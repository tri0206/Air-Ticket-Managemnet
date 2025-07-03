using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace AirTicketOfficeManagement
{
    public partial class fPlaneManage : Form
    {
        private string connectionString = "Data Source=LAPTOP-7CGT11A5;Initial Catalog=PhongVeMayBay;Integrated Security=True";
        BindingSource listPlane = new BindingSource();
        public fPlaneManage()
        {
            InitializeComponent();
        }

        private void btnViewPlane_Click(object sender, EventArgs e)
        {
            LoadPlane();
        }
        void LoadPlane()
        {
            string query = "select * from Plane";
            Function function = new Function();
            listPlane.DataSource = function.LoadDataGridView(query);
            dtgvPlane.DataSource = listPlane;
        }

        private void fPlaneManage_Load(object sender, EventArgs e)
        {
            LoadPlane();
            addPlaneBinding();
        }

        private void btnAddPlane_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdPlane.Text);
            string type = txtType.Text;
            string airline = txtAirline.Text;
            int seat = int.Parse(txtSeat.Text);
            if(addPlane(id, type, airline, seat))
            {
                MessageBox.Show("Thêm thành công!");
                LoadPlane();
            }
        }
        bool addPlane(int id, string type, string airline, int seat)
        {
            string query = string.Format("insert Plane(idPlane, type, airline, seat) values ({0}, N'{1}', N'{2}', {3})", id, type, airline, seat);
            Function function = new Function();
            int result = function.OperationCRUD(query);
            return result > 0;
        }
        void addPlaneBinding()
        {
            txtIdPlane.DataBindings.Add("Text", dtgvPlane.DataSource, "idPlane");
            txtType.DataBindings.Add("Text", dtgvPlane.DataSource, "type");
            txtAirline.DataBindings.Add("Text", dtgvPlane.DataSource, "airline");
            txtSeat.DataBindings.Add("Text", dtgvPlane.DataSource, "seat");

        }
        private void btnUpdatePlane_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdPlane.Text);
            string type = txtType.Text;
            string airline = txtAirline.Text;
            int seat = int.Parse(txtSeat.Text);
            if(UpdatePlane(id, type, airline, seat))
            {
                MessageBox.Show("Sửa thành công!");
                LoadPlane();
            }
        }
        bool UpdatePlane(int id, string type, string airline, int seat)
        {
            string query = string.Format("update Plane set type = '{0}', airline = '{1}', seat = {2} where idPlane = {3}", type, airline, seat, id);
            Function function = new Function();
            int result = function.OperationCRUD(query);
            return result > 0;
        }

        private void btnDeletePlane_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa máy bay này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if(deletePlane(int.Parse(txtIdPlane.Text)))
                {
                    MessageBox.Show("Xóa thành công!!");
                    LoadPlane();
                }
            }
        }
        bool deletePlane(int id)
        {
            string query = string.Format("delete Plane where idPlane = {0}", id);
            Function function = new Function();
            int result = function.OperationCRUD(query);
            return result > 0;
        }

        private void btnSearchPlane_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchPlane.Text.Trim();

            if (!string.IsNullOrEmpty(keyword))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "select * from Plane where idPlane like @Keyword or airline like @Keyword or type like @Keyword";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dtgvPlane.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
