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
    public partial class Frm_Session : Form
    {
        Database_Connection DB = new Database_Connection();
        bool Enable_BtnAdd = true;
        public Frm_Session()
        {
            InitializeComponent();

            Fill_Choose_Class();
            Com_Class.SelectedValue = 0;
            FillDGV_Session();

        }
        private void FillDGV_Session()
        {
            SqlDataAdapter ad = new SqlDataAdapter("select Id_Session as 'الرقم' ,Class.Name as 'اسم الصف' , Day_S as 'اليوم' ,Time_S as 'الوقت'   from [Session] inner join Class on Class.Id_Class=[Session].Id_Class", DB.sqlconnection);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            DGV_Session.DataSource = dt;

        }

        private void Fill_Choose_Class()
        {
            SqlDataAdapter ad = new SqlDataAdapter("select * from Class order by Id_Class DESC ", DB.sqlconnection);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            Com_Class.DataSource = dt;
            Com_Class.DisplayMember = "Name";
            Com_Class.ValueMember = "Id_Class";

        }

        private void Frm_Session_SizeChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            Btn_Add.Enabled = true;
            Btn_Update.Enabled = false;

            Com_Class.SelectedValue = 0;
            Com_Days.SelectedIndex = -1;
            DTP_time.Value = Convert.ToDateTime(DateTime.Now);
            DGV_Session.ClearSelection();

        }

        private void Frm_Session_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Btn_New_Click(sender, e);
            }
        }

        private void Frm_Session_Load(object sender, EventArgs e)
        {
            DGV_Session.ClearSelection();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (Com_Class.SelectedIndex == -1 || Com_Days.SelectedIndex == -1)
            {
                MessageBox.Show("الرجاء إكمال المعلومات المطلوبة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into [Session] values( Next value For Id_Seesion,'" + Com_Days.Text + "' , '" + DTP_time.Text + "' ,'" + Convert.ToInt32(Com_Class.SelectedValue) + "')", DB.sqlconnection);
                DB.Open();
                cmd.ExecuteNonQuery();
                DB.Close();

                MessageBox.Show("تمت عملية الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDGV_Session();

                Btn_New_Click(sender, e);

            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (DGV_Session.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(" تأكيد عملية الحذف ؟ ", "عملية الحذف ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("delete [Session] where Id_Session='" + Convert.ToInt32(DGV_Session.CurrentRow.Cells[0].Value) + "'", DB.sqlconnection);
                    DB.Open();
                    cmd.ExecuteNonQuery();
                    DB.Close();

                    FillDGV_Session();
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
                SqlCommand cmd = new SqlCommand("update [Session] set  Day_S ='" + Com_Days.Text + "'  , Time_S='" + DTP_time.Text + "' , Id_Class='" + Convert.ToInt32(Com_Class.SelectedValue) + "' where Id_Session ='" + Convert.ToInt32(DGV_Session.CurrentRow.Cells[0].Value.ToString()) + "' ", DB.sqlconnection);
                DB.Open();
                cmd.ExecuteNonQuery();
                DB.Close();

                MessageBox.Show("تمت عملية التعديل بنجاح", "عملية التعديل ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FillDGV_Session();

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
        
        private void DGV_Session_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (DGV_Session.SelectedRows.Count == 0)
                    return;

                Com_Class.Text = DGV_Session.CurrentRow.Cells[1].Value.ToString();
                Com_Days.Text = DGV_Session.CurrentRow.Cells[2].Value.ToString();
                DTP_time.Value = Convert.ToDateTime(DGV_Session.CurrentRow.Cells[3].Value.ToString());

                DGV_Session.ClearSelection();
                Btn_Update.Enabled = true;
                Enable_BtnAdd = false;
                Btn_Add.Enabled = false;
            }
            catch (Exception ex) { }
           
        }
    }
}

