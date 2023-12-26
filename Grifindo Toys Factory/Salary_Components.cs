using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Toys_Factory
{
    public partial class Salary_Components : Form
    {
        SqlConnection Con = new SqlConnection();
        public Salary_Components()
        {
            InitializeComponent();
            Con = new SqlConnection(@"Data Source=JMSPUNSARAMSI\SQLEXPRESS;Initial Catalog=Grifindo_Toys_Factory;Integrated Security=True;");
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //=============ADD BUTTON CODE=============
            string SalaryMonth = Convert.ToDateTime(dtp_salarymonth.Text).ToString("yyyy-MM");
            string connectionString = "Data Source=JMSPUNSARAMSI\\SQLEXPRESS;Initial Catalog=Grifindo_Toys_Factory;Integrated Security=True;";
            SqlConnection Con = new SqlConnection(connectionString);
            try
            {
                int RecordId = int.Parse(txt_recordid.Text);                

                decimal Salary = decimal.Parse(txt_monthsalary.Text);
                decimal OTRate = decimal.Parse(txt_overtimerate.Text);
                decimal Allowances = decimal.Parse(txt_allowances.Text);
                decimal TaxRate = decimal.Parse(txt_govertaxrate.Text);
                int SalCyDateRange = int.Parse(txt_salarycycle.Text);
                int AbsentDays = int.Parse(txt_absent.Text);
                decimal OTHours = decimal.Parse(txt_overtimehours.Text);

                decimal basePay = Salary + Allowances + (OTRate * OTHours);
                decimal OTPay = OTRate * OTHours;
                decimal calculatedTax = (basePay * TaxRate) / 100;
                decimal noPay = ((Salary + Allowances) / SalCyDateRange) * AbsentDays;
                decimal grossPay = (basePay - (noPay + calculatedTax));
                lbl_basepay.Text = basePay.ToString();
                lbl_grosspay.Text = grossPay.ToString();
                lbl_nopay.Text = noPay.ToString();



                try
                {
                    Con.Open();
                    String query = "INSERT INTO salaryData (RecordId , basePay, OTPay, calculatedTax, noPay, grossPay, EmpId, SalaryMonth) VALUES ('" + RecordId+"','"+basePay+"','"+OTPay+"', '"+ calculatedTax + "','"+noPay+"','"+grossPay+"', '"+ txt_employeeid.Text+ "', '"+SalaryMonth+"')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Record saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Con.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            //=============SEARCH BUTTON CODE=============
            Con.Open();
            string RecordId = txt_recordid.Text;

            string sql_search = "SELECT * FROM salaryData WHERE RecordId = " + txt_recordid.Text + "";

            SqlCommand cmd = new SqlCommand(sql_search, Con);

            SqlDataReader r = cmd.ExecuteReader();

            if (r.Read())
            {
                txt_recordid.Text = r["RecordId"].ToString();
                txt_employeeid.Text = r["EmpId"].ToString();
                lbl_basepay.Text = r["basePay"].ToString();
                lbl_grosspay.Text = r["grossPay"].ToString();
                lbl_nopay.Text = r["noPay"].ToString();
                dtp_salarymonth.Text = r["SalaryMonth"].ToString();
                MessageBox.Show("Found Successfully", "Salary Data");
            }
            else
            {
                txt_recordid.Text = null;
                txt_employeeid.Text = null;
                lbl_basepay.Text = null;
                lbl_grosspay.Text = null;
                lbl_nopay.Text = null;
                dtp_salarymonth.Text= null;
                MessageBox.Show("Not Found", "Salary Data");
            }
            Con.Close();
        }

        

        private void btn_clear_Click(object sender, EventArgs e)
        {
            //=============CLEAR BUTTON CODE=============
            txt_recordid.Clear();
            txt_absent.Clear();
            txt_leaves.Clear();
            txt_overtimehours.Clear();
            txt_overtimerate.Clear();
            txt_employeeid.Clear();
            txt_govertaxrate.Clear();
            txt_allowances.Clear();
            txt_salarycycle.Clear();
            txt_monthsalary.Clear();
            dtp_salarymonth.Value = DateTime.Now;
            MessageBox.Show("Cleared Successfully", "Salary Data");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //=============DELETE BUTTON CODE=============
            Con.Open();

            string SetId = txt_recordid.Text;

            string sql_delete = "DELETE FROM salaryData WHERE RecordId = '" + txt_recordid.Text + "'";

            SqlCommand cmd = new SqlCommand(sql_delete, Con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Delete Successfully", "Salary Component", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Grifindo_Payroll_Menu newform = new Grifindo_Payroll_Menu();
            newform.ShowDialog();
            this.Show();
        }

        private void btn_Search2_Click(object sender, EventArgs e)
        {
            //=============SEARCH BUTTON CODE=============
            Con.Open();
            string RecordId = txt_recordid.Text;

            string sql_search = "SELECT * FROM salaryData WHERE RecordId = " + txt_recordid.Text + "";

            SqlCommand cmd = new SqlCommand(sql_search, Con);

            SqlDataReader r = cmd.ExecuteReader();

            if (r.Read())
            {
                txt_recordid.Text = r["RecordId"].ToString();
                txt_employeeid.Text = r["EmpId"].ToString();
                lbl_basepay.Text = r["basePay"].ToString();
                lbl_grosspay.Text = r["grossPay"].ToString();
                lbl_nopay.Text = r["noPay"].ToString();
                dtp_salarymonth.Text = r["SalaryMonth"].ToString();
                MessageBox.Show("Found Successfully", "Salary Data");
            }
            else
            {
                txt_recordid.Text = null;
                txt_employeeid.Text = null;
                lbl_basepay.Text = null;
                lbl_grosspay.Text = null;
                lbl_nopay.Text = null;
                dtp_salarymonth.Text = null;
                MessageBox.Show("Not Found", "Salary Data");
            }
            Con.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dgv_salary.Width, dgv_salary.Height);
            dgv_salary.DrawToBitmap(imagebmp, new Rectangle(0, 0, dgv_salary.Width, dgv_salary.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            //=============PRINT BUTTON CODE=============
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void Salary_Components_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grifindo_Toys_FactoryDataSet1.salaryData' table. You can move, or remove it, as needed.
            this.salaryDataTableAdapter.Fill(this.grifindo_Toys_FactoryDataSet1.salaryData);

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ////=============REFRESH ALL DATA BUTTON CODE======================
            Con.Open();

            SqlDataAdapter data = new SqlDataAdapter(@"SELECT * FROM salaryData", Con);

            DataTable t = new DataTable();

            dgv_salary.DataSource = t;

            data.Fill(t);
            MessageBox.Show("View all Data Successfully", "Salary Component", MessageBoxButtons.OK, MessageBoxIcon.None);

            Con.Close();
        }
    }
}
