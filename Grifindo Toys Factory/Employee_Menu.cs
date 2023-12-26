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
    public partial class Employee_Menu : Form
    {
        public Employee_Menu()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Grifindo_Payroll_Menu newform = new Grifindo_Payroll_Menu();
            newform.ShowDialog();
            this.Show();
        }

        private void pb_registeremployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Insert_Employee newform = new Insert_Employee();
            newform.ShowDialog();
            this.Show();
        }

        private void lbl_registeremployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Insert_Employee newform = new Insert_Employee();
            newform.ShowDialog();
            this.Show();
        }


        private void pb_employeemanage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_Components newform = new Employee_Components();
            newform.ShowDialog();
            this.Show();
        }

        private void lbl_employeemanage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_Components newform = new Employee_Components();
            newform.ShowDialog();
            this.Show();
        }
    }
}
