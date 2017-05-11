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
    public partial class ProductsOrdrer : Form
    {
        public OleDbConnection conn;
        public OleDbCommand cmd;
        Myconnection mc;
        public OleDbDataReader dr;


        public static String id;
        public static String dte;
        public static String approve;
        public static String name;
        public static String vid;
        public static String cp;
        public static String cpph;
        public static String amount;
        public static String good;
        public static String status;
        public static String deptt;



        public ProductsOrdrer()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            mc = new Myconnection();

            mc.conn.Open();

            cmd = new OleDbCommand("select GrpName from CusGroup" ,mc.conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbdptt.Items.Add(dr["GrpName"]);
            }

            mc.conn.Close();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            mc.conn.Open();
            cmd = new OleDbCommand("insert into PO (POID , DDate , Status , Approve , VDept , VName , VID , VContectPerson , VCPPH , TotalAmount , GoodRecieved) values (@POID , @DDate , @Status , @Approve , @VDept , @VName , @VID , @VContectPerson , @VCPPH , @TotalAmount , @GoodRecieved)", mc.conn);
            cmd.Parameters.AddWithValue("@POID" , txtid.Text.ToString());
            cmd.Parameters.AddWithValue("@DDate" , dateTimePicker1.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("@Status" , cmbstatus.Text);
            cmd.Parameters.AddWithValue("@Approve" , cmpappr.Text);
            cmd.Parameters.AddWithValue("@VDept" , cmbdptt.Text);
            cmd.Parameters.AddWithValue("@VName" , txtname.Text);
            cmd.Parameters.AddWithValue("@VID" , txtvid.Text.ToString());
            cmd.Parameters.AddWithValue("@VContectPerson" , txtvcp.Text);
            cmd.Parameters.AddWithValue("@VCPPH" , txtcpphn.Text);
            cmd.Parameters.AddWithValue("@TotalAmount" , txttotamnt.Text);
            cmd.Parameters.AddWithValue("@GoodRecieved" , txtgood.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Added");
            mc.conn.Close();
        }

        private void ProductsOrdrer_Load(object sender, EventArgs e)
        {
            mc = new Myconnection();
            int c = 0;
            mc.conn.Open();

            cmd = new OleDbCommand("select count(POID) from PO where Approve = 'Not Approve' ", mc.conn);

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                c = Convert.ToInt32(dr[0]); c++;
                txtid.Text = "PO-" + c.ToString() + "-" + System.DateTime.Today.Year;
            }

            mc.conn.Close();
        }

        private void btnapp_Click(object sender, EventArgs e)
        {
            id = txtid.Text;
            dte = dateTimePicker1.Value.ToShortDateString();
            status = cmbstatus.Text;
            deptt = cmbdptt.Text;
            approve = cmpappr.Text;
            vid = txtvid.Text;
            name = txtname.Text;
            cp = txtvcp.Text;
            cpph = txtcpphn.Text;
            amount = txttotamnt.Text;
            good = txtgood.Text;

            POApprove poa = new POApprove();
            this.Hide();
            poa.ShowDialog();

        }

        private void btnext_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            //txtid.Clear(); 
            //dte = dateTimePicker1.Value.ToShortDateString();
            //status = cmbstatus.Text;
            //deptt = cmbdptt.Text;
            //approve = cmpappr.Text;
            //vid = txtvid.Text;
            //name = txtname.Text;
            //cp = txtvcp.Text;
            //cpph = txtcpphn.Text;
            //amount = txttotamnt.Text;
            //good = txtgood.Text;

            txtid.Clear();
            dateTimePicker1.Value = System.DateTime.Now;
            cmbstatus.Text = "";
            cmbdptt.Text = "";
            cmpappr.Text = "";
            txtvid.Text = "";
            txtname.Text = "";
            txtvcp.Clear();
            txtcpphn.Clear();
            txttotamnt.Clear();
            txtgood.Text = "";
        }

        private void cmbdptt_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c = 0;
            mc.conn.Open();
            cmd = new OleDbCommand("select count(VID) from PO where VDept  = '"+cmbdptt.Text+"' " , mc.conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                c = Convert.ToInt32(dr[0]); c++;            
            }
            if (cmbdptt.Text == "Consumer")
            {
                txtvid.Text = "Cons-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }
            else if (cmbdptt.Text == "HR")
            {
                txtvid.Text = "HR-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }
            else if (cmbdptt.Text == "Marketing")
            {
                txtvid.Text = "Mar-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }
            else if (cmbdptt.Text == "Sales")
            {
                txtvid.Text = "Sal-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }
            else
            {
                MessageBox.Show("Please select Department");
            }
            mc.conn.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
