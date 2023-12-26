using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Toys_Factory
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //================Login Button Code====================
            string username = "Administrator";
            string password = "Pass@GrifindoToys";


            if (txt_username.Text == username && txt_password.Text == password)
            {
                MessageBox.Show("Welcome back, Successfully Login", "Security Check Version 1.0");
                this.Hide();
                Grifindo_Payroll_Menu frm2 = new Grifindo_Payroll_Menu();
                frm2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Unsuccessfully Login, Please Check Your Username & Password", "Security Check Version 1.0");
            }
        }

        private void cb_show_CheckedChanged(object sender, EventArgs e)
        {
            //=====================Show Password Combo Box===============
            if (cb_show.Checked == true)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar= true;
            }
        }
    }
}
