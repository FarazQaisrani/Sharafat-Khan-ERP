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
    public partial class Login : Form
    {
        

        public Login()
        {
            InitializeComponent();
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            String user = "admin";
            String pwd = "admin";

            if (txtuser.Text == user && txtpwd.Text == pwd)
            {
                //MessageBox.Show("Login Successfull");
                Main main = new Main();
                this.Hide();
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtpwd.Clear();
            txtuser.Clear();
        }

        private void txtpwd_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                String user = "admin";
                String pwd = "admin";

                if (txtuser.Text == user && txtpwd.Text == pwd)
                {
                    //MessageBox.Show("Login Successfull");
                    Main main = new Main();
                    this.Hide();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
            }
        }

       
        }


    }

