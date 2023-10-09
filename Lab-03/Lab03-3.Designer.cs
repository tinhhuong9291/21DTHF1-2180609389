
namespace Lab_03
{
    partial class Lab03_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab03_3));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblAdd = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblFindName = new System.Windows.Forms.ToolStripLabel();
            this.txt_TimKiem = new System.Windows.Forms.ToolStripTextBox();
            this.dgv_StudenInfo = new System.Windows.Forms.DataGridView();
            this.lbl_TongNam = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_TongNu = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgv_STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_AverageScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudenInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripSystem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripSystem
            // 
            this.ToolStripSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.ToolStripSystem.Name = "ToolStripSystem";
            this.ToolStripSystem.Size = new System.Drawing.Size(77, 20);
            this.ToolStripSystem.Text = "Chức năng";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblAdd,
            this.toolStripSeparator2,
            this.toolStripSeparator1,
            this.lblFindName,
            this.txt_TimKiem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblAdd
            // 
            this.lblAdd.Image = ((System.Drawing.Image)(resources.GetObject("lblAdd.Image")));
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(77, 22);
            this.lblAdd.Text = "Thêm mới";
            this.lblAdd.Click += new System.EventHandler(this.lblAdd_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lblFindName
            // 
            this.lblFindName.Name = "lblFindName";
            this.lblFindName.Size = new System.Drawing.Size(103, 22);
            this.lblFindName.Text = "Tìm kiếm theo tên";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(100, 25);
            // 
            // dgv_StudenInfo
            // 
            this.dgv_StudenInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_StudenInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StudenInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_STT,
            this.dgv_StudentID,
            this.dgv_Fullname,
            this.dgv_Gender,
            this.dgv_Email,
            this.dgv_Faculty,
            this.dgv_AverageScore});
            this.dgv_StudenInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_StudenInfo.Enabled = false;
            this.dgv_StudenInfo.Location = new System.Drawing.Point(0, 49);
            this.dgv_StudenInfo.Name = "dgv_StudenInfo";
            this.dgv_StudenInfo.Size = new System.Drawing.Size(800, 401);
            this.dgv_StudenInfo.TabIndex = 3;
            this.dgv_StudenInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_StudenInfo_CellContentClick);
            // 
            // lbl_TongNam
            // 
            this.lbl_TongNam.AutoSize = true;
            this.lbl_TongNam.Location = new System.Drawing.Point(363, 30);
            this.lbl_TongNam.Name = "lbl_TongNam";
            this.lbl_TongNam.Size = new System.Drawing.Size(55, 13);
            this.lbl_TongNam.TabIndex = 4;
            this.lbl_TongNam.Text = "Tổng nam";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(424, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "0";
            // 
            // lbl_TongNu
            // 
            this.lbl_TongNu.AutoSize = true;
            this.lbl_TongNu.Location = new System.Drawing.Point(589, 30);
            this.lbl_TongNu.Name = "lbl_TongNu";
            this.lbl_TongNu.Size = new System.Drawing.Size(47, 13);
            this.lbl_TongNu.TabIndex = 4;
            this.lbl_TongNu.Text = "Tổng nữ";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(650, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "0";
            // 
            // dgv_STT
            // 
            this.dgv_STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgv_STT.HeaderText = "STT";
            this.dgv_STT.Name = "dgv_STT";
            this.dgv_STT.Width = 53;
            // 
            // dgv_StudentID
            // 
            this.dgv_StudentID.HeaderText = "MSSV";
            this.dgv_StudentID.Name = "dgv_StudentID";
            // 
            // dgv_Fullname
            // 
            this.dgv_Fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_Fullname.HeaderText = "Họ tên";
            this.dgv_Fullname.Name = "dgv_Fullname";
            // 
            // dgv_Gender
            // 
            this.dgv_Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgv_Gender.HeaderText = "Giới tính";
            this.dgv_Gender.Name = "dgv_Gender";
            this.dgv_Gender.Width = 72;
            // 
            // dgv_Email
            // 
            this.dgv_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_Email.HeaderText = "Email";
            this.dgv_Email.Name = "dgv_Email";
            // 
            // dgv_Faculty
            // 
            this.dgv_Faculty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_Faculty.HeaderText = "Ngành";
            this.dgv_Faculty.Name = "dgv_Faculty";
            // 
            // dgv_AverageScore
            // 
            this.dgv_AverageScore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgv_AverageScore.HeaderText = "Điểm TB";
            this.dgv_AverageScore.Name = "dgv_AverageScore";
            this.dgv_AverageScore.Width = 73;
            // 
            // Lab03_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_TongNu);
            this.Controls.Add(this.lbl_TongNam);
            this.Controls.Add(this.dgv_StudenInfo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Lab03_3";
            this.Text = "Lab03_3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudenInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripSystem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblAdd;
        private System.Windows.Forms.ToolStripLabel lblFindName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dgv_StudenInfo;
        private System.Windows.Forms.Label lbl_TongNam;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_TongNu;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripTextBox txt_TimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Faculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_AverageScore;
    }
}