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

namespace Grifindo_Toys_Factory
{
    public partial class Setting_Components : Form
    {
        SqlConnection Con = new SqlConnection();
        public Setting_Components()
        {
            InitializeComponent();
            Con = new SqlConnection(@"Data Source=JMSPUNSARAMSI\SQLEXPRESS;Initial Catalog=Grifindo_Toys_Factory;Integrated Security=True;");

        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            string start_date = Convert.ToDateTime(dtp_salarycyclestartdate.Text).ToString("yyyy-MM-dd");
            string end_date = Convert.ToDateTime(dtp_salarycycleenddate.Text).ToString("yyyy-MM-dd");

            //==============Insert Button Code========================
            try
            {
                Con.Open();
                String query = "insert into settingData(SetId,EmpId,SalaryCycleDataRange,SalaryCycleStartDate,SalaryCycleEndDate,AbsentDays,LeavesTaken,OvertimeHours,GovermentTaxRate) values('" + txt_setid.Text + "','" + txt_empid.Text + "', '" + txt_salarycycledatarange.Text + "', '" + start_date + "', '" + end_date + "', '" + txt_absentdays.Text + "', '" + txt_leavestaken.Text + "', '" + txt_overtimehours.Text + "', '" + txt_govermenttaxrate.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Setting Components Insert Successfully", "Setting Data");
                }
                Con.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //===============Delete Button Code========================
            Con.Open();

            string SetId = txt_setid.Text;

            string sql_delete = "DELETE FROM settingData WHERE SetId = '" + txt_setid.Text + "'";

            SqlCommand cmd = new SqlCommand(sql_delete, Con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Delete Successfully", "Setting Component", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            Con.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //====================Update Button Code============================
            string connectionString = "Data Source=JMSPUNSARAMSI\\SQLEXPRESS;Initial Catalog=Grifindo_Toys_Factory;Integrated Security=True;";
            SqlConnection Con = new SqlConnection(connectionString);

            try
            {
                Con.Open();

                string updateQuery = "UPDATE settingData SET EmpId = @EmpId, SalaryCycleDataRange = @SalaryCycleDataRange, SalaryCycleStartDate = @SalaryCycleStartDate, SalaryCycleEndDate = @SalaryCycleEndDate, AbsentDays = @AbsentDays, LeavesTaken = @LeavesTaken, OvertimeHours = @OvertimeHours, GovermentTaxRate = @GovermentTaxRate WHERE SetId = @SetId";

                SqlCommand command = new SqlCommand(updateQuery, Con);
                command.Parameters.AddWithValue("SetId", txt_setid.Text);
                command.Parameters.AddWithValue("@EmpId", txt_empid.Text);
                command.Parameters.AddWithValue("@SalaryCycleDataRange", txt_salarycycledatarange.Text);
                command.Parameters.AddWithValue("SalaryCycleStartDate", dtp_salarycyclestartdate.Text);
                command.Parameters.AddWithValue("SalaryCycleEndDate", dtp_salarycycleenddate.Text);
                command.Parameters.AddWithValue("AbsentDays", txt_absentdays.Text);
                command.Parameters.AddWithValue("LeavesTaken", txt_leavestaken.Text);
                command.Parameters.AddWithValue("OvertimeHours", txt_overtimehours.Text);
                command.Parameters.AddWithValue("GovermentTaxRate", txt_govermenttaxrate.Text);

                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully " + rowsAffected);
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
            //=================Search Button Code===========================
            Con.Open();
            string SetId = txt_setid.Text;

            string sql_search = "SELECT * FROM settingData WHERE SetId = '" + txt_setid.Text + "'";

            SqlCommand cmd = new SqlCommand(sql_search, Con);

            SqlDataReader r = cmd.ExecuteReader();

            if (r.Read())
            {
                txt_setid.Text = r["SetId"].ToString();
                txt_empid.Text = r["EmpId"].ToString();
                txt_salarycycledatarange.Text = r["SalaryCycleDataRange"].ToString();
                dtp_salarycyclestartdate.Text = r["SalaryCycleStartDate"].ToString();
                dtp_salarycycleenddate.Text = r["SalaryCycleEndDate"].ToString();
                txt_absentdays.Text = r["AbsentDays"].ToString();
                txt_leavestaken.Text = r["LeavesTaken"].ToString();
                txt_overtimehours.Text = r["OvertimeHours"].ToString();
                txt_govermenttaxrate.Text = r["GovermentTaxRate"].ToString();
                MessageBox.Show("Found Successfully", "Setting Data");
            }
            else
            {
                txt_setid.Text = null;
                txt_empid.Text = null;
                txt_salarycycledatarange.Text = null;
                dtp_salarycyclestartdate.Text = null;
                dtp_salarycycleenddate. Text = null;
                txt_absentdays.Text = null;
                txt_leavestaken.Text = null;
                txt_overtimehours.Text = null;
                txt_govermenttaxrate.Text = null;
                MessageBox.Show("Not Found", "Setting Data");
            }
            Con.Close();
        }


        private void btn_Search2_Click(object sender, EventArgs e)
        {
            //==================Search Button 2 Code=========================
            Con.Open();
            string SetId = txt_setid.Text;

            string sql_search = "SELECT * FROM settingData WHERE SetId = '" + txt_setid.Text + "'";

            SqlCommand cmd = new SqlCommand(sql_search, Con);

            SqlDataReader r = cmd.ExecuteReader();

            if (r.Read())
            {
                txt_setid.Text = r["SetId"].ToString();
                txt_empid.Text = r["EmpId"].ToString();
                txt_salarycycledatarange.Text = r["SalaryCycleDataRange"].ToString();
                dtp_salarycyclestartdate.Text = r["SalaryCycleStartDate"].ToString();
                dtp_salarycycleenddate.Text = r["SalaryCycleEndDate"].ToString();
                txt_absentdays.Text = r["AbsentDays"].ToString();
                txt_leavestaken.Text = r["LeavesTaken"].ToString();
                txt_overtimehours.Text = r["OvertimeHours"].ToString();
                txt_govermenttaxrate.Text = r["GovermentTaxRate"].ToString();
                MessageBox.Show("Found Successfully", "Setting Data");
            }
            else
            {
                txt_setid.Text = null;
                txt_empid.Text = null;
                txt_salarycycledatarange.Text = null;
                dtp_salarycyclestartdate.Text = null;
                dtp_salarycycleenddate.Text = null;
                txt_absentdays.Text = null;
                txt_leavestaken.Text = null;
                txt_overtimehours.Text = null;
                txt_govermenttaxrate.Text = null;
                MessageBox.Show("Not Found", "Setting Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            //=======================Refresh All DataGridView Data Button Code=======================
            Con.Open();

            SqlDataAdapter data = new SqlDataAdapter(@"SELECT * FROM settingData", Con);

            DataTable t = new DataTable();

            dgv_setting.DataSource = t;

            data.Fill(t);
            MessageBox.Show("Refresh All Data", "Setting Data");

            Con.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            //====================Clear All Text Box Button Code============================
            txt_setid.Clear();
            txt_empid.Clear();
            txt_salarycycledatarange.Clear();
            txt_absentdays.Clear();
            txt_leavestaken.Clear();
            txt_overtimehours.Clear();
            txt_govermenttaxrate.Clear();
            dtp_salarycyclestartdate.Value = DateTime.Now;
            dtp_salarycycleenddate.Value = DateTime.Now;
            MessageBox.Show("Cleared Successfully", "Setting Data");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Grifindo_Payroll_Menu newform = new Grifindo_Payroll_Menu();
            newform.ShowDialog();
            this.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void dtp_salarycycleenddate_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dtp_salarycyclestartdate.Value;
            DateTime endDate = dtp_salarycycleenddate.Value;

            int allowedDays = 30;

            if ((endDate - startDate).Days > allowedDays)

            {
                MessageBox.Show("Error:Only 30 Days salry Cycle Date Range", "Date Range Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Setting_Components_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grifindo_Toys_FactoryDataSet2.settingData' table. You can move, or remove it, as needed.
            this.settingDataTableAdapter.Fill(this.grifindo_Toys_FactoryDataSet2.settingData);

        }
    }
}
