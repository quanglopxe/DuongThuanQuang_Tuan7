using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuongThuanQuang_BTTL_Bai2
{
    public partial class Form1 : Form
    {
        Mang1Chieu Arr;
        public Form1()
        {
            InitializeComponent();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_Array.Focus();
        }

        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            string[] stringArray = txt_Array.Text.Split(' ');
            Arr = new Mang1Chieu(stringArray.Length);
            for(int i = 0; i < stringArray.Length; i++)
            {
                Arr.A[i] = int.Parse(stringArray[i]);
            }
            string resultText = string.Join(" ", Arr.A);
            txt_Result.Text = resultText;
        }
    }
}
