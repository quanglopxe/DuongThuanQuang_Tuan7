using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuongThuanQuang
{
    public partial class Form1 : Form
    {
        List<SinhVien> dssv = new List<SinhVien>();
        public Form1()
        {
            InitializeComponent();
            SinhVien sv1 = new SinhVien("Nguyen Van A");
            SinhVien sv2 = new SinhVien("Nguyen Van B");
            SinhVien sv3 = new SinhVien("Nguyen Van C");
            SinhVien sv4 = new SinhVien("Nguyen Van D");

            dssv.Add(sv1);
            dssv.Add(sv2);
            dssv.Add(sv3);
            dssv.Add(sv4);
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (string.IsNullOrEmpty(txt_Name.Text) == true && Char.IsDigit(txt_Name.Text, 0) == true)
                this.errorProvider1.SetError(ctrl, "giá trị không hợp lệ");
            else
                this.errorProvider1.Clear();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            
            foreach(var sv in dssv)
            {
                if (string.Compare(txt_Name.Text, sv.Name, false) == 0)
                {
                    MessageBox.Show(sv.Name);
                }
            }
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            foreach(var SV in dssv)
            {
                if (string.Compare(txt_Name.Text, SV.Name, false) == 0)
                {
                    MessageBox.Show("Tên đã tồn tại!");
                    txt_Name.Focus();
                    break;
                }
                else
                {
                    SinhVien newSV = new SinhVien(txt_Name.Text);
                    dssv.Add(newSV);
                    MessageBox.Show("Đã thêm sv");
                    break;
                }
            }
            
        }

    }
}
