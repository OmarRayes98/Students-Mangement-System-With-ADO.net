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

    public partial class Frm_Class : Form
    {
        Database_Connection DB = new Database_Connection();
        bool Enable_BtnAdd = true;
        public static int idclass;
        public Frm_Class()
        {
            InitializeComponent();
            Fill_ComNameClass();
            Com_NameClass.SelectedValue = 0;
            Fill_DGV_Class();
        }

        private void Fill_DGV_Class()
        {
            SqlDataAdapter ad = new SqlDataAdapter("select * from Class", DB.sqlconnection);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            DGV_Class.DataSource = dt;
            DGV_Class.Columns[0].HeaderText = "رقم الصف";
            DGV_Class.Columns[1].HeaderText = "اسم الصف";
            DGV_Class.Columns[2].HeaderText = "رقم الكورس";

        }

        private void Fill_ComNameClass()
        {
            SqlDataAdapter ad = new SqlDataAdapter("select * from Course", DB.sqlconnection);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            Com_NameClass.DataSource = dt;
            Com_NameClass.DisplayMember = "Name";
            Com_NameClass.ValueMember = "Id_Course";
        }

        private void Frm_Class_Load(object sender, EventArgs e)
        {
            DGV_Class.ClearSelection();
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            Btn_Add.Enabled = true;
            Btn_Update.Enabled = false;

            Com_NameClass.SelectedValue = 0;
            RText_Letter.ResetText();
            DGV_Class.ClearSelection();

        }

        private void Frm_Class_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Btn_New_Click(sender, e);
            }
        }

        private void Frm_Class_SizeChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }
       private DataTable  Check_NameClass()
       {
           SqlDataAdapter ad = new SqlDataAdapter("select * from Class where Class.Name='" + RText_Edit.Text + "'", DB.sqlconnection);
           DataTable dt = new DataTable();
           ad.Fill(dt);

           return dt;
       }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (Com_NameClass.SelectedIndex == -1 || string.IsNullOrEmpty(RText_Letter.Text))
            {
                MessageBox.Show("الرجاء إكمال المعلومات المطلوبة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (Check_NameClass().Rows.Count > 0)
                {
                    MessageBox.Show("                   , هذا الاسم موجود سابقا  \n               الرجاء تغيير الحرف أو الرقم  \n . لعدم حدوث تشابه بأسماء الصفوف ", "معلومات ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                }

                SqlCommand cmd = new SqlCommand("insert into Class values(Next value For Id_Class,'" + "" + Com_NameClass.Text + " فئة : " + RText_Letter.Text + "" + "' , '" + Convert.ToInt32(Com_NameClass.SelectedValue) + "')", DB.sqlconnection);
                DB.Open();
                cmd.ExecuteNonQuery();
                DB.Close();

                MessageBox.Show("تمت عملية الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Fill_DGV_Class();
                Btn_New_Click(sender, e);

            }
        }


        private void RText_Letter_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {

                if (DGV_Class.SelectedRows.Count > 0)
                {
                    MessageBox.Show("            تحذير : عند حذف صف سيتم حذف  \n  (كامل بياناته (الطلاب الصف وتسجيلاتهم الخاصة به ..الخ   ", "تحذير ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (MessageBox.Show(" تأكيد عملية الحذف ؟ ", "عملية الحذف ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand("delete Class where Id_Class='" + Convert.ToInt32(DGV_Class.CurrentRow.Cells[0].Value) + "'", DB.sqlconnection);
                        DB.Open();
                        cmd.ExecuteNonQuery();
                        DB.Close();
                        Fill_DGV_Class();
                        Btn_New_Click(sender, e);
                    }
                    else
                    {
                        Btn_New_Click(sender, e);
                    }
                }
            

        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update Class set  Name ='" + "" + Com_NameClass.Text + " فئة : " + RText_Letter.Text + "" + "'  , Id_Course='" + Convert.ToInt32(Com_NameClass.SelectedValue) + "' where Id_Class ='" + Convert.ToInt32(DGV_Class.CurrentRow.Cells[0].Value.ToString()) + "' ", DB.sqlconnection);
                DB.Open();
                cmd.ExecuteNonQuery();
                DB.Close();

                MessageBox.Show("تمت عملية التعديل بنجاح", "عملية التعديل ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Fill_DGV_Class();

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

        private void DGV_Class_DoubleClick(object sender, EventArgs e)
        {
            RText_Edit.ResetText();
            if (DGV_Class.SelectedRows.Count == 0)
                return;

            RText_Edit.Text = DGV_Class.CurrentRow.Cells[1].Value.ToString();


            DGV_Class.ClearSelection();

            Btn_Update.Enabled = true;
            Enable_BtnAdd = false;
            Btn_Add.Enabled = false;
        }

        private void Com_NameClass_TextChanged(object sender, EventArgs e)
        {
            RText_Edit.Text = "" + Com_NameClass.Text + " فئة : " + RText_Letter.Text + "";
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
           SqlDataAdapter ad = new SqlDataAdapter("select * from Class where Class.Name like '%" + RText_Search.Text + "%' ", DB.sqlconnection);
            ad.Fill(dt);

            DGV_Class.DataSource = dt;
            DGV_Class.Columns[0].HeaderText = "رقم الصف";
            DGV_Class.Columns[1].HeaderText = "اسم الصف";
            DGV_Class.Columns[2].HeaderText = "رقم الكورس";

            DGV_Class.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DGV_Class.SelectedRows.Count > 0)
            {
                idclass = Convert.ToInt32(DGV_Class.CurrentRow.Cells[0].Value.ToString());

                Frm_StudentsClass SClass = new Frm_StudentsClass();
                SClass.ShowDialog();
            }
            else
            {
                MessageBox.Show("                              , لم يتم تحديد سجل من الجدول الأسفل  \n . الرجاء تحديد سجل ثم الضغط لإظهار طلاب الصف المحدد", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RText_Edit_TextChanged(object sender, EventArgs e)
        {

        }


    }
}

    


