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
    public partial class vsuform : Form
    {
        public OleDbConnection conn;
        public OleDbCommand cmd;
        public OleDbDataReader dr;
        Myconnection mc;
        public vsuform()
        {
            InitializeComponent();
        }

        private void vsuform_Load(object sender, EventArgs e)
        {
            mc = new Myconnection();
            mc.conn.Open();

            cmd = new OleDbCommand("select VID from Vendor " , mc.conn);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                comboBox1.Items.Add(dr["VID"]);
            }

            mc.conn.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mc.conn.Open();

            cmd = new OleDbCommand("select * from Vendor where VID = '"+comboBox1.Text+"' " , mc.conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cmbgroup.Text = dr["VGroup"].ToString() ;
                cmbstatus.Text = dr["VStatus"].ToString();
                textBox1.Text = dr["VID"].ToString();
                textBox4.Text = dr["VName"].ToString();
                txtcode.Text = dr["VCode"].ToString();
                textBox6.Text = dr["VCity"].ToString();
                txtphn.Text = dr["PH1"].ToString();
                txtphn2.Text = dr["PH2"].ToString();
                txtcp.Text = dr["CPName"].ToString();
                textBox10.Text = dr["CPPH"].ToString();
                txtmail.Text = dr["VEmail"].ToString();
                textBox13.Text = dr["VFax"].ToString();
                txtadd.Text = dr["VAddress"].ToString();
            }

            mc.conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mc.conn.Open();

            cmd = new OleDbCommand("update Vendor set VID = '" + textBox1.Text + "', VName = '" + textBox4.Text + "' , VCode = '" + txtcode.Text + "' , VCity = '" + textBox6.Text + "' , PH1  = '" + txtphn.Text + "' , PH2  = '" + txtphn2.Text + "' , VAddress  = '" + txtadd.Text + "' , CPName  = '" + txtcp.Text + "' , CPPH  = '" + textBox10.Text + "' , VEmail  = '" + txtmail.Text + "' , VFax  = '" + textBox13.Text + "' , VGroup   = '" + cmbgroup.Text + "', VStatus  = '" + cmbstatus.Text + "' where VID = '"+comboBox1.Text+"' ", mc.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has been updated");

            mc.conn.Close();
        }

        private void btnext_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
