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
    public partial class SOApprove : Form
    {
        public OleDbConnection conn;
        public OleDbCommand cmd;
        Myconnection mc;

        public SOApprove()
        {
            InitializeComponent();
        }

        private void SOApprove_Load(object sender, EventArgs e)
        {
            txtid.Text = SalesOrder.poid;
            txtdate.Text = SalesOrder.date.ToString();
            txtpid.Text = SalesOrder.pid;
            txtpname.Text = SalesOrder.pname;
            txtprice.Text = SalesOrder.price;
            txtqtty.Text = SalesOrder.qtty;
            txttotal.Text = SalesOrder.totalprce;
            textBox1.Text = SalesOrder.showid;
            textBox2.Text = SalesOrder.showqtty;
            cmbvid.Text = SalesOrder.vid;
            txtvname.Text = SalesOrder.vname;
            txtdeptt.Text = SalesOrder.deptt;
            txtcp.Text = SalesOrder.cp;
            txtcpphn.Text = SalesOrder.cpphn;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mc = new Myconnection();

            mc.conn.Open();

            cmd = new OleDbCommand("update SO set Approve = 'Approved' where SOID = '" + txtid.Text + "' ", mc.conn);
            cmd.ExecuteNonQuery();
            mc.conn.Close();
            MessageBox.Show("Approved");
        }
    }
}
