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
    public partial class Vendor : Form
    {
        public OleDbConnection conn;
        public OleDbCommand cmd;
        public OleDbDataReader dr;
        Myconnection mc;

        public static String id;
        public static String name;
        public static String add;
        public static String city;
        public static String ph1;
        public static String ph2;
        public static String cp;
        public static String cpph;
        public static String email;
        public static String fax;
        public static String code;
        public static String status;
        public static String group;

        public Vendor()
        {
            InitializeComponent();
        }

        private void Vendor_Load(object sender, EventArgs e)
        {
            mc = new Myconnection();
            mc.conn.Open();

            cmd = new OleDbCommand("select GrpName from CusGroup", mc.conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbgroup.Items.Add(dr["GrpName"]);
            }


            mc.conn.Close();
        }

        private void cmbgroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c = 0;
            mc.conn.Open();

            cmd = new OleDbCommand("select count(VID) from Vendor where VGroup = '"+cmbgroup.Text+"' ",mc.conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                c = Convert.ToInt32(dr[0]); c++;
            }
            if (cmbgroup.Text == "Consumer")
            {
                textBox1.Text = "Con-0" +c.ToString()+ "-" + System.DateTime.Today.Year;
            }
            else if (cmbgroup.Text == "HR")
            {
                textBox1.Text = "HR-00" +c.ToString() + "-"+ System.DateTime.Today.Year;
            }
            else if (cmbgroup.Text == "Marketing")
            {
                textBox1.Text = "Mark-00" +c.ToString()+ "-" +System.DateTime.Today.Year;
            }
            else if(cmbgroup.Text == "Sales")
            {
                textBox1.Text = "Sal-00" + c.ToString() + "-"+ System.DateTime.Today.Year;
            }
            else
            {
                textBox1.Text = "Plese select anyone gruop!";
            }


            mc.conn.Close();
        }


        private void btnext_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            cmbgroup.Text = "";
            cmbstatus.Text = "";
            textBox1.Clear();
            textBox10.Clear();
            txtcode.Clear();
            txtcp.Clear();
            txtmail.Clear();
            txtphn.Clear();
            txtphn2.Clear();
            textBox13.Clear();
            txtadd.Clear();
            textBox4.Clear();
            textBox6.Clear();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


            id = textBox1.Text;
            name = textBox4.Text;
            add = txtadd.Text;
            city = textBox6.Text;
            ph1 = txtphn.Text;
            ph2 = txtphn2.Text;
            cp = txtcp.Text;
            cpph = textBox10.Text;
            email = txtmail.Text;
            fax = textBox13.Text;
            code = txtcode.Text;
            status = cmbstatus.Text;
            group = cmbgroup.Text;

            Ven_Approve va = new Ven_Approve();
            this.Hide();
            va.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mc.conn.Open();

            cmd = new OleDbCommand("insert into Vendor (ViD,VNAME, VCODE, VCITY, PH1, PH2, VAddress, CPName, CPPH, VEmail, VFax, VGroup, VStatus) values (@ViD , @VNAME, @VCODE, @VCITY, @PH1, @PH2, @VAddress, @CPName, @CPPH, @VEmail, @VFax, @VGroup, @VStatus)", mc.conn);
            cmd.Parameters.AddWithValue("@ViD" , textBox1.Text);
            cmd.Parameters.AddWithValue("@VNAME", textBox4.Text);
            cmd.Parameters.AddWithValue("@VCODE", txtcode.Text);
            cmd.Parameters.AddWithValue("@VCITY", textBox6.Text);
            cmd.Parameters.AddWithValue("@PH1", txtphn.Text);
            cmd.Parameters.AddWithValue("@PH2", txtphn2.Text);
            cmd.Parameters.AddWithValue("@VAddress", txtadd.Text);
            cmd.Parameters.AddWithValue("@CPName", txtcp.Text);
            cmd.Parameters.AddWithValue("@VCPPh", textBox10.Text);            
            cmd.Parameters.AddWithValue("@VEmail", txtmail.Text);
            cmd.Parameters.AddWithValue("@VFax", textBox13.Text);
            cmd.Parameters.AddWithValue("@VGroup", cmbgroup.Text);
            cmd.Parameters.AddWithValue("@VSatus", cmbstatus.Text);

            MessageBox.Show("Record has been added");

            cmd.ExecuteNonQuery();

            mc.conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vsuform vsu = new vsuform();
            this.Hide();
            vsu.ShowDialog();
        }
    }
}
