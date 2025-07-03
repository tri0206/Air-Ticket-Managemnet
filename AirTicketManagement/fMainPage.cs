using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static AirTicketOfficeManagement.ApplicationData;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
namespace AirTicketOfficeManagement
{
    public partial class fMainPage : Form
    {
        private string connectionString = "Data Source=LAPTOP-7CGT11A5;Initial Catalog=PhongVeMayBay;Integrated Security=True";

        public fMainPage()
        {
            InitializeComponent();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void liênHệHotline0ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Text.Trim();

            if (!string.IsNullOrEmpty(keyword))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "select Flight.idFlight, Flight.dayFly, Flight.idPlane, Plane.type, Plane.airline, AirportGo.nameAirport, AirportArr.nameAirport from Flight join Plane on Flight.idPlane = Plane.idPlane join Airport as AirportGo on Flight.idAirportGo = AirportGo.idAirport join Airport as AirportArr on Flight.idAirportArrival = AirportArr.idAirport where AirportGo.nameAirport like @Keyword or AirportArr.nameAirport like @Keyword";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dtgvFlight.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadFlightSchedule()
        {
            string query = "select Flight.idFlight, Flight.dayFly, Flight.idPlane, Plane.type, Plane.airline, AirportGo.nameAirport, AirportArr.nameAirport from Flight join Plane on Flight.idPlane = Plane.idPlane join Airport as AirportGo on Flight.idAirportGo = AirportGo.idAirport join Airport as AirportArr on Flight.idAirportArrival = AirportArr.idAirport";
            Function function = new Function();
            dtgvFlight.DataSource = function.LoadDataGridView(query);
        }
        BindingSource listTicket = new BindingSource();
        private void fMainPage_Load_1(object sender, EventArgs e)
        {
            dtgvBuyTicket.DataSource = listTicket;
            LoadFlightSchedule();
            if (ApplicationData.isAdmin == false)
            {
                btnAdmin.Enabled = false;
            }
            LoadAirport();
            addAirportBinding();
            LoadTicketAndBill();
            addTicketBinding();
            viewIdStaff();
        }
        private void dtgvFlight_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            tc1.SelectedTab = tpBuyTicket;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }
        private void Logout()
        {
            fLogin a = new fLogin();
            a.Show();
            this.Close();
        }
        private void btnExitt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMyself_Click(object sender, EventArgs e)
        {
            fPersonal f = new fPersonal();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnFlightManage_Click(object sender, EventArgs e)
        {
            fPlaneManage f = new fPlaneManage();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fBill f = new fBill();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnTicketManage_Click(object sender, EventArgs e)
        {
            fTicketManage f = new fTicketManage();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnViewFlight_Click(object sender, EventArgs e)
        {
            LoadFlightSchedule();
        }

        private void btnSearchAirport_Click(object sender, EventArgs e)
        {
            string keyword_1 = txtAirport.Text.Trim();

            if (!string.IsNullOrEmpty(keyword_1))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "select * from Airport where nameAirport like @Keyword_1 or nation like @Keyword_1";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Keyword_1", "%" + keyword_1 + "%");
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dtgvAirport.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnViewAirport_Click(object sender, EventArgs e)
        {
            LoadAirport();
        }

        BindingSource listAirport = new BindingSource();
        void LoadAirport()
        {
            string query = "select * from Airport";
            Function function = new Function();
            listAirport.DataSource = function.LoadDataGridView(query);
            dtgvAirport.DataSource = listAirport;
        }

        private void btnAddAirport_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIDAirport.Text);
            string name = txtNameAirport.Text;
            string nation = cbNation.Text;
            if (addAirport(id, name, nation))
            {
                MessageBox.Show("Thêm thành công!");
                LoadAirport();
            }
        }
        private bool addAirport(int id, string name, string nation)
        {
            string query = string.Format("insert Airport(idAirport, nameAirport, nation) values ({0}, N'{1}', N'{2}')", id, name, nation);
            Function function = new Function();
            int result = function.OperationCRUD(query);
            return result > 0;
        }
        private bool FixAirport(int id, string name, string nation)
        {
            string query = String.Format("Update Airport set nameAirport = N'{0}', nation = N'{1}' where idAirport = {2}", name, nation, id);
            Function function = new Function();
            int result = function.OperationCRUD(query);
            return result > 0;
        }
        private void btnFixAirport_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIDAirport.Text);
            string name = txtNameAirport.Text;
            string nation = cbNation.Text;
            if (FixAirport(id, name, nation))
            {
                MessageBox.Show("Sửa dữ liệu thành công");
                LoadAirport();
            }
        }
        private bool DeleteAirport(int id)
        {
            string query = String.Format("delete from Airport where idAirport = {0}", id);
            Function function = new Function();
            int result = function.OperationCRUD(query);
            return result > 0;
        }

