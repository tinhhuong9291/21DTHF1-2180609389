
namespace Lab_03
{
    partial class StudentInfo
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
            this.lbl_StudentID = new System.Windows.Forms.Label();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.cmb_Faculty = new System.Windows.Forms.ComboBox();
            this.lbl_Fullname = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Faculty = new System.Windows.Forms.Label();
            this.lbl_AverageScore = new System.Windows.Forms.Label();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_AverageScore = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_StudentID
            // 
            this.lbl_StudentID.AutoSize = true;
            this.lbl_StudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StudentID.Location = new System.Drawing.Point(127, 41);
            this.lbl_StudentID.Name = "lbl_StudentID";
            this.lbl_StudentID.Size = new System.Drawing.Size(55, 20);
            this.lbl_StudentID.TabIndex = 0;
            this.lbl_StudentID.Text = "MSSV";
            this.lbl_StudentID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Male.Location = new System.Drawing.Point(314, 148);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(60, 24);
            this.rb_Male.TabIndex = 2;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Nam";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(285, 35);
            this.txtStudentID.MaxLength = 10;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(243, 26);
            this.txtStudentID.TabIndex = 3;
            this.txtStudentID.TextChanged += new System.EventHandler(this.StudentInfo_Load);
            this.txtStudentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentID_KeyPress);
            // 
            // cmb_Faculty
            // 
            this.cmb_Faculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Faculty.FormattingEnabled = true;
            this.cmb_Faculty.Items.AddRange(new object[] {
            "Quản trị kinh doanh",
            "Công nghệ thông tin",
            "Công nghệ oto",
            "ngôn ngữ Anh"});
            this.cmb_Faculty.Location = new System.Drawing.Point(285, 268);
            this.cmb_Faculty.Name = "cmb_Faculty";
            this.cmb_Faculty.Size = new System.Drawing.Size(243, 28);
            this.cmb_Faculty.TabIndex = 4;
            this.cmb_Faculty.SelectedIndexChanged += new System.EventHandler(this.cmb_Faculty_SelectedIndexChanged);
            // 
            // lbl_Fullname
            // 
            this.lbl_Fullname.AutoSize = true;
            this.lbl_Fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fullname.Location = new System.Drawing.Point(127, 95);
            this.lbl_Fullname.Name = "lbl_Fullname";
            this.lbl_Fullname.Size = new System.Drawing.Size(57, 20);
            this.lbl_Fullname.TabIndex = 0;
            this.lbl_Fullname.Text = "Họ tên";
            this.lbl_Fullname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Fullname.Click += new System.EventHandler(this.lbl_Fullname_Click);
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(127, 148);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(67, 20);
            this.lbl_Gender.TabIndex = 0;
            this.lbl_Gender.Text = "Giới tính";
            this.lbl_Gender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(127, 210);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(48, 20);
            this.lbl_Email.TabIndex = 0;
            this.lbl_Email.Text = "Email";
            this.lbl_Email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Faculty
            // 
            this.lbl_Faculty.AutoSize = true;
            this.lbl_Faculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Faculty.Location = new System.Drawing.Point(127, 271);
            this.lbl_Faculty.Name = "lbl_Faculty";
            this.lbl_Faculty.Size = new System.Drawing.Size(56, 20);
            this.lbl_Faculty.TabIndex = 0;
            this.lbl_Faculty.Text = "Ngành";
            this.lbl_Faculty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_AverageScore
            // 
            this.lbl_AverageScore.AutoSize = true;
            this.lbl_AverageScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AverageScore.Location = new System.Drawing.Point(127, 327);
            this.lbl_AverageScore.Name = "lbl_AverageScore";
            this.lbl_AverageScore.Size = new System.Drawing.Size(70, 20);
            this.lbl_AverageScore.TabIndex = 0;
            this.lbl_AverageScore.Text = "Điểm TB";
            this.lbl_AverageScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Female.Location = new System.Drawing.Point(415, 148);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(47, 24);
            this.rb_Female.TabIndex = 2;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Nữ";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // txtFullname
            // 
            this.txtFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullname.Location = new System.Drawing.Point(285, 95);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(243, 26);
            this.txtFullname.TabIndex = 3;
            this.txtFullname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFullname_KeyPress);
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(285, 210);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(243, 26);
            this.txt_Email.TabIndex = 3;
            // 
            // txt_AverageScore
            // 
            this.txt_AverageScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AverageScore.Location = new System.Drawing.Point(285, 321);
            this.txt_AverageScore.Name = "txt_AverageScore";
            this.txt_AverageScore.Size = new System.Drawing.Size(243, 26);
            this.txt_AverageScore.TabIndex = 3;
            this.txt_AverageScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AveraScore_KeyPress);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(285, 385);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 39);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(455, 385);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 39);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.cmb_Faculty);
            this.Controls.Add(this.txt_AverageScore);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.rb_Female);
            this.Controls.Add(this.rb_Male);
            this.Controls.Add(this.lbl_AverageScore);
            this.Controls.Add(this.lbl_Faculty);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Fullname);
            this.Controls.Add(this.lbl_StudentID);
            this.Name = "StudentInfo";
            this.Text = "StudentInfo";
            this.Load += new System.EventHandler(this.StudentInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_StudentID;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.ComboBox cmb_Faculty;
        private System.Windows.Forms.Label lbl_Fullname;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Faculty;
        private System.Windows.Forms.Label lbl_AverageScore;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_AverageScore;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Exit;
    }
}