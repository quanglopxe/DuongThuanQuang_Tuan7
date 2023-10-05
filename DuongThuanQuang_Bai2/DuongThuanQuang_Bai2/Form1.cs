using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuongThuanQuang_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbox_Regular_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_Regular.Checked == true)
                lb_Name.Font = new Font(lb_Name.Font, FontStyle.Regular);
        }

        private void cbox_Bold_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_Bold.Checked == true)
                lb_Name.Font = new Font(lb_Name.Font, FontStyle.Bold);
        }

        private void cbox_Italic_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_Italic.Checked == true)
                lb_Name.Font = new Font(lb_Name.Font, FontStyle.Italic);
            
        }

        private void cbox_Bold_Italic_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_Bold_Italic.Checked == true)
                lb_Name.Font = new Font(lb_Name.Font, (FontStyle)(FontStyle.Bold | FontStyle.Italic));
        }

        private void rbtn_Auto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_Auto.Checked == true)
                lb_Name.ForeColor = Color.Black;
        }

        private void rbtn_Red_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_Red.Checked == true)
                lb_Name.ForeColor = Color.Red;
        }

        private void rbtn_Green_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_Green.Checked == true)
                lb_Name.ForeColor = Color.Green;
        }

        private void rbtn_Blue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_Blue.Checked == true)
                lb_Name.ForeColor = Color.Blue;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo);
            if(r==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        

        
    }
}
