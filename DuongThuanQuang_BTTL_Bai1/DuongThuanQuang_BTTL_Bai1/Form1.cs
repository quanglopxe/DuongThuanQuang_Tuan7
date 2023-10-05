using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuongThuanQuang_BTTL_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbtn_PT1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_PT1.Checked == true)
            {
                lb_c.Enabled = false;
                txt_c.Enabled = false;
            }
        }

        private void rbtn_PT2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_PT2.Checked == true)
            {
                lb_c.Enabled = true;
                txt_c.Enabled = true;
            }
        }

        private void txt_a_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (ctrl.Text.Length > 0 && string.IsNullOrEmpty(ctrl.Text) == true)
            {
                this.errorProvider1.SetError(ctrl, "Giá trị không được để trống!");
                ctrl.Focus();
            }
            else
                this.errorProvider1.Clear();
        }

        private void txt_b_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (ctrl.Text.Length > 0 && string.IsNullOrEmpty(ctrl.Text) == true)
            {
                this.errorProvider1.SetError(ctrl, "Giá trị không được để trống!");
                ctrl.Focus();
            }
            else
                this.errorProvider1.Clear();
        }

        private void txt_c_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (ctrl.Text.Length > 0 && string.IsNullOrEmpty(ctrl.Text) == true)
            {
                this.errorProvider1.SetError(ctrl, "Giá trị không được để trống!");
                ctrl.Focus();
            }
            else
                this.errorProvider1.Clear();
        }

        private void btn_Solve_Click(object sender, EventArgs e)
        {
            if(rbtn_PT1.Checked==true)
            {
                if(int.Parse(txt_a.Text) == 0)
                {
                    if (int.Parse(txt_b.Text) == 0)
                    {
                        txt_Result.Text = "Phương trình vô số nghiệm";
                    }
                    else
                        txt_Result.Text = "Phương trình vô nghiệm";
                }
                else
                {
                    float kq = -float.Parse(txt_b.Text) / float.Parse(txt_a.Text);
                    txt_Result.Text = "Phương trình có nghiệm là: " + kq.ToString();
                }
                    
            }
            if(rbtn_PT2.Checked==true)
            {
                if (int.Parse(txt_a.Text) == 0)
                {
                    if (int.Parse(txt_b.Text) == 0)
                    {
                        txt_Result.Text = "Phuong trinh vo nghiem!";
                    }
                    else
                    {
                        float kq2 = -float.Parse(txt_c.Text) / float.Parse(txt_b.Text);
                        txt_Result.Text ="Phuong trinh co mot nghiem: x = " + kq2.ToString();
                    }
                    return;
                }
                // tinh delta
                float delta = int.Parse(txt_b.Text) * int.Parse(txt_b.Text) - 4 * int.Parse(txt_a.Text) * int.Parse(txt_c.Text);
                float x1;
                float x2;
                // tinh nghiem
                if (delta > 0)
                {
                    x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                    x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                    Console.Write("Phuong trinh co 2 nghiem la: x1 = {0} va x2 = {1}", x1, x2);
                }
                else if (delta == 0)
                {
                    x1 = (-b / (2 * a));
                    Console.Write("Phong trinh co nghiem kep: x1 = x2 = {0}", x1);
                }
                else
                {
                    Console.Write("Phuong trinh vo nghiem!");
                }
            }
        }

       
    }
}
