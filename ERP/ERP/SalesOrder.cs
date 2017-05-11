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
    public partial class SalesOrder : Form
    {
        public static string poid, date;
        public static string pid, pname, price, qtty, totalprce, showid, showqtty;
        public static string vid, vname, deptt, cp, cpphn;

        string[] prds = new string[50];
        int[] qntty = new int[50];
        int counter = 0;

        int total = 0;
        public OleDbConnection conn;
        public OleDbCommand cmd;
        public OleDbDataReader dr;
        Myconnection mc;
        public SalesOrder()
        {
            InitializeComponent();
        }

        private void SalesOrder_Load(object sender, EventArgs e)
        {
            mc = new Myconnection();
            mc.conn.Open();
            //int c = 0;
            cmd = new OleDbCommand("select SOID from SO where Approve = 'Not Approve' ", mc.conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //c = Convert.ToInt32(dr[0]); c++;
                txtid.Items.Add(dr["SOID"]);
                //txtid.Text = "PO-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }




            cmd = new OleDbCommand("Select PID from Products", mc.conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtpid.Items.Add(dr["PID"]);
            }

            cmd = new OleDbCommand("Select VID from Vendor", mc.conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbvid.Items.Add(dr["VID"]);
            }
            mc.conn.Close();
        }

        private void txtid_SelectedIndexChanged(object sender, EventArgs e)
        {
            mc.conn.Open();

            cmd = new OleDbCommand("Select DDate from SO where SOID = '" + txtid.Text + "' ", mc.conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //  dateTimePicker1.Value = dr["DDate"].ToString();
                txtdate.Text = dr["DDate"].ToString();
            }

            mc.conn.Close();
        }

        private void txtpid_SelectedIndexChanged(object sender, EventArgs e)
        {
            mc.conn.Open();

            cmd = new OleDbCommand("Select PName , BasePrice from Products where PID = '" + txtpid.Text + "'", mc.conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtpname.Text = dr["PName"].ToString();
                txtprice.Text = dr["BasePrice"].ToString();
            }

            mc.conn.Close();
        }

        private void cmbvid_SelectedIndexChanged(object sender, EventArgs e)
        {
            mc.conn.Open();

            cmd = new OleDbCommand("select VName , VGroup , CPName , CPPH from vendor where VID = '" + cmbvid.Text + "'  ", mc.conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtvname.Text = dr["VName"].ToString();
                txtdeptt.Text = dr["VGroup"].ToString();
                txtcp.Text = dr["CPName"].ToString();
                txtcpphn.Text = dr["CPPH"].ToString();
            }

            mc.conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            total += Convert.ToInt32(txtprice.Text) * Convert.ToInt32(txtqtty.Text);
            txttotal.Text = total.ToString();

            textBox1.Text += txtpid.Text + Environment.NewLine;
            textBox2.Text += txtqtty.Text + Environment.NewLine;

            prds[counter] = txtpid.Text;
            qntty[counter] = Convert.ToInt32(txtqtty.Text);
            counter++;  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mc.conn.Open();

            for (int i = 0; i < counter; i++)
            {
                cmd = new OleDbCommand("insert into POProducts values (@POID , @PModel, @PQty)", mc.conn);
                cmd.Parameters.AddWithValue("@POID", txtid.Text);
                cmd.Parameters.AddWithValue("@PModel", txtpid.Text);
                cmd.Parameters.AddWithValue("@PQty", txtqtty.Text);

                cmd.ExecuteNonQuery();
            }

            mc.conn.Close();

            poid = txtid.Text;
            date = txtdate.Text;
            pid = txtpid.Text;
            pname = txtpname.Text;
            price = txtprice.Text;
            qtty = txtqtty.Text;
            totalprce = txttotal.Text;
            showid = textBox1.Text;
            showqtty = textBox2.Text;
            vid = cmbvid.Text;
            vname = txtvname.Text;
            deptt = txtdeptt.Text;
            cp = txtcp.Text;
            cpphn = txtcpphn.Text;

            MessageBox.Show("Sales Order done!");
            SOApprove soa = new SOApprove();
            this.Hide();
            soa.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
