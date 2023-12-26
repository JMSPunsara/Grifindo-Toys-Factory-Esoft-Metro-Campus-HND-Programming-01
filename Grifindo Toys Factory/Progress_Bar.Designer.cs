namespace Grifindo_Toys_Factory
{
    partial class Progress_Bar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_load2 = new System.Windows.Forms.Panel();
            this.panel_load1 = new System.Windows.Forms.Panel();
            this.lbl_employee = new System.Windows.Forms.Label();
            this.pb_employee = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_load2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_employee)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(2, 387);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 26);
            this.panel1.TabIndex = 0;
            // 
            // panel_load2
            // 
            this.panel_load2.Controls.Add(this.panel_load1);
            this.panel_load2.Location = new System.Drawing.Point(1, 386);
            this.panel_load2.Name = "panel_load2";
            this.panel_load2.Size = new System.Drawing.Size(966, 26);
            this.panel_load2.TabIndex = 0;
            // 
            // panel_load1
            // 
            this.panel_load1.BackColor = System.Drawing.Color.Crimson;
            this.panel_load1.Location = new System.Drawing.Point(0, -1);
            this.panel_load1.Name = "panel_load1";
            this.panel_load1.Size = new System.Drawing.Size(156, 26);
            this.panel_load1.TabIndex = 1;
            // 
            // lbl_employee
            // 
            this.lbl_employee.AutoSize = true;
            this.lbl_employee.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employee.ForeColor = System.Drawing.Color.White;
            this.lbl_employee.Location = new System.Drawing.Point(529, 154);
            this.lbl_employee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_employee.Name = "lbl_employee";
            this.lbl_employee.Size = new System.Drawing.Size(231, 51);
            this.lbl_employee.TabIndex = 9;
            this.lbl_employee.Text = "Loading.....";
            // 
            // pb_employee
            // 
            this.pb_employee.Image = global::Grifindo_Toys_Factory.Properties.Resources.font_design_word_toy_shop_with_many_toys_1308_42318_removebg_preview;
            this.pb_employee.Location = new System.Drawing.Point(34, 29);
            this.pb_employee.Margin = new System.Windows.Forms.Padding(4);
            this.pb_employee.Name = "pb_employee";
            this.pb_employee.Size = new System.Drawing.Size(356, 291);
            this.pb_employee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_employee.TabIndex = 10;
            this.pb_employee.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 355);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Created by JMSPunsara";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Progress_Bar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(968, 414);
            this.Controls.Add(this.pb_employee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_employee);
            this.Controls.Add(this.panel_load2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Progress_Bar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Progress_Bar";
            this.panel_load2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_employee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_load2;
        private System.Windows.Forms.Panel panel_load1;
        private System.Windows.Forms.PictureBox pb_employee;
        private System.Windows.Forms.Label lbl_employee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}