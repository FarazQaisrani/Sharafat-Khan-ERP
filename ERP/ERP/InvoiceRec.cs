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
    public partial class InvoiceRec : Form
    {
        public OleDbConnection conn;
        public OleDbCommand cmd;
        public OleDbDataReader dr;
        Myconnection mc = new Myconnection();

        double amountpayable = 0, tax = 0, price = 0;

        public InvoiceRec()
        {
            InitializeComponent();
        }

        private void InvoiceRec_Load(object sender, EventArgs e)
        {
            mc.conn.Open();
            cmd = new OleDbCommand("select DCID from DeliveryChallan where Status = 'Open' ", mc.conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbdcid.Items.Add(dr["DCID"]);
            }

            cmd = new OleDbCommand("select PID from Products where InventoryStatus = 'Not in Hand' ", mc.conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbpid.Items.Add(dr["PID"]);
            }

            cmd = new OleDbCommand("select VID from Vendor where VStatus = 'Active' ", mc.conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbvid.Items.Add(dr["VID"]);
            }

            mc.conn.Close();

        }

        private void cmbdcid_SelectedIndexChanged(object sender, EventArgs e)
        {
            mc.conn.Open();

            cmd = new OleDbCommand("select DDate , DCDate from DeliveryChallan where DCID = '" + cmbdcid.Text + "' ", mc.conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                txtdd.Text = dr["DDate"].ToString();
                dateTimePicker1.Text = dr["DCDate"].ToString();

                txtinv.Text = "Inv-" + cmbdcid.Text;
            }

            mc.conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mc.conn.Open();

            cmd = new OleDbCommand("select VName , PH1 , CPName , CPPH from Vendor where VID = '" + cmbvid.Text + "' ", mc.conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtvname.Text = dr["VName"].ToString();
                txtvphn.Text = dr["PH1"].ToString();
                txtcp.Text = dr["CPName"].ToString();
                txtcpph.Text = dr["CPPH"].ToString();

            }

            mc.conn.Close();
        }

        private void cmbpid_SelectedIndexChanged(object sender, EventArgs e)
        {
            mc.conn.Open();

            cmd = new OleDbCommand("select PName , BasePrice from Products where PID = '" + cmbpid.Text + "' ", mc.conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtpname.Text = dr["PName"].ToString();
                txtpprice.Text = dr["BasePrice"].ToString();
            }

            mc.conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            price = double.Parse(txtpprice.Text);
            tax = price * .17;
            amountpayable = price + tax;
            txtamnt.Text = amountpayable.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mc.conn.Open();

            cmd = new OleDbCommand("insert into InvoiceRecievable (InvoiceNo , VendorID , VendorName , VPhone , ContectPerson , CPPH , ProductName , Price , AmountPayable , DCID , DDate , DCDate ) values (@InvoiceNo , @VendorID , @VendorName , @VPhone , @ContectPerson , @CPPH , @ProductName , @Price , @AmountPayable , @DCID , @DDate , @DCDate)", mc.conn);
            cmd.Parameters.AddWithValue("InvoiceNo", txtinv.Text);
            cmd.Parameters.AddWithValue("VendorID", cmbvid.Text);
            cmd.Parameters.AddWithValue("VendorName", txtvname.Text);
            cmd.Parameters.AddWithValue("VPhone", txtvphn.Text);
            cmd.Parameters.AddWithValue("ContectPerson", txtcp.Text);
            cmd.Parameters.AddWithValue("CPPH", txtcpph.Text);
            cmd.Parameters.AddWithValue("ProductName", txtpname.Text);
            cmd.Parameters.AddWithValue("Price", txtpprice.Text);
            //cmd.Parameters.AddWithValue("STax" , txttax.Text);
            cmd.Parameters.AddWithValue("AmountPayable", double.Parse(txtamnt.Text));
            cmd.Parameters.AddWithValue("DCID", cmbdcid.Text);
            cmd.Parameters.AddWithValue("DDate", txtdd.Text);
            cmd.Parameters.AddWithValue("DCDate", dateTimePicker1.Value.ToShortDateString());

            cmd.ExecuteNonQuery();
            MessageBox.Show("Invoice Recieved!");

            cmd = new OleDbCommand("update DeliveryChallan set Status = 'Close' where DCID = '" + cmbdcid.Text + "' ", mc.conn);

            cmd.ExecuteNonQuery();
            MessageBox.Show("DC status has been closed!");

            mc.conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
