namespace Students_Mangement_System
{
    partial class Frm_StudentsClass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DGV_InfoStudent = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InfoStudent)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.DGV_InfoStudent, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.63685F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.431127F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.11092F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(976, 559);
            this.tableLayoutPanel3.TabIndex = 44;
            // 
            // DGV_InfoStudent
            // 
            this.DGV_InfoStudent.AllowUserToAddRows = false;
            this.DGV_InfoStudent.AllowUserToDeleteRows = false;
            this.DGV_InfoStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_InfoStudent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_InfoStudent.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.DGV_InfoStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_InfoStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel3.SetColumnSpan(this.DGV_InfoStudent, 2);
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 8.6F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_InfoStudent.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_InfoStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_InfoStudent.Location = new System.Drawing.Point(3, 102);
            this.DGV_InfoStudent.MultiSelect = false;
            this.DGV_InfoStudent.Name = "DGV_InfoStudent";
            this.DGV_InfoStudent.ReadOnly = true;
            this.DGV_InfoStudent.RowTemplate.Height = 29;
            this.DGV_InfoStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_InfoStudent.Size = new System.Drawing.Size(970, 454);
            this.DGV_InfoStudent.TabIndex = 31;
            this.DGV_InfoStudent.TabStop = false;
            // 
            // panel3
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.panel3, 2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.tableLayoutPanel3.SetRowSpan(this.panel3, 2);
            this.panel3.Size = new System.Drawing.Size(970, 93);
            this.panel3.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(784, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "طلاب الصف ";
            // 
            // Frm_StudentsClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(976, 559);
            this.Controls.Add(this.tableLayoutPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Frm_StudentsClass";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "طلاب الصف";
            this.Load += new System.EventHandler(this.Frm_StudentsClass_Load);
            this.SizeChanged += new System.EventHandler(this.Frm_StudentsClass_SizeChanged);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InfoStudent)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView DGV_InfoStudent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;

    }
}