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
            if (Arr.IsSorted())
            {
                lb_Error1.Visible = false;
                lb_Error2.Visible = false;
            }
            else
            {
                lb_Error1.Visible = true;
                lb_Error2.Visible = true;
            }
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
            rbtn_Add_Value.Checked = false;
            rbtn_Delete_Index.Checked = false;
            rbtn_Delete_Value.Checked = false;
            rbtn_Replace_Index.Checked = false;
            rbtn_Replace_Value.Checked = false;
            rbtn_Search_Index.Checked = false;
            rbtn_Search_Value.Checked = false;
            rbtn_Sort_Decrease.Checked = false;
            rbtn_Sort_Increase.Checked = false;
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
            if (Arr.IsSorted())
            {
                lb_Error1.Visible = false;
                lb_Error2.Visible = false;
            }
            else
            {
                lb_Error1.Visible = true;
                lb_Error2.Visible = true;
            }
            //---------------------------------------------------------------------------
            if(rbtn_Search_Value.Checked && !string.IsNullOrEmpty(txt_Search_value.Text))
            {
                int rs = int.Parse(txt_Search_value.Text);
                if (Arr.Search_Value(rs) != -1)
                    txt_Value_Search.Text = txt_Search_value.Text;
                else
                    MessageBox.Show("Không tìm thấy giá trị!");
            }
            if(rbtn_Search_Index.Checked && !string.IsNullOrEmpty(txt_Search_Index.Text))
            {
                int rs = int.Parse(txt_Search_Index.Text);
                if(Arr.Search_Index(rs)!=-1)
                    txt_Value_Search.Text = Arr.Search_Index(rs).ToString();
                else
                    MessageBox.Show("Không tìm thấy giá trị!");
            }
            //---------------------------------------------------------------------------
            try
            {
                if (rbtn_Delete_Value.Checked)
                    Arr.Delete_Value(int.Parse(txt_Delete_Value.Text));
                else if (rbtn_Delete_Index.Checked)
                    Arr.Delete_Index(int.Parse(txt_Delete_Index.Text));

            }
            catch
            {
                MessageBox.Show("Giá trị xóa không tồn tại");
            }

            try
            {
                if (rbtn_Replace_Value.Checked)
                    Arr.ReplaceValue(int.Parse(txt_Replace_Value.Text), int.Parse(txt_Value_Replace.Text));
                else if (rbtn_Replace_Index.Checked)
                    Arr.ReplaceValue(int.Parse(txt_Replace_Index.Text), int.Parse(txt_Value_Replace.Text));
            }
            catch
            {
                MessageBox.Show("Không tìm thấy giá trị thay thế!");
            }
            string resultText = string.Join(" ", Arr.A);
            txt_Result.Text = resultText;

        }
        private void btnSum_Click(object sender, EventArgs e)
        {
            string inputText = txt_Array.Text;
            string[] stringArray = inputText.Split(' ');
            Mang1Chieu Arr = new Mang1Chieu(stringArray.Length);
            try
            {
                for (int i = 0; i < stringArray.Length; i++)
                {
                    Arr.A[i] = int.Parse(stringArray[i]);
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập mảng trước khi thực hiện!");
            }
            int tong = Arr.TongMang();
            int tongChan = Arr.TongChan();
            int tongLe = Arr.TongLe();
            txt_Sum_Array.Text = tong.ToString();
            txt_Sum_Even.Text = tongChan.ToString();
            txt_Sum_Odd.Text = tongLe.ToString();
        }

        private void btn_Max_Min_Click(object sender, EventArgs e)
        {
            string inputText = txt_Array.Text;
            string[] stringArray = inputText.Split(' ');
            Mang1Chieu Arr = new Mang1Chieu(stringArray.Length);
            try
            {
                for (int i = 0; i < stringArray.Length; i++)
                {
                    Arr.A[i] = int.Parse(stringArray[i]);
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập mảng trước khi thực hiện!");
            }
            int max = Arr.TimMax();
            int min = Arr.TimMin();
            txt_Max.Text = max.ToString();
            txt_Min.Text = min.ToString();
        }

        

    }
}
