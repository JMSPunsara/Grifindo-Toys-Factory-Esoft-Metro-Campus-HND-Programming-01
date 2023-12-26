using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Grifindo_Toys_Factory
{
    
    public partial class Employee_Components : Form
    {
        SqlConnection Con = new SqlConnection();
        public Employee_Components()
        {
            InitializeComponent();
            Con = new SqlConnection(@"Data Source=JMSPUNSARAMSI\SQLEXPRESS;Initial Catalog=Grifindo_Toys_Factory;Integrated Security=True;");

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //==============Update Button Code=======================
            string connectionString = "Data Source=JMSPUNSARAMSI\\SQLEXPRESS;Initial Catalog=Grifindo_Toys_Factory;Integrated Security=True;";
            SqlConnection Con = new SqlConnection(connectionString);

            try
            {
                Con.Open();

                string updateQuery = "UPDATE employeeData SET EmpName = @EmpName, EmpAddress = @EmpAddress, EmpDOB = @EmpDOB, EmpGender = @EmpGender, EmpContact = @EmpContact, EmpEmail = @EmpEmail, MonthSalary = @MonthSalary, EmpVacancy = @EmpVacancy, EmpAllowances = @EmpAllowances, EmpOvertimeRate = @EmpOvertimeRate, EmpLeaves = @EmpLeaves, EmpHoliday = @EmpHoliday WHERE EmpId = @EmpId";

                SqlCommand command = new SqlCommand(updateQuery, Con);
                command.Parameters.AddWithValue("EmpId", txt_empid.Text);
                command.Parameters.AddWithValue("@EmpName", txt_empname.Text);
                command.Parameters.AddWithValue("@EmpAddress", txt_empaddress.Text);
                command.Parameters.AddWithValue("EmpDOB", dtp_DOB.Text);
                command.Parameters.AddWithValue("EmpGender", cb_gender.Text);
                command.Parameters.AddWithValue("EmpContact", txt_contact.Text);
                command.Parameters.AddWithValue("EmpEmail", txt_empemail.Text);
                command.Parameters.AddWithValue("MonthSalary", txt_monthsalary.Text);
                command.Parameters.AddWithValue("EmpVacancy", cb_empvacancy.Text);
                command.Parameters.AddWithValue("EmpAllowances", txt_allowances.Text);
                command.Parameters.AddWithValue("EmpOvertimeRate", txt_overtimerate.Text);
                command.Parameters.AddWithValue("EmpLeaves", txt_leaves.Text);
                command.Parameters.AddWithValue("EmpHoliday", txt_holiday.Text);

                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show("Update Successfully: " + rowsAffected);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //===============Search Button Code===================
            Con.Open();
            string EmpId = txt_empid.Text;

            string sql_search = "SELECT * FROM employeeData WHERE EmpId = '" + txt_empid.Text + "'";

            SqlCommand cmd = new SqlCommand(sql_search, Con);

            SqlDataReader r = cmd.ExecuteReader();

            if (r.Read()) 
            {
                txt_empname.Text = r["EmpName"].ToString();
                txt_empaddress.Text = r["EmpAddress"].ToString();
                dtp_DOB.Text = r["EmpDOB"].ToString();
                cb_gender.Text = r["EmpGender"].ToString();
                txt_contact.Text = r["EmpContact"].ToString();
                txt_empemail.Text = r["EmpEmail"].ToString();
                txt_monthsalary.Text = r["MonthSalary"].ToString();
                cb_empvacancy.Text = r["EmpVacancy"].ToString();
                txt_allowances.Text = r["EmpAllowances"].ToString();
                txt_overtimerate.Text = r["EmpOvertimeRate"].ToString();
                txt_leaves.Text = r["EmpLeaves"].ToString();
                txt_holiday.Text = r["EmpHoliday"].ToString();
                MessageBox.Show("Found Successfully", "Employee Component", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txt_empname.Text = null;
                txt_empaddress.Text = null;
                dtp_DOB.Text = null;
                cb_gender.Text = null;
                txt_contact.Text= null;
                txt_empemail.Text = null;
                txt_monthsalary.Text = null;
                cb_empvacancy.Text = null;
                txt_allowances.Text = null;
                txt_overtimerate.Text= null;
                txt_leaves.Text = null;
                txt_holiday.Text= null;
                MessageBox.Show("Not Found");
            }
            Con.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //===========Delete Button Code===========
            Con.Open();

            string EmpId = txt_empid.Text;

            string sql_delete = "DELETE FROM employeeData WHERE EmpId = '" + txt_empid.Text + "'";

            SqlCommand cmd = new SqlCommand(sql_delete, Con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Delete Successfully", "Employee Component", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            Con.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            //===========Refresh All Employee Data Button Code===================
            Con.Open();

            SqlDataAdapter data = new SqlDataAdapter(@"SELECT * FROM employeeData", Con);

            DataTable t = new DataTable();

            dgv_employee.DataSource = t;

            data.Fill(t);
            MessageBox.Show("Refresh All Data Successfully");

            Con.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            //================Clear All Text Box Button Code=======================
            txt_empid.Clear();
            txt_empname.Clear();
            txt_empaddress.Clear();
            dtp_DOB.Value=DateTime.Now;
            txt_contact.Clear();
            txt_empemail.Clear();
            txt_monthsalary.Clear();
            txt_allowances.Clear();
            txt_overtimerate.Clear();
            txt_leaves.Clear();
            txt_holiday.Clear();
            cb_empvacancy.SelectedIndex = 0;
            cb_gender.SelectedIndex = 0;
            MessageBox.Show("Cleared Successfully");
        }

        private void btn_Search2_Click(object sender, EventArgs e)
        {
            //================Instant Search Button Code============================
            Con.Open();
            string EmpId = txt_empid.Text;

            string sql_search = "SELECT * FROM employeeData WHERE EmpId = '" + txt_empid.Text + "'";

            SqlCommand cmd = new SqlCommand(sql_search, Con);

            SqlDataReader r = cmd.ExecuteReader();

            if (r.Read())
            {
                txt_empname.Text = r["EmpName"].ToString();
                txt_empaddress.Text = r["EmpAddress"].ToString();
                dtp_DOB.Text = r["EmpDOB"].ToString();
                cb_gender.Text = r["EmpGender"].ToString();
                txt_contact.Text = r["EmpContact"].ToString();
                txt_empemail.Text = r["EmpEmail"].ToString();
                txt_monthsalary.Text = r["MonthSalary"].ToString();
                cb_empvacancy.Text = r["EmpVacancy"].ToString();
                txt_allowances.Text = r["EmpAllowances"].ToString();
                txt_overtimerate.Text = r["EmpOvertimeRate"].ToString();
                txt_leaves.Text = r["EmpLeaves"].ToString();
                txt_holiday.Text = r["EmpHoliday"].ToString();
                MessageBox.Show("Found Successfully","Employee Component",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txt_empname.Text = null;
                txt_empaddress.Text = null;
                dtp_DOB.Text = null;
                cb_gender.Text = null;
                txt_contact.Text = null;
                txt_empemail.Text = null;
                txt_monthsalary.Text = null;
                cb_empvacancy.Text = null;
                txt_allowances.Text = null;
                txt_overtimerate.Text = null;
                txt_leaves.Text = null;
                txt_holiday.Text = null;
                MessageBox.Show("Not Found");
            }
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_Menu newform = new Employee_Menu();
            newform.ShowDialog();
            this.Show();
        }

        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dgv_employee.Width, dgv_employee.Height);
            dgv_employee.DrawToBitmap(imagebmp, new Rectangle(0, 0, dgv_employee.Width, dgv_employee.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            //==================Print Button Code================
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void Employee_Components_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grifindo_Toys_FactoryDataSet.employeeData' table. You can move, or remove it, as needed.
            this.employeeDataTableAdapter.Fill(this.grifindo_Toys_FactoryDataSet.employeeData);

        }
    }
}
