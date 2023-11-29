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
    public partial class frmlog_exit : System.Windows.Forms.Form
    {
        public frmlog_exit()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data source=(local);initial catalog=employeeDB; integrated security = true");
        SqlCommand cmd = new SqlCommand();

        void display()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select id_emp,fname,lname from employee";
            adp.Fill(ds, "employee");
            dvg_logexit.DataSource = ds;
            dvg_logexit.DataMember = "employee";
            //**********************
            dvg_logexit.Columns[0].HeaderText = "کد پرسنلی";
            dvg_logexit.Columns[1].HeaderText = "نام ";
            dvg_logexit.Columns[2].HeaderText = "نام خانوادگی";
            dvg_logexit.Columns[1].Width = 161;
            dvg_logexit.Columns[2].Width = 162;

           
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            txt_time.Text = DateTime.Now.Hour.ToString("0#");
            txt_time.Text += ":";
            txt_time.Text += DateTime.Now.Minute.ToString("0#");
            txt_time.Text += ":";
            txt_time.Text += DateTime.Now.Second.ToString("0#");
        }

        private void frmlog_exit_Load(object sender, EventArgs e)
        {
            display();
            System.Globalization.PersianCalendar p = new System.Globalization.PersianCalendar();
            mask_date.Text = p.GetYear(DateTime.Now).ToString() + p.GetMonth(DateTime.Now).ToString("0#") + p.GetDayOfMonth(DateTime.Now).ToString("0#");
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "insert into login_emp(idemp,fname,lname,date,time)values(@a,@b,@c,@d,@e)";
                cmd.Parameters.AddWithValue("@a", Convert.ToInt32(dvg_logexit.SelectedCells[0].Value));
                cmd.Parameters.AddWithValue("@b", dvg_logexit.SelectedCells[1].Value);
                cmd.Parameters.AddWithValue("@c", dvg_logexit.SelectedCells[2].Value);
                cmd.Parameters.AddWithValue("@d", mask_date.Text);
                cmd.Parameters.AddWithValue("@e", txt_time.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("اطلاعات ورود ثبت شد");
            }
            catch (Exception)
            {
                MessageBox.Show("مشکلی پیش آمده است");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "insert into exit_emp(idemp,fname,lname,date,time)values(@a,@b,@c,@d,@e)";
                cmd.Parameters.AddWithValue("@a", Convert.ToInt32(dvg_logexit.SelectedCells[0].Value));
                cmd.Parameters.AddWithValue("@b", dvg_logexit.SelectedCells[1].Value);
                cmd.Parameters.AddWithValue("@c", dvg_logexit.SelectedCells[2].Value);
                cmd.Parameters.AddWithValue("@d", mask_date.Text);
                cmd.Parameters.AddWithValue("@e", txt_time.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("اطلاعات خروج ثبت شد");
            }
            catch (Exception)
            {
                MessageBox.Show("مشکلی پیش آمده است");
            }
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            new frmlist_logexit().ShowDialog();
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mask_date_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
