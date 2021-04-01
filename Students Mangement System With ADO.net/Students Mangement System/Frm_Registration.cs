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
    public partial class Frm_Registration : Form
    {
        Database_Connection DB = new Database_Connection();
        bool Enable_BtnAdd = true;
        public Frm_Registration()
        {
            InitializeComponent();

            Fill_ComStudent();
            Com_NameS.SelectedValue = 0;

            Fill_ComClass();
            Com_NameC.SelectedValue = 0;

            FillDGV_Reg();

        }

        private void FillDGV_Reg()
        {

            SqlDataAdapter ad = new SqlDataAdapter("select Student_Regisrtation.Id_SR as 'الرقم',Students.Name as 'اسم الطالب',Class.Name as 'اسم الصف',Date_Reg as 'تاريخ التسجيل' ,Value_Reg as 'تكاليف التسجيل',Note_Reg as 'تبرير المبلغ' from Student_Regisrtation inner join Students on Students.Id_S = Student_Regisrtation.Id_S inner join Class on Class.Id_Class=Student_Regisrtation.Id_Class", DB.sqlconnection);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            DGV_Registration.DataSource = dt;

            DGV_Registration.Columns[4].DefaultCellStyle.Format = "C0";

            foreach (DataGridViewColumn column in DGV_Registration.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                if (column == DGV_Registration.Columns[1])
                {
                    DGV_Registration.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    continue;
                }
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void Check_DGV_Size()
        {
            if (DGV_Registration.Columns[0].Width <= 68)
            {
                DGV_Registration.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            else
            {
                DGV_Registration.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        private void Fill_ComStudent()
        {

            SqlDataAdapter ad = new SqlDataAdapter("select * from Students order by Id_S DESC ", DB.sqlconnection);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            Com_NameS.DataSource = dt;
            Com_NameS.DisplayMember = "Name";
            Com_NameS.ValueMember = "Id_S";
        }

        private void Fill_ComClass()
        {

            SqlDataAdapter ad = new SqlDataAdapter("select * from Class order by Id_Class DESC", DB.sqlconnection);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            Com_NameC.DataSource = dt;
            Com_NameC.DisplayMember = "Name";
            Com_NameC.ValueMember = "Id_Class";
        }

        private void Frm_Registration_SizeChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void RadBtn_SepicalC_CheckedChanged(object sender, EventArgs e)
        {
            if (RadBtn_SepicalC.Checked == true)
            {
                RText_SpecialC.ReadOnly = false;
                RText_Cause.ReadOnly = false;
                RText_SpecialC.ResetText();
                RText_Cause.ResetText();
            }
            else
            {
                RText_SpecialC.ReadOnly = true;
                RText_Cause.ReadOnly = true;
                RText_SpecialC.Text = "المبلغ الخاص";
                RText_Cause.Text = "تبرير السعر";
            }
        }

        private void Frm_Registration_Load(object sender, EventArgs e)
        {
            DGV_Registration.ClearSelection();
            RText_SpecialC.Text = "المبلغ الخاص";
            RText_Cause.Text = "تبرير السعر";
            Check_DGV_Size();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Btn_Add.Enabled = true;
            Btn_Update.Enabled = false;

            Com_NameS.SelectedValue = 0;
            Com_NameC.SelectedValue = 0;
            Lbl_Course.Text = ". . . . .";
            Lbl_Cost.Text = ". . . . .";
            DTP_history.Value = Convert.ToDateTime(DateTime.Now);
            RadBtn_Cost.Checked = true;
            RadBtn_SepicalC.Checked = false;


            DGV_Registration.ClearSelection();
        }

        private void Frm_Registration_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Btn_Reset_Click(sender, e);
            }
        }

        private void RText_SpecialC_KeyPress(object sender, KeyPressEventArgs e)
        {
            Frm_Students student = new Frm_Students();
            student.OnlyNumber(e);
        }

        private void Com_NameC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select Course.Name , Course.Cost from  Class inner join Course on Course.Id_Course=Class.Id_Course  where Class.Id_Class= '" + Convert.ToInt32(Com_NameC.SelectedValue) + "'", DB.sqlconnection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Lbl_Course.Text = dt.Rows[0][0].ToString();
                    Lbl_Cost.Text = dt.Rows[0][1].ToString();

                }
            }
            catch (Exception ex) { }
        }

        DataTable Check_FindStudentClass()
        {
            SqlDataAdapter ad = new SqlDataAdapter("select * from Student_Regisrtation where Student_Regisrtation.Id_S='" + Convert.ToInt32(Com_NameS.SelectedValue) + "' and Student_Regisrtation.Id_Class='" + Convert.ToInt32(Com_NameC.SelectedValue) + "'", DB.sqlconnection);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
        }
        DataTable Check_FindStudentCourse()
        {
            SqlDataAdapter ad = new SqlDataAdapter(" select Student_Regisrtation.Id_S ,Course.Name , Course.Cost from  Class inner join Course on Course.Id_Course=Class.Id_Course inner join Student_Regisrtation on Student_Regisrtation.Id_Class=Class.Id_Class inner join Students on Student_Regisrtation.Id_S=Students.Id_S where Student_Regisrtation.Id_S= '"+Convert.ToInt32(Com_NameS.SelectedValue)+"' and Course.Name='"+Lbl_Course.Text+"'", DB.sqlconnection);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            string RadBtnCost;
            string Cause;

            if (RadBtn_Cost.Checked)
            {
                RadBtnCost = Lbl_Cost.Text;
                Cause = RadBtn_Cost.Text;
            }
            else
            {
                RadBtnCost = RText_SpecialC.Text;
                Cause = RText_Cause.Text;
            }

            if (Com_NameS.SelectedIndex == -1 || Com_NameC.SelectedIndex == -1 || string.IsNullOrEmpty(RText_SpecialC.Text))
            {
                MessageBox.Show("الرجاء إكمال المعلومات المطلوبة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (Check_FindStudentClass().Rows.Count > 0)
                {
                    MessageBox.Show("! هذا الطالب مسجل مسبقا بهذا الصف", "معلومات ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                }
                else if (Check_FindStudentCourse().Rows.Count > 0)
                {
                    MessageBox.Show(" , هذا الطالب مسجل مسبقا في هذا الكورس \n ! لا يمكن تسجيل طالب في أكثر من صف لأجل كورس واحد", "معلومات ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                SqlCommand cmd = new SqlCommand("insert into Student_Regisrtation values( Next value For Id_SR ,'" + Convert.ToInt32(Com_NameS.SelectedValue) + "' , '" + Convert.ToInt32(Com_NameC.SelectedValue) + "' ,'" + DTP_history.Value.ToShortDateString() + "' ,'" + Convert.ToInt32(RadBtnCost) + "','" + Cause + "' )", DB.sqlconnection);
                DB.Open();
                cmd.ExecuteNonQuery();
                DB.Close();

                MessageBox.Show("تمت عملية الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDGV_Reg();
                Check_DGV_Size();
                Btn_Reset_Click(sender, e);

            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (DGV_Registration.SelectedRows.Count > 0)
                if (MessageBox.Show(" تأكيد عملية الحذف ؟ ", "عملية الحذف ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("delete Student_Regisrtation where Id_SR='" + Convert.ToInt32(DGV_Registration.CurrentRow.Cells[0].Value) + "'", DB.sqlconnection);
                    DB.Open();
                    cmd.ExecuteNonQuery();
                    DB.Close();
                    FillDGV_Reg();
                    Btn_Reset_Click(sender, e);
                }
                else
                {
                    Btn_Reset_Click(sender, e);
                }
        }

        private void DGV_Registration_DoubleClick(object sender, EventArgs e)
        {
            if (DGV_Registration.SelectedRows.Count == 0)
                return;

            Com_NameS.Text = DGV_Registration.CurrentRow.Cells[1].Value.ToString();
            Com_NameC.Text = DGV_Registration.CurrentRow.Cells[2].Value.ToString();
            DTP_history.Value = Convert.ToDateTime(DGV_Registration.CurrentRow.Cells[3].Value.ToString());

            string cause = this.DGV_Registration.CurrentRow.Cells[5].Value.ToString();

            if (cause == "المبلغ الافتراضي")
            {
                RadBtn_Cost.Checked = true;

            }
            else
            {
                RadBtn_SepicalC.Checked = true;
                RText_SpecialC.Text = this.DGV_Registration.CurrentRow.Cells[4].Value.ToString();
                RText_Cause.Text = this.DGV_Registration.CurrentRow.Cells[5].Value.ToString();
            }

            DGV_Registration.ClearSelection();
            Btn_Update.Enabled = true;
            Enable_BtnAdd = false;
            Btn_Add.Enabled = false;
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            string RadBtnCost;
            string Cause;

            if (RadBtn_Cost.Checked)
            {
                RadBtnCost = Lbl_Cost.Text;
                Cause = RadBtn_Cost.Text;
            }
            else
            {
                RadBtnCost = RText_SpecialC.Text;
                Cause = RText_Cause.Text;
            }

            if (Com_NameS.SelectedIndex == -1 || Com_NameC.SelectedIndex == -1 || string.IsNullOrEmpty(RText_SpecialC.Text))
            {
                MessageBox.Show("الرجاء إكمال المعلومات المطلوبة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("update Student_Regisrtation set  Id_S ='" + Convert.ToInt32(Com_NameS.SelectedValue) + "', Id_Class='" + Convert.ToInt32(Com_NameC.SelectedValue) + "' , Date_Reg='" + DTP_history.Value.ToShortDateString() + "',Value_Reg='" + Convert.ToInt32(RadBtnCost) + "',Note_Reg='" + Cause + "' where Id_SR ='" + Convert.ToInt32(DGV_Registration.CurrentRow.Cells[0].Value.ToString()) + "' ", DB.sqlconnection);
                    DB.Open();
                    cmd.ExecuteNonQuery();
                    DB.Close();

                    MessageBox.Show("تمت عملية التعديل بنجاح", "عملية التعديل ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillDGV_Reg();
                    Check_DGV_Size();


                    if (Enable_BtnAdd == false)
                    {
                        Btn_Add.Enabled = true;
                    }
                    Btn_Update.Enabled = false;

                    Btn_Reset_Click(sender, e);
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void RText_Search_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter("select Student_Regisrtation.Id_SR as 'الرقم',Students.Name as 'اسم الطالب',Class.Name as 'اسم الصف',Date_Reg as 'تاريخ التسجيل' ,Value_Reg as 'تكاليف التسجيل',Note_Reg as 'تبرير المبلغ' from Student_Regisrtation inner join Students on Students.Id_S = Student_Regisrtation.Id_S inner join Class on Class.Id_Class=Student_Regisrtation.Id_Class where Students.Name like '%" + RText_Search.Text + "%' or Class.Name like '%" + RText_Search.Text + "%' ", DB.sqlconnection);
            ad.Fill(dt);

            DGV_Registration.DataSource = dt;
            
            DGV_Registration.ClearSelection();
        }

        private void Com_NameS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

