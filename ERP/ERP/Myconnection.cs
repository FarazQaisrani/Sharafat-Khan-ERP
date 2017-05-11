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
    public partial class Myconnection : Form
    {
        public OleDbConnection conn;
        public Myconnection()
        {
            InitializeComponent();
            conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sharafat Khan\Desktop\Sharafat Khan ERP\PC_DB.accdb";
        }

        private void Myconnection_Load(object sender, EventArgs e)
        {

        }
    }
}
