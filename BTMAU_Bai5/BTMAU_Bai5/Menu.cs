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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_Bai1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 b1 = new Form1();
            b1.ShowDialog();
            this.Show();
        }

        private void btn_Bai2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 b2 = new Form2();
            b2.ShowDialog();
            this.Show();
        }

        private void btn_Bai3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 b3 = new Form3();
            b3.ShowDialog();
            this.Show();
        }
    }
}
