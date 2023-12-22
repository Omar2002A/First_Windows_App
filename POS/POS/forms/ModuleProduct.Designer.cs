namespace POS.forms
{
    partial class ModuleProduct
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
            this.components = new System.ComponentModel.Container();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.ctDropDown = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new Windows.Forms.HintTextBox(this.components);
            this.txtPrice = new Windows.Forms.HintTextBox(this.components);
            this.hintTextBox4 = new Windows.Forms.HintTextBox(this.components);
            this.txtCost = new Windows.Forms.HintTextBox(this.components);
            this.txtDescribtion = new Windows.Forms.HintTextBox(this.components);
            this.txtProductName = new Windows.Forms.HintTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.PatternStyle.ForwardDiagonal, System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220))))), System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157))))));
            this.gradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(800, 91);
            this.gradientPanel1.TabIndex = 14;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220))))), System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(234)))), ((int)(((byte)(252))))));
            this.gradientPanel2.Controls.Add(this.btnExit);
            this.gradientPanel2.Controls.Add(this.btnclear);
            this.gradientPanel2.Controls.Add(this.btnInsert);
            this.gradientPanel2.Controls.Add(this.label7);
            this.gradientPanel2.Controls.Add(this.label6);
            this.gradientPanel2.Controls.Add(this.label5);
            this.gradientPanel2.Controls.Add(this.label4);
            this.gradientPanel2.Controls.Add(this.label3);
            this.gradientPanel2.Controls.Add(this.label2);
            this.gradientPanel2.Controls.Add(this.lbName);
            this.gradientPanel2.Controls.Add(this.ctDropDown);
            this.gradientPanel2.Controls.Add(this.txtQuantity);
            this.gradientPanel2.Controls.Add(this.txtPrice);
            this.gradientPanel2.Controls.Add(this.hintTextBox4);
            this.gradientPanel2.Controls.Add(this.txtCost);
            this.gradientPanel2.Controls.Add(this.txtDescribtion);
            this.gradientPanel2.Controls.Add(this.txtProductName);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 91);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(800, 359);
            this.gradientPanel2.TabIndex = 15;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(682, 305);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 40);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnclear
            // 
            this.btnclear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Location = new System.Drawing.Point(682, 268);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(111, 40);
            this.btnclear.TabIndex = 29;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Location = new System.Drawing.Point(682, 231);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(111, 40);
            this.btnInsert.TabIndex = 28;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(499, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(499, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Barcode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(499, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Describtion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Cost";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(71, 47);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(43, 17);
            this.lbName.TabIndex = 21;
            this.lbName.Text = "Name";
            // 
            // ctDropDown
            // 
            this.ctDropDown.FormattingEnabled = true;
            this.ctDropDown.Location = new System.Drawing.Point(209, 287);
            this.ctDropDown.Name = "ctDropDown";
            this.ctDropDown.Size = new System.Drawing.Size(121, 21);
            this.ctDropDown.TabIndex = 20;
            // 
            // txtQuantity
            // 
            this.txtQuantity.EnterToTab = false;
            this.txtQuantity.ForeColor = System.Drawing.Color.Gray;
            this.txtQuantity.HintColor = System.Drawing.Color.Gray;
            this.txtQuantity.HintValue = "Hint Value";
            this.txtQuantity.Location = new System.Drawing.Point(600, 205);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 19;
            this.txtQuantity.Text = "Hint Value";
            this.txtQuantity.TextForeColor = System.Drawing.Color.Black;
            this.txtQuantity.Value = "";
            // 
            // txtPrice
            // 
            this.txtPrice.EnterToTab = false;
            this.txtPrice.ForeColor = System.Drawing.Color.Gray;
            this.txtPrice.HintColor = System.Drawing.Color.Gray;
            this.txtPrice.HintValue = "Hint Value";
            this.txtPrice.Location = new System.Drawing.Point(209, 205);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 18;
            this.txtPrice.Text = "Hint Value";
            this.txtPrice.TextForeColor = System.Drawing.Color.Black;
            this.txtPrice.Value = "";
            // 
            // hintTextBox4
            // 
            this.hintTextBox4.EnterToTab = false;
            this.hintTextBox4.ForeColor = System.Drawing.Color.Gray;
            this.hintTextBox4.HintColor = System.Drawing.Color.Gray;
            this.hintTextBox4.HintValue = "Hint Value";
            this.hintTextBox4.Location = new System.Drawing.Point(600, 118);
            this.hintTextBox4.Name = "hintTextBox4";
            this.hintTextBox4.Size = new System.Drawing.Size(100, 20);
            this.hintTextBox4.TabIndex = 17;
            this.hintTextBox4.Text = "Hint Value";
            this.hintTextBox4.TextForeColor = System.Drawing.Color.Black;
            this.hintTextBox4.Value = "";
            // 
            // txtCost
            // 
            this.txtCost.EnterToTab = false;
            this.txtCost.ForeColor = System.Drawing.Color.Gray;
            this.txtCost.HintColor = System.Drawing.Color.Gray;
            this.txtCost.HintValue = "Hint Value";
            this.txtCost.Location = new System.Drawing.Point(209, 118);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 16;
            this.txtCost.Text = "Hint Value";
            this.txtCost.TextForeColor = System.Drawing.Color.Black;
            this.txtCost.Value = "";
            // 
            // txtDescribtion
            // 
            this.txtDescribtion.EnterToTab = false;
            this.txtDescribtion.ForeColor = System.Drawing.Color.Gray;
            this.txtDescribtion.HintColor = System.Drawing.Color.Gray;
            this.txtDescribtion.HintValue = "alo";
            this.txtDescribtion.Location = new System.Drawing.Point(600, 46);
            this.txtDescribtion.Multiline = true;
            this.txtDescribtion.Name = "txtDescribtion";
            this.txtDescribtion.Size = new System.Drawing.Size(126, 53);
            this.txtDescribtion.TabIndex = 15;
            this.txtDescribtion.Text = "alo";
            this.txtDescribtion.TextForeColor = System.Drawing.Color.Black;
            this.txtDescribtion.Value = "";
            // 
            // txtProductName
            // 
            this.txtProductName.EnterToTab = false;
            this.txtProductName.ForeColor = System.Drawing.Color.Gray;
            this.txtProductName.HintColor = System.Drawing.Color.Gray;
            this.txtProductName.HintValue = "Hint Value";
            this.txtProductName.Location = new System.Drawing.Point(209, 46);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 14;
            this.txtProductName.Text = "Hint Value";
            this.txtProductName.TextForeColor = System.Drawing.Color.Black;
            this.txtProductName.Value = "";
            // 
            // ModuleProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradientPanel2);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModuleProduct";
            this.Text = "ModuleProduct";
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ComboBox ctDropDown;
        private Windows.Forms.HintTextBox txtQuantity;
        private Windows.Forms.HintTextBox txtPrice;
        private Windows.Forms.HintTextBox hintTextBox4;
        private Windows.Forms.HintTextBox txtCost;
        private Windows.Forms.HintTextBox txtDescribtion;
        private Windows.Forms.HintTextBox txtProductName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnInsert;
    }
}