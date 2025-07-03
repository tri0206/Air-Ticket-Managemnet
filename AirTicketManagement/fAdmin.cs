using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace AirTicketOfficeManagement
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void tcAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dtgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private string connectionString = "Data Source=LAPTOP-7CGT11A5;Initial Catalog=PhongVeMayBay;Integrated Security=True";
        private void btnViewStaff_Click(object sender, EventArgs e)
        {

            LoadViewStaff();
        }
        private void LoadViewStaff()
        {
            string query = "select * from Staff";
            Function function = new Function();
            listStaff.DataSource = function.LoadDataGridView(query);
            dtgvStaff.DataSource = listStaff;
        }
        void addStaffBinding()
        {
            txtIDStaff.DataBindings.Add("Text", dtgvStaff.DataSource, "idStaff");
            txtNameStaff.DataBindings.Add("Text", dtgvStaff.DataSource, "nameStaff");
            dtpkStaff.DataBindings.Add("Text", dtgvStaff.DataSource, "dobStaff");
            txtUserNameStaff.DataBindings.Add("Text", dtgvStaff.DataSource, "UserName");
            txtPassWordStaff.DataBindings.Add("Text", dtgvStaff.DataSource, "passWord");
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        BindingSource listStaff = new BindingSource();
        private void fAdmin_Load(object sender, EventArgs e)
        {
            dtgvStaff.DataSource = listStaff;
            LoadViewStaff();
            addStaffBinding();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIDStaff.Text);
            string name = txtNameStaff.Text;
            DateTime dob = dtpkStaff.Value;
            string username = txtUserNameStaff.Text;
            string password = txtPassWordStaff.Text;
            if (addStaff(id, name, dob, username, password))
            {
                MessageBox.Show("Thêm thành công!");
                LoadViewStaff();
            }
        }
        bool addStaff(int id, string name, DateTime dob, string username, string password)
        {
            string query = String.Format("insert Staff(idStaff, nameStaff, dobStaff, UserName, passWord) values( {0}, N'{1}', @date, '{2}', '{3}')", id, name, username, password);
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@date", dob);
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
                return false;
            }
        }

        private void btnFixStaff_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIDStaff.Text);
            string name = txtNameStaff.Text;
            DateTime dob = dtpkStaff.Value;
            string username = txtUserNameStaff.Text;
            string password = txtPassWordStaff.Text;
            if (UpdateStaff(id, name, dob, username, password))
            {
                MessageBox.Show("Sửa thành công!");
                LoadViewStaff();
            }
        }
        bool UpdateStaff(int id, string name, DateTime dob, string username, string password)
        {
            string query = string.Format("update staff set nameStaff = N'{0}', dobStaff = '{1}', UserName = '{2}', passWord = '{3}' where idStaff = {4}", name, dob, username, password, id);
            Function function = new Function();
            int result = function.OperationCRUD(query);
            return result > 0;
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIDStaff.Text);
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (DeleteStaff(id))
                {
                    MessageBox.Show("Xóa thành công!!");
                    LoadViewStaff();
                }
            }
        }
        bool DeleteStaff(int id)
        {
            string query = string.Format("delete from Staff where idStaff = {0}", id);
            Function function = new Function();
            int result = function.OperationCRUD(query);
            return result > 0;
        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            string keyword = txtFindStaff.Text.Trim();

            if (!string.IsNullOrEmpty(keyword))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "select * from Staff where nameStaff like @Keyword or idStaff like @Keyword";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dtgvStaff.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(cbDays.SelectedItem);
            int month = Convert.ToInt32(cbMonths.SelectedItem);
            int year = Convert.ToInt32(cbYears.SelectedItem);
            decimal TotalPrice = Total(day, month, year);
            txtTotalPrice.Text = TotalPrice.ToString();
            LoadReport(day, month, year);
        }

        decimal Total(int day, int month, int year)
        {
            string dateString1, dateString2;
            if(month < 10)
            {
                dateString1 = string.Concat(year, "-", '0', month, "-", day);
                dateString2 = string.Concat(year, "-", '0', month);
            }
            else
            {
                dateString1 = string.Concat(year, "-", month, "-", year);
                dateString2 = string.Concat(year, "-", month);
            }
            decimal sum = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = string.Empty;
                if (day != 0 && month != 0 && year != 0)
                {
                    query = $"SELECT SUM(price) FROM Ticket JOIN Bill ON Ticket.idTicket = Bill.idTicket WHERE Bill.dateBuy LIKE '{dateString1}%'";
                }
                else if (day == 0 && month != 0 && year != 0)
                {
                    query = $"SELECT SUM(price) FROM Ticket JOIN Bill ON Ticket.idTicket = Bill.idTicket WHERE Bill.dateBuy LIKE '{dateString2}%'";
                }
                else if (day == 0 && month == 0 && year != 0)
                {
                    query = $"SELECT SUM(price) FROM Ticket JOIN Bill ON Ticket.idTicket = Bill.idTicket WHERE Bill.dateBuy LIKE '{year}%'";
                }

                if (!string.IsNullOrEmpty(query))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        sum = Convert.ToDecimal(result);
                    }
                }
            }

            return sum;
        }
        void LoadReport(int day, int month, int year)
        {
            string dateString1 = string.Concat(year, "-", '0', month, '0', "-", day);
            string dateString2 = string.Concat(year, "-", '0', month);
            Function function = new Function();
            if (day != 0 && month != 0 && year != 0)
            {
                dtgvReport.DataSource = function.LoadDataGridView($"select Ticket.idTicket, Ticket.idFlight, Ticket.namePassenger, Ticket.Passport, Ticket.price, Flight.dayFly, Bill.dateBuy from Ticket join Bill on Ticket.idTicket = Bill.idTicket join Flight on Ticket.idFlight = Flight.idFlight where dateBuy like '{dateString1}%'");
            }
            else if (day == 0 && month != 0 && year != 0)
            {
                dtgvReport.DataSource = function.LoadDataGridView($"select Ticket.idTicket, Ticket.idFlight, Ticket.namePassenger, Ticket.Passport, Ticket.price, Flight.dayFly, Bill.dateBuy from Ticket join Bill on Ticket.idTicket = Bill.idTicket join Flight on Ticket.idFlight = Flight.idFlight where dateBuy like '{dateString2}%'");
            }
            else if (day == 0 && month == 0 && year != 0)
            {
                dtgvReport.DataSource = function.LoadDataGridView($"select Ticket.idTicket, Ticket.idFlight, Ticket.namePassenger, Ticket.Passport, Ticket.price, Flight.dayFly, Bill.dateBuy from Ticket join Bill on Ticket.idTicket = Bill.idTicket join Flight on Ticket.idFlight = Flight.idFlight where dateBuy like '{year}%'");

            }

        }
        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDStaff_TextChanged(object sender, EventArgs e)
        {

        }
    }
}