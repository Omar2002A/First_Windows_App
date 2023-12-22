namespace POS.forms
{
    partial class ProductsView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sfDataGrid2 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.btn_admre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sfDataGrid2
            // 
            this.sfDataGrid2.AccessibleName = "Table";
            this.sfDataGrid2.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfDataGrid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGrid2.Location = new System.Drawing.Point(0, 0);
            this.sfDataGrid2.Name = "sfDataGrid2";
            this.sfDataGrid2.Size = new System.Drawing.Size(746, 450);
            this.sfDataGrid2.TabIndex = 0;
            this.sfDataGrid2.Text = "sfDataGrid2";
            this.sfDataGrid2.Click += new System.EventHandler(this.sfDataGrid2_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.gradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.gradientPanel1.Controls.Add(this.btn_admre);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 370);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(746, 80);
            this.gradientPanel1.TabIndex = 1;
            // 
            // btn_admre
            // 
            this.btn_admre.BackColor = System.Drawing.SystemColors.Window;
            this.btn_admre.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_admre.FlatAppearance.BorderSize = 0;
            this.btn_admre.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_admre.Location = new System.Drawing.Point(618, 0);
            this.btn_admre.Name = "btn_admre";
            this.btn_admre.Size = new System.Drawing.Size(124, 76);
            this.btn_admre.TabIndex = 6;
            this.btn_admre.Text = "ADD MORE ...";
            this.btn_admre.UseVisualStyleBackColor = false;
            this.btn_admre.Click += new System.EventHandler(this.btn_admre_Click);
            // 
            // ProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.ControlBox = false;
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.sfDataGrid2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductsView";
            this.Text = "ProductsView";
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid2;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private System.Windows.Forms.Button btn_admre;
    }
}