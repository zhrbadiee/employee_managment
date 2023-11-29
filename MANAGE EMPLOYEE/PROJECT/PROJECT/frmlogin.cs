using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PROJECT
{
    public partial class frmlogin : System.Windows.Forms.Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data source=(local);initial catalog=employeeDB; integrated security = true");
        SqlCommand cmd = new SqlCommand();

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                cmd = new SqlCommand("select count(*) from Karbar where username=@UName AND password=@Password", con);
                cmd.Parameters.AddWithValue("@Uname", txt_uname.Text);
                cmd.Parameters.AddWithValue("@Password", txt_pass.Text);
                con.Open();
                i = (int)cmd.ExecuteScalar();
                con.Close();

                if (i > 0)
                {
                    new Form().ShowDialog();
                    this.Close();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("نام کاربری یا رمز عبور اشتباه است");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("مشکلی وجود دارد");
            }
        }
    }
}
