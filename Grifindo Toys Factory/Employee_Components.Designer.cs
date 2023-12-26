namespace Grifindo_Toys_Factory
{
    partial class Employee_Components
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Components));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.txt_leaves = new System.Windows.Forms.TextBox();
            this.txt_overtimerate = new System.Windows.Forms.TextBox();
            this.txt_allowances = new System.Windows.Forms.TextBox();
            this.txt_monthsalary = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_empaddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_empname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_empid = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_holiday = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgv_employee = new System.Windows.Forms.DataGridView();
            this.employeeDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grifindo_Toys_FactoryDataSet = new Grifindo_Toys_Factory.Grifindo_Toys_FactoryDataSet();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_empemail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_empvacancy = new System.Windows.Forms.ComboBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_Search2 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btn_print = new System.Windows.Forms.Button();
            this.employeeDataTableAdapter = new Grifindo_Toys_Factory.Grifindo_Toys_FactoryDataSetTableAdapters.employeeDataTableAdapter();
            this.employeeComponentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpVacancy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpAllowances = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpOvertimeRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpLeaves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpHoliday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindo_Toys_FactoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeComponentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1546, 44);
            this.panel1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Grifindo_Toys_Factory.Properties.Resources.Go_Back;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1444, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 44);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee Components";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Grifindo_Toys_Factory.Properties.Resources.Cancel;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1495, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 44);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_gender
            // 
            this.cb_gender.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "",
            "Male",
            "Female"});
            this.cb_gender.Location = new System.Drawing.Point(230, 223);
            this.cb_gender.Margin = new System.Windows.Forms.Padding(4);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(441, 30);
            this.cb_gender.TabIndex = 48;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dtp_DOB.Location = new System.Drawing.Point(230, 181);
            this.dtp_DOB.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(441, 30);
            this.dtp_DOB.TabIndex = 47;
            // 
            // txt_leaves
            // 
            this.txt_leaves.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_leaves.Location = new System.Drawing.Point(230, 517);
            this.txt_leaves.Margin = new System.Windows.Forms.Padding(4);
            this.txt_leaves.Name = "txt_leaves";
            this.txt_leaves.Size = new System.Drawing.Size(441, 30);
            this.txt_leaves.TabIndex = 43;
            // 
            // txt_overtimerate
            // 
            this.txt_overtimerate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_overtimerate.Location = new System.Drawing.Point(230, 474);
            this.txt_overtimerate.Margin = new System.Windows.Forms.Padding(4);
            this.txt_overtimerate.Name = "txt_overtimerate";
            this.txt_overtimerate.Size = new System.Drawing.Size(441, 30);
            this.txt_overtimerate.TabIndex = 42;
            // 
            // txt_allowances
            // 
            this.txt_allowances.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_allowances.Location = new System.Drawing.Point(230, 432);
            this.txt_allowances.Margin = new System.Windows.Forms.Padding(4);
            this.txt_allowances.Name = "txt_allowances";
            this.txt_allowances.Size = new System.Drawing.Size(441, 30);
            this.txt_allowances.TabIndex = 41;
            // 
            // txt_monthsalary
            // 
            this.txt_monthsalary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monthsalary.Location = new System.Drawing.Point(230, 350);
            this.txt_monthsalary.Margin = new System.Windows.Forms.Padding(4);
            this.txt_monthsalary.Name = "txt_monthsalary";
            this.txt_monthsalary.Size = new System.Drawing.Size(441, 30);
            this.txt_monthsalary.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(28, 523);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 27);
            this.label10.TabIndex = 39;
            this.label10.Text = "Leaves";
            // 
            // txt_contact
            // 
            this.txt_contact.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact.Location = new System.Drawing.Point(230, 267);
            this.txt_contact.Margin = new System.Windows.Forms.Padding(4);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(441, 30);
            this.txt_contact.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(28, 476);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 27);
            this.label9.TabIndex = 37;
            this.label9.Text = "Overtime Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 230);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 27);
            this.label6.TabIndex = 36;
            this.label6.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(28, 434);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 27);
            this.label8.TabIndex = 35;
            this.label8.Text = "Allowances";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 352);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 27);
            this.label7.TabIndex = 34;
            this.label7.Text = "Monthly Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 27);
            this.label5.TabIndex = 33;
            this.label5.Text = "Date Of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 27);
            this.label4.TabIndex = 32;
            this.label4.Text = "Contact Number";
            // 
            // txt_empaddress
            // 
            this.txt_empaddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empaddress.Location = new System.Drawing.Point(230, 142);
            this.txt_empaddress.Margin = new System.Windows.Forms.Padding(4);
            this.txt_empaddress.Name = "txt_empaddress";
            this.txt_empaddress.Size = new System.Drawing.Size(441, 30);
            this.txt_empaddress.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 27);
            this.label3.TabIndex = 31;
            this.label3.Text = "Employee Address";
            // 
            // txt_empname
            // 
            this.txt_empname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empname.Location = new System.Drawing.Point(230, 102);
            this.txt_empname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_empname.Name = "txt_empname";
            this.txt_empname.Size = new System.Drawing.Size(441, 30);
            this.txt_empname.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 27);
            this.label1.TabIndex = 38;
            this.label1.Text = "Employee Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(28, 68);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 27);
            this.label11.TabIndex = 38;
            this.label11.Text = "Employee Id";
            // 
            // txt_empid
            // 
            this.txt_empid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empid.Location = new System.Drawing.Point(230, 62);
            this.txt_empid.Margin = new System.Windows.Forms.Padding(4);
            this.txt_empid.Name = "txt_empid";
            this.txt_empid.Size = new System.Drawing.Size(441, 30);
            this.txt_empid.TabIndex = 45;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(686, 562);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(135, 38);
            this.btn_delete.TabIndex = 49;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_holiday
            // 
            this.txt_holiday.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_holiday.Location = new System.Drawing.Point(232, 560);
            this.txt_holiday.Margin = new System.Windows.Forms.Padding(4);
            this.txt_holiday.Name = "txt_holiday";
            this.txt_holiday.Size = new System.Drawing.Size(441, 30);
            this.txt_holiday.TabIndex = 52;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(29, 564);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 27);
            this.label13.TabIndex = 51;
            this.label13.Text = "Holidays";
            // 
            // dgv_employee
            // 
            this.dgv_employee.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.dgv_employee.AllowUserToAddRows = false;
            this.dgv_employee.AutoGenerateColumns = false;
            this.dgv_employee.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.dgv_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpId,
            this.EmpName,
            this.EmpAddress,
            this.EmpDOB,
            this.EmpGender,
            this.EmpContact,
            this.EmpEmail,
            this.MonthSalary,
            this.EmpVacancy,
            this.EmpAllowances,
            this.EmpOvertimeRate,
            this.EmpLeaves,
            this.EmpHoliday});
            this.dgv_employee.DataSource = this.employeeDataBindingSource;
            this.dgv_employee.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgv_employee.Location = new System.Drawing.Point(685, 62);
            this.dgv_employee.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_employee.Name = "dgv_employee";
            this.dgv_employee.RowHeadersWidth = 51;
            this.dgv_employee.Size = new System.Drawing.Size(848, 485);
            this.dgv_employee.TabIndex = 54;
            // 
            // employeeDataBindingSource
            // 
            this.employeeDataBindingSource.DataMember = "employeeData";
            this.employeeDataBindingSource.DataSource = this.grifindo_Toys_FactoryDataSet;
            // 
            // grifindo_Toys_FactoryDataSet
            // 
            this.grifindo_Toys_FactoryDataSet.DataSetName = "Grifindo_Toys_FactoryDataSet";
            this.grifindo_Toys_FactoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Gold;
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btn_search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_search.Location = new System.Drawing.Point(829, 562);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(135, 38);
            this.btn_search.TabIndex = 55;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_refresh.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btn_refresh.Location = new System.Drawing.Point(972, 562);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(135, 38);
            this.btn_refresh.TabIndex = 56;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Orange;
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btn_update.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_update.Location = new System.Drawing.Point(1114, 564);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(135, 38);
            this.btn_update.TabIndex = 55;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(28, 310);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(171, 27);
            this.label14.TabIndex = 34;
            this.label14.Text = "Employee Email";
            // 
            // txt_empemail
            // 
            this.txt_empemail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empemail.Location = new System.Drawing.Point(230, 308);
            this.txt_empemail.Margin = new System.Windows.Forms.Padding(4);
            this.txt_empemail.Name = "txt_empemail";
            this.txt_empemail.Size = new System.Drawing.Size(441, 30);
            this.txt_empemail.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(28, 398);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 27);
            this.label12.TabIndex = 57;
            this.label12.Text = "Job Type";
            // 
            // cb_empvacancy
            // 
            this.cb_empvacancy.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cb_empvacancy.FormattingEnabled = true;
            this.cb_empvacancy.Items.AddRange(new object[] {
            "",
            "Delivery",
            "Graphic design",
            "Finance Sector",
            "Manager",
            "Machanicle",
            "Security"});
            this.cb_empvacancy.Location = new System.Drawing.Point(230, 390);
            this.cb_empvacancy.Margin = new System.Windows.Forms.Padding(4);
            this.cb_empvacancy.Name = "cb_empvacancy";
            this.cb_empvacancy.Size = new System.Drawing.Size(441, 30);
            this.cb_empvacancy.TabIndex = 58;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btn_clear.Location = new System.Drawing.Point(1260, 564);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(135, 38);
            this.btn_clear.TabIndex = 59;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_Search2
            // 
            this.btn_Search2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Search2.BackgroundImage")));
            this.btn_Search2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Search2.Location = new System.Drawing.Point(633, 62);
            this.btn_Search2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search2.Name = "btn_Search2";
            this.btn_Search2.Size = new System.Drawing.Size(40, 33);
            this.btn_Search2.TabIndex = 60;
            this.btn_Search2.UseVisualStyleBackColor = true;
            this.btn_Search2.Click += new System.EventHandler(this.btn_Search2_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_print.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(1402, 564);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(135, 38);
            this.btn_print.TabIndex = 61;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // employeeDataTableAdapter
            // 
            this.employeeDataTableAdapter.ClearBeforeFill = true;
            // 
            // employeeComponentsBindingSource
            // 
            this.employeeComponentsBindingSource.DataSource = typeof(Grifindo_Toys_Factory.Employee_Components);
            // 
            // EmpId
            // 
            this.EmpId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmpId.DataPropertyName = "EmpId";
            this.EmpId.HeaderText = "Employee Id";
            this.EmpId.MinimumWidth = 6;
            this.EmpId.Name = "EmpId";
            this.EmpId.ReadOnly = true;
            this.EmpId.Width = 112;
            // 
            // EmpName
            // 
            this.EmpName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmpName.DataPropertyName = "EmpName";
            this.EmpName.HeaderText = "Employee Name";
            this.EmpName.MinimumWidth = 6;
            this.EmpName.Name = "EmpName";
            this.EmpName.Width = 127;
            // 
            // EmpAddress
            // 
            this.EmpAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmpAddress.DataPropertyName = "EmpAddress";
            this.EmpAddress.HeaderText = "Employee Address";
            this.EmpAddress.MinimumWidth = 6;
            this.EmpAddress.Name = "EmpAddress";
            this.EmpAddress.Width = 139;
            // 
            // EmpDOB
            // 
            this.EmpDOB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmpDOB.DataPropertyName = "EmpDOB";
            this.EmpDOB.HeaderText = "Employee DOB";
            this.EmpDOB.MinimumWidth = 6;
            this.EmpDOB.Name = "EmpDOB";
            this.EmpDOB.Width = 119;
            // 
            // EmpGender
            // 
            this.EmpGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmpGender.DataPropertyName = "EmpGender";
            this.EmpGender.HeaderText = "Employee Gender";
            this.EmpGender.MinimumWidth = 6;
            this.EmpGender.Name = "EmpGender";
            this.EmpGender.Width = 134;
            // 
            // EmpContact
            // 
            this.EmpContact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmpContact.DataPropertyName = "EmpContact";
            this.EmpContact.HeaderText = "Employee Contact";
            this.EmpContact.MinimumWidth = 6;
            this.EmpContact.Name = "EmpContact";
            this.EmpContact.Width = 134;
            // 
            // EmpEmail
            // 
            this.EmpEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmpEmail.DataPropertyName = "EmpEmail";
            this.EmpEmail.HeaderText = "Employee Email";
            this.EmpEmail.MinimumWidth = 6;
            this.EmpEmail.Name = "EmpEmail";
            this.EmpEmail.Width = 124;
            // 
            // MonthSalary
            // 
            this.MonthSalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MonthSalary.DataPropertyName = "MonthSalary";
            this.MonthSalary.HeaderText = "Month Salary";
            this.MonthSalary.MinimumWidth = 6;
            this.MonthSalary.Name = "MonthSalary";
            this.MonthSalary.Width = 105;
            // 
            // EmpVacancy
            // 
            this.EmpVacancy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmpVacancy.DataPropertyName = "EmpVacancy";
            this.EmpVacancy.HeaderText = "Employee Vacancy";
            this.EmpVacancy.MinimumWidth = 6;
            this.EmpVacancy.Name = "EmpVacancy";
            this.EmpVacancy.Width = 141;
            // 
            // EmpAllowances
            // 
            this.EmpAllowances.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmpAllowances.DataPropertyName = "EmpAllowances";
            this.EmpAllowances.HeaderText = "Employee Allowances";
            this.EmpAllowances.MinimumWidth = 6;
            this.EmpAllowances.Name = "EmpAllowances";
            this.EmpAllowances.Width = 155;
            // 
            // EmpOvertimeRate
            // 
            this.EmpOvertimeRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmpOvertimeRate.DataPropertyName = "EmpOvertimeRate";
            this.EmpOvertimeRate.HeaderText = "Employee Overtime Rate(%)";
            this.EmpOvertimeRate.MinimumWidth = 6;
            this.EmpOvertimeRate.Name = "EmpOvertimeRate";
            this.EmpOvertimeRate.Width = 145;
            // 
            // EmpLeaves
            // 
            this.EmpLeaves.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmpLeaves.DataPropertyName = "EmpLeaves";
            this.EmpLeaves.HeaderText = "Employee Leaves";
            this.EmpLeaves.MinimumWidth = 6;
            this.EmpLeaves.Name = "EmpLeaves";
            this.EmpLeaves.Width = 134;
            // 
            // EmpHoliday
            // 
            this.EmpHoliday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmpHoliday.DataPropertyName = "EmpHoliday";
            this.EmpHoliday.HeaderText = "Employee Holiday";
            this.EmpHoliday.MinimumWidth = 6;
            this.EmpHoliday.Name = "EmpHoliday";
            this.EmpHoliday.Width = 136;
            // 
            // Employee_Components
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1546, 609);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_Search2);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.cb_empvacancy);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dgv_employee);
            this.Controls.Add(this.txt_holiday);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.txt_leaves);
            this.Controls.Add(this.txt_overtimerate);
            this.Controls.Add(this.txt_allowances);
            this.Controls.Add(this.txt_empemail);
            this.Controls.Add(this.txt_monthsalary);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_empaddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_empid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_empname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Employee_Components";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_Components";
            this.Load += new System.EventHandler(this.Employee_Components_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindo_Toys_FactoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeComponentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.TextBox txt_leaves;
        private System.Windows.Forms.TextBox txt_overtimerate;
        private System.Windows.Forms.TextBox txt_allowances;
        private System.Windows.Forms.TextBox txt_monthsalary;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_empaddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_empname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_empid;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_holiday;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgv_employee;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_empemail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_empvacancy;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_Search2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.BindingSource employeeComponentsBindingSource;
        private Grifindo_Toys_FactoryDataSet grifindo_Toys_FactoryDataSet;
        private System.Windows.Forms.BindingSource employeeDataBindingSource;
        private Grifindo_Toys_FactoryDataSetTableAdapters.employeeDataTableAdapter employeeDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpVacancy;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpAllowances;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpOvertimeRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpLeaves;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpHoliday;
    }
}