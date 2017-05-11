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
    public partial class Form1 : Form
    {
        OleDbConnection conn;
        OleDbDataReader dr;

        public static String id;
        public static String name;
        public static String add;
        public static String city;
        public static String ph1;
        public static String ph2;
        public static String cp;
        public static String cpph;
        public static String email;
        public static String credit;
        public static String status;
        public static String group;

        Myconnection mc;
        OleDbCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }


        private void btnclr_Click(object sender, EventArgs e)
        {
            cmbgroup.Text = "";
            cmbstatus.Text = "";
            textBox1.Text = "";
            txtname.Clear();
            txtphn.Clear();
            txtphn2.Clear();
            txcity.Clear();
            txtadd.Clear();
            txtcmail.Clear();
            txtcp.Clear();
            txtcpphn.Clear();
            txtcredit.Clear();


        }

        private void btnext_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mc = new Myconnection();

            mc.conn.Open();

            cmd = new OleDbCommand("select GrpName from CusGroup", mc.conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbgroup.Items.Add(dr["GrpName"].ToString());
            }

            
            mc.conn.Close();


        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            mc.conn.Open();

            cmd = new OleDbCommand("insert into Customer(CID, Cname, CAddress, City, PH1, PH2, ContectPerson,CPPH, CEmail,CreditLimit, CStatus,CGroup ) values (@CID, @Cname , @CAddress , @City , @PH1 , @PH2 , @ContectPerson , @CPPH , @CEmail , @CreditLimit , @CStatus , @CGroup);", mc.conn);
            cmd.Parameters.AddWithValue("@CID", textBox1.Text.ToString());
            cmd.Parameters.AddWithValue("@Cname", txtname.Text);
            cmd.Parameters.AddWithValue("@CAddress", txtadd.Text);
            cmd.Parameters.AddWithValue("@City", txcity.Text);
            cmd.Parameters.AddWithValue("@PH1", txtphn.Text);
            cmd.Parameters.AddWithValue("@PH2", txtphn2.Text);
            cmd.Parameters.AddWithValue("@ContectPerson", txtcp.Text);
            cmd.Parameters.AddWithValue("@CPPH", txtcpphn.Text);
            cmd.Parameters.AddWithValue("@CEmail", txtcmail.Text);
            cmd.Parameters.AddWithValue("@CreditLimit", txtcredit.Text);
            cmd.Parameters.AddWithValue("@CStatus", cmbstatus.SelectedItem);
            cmd.Parameters.AddWithValue("@CGroup", cmbgroup.SelectedItem);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Record has been added");

            mc.conn.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            id = textBox1.Text;
            name = txtname.Text;
            add = txtadd.Text;
            city = txcity.Text;
            ph1 = txtphn.Text;
            ph2 = txtphn2.Text;
            cp = txtcp.Text;
            cpph = txtcpphn.Text;
            email = txtcmail.Text;
            credit = txtcredit.Text;
            status = cmbstatus.Text;
            group = cmbgroup.Text;


            Approve ap = new Approve();
            this.Hide();
            ap.ShowDialog();

        }

        private void cmbid_SelectedIndexChanged(object sender, EventArgs e)
        {
            mc.conn.Open();

            cmd = new OleDbCommand("select * from Customer where CID = '" + textBox1.Text + "'", mc.conn);
            dr = cmd.ExecuteReader();

            if (dr.Read())
                txtname.Text = dr["Cname"].ToString();
            txtname.Text = dr["Cname"].ToString();
            txtadd.Text = dr["CAddress"].ToString();
            txcity.Text = dr["City"].ToString();
            txtphn.Text = dr["PH1"].ToString();
            txtphn2.Text = dr["PH2"].ToString();
            txtcp.Text = dr["ContectPerson"].ToString();
            txtcpphn.Text = dr["CPPH"].ToString();
            txtcmail.Text = dr["CEmail"].ToString();
            txtcredit.Text = dr["CreditLimit"].ToString();
            cmbstatus.Text = dr["CStatus"].ToString();
            cmbgroup.Text = dr["CGroup"].ToString();

            mc.conn.Close();
        }

        private void cmbgroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c = 0;
            mc.conn.Open();

            cmd = new OleDbCommand("select count(CID) from Customer where CGroup = '" + cmbgroup.Text + "' ", mc.conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                c = Convert.ToInt32(dr[0]); c++;
            }
            if (cmbgroup.Text == "Consumer")
            {
                textBox1.Text = "Con-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }
            else if (cmbgroup.Text == "HR")
            {
                textBox1.Text = "HR-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }
            else if (cmbgroup.Text == "Marketing")
            {
                textBox1.Text = "Mark-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }
            else if (cmbgroup.Text == "Sales")
            {
                textBox1.Text = "Sal-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }
            else
            {
                textBox1.Text = "Please select anyone gruop!";
            }

            mc.conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SUForm su = new SUForm();
            this.Hide();
            su.ShowDialog();
        }
    }
}
