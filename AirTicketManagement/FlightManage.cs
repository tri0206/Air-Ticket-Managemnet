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
using static AirTicketOfficeManagement.Function;

namespace AirTicketOfficeManagement
{
    public partial class FlightManage : Form
    {
        private string connectionString = "Data Source=LAPTOP-7CGT11A5;Initial Catalog=PhongVeMayBay;Integrated Security=True";
        public FlightManage()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        void LoadFlight()
        {
            string query = "select * from Flight";
            Function function = new Function();
            listFlight.DataSource = function.LoadDataGridView(query);
            dtgvFlight.DataSource = listFlight;
        }
        BindingSource listFlight = new BindingSource();
        void addFlightBinding()
        {
            txtIdFlight.DataBindings.Add("Text", dtgvFlight.DataSource, "idFlight");
            txtIdPlane.DataBindings.Add("Text", dtgvFlight.DataSource, "idPlane");
            txtIdAirportGo.DataBindings.Add("Text", dtgvFlight.DataSource, "idAirportGo");
            txtIdAirportArrival.DataBindings.Add("Text", dtgvFlight.DataSource, "idAirportArrival");
            dtpkDayFly.DataBindings.Add("Text", dtgvFlight.DataSource, "dayFly");
        }

        private void FlightManage_Load(object sender, EventArgs e)
        {
            LoadFlight();
            addFlightBinding();
        }

        private void btnViewFlight_Click(object sender, EventArgs e)
        {
            LoadFlight();
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            int idFlight = int.Parse(txtIdFlight.Text);
            int idPlane = int.Parse(txtIdPlane.Text);
            int idAirportGo = int.Parse(txtIdAirportGo.Text);
            int idAirportArrival = int.Parse(txtIdAirportArrival.Text);
            DateTime dayFly = dtpkDayFly.Value;
            if (addFlight(idFlight, idPlane, idAirportGo, idAirportArrival, dayFly))
            {
                MessageBox.Show("Thêm thành công!!");
                LoadFlight();
            };
        }

        bool addFlight(int idFlight, int idPlane, int idAirportGo, int idAirportArrival, DateTime dayFly)
        {
            string query = String.Format("insert Flight(idFlight, idPlane, idAirportGo, idAirportArrival, dayFly) values( {0}, {1}, {2}, {3}, @date)", idFlight, idPlane, idAirportGo, idAirportArrival);
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    command.Parameters.AddWithValue("@date", dayFly);
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
        bool deleteFlight(int id)
        {
            string query = String.Format("delete from Flight where idFlight = {0}", id);
            Function function = new Function();
            int result = function.OperationCRUD(query);
            return result > 0;
        }
        bool updateFlight(int idFlight, int idPlane, int idAirportGo, int idAirportArrival, DateTime dayFly)
        {
            string query = String.Format("update Flight set idPlane = {0}, idAirportGo = {1}, idAirportArrival = {2}, dayFly = '{3}' where idFlight = {4}", idPlane, idAirportGo, idAirportArrival, dayFly, idFlight);
            Function function = new Function();
            int result = function.OperationCRUD(query);
            return result > 0;
        }
        private void btnDeleteFlight_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdFlight.Text);
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (deleteFlight(id))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadFlight();
                }
            }
        }

        private void btnUpdateFlight_Click(object sender, EventArgs e)
        {
            int idFlight = int.Parse(txtIdFlight.Text);
            int idPlane = int.Parse(txtIdPlane.Text);
            int idAirportGo = int.Parse(txtIdAirportGo.Text);
            int idAirportArrival = int.Parse(txtIdAirportArrival.Text);
            DateTime dayFly = dtpkDayFly.Value;
            if (updateFlight(idFlight, idPlane, idAirportGo, idAirportArrival, dayFly))
            {
                MessageBox.Show("Sửa thành công!");
                LoadFlight();
            }
        }

        private void btnSearchFlight_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchFlight.Text.Trim();

            if (!string.IsNullOrEmpty(keyword))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "select * from Flight where idFlight like @Keyword or idPlane like @Keyword or idAirportGo like @Keyword or idAirportArrival like @Keyword or dayFly like @Keyword";
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
    }
}
