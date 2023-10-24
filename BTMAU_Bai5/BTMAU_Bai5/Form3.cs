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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string[] pb = { "Giám đốc", "Tổ chức hành chính", "Kế hoạch", "Kế toán" };
            foreach(var item in pb)
            {
                trv_Department.Nodes.Add(item);
                cbo_Department.Items.Add(item);
            }
            cbo_Department.SelectedIndex = 0;
        }
        private bool kiemtra(string s)
        {
            foreach(TreeNode item in trv_Department.Nodes)
            {
                if (String.Compare(item.Text, s, true) == 0)
                    return false;
            }
            return true;
        }

        private void btn_Add_Dept_Click(object sender, EventArgs e)
        {
            if (kiemtra(txt_Department.Text))
            {
                cbo_Department.Items.Add(txt_Department.Text);
                trv_Department.Nodes.Add(txt_Department.Text);
            }
            else
                MessageBox.Show("Tên phòng ban đã tồn tại!");
            txt_Department.Text = "";
            txt_Department.Focus();
        }

        private void btn_Delete_Dept_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                trv_Department.Nodes.Remove(trv_Department.SelectedNode);
                cbo_Department.Items.Remove(trv_Department.SelectedNode.Text);
            }
        }

        private void btn_Add_Emp_Click(object sender, EventArgs e)
        {
            int index = -1;
            foreach (TreeNode node in trv_Department.Nodes)
            {
                if (node.Text == cbo_Department.Text)
                {
                    index = node.Index;
                    break;
                }
            }
            trv_Department.Nodes[index].Nodes.Add(txt_Name.Text + " (" + txt_ID.Text + ")");
            trv_Department.ExpandAll();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
