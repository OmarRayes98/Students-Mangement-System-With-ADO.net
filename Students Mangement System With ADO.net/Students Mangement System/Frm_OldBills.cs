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
    public partial class Frm_OldBills : Form
    {
        Database_Connection DB = new Database_Connection();
        public Frm_OldBills()
        {
            InitializeComponent();
        }

        private void Frm_OldBills_SizeChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void FillDGV_OldBill()
        {
            SqlDataAdapter ad = new SqlDataAdapter(" select Bill.Id_Bill as'الرقم' , Bill.Paid as 'المبلغ المدفوع' ,Bill.Rest as 'الباقي',Bill.Date as 'تاريخ الدفع' from  Bill inner join Students on Students.Id_S = Bill.Id_S where Students.Id_S='" + Frm_Bill.Com_student + "' ", DB.sqlconnection);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            DGV_OldBills.DataSource = dt;
            DGV_OldBills.Columns[1].DefaultCellStyle.Format = "C0";
            DGV_OldBills.Columns[2].DefaultCellStyle.Format = "C0";
        }
        private void Fill_Paid_TotalCost()
        {
            SqlDataAdapter ad1 = new SqlDataAdapter(" select ISNULL( Sum(Bill.Paid),0) as 'Paid'  from Students inner join Bill on Bill.Id_S=Students.Id_S where Bill.Id_S='" + Frm_Bill.Com_student + "' ", DB.sqlconnection);
            DataTable dt1 = new DataTable();
            ad1.Fill(dt1);

                Rtext_Paid.Text = dt1.Rows[0][0].ToString() + " ل.س ";

                SqlDataAdapter ad2 = new SqlDataAdapter(" select ISNULL( Sum(Student_Regisrtation.Value_Reg),0) as 'Paid'  from Students inner join Student_Regisrtation on Student_Regisrtation.Id_S=Students.Id_S where Student_Regisrtation.Id_S='" + Frm_Bill.Com_student + "' ", DB.sqlconnection);
                DataTable dt2 = new DataTable();
                ad2.Fill(dt2);

                RText_Total.Text = dt2.Rows[0][0].ToString() + " ل.س ";
            
        }

        private void Fill_Name_Rest()
        {
            SqlDataAdapter ad = new SqlDataAdapter(" select top 1  Students.Name , Bill.Rest   from Students inner join Bill on Bill.Id_S=Students.Id_S where Students.Id_S='"+Convert.ToInt32(Frm_Bill.Com_student)+"' order by Id_Bill desc ", DB.sqlconnection);
             DataTable dt = new DataTable();
             ad.Fill(dt);

             if (dt.Rows.Count > 0)
             {
                 RText_NameS.Text = dt.Rows[0][0].ToString();
                 RText_Rest.Text = dt.Rows[0][1].ToString() + " ل.س ";
             }
        }

        private void Frm_OldBills_Load(object sender, EventArgs e)
        {
            FillDGV_OldBill();
            Fill_Paid_TotalCost();
            Fill_Name_Rest();
            DGV_OldBills.ClearSelection();
        }
    }
}
