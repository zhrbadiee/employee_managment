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
using System.IO;

namespace PROJECT
{
    public partial class frmemployee : System.Windows.Forms.Form
    {
        public frmemployee()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data source=(local);initial catalog=employeeDB; integrated security = true");
        SqlCommand cmd = new SqlCommand();

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

        private void labelX8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try 
            {
                if (pictureBox.Image == null)
                {
                    MessageBox.Show("تصویری انتخاب نکرده اید");
                    return;
                }
                if(txt_idemp.Text == "" || txt_codeid.Text == ""||txt_fname.Text == ""|| txt_lname.Text == ""|| txt_faname.Text == ""||
                mask_birthday.Text == ""|| txt_numsh.Text == ""|| txt_phnum.Text == ""|| txt_mobile.Text == ""||txt_major.Text == ""||
                comb_study.Text=="" || txt_namejob.Text == ""||txt_salary.Text == ""||comb_estekhdam.Text=="")
                {
                    MessageBox.Show("اطلاعات خواسته شده (*دار) وارد کنید.");
                }
                else
                {
                    con.Open();
                    byte[] ar = File.ReadAllBytes(pictureBox.ImageLocation);
                    SqlCommand cmd = new SqlCommand("insert into employee(id_emp,codemeli,fname,lname,fathername,birth,Shenasnameh,tahol,phon,mobile,study,majer,namejob,salary,date_estekhdam,status_estekhdam,Pic)values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k,@l,@m,@n,@o,@s,@p)", con);
                    cmd.Parameters.AddWithValue("@a", txt_idemp.Text);
                    cmd.Parameters.AddWithValue("@b", txt_codeid.Text);
                    cmd.Parameters.AddWithValue("@c", txt_fname.Text);
                    cmd.Parameters.AddWithValue("@d", txt_lname.Text);
                    cmd.Parameters.AddWithValue("@e", txt_faname.Text);
                    cmd.Parameters.AddWithValue("@f", mask_birthday.Text);
                    cmd.Parameters.AddWithValue("@g", txt_numsh.Text);
                    cmd.Parameters.AddWithValue("@h", comb_study.Text);
                    cmd.Parameters.AddWithValue("@i", txt_phnum.Text);
                    cmd.Parameters.AddWithValue("@j", txt_mobile.Text);
                    cmd.Parameters.AddWithValue("@k", comb_sinmar.Text);
                    cmd.Parameters.AddWithValue("@l", txt_major.Text);
                    cmd.Parameters.AddWithValue("@m", txt_namejob.Text);
                    cmd.Parameters.AddWithValue("@n", txt_salary.Text);
                    cmd.Parameters.AddWithValue("@o", mask_estekhdam.Text);
                    cmd.Parameters.AddWithValue("@s", comb_estekhdam.Text);
                    cmd.Parameters.AddWithValue("@p", SqlDbType.VarBinary).Value = ar;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("کارمند ثبت شد");
                    txt_idemp.Focus(); ;

                    txt_idemp.Text = "";
                    txt_codeid.Text = "";
                    txt_fname.Text = "";
                    txt_lname.Text = "";
                    txt_faname.Text = "";
                    mask_birthday.Text = "";
                    txt_numsh.Text = "";
                    txt_phnum.Text = "";
                    txt_mobile.Text = "";
                    txt_major.Text = "";
                    txt_namejob.Text = "";
                    txt_salary.Text = "";
                    mask_estekhdam.Text = "";
                    comb_sinmar.Text = "";
                    comb_study.Text = "";
                    comb_estekhdam.Text = "";



                    pictureBox.Image = null;
                }
                
            }
            catch (Exception) 
            {
                MessageBox.Show("مشکلی پیش آمده است");
            }

            
        }

