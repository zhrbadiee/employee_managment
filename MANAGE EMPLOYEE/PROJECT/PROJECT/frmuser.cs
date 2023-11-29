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
    public partial class frmuser : System.Windows.Forms.Form
    {
        public frmuser()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("data source=(local);initial catalog=employeeDB;integrated security=true");
        SqlCommand cmd = new SqlCommand();
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void display()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "select id ,username from karbar";
            adp.Fill(ds, "karbar");
            dgv_user.DataSource = ds;
            dgv_user.DataMember = "karbar";

            dgv_user.Columns[0].HeaderText = "کد";
            dgv_user.Columns[1].HeaderText = "نام کاربری";
            //dgv_user.Columns[2].HeaderText = "رمزعبور";

            dgv_user.Columns[0].Width = 50;
            dgv_user.Columns[1].Width = 120;
            //dgv_user.Columns[2].Width = 111;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_uname.Text==""||txt_pass.Text=="")
                {
                    MessageBox.Show("نام کاربری یا رمزعبور وارد کنید");
                }
                else
                {
                    cmd.Parameters.Clear();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into Karbar(username,password)values(@Uname,@Password)";
                    cmd.Parameters.AddWithValue("@Uname", txt_uname.Text);
                    cmd.Parameters.AddWithValue("@Password", txt_pass.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    display();

                    txt_uname.Text = "";
                    txt_pass.Text = "";

                    MessageBox.Show("کاربر با موفقیت ذخیره شد");
                }
               
            }
            catch(Exception)
            {
                MessageBox.Show("مشکلی وجود دارد");
            }
        }

        private void frmuser_Load(object sender, EventArgs e)
        {
            display();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(dgv_user.SelectedCells[0].Value);

                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "Delete From Karbar where id=@N";
                cmd.Parameters.AddWithValue("@N", x);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                display();
                MessageBox.Show("کاربر با موفقیت حذف شد");
            }
            catch (Exception)
            {
                MessageBox.Show("مشکلی وجود دارد");
            }

        }

        private void btn_search_idemp_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataReader dr;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select username,password from Karbar where username=@N";
            cmd.Parameters.AddWithValue("@N", txt_uname.Text);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_pass.Text = dr["password"].ToString();
            }
            else
            {
                txt_uname.Text = "";
                MessageBox.Show("مشخصاتی با این نام کاربری پیدا نشد");
            }
            con.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update karbar set password='" + txt_pass.Text + "'where username='" + txt_uname.Text + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("ویرایش با موفقیت انجام شد");

            //***********************************
            txt_pass.Text = "";
            txt_uname.Text = "";
        }
    }
}
