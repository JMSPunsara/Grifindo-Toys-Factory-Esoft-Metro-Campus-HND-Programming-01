using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Toys_Factory
{
    public partial class Insert_Employee : Form
    {
        SqlConnection Con = new SqlConnection();
        public Insert_Employee()
        {
            InitializeComponent();
            Con = new SqlConnection(@"Data Source=JMSPUNSARAMSI\SQLEXPRESS;Initial Catalog=Grifindo_Toys_Factory;Integrated Security=True;");
        }

        
        private void btn_insert_Click(object sender, EventArgs e)
        {
            //=====================Insert Button Code============================
            string emp_dob = Convert.ToDateTime(dtp_empdob.Text).ToString("yyyy-MM-dd");
            try
            {
                Con.Open();
                String query = "insert into employeeData(EmpName,EmpAddress,EmpDOB,EmpGender,EmpContact,EmpEmail,MonthSalary,EmpVacancy) values('" + txt_empname.Text + "','" + txt_empaddress.Text + "', '" + emp_dob + "', '" + cb_empgender.Text + "', '" + txt_empcontact.Text + "', '" + txt_empemail.Text + "', '" + txt_empmonthsalary.Text + "', '" + cb_empvacancy.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Employee Insert Successfully");
                }
                Con.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            //===================Clear All Text Box Button Code==============================
            txt_empname.Clear();
            txt_empaddress.Clear();
            dtp_empdob.Value = DateTime.Now;
            txt_empcontact.Clear();
            txt_empemail.Clear();
            txt_empmonthsalary.Clear();
            cb_empgender.SelectedIndex = 0;
            cb_empvacancy.SelectedIndex = 0;
            MessageBox.Show("Cleared Successfully");

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_Menu newform = new Employee_Menu();
            newform.ShowDialog();
            this.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