        Image imagebyte(byte[] bytes)
        {
            System.IO.MemoryStream m = new MemoryStream(bytes);
            return Image.FromStream(m);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "Delete from employee where id_emp=" + txt_idemp.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("کارمند حذف شد");


                txt_idemp.Text = "";
                txt_codeid.Text = "";
                txt_fname.Text = "";
                txt_lname.Text = "";
                txt_faname.Text = "";
                mask_birthday.Text = "";
                txt_numsh.Text = "";
                txt_phnum.Text = "";
                txt_mobile.Text = "";
                txt_major.Text = "";
                txt_namejob.Text = "";
                txt_salary.Text = "";
                mask_estekhdam.Text = "";
                comb_sinmar.Text = "";
                comb_study.Text = "";
                comb_estekhdam.Text = ""; 
            }
            catch (Exception)
            {
                MessageBox.Show("مشکلی پیش آمده است");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            try
            {
                pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            }
            catch (Exception)
            {
            }
            byte[] arrPic = ms.GetBuffer();
            ms.Close();
            cmd.Parameters.Clear();
            cmd.Connection = con;
            string Updateemployee = "Update employee set id_emp='" + txt_idemp.Text + "',codemeli='" + txt_codeid.Text + "',fname='" + txt_fname.Text + "',lname='" + txt_lname.Text + "',fathername='" + txt_faname.Text + "',birth='" + mask_birthday.Text + "',shenasnameh='" + txt_numsh.Text + "',tahol='" + comb_sinmar.Text + "',phon='" + txt_phnum.Text + "',mobile='" + txt_mobile.Text + "',study='" + comb_study.Text + "',majer='" + txt_major.Text  + "',namejob='" + txt_namejob.Text + "',salary='" + txt_salary.Text + "',date_estekhdam='" + mask_estekhdam.Text + "',status_estekhdam='" + comb_estekhdam.Text + "',pic=@Pic where id_emp='" + txt_idemp.Text + "'";
            SqlCommand com = new SqlCommand(Updateemployee, con);
            com.Parameters.AddWithValue("@Pic", arrPic);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("ویرایش انجام شد");


            txt_idemp.Text = "";
            txt_codeid.Text = "";
            txt_fname.Text = "";
            txt_lname.Text = "";
            txt_faname.Text = "";
            mask_birthday.Text = "";
            txt_numsh.Text = "";
            txt_phnum.Text = "";
            txt_mobile.Text = "";
            txt_major.Text = "";
            txt_namejob.Text = "";
            txt_salary.Text = "";
            mask_estekhdam.Text = "";
            comb_sinmar.Text = "";
            comb_study.Text = "";
            comb_estekhdam.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_listemp_Click(object sender, EventArgs e)
        {
            new frmlistemp().ShowDialog();
        }

       /* private void btn_search_idemp_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from employee where id_emp=@N";
            cmd.Parameters.AddWithValue("@N", txt_idemp.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_idemp.Text = dr["id_emp"].ToString();
                txt_codeid.Text = dr["codemeli"].ToString();
                txt_fname.Text = dr["fname"].ToString();
                txt_lname.Text = dr["lname"].ToString();
                txt_faname.Text = dr["fathername"].ToString();
                mask_birthday.Text = dr["birth"].ToString();
                txt_numsh.Text = dr["shenasnameh"].ToString();
                comb_sinmar.Text = dr["tahol"].ToString(); 
                txt_phnum.Text = dr["phon"].ToString();
                txt_mobile.Text = dr["mobile"].ToString();
                comb_study.Text = dr["study"].ToString();
                txt_major.Text = dr["majer"].ToString();
                txt_namejob.Text = dr["namejob"].ToString();
                txt_salary.Text = dr["salary"].ToString();
                mask_estekhdam.Text = dr["date_estekhdam"].ToString();
                comb_estekhdam.Text = dr["status_estekhdam"].ToString();
                pictureBox.Image = imagebyte((byte[])dr[17]);
            }
            else
            {
                txt_idemp.Text = "";
                MessageBox.Show("مقداری پیدا نشد");
            }
            con.Close();
        }*/

        private void btn_search_idjob_Click(object sender, EventArgs e)
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
            }
            else
            {
                MessageBox.Show("اطلاعاتی برای کد وارد شده پیدا نشد");
                txt_idjob.Text = "";
                txt_idjob.Focus();
            }
            con.Close();
        }

        private void btn_savepic_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "All Pictures(*.*)|*.hpg;*.bmp;*.png;*.gif";
                op.ShowDialog();
                pictureBox.ImageLocation = op.FileName;
            }
            catch (Exception)
            {
            }
        }

        private void btn_deletepic_Click(object sender, EventArgs e)
        {
            pictureBox.ImageLocation = null;
        }

        private void btn_search_idemp_Click_1(object sender, EventArgs e)
        {

            SqlDataReader dr;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from employee where id_emp=@N";
            cmd.Parameters.AddWithValue("@N", txt_idemp.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_idemp.Text = dr["id_emp"].ToString();
                txt_codeid.Text = dr["codemeli"].ToString();
                txt_fname.Text = dr["fname"].ToString();
                txt_lname.Text = dr["lname"].ToString();
                txt_faname.Text = dr["fathername"].ToString();
                mask_birthday.Text = dr["birth"].ToString();
                txt_numsh.Text = dr["shenasnameh"].ToString();
                comb_sinmar.Text = dr["tahol"].ToString();
                txt_phnum.Text = dr["phon"].ToString();
                txt_mobile.Text = dr["mobile"].ToString();
                comb_study.Text = dr["study"].ToString();
                txt_major.Text = dr["majer"].ToString();
                txt_namejob.Text = dr["namejob"].ToString();
                txt_salary.Text = dr["salary"].ToString();
                mask_estekhdam.Text = dr["date_estekhdam"].ToString();
                comb_estekhdam.Text = dr["status_estekhdam"].ToString();
                pictureBox.Image = imagebyte((byte[])dr[17]);
            }
            else
            {
                txt_idemp.Text = "";
                MessageBox.Show("مقداری پیدا نشد");
            }
            con.Close();
        }
    }
}
