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
    public partial class DeliveryChallan : Form
    {
        public OleDbConnection conn;
        public OleDbCommand cmd;
        public OleDbDataReader dr;

        Myconnection mc = new Myconnection();

        public DeliveryChallan()
        {
            InitializeComponent();
        }

        private void DeliveryChallan_Load(object sender, EventArgs e)
        {
            mc.conn.Open();

            cmd = new OleDbCommand("select POID from POProducts", mc.conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["POID"]);
            }


            cmd = new OleDbCommand("select SOID from SO where Status = 'Open' ", mc.conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["SOID"]);
            }

            mc.conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mc.conn.Open();

            cmd = new OleDbCommand("select PModel , PQty from POProducts where POID = '" + comboBox1.Text + "' ", mc.conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["PModel"].ToString();
                textBox2.Text = dr["PQty"].ToString();
            }


            cmd = new OleDbCommand("select POID from POProducts where POID = '" + comboBox1.Text + "' ", mc.conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox3.Text = "DC_" + dr["POID"].ToString();

            }

            mc.conn.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            mc.conn.Open();

            cmd = new OleDbCommand("select VName , DDate from PO where POID = '" + comboBox2.Text + "' ", mc.conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox4.Text = dr["VName"].ToString();
                textBox6.Text = dr["DDate"].ToString();

            }

            mc.conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mc.conn.Open();

            cmd = new OleDbCommand("insert into DeliveryChallan (DCID , BaseDocument , Status , VName , DDate , DCDate) values (@DCID , @BaseDocument , @Status , @VName , @DDate , @DCDate)", mc.conn);
            cmd.Parameters.AddWithValue("@DCID", textBox3.Text);
            cmd.Parameters.AddWithValue("@BaseDocument", comboBox2.Text);
            cmd.Parameters.AddWithValue("@Status", "Open");
            cmd.Parameters.AddWithValue("@VName", textBox4.Text);
            cmd.Parameters.AddWithValue("@DDate", textBox6.Text);
            cmd.Parameters.AddWithValue("@DCDate", dateTimePicker1.Value);
            cmd.ExecuteNonQuery();


            cmd = new OleDbCommand("Update SO set Status = 'Close', GoodRecieved = 'Yes' where SOID = '" + comboBox2.Text + "' ", mc.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record inserted, Status has been closed!");

            mc.conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
