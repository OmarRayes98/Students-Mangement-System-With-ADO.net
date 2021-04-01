namespace Students_Mangement_System
{
    partial class Frm_Additems
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RText_Items = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Btn_Add_Item = new System.Windows.Forms.Button();
            this.Btn_Delete_item = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 226F));
            this.tableLayoutPanel1.Controls.Add(this.RText_Items, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Add_Item, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Delete_item, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.28205F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.71795F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(563, 192);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // RText_Items
            // 
            this.RText_Items.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.RText_Items, 2);
            this.RText_Items.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RText_Items.Location = new System.Drawing.Point(262, 56);
            this.RText_Items.Multiline = false;
            this.RText_Items.Name = "RText_Items";
            this.RText_Items.Size = new System.Drawing.Size(277, 33);
            this.RText_Items.TabIndex = 10;
            this.RText_Items.Text = "";
            this.RText_Items.TextChanged += new System.EventHandler(this.RText_Items_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(6, 35);
            this.listBox1.Name = "listBox1";
            this.tableLayoutPanel1.SetRowSpan(this.listBox1, 2);
            this.listBox1.Size = new System.Drawing.Size(217, 137);
            this.listBox1.TabIndex = 0;
            // 
            // Btn_Add_Item
            // 
            this.Btn_Add_Item.AutoSize = true;
            this.Btn_Add_Item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Btn_Add_Item.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Add_Item.ForeColor = System.Drawing.Color.White;
            this.Btn_Add_Item.Location = new System.Drawing.Point(463, 117);
            this.Btn_Add_Item.Name = "Btn_Add_Item";
            this.Btn_Add_Item.Size = new System.Drawing.Size(76, 39);
            this.Btn_Add_Item.TabIndex = 10;
            this.Btn_Add_Item.Text = "إضافة";
            this.Btn_Add_Item.UseVisualStyleBackColor = false;
            this.Btn_Add_Item.Click += new System.EventHandler(this.Btn_Add_Item_Click);
            // 
            // Btn_Delete_item
            // 
            this.Btn_Delete_item.AutoSize = true;
            this.Btn_Delete_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Btn_Delete_item.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Delete_item.ForeColor = System.Drawing.Color.White;
            this.Btn_Delete_item.Location = new System.Drawing.Point(353, 117);
            this.Btn_Delete_item.Name = "Btn_Delete_item";
            this.Btn_Delete_item.Size = new System.Drawing.Size(76, 39);
            this.Btn_Delete_item.TabIndex = 10;
            this.Btn_Delete_item.Text = "حذف";
            this.Btn_Delete_item.UseVisualStyleBackColor = false;
            this.Btn_Delete_item.Click += new System.EventHandler(this.Btn_Delete_item_Click);
            // 
            // Frm_Additems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(563, 192);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Additems";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة اختصاص";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Additems_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Additems_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Additems_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Btn_Delete_item;
        private System.Windows.Forms.Button Btn_Add_Item;
        private System.Windows.Forms.RichTextBox RText_Items;
        public System.Windows.Forms.ListBox listBox1;
    }
}