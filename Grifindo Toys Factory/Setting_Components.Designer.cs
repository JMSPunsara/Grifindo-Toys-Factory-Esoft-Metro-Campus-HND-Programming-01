namespace Grifindo_Toys_Factory
{
    partial class Setting_Components
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting_Components));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_salarycyclestartdate = new System.Windows.Forms.DateTimePicker();
            this.txt_salarycycledatarange = new System.Windows.Forms.TextBox();
            this.txt_empid = new System.Windows.Forms.TextBox();
            this.txt_setid = new System.Windows.Forms.TextBox();
            this.txt_absentdays = new System.Windows.Forms.TextBox();
            this.txt_leavestaken = new System.Windows.Forms.TextBox();
            this.txt_overtimehours = new System.Windows.Forms.TextBox();
            this.txt_govermenttaxrate = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgv_setting = new System.Windows.Forms.DataGridView();
            this.settingDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grifindo_Toys_FactoryDataSet2 = new Grifindo_Toys_Factory.Grifindo_Toys_FactoryDataSet2();
            this.btn_Search2 = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.dtp_salarycycleenddate = new System.Windows.Forms.DateTimePicker();
            this.settingDataTableAdapter = new Grifindo_Toys_Factory.Grifindo_Toys_FactoryDataSet2TableAdapters.settingDataTableAdapter();
            this.SetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryCycleDataRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryCycleStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryCycleEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbsentDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeavesTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OvertimeHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GovermentTaxRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_setting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindo_Toys_FactoryDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 44);
            this.panel1.TabIndex = 7;
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = global::Grifindo_Toys_Factory.Properties.Resources.Go_Back;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(1183, 0);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(51, 44);
            this.btn_back.TabIndex = 5;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Setting Componnents";
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = global::Grifindo_Toys_Factory.Properties.Resources.Cancel;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(1234, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(51, 44);
            this.btn_close.TabIndex = 0;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(49, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 27);
            this.label1.TabIndex = 215;
            this.label1.Text = "Setting ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(404, 63);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 27);
            this.label10.TabIndex = 214;
            this.label10.Text = "Absent Days";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(48, 389);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 27);
            this.label5.TabIndex = 225;
            this.label5.Text = "Salary Cycle End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(49, 300);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 27);
            this.label4.TabIndex = 224;
            this.label4.Text = "Salary Cycle Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(49, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 27);
            this.label3.TabIndex = 221;
            this.label3.Text = "Employee ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(404, 300);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 27);
            this.label6.TabIndex = 220;
            this.label6.Text = "Government Tax Rate(%)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(404, 220);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 27);
            this.label9.TabIndex = 219;
            this.label9.Text = "Overtime Hours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(404, 138);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 27);
            this.label7.TabIndex = 223;
            this.label7.Text = "No. of Leaves Taken";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(49, 220);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 27);
            this.label8.TabIndex = 222;
            this.label8.Text = "Salary Cycle Date Range";
            // 
            // dtp_salarycyclestartdate
            // 
            this.dtp_salarycyclestartdate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dtp_salarycyclestartdate.Location = new System.Drawing.Point(55, 336);
            this.dtp_salarycyclestartdate.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_salarycyclestartdate.Name = "dtp_salarycyclestartdate";
            this.dtp_salarycyclestartdate.Size = new System.Drawing.Size(263, 30);
            this.dtp_salarycyclestartdate.TabIndex = 226;
            this.dtp_salarycyclestartdate.Value = new System.DateTime(2023, 12, 16, 0, 0, 0, 0);
            // 
            // txt_salarycycledatarange
            // 
            this.txt_salarycycledatarange.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salarycycledatarange.Location = new System.Drawing.Point(55, 256);
            this.txt_salarycycledatarange.Margin = new System.Windows.Forms.Padding(4);
            this.txt_salarycycledatarange.Name = "txt_salarycycledatarange";
            this.txt_salarycycledatarange.Size = new System.Drawing.Size(261, 30);
            this.txt_salarycycledatarange.TabIndex = 227;
            // 
            // txt_empid
            // 
            this.txt_empid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empid.Location = new System.Drawing.Point(53, 177);
            this.txt_empid.Margin = new System.Windows.Forms.Padding(4);
            this.txt_empid.Name = "txt_empid";
            this.txt_empid.Size = new System.Drawing.Size(261, 30);
            this.txt_empid.TabIndex = 227;
            // 
            // txt_setid
            // 
            this.txt_setid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_setid.Location = new System.Drawing.Point(56, 92);
            this.txt_setid.Margin = new System.Windows.Forms.Padding(4);
            this.txt_setid.Name = "txt_setid";
            this.txt_setid.Size = new System.Drawing.Size(261, 30);
            this.txt_setid.TabIndex = 227;
            // 
            // txt_absentdays
            // 
            this.txt_absentdays.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_absentdays.Location = new System.Drawing.Point(409, 92);
            this.txt_absentdays.Margin = new System.Windows.Forms.Padding(4);
            this.txt_absentdays.Name = "txt_absentdays";
            this.txt_absentdays.Size = new System.Drawing.Size(285, 30);
            this.txt_absentdays.TabIndex = 227;
            // 
            // txt_leavestaken
            // 
            this.txt_leavestaken.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_leavestaken.Location = new System.Drawing.Point(409, 177);
            this.txt_leavestaken.Margin = new System.Windows.Forms.Padding(4);
            this.txt_leavestaken.Name = "txt_leavestaken";
            this.txt_leavestaken.Size = new System.Drawing.Size(285, 30);
            this.txt_leavestaken.TabIndex = 227;
            // 
            // txt_overtimehours
            // 
            this.txt_overtimehours.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_overtimehours.Location = new System.Drawing.Point(409, 256);
            this.txt_overtimehours.Margin = new System.Windows.Forms.Padding(4);
            this.txt_overtimehours.Name = "txt_overtimehours";
            this.txt_overtimehours.Size = new System.Drawing.Size(285, 30);
            this.txt_overtimehours.TabIndex = 227;
            // 
            // txt_govermenttaxrate
            // 
            this.txt_govermenttaxrate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_govermenttaxrate.Location = new System.Drawing.Point(409, 336);
            this.txt_govermenttaxrate.Margin = new System.Windows.Forms.Padding(4);
            this.txt_govermenttaxrate.Name = "txt_govermenttaxrate";
            this.txt_govermenttaxrate.Size = new System.Drawing.Size(285, 30);
            this.txt_govermenttaxrate.TabIndex = 227;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btn_clear.Location = new System.Drawing.Point(571, 465);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(136, 38);
            this.btn_clear.TabIndex = 266;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(409, 465);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(137, 38);
            this.btn_delete.TabIndex = 267;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Orange;
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btn_update.Location = new System.Drawing.Point(571, 420);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(136, 38);
            this.btn_update.TabIndex = 268;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Lime;
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btn_add.Location = new System.Drawing.Point(407, 376);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(141, 38);
            this.btn_add.TabIndex = 269;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dgv_setting
            // 
            this.dgv_setting.AllowUserToAddRows = false;
            this.dgv_setting.AutoGenerateColumns = false;
            this.dgv_setting.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.dgv_setting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_setting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SetId,
            this.EmpId,
            this.SalaryCycleDataRange,
            this.SalaryCycleStartDate,
            this.SalaryCycleEndDate,
            this.AbsentDays,
            this.LeavesTaken,
            this.OvertimeHours,
            this.GovermentTaxRate});
            this.dgv_setting.DataSource = this.settingDataBindingSource;
            this.dgv_setting.Location = new System.Drawing.Point(719, 52);
            this.dgv_setting.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_setting.Name = "dgv_setting";
            this.dgv_setting.RowHeadersWidth = 51;
            this.dgv_setting.Size = new System.Drawing.Size(551, 448);
            this.dgv_setting.TabIndex = 270;
            // 
            // settingDataBindingSource
            // 
            this.settingDataBindingSource.DataMember = "settingData";
            this.settingDataBindingSource.DataSource = this.grifindo_Toys_FactoryDataSet2;
            // 
            // grifindo_Toys_FactoryDataSet2
            // 
            this.grifindo_Toys_FactoryDataSet2.DataSetName = "Grifindo_Toys_FactoryDataSet2";
            this.grifindo_Toys_FactoryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Search2
            // 
            this.btn_Search2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Search2.BackgroundImage")));
            this.btn_Search2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Search2.Location = new System.Drawing.Point(279, 90);
            this.btn_Search2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search2.Name = "btn_Search2";
            this.btn_Search2.Size = new System.Drawing.Size(40, 33);
            this.btn_Search2.TabIndex = 271;
            this.btn_Search2.UseVisualStyleBackColor = true;
            this.btn_Search2.Click += new System.EventHandler(this.btn_Search2_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Gold;
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btn_search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_search.Location = new System.Drawing.Point(409, 420);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(136, 38);
            this.btn_search.TabIndex = 272;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_refresh.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_refresh.Location = new System.Drawing.Point(572, 376);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(135, 38);
            this.btn_refresh.TabIndex = 273;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // dtp_salarycycleenddate
            // 
            this.dtp_salarycycleenddate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dtp_salarycycleenddate.Location = new System.Drawing.Point(56, 430);
            this.dtp_salarycycleenddate.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_salarycycleenddate.Name = "dtp_salarycycleenddate";
            this.dtp_salarycycleenddate.Size = new System.Drawing.Size(263, 30);
            this.dtp_salarycycleenddate.TabIndex = 226;
            this.dtp_salarycycleenddate.Value = new System.DateTime(2023, 12, 16, 0, 0, 0, 0);
            this.dtp_salarycycleenddate.ValueChanged += new System.EventHandler(this.dtp_salarycycleenddate_ValueChanged);
            // 
            // settingDataTableAdapter
            // 
            this.settingDataTableAdapter.ClearBeforeFill = true;
            // 
            // SetId
            // 
            this.SetId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SetId.DataPropertyName = "SetId";
            this.SetId.HeaderText = "Setting Id";
            this.SetId.MinimumWidth = 6;
            this.SetId.Name = "SetId";
            this.SetId.Width = 91;
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
            // SalaryCycleDataRange
            // 
            this.SalaryCycleDataRange.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SalaryCycleDataRange.DataPropertyName = "SalaryCycleDataRange";
            this.SalaryCycleDataRange.HeaderText = "Salary Cycle Data Range";
            this.SalaryCycleDataRange.MinimumWidth = 6;
            this.SalaryCycleDataRange.Name = "SalaryCycleDataRange";
            this.SalaryCycleDataRange.Width = 135;
            // 
            // SalaryCycleStartDate
            // 
            this.SalaryCycleStartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SalaryCycleStartDate.DataPropertyName = "SalaryCycleStartDate";
            this.SalaryCycleStartDate.HeaderText = "Salary Cycle Start Date";
            this.SalaryCycleStartDate.MinimumWidth = 6;
            this.SalaryCycleStartDate.Name = "SalaryCycleStartDate";
            this.SalaryCycleStartDate.Width = 133;
            // 
            // SalaryCycleEndDate
            // 
            this.SalaryCycleEndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SalaryCycleEndDate.DataPropertyName = "SalaryCycleEndDate";
            this.SalaryCycleEndDate.HeaderText = "Salary Cycle End Date";
            this.SalaryCycleEndDate.MinimumWidth = 6;
            this.SalaryCycleEndDate.Name = "SalaryCycleEndDate";
            this.SalaryCycleEndDate.Width = 130;
            // 
            // AbsentDays
            // 
            this.AbsentDays.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AbsentDays.DataPropertyName = "AbsentDays";
            this.AbsentDays.HeaderText = "Absent Days";
            this.AbsentDays.MinimumWidth = 6;
            this.AbsentDays.Name = "AbsentDays";
            this.AbsentDays.Width = 104;
            // 
            // LeavesTaken
            // 
            this.LeavesTaken.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LeavesTaken.DataPropertyName = "LeavesTaken";
            this.LeavesTaken.HeaderText = "Leaves Taken";
            this.LeavesTaken.MinimumWidth = 6;
            this.LeavesTaken.Name = "LeavesTaken";
            this.LeavesTaken.Width = 113;
            // 
            // OvertimeHours
            // 
            this.OvertimeHours.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OvertimeHours.DataPropertyName = "OvertimeHours";
            this.OvertimeHours.HeaderText = "Overtime Hours";
            this.OvertimeHours.MinimumWidth = 6;
            this.OvertimeHours.Name = "OvertimeHours";
            this.OvertimeHours.Width = 119;
            // 
            // GovermentTaxRate
            // 
            this.GovermentTaxRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GovermentTaxRate.DataPropertyName = "GovermentTaxRate";
            this.GovermentTaxRate.HeaderText = "Goverment TaxRate(%)";
            this.GovermentTaxRate.MinimumWidth = 6;
            this.GovermentTaxRate.Name = "GovermentTaxRate";
            this.GovermentTaxRate.Width = 162;
            // 
            // Setting_Components
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1285, 514);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_Search2);
            this.Controls.Add(this.dgv_setting);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_govermenttaxrate);
            this.Controls.Add(this.txt_overtimehours);
            this.Controls.Add(this.txt_leavestaken);
            this.Controls.Add(this.txt_absentdays);
            this.Controls.Add(this.txt_setid);
            this.Controls.Add(this.txt_empid);
            this.Controls.Add(this.txt_salarycycledatarange);
            this.Controls.Add(this.dtp_salarycycleenddate);
            this.Controls.Add(this.dtp_salarycyclestartdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Setting_Components";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting_Components";
            this.Load += new System.EventHandler(this.Setting_Components_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_setting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindo_Toys_FactoryDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_salarycyclestartdate;
        private System.Windows.Forms.TextBox txt_salarycycledatarange;
        private System.Windows.Forms.TextBox txt_empid;
        private System.Windows.Forms.TextBox txt_setid;
        private System.Windows.Forms.TextBox txt_absentdays;
        private System.Windows.Forms.TextBox txt_leavestaken;
        private System.Windows.Forms.TextBox txt_overtimehours;
        private System.Windows.Forms.TextBox txt_govermenttaxrate;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgv_setting;
        private System.Windows.Forms.Button btn_Search2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DateTimePicker dtp_salarycycleenddate;
        private Grifindo_Toys_FactoryDataSet2 grifindo_Toys_FactoryDataSet2;
        private System.Windows.Forms.BindingSource settingDataBindingSource;
        private Grifindo_Toys_FactoryDataSet2TableAdapters.settingDataTableAdapter settingDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn SetId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryCycleDataRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryCycleStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryCycleEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbsentDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeavesTaken;
        private System.Windows.Forms.DataGridViewTextBoxColumn OvertimeHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn GovermentTaxRate;
    }
}