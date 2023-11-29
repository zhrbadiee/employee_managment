using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class frmloading : System.Windows.Forms.Form
    {
        public frmloading()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                pr_bar.Value += 5;
                if(pr_bar.Value==100)
                {
                    timer.Stop();
                    new frmlogin().ShowDialog();
                    this.Close();
                    this.Hide();

                }
            }
           
            catch (Exception)
            {

            }
        }
    }
}
