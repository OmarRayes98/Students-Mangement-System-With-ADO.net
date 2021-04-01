namespace Students_Mangement_System
{
    partial class Frm_Bill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.VisitsFrm = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Bill = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DTP_history = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.RText_Total = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RText_Paid = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RText_Rest = new System.Windows.Forms.RichTextBox();
            this.Com_NameS = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Symptoms = new System.Windows.Forms.Button();
            this.RText_Search = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.VisitsFrm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Bill)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // VisitsFrm
            // 
            this.VisitsFrm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VisitsFrm.Controls.Add(this.groupBox1);
            this.VisitsFrm.Font = new System.Drawing.Font("Arial", 9F);
            this.VisitsFrm.Location = new System.Drawing.Point(15, 15);
            this.VisitsFrm.Name = "VisitsFrm";
            this.VisitsFrm.Size = new System.Drawing.Size(1678, 684);
            this.VisitsFrm.TabIndex = 1;
            this.VisitsFrm.TabStop = false;
            this.VisitsFrm.Text = "معلومات الدفع  ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.6F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(6, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1666, 628);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اختيار طالب ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.63415F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.4486F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.26791F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.670732F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.90244F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DGV_Bill, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.DTP_history, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.RText_Total, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.RText_Paid, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.RText_Rest, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.Com_NameS, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 5, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.611503F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.777219F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.445787F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.06671F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.88039F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.21839F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1660, 602);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(1463, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "اختيار اسم الطالب :";
            // 
            // DGV_Bill
            // 
            this.DGV_Bill.AllowUserToAddRows = false;
            this.DGV_Bill.AllowUserToDeleteRows = false;
            this.DGV_Bill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Bill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Bill.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.DGV_Bill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.DGV_Bill, 5);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.6F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Bill.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Bill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Bill.Location = new System.Drawing.Point(3, 248);
            this.DGV_Bill.MultiSelect = false;
            this.DGV_Bill.Name = "DGV_Bill";
            this.DGV_Bill.ReadOnly = true;
            this.DGV_Bill.RowTemplate.Height = 29;
            this.DGV_Bill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Bill.Size = new System.Drawing.Size(1599, 274);
            this.DGV_Bill.TabIndex = 26;
            this.DGV_Bill.TabStop = false;
            this.DGV_Bill.DoubleClick += new System.EventHandler(this.DGV_Bill_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(720, 528);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 51);
            this.panel1.TabIndex = 27;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.Btn_Add, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_Delete, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_Reset, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(882, 51);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // Btn_Add
            // 
            this.Btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Btn_Add.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Add.ForeColor = System.Drawing.Color.White;
            this.Btn_Add.Location = new System.Drawing.Point(745, 5);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(134, 40);
            this.Btn_Add.TabIndex = 8;
            this.Btn_Add.Text = "إضافة";
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Btn_Delete.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Delete.ForeColor = System.Drawing.Color.White;
            this.Btn_Delete.Location = new System.Drawing.Point(490, 5);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(134, 40);
            this.Btn_Delete.TabIndex = 10;
            this.Btn_Delete.Text = "حذف";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btn_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Btn_Reset.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Reset.ForeColor = System.Drawing.Color.White;
            this.Btn_Reset.Location = new System.Drawing.Point(235, 5);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(134, 40);
            this.Btn_Reset.TabIndex = 11;
            this.Btn_Reset.Text = "جديد";
            this.Btn_Reset.UseVisualStyleBackColor = false;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(1509, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "تاريخ الدفع :";
            // 
            // DTP_history
            // 
            this.DTP_history.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DTP_history.Checked = false;
            this.DTP_history.CustomFormat = "";
            this.DTP_history.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_history.Location = new System.Drawing.Point(1418, 200);
            this.DTP_history.Name = "DTP_history";
            this.DTP_history.Size = new System.Drawing.Size(184, 27);
            this.DTP_history.TabIndex = 34;
            this.DTP_history.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.Location = new System.Drawing.Point(1106, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "المبلغ الكامل :";
            // 
            // RText_Total
            // 
            this.RText_Total.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RText_Total.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RText_Total.Location = new System.Drawing.Point(1020, 87);
            this.RText_Total.Name = "RText_Total";
            this.RText_Total.ReadOnly = true;
            this.RText_Total.Size = new System.Drawing.Size(187, 31);
            this.RText_Total.TabIndex = 5;
            this.RText_Total.Text = "";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.Location = new System.Drawing.Point(1097, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "المبلغ المدفوع :";
            // 
            // RText_Paid
            // 
            this.RText_Paid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RText_Paid.BackColor = System.Drawing.Color.AliceBlue;
            this.RText_Paid.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RText_Paid.Location = new System.Drawing.Point(1020, 198);
            this.RText_Paid.Name = "RText_Paid";
            this.RText_Paid.Size = new System.Drawing.Size(187, 31);
            this.RText_Paid.TabIndex = 6;
            this.RText_Paid.Text = "";
            this.RText_Paid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RText_Paid_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(880, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "الباقي : ";
            // 
            // RText_Rest
            // 
            this.RText_Rest.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RText_Rest.BackColor = System.Drawing.Color.AliceBlue;
            this.RText_Rest.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RText_Rest.Location = new System.Drawing.Point(756, 198);
            this.RText_Rest.Name = "RText_Rest";
            this.RText_Rest.ReadOnly = true;
            this.RText_Rest.Size = new System.Drawing.Size(187, 31);
            this.RText_Rest.TabIndex = 7;
            this.RText_Rest.TabStop = false;
            this.RText_Rest.Text = "";
            this.RText_Rest.Click += new System.EventHandler(this.RText_Rest_Click);
            this.RText_Rest.TextChanged += new System.EventHandler(this.RText_Rest_TextChanged);
            // 
            // Com_NameS
            // 
            this.Com_NameS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Com_NameS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Com_NameS.Font = new System.Drawing.Font("Arial", 9F);
            this.Com_NameS.ForeColor = System.Drawing.Color.Black;
            this.Com_NameS.FormattingEnabled = true;
            this.Com_NameS.Location = new System.Drawing.Point(1272, 88);
            this.Com_NameS.MaxDropDownItems = 5;
            this.Com_NameS.Name = "Com_NameS";
            this.Com_NameS.Size = new System.Drawing.Size(330, 29);
            this.Com_NameS.TabIndex = 325;
            this.Com_NameS.SelectedIndexChanged += new System.EventHandler(this.Com_NameS_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.Btn_Symptoms);
            this.groupBox2.Controls.Add(this.RText_Search);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(243, 25);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox2, 4);
            this.groupBox2.Size = new System.Drawing.Size(380, 208);
            this.groupBox2.TabIndex = 326;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "عملية البحث";
            // 
            // Btn_Symptoms
            // 
            this.Btn_Symptoms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Symptoms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Btn_Symptoms.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Symptoms.ForeColor = System.Drawing.Color.White;
            this.Btn_Symptoms.Location = new System.Drawing.Point(248, 151);
            this.Btn_Symptoms.Name = "Btn_Symptoms";
            this.Btn_Symptoms.Size = new System.Drawing.Size(110, 40);
            this.Btn_Symptoms.TabIndex = 7;
            this.Btn_Symptoms.Text = "بحث";
            this.Btn_Symptoms.UseVisualStyleBackColor = false;
            this.Btn_Symptoms.Click += new System.EventHandler(this.Btn_Symptoms_Click);
            // 
            // RText_Search
            // 
            this.RText_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RText_Search.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RText_Search.Location = new System.Drawing.Point(73, 78);
            this.RText_Search.Name = "RText_Search";
            this.RText_Search.Size = new System.Drawing.Size(285, 32);
            this.RText_Search.TabIndex = 6;
            this.RText_Search.Text = "";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F);
            this.label10.Location = new System.Drawing.Point(93, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(269, 23);
            this.label10.TabIndex = 3;
            this.label10.Text = "البحث حسب اسم الطالب أو تاريخ الدفع:";
            // 
            // Frm_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1709, 714);
            this.Controls.Add(this.VisitsFrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Bill";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "إدارة المدفوعات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Bill_Load);
            this.SizeChanged += new System.EventHandler(this.Frm_Bill_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Bill_KeyDown);
            this.Leave += new System.EventHandler(this.Frm_Bill_Leave);
            this.VisitsFrm.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Bill)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox VisitsFrm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox RText_Total;
        private System.Windows.Forms.DataGridView DGV_Bill;
        private System.Windows.Forms.RichTextBox RText_Rest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox RText_Paid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.DateTimePicker DTP_history;
        public System.Windows.Forms.ComboBox Com_NameS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Symptoms;
        private System.Windows.Forms.RichTextBox RText_Search;
        private System.Windows.Forms.Label label10;
    }
}