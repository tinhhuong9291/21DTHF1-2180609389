using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_03
{
    public partial class StudentInfo : Form
    {

        public delegate void PassControl(object sender);

        // Create instance (null)
        public PassControl passControl;
        public StudentInfo()
        {
            InitializeComponent();
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            cmb_Faculty.SelectedIndex = 1;
            rb_Female.Checked = true;
        }

        private void txtStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("MSSV chi dc phep nhap moi so", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtFullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            { 
                e.Handled = true;
                MessageBox.Show("Ten chi duoc phep nhap moi chu", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_AveraScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("DTB chi dc phep nhap moi so", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Huy nhap thong tin sinh vien ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtStudentID.Text == "" || txtFullname.Text == "" || txt_AverageScore.Text == "" || txt_Email.Text == "")
                    throw new Exception("Vui lòng nhập đủ thông tin !");
                if (txtStudentID.TextLength < 10)
                    throw new Exception("MSSV phai du 10 so");
                if ((int.Parse(txt_AverageScore.Text) > 10) || (int.Parse(txt_AverageScore.Text) < 0))
                    throw new Exception("DTB khong hop le");
                if (!(txtFullname.TextLength > 3 && txtFullname.TextLength < 100))
                    throw new Exception("Ten qua dai hoac qua ngan");
                if(!txt_Email.Text.Contains("@gmail.com"))
                    throw new Exception("Sai dinh dang email");

                if (passControl != null)
                    {
                        passControl(txtStudentID);
                        passControl(txtFullname);
                        //passControl(txt_Email);
                        //if (rb_Female.Checked == true)
                        //    passControl(rb_Female);
                        //else passControl(rb_Male);
                        //passControl(cmb_Faculty);
                        //passControl(txt_AverageScore);
                    }
                    this.Hide();
                    MessageBox.Show("Thêm dữ liệu mới thành công", "Thông báo", MessageBoxButtons.OK);
                //else
                //{
                //   InsertUpdate(selectedRow);
                //    MessageBox.Show("Cập nhật thành công", "thông báo", MessageBoxButtons.OK);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void lbl_Fullname_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
