namespace ERP
{
    partial class InvoiceRec
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
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.txtpprice = new System.Windows.Forms.TextBox();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.cmbpid = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtamnt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.grpbox = new System.Windows.Forms.GroupBox();
            this.txtcp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbvid = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtcpph = new System.Windows.Forms.TextBox();
            this.txtvphn = new System.Windows.Forms.TextBox();
            this.txtvname = new System.Windows.Forms.TextBox();
            this.cmbdcid = new System.Windows.Forms.ComboBox();
            this.txtinv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label29 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.grpbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Product ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "ProdName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Product Price";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(257, 114);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(106, 17);
            this.lbl.TabIndex = 21;
            this.lbl.Text = "Amount Recivable";
            // 
            // txtpprice
            // 
            this.txtpprice.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtpprice.Location = new System.Drawing.Point(364, 75);
            this.txtpprice.Name = "txtpprice";
            this.txtpprice.ReadOnly = true;
            this.txtpprice.Size = new System.Drawing.Size(136, 24);
            this.txtpprice.TabIndex = 6;
            // 
            // txtpname
            // 
            this.txtpname.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtpname.Location = new System.Drawing.Point(102, 75);
            this.txtpname.Name = "txtpname";
            this.txtpname.ReadOnly = true;
            this.txtpname.Size = new System.Drawing.Size(136, 24);
            this.txtpname.TabIndex = 68;
            // 
            // cmbpid
            // 
            this.cmbpid.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmbpid.FormattingEnabled = true;
            this.cmbpid.Location = new System.Drawing.Point(102, 37);
            this.cmbpid.Name = "cmbpid";
            this.cmbpid.Size = new System.Drawing.Size(398, 25);
            this.cmbpid.TabIndex = 67;
            this.cmbpid.SelectedIndexChanged += new System.EventHandler(this.cmbpid_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.txtpname);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbpid);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.lbl);
            this.groupBox2.Controls.Add(this.txtamnt);
            this.groupBox2.Controls.Add(this.txtpprice);
            this.groupBox2.Location = new System.Drawing.Point(37, 384);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 156);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Details";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CadetBlue;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(102, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 30);
            this.button3.TabIndex = 50;
            this.button3.Text = "Calculate Amount";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtamnt
            // 
            this.txtamnt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtamnt.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamnt.ForeColor = System.Drawing.Color.Maroon;
            this.txtamnt.Location = new System.Drawing.Point(364, 111);
            this.txtamnt.Name = "txtamnt";
            this.txtamnt.ReadOnly = true;
            this.txtamnt.Size = new System.Drawing.Size(136, 21);
            this.txtamnt.TabIndex = 8;
            this.txtamnt.Text = "total amount with 17% tax";
            this.txtamnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CadetBlue;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(297, 552);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 38);
            this.button2.TabIndex = 66;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(81, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 38);
            this.button1.TabIndex = 65;
            this.button1.Text = "Generate Invoice";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(232, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 26);
            this.label6.TabIndex = 64;
            this.label6.Text = "Invoice Reciveable";
            // 
            // grpbox
            // 
            this.grpbox.Controls.Add(this.txtcp);
            this.grpbox.Controls.Add(this.label8);
            this.grpbox.Controls.Add(this.label4);
            this.grpbox.Controls.Add(this.cmbvid);
            this.grpbox.Controls.Add(this.label);
            this.grpbox.Controls.Add(this.label14);
            this.grpbox.Controls.Add(this.label15);
            this.grpbox.Controls.Add(this.txtcpph);
            this.grpbox.Controls.Add(this.txtvphn);
            this.grpbox.Controls.Add(this.txtvname);
            this.grpbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpbox.Location = new System.Drawing.Point(37, 218);
            this.grpbox.Name = "grpbox";
            this.grpbox.Size = new System.Drawing.Size(514, 148);
            this.grpbox.TabIndex = 63;
            this.grpbox.TabStop = false;
            this.grpbox.Text = "Vendor Details";
            // 
            // txtcp
            // 
            this.txtcp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtcp.Location = new System.Drawing.Point(102, 108);
            this.txtcp.Name = "txtcp";
            this.txtcp.ReadOnly = true;
            this.txtcp.Size = new System.Drawing.Size(136, 24);
            this.txtcp.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "ContPerson";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Vendor ID";
            // 
            // cmbvid
            // 
            this.cmbvid.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmbvid.FormattingEnabled = true;
            this.cmbvid.Location = new System.Drawing.Point(102, 35);
            this.cmbvid.Name = "cmbvid";
            this.cmbvid.Size = new System.Drawing.Size(398, 25);
            this.cmbvid.TabIndex = 46;
            this.cmbvid.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(266, 111);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(84, 17);
            this.label.TabIndex = 45;
            this.label.Text = "CP Phone No.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 17);
            this.label14.TabIndex = 31;
            this.label14.Text = "Vend Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(266, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 17);
            this.label15.TabIndex = 32;
            this.label15.Text = "Phone No.";
            // 
            // txtcpph
            // 
            this.txtcpph.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtcpph.Location = new System.Drawing.Point(364, 108);
            this.txtcpph.Name = "txtcpph";
            this.txtcpph.ReadOnly = true;
            this.txtcpph.Size = new System.Drawing.Size(136, 24);
            this.txtcpph.TabIndex = 14;
            // 
            // txtvphn
            // 
            this.txtvphn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtvphn.Location = new System.Drawing.Point(364, 72);
            this.txtvphn.Name = "txtvphn";
            this.txtvphn.ReadOnly = true;
            this.txtvphn.Size = new System.Drawing.Size(136, 24);
            this.txtvphn.TabIndex = 16;
            // 
            // txtvname
            // 
            this.txtvname.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtvname.Location = new System.Drawing.Point(102, 72);
            this.txtvname.Name = "txtvname";
            this.txtvname.ReadOnly = true;
            this.txtvname.Size = new System.Drawing.Size(136, 24);
            this.txtvname.TabIndex = 12;
            // 
            // cmbdcid
            // 
            this.cmbdcid.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmbdcid.FormattingEnabled = true;
            this.cmbdcid.Location = new System.Drawing.Point(102, 36);
            this.cmbdcid.Name = "cmbdcid";
            this.cmbdcid.Size = new System.Drawing.Size(398, 25);
            this.cmbdcid.TabIndex = 56;
            this.cmbdcid.SelectedIndexChanged += new System.EventHandler(this.cmbdcid_SelectedIndexChanged);
            // 
            // txtinv
            // 
            this.txtinv.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtinv.Location = new System.Drawing.Point(139, 52);
            this.txtinv.Name = "txtinv";
            this.txtinv.ReadOnly = true;
            this.txtinv.Size = new System.Drawing.Size(398, 24);
            this.txtinv.TabIndex = 55;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtdd);
            this.groupBox1.Controls.Add(this.cmbdcid);
            this.groupBox1.Location = new System.Drawing.Point(37, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 111);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GRN Details";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(364, 72);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 22);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(19, 36);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(54, 17);
            this.label29.TabIndex = 46;
            this.label29.Text = "GRNID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Del Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(266, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 17);
            this.label13.TabIndex = 30;
            this.label13.Text = "Recive Date";
            // 
            // txtdd
            // 
            this.txtdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtdd.Location = new System.Drawing.Point(102, 73);
            this.txtdd.Name = "txtdd";
            this.txtdd.ReadOnly = true;
            this.txtdd.Size = new System.Drawing.Size(136, 24);
            this.txtdd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Invoice No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 61;
            this.label5.Text = "Vendor ID";
            // 
            // InvoiceRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(587, 603);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpbox);
            this.Controls.Add(this.txtinv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InvoiceRec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceRec";
            this.Load += new System.EventHandler(this.InvoiceRec_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpbox.ResumeLayout(false);
            this.grpbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtpprice;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.ComboBox cmbpid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtamnt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpbox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtcpph;
        private System.Windows.Forms.TextBox txtvphn;
        private System.Windows.Forms.TextBox txtvname;
        private System.Windows.Forms.ComboBox cmbdcid;
        private System.Windows.Forms.TextBox txtinv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcp;
        private System.Windows.Forms.ComboBox cmbvid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
    }
}