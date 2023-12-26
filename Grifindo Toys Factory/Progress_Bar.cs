using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Toys_Factory
{
    public partial class Progress_Bar : Form
    {
        public Progress_Bar()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel_load1.Width += 10;

            if (panel_load1.Width >= 720) 
            {
                timer1.Stop();
                Login fm2 = new Login();
                fm2.Show();
                this.Hide();
            }
        }
    }
}
