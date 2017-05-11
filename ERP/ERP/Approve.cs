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
    public partial class Approve : Form
    {
        public OleDbConnection conn;
        public OleDbCommand cmd;
        Myconnection mc;

        public Approve()
        {
            InitializeComponent();
        }

        private void Approve_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = Form1.id;
            this.txtname.Text = Form1.name;
            this.txtphn.Text = Form1.ph1;
            this.txtphn2.Text = Form1.ph2;
            this.txtadd.Text = Form1.add;
            this.txcity.Text = Form1.city;
            this.txtcp.Text = Form1.cp;
            this.txtcpphn.Text = Form1.cpph;
            this.txtcmail.Text = Form1.email;
            this.txtcredit.Text = Form1.credit;
            this.cmbstatus.Text = Form1.status;
            this.cmbgroup.Text = Form1.group;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mc = new Myconnection();

            mc.conn.Open();

            cmd = new OleDbCommand("Update Customer set CStatus = 'Active' where CID = '"+textBox1.Text.ToString()+"' ",mc.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Approved");
            
            mc.conn.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
