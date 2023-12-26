namespace Grifindo_Toys_Factory
{
    partial class Grifindo_Payroll_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grifindo_Payroll_Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_settings = new System.Windows.Forms.Label();
            this.lbl_salaries = new System.Windows.Forms.Label();
            this.lbl_employee = new System.Windows.Forms.Label();
            this.pb_settings = new System.Windows.Forms.PictureBox();
            this.pb_salaries = new System.Windows.Forms.PictureBox();
            this.pb_employee = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_salaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_employee)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 38);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(321, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Grifindo Toys Factory Menu";
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = global::Grifindo_Toys_Factory.Properties.Resources.Cancel;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(866, 0);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(45, 38);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_settings
            // 
            this.lbl_settings.AutoSize = true;
            this.lbl_settings.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_settings.ForeColor = System.Drawing.Color.White;
            this.lbl_settings.Location = new System.Drawing.Point(606, 219);
            this.lbl_settings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_settings.Name = "lbl_settings";
            this.lbl_settings.Size = new System.Drawing.Size(196, 27);
            this.lbl_settings.TabIndex = 3;
            this.lbl_settings.Text = "Setting Component";
            this.lbl_settings.Click += new System.EventHandler(this.lbl_settings_Click);
            // 
            // lbl_salaries
            // 
            this.lbl_salaries.AutoSize = true;
            this.lbl_salaries.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salaries.ForeColor = System.Drawing.Color.White;
            this.lbl_salaries.Location = new System.Drawing.Point(366, 219);
            this.lbl_salaries.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_salaries.Name = "lbl_salaries";
            this.lbl_salaries.Size = new System.Drawing.Size(190, 27);
            this.lbl_salaries.TabIndex = 4;
            this.lbl_salaries.Text = "Salary Component";
            this.lbl_salaries.Click += new System.EventHandler(this.lbl_salaries_Click);
            // 
            // lbl_employee
            // 
            this.lbl_employee.AutoSize = true;
            this.lbl_employee.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employee.ForeColor = System.Drawing.Color.White;
            this.lbl_employee.Location = new System.Drawing.Point(96, 219);
            this.lbl_employee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_employee.Name = "lbl_employee";
            this.lbl_employee.Size = new System.Drawing.Size(227, 27);
            this.lbl_employee.TabIndex = 5;
            this.lbl_employee.Text = "Employee Component";
            // 
            // pb_settings
            // 
            this.pb_settings.Image = global::Grifindo_Toys_Factory.Properties.Resources.Settings;
            this.pb_settings.Location = new System.Drawing.Point(636, 86);
            this.pb_settings.Margin = new System.Windows.Forms.Padding(4);
            this.pb_settings.Name = "pb_settings";
            this.pb_settings.Size = new System.Drawing.Size(129, 129);
            this.pb_settings.TabIndex = 6;
            this.pb_settings.TabStop = false;
            this.pb_settings.Click += new System.EventHandler(this.pb_settings_Click);
            // 
            // pb_salaries
            // 
            this.pb_salaries.Image = global::Grifindo_Toys_Factory.Properties.Resources.Money_Transfer;
            this.pb_salaries.Location = new System.Drawing.Point(394, 86);
            this.pb_salaries.Margin = new System.Windows.Forms.Padding(4);
            this.pb_salaries.Name = "pb_salaries";
            this.pb_salaries.Size = new System.Drawing.Size(129, 129);
            this.pb_salaries.TabIndex = 7;
            this.pb_salaries.TabStop = false;
            this.pb_salaries.Click += new System.EventHandler(this.pb_salaries_Click);
            // 
            // pb_employee
            // 
            this.pb_employee.Image = global::Grifindo_Toys_Factory.Properties.Resources.Permanent_Job;
            this.pb_employee.Location = new System.Drawing.Point(144, 86);
            this.pb_employee.Margin = new System.Windows.Forms.Padding(4);
            this.pb_employee.Name = "pb_employee";
            this.pb_employee.Size = new System.Drawing.Size(129, 129);
            this.pb_employee.TabIndex = 8;
            this.pb_employee.TabStop = false;
            this.pb_employee.Click += new System.EventHandler(this.pb_employee_Click);
            // 
            // Grifindo_Payroll_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(911, 331);
            this.Controls.Add(this.pb_settings);
            this.Controls.Add(this.pb_salaries);
            this.Controls.Add(this.pb_employee);
            this.Controls.Add(this.lbl_settings);
            this.Controls.Add(this.lbl_salaries);
            this.Controls.Add(this.lbl_employee);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Grifindo_Payroll_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grifindo_Payroll_Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_salaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_employee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox pb_settings;
        private System.Windows.Forms.PictureBox pb_salaries;
        private System.Windows.Forms.PictureBox pb_employee;
        private System.Windows.Forms.Label lbl_settings;
        private System.Windows.Forms.Label lbl_salaries;
        private System.Windows.Forms.Label lbl_employee;
    }
}