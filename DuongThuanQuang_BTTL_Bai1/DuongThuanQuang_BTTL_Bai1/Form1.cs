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
            if (rbtn_PT1.Checked)
            {
                if (!string.IsNullOrEmpty(txt_a.Text) && !string.IsNullOrEmpty(txt_b.Text))
                    btn_Solve.Enabled = true;
                else
                    btn_Solve.Enabled = false;
            }
            else
            {
                if (!string.IsNullOrEmpty(txt_a.Text) && !string.IsNullOrEmpty(txt_b.Text) && !string.IsNullOrEmpty(txt_c.Text))
                    btn_Solve.Enabled = true;
                else
                    btn_Solve.Enabled = false;
            }
        }

        private void txt_b_TextChanged(object sender, EventArgs e)
        {
            if (rbtn_PT1.Checked)
            {
                if (!string.IsNullOrEmpty(txt_a.Text) && !string.IsNullOrEmpty(txt_b.Text))
                    btn_Solve.Enabled = true;
                else
                    btn_Solve.Enabled = false;
            }
            else
            {
                if (!string.IsNullOrEmpty(txt_a.Text) && !string.IsNullOrEmpty(txt_b.Text) && !string.IsNullOrEmpty(txt_c.Text))
                    btn_Solve.Enabled = true;
                else
                    btn_Solve.Enabled = false;
            }
        }

        private void txt_c_TextChanged(object sender, EventArgs e)
        {
            if (rbtn_PT1.Checked)
            {
                if (!string.IsNullOrEmpty(txt_a.Text) && !string.IsNullOrEmpty(txt_b.Text))
                    btn_Solve.Enabled = true;
                else
                    btn_Solve.Enabled = false;
            }
            else
            {
                if (!string.IsNullOrEmpty(txt_a.Text) && !string.IsNullOrEmpty(txt_b.Text) && !string.IsNullOrEmpty(txt_c.Text))
                    btn_Solve.Enabled = true;
                else
                    btn_Solve.Enabled = false;
            }
        }

        private void btn_Solve_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt_a.Text);
            int b = int.Parse(txt_b.Text);

            if(rbtn_PT1.Checked==true)
            {
                if(a == 0)
                {
                    if (b == 0)
                    {
                        txt_Result.Text = "Phương trình vô số nghiệm";
                    }
                    else
                        txt_Result.Text = "Phương trình vô nghiệm";
                }
                else
                {
                    double kq = 1.0*-b/a;
                    txt_Result.Text = "Phương trình có nghiệm là: " + kq.ToString();
                }
                    
            }
            if(rbtn_PT2.Checked==true)
            {
                int c = int.Parse(txt_c.Text);
                if (a == 0)
                {
                    if (b == 0)
                    {
                        txt_Result.Text = "Phuong trinh vo nghiem!";
                    }
                    else
                    {
                        double kq2 = 1.0 * c / b;
                        txt_Result.Text ="Phuong trinh co mot nghiem: x = " + kq2.ToString();
                    }
                    return;
                }
               
                double delta = 1.0*b * b - 4 * a * c;
                double x1;
                double x2;
                
                if (delta > 0)
                {
                    x1 = (double)((-b + Math.Sqrt(delta)) / (2 * a));
                    x2 = (double)((-b - Math.Sqrt(delta)) / (2 * a));
                    txt_Result.Text = "Phuong trinh co 2 nghiem la: x1 = " + x1.ToString() + "va x2 = " + x2.ToString();
                }
                else if (delta == 0)
                {
                    x1 = (-b / (2 * a));
                    txt_Result.Text ="Phong trinh co nghiem kep: x1 = x2 = " + x1.ToString();
                }
                else
                {
                    txt_Result.Text = "Phuong trinh vo nghiem!";
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

       
    }
}
