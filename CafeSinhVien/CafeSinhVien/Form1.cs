using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTenKH.Focus();
            btnTinhTien.Enabled = btnThanhToan.Enabled = btnReset.Enabled = false;
        }

        private void txtTenKH_Leave(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            string name = txtTenKH.Text;
            if(string.IsNullOrEmpty(name))
                this.errorProvider1.SetError(ctrl, "Vui lòng nhập tên!");
            else
                this.errorProvider1.Clear();
        }


        private void txtSoKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void chkBMT_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenKH.Text) && !string.IsNullOrEmpty(txtSoKH.Text))
            {
                if (rdoCafeDa.Checked || rdoCafeDen.Checked || rdoCafeKem.Checked || rdoCafeSua.Checked || rdoCafeSuaDa.Checked)
                {
                    if (chkBMT.Checked || chkMXB.Checked || chkBMC.Checked || chkMC.Checked || chkMTT.Checked)
                        btnTinhTien.Enabled = true;
                }
            }
        }

        private void chkMXB_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenKH.Text) && !string.IsNullOrEmpty(txtSoKH.Text))
            {
                if (rdoCafeDa.Checked || rdoCafeDen.Checked || rdoCafeKem.Checked || rdoCafeSua.Checked || rdoCafeSuaDa.Checked)
                {
                    if (chkBMT.Checked || chkMXB.Checked || chkBMC.Checked || chkMC.Checked || chkMTT.Checked)
                        btnTinhTien.Enabled = true;
                }
            }
        }

        private void chkBMC_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenKH.Text) && !string.IsNullOrEmpty(txtSoKH.Text))
            {
                if (rdoCafeDa.Checked || rdoCafeDen.Checked || rdoCafeKem.Checked || rdoCafeSua.Checked || rdoCafeSuaDa.Checked)
                {
                    if (chkBMT.Checked || chkMXB.Checked || chkBMC.Checked || chkMC.Checked || chkMTT.Checked)
                        btnTinhTien.Enabled = true;
                }
            }
        }

        private void chkMC_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenKH.Text) && !string.IsNullOrEmpty(txtSoKH.Text))
            {
                if (rdoCafeDa.Checked || rdoCafeDen.Checked || rdoCafeKem.Checked || rdoCafeSua.Checked || rdoCafeSuaDa.Checked)
                {
                    if (chkBMT.Checked || chkMXB.Checked || chkBMC.Checked || chkMC.Checked || chkMTT.Checked)
                        btnTinhTien.Enabled = true;
                }
            }
        }

        private void chkMTT_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenKH.Text) && !string.IsNullOrEmpty(txtSoKH.Text))
            {
                if (rdoCafeDa.Checked || rdoCafeDen.Checked || rdoCafeKem.Checked || rdoCafeSua.Checked || rdoCafeSuaDa.Checked)
                {
                    if (chkBMT.Checked || chkMXB.Checked || chkBMC.Checked || chkMC.Checked || chkMTT.Checked)
                        btnTinhTien.Enabled = true;
                }
            }
        }

        double TongTien = 0;
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            double giaNuoc = 0;
            double giaDoAn = 0;

            if (rdoCafeDen.Checked)
                giaNuoc = 20000;
            else if (rdoCafeDa.Checked || rdoCafeSua.Checked)
                giaNuoc = 25000;
            else if (rdoCafeSuaDa.Checked)
                giaNuoc = 30000;
            else if (rdoCafeKem.Checked)
                giaNuoc = 35000;

            if (chkBMT.Checked)
                giaDoAn += 15000;
            if (chkBMC.Checked)
                giaDoAn += 15000;
            if (chkMTT.Checked)
                giaDoAn += 20000;
            if (chkMXB.Checked)
                giaDoAn += 30000;
            if (chkMC.Checked)
                giaDoAn += 50000;
            TongTien = giaNuoc + giaDoAn;
            if (chkSV.Checked)
                TongTien = TongTien - (TongTien * 0.2);
            btnReset.Enabled = true;
            btnThanhToan.Enabled = true;
            MessageBox.Show("Tên khách hàng: " + txtTenKH.Text + "\nTổng tiền la: " + TongTien.ToString());
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            txtTongKH.Text = txtSoKH.Text;
            txtTongTT.Text = TongTien.ToString();
            btnThanhToan.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTenKH.Clear();
            txtSoKH.Clear();
            chkSV.Checked = false;
            btnTinhTien.Enabled = false;
            btnThanhToan.Enabled = false;
            btnReset.Enabled = false;
            txtTongKH.Clear();
            txtTongTT.Clear();
            rdoCafeDa.Checked = false;
            rdoCafeDen.Checked=false;
            rdoCafeKem.Checked = false;
            rdoCafeSua.Checked = false;
            rdoCafeSuaDa.Checked = false;
            chkBMC.Checked = false;
            chkBMT.Checked = false;
            chkMC.Checked = false;
            chkMTT.Checked = false;
            chkMXB.Checked = false;
            chkSV.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        
    }
}
