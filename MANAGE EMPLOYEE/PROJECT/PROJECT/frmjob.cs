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
    public partial class frmjob : System.Windows.Forms.Form
    {
        public frmjob()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("data source=(local);initial catalog=employeeDB;integrated security=true");
        SqlCommand cmd = new SqlCommand();
        private void frmjob_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_namejob.Text==""|| txt_salary.Text == "")
                {
                    MessageBox.Show("اطلاعات خواسته شده را وارد کنید");
                }
                else
                {
                    cmd.Parameters.Clear();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into job(id_job,name_job,salary,description)Values(@a,@b,@c,@d)";
                    cmd.Parameters.AddWithValue("@a", txt_idjob.Text);
                    cmd.Parameters.AddWithValue("@b", txt_namejob.Text);
                    cmd.Parameters.AddWithValue("@c", txt_salary.Text);
                    cmd.Parameters.AddWithValue("@d", txt_description.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    //***********************************
                    txt_idjob.Text = "";
                    txt_namejob.Text = "";
                    txt_salary.Text = "";
                    txt_description.Text = "";
                    MessageBox.Show("ثبت اطلاعات انجام شد");
                }
               
            }
            catch (Exception)
            {
                MessageBox.Show("مشکلی پیش آمده است");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "Delete from job where id_job=" + txt_idjob.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("حذف انجام شد");

                txt_idjob.Text = "";
                txt_namejob.Text = "";
                txt_salary.Text = "";
                txt_description.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("مشکلی پیش آمده است");
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "update job set name_job='" + txt_namejob.Text + "',salary='" + txt_salary.Text + "',description='" + txt_description.Text  + "'where id_job='" + txt_idjob.Text + "'";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("ویرایش با موفقیت انجام شد");
                
                //***********************************
                txt_idjob.Text = "";
                txt_namejob.Text = "";
                txt_salary.Text = "";
                txt_description.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("مشکلی پیش آمده است");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from job where id_job=@N";
            cmd.Parameters.AddWithValue("@N", txt_idjob.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_idjob.Text = dr["id_job"].ToString();
                txt_namejob.Text = dr["name_job"].ToString();
                txt_salary.Text = dr["salary"].ToString();
                txt_description.Text = dr["description"].ToString();
            }
            else
            {
                MessageBox.Show("اطلاعاتی برای کد وارد شده پیدا نشد");
                txt_idjob.Text = "";
                txt_idjob.Focus();
            }
            con.Close();
        }
    }
}