        private void btnDeleteAirport_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sân bay này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (DeleteAirport(int.Parse(txtIDAirport.Text)))
                {
                    MessageBox.Show("Xóa thành công!!");
                    LoadAirport();
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassport_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheckFlight_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCheckFlight.Text);
            checkPlace(id);
        }
        void checkPlace(int id)
        {
            string query = string.Format("select AirportGo.nameAirport, AirportArr.nameAirport from Flight join Airport as AirportGo on Flight.idAirportGo = AirportGo.idAirport join Airport as AirportArr on Flight.idAirportArrival = AirportArr.idAirport where Flight.idFlight = {0}", id);
            Function function = new Function();
            dtgvPlace.DataSource = function.LoadDataGridView(query);
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            int idTicket = int.Parse(txtIdTicket.Text);
            int idFlight = int.Parse(txtCheckFlight.Text);
            string name = txtNamePassenger.Text;
            int idStaff = int.Parse(txtStaffBuyTicket.Text);
            string passport = txtPassport.Text;
            int price = int.Parse(txtPrice.Text);
            DateTime dateTime = DateTime.Now;
            if (addTicket(idTicket, idFlight, name, passport, price) && addBill(idTicket, idStaff, dateTime))
            {
                MessageBox.Show("Mua vé thành công!!");
                LoadTicketAndBill();
            }
        }
        private bool addTicket(int idTicket, int idFlight, string name, string passport, int price)
        {
            string query = string.Format("insert Ticket(idTicket, idFlight, namePassenger, Passport, price) values ({0}, {1}, N'{2}', N'{3}', {4})", idTicket, idFlight, name, passport, price);
            Function function = new Function();
            int result = function.OperationCRUD(query);
            return result > 0;
        }
        private bool addBill(int idTicket, int idStaff, DateTime dateTime)
        {
            string query = string.Format("insert Bill(idTicket, idStaff, dateBuy) values({0}, {1}, GETDATE())", idTicket, idStaff);
            Function function = new Function();
            int result = function.OperationCRUD(query);
            return result > 0;
        }
        BindingSource bindingSource = new BindingSource();

        void LoadTicketAndBill()
        {
            Function function = new Function();
            string query = "select Ticket.idTicket, Ticket.idFlight, Ticket.namePassenger, Ticket.Passport, Ticket.price, Staff.nameStaff, dateBuy from Bill join Ticket on Bill.idTicket = Ticket.idTicket join Staff on Bill.idStaff = Staff.idStaff;";
            bindingSource.DataSource = function.LoadDataGridView(query);
            dtgvBuyTicket.DataSource = bindingSource;
        }

        private void fill(object sender, DataGridViewAutoSizeColumnsModeEventArgs e)
        {

        }

        private void btnUpdateTicket_Click(object sender, EventArgs e)
        {
            int idTicket = int.Parse(txtIdTicket.Text);
            int idFlight = int.Parse(txtCheckFlight.Text);
            string name = txtNamePassenger.Text;
            string passport = txtPassport.Text;
            int price = int.Parse(txtPrice.Text);
            DateTime dateTime = DateTime.Now;
            int idStaff = int.Parse(txtStaffBuyTicket.Text);
            if (UpdateTicket(idTicket, idFlight, name, passport, price))
            {
                MessageBox.Show("Sửa vé thành công!!");
                LoadTicketAndBill();
            }
        }
        bool UpdateTicket(int idTicket, int idFlight, string name, string passport, int price)
        {
            string query = String.Format("Update Ticket set idFlight = {0}, namePassenger = N'{1}', passport = N'{2}', price = {3} where idTicket = {4}", idFlight, name, passport, price, idTicket);
            Function function = new Function();
            int result = function.OperationCRUD(query);
            return result > 0;
        }
        void addTicketBinding()
        {
            txtIdTicket.DataBindings.Add("Text", dtgvBuyTicket.DataSource, "idTicket");
            txtCheckFlight.DataBindings.Add("Text", dtgvBuyTicket.DataSource, "idFlight");
            txtNamePassenger.DataBindings.Add("Text", dtgvBuyTicket.DataSource, "namePassenger");
            txtPassport.DataBindings.Add("Text", dtgvBuyTicket.DataSource, "Passport");
            txtPrice.DataBindings.Add("Text", dtgvBuyTicket.DataSource, "price");
        }
        void addAirportBinding()
        {
            txtIDAirport.DataBindings.Add("Text", dtgvAirport.DataSource, "idAirport");
            txtNameAirport.DataBindings.Add("Text", dtgvAirport.DataSource, "nameAirport");
            cbNation.DataBindings.Add("Text", dtgvAirport.DataSource, "nation");
        }

        private void btnDeleteTicket_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy vé?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeleteTicket(int.Parse(txtIdTicket.Text));
                MessageBox.Show("Xóa thành công!!");
                LoadTicketAndBill();
            }
        }
        private void DeleteTicket(int id)
        {
            string query = String.Format("delete from Bill where idTicket = {0}", id);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            string query1 = String.Format("delete from Ticket where idTicket = {0}", id);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void txtStaffBuyTicket_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFlightManage_Click_1(object sender, EventArgs e)
        {

        }

        private void btnFlightManage_Click_2(object sender, EventArgs e)
        {
            FlightManage f = new FlightManage();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        void viewIdStaff()
        {
            string username = fLogin.LogginUsername;
            string query = string.Format("select Staff.idStaff from Staff where Username = '{0}'", username);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", username);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {

                        txtStaffBuyTicket.Text = reader["idStaff"].ToString();

                    }
                }
            }
        }
    }
}
