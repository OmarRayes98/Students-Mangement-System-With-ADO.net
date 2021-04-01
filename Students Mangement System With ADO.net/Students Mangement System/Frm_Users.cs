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
    public partial class Frm_Users : Form
    {
        Database_Connection DB = new Database_Connection();
        bool Enable_BtnAdd = true;

        public Frm_Users()
        {
            InitializeComponent();
            Fill_DGV_User();
        }

        private void Fill_DGV_User()
        {
            SqlDataAdapter ad = new SqlDataAdapter("select * from[User]", DB.sqlconnection);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            DGV_Users.DataSource = dt;
            DGV_Users.Columns[0].HeaderText = "رقم المستخدم";
            DGV_Users.Columns[1].HeaderText = "اسم المستخدم";
            DGV_Users.Columns[2].HeaderText = "كلمة المرور";
            DGV_Users.Columns[3].HeaderText = "نوع الصلاحية";

        }

        private void Frm_Users_SizeChanged(object sender, EventArgs e)
        {
                this.WindowState = FormWindowState.Maximized;
        }

        private void Frm_Users_Load(object sender, EventArgs e)
        {
            RText_User.Focus();
            DGV_Users.ClearSelection();

        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            Btn_Add.Enabled = true;
            Btn_Update.Enabled = false;

            RText_User.ResetText();
            RText_Password.ResetText();
            Com_User.SelectedIndex = -1;
            DGV_Users.ClearSelection();
        }

        private void Frm_Users_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Btn_New_Click(sender, e);
            }  
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
           
                if (string.IsNullOrEmpty(RText_User.Text) || string.IsNullOrEmpty(RText_Password.Text) || Com_User.SelectedIndex == -1)
                {
                    MessageBox.Show("الرجاء إكمال المعلومات المطلوبة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into [User] values('" + RText_User.Text + "' , '" + RText_Password.Text + "' , '" + Com_User.SelectedItem.ToString() + "')",DB.sqlconnection);
                    DB.Open();
                    cmd.ExecuteNonQuery();
                    DB.Close();

                    MessageBox.Show("تمت عملية الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Fill_DGV_User();
                }
                Btn_New_Click(sender, e);

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (DGV_Users.SelectedRows.Count > 0)
                if (MessageBox.Show(" تأكيد عملية الحذف ؟ ", "عملية الحذف ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("delete [User] where Id_User='" + Convert.ToInt32(DGV_Users.CurrentRow.Cells[0].Value) + "'",DB.sqlconnection);
                    DB.Open();
                    cmd.ExecuteNonQuery();
                    DB.Close();
                    Fill_DGV_User();
                    Btn_New_Click(sender, e);
                }
                else
                {
                    Btn_New_Click(sender, e);
                }
        }

        private void DGV_Users_DoubleClick(object sender, EventArgs e)
        {
            if (DGV_Users.SelectedRows.Count == 0)
                return;

            RText_User.Text = DGV_Users.CurrentRow.Cells[1].Value.ToString();
            RText_Password.Text = DGV_Users.CurrentRow.Cells[2].Value.ToString();
            Com_User.Text = DGV_Users.CurrentRow.Cells[3].Value.ToString();

            DGV_Users.ClearSelection();
            Btn_Update.Enabled = true;
            Enable_BtnAdd = false;
            Btn_Add.Enabled = false;
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update [User] set  Name ='"+RText_User.Text+"'  , PWD='"+RText_Password.Text+"' , User_Type='"+Com_User.SelectedItem.ToString()+"' where Id_User ='"+Convert.ToInt32( DGV_Users.CurrentRow.Cells[0].Value.ToString())+"' ", DB.sqlconnection);
                DB.Open();
                cmd.ExecuteNonQuery();
                DB.Close();

                MessageBox.Show("تمت عملية التعديل بنجاح", "عملية التعديل ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Fill_DGV_User();

                if (Enable_BtnAdd == false)
                {
                    Btn_Add.Enabled = true;
                }
                Btn_Update.Enabled = false;

                Btn_New_Click(sender, e);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
