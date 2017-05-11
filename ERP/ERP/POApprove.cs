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
    public partial class POApprove : Form
    {
        public OleDbConnection conn;
        public OleDbCommand cmd;
        Myconnection mc;
        public POApprove()
        {
            InitializeComponent();
        }

        private void POApprove_Load(object sender, EventArgs e)
        {
            txtid.Text = ProductsOrdrer.id ;
            textBox1.Text = ProductsOrdrer.dte.ToString();
            cmbstatus.Text = ProductsOrdrer.status;
            cmbdptt.Text = ProductsOrdrer.deptt;
            cmpappr.Text = ProductsOrdrer.approve;
            txtvid.Text = ProductsOrdrer.vid;
            txtname.Text = ProductsOrdrer.name;
           txtvcp.Text = ProductsOrdrer.cp;
            txtcpphn.Text = ProductsOrdrer.cpph;
            txttotamnt.Text = ProductsOrdrer.amount;
            txtgood.Text = ProductsOrdrer.good;
        }

        private void btnapp_Click(object sender, EventArgs e)
        {
            mc = new Myconnection();
            mc.conn.Open();

            cmd = new OleDbCommand("Update PO set Approve = 'Approved' where POID = '"+txtid.Text+"'",mc.conn);

            MessageBox.Show("Approved");
            cmd.ExecuteNonQuery();

            mc.conn.Close();
        }

        private void btnext_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
