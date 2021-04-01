using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Students_Mangement_System
{
    public partial class Frm_Login : Form
    {
        Database_Connection DB = new Database_Connection();
        public Frm_Login()
        {
            InitializeComponent();
            Fill_ComUsers();
            Com_Users.SelectedValue = 0;
        }

        private void Fill_ComUsers()
        {
            SqlDataAdapter ad = new SqlDataAdapter("select * from[User]", DB.sqlconnection);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            Com_Users.DataSource = dt;
            Com_Users.DisplayMember = "Name";
            Com_Users.ValueMember = "Id_User";
        }


        private void Btn_Cancel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Com_Users.Text) || (string.IsNullOrEmpty(Txt_PWD.Text) && string.IsNullOrEmpty(Txt_PWD.Text)))
            {
                MessageBox.Show("لا يمكن ترك البيانات فارغة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            SqlDataAdapter ad = new SqlDataAdapter("select * from[User] where Name='" + Com_Users.Text + "'and PWD='" + Txt_PWD.Text + "' and Id_User='"+Convert.ToInt32(Com_Users.SelectedValue)+"' ", DB.sqlconnection);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Pic_Up.Image = Properties.Resources.True;
                Pic_Down.Image = Properties.Resources.True;
                MessageBox.Show("تم تسجيل الدخول بنجاح ", "تسجيل الدخول",MessageBoxButtons.OK, MessageBoxIcon.Information);

                Frm_MainForm MainF = new Frm_MainForm();
                var user_type = dt.Rows[0][3];

                if (user_type.ToString() == "مدير")
                {
                    MainF.ToolMS_Users.Enabled = true;
                }
                else
                {
                    MainF.ToolMS_Users.Enabled = false;
                }
                this.Hide();
                MainF.ShowDialog();
            }
            else
            {
                Pic_Down.Image = Properties.Resources.False;
                MessageBox.Show("الرجاء التحقق من  المعلومات ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Btn_Eyes_Visible_Click(object sender, EventArgs e)
        {
            Txt_PWD.UseSystemPasswordChar = false;
            Btn_Eyes_Visible.Visible = false;
        }

        private void Btn_Eye_Hide_Click(object sender, EventArgs e)
        {
            Txt_PWD.UseSystemPasswordChar = true;
            Btn_Eyes_Visible.Visible = true;
        }

        private void Frm_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_login_Click(sender, e);
            }
        }


    }
}
