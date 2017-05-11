using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            radcm.Visible = false;
            radvm.Visible = false;
            btnok.Visible = false;
        }

        private void btnbp_Click(object sender, EventArgs e)
        {
            radvm.Visible = true;
            radcm.Visible = true;
            btnok.Visible = true;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if(radcm.Checked)
            {
                Form1 frm = new Form1();
                this.Hide();
                frm.ShowDialog();
            }
            else if(radvm.Checked)
            {
                Vendor ven = new Vendor();
                this.Hide();
                ven.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select anyone option");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button9_Click(object sender, EventArgs e)
        {
            SalesOrder so = new SalesOrder();
            this.Hide();
            so.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PurchaseOrder purord = new PurchaseOrder();
            this.Hide();
            purord.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            GRN grn = new GRN();
            this.Hide();
            grn.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Invoice inv = new Invoice();
            this.Hide();
            inv.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Products prdct = new Products();
            this.Hide();
            prdct.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ProductsOrdrer prodord = new ProductsOrdrer();
            this.Hide();
            prodord.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DeliveryChallan dc = new DeliveryChallan();
            this.Hide();
            dc.ShowDialog();
            
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            InvoiceRec invrec = new InvoiceRec();
            this.Hide();
            invrec.ShowDialog();
        }
    }
}
