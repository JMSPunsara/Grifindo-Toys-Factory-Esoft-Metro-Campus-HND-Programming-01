namespace Grifindo_Toys_Factory
{
    partial class Salary_Components
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary_Components));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_recordid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_employeeid = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.StaffTypeId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_absent = new System.Windows.Forms.TextBox();
            this.txt_leaves = new System.Windows.Forms.TextBox();
            this.txt_overtimehours = new System.Windows.Forms.TextBox();
            this.txt_allowances = new System.Windows.Forms.TextBox();
            this.txt_govertaxrate = new System.Windows.Forms.TextBox();
            this.txt_monthsalary = new System.Windows.Forms.TextBox();
            this.txt_overtimerate = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_salarycycle = new System.Windows.Forms.TextBox();
            this.dgv_salary = new System.Windows.Forms.DataGridView();
            this.salaryDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grifindo_Toys_FactoryDataSet1 = new Grifindo_Toys_Factory.Grifindo_Toys_FactoryDataSet1();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_grosspay = new System.Windows.Forms.Label();
            this.lbl_nopay = new System.Windows.Forms.Label();
            this.lbl_basepay = new System.Windows.Forms.Label();
            this.btn_Search2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dtp_salarymonth = new System.Windows.Forms.DateTimePicker();
            this.btn_print = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.salaryDataTableAdapter = new Grifindo_Toys_Factory.Grifindo_Toys_FactoryDataSet1TableAdapters.salaryDataTableAdapter();
            this.RecordId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basePay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OTPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculatedTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindo_Toys_FactoryDataSet1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1503, 44);
            this.panel1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Grifindo_Toys_Factory.Properties.Resources.Go_Back;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1401, 0);
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
            this.label2.Size = new System.Drawing.Size(163, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Salary Components";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Grifindo_Toys_Factory.Properties.Resources.Cancel;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1452, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 44);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_recordid
            // 
            this.txt_recordid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_recordid.Location = new System.Drawing.Point(21, 89);
            this.txt_recordid.Margin = new System.Windows.Forms.Padding(4);
            this.txt_recordid.Name = "txt_recordid";
            this.txt_recordid.Size = new System.Drawing.Size(217, 30);
            this.txt_recordid.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 27);
            this.label1.TabIndex = 30;
            this.label1.Text = "Record Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(473, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 27);
            this.label4.TabIndex = 30;
            this.label4.Text = "Employee Id";
            // 
            // txt_employeeid
            // 
            this.txt_employeeid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_employeeid.Location = new System.Drawing.Point(479, 89);
            this.txt_employeeid.Margin = new System.Windows.Forms.Padding(4);
            this.txt_employeeid.Name = "txt_employeeid";
            this.txt_employeeid.Size = new System.Drawing.Size(256, 30);
            this.txt_employeeid.TabIndex = 31;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_refresh.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btn_refresh.Location = new System.Drawing.Point(587, 557);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(141, 38);
            this.btn_refresh.TabIndex = 45;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Gold;
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btn_search.Location = new System.Drawing.Point(294, 81);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(141, 38);
            this.btn_search.TabIndex = 45;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // StaffTypeId
            // 
            this.StaffTypeId.AutoSize = true;
            this.StaffTypeId.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.StaffTypeId.ForeColor = System.Drawing.Color.White;
            this.StaffTypeId.Location = new System.Drawing.Point(16, 376);
            this.StaffTypeId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StaffTypeId.Name = "StaffTypeId";
            this.StaffTypeId.Size = new System.Drawing.Size(195, 27);
            this.StaffTypeId.TabIndex = 258;
            this.StaffTypeId.Text = "Overtime Rate (%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(475, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 27);
            this.label6.TabIndex = 256;
            this.label6.Text = "Government Tax Rate(%)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(16, 136);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 27);
            this.label10.TabIndex = 257;
            this.label10.Text = "Absent Days";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 217);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 27);
            this.label8.TabIndex = 259;
            this.label8.Text = "Leaves Taken";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(475, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 27);
            this.label5.TabIndex = 260;
            this.label5.Text = "Allowances";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(473, 376);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 27);
            this.label7.TabIndex = 261;
            this.label7.Text = "Monthly Salary";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 301);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 27);
            this.label9.TabIndex = 262;
            this.label9.Text = "Overtime Hours";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(473, 301);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(253, 27);
            this.label11.TabIndex = 263;
            this.label11.Text = "Salary Cycle Date Range";
            // 
            // txt_absent
            // 
            this.txt_absent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_absent.Location = new System.Drawing.Point(21, 167);
            this.txt_absent.Margin = new System.Windows.Forms.Padding(4);
            this.txt_absent.Name = "txt_absent";
            this.txt_absent.Size = new System.Drawing.Size(256, 30);
            this.txt_absent.TabIndex = 31;
            // 
            // txt_leaves
            // 
            this.txt_leaves.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_leaves.Location = new System.Drawing.Point(21, 247);
            this.txt_leaves.Margin = new System.Windows.Forms.Padding(4);
            this.txt_leaves.Name = "txt_leaves";
            this.txt_leaves.Size = new System.Drawing.Size(256, 30);
            this.txt_leaves.TabIndex = 31;
            // 
            // txt_overtimehours
            // 
            this.txt_overtimehours.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_overtimehours.Location = new System.Drawing.Point(21, 330);
            this.txt_overtimehours.Margin = new System.Windows.Forms.Padding(4);
            this.txt_overtimehours.Name = "txt_overtimehours";
            this.txt_overtimehours.Size = new System.Drawing.Size(256, 30);
            this.txt_overtimehours.TabIndex = 31;
            // 
            // txt_allowances
            // 
            this.txt_allowances.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_allowances.Location = new System.Drawing.Point(480, 247);
            this.txt_allowances.Margin = new System.Windows.Forms.Padding(4);
            this.txt_allowances.Name = "txt_allowances";
            this.txt_allowances.Size = new System.Drawing.Size(255, 30);
            this.txt_allowances.TabIndex = 31;
            // 
            // txt_govertaxrate
            // 
            this.txt_govertaxrate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_govertaxrate.Location = new System.Drawing.Point(479, 167);
            this.txt_govertaxrate.Margin = new System.Windows.Forms.Padding(4);
            this.txt_govertaxrate.Name = "txt_govertaxrate";
            this.txt_govertaxrate.Size = new System.Drawing.Size(256, 30);
            this.txt_govertaxrate.TabIndex = 31;
            // 
            // txt_monthsalary
            // 
            this.txt_monthsalary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monthsalary.Location = new System.Drawing.Point(479, 405);
            this.txt_monthsalary.Margin = new System.Windows.Forms.Padding(4);
            this.txt_monthsalary.Name = "txt_monthsalary";
            this.txt_monthsalary.Size = new System.Drawing.Size(256, 30);
            this.txt_monthsalary.TabIndex = 31;
            // 
            // txt_overtimerate
            // 
            this.txt_overtimerate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_overtimerate.Location = new System.Drawing.Point(22, 406);
            this.txt_overtimerate.Margin = new System.Windows.Forms.Padding(4);
            this.txt_overtimerate.Name = "txt_overtimerate";
            this.txt_overtimerate.Size = new System.Drawing.Size(255, 30);
            this.txt_overtimerate.TabIndex = 31;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Lime;
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btn_add.Location = new System.Drawing.Point(19, 557);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(141, 38);
            this.btn_add.TabIndex = 265;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Crimson;
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(201, 557);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(141, 38);
            this.btn_delete.TabIndex = 265;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btn_clear.Location = new System.Drawing.Point(393, 557);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(141, 38);
            this.btn_clear.TabIndex = 265;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_salarycycle
            // 
            this.txt_salarycycle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salarycycle.Location = new System.Drawing.Point(478, 330);
            this.txt_salarycycle.Margin = new System.Windows.Forms.Padding(4);
            this.txt_salarycycle.Name = "txt_salarycycle";
            this.txt_salarycycle.Size = new System.Drawing.Size(257, 30);
            this.txt_salarycycle.TabIndex = 31;
            // 
            // dgv_salary
            // 
            this.dgv_salary.AllowUserToAddRows = false;
            this.dgv_salary.AutoGenerateColumns = false;
            this.dgv_salary.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.dgv_salary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_salary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecordId,
            this.EmpId,
            this.SalaryMonth,
            this.basePay,
            this.noPay,
            this.grossPay,
            this.OTPay,
            this.calculatedTax});
            this.dgv_salary.DataSource = this.salaryDataBindingSource;
            this.dgv_salary.Location = new System.Drawing.Point(753, 270);
            this.dgv_salary.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_salary.Name = "dgv_salary";
            this.dgv_salary.RowHeadersWidth = 51;
            this.dgv_salary.Size = new System.Drawing.Size(738, 336);
            this.dgv_salary.TabIndex = 266;
            // 
            // salaryDataBindingSource
            // 
            this.salaryDataBindingSource.DataMember = "salaryData";
            this.salaryDataBindingSource.DataSource = this.grifindo_Toys_FactoryDataSet1;
            // 
            // grifindo_Toys_FactoryDataSet1
            // 
            this.grifindo_Toys_FactoryDataSet1.DataSetName = "Grifindo_Toys_FactoryDataSet1";
            this.grifindo_Toys_FactoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(790, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 27);
            this.label3.TabIndex = 267;
            this.label3.Text = "Gross Pay";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(790, 148);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 27);
            this.label12.TabIndex = 267;
            this.label12.Text = "No Pay";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(790, 81);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 27);
            this.label13.TabIndex = 267;
            this.label13.Text = "Base Pay";
            // 
            // lbl_grosspay
            // 
            this.lbl_grosspay.AutoSize = true;
            this.lbl_grosspay.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_grosspay.ForeColor = System.Drawing.Color.White;
            this.lbl_grosspay.Location = new System.Drawing.Point(964, 212);
            this.lbl_grosspay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_grosspay.Name = "lbl_grosspay";
            this.lbl_grosspay.Size = new System.Drawing.Size(110, 27);
            this.lbl_grosspay.TabIndex = 267;
            this.lbl_grosspay.Text = "Gross Pay";
            // 
            // lbl_nopay
            // 
            this.lbl_nopay.AutoSize = true;
            this.lbl_nopay.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nopay.ForeColor = System.Drawing.Color.White;
            this.lbl_nopay.Location = new System.Drawing.Point(964, 148);
            this.lbl_nopay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nopay.Name = "lbl_nopay";
            this.lbl_nopay.Size = new System.Drawing.Size(84, 27);
            this.lbl_nopay.TabIndex = 267;
            this.lbl_nopay.Text = "No Pay";
            // 
            // lbl_basepay
            // 
            this.lbl_basepay.AutoSize = true;
            this.lbl_basepay.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_basepay.ForeColor = System.Drawing.Color.White;
            this.lbl_basepay.Location = new System.Drawing.Point(964, 81);
            this.lbl_basepay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_basepay.Name = "lbl_basepay";
            this.lbl_basepay.Size = new System.Drawing.Size(102, 27);
            this.lbl_basepay.TabIndex = 267;
            this.lbl_basepay.Text = "Base Pay";
            // 
            // btn_Search2
            // 
            this.btn_Search2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Search2.BackgroundImage")));
            this.btn_Search2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Search2.Location = new System.Drawing.Point(237, 87);
            this.btn_Search2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search2.Name = "btn_Search2";
            this.btn_Search2.Size = new System.Drawing.Size(40, 33);
            this.btn_Search2.TabIndex = 268;
            this.btn_Search2.UseVisualStyleBackColor = true;
            this.btn_Search2.Click += new System.EventHandler(this.btn_Search2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(37, 484);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(187, 35);
            this.label14.TabIndex = 261;
            this.label14.Text = "Salary Month";
            // 
            // dtp_salarymonth
            // 
            this.dtp_salarymonth.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dtp_salarymonth.Location = new System.Drawing.Point(269, 489);
            this.dtp_salarymonth.Name = "dtp_salarymonth";
            this.dtp_salarymonth.Size = new System.Drawing.Size(314, 30);
            this.dtp_salarymonth.TabIndex = 269;
            this.dtp_salarymonth.Value = new System.DateTime(2023, 12, 16, 14, 49, 38, 0);
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_print.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(1340, 212);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(135, 38);
            this.btn_print.TabIndex = 270;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
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
            // salaryDataTableAdapter
            // 
            this.salaryDataTableAdapter.ClearBeforeFill = true;
            // 
            // RecordId
            // 
            this.RecordId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RecordId.DataPropertyName = "RecordId";
            this.RecordId.HeaderText = "Record Id";
            this.RecordId.MinimumWidth = 6;
            this.RecordId.Name = "RecordId";
            this.RecordId.Width = 95;
            // 
            // EmpId
            // 
            this.EmpId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmpId.DataPropertyName = "EmpId";
            this.EmpId.HeaderText = "Employee Id";
            this.EmpId.MinimumWidth = 6;
            this.EmpId.Name = "EmpId";
            this.EmpId.Width = 112;
            // 
            // SalaryMonth
            // 
            this.SalaryMonth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SalaryMonth.DataPropertyName = "SalaryMonth";
            this.SalaryMonth.HeaderText = "Salary Month";
            this.SalaryMonth.MinimumWidth = 6;
            this.SalaryMonth.Name = "SalaryMonth";
            this.SalaryMonth.Width = 114;
            // 
            // basePay
            // 
            this.basePay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.basePay.DataPropertyName = "basePay";
            this.basePay.HeaderText = "Base-Pay";
            this.basePay.MinimumWidth = 6;
            this.basePay.Name = "basePay";
            this.basePay.Width = 96;
            // 
            // noPay
            // 
            this.noPay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.noPay.DataPropertyName = "noPay";
            this.noPay.HeaderText = "No-Pay";
            this.noPay.MinimumWidth = 6;
            this.noPay.Name = "noPay";
            this.noPay.Width = 82;
            // 
            // grossPay
            // 
            this.grossPay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.grossPay.DataPropertyName = "grossPay";
            this.grossPay.HeaderText = "Gross-Pay";
            this.grossPay.MinimumWidth = 6;
            this.grossPay.Name = "grossPay";
            // 
            // OTPay
            // 
            this.OTPay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OTPay.DataPropertyName = "OTPay";
            this.OTPay.HeaderText = "OT-Pay";
            this.OTPay.MinimumWidth = 6;
            this.OTPay.Name = "OTPay";
            this.OTPay.Width = 83;
            // 
            // calculatedTax
            // 
            this.calculatedTax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.calculatedTax.DataPropertyName = "calculatedTax";
            this.calculatedTax.HeaderText = "Calculated Tax";
            this.calculatedTax.MinimumWidth = 6;
            this.calculatedTax.Name = "calculatedTax";
            this.calculatedTax.Width = 116;
            // 
            // Salary_Components
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1503, 622);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.dtp_salarymonth);
            this.Controls.Add(this.btn_Search2);
            this.Controls.Add(this.lbl_basepay);
            this.Controls.Add(this.lbl_nopay);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbl_grosspay);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_salary);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StaffTypeId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.txt_employeeid);
            this.Controls.Add(this.txt_overtimerate);
            this.Controls.Add(this.txt_govertaxrate);
            this.Controls.Add(this.txt_monthsalary);
            this.Controls.Add(this.txt_allowances);
            this.Controls.Add(this.txt_salarycycle);
            this.Controls.Add(this.txt_overtimehours);
            this.Controls.Add(this.txt_leaves);
            this.Controls.Add(this.txt_absent);
            this.Controls.Add(this.txt_recordid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Salary_Components";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary_Components";
            this.Load += new System.EventHandler(this.Salary_Components_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindo_Toys_FactoryDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_recordid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_employeeid;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label StaffTypeId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_absent;
        private System.Windows.Forms.TextBox txt_leaves;
        private System.Windows.Forms.TextBox txt_overtimehours;
        private System.Windows.Forms.TextBox txt_allowances;
        private System.Windows.Forms.TextBox txt_govertaxrate;
        private System.Windows.Forms.TextBox txt_monthsalary;
        private System.Windows.Forms.TextBox txt_overtimerate;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_salarycycle;
        private System.Windows.Forms.DataGridView dgv_salary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_grosspay;
        private System.Windows.Forms.Label lbl_nopay;
        private System.Windows.Forms.Label lbl_basepay;
        private System.Windows.Forms.Button btn_Search2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtp_salarymonth;
        private System.Windows.Forms.Button btn_print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Grifindo_Toys_FactoryDataSet1 grifindo_Toys_FactoryDataSet1;
        private System.Windows.Forms.BindingSource salaryDataBindingSource;
        private Grifindo_Toys_FactoryDataSet1TableAdapters.salaryDataTableAdapter salaryDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn basePay;
        private System.Windows.Forms.DataGridViewTextBoxColumn noPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn OTPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn calculatedTax;
    }
}