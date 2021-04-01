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
    public partial class Frm_StudentsClass : Form
    {
        Database_Connection DB = new Database_Connection();
        public Frm_StudentsClass()
        {
            InitializeComponent();
        }

        private void Frm_StudentsClass_SizeChanged(object sender, EventArgs e)
        {
        }

        private void Frm_StudentsClass_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select Student_Regisrtation.Id_S as 'الرقم',Students.Name as 'اسم الطالب',Students.Phone as 'الموبايل',Specializtion.Name_Specializtion as 'الاختصاص',Class.Name as 'اسم الصف' ,Value_Reg as 'تكاليف التسجيل',Date_Reg as 'تاريخ التسجيل',Note_Reg as 'تبرير المبلغ' from Student_Regisrtation inner join Students on Students.Id_S = Student_Regisrtation.Id_S inner join Class on Class.Id_Class=Student_Regisrtation.Id_Class inner join Specializtion on Specializtion.Id_Specializtion=Students.Id_Specializtion where Class.Id_Class='"+Frm_Class.idclass+"'",DB.sqlconnection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DGV_InfoStudent.DataSource=dt;

        }
    }
}
