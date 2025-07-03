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
    public partial class fTicketManage : Form
    {
        private string connectionString = "Data Source=LAPTOP-7CGT11A5;Initial Catalog=PhongVeMayBay;Integrated Security=True";
        public fTicketManage()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fTicketManage_Load(object sender, EventArgs e)
        {
            LoadTicket();
            addTicketBinding();
        }
        BindingSource listTicket = new BindingSource();
        void LoadTicket()
        {
            string query = "select Ticket.idTicket, Ticket.idFlight, Ticket.namePassenger, Ticket.Passport, Ticket.price, Plane.seat from Ticket join Flight on Ticket.idFlight = Flight.idFlight join Plane on Flight.idPlane = Plane.idPlane;";
            Function fuction = new Function();
            listTicket.DataSource = fuction.LoadDataGridView(query);
            dtgvTicket.DataSource = listTicket;
        }
        void addTicketBinding()
        {
            txtIdTicket.DataBindings.Add("Text", dtgvTicket.DataSource, "idTicket");
            TxtIdFlight.DataBindings.Add("Text", dtgvTicket.DataSource, "idFlight");
            txtNamePassenger.DataBindings.Add("Text", dtgvTicket.DataSource, "namePassenger");
            txtPassport.DataBindings.Add("Text", dtgvTicket.DataSource, "Passport");
            txtPriceTicket.DataBindings.Add("Text", dtgvTicket.DataSource, "price");
            TxtSeat.DataBindings.Add("Text", dtgvTicket.DataSource, "seat");
        }

        private void btnSearchTicket_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchTicket.Text.Trim();

            if (!string.IsNullOrEmpty(keyword))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "select Ticket.idTicket as N'Mã số vé', Ticket.idFlight as N'Mã chuyến bay', Ticket.namePassenger as N'Tên hành khách', Ticket.Passport, Ticket.price as N'Giá vé', Plane.seat as 'Hạng vé' from Ticket join Flight on Ticket.idFlight = Flight.idFlight join Plane on Flight.idPlane = Plane.idPlane where namePassenger like @Keyword";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dtgvTicket.DataSource = dataTable;
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
