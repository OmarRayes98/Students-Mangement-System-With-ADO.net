using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace Students_Mangement_System
{
    public partial class Frm_Setting : Form
    {
        public Frm_Setting()
        {
            InitializeComponent();
        }

        private void Frm_Setting_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                RText_Name.ResetText();
                RText_Number.ResetText();
                RText_Email.ResetText();
            }
        }
        public void OnlyNumber(KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0': case '1':case '2': case '3': case '4': case '5':  case '6':case '7': case '8':case '9': case (char)Keys.Back: case (char)Keys.Space: case (char)Keys.Enter: case ('+'):
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        public void OnlyLetters(KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {   case '0':     case '1': case '2': case '3':case '4': case '5': case '6':  case '7':  case '8':  case '9':
                    e.Handled = true;
                    break;
                default:
                    e.Handled = false;
                    break;
            }
        }

        private void Frm_Setting_SizeChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void Btn_SaveSetting_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(RText_Name.Text) || string.IsNullOrEmpty(RText_Number.Text) || string.IsNullOrEmpty(RText_Email.Text))
            {
                MessageBox.Show("الرجاء إكمال المعلومات المطلوبة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
               Students_Mangement_System.Properties.Settings.Default.Name = RText_Name.Text;
               Students_Mangement_System.Properties.Settings.Default.Number = Convert.ToInt32(RText_Number.Text);
               Students_Mangement_System.Properties.Settings.Default.Email = RText_Email.Text.ToString();

                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();


                RText_Email.ResetText();
                RText_Name.ResetText();
                RText_Number.ResetText();

                if (MessageBox.Show(" هل تريد إعادة تشغيل البرنامج الأن أو لاحقا \n  لحفظ الإعدادات ؟ ", " تحذير ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
        }

        private void Btn_LoadSetting_Click(object sender, EventArgs e)
        {
            RText_Name.Text = Students_Mangement_System.Properties.Settings.Default.Name;
            RText_Number.Text = Students_Mangement_System.Properties.Settings.Default.Number.ToString();
            RText_Email.Text = Students_Mangement_System.Properties.Settings.Default.Email.ToString();
        }

        private void RText_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber(e);
        }
    }
}
