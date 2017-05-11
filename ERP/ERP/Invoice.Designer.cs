namespace ERP
{
    partial class Invoice
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
            this.txtinv = new System.Windows.Forms.TextBox();
            this.cmbgrnid = new System.Windows.Forms.ComboBox();
            this.txtdd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label29 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtcp = new System.Windows.Forms.TextBox();
            this.txtvname = new System.Windows.Forms.TextBox();
            this.cmbvid = new System.Windows.Forms.ComboBox();
            this.txtvphn = new System.Windows.Forms.TextBox();
            this.txtcpph = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.grpbox = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.cmbpid = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.txtamnt = new System.Windows.Forms.TextBox();
            this.txtpprice = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grpbox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtinv
            // 
            this.txtinv.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtinv.Location = new System.Drawing.Point(127, 55);
            this.txtinv.Margin = new System.Windows.Forms.Padding(2);
            this.txtinv.Name = "txtinv";
            this.txtinv.ReadOnly = true;
            this.txtinv.Size = new System.Drawing.Size(398, 23);
            this.txtinv.TabIndex = 0;
            // 
            // cmbgrnid
            // 
            this.cmbgrnid.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmbgrnid.FormattingEnabled = true;
            this.cmbgrnid.Location = new System.Drawing.Point(127, 133);
            this.cmbgrnid.Margin = new System.Windows.Forms.Padding(2);
            this.cmbgrnid.Name = "cmbgrnid";
            this.cmbgrnid.Size = new System.Drawing.Size(398, 22);
            this.cmbgrnid.TabIndex = 1;
            this.cmbgrnid.SelectedIndexChanged += new System.EventHandler(this.cmbgrnid_SelectedIndexChanged);
            // 
            // txtdd
            // 
            this.txtdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtdd.Location = new System.Drawing.Point(93, 74);
            this.txtdd.Margin = new System.Windows.Forms.Padding(2);
            this.txtdd.Name = "txtdd";
            this.txtdd.ReadOnly = true;
            this.txtdd.Size = new System.Drawing.Size(136, 23);
            this.txtdd.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtdd);
            this.groupBox1.Location = new System.Drawing.Point(34, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(499, 106);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GRN Details";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(355, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 22);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(20, 41);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(55, 16);
            this.label29.TabIndex = 46;
            this.label29.Text = "GRNID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 82);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Del Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(254, 81);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Recive Date";
            // 
            // txtcp
            // 
            this.txtcp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtcp.Location = new System.Drawing.Point(127, 345);
            this.txtcp.Margin = new System.Windows.Forms.Padding(2);
            this.txtcp.Name = "txtcp";
            this.txtcp.ReadOnly = true;
            this.txtcp.Size = new System.Drawing.Size(136, 23);
            this.txtcp.TabIndex = 13;
            // 
            // txtvname
            // 
            this.txtvname.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtvname.Location = new System.Drawing.Point(93, 84);
            this.txtvname.Margin = new System.Windows.Forms.Padding(2);
            this.txtvname.Name = "txtvname";
            this.txtvname.ReadOnly = true;
            this.txtvname.Size = new System.Drawing.Size(136, 23);
            this.txtvname.TabIndex = 12;
            // 
            // cmbvid
            // 
            this.cmbvid.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmbvid.FormattingEnabled = true;
            this.cmbvid.Location = new System.Drawing.Point(127, 264);
            this.cmbvid.Margin = new System.Windows.Forms.Padding(2);
            this.cmbvid.Name = "cmbvid";
            this.cmbvid.Size = new System.Drawing.Size(398, 22);
            this.cmbvid.TabIndex = 11;
            this.cmbvid.SelectedIndexChanged += new System.EventHandler(this.cmbvid_SelectedIndexChanged);
            // 
            // txtvphn
            // 
            this.txtvphn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtvphn.Location = new System.Drawing.Point(355, 84);
            this.txtvphn.Margin = new System.Windows.Forms.Padding(2);
            this.txtvphn.Name = "txtvphn";
            this.txtvphn.ReadOnly = true;
            this.txtvphn.Size = new System.Drawing.Size(137, 23);
            this.txtvphn.TabIndex = 16;
            // 
            // txtcpph
            // 
            this.txtcpph.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtcpph.Location = new System.Drawing.Point(355, 124);
            this.txtcpph.Margin = new System.Windows.Forms.Padding(2);
            this.txtcpph.Name = "txtcpph";
            this.txtcpph.ReadOnly = true;
            this.txtcpph.Size = new System.Drawing.Size(137, 23);
            this.txtcpph.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Invoice No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 267);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Vendor ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 349);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "ContPerson";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 89);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 16);
            this.label14.TabIndex = 31;
            this.label14.Text = "Vend Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(254, 88);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 16);
            this.label15.TabIndex = 32;
            this.label15.Text = "Phone No.";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(254, 127);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(89, 16);
            this.label.TabIndex = 45;
            this.label.Text = "CP Phone No.";
            // 
            // grpbox
            // 
            this.grpbox.Controls.Add(this.label);
            this.grpbox.Controls.Add(this.label14);
            this.grpbox.Controls.Add(this.label15);
            this.grpbox.Controls.Add(this.txtcpph);
            this.grpbox.Controls.Add(this.txtvphn);
            this.grpbox.Controls.Add(this.txtvname);
            this.grpbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpbox.Location = new System.Drawing.Point(34, 219);
            this.grpbox.Margin = new System.Windows.Forms.Padding(2);
            this.grpbox.Name = "grpbox";
            this.grpbox.Padding = new System.Windows.Forms.Padding(2);
            this.grpbox.Size = new System.Drawing.Size(499, 155);
            this.grpbox.TabIndex = 46;
            this.grpbox.TabStop = false;
            this.grpbox.Text = "Vendor Details";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CadetBlue;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(93, 114);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 30);
            this.button3.TabIndex = 50;
            this.button3.Text = "Calculate Amount";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(184, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 26);
            this.label6.TabIndex = 47;
            this.label6.Text = "Invoice Payable";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(127, 564);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 38);
            this.button1.TabIndex = 48;
            this.button1.Text = "Generate Invoice";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CadetBlue;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(289, 564);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 38);
            this.button2.TabIndex = 49;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtpname
            // 
            this.txtpname.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtpname.Location = new System.Drawing.Point(127, 472);
            this.txtpname.Margin = new System.Windows.Forms.Padding(2);
            this.txtpname.Name = "txtpname";
            this.txtpname.ReadOnly = true;
            this.txtpname.Size = new System.Drawing.Size(136, 23);
            this.txtpname.TabIndex = 52;
            // 
            // cmbpid
            // 
            this.cmbpid.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmbpid.FormattingEnabled = true;
            this.cmbpid.Location = new System.Drawing.Point(127, 434);
            this.cmbpid.Margin = new System.Windows.Forms.Padding(2);
            this.cmbpid.Name = "cmbpid";
            this.cmbpid.Size = new System.Drawing.Size(398, 22);
            this.cmbpid.TabIndex = 51;
            this.cmbpid.SelectedIndexChanged += new System.EventHandler(this.cmbpid_SelectedIndexChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.lbl);
            this.groupBox2.Controls.Add(this.txtamnt);
            this.groupBox2.Controls.Add(this.txtpprice);
            this.groupBox2.Location = new System.Drawing.Point(34, 393);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(499, 159);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Product ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 85);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "ProdName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Product Price";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(254, 124);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(100, 16);
            this.lbl.TabIndex = 21;
            this.lbl.Text = "Amount Payable";
            // 
            // txtamnt
            // 
            this.txtamnt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtamnt.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamnt.ForeColor = System.Drawing.Color.Maroon;
            this.txtamnt.Location = new System.Drawing.Point(355, 120);
            this.txtamnt.Margin = new System.Windows.Forms.Padding(2);
            this.txtamnt.Name = "txtamnt";
            this.txtamnt.ReadOnly = true;
            this.txtamnt.Size = new System.Drawing.Size(137, 21);
            this.txtamnt.TabIndex = 8;
            this.txtamnt.Text = "total amount with 17% tax";
            this.txtamnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtpprice
            // 
            this.txtpprice.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtpprice.Location = new System.Drawing.Point(355, 82);
            this.txtpprice.Margin = new System.Windows.Forms.Padding(2);
            this.txtpprice.Name = "txtpprice";
            this.txtpprice.ReadOnly = true;
            this.txtpprice.Size = new System.Drawing.Size(137, 23);
            this.txtpprice.TabIndex = 6;
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(563, 610);
            this.Controls.Add(this.txtpname);
            this.Controls.Add(this.cmbpid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcp);
            this.Controls.Add(this.cmbvid);
            this.Controls.Add(this.cmbgrnid);
            this.Controls.Add(this.txtinv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbox);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Payable";
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpbox.ResumeLayout(false);
            this.grpbox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtinv;
        private System.Windows.Forms.ComboBox cmbgrnid;
        private System.Windows.Forms.TextBox txtdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcp;
        private System.Windows.Forms.TextBox txtvname;
        private System.Windows.Forms.ComboBox cmbvid;
        private System.Windows.Forms.TextBox txtvphn;
        private System.Windows.Forms.TextBox txtcpph;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox grpbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.ComboBox cmbpid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtamnt;
        private System.Windows.Forms.TextBox txtpprice;
    }
}