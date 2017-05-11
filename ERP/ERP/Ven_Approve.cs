using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ERP
{
    public partial class Ven_Approve : Form
    {
        public OleDbConnection conn;
        public OleDbCommand cmd;
        Myconnection mc;
        public Ven_Approve()
        {
            InitializeComponent();
        }

        private void Ven_Approve_Load(object sender, EventArgs e)
        {
           this.textBox1.Text = Vendor.id;
           this.textBox4.Text = Vendor.name;
           this.txtadd.Text = Vendor.add;
           this.textBox6.Text = Vendor.city;
           this.txtphn.Text = Vendor.ph1;
           this.txtphn2.Text = Vendor.ph2;
           this.txtcp.Text = Vendor.cp;
           this.textBox10.Text = Vendor.cpph;
           this.txtmail.Text = Vendor.email;
           this.textBox13.Text = Vendor.fax;
           this.txtcode.Text = Vendor.code;
           this.cmbstatus.Text = Vendor.status;
           this.cmbgroup.Text = Vendor.group;
        }

        private void btnext_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mc = new Myconnection();
            mc.conn.Open();

            cmd = new OleDbCommand("update vendor set VStatus = 'Active' where VID = '" +textBox1.Text+ "' ", mc.conn);
            MessageBox.Show("Approved");

            cmd.ExecuteNonQuery();

            mc.conn.Close();
        }
    }
}
