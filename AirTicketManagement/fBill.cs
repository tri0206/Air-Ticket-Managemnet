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
    public partial class fBill : Form
    {
        private string connectionString = "Data Source=LAPTOP-7CGT11A5;Initial Catalog=PhongVeMayBay;Integrated Security=True";
        public fBill()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        BindingSource listBill = new BindingSource();
        void addBillBinding()
        {
            txtIdBill.DataBindings.Add("Text", dtgvBill.DataSource, "id");
            txtNamePassenger.DataBindings.Add("Text", dtgvBill.DataSource, "namePassenger");
            txtIdTicket.DataBindings.Add("Text", dtgvBill.DataSource, "idTicket");
            txtDateBuy.DataBindings.Add("Text", dtgvBill.DataSource, "dateBuy");
            txtPrice.DataBindings.Add("Text", dtgvBill.DataSource, "price");

        }
        void LoadBill()
        {
            string query = "select Bill.id, Bill.dateBuy, Ticket.namePassenger, Ticket.price, Ticket.idTicket from Bill join Ticket on Bill.idTicket = Ticket.idTicket";
            Function function = new Function();
            listBill.DataSource = function.LoadDataGridView(query);
            dtgvBill.DataSource = listBill;
        }
        private void fBill_Load(object sender, EventArgs e)
        {
            LoadBill();
            addBillBinding();

        }

        private void btnSearchBill_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchBill.Text.Trim();

            if (!string.IsNullOrEmpty(keyword))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "select Bill.id, Bill.dateBuy, Ticket.namePassenger, Ticket.price, Ticket.idTicket from Bill join Ticket on Bill.idTicket = Ticket.idTicket where Bill.id like @Keyword or Ticket.namePassenger like @Keyword or Ticket.idTicket like @Keyword";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dtgvBill.DataSource = dataTable;
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
