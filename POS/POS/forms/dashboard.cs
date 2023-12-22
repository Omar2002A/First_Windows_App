using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.forms
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();

        }

        private void btn_cash_Click(object sender, EventArgs e)
        {
            Cash cash = new Cash();
            gradientPanel1.Controls.Clear();
            cash.TopLevel = false;
            gradientPanel1.Controls.Add(cash);
            cash.Show();
        }

        private void btn_prdct_Click(object sender, EventArgs e)
        {
            ProductsView products = new ProductsView();
            gradientPanel1.Controls.Clear();
            products.TopLevel = false;
            gradientPanel1.Controls.Add(products);
            products.Dock = DockStyle.Fill;
            products.Show();
        }

        private void btn_ctg_Click(object sender, EventArgs e)
        {
            CategorysView categorys = new CategorysView();
            gradientPanel1.Controls.Clear();
            categorys.TopLevel = false;
            gradientPanel1.Controls.Add(categorys);
            categorys.Dock = DockStyle.Fill;
            categorys.Show();
        }

        private void btn_supplier_Click(object sender, EventArgs e)
        {
            SupplierViews supplier = new SupplierViews();
            gradientPanel1.Controls.Clear();
            supplier.TopLevel = false;
            gradientPanel1.Controls.Add(supplier);
            supplier.Dock = DockStyle.Fill;
            supplier.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }



    }
}
