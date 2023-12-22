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
    public partial class ProductsView : Form
    {
        static string databaseFileName = "Database1.mdf"; // Replace with your actual MDF file name
        static string databasePath = System.IO.Path.Combine(Application.StartupPath, databaseFileName);

        string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={databasePath};Integrated Security=True";
        SqlConnection connection = new SqlConnection();
        public ProductsView()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tbProduct", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                sfDataGrid2.DataSource = table;
                connection.Close();
            }
        }

        private void btn_admre_Click(object sender, EventArgs e)
        {
            ModuleProduct p = new ModuleProduct();
            p.Show();
        }

        private void sfDataGrid2_Click(object sender, EventArgs e)
        {

        }
    }
}
