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
    public partial class CategorysView : Form
    {

        static string databaseFileName = "Database1.mdf"; // Replace with your actual MDF file name
        static string databasePath = System.IO.Path.Combine(Application.StartupPath, databaseFileName);

        string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={databasePath};Integrated Security=True";
        SqlConnection connection = new SqlConnection();

        public CategorysView()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tbCategory", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DGView1.DataSource = table;
                connection.Close();
            }
        }

        private void btn_addmore_Click(object sender, EventArgs e)
        {
            Categorymediol categorymediol = new Categorymediol();
            categorymediol.Show();
        }

        private void DGView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
