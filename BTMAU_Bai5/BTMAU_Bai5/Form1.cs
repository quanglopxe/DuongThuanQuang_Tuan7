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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Right_Click(object sender, EventArgs e)
        {
            if(listBoxLeft.SelectedIndex>=0)
            {
                listBoxRight.Items.Add(listBoxLeft.SelectedItem);
                listBoxLeft.Items.Remove(listBoxLeft.SelectedItem);
            }
        }
        private void btn_Right_All_Click(object sender, EventArgs e)
        {
            listBoxRight.Items.AddRange(listBoxLeft.Items);
            listBoxLeft.Items.Clear();
        }
        private void btn_Left_Click(object sender, EventArgs e)
        {
            if (listBoxRight.SelectedIndex >= 0)
            {
                listBoxLeft.Items.Add(listBoxRight.SelectedItem);
                listBoxRight.Items.Remove(listBoxRight.SelectedItem);
            }
        }
        private void btn_Left_All_Click(object sender, EventArgs e)
        {
            listBoxLeft.Items.AddRange(listBoxRight.Items);
            listBoxRight.Items.Clear();
        }

    }
}
