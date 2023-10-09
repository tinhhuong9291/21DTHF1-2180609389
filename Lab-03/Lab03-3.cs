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
    public partial class Lab03_3 : Form
    {
        public Lab03_3()
        {
            InitializeComponent();
        }


        private void PassData(object sender)
        {

            dgv_Fullname.HeaderText = ((TextBox)sender).Text;
            dgv_Gender.HeaderText = ((TextBox)sender).Text;
            dgv_Email.HeaderText = ((TextBox)sender).Text;
            dgv_Faculty.HeaderText = ((TextBox)sender).Text;
            dgv_AverageScore.HeaderText = ((TextBox)sender).Text;
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            StudentInfo frm = new StudentInfo();
            frm.Show();
        }

        

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Thoát chương trình ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                Application.Exit();
        }



        private void dgv_StudenInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
