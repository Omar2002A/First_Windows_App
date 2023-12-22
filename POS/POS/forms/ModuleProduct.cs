using System.Windows.Forms;
using System.Data.SqlClient;

namespace POS.forms
{
    public partial class ModuleProduct : Form
    {
        static string databaseFileName = "Database1.mdf"; // Replace with your actual MDF file name
        static string databasePath = System.IO.Path.Combine(Application.StartupPath, databaseFileName);

        string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={databasePath}";
        SqlConnection connection = new SqlConnection();

        public ModuleProduct()
        {
            InitializeComponent();
            string Sql = "select CategoryName from tbCategory";
            connection.ConnectionString = connectionString;
            SqlCommand cmd = new SqlCommand(Sql, connection);
            connection.Open();
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                ctDropDown.Items.Add(DR[0]);
            }
            connection.Close();
        }
        private void btnInsert_Click(object sender, System.EventArgs e)
        { 
            //get category id where category name is equal to selected category name
            string Sql = "select CategoryID from tbCategory where CategoryName='" + ctDropDown.Text + "'";
            connection.ConnectionString = connectionString;
            SqlCommand cmd = new SqlCommand(Sql, connection);
            connection.Open();
            SqlDataReader DR = cmd.ExecuteReader();
            DR.Read();
            string CategoryID = DR[0].ToString();
            connection.Close();
            // make productID auto increment
            string Sql1 = "select max(ProductID) from tbProduct";
            connection.Open();
            SqlCommand cmd1 = new SqlCommand(Sql1, connection);
            SqlDataReader DR1 = cmd1.ExecuteReader();
            DR1.Read();
            string ProductID = DR1[0].ToString();
            connection.Close();
            
            connection.ConnectionString = connectionString;

            //change cost price and selling price to decimal of 3 digits after decimal point
            txtCost.Text = string.Format("{0:0.000}", txtCost.Text);
            txtPrice.Text = string.Format("{0:0.000}", txtPrice.Text);
            //insert data into tbProduct
            string a = "insert into tbProduct(ProductName,CostPrice,SellingPrice,CategoryID,Describtion,barcode,QtyOnHand) values('"+ txtProductName.Text + "','" + txtCost.Text + "','" + txtPrice.Text + "','" + CategoryID + "','" + txtDescribtion.Text + "','" + hintTextBox4.Text + "','" + txtQuantity.Text + "')";
            

            connection.ConnectionString = connectionString;
            cmd = new SqlCommand(a, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Data Inserted Successfully");
        }

        private void btnclear_Click(object sender, System.EventArgs e)
        {
            txtProductName.Text = "";
            txtCost.Text = ""; 
            txtPrice.Text = "";
            ctDropDown.Text = "";
            txtDescribtion.Text = "";
            hintTextBox4.Text = "";
            txtQuantity.Text = "";
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
