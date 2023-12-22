namespace POS.forms
{
    partial class CategorysView
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
            this.DGView1 = new System.Windows.Forms.DataGridView();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.btn_addmore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGView1
            // 
            this.DGView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGView1.Location = new System.Drawing.Point(0, 0);
            this.DGView1.Name = "DGView1";
            this.DGView1.Size = new System.Drawing.Size(800, 450);
            this.DGView1.TabIndex = 0;
            this.DGView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGView1_CellContentClick);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.gradientPanel1.Controls.Add(this.btn_addmore);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 370);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(800, 80);
            this.gradientPanel1.TabIndex = 1;
            // 
            // btn_addmore
            // 
            this.btn_addmore.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_addmore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addmore.Location = new System.Drawing.Point(679, 0);
            this.btn_addmore.Name = "btn_addmore";
            this.btn_addmore.Size = new System.Drawing.Size(117, 76);
            this.btn_addmore.TabIndex = 2;
            this.btn_addmore.Text = "ADD MORE ...";
            this.btn_addmore.UseVisualStyleBackColor = true;
            this.btn_addmore.Click += new System.EventHandler(this.btn_addmore_Click);
            // 
            // CategorysView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.DGView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategorysView";
            this.Text = "CategorysView";
            ((System.ComponentModel.ISupportInitialize)(this.DGView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGView1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private System.Windows.Forms.Button btn_addmore;
    }
}