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
    public partial class SUForm : Form
    {
        public OleDbConnection conn;
        public OleDbCommand cmd;
        public OleDbDataReader dr;
        Myconnection mc;
        public SUForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mc.conn.Open();

            cmd = new OleDbCommand("update Customer set CID = '"+textBox1.Text+"' , Cname = '"+txtname.Text+"' , CAddress = '"+txtadd.Text+"' , City = '"+txcity.Text+"' , PH1 = '"+txtphn.Text+"' , PH2 = '"+txtphn2.Text+"' , ContectPerson = '"+txtcp.Text+"' , CPPH = '"+txtcpphn.Text+"' , CEmail = '"+txtcmail.Text+"' , CreditLimit = '"+txtcredit.Text+"' , CStatus = '"+cmbstatus.Text+"' , CGroup = '"+cmbgroup.Text+"' where CID = '"+comboBox1.Text+"'", mc.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has been updated");
            mc.conn.Close();
        }

        private void SUForm_Load(object sender, EventArgs e)
        {
            mc = new Myconnection();

            mc.conn.Open();

            cmd = new OleDbCommand("select CID from Customer" , mc.conn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["CID"]);
            }

            mc.conn.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mc.conn.Open();

            cmd = new OleDbCommand("select * from Customer where CID = '"+comboBox1.Text+"' " , mc.conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cmbgroup.Text = dr["CGroup"].ToString();
                cmbstatus.Text = dr["CStatus"].ToString();
                textBox1.Text = dr["CID"].ToString();
                txtname.Text = dr["Cname"].ToString();
                txtphn.Text = dr["PH1"].ToString();
                txtphn2.Text = dr["PH2"].ToString();
                txtadd.Text = dr["CAddress"].ToString();
                txcity.Text = dr["City"].ToString();
                txtcp.Text = dr["ContectPerson"].ToString();
                txtcpphn.Text = dr["CPPH"].ToString();
                txtcmail.Text = dr["CEmail"].ToString();
                txtcredit.Text = dr["CreditLimit"].ToString();


            }

            mc.conn.Close();

        }

        private void btnext_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
