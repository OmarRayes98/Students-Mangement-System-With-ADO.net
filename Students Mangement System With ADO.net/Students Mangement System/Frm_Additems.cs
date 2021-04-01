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
    public partial class Frm_Additems : Form
    {
        Database_Connection DB = new Database_Connection();



        public Frm_Additems()
        {
            InitializeComponent();   
            Fill_ListItems();
        }

        private void Frm_Additems_Load(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
        }

        
             private void Fill_ListItems()
        {
            SqlDataAdapter ad = new SqlDataAdapter("select * from Specializtion", DB.sqlconnection);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            listBox1.DataSource = dt;
            listBox1.DisplayMember = "Name_Specializtion";
            listBox1.ValueMember = "Id_Specializtion";    

        }
        

        private void Btn_Add_Item_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RText_Items.Text) )
            {
                MessageBox.Show("لا يمكن ترك اسم الاختصاص فارغ  ", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into Specializtion values ('" + RText_Items.Text + "')", DB.sqlconnection);
                DB.Open();
                cmd.ExecuteNonQuery();
                DB.Close();

                MessageBox.Show("تمت عملية الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Fill_ListItems();
            }
            RText_Items.ResetText();
            listBox1.ClearSelected();

        }

        private void Btn_Delete_item_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.Items.Count > 0)
                    if (MessageBox.Show(" تأكيد عملية الحذف ؟ ", "عملية الحذف ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand("delete Specializtion where Id_Specializtion='" + Convert.ToInt32(listBox1.SelectedValue) + "'", DB.sqlconnection);
                        DB.Open();
                        cmd.ExecuteNonQuery();
                        DB.Close();
                        Fill_ListItems();
                        listBox1.ClearSelected();
                    }
                    else
                    {
                        listBox1.ClearSelected();
                    }
            }
            catch (Exception ex) {  }

        }

        private void RText_Items_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();

        }

        private void RText_Items_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Additems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_Add_Item_Click(sender, e);
            }  
        }

        private void Frm_Additems_FormClosed(object sender, FormClosedEventArgs e)
        {
            SqlDataAdapter ad = new SqlDataAdapter("select * from Specializtion", DB.sqlconnection);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            Frm_Students.getfrm_student.Com_Spicaliztion.DataSource = dt;
            Frm_Students.getfrm_student.Com_Spicaliztion.DisplayMember = "Name_Specializtion";
            Frm_Students.getfrm_student.Com_Spicaliztion.ValueMember = "Id_Specializtion";

            Frm_Students.getfrm_student.Com_Spicaliztion.SelectedValue = 0;
        }
    }
}
