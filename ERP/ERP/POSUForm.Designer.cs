namespace ERP
{
    partial class POSUForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnext = new System.Windows.Forms.Button();
            this.btnapp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdeliv = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtprdtyp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.txtaoh = new System.Windows.Forms.TextBox();
            this.jhjh = new System.Windows.Forms.Label();
            this.txtwp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtapo = new System.Windows.Forms.TextBox();
            this.txtwinp = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.CadetBlue;
            this.label6.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(269, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(366, 30);
            this.label6.TabIndex = 65;
            this.label6.Text = "Products Search, Update";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(171, 85);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(622, 21);
            this.comboBox1.TabIndex = 68;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 68;
            this.label10.Text = "Select ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(57, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(749, 61);
            this.groupBox3.TabIndex = 69;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnext);
            this.groupBox1.Controls.Add(this.btnapp);
            this.groupBox1.Location = new System.Drawing.Point(279, 443);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(332, 62);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            // 
            // btnext
            // 
            this.btnext.BackColor = System.Drawing.Color.Teal;
            this.btnext.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnext.ForeColor = System.Drawing.Color.Black;
            this.btnext.Location = new System.Drawing.Point(171, 13);
            this.btnext.Margin = new System.Windows.Forms.Padding(5);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(152, 41);
            this.btnext.TabIndex = 13;
            this.btnext.Text = "Exit";
            this.btnext.UseVisualStyleBackColor = false;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // btnapp
            // 
            this.btnapp.BackColor = System.Drawing.Color.Teal;
            this.btnapp.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnapp.ForeColor = System.Drawing.Color.Black;
            this.btnapp.Location = new System.Drawing.Point(9, 13);
            this.btnapp.Margin = new System.Windows.Forms.Padding(5);
            this.btnapp.Name = "btnapp";
            this.btnapp.Size = new System.Drawing.Size(152, 41);
            this.btnapp.TabIndex = 30;
            this.btnapp.Text = "Update";
            this.btnapp.UseVisualStyleBackColor = false;
            this.btnapp.Click += new System.EventHandler(this.btnapp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 41;
            this.label5.Text = "Inventory Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "BasePrice";
            // 
            // txtprice
            // 
            this.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprice.Location = new System.Drawing.Point(119, 79);
            this.txtprice.Margin = new System.Windows.Forms.Padding(5);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(242, 25);
            this.txtprice.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "PID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "Est_Delivery";
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Location = new System.Drawing.Point(494, 22);
            this.txtname.Margin = new System.Windows.Forms.Padding(5);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(242, 25);
            this.txtname.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 35;
            this.label7.Text = "PName";
            // 
            // txtdeliv
            // 
            this.txtdeliv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdeliv.Location = new System.Drawing.Point(494, 134);
            this.txtdeliv.Margin = new System.Windows.Forms.Padding(5);
            this.txtdeliv.Name = "txtdeliv";
            this.txtdeliv.Size = new System.Drawing.Size(242, 25);
            this.txtdeliv.TabIndex = 40;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtid);
            this.groupBox2.Controls.Add(this.txtprdtyp);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cmbstatus);
            this.groupBox2.Controls.Add(this.txtaoh);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.jhjh);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtprice);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtwp);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtapo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtname);
            this.groupBox2.Controls.Add(this.txtwinp);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtdeliv);
            this.groupBox2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(57, 156);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(749, 287);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            // 
            // txtid
            // 
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Location = new System.Drawing.Point(118, 22);
            this.txtid.Margin = new System.Windows.Forms.Padding(5);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(242, 25);
            this.txtid.TabIndex = 58;
            // 
            // txtprdtyp
            // 
            this.txtprdtyp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprdtyp.Location = new System.Drawing.Point(494, 248);
            this.txtprdtyp.Margin = new System.Windows.Forms.Padding(5);
            this.txtprdtyp.Name = "txtprdtyp";
            this.txtprdtyp.Size = new System.Drawing.Size(242, 25);
            this.txtprdtyp.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 251);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 18);
            this.label11.TabIndex = 50;
            this.label11.Text = "Warrenty Period";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(388, 251);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 18);
            this.label8.TabIndex = 54;
            this.label8.Text = "Product Type";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 195);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 18);
            this.label13.TabIndex = 46;
            this.label13.Text = "Amount On Hand";
            // 
            // cmbstatus
            // 
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "In Hand",
            "Not In Hand"});
            this.cmbstatus.Location = new System.Drawing.Point(119, 134);
            this.cmbstatus.Margin = new System.Windows.Forms.Padding(5);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(241, 26);
            this.cmbstatus.TabIndex = 57;
            // 
            // txtaoh
            // 
            this.txtaoh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtaoh.Location = new System.Drawing.Point(119, 193);
            this.txtaoh.Margin = new System.Windows.Forms.Padding(5);
            this.txtaoh.Name = "txtaoh";
            this.txtaoh.Size = new System.Drawing.Size(242, 25);
            this.txtaoh.TabIndex = 47;
            // 
            // jhjh
            // 
            this.jhjh.AutoSize = true;
            this.jhjh.Location = new System.Drawing.Point(388, 199);
            this.jhjh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.jhjh.Name = "jhjh";
            this.jhjh.Size = new System.Drawing.Size(105, 18);
            this.jhjh.TabIndex = 48;
            this.jhjh.Text = "Allow Per Ordre";
            // 
            // txtwp
            // 
            this.txtwp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtwp.Location = new System.Drawing.Point(119, 248);
            this.txtwp.Margin = new System.Windows.Forms.Padding(5);
            this.txtwp.Name = "txtwp";
            this.txtwp.Size = new System.Drawing.Size(242, 25);
            this.txtwp.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 18);
            this.label9.TabIndex = 44;
            this.label9.Text = "Weight In Pround";
            // 
            // txtapo
            // 
            this.txtapo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtapo.Location = new System.Drawing.Point(494, 193);
            this.txtapo.Margin = new System.Windows.Forms.Padding(5);
            this.txtapo.Name = "txtapo";
            this.txtapo.Size = new System.Drawing.Size(242, 25);
            this.txtapo.TabIndex = 49;
            // 
            // txtwinp
            // 
            this.txtwinp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtwinp.Location = new System.Drawing.Point(494, 79);
            this.txtwinp.Margin = new System.Windows.Forms.Padding(5);
            this.txtwinp.Name = "txtwinp";
            this.txtwinp.Size = new System.Drawing.Size(242, 25);
            this.txtwinp.TabIndex = 45;
            // 
            // POSUForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(865, 521);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "POSUForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POSUForm";
            this.Load += new System.EventHandler(this.POSUForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnext;
        private System.Windows.Forms.Button btnapp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdeliv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtprdtyp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.TextBox txtaoh;
        private System.Windows.Forms.Label jhjh;
        private System.Windows.Forms.TextBox txtwp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtapo;
        private System.Windows.Forms.TextBox txtwinp;
    }
}