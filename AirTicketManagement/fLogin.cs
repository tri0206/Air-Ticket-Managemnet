using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using static AirTicketOfficeManagement.ApplicationData;

namespace AirTicketOfficeManagement
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        public static string LogginUsername;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            string password = txbPassWord.Text;
            if (username == "Admin")
            {
                isAdmin = true;
            }
            else
            {
                isAdmin = false;
            }
            if (CheckCredentials(username, password))
            {
                MessageBox.Show("Đăng nhập thành công!");
                LogginUsername = username;
                fMainPage f = new fMainPage();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
        }
        private bool CheckCredentials(string username, string password)
        {
            string connectionString = "Data Source=LAPTOP-7CGT11A5;Initial Catalog=PhongVeMayBay;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Staff WHERE Username = @UserName AND Password = @passWord";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", username);
                command.Parameters.AddWithValue("@passWord", password);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}