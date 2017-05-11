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
    public partial class PurchOrdApprove : Form
    {
        public OleDbConnection conn;
        public OleDbCommand cmd;
        Myconnection mc;
        public PurchOrdApprove()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mc = new Myconnection();

            mc.conn.Open();

            cmd = new OleDbCommand("update PO set Approve = 'Approved' where POID = '"+txtid.Text+"' ", mc.conn);
            cmd.ExecuteNonQuery();
            mc.conn.Close();
            MessageBox.Show("Approved");
        }

        private void PurchOrdApprove_Load(object sender, EventArgs e)
        {
                       txtid.Text = PurchaseOrder.poid;
        txtdate.Text = PurchaseOrder.date.ToString();
            txtpid.Text = PurchaseOrder.pid;
         txtpname.Text = PurchaseOrder.pname;
         txtprice.Text = PurchaseOrder.price;
         txtqtty.Text = PurchaseOrder.qtty;
         txttotal.Text = PurchaseOrder.totalprce;
         textBox1.Text = PurchaseOrder.showid;
         textBox2.Text = PurchaseOrder.showqtty;
         cmbvid.Text = PurchaseOrder.vid;
          txtvname.Text = PurchaseOrder.vname;
         txtdeptt.Text = PurchaseOrder.deptt;
         txtcp.Text = PurchaseOrder.cp;
         txtcpphn.Text = PurchaseOrder.cpphn;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
