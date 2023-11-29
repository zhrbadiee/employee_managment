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
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            new frmuser().ShowDialog();
        }

        private void expandablePanel1_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            new frmjob().ShowDialog();
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            new frmemployee().ShowDialog();
        }

        private void btn_listemp_Click(object sender, EventArgs e)
        {
            new frmlistemp().ShowDialog();
        }

        private void btn_loginexit_Click(object sender, EventArgs e)
        {
            new frmlog_exit().ShowDialog();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            new frmlist_logexit().ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        //private void btn_exit_Click_1(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}
    }
}
