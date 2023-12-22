using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POS.forms
{
    public partial class Categorymediol : Form
    {
        static string databaseFileName = "Database1.mdf"; // Replace with your actual MDF file name
        static string databasePath = System.IO.Path.Combine(Application.StartupPath, databaseFileName);

        string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={databasePath};Integrated Security=True";
        SqlConnection connection = new SqlConnection();

        public Categorymediol()
        {
            InitializeComponent();
        }

        private void btn_insrt_Click(object sender, EventArgs e)
        {
           //insert category name into tbl_category
           connection.ConnectionString = connectionString;
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into tbCategory(categoryname) values('" + textBox1.Text + "')", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Category Inserted Successfully");
            textBox1.Clear();
        }

      

        private void btn_ext_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
