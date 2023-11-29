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
    public partial class frmlistemp : System.Windows.Forms.Form
    {
        public frmlistemp()
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
            adp.SelectCommand.CommandText = "Select id_emp,codemeli,fname,lname,mobile,namejob from employee";
            adp.Fill(ds, "employee");
            dvg_listemployee.DataSource = ds;
            dvg_listemployee.DataMember = "employee";

            dvg_listemployee.Columns[0].HeaderText = "کدپرسنلی";
            dvg_listemployee.Columns[1].HeaderText = "کدملی";
            dvg_listemployee.Columns[2].HeaderText = "نام";
            dvg_listemployee.Columns[3].HeaderText = "نام خانوادگی";
            dvg_listemployee.Columns[4].HeaderText = "تلفن همراه";
            dvg_listemployee.Columns[5].HeaderText = "عنوان شغلی";



            dvg_listemployee.Columns[0].Width = 70;

        }

        private void frmlistemp_Load(object sender, EventArgs e)
        {
            display();
        }
        private void txt_idemp_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select * from employee where id_emp like '%' +@S+ '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txt_idemp.Text);
            adp.Fill(ds, "employee");
            dvg_listemployee.DataSource = ds;
            dvg_listemployee.DataMember = "employee";
        }

        private void txt_lname_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select * from employee where lname like '%' +@S+ '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txt_lname.Text);
            adp.Fill(ds, "employee");
            dvg_listemployee.DataSource = ds;
            dvg_listemployee.DataMember = "employee";
        }

        private void txt_namejob_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select * from employee where namejob like '%' +@S+ '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txt_namejob.Text);
            adp.Fill(ds, "employee");
            dvg_listemployee.DataSource = ds;
            dvg_listemployee.DataMember = "employee";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(dvg_listemployee.SelectedCells[0].Value);
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "Delete from employee where id_emp=@N";
                cmd.Parameters.AddWithValue("@N", x);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                display();
                MessageBox.Show("کارمند حذف شد");
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
    }
}
