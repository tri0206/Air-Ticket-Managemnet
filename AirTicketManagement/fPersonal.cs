using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Xml.Linq;

namespace AirTicketOfficeManagement
{

    public partial class fPersonal : Form
    {
        private string connectionString = "Data Source=LAPTOP-7CGT11A5;Initial Catalog=PhongVeMayBay;Integrated Security=True";
        public fPersonal()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string password = txtChangePassword.Text;
            int id = int.Parse(txtPersonalId.Text);
            if (!string.IsNullOrEmpty(txtChangePassword.Text))
            {
                if(changePassword(password, id)) {
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    viewPersonal();
                    txtChangePassword.Text = " ";
                }
                else
                {
                    MessageBox.Show("Có lỗi!!");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập mật khẩu mới!");
            }
        }

        private void fPersonal_Load(object sender, EventArgs e)
        {
            viewPersonal();
        }
        void viewPersonal()
        {
            string username = fLogin.LogginUsername;
            string query = string.Format("select * from Staff where Username = '{0}'", username);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", username);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {

                        txtPersonalId.Text = reader["idStaff"].ToString();
                        txtPersonalName.Text = reader["nameStaff"].ToString();
                        txtPersonalDob.Text = reader["dobStaff"].ToString();
                        txtPersonalUsername.Text = reader["UserName"].ToString();
                        txtOldPass.Text = reader["passWord"].ToString();
                    }
                }
            }
        }
        bool changePassword(string password, int id)
        {
            string query = string.Format("Update Staff set passWord = '{0}' where idStaff = {1}", password, id);
            Function function = new Function();
            int result = function.OperationCRUD(query);
            return result > 0;
        }

        private void txtPersonalId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
