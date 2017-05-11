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
    public partial class POSUForm : Form
    {

        public OleDbConnection conn;
        public OleDbCommand cmd;
        public OleDbDataReader dr;
        Myconnection mc;
        public POSUForm()
        {
            InitializeComponent();
        }

        private void POSUForm_Load(object sender, EventArgs e)
        {
            mc = new Myconnection();

            mc.conn.Open();

            cmd = new OleDbCommand("select PID from Products", mc.conn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["PID"]);
            }

            mc.conn.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mc.conn.Open();

            cmd = new OleDbCommand("select * from Products where PID = '" + comboBox1.Text + "' ", mc.conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtid.Text = dr["PID"].ToString();
                txtname.Text = dr["PName"].ToString();
                txtprice.Text = dr["BasePrice"].ToString();
                txtwinp.Text = dr["WeightInPounds"].ToString();
                cmbstatus.Text = dr["InventoryStatus"].ToString();
                txtdeliv.Text = dr["EstimatedDelivery"].ToString();
                txtaoh.Text = dr["AmountOnHand"].ToString();
                txtapo.Text = dr["AllowPerOrder"].ToString();
                txtwp.Text = dr["WarrentyPeriod"].ToString();
                txtprdtyp.Text = dr["ProductType"].ToString();


            }

            mc.conn.Close();


        }

        private void btnapp_Click(object sender, EventArgs e)
        {
            mc.conn.Open();

            cmd = new OleDbCommand("Update Products set PID = '" + txtid.Text + "', PName = '" + txtname.Text + "', BasePrice = '" + txtprice.Text + "', WeightInPounds = '" + txtwinp.Text + "',InventoryStatus = '" + cmbstatus.Text + "',  EstimatedDelivery = '" + txtdeliv.Text + "', AmountOnHand = '" + txtaoh.Text + "', AllowPerOrder = '" + txtapo.Text + "', WarrentyPeriod = '" + txtwp.Text + "', ProductType = '" + txtprdtyp.Text + "' where PID = '"+comboBox1.Text+"' ", mc.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has been Updated");
            mc.conn.Close();
        }

        private void btnext_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
