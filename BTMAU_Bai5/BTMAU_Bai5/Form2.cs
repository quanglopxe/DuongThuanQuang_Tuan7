using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTMAU_Bai5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            string[] nation = { "Kinh", "Hoa", "K'Me", "H'Mong", "Khác" };
            foreach(string s in nation)
            {
                cbo_Select_Nation.Items.Add(s);
            }
        }

        private void cbo_Select_Nation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbo_Select_Nation.SelectedIndex>=0)
            {
                MessageBox.Show("Bạn vừa chọn dân tộc: " + cbo_Select_Nation.SelectedItem);
            }
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            if (cbo_Select_Nation.SelectedIndex >= 0)
                lb_Result.Text = "Bạn vừa chọn dân tộc: " + cbo_Select_Nation.SelectedItem;
            else
                lb_Result.Text = "Bạn chưa chọn dân tộc!";
        }  
    }
}
