namespace Grifindo_Toys_Factory
{
    partial class Employee_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_registeremployee = new System.Windows.Forms.Label();
            this.pb_registeremployee = new System.Windows.Forms.PictureBox();
            this.lbl_employeemanage = new System.Windows.Forms.Label();
            this.pb_employeemanage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_registeremployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_employeemanage)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(701, 44);
            this.panel1.TabIndex = 5;
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = global::Grifindo_Toys_Factory.Properties.Resources.Go_Back;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(599, 0);
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
            this.label2.Size = new System.Drawing.Size(138, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee Menu";
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = global::Grifindo_Toys_Factory.Properties.Resources.Cancel;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(650, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(51, 44);
            this.btn_close.TabIndex = 0;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_registeremployee
            // 
            this.lbl_registeremployee.AutoSize = true;
            this.lbl_registeremployee.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registeremployee.ForeColor = System.Drawing.Color.White;
            this.lbl_registeremployee.Location = new System.Drawing.Point(64, 185);
            this.lbl_registeremployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_registeremployee.Name = "lbl_registeremployee";
            this.lbl_registeremployee.Size = new System.Drawing.Size(203, 27);
            this.lbl_registeremployee.TabIndex = 9;
            this.lbl_registeremployee.Text = "Register Employees";
            this.lbl_registeremployee.Click += new System.EventHandler(this.lbl_registeremployee_Click);
            // 
            // pb_registeremployee
            // 
            this.pb_registeremployee.Image = global::Grifindo_Toys_Factory.Properties.Resources.Add_User_Male;
            this.pb_registeremployee.Location = new System.Drawing.Point(105, 52);
            this.pb_registeremployee.Margin = new System.Windows.Forms.Padding(4);
            this.pb_registeremployee.Name = "pb_registeremployee";
            this.pb_registeremployee.Size = new System.Drawing.Size(129, 129);
            this.pb_registeremployee.TabIndex = 10;
            this.pb_registeremployee.TabStop = false;
            this.pb_registeremployee.Click += new System.EventHandler(this.pb_registeremployee_Click);
            // 
            // lbl_employeemanage
            // 
            this.lbl_employeemanage.AutoSize = true;
            this.lbl_employeemanage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employeemanage.ForeColor = System.Drawing.Color.White;
            this.lbl_employeemanage.Location = new System.Drawing.Point(432, 185);
            this.lbl_employeemanage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_employeemanage.Name = "lbl_employeemanage";
            this.lbl_employeemanage.Size = new System.Drawing.Size(192, 27);
            this.lbl_employeemanage.TabIndex = 9;
            this.lbl_employeemanage.Text = "Employee Manage";
            this.lbl_employeemanage.Click += new System.EventHandler(this.lbl_employeemanage_Click);
            // 
            // pb_employeemanage
            // 
            this.pb_employeemanage.Image = ((System.Drawing.Image)(resources.GetObject("pb_employeemanage.Image")));
            this.pb_employeemanage.Location = new System.Drawing.Point(464, 52);
            this.pb_employeemanage.Margin = new System.Windows.Forms.Padding(4);
            this.pb_employeemanage.Name = "pb_employeemanage";
            this.pb_employeemanage.Size = new System.Drawing.Size(129, 129);
            this.pb_employeemanage.TabIndex = 10;
            this.pb_employeemanage.TabStop = false;
            this.pb_employeemanage.Click += new System.EventHandler(this.pb_employeemanage_Click);
            // 
            // Employee_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(701, 270);
            this.Controls.Add(this.pb_employeemanage);
            this.Controls.Add(this.lbl_employeemanage);
            this.Controls.Add(this.pb_registeremployee);
            this.Controls.Add(this.lbl_registeremployee);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Employee_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_registeremployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_employeemanage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.PictureBox pb_registeremployee;
        private System.Windows.Forms.Label lbl_registeremployee;
        private System.Windows.Forms.Label lbl_employeemanage;
        private System.Windows.Forms.PictureBox pb_employeemanage;
    }
}