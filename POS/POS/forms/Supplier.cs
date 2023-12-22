﻿using System;
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
    public partial class Supplier : Form
    {

        static string databaseFileName = "Database1.mdf"; // Replace with your actual MDF file name
        static string databasePath = System.IO.Path.Combine(Application.StartupPath, databaseFileName);

        string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={databasePath};Integrated Security=True";
        SqlConnection connection = new SqlConnection();

        public Supplier()
        {
            InitializeComponent();
        }


        private void btn_insrt_Click(object sender, EventArgs e)
        {
            connection.ConnectionString = connectionString;
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into tbSupplier(SupplierName,ContactInfo,Address) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Supplier Inserted Successfully");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
