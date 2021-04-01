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
    public partial class Frm_Bill : Form
    {
        Database_Connection DB = new Database_Connection();
        public static int Com_student;
        public static int CheckofOldBill = 0;


        public Frm_Bill()
        {
            InitializeComponent();

            Fill_ComStudent();
            Com_NameS.SelectedValue = 0;

            Fill_DGV_Bill();
        }

        private void Fill_ComStudent()
        {

            SqlDataAdapter ad = new SqlDataAdapter("select Students.Id_S , Students.Name from Students inner join Student_Regisrtation  on Student_Regisrtation.Id_S =Students.Id_S order by Id_S DESC ", DB.sqlconnection);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            Com_NameS.DataSource = dt;
            Com_NameS.DisplayMember = "Name";
            Com_NameS.ValueMember = "Id_S";
        }
         private void Fill_DGV_Bill()
        {
            SqlDataAdapter ad = new SqlDataAdapter(" select Bill.Id_Bill as'الرقم' , Students.Name as'اسم الطالب', Bill.Paid as 'المبلغ المدفوع' ,Bill.Rest as 'الباقي',Bill.Date as 'تاريخ الدفع' from  Bill inner join Students on Students.Id_S = Bill.Id_S ", DB.sqlconnection);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            DGV_Bill.DataSource = dt;
            DGV_Bill.Columns[2].DefaultCellStyle.Format = "C0";
            DGV_Bill.Columns[3].DefaultCellStyle.Format = "C0";


        }
        private void Frm_Bill_SizeChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void Com_NameS_SelectedIndexChanged(object sender, EventArgs e)
         {
            try
            {
                Com_student = Convert.ToInt32(Com_NameS.SelectedValue);
                CheckofOldBill = Convert.ToInt32(Com_NameS.SelectedValue);


                SqlDataAdapter da = new SqlDataAdapter("select ISNULL(SUM(Value_Reg),0) as 'Result' from Student_Regisrtation inner join Students on Students.Id_S=Student_Regisrtation.Id_S where Student_Regisrtation.Id_S='" + Convert.ToInt32(Com_NameS.SelectedValue) + "'", DB.sqlconnection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    RText_Total.Text = dt.Rows[0][0].ToString();

                }
            }
            catch (Exception ex) { }
        }

        private void RText_Paid_KeyPress(object sender, KeyPressEventArgs e)
        {
            Frm_Students student = new Frm_Students();
            student.OnlyNumber(e);
        }

        private void Frm_Bill_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Btn_Reset_Click(sender, e);
            }
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Com_NameS.SelectedIndex = -1;
            RText_Paid.ResetText();
            RText_Rest.ResetText();
            RText_Total.ResetText();
            DTP_history.Value = Convert.ToDateTime(DateTime.Now);
            DGV_Bill.ClearSelection();


        }

        private void Frm_Bill_Load(object sender, EventArgs e)
        {
            DGV_Bill.ClearSelection();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
             if (DGV_Bill.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(" تأكيد عملية الحذف ؟ ", "عملية الحذف ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("delete Bill where Id_Bill='" + Convert.ToInt32(DGV_Bill.CurrentRow.Cells[0].Value) + "'", DB.sqlconnection);
                    DB.Open();
                    cmd.ExecuteNonQuery();
                    DB.Close();
                    Fill_DGV_Bill();
                     Btn_Reset_Click(sender, e);
                }
                else
                {
                    Btn_Reset_Click(sender, e);
                }
        }
    }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (Com_NameS.SelectedIndex == -1 || string.IsNullOrEmpty(RText_Paid.Text) || string.IsNullOrEmpty(RText_Total.Text) || string.IsNullOrEmpty(RText_Rest.Text))
            {
                MessageBox.Show("الرجاء إكمال المعلومات المطلوبة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                SqlCommand cmd = new SqlCommand("insert into Bill values( Next value For Id_Bill, '" +Convert.ToInt32( RText_Paid.Text) + "' , '" + Convert.ToInt32(RText_Rest.Text) + "' , '" + DTP_history.Value.ToShortDateString() + "', '" + Convert.ToInt32(Com_NameS.SelectedValue) + "')", DB.sqlconnection);
                DB.Open();
                cmd.ExecuteNonQuery();
                DB.Close();

                MessageBox.Show("تمت عملية الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Fill_DGV_Bill();
                Btn_Reset_Click(sender, e);
            }
        }

        private void RText_Rest_Click(object sender, EventArgs e)
        {
          
                if (string.IsNullOrEmpty(RText_Total.Text) || string.IsNullOrEmpty(RText_Paid.Text))
                {
                    return;
                }

                int Total = Convert.ToInt32(RText_Total.Text);
                int NewPaid = Convert.ToInt32(RText_Paid.Text);

                SqlDataAdapter da = new SqlDataAdapter(" select ISNULL(SUM(Bill.Paid),0) as 'Result' from Bill inner join Students on Students.Id_S=Bill.Id_S where Bill.Id_S='" + Convert.ToInt32(Com_NameS.SelectedValue) + "'", DB.sqlconnection);
                DataTable dt = new DataTable();
                da.Fill(dt);


                   int OldPaid = Convert.ToInt32(dt.Rows[0][0].ToString());
                    RText_Rest.Text = (Total - (NewPaid + OldPaid)).ToString();

                if (Convert.ToInt32(RText_Rest.Text) < 0)
                {
                    MessageBox.Show("  (المبالغ التي تم دفعها (السابقة و الحالية \n   .قد تجاوزت المبلغ الكامل  ", "رسالة خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            
        }

        private void RText_Rest_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGV_Bill_DoubleClick(object sender, EventArgs e)
        {
            if (DGV_Bill.SelectedRows.Count == 0)
                return;

            Com_NameS.Text = DGV_Bill.CurrentRow.Cells[1].Value.ToString();
            RText_Paid.Text = DGV_Bill.CurrentRow.Cells[2].Value.ToString();
            RText_Rest.Text = DGV_Bill.CurrentRow.Cells[3].Value.ToString();
            DTP_history.Value = Convert.ToDateTime(DGV_Bill.CurrentRow.Cells[4].Value.ToString());

            DGV_Bill.ClearSelection();
        }
        
        private void Btn_Symptoms_Click(object sender, EventArgs e)
        {
            SqlDataAdapter ad = new SqlDataAdapter("select Bill.Id_Bill as'الرقم' , Students.Name as'اسم الطالب', Bill.Paid as 'المبلغ المدفوع' ,Bill.Rest as 'الباقي',Bill.Date as 'تاريخ الدفع' from  Bill inner join Students on Students.Id_S = Bill.Id_S where Students.Name like '%" + RText_Search.Text + "%' or Bill.Date like '%" + RText_Search.Text + "%' ", DB.sqlconnection);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            DGV_Bill.DataSource = dt;

            DGV_Bill.ClearSelection();
        }

        private void Frm_Bill_Leave(object sender, EventArgs e)
        {
            CheckofOldBill = 0;
        }
        }
}
