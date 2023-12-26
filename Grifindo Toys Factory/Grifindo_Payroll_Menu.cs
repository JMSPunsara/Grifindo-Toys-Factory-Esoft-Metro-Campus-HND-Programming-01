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
    public partial class Grifindo_Payroll_Menu : Form
    {
        public Grifindo_Payroll_Menu()
        {
            InitializeComponent();
        }


        private void pb_employee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_Menu newform = new Employee_Menu();
            newform.ShowDialog();
            this.Show();
        }

        private void pb_salaries_Click(object sender, EventArgs e)
        {
            this.Hide();
            Salary_Components newform = new Salary_Components();
            newform.ShowDialog();
            this.Show();
        }

        private void lbl_salaries_Click(object sender, EventArgs e)
        {
            this.Hide();
            Salary_Components newform = new Salary_Components();
            newform.ShowDialog();
            this.Show();
        }

        private void pb_settings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Setting_Components newform = new Setting_Components();
            newform.ShowDialog();
            this.Show();
        }

        private void lbl_settings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Setting_Components newform = new Setting_Components();
            newform.ShowDialog();
            this.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
