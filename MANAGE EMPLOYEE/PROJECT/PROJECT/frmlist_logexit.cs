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
    public partial class frmlist_logexit:System.Windows.Forms.Form
    {
        public frmlist_logexit()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data source=(local);initial catalog=employeeDB; integrated security = true");
        SqlCommand cmd = new SqlCommand();

       
        void displaylogin()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select idemp,fname,lname,date,time from login_emp where date between '" + mask_date1.Text + "' AND '" + mask_date2.Text + "'";
            adp.Fill(ds, "login_emp");
            dvg_listlogin.DataSource = ds;
            dvg_listlogin.DataMember = "login_emp";
            
            
            dvg_listlogin.Columns[0].HeaderText = "کد پرسنلی";
            dvg_listlogin.Columns[1].HeaderText = "نام ";
            dvg_listlogin.Columns[2].HeaderText = "نام خانوادگی";
            dvg_listlogin.Columns[3].HeaderText = "تاریخ ورود";
            dvg_listlogin.Columns[4].HeaderText = "ساعت ورود";

        }

        void displayexit()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select idemp,fname,lname,date,time from exit_emp where date between '" + mask_date1.Text + "' AND '" + mask_date2.Text + "'";
            adp.Fill(ds, "exit_emp");
            dvg_listexit.DataSource = ds;
            dvg_listexit.DataMember = "exit_emp";

            dvg_listexit.Columns[0].HeaderText = "کد پرسنلی";
            dvg_listexit.Columns[1].HeaderText = "نام ";
            dvg_listexit.Columns[2].HeaderText = "نام خانوادگی";
            dvg_listexit.Columns[3].HeaderText = "تاریخ خروج";
            dvg_listexit.Columns[4].HeaderText = "ساعت خروج";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.PersianCalendar p = new System.Globalization.PersianCalendar();
            mask_date1.Text = p.GetYear(DateTime.Now).ToString() + p.GetMonth(DateTime.Now).ToString("0#") + p.GetDayOfMonth(DateTime.Now).ToString("0#");
            mask_date2.Text = p.GetYear(DateTime.Now).ToString() + p.GetMonth(DateTime.Now).ToString("0#") + p.GetDayOfMonth(DateTime.Now).ToString("0#");
            displaylogin();
            displayexit();

        }
        private void dvg_listlogexit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mask_date1_TextChanged(object sender, EventArgs e)
        {
            displaylogin();
            displayexit();
        }
        private void mask_date2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void mask_date2_TextChanged_1(object sender, EventArgs e)
        {
            displaylogin();
            displayexit();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            deletelogin();
            deleteexit();
        }
        void deletelogin()
        {
            try
            {
                int x = Convert.ToInt32(dvg_listlogin.SelectedCells[0].Value);
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "Delete from login_emp where idemp=@N";
                cmd.Parameters.AddWithValue("@N", x);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                displaylogin();

            }
            catch (Exception)
            {
                MessageBox.Show("مشکلی پیش آمده است");
            }
        }

        void deleteexit()
        {
            try
            {
                int x = Convert.ToInt32(dvg_listexit.SelectedCells[0].Value);
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "Delete from exit_emp where idemp=@N";
                cmd.Parameters.AddWithValue("@N", x);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                displayexit();

            }
            catch (Exception)
            {
                MessageBox.Show("مشکلی پیش آمده است");
            }
        }
    }
}
