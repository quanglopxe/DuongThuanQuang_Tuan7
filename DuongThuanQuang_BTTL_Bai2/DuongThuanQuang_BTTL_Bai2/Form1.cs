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

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Result.Clear();
            txt_Array.Clear();
            txt_Add_Index.Clear();
            txt_Add_Value.Clear();
            txt_Delete_Index.Clear();
            txt_Delete_Value.Clear();
            txt_Max.Clear();
            txt_Min.Clear();
            txt_Replace_Index.Clear();
            txt_Replace_Value.Clear();
            txt_Search_Index.Clear();
            txt_Search_value.Clear();
            txt_Sum_Array.Clear();
            txt_Sum_Even.Clear();
            txt_Sum_Odd.Clear();
            txt_Value_Replace.Clear();
            txt_Value_Search.Clear();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_Do_Click(object sender, EventArgs e)
        {
            if (rbtn_Sort_Increase.Checked)
                Arr.Ascending_Sort();
            if (rbtn_Sort_Decrease.Checked)
                Arr.Descending_Sort();
            string resultText = string.Join(" ", Arr.A);
            txt_Result.Text = resultText;
        }


    }
}
