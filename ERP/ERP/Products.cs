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
    public partial class Products : Form
    {
        public OleDbConnection conn;
        public OleDbCommand cmd;
        public OleDbDataReader dr;
        Myconnection mc;

        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            int c = 0;
            mc = new Myconnection();
            mc.conn.Open();

            cmd = new OleDbCommand("select count(PID) from Products",mc.conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            { 
                c = Convert.ToInt32(dr[0]); c++;
                txtid.Text = " Prod-00" + c.ToString() +"-" + System.DateTime.Today.Year;
            }

            mc.conn.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            mc.conn.Open();

            cmd = new OleDbCommand("insert into Products (PID, PName, BasePrice, WeightInPounds, InventoryStatus, EstimatedDelivery, AmountOnHand, AllowPerOrder, WarrentyPeriod, ProductType) values (@PID, @PName, @BasePrice, @WeightInPounds, @InventoryStatus, @EstimatedDelivery, @AmountOnHand, @AllowPerOrder, @WarrentyPeriod, @ProductType) ", mc.conn);
            cmd.Parameters.AddWithValue("@PID",txtid.Text.ToString());
            cmd.Parameters.AddWithValue("@PName",txtname.Text);
            cmd.Parameters.AddWithValue("@BasePrice",txtprice.Text);
            cmd.Parameters.AddWithValue("@WeightInPounds",txtwinp.Text);
            cmd.Parameters.AddWithValue("@InventoryStatus",cmbstatus.Text);
            cmd.Parameters.AddWithValue("@EstimatedDelivery",txtdeliv.Text);
            cmd.Parameters.AddWithValue("@AmountOnHand",txtaoh.Text);
            cmd.Parameters.AddWithValue("@AllowPerOrder",txtapo.Text);
            cmd.Parameters.AddWithValue("@WarrentyPeriod",txtwp.Text.ToString());
            cmd.Parameters.AddWithValue("@ProductType",txtprdtyp.Text);

            MessageBox.Show("Record has been added");
            cmd.ExecuteNonQuery(); 

            mc.conn.Close();
        }

        private void btnext_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            cmbstatus.Text = "";
            txtid.Clear();
            txtname.Clear();
            txtdeliv.Clear();
            txtprice.Clear();
            txtwinp.Clear();
            txtwp.Clear();
            txtprdtyp.Clear();
            txtaoh.Clear();
            txtapo.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            POSUForm suf = new POSUForm();
            this.Hide();
            suf.ShowDialog();
        }

        private void btnapp_Click(object sender, EventArgs e)
        {
            POApprove poa = new POApprove();
            this.Hide();
            poa.ShowDialog();
        }
    }
}
