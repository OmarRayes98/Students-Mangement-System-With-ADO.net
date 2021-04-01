using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Students_Mangement_System
{
    public partial class Frm_MainForm : Form
    {
        bool checkofScreen = true;
        public Frm_MainForm()
        {
            InitializeComponent();
        }

        private void Frm_MainForm_SizeChanged(object sender, EventArgs e)
        {

            if (checkofScreen == true)
            {

                this.WindowState = FormWindowState.Maximized;
                checkofScreen = false;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
                checkofScreen = true;
            }
        }

        private void Frm_MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Frm_MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                toolStripStatusLabel2.Text = "هاتف المكتب : " + Students_Mangement_System.Properties.Settings.Default.Number.ToString();
                toolStripStatusLabel3.Text = "ايميل  : " + Students_Mangement_System.Properties.Settings.Default.Email.ToString();
                toolStripStatusLabel1.Text = "اسم المكتب : " + Students_Mangement_System.Properties.Settings.Default.Name.ToString();
            }
            catch (Exception ex) {  }

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_Time.Text = Convert.ToString(DateTime.Now.ToString("ss : mm : hh  tt"));
            Lbl_Date.Text = Convert.ToString(DateTime.Now.ToString("dd / MM / yyyy"));
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolMS_Setting_Click(object sender, EventArgs e)
        {
            Panel_Frm.Controls.Clear();

            Frm_Setting setting = new Frm_Setting();

            setting.TopLevel = false;

            Panel_Frm.Controls.Add(setting);

            setting.Show();
        }

        private void ToolMS_Users_Click(object sender, EventArgs e)
        {
            Panel_Frm.Controls.Clear();

            Frm_Users user = new Frm_Users();

            user.TopLevel = false;

            Panel_Frm.Controls.Add(user);

            user.Show();
        }

        private void ToolMS_Students_Click(object sender, EventArgs e)
        {
            Panel_Frm.Controls.Clear();

            Frm_Students student = new Frm_Students();

            student.TopLevel = false;

            Panel_Frm.Controls.Add(student);

            student.Show();
        }

        private void إدارةالكورساتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel_Frm.Controls.Clear();

            Frm_Course course = new Frm_Course();

            course.TopLevel = false;

            Panel_Frm.Controls.Add(course);

            course.Show();
        }

        private void إدارةالصفوفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel_Frm.Controls.Clear();

            Frm_Class classes = new Frm_Class();

            classes.TopLevel = false;

            Panel_Frm.Controls.Add(classes);

            classes.Show();
        }

        private void الجلساتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel_Frm.Controls.Clear();

            Frm_Session session = new Frm_Session();

            session.TopLevel = false;

            Panel_Frm.Controls.Add(session);

            session.Show();
        }

        private void تسجيلالطلابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel_Frm.Controls.Clear();

            Frm_Registration register = new Frm_Registration();

            register.TopLevel = false;

            Panel_Frm.Controls.Add(register);

            register.Show();
        }

        private void إدارةالمدفوعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel_Frm.Controls.Clear();

            Frm_Bill bill = new Frm_Bill();

            bill.TopLevel = false;

            Panel_Frm.Controls.Add(bill);

            bill.Show();
        }

        private void المدفوعاتالسابقةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel_Frm.Controls.Clear();

            Frm_OldBills oldbill = new Frm_OldBills();

            oldbill.TopLevel = false;

            Panel_Frm.Controls.Add(oldbill);

            oldbill.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Frm_Bill.CheckofOldBill != 0)
            {
                المدفوعاتالسابقةToolStripMenuItem.Enabled = true;
               

            }
            else
            {
                المدفوعاتالسابقةToolStripMenuItem.Enabled = false;
            }
        }
    }
}
