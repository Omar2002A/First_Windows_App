using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace POS.forms
{
    public partial class Login : Form
    {
        static string databaseFileName = "Database1.mdf"; // Replace with your actual MDF file name
        static string databasePath = System.IO.Path.Combine(Application.StartupPath, databaseFileName);

        string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={databasePath};Integrated Security=True";
        SqlConnection connection = new SqlConnection();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBoxExt1_Enter(object sender, EventArgs e)
        {
            if(textBoxExt1.Text == "Username")
            {
                textBoxExt1.Text = "";
                textBoxExt1.ForeColor = Color.Black;
            }
        }

        private void textBoxExt1_Leave(object sender, EventArgs e)
        {
            if(textBoxExt1.Text == "")
            {
                textBoxExt1.Text = "Username";
                textBoxExt1.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if(txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if(txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM tbUser WHERE UserName = @Username AND Password = @Password";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", textBoxExt1.Text);
                command.Parameters.AddWithValue("@Password", txtPassword.Text);
                connection.ConnectionString = connectionString;
                connection.Open();

                int count = (int)command.ExecuteScalar(); // ExecuteScalar() returns the count of matching rows

                if (count > 0)
                {
                    dashboard dashboard = new dashboard();
                    this.Hide();
                    
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
                connection.Close();
            }
        }

        private void textBoxExt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
