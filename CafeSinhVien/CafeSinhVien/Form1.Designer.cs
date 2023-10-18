namespace CafeSinhVien
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtTongKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkMC = new System.Windows.Forms.CheckBox();
            this.chkMXB = new System.Windows.Forms.CheckBox();
            this.chkMTT = new System.Windows.Forms.CheckBox();
            this.chkBMC = new System.Windows.Forms.CheckBox();
            this.chkBMT = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoCafeKem = new System.Windows.Forms.RadioButton();
            this.rdoCafeSuaDa = new System.Windows.Forms.RadioButton();
            this.rdoCafeSua = new System.Windows.Forms.RadioButton();
            this.rdoCafeDa = new System.Windows.Forms.RadioButton();
            this.rdoCafeDen = new System.Windows.Forms.RadioButton();
            this.chkSV = new System.Windows.Forms.CheckBox();
            this.txtSoKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongTT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTongKH
            // 
            this.txtTongKH.Enabled = false;
            this.txtTongKH.Location = new System.Drawing.Point(365, 453);
            this.txtTongKH.Name = "txtTongKH";
            this.txtTongKH.Size = new System.Drawing.Size(293, 30);
            this.txtTongKH.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(140, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tổng khách hàng";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(580, 374);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 42);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(427, 374);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(121, 42);
            this.btnThanhToan.TabIndex = 25;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(308, 374);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 42);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "Nhập lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(177, 374);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(95, 42);
            this.btnTinhTien.TabIndex = 23;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkMC);
            this.groupBox2.Controls.Add(this.chkMXB);
            this.groupBox2.Controls.Add(this.chkMTT);
            this.groupBox2.Controls.Add(this.chkBMC);
            this.groupBox2.Controls.Add(this.chkBMT);
            this.groupBox2.Location = new System.Drawing.Point(407, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 161);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thức ăn";
            // 
            // chkMC
            // 
            this.chkMC.AutoSize = true;
            this.chkMC.Location = new System.Drawing.Point(178, 69);
            this.chkMC.Name = "chkMC";
            this.chkMC.Size = new System.Drawing.Size(90, 27);
            this.chkMC.TabIndex = 12;
            this.chkMC.Text = "Mỳ cay";
            this.chkMC.UseVisualStyleBackColor = true;
            this.chkMC.CheckedChanged += new System.EventHandler(this.chkMC_CheckedChanged);
            // 
            // chkMXB
            // 
            this.chkMXB.AutoSize = true;
            this.chkMXB.Location = new System.Drawing.Point(178, 29);
            this.chkMXB.Name = "chkMXB";
            this.chkMXB.Size = new System.Drawing.Size(118, 27);
            this.chkMXB.TabIndex = 11;
            this.chkMXB.Text = "Mỳ xào bò";
            this.chkMXB.UseVisualStyleBackColor = true;
            this.chkMXB.CheckedChanged += new System.EventHandler(this.chkMXB_CheckedChanged);
            // 
            // chkMTT
            // 
            this.chkMTT.AutoSize = true;
            this.chkMTT.Location = new System.Drawing.Point(20, 115);
            this.chkMTT.Name = "chkMTT";
            this.chkMTT.Size = new System.Drawing.Size(147, 27);
            this.chkMTT.TabIndex = 10;
            this.chkMTT.Text = "Mỳ tôm trứng";
            this.chkMTT.UseVisualStyleBackColor = true;
            this.chkMTT.CheckedChanged += new System.EventHandler(this.chkMTT_CheckedChanged);
            // 
            // chkBMC
            // 
            this.chkBMC.AutoSize = true;
            this.chkBMC.Location = new System.Drawing.Point(20, 72);
            this.chkBMC.Name = "chkBMC";
            this.chkBMC.Size = new System.Drawing.Size(131, 27);
            this.chkBMC.TabIndex = 9;
            this.chkBMC.Text = "Bánh mỳ cá";
            this.chkBMC.UseVisualStyleBackColor = true;
            this.chkBMC.CheckedChanged += new System.EventHandler(this.chkBMC_CheckedChanged);
            // 
            // chkBMT
            // 
            this.chkBMT.AutoSize = true;
            this.chkBMT.Location = new System.Drawing.Point(20, 32);
            this.chkBMT.Name = "chkBMT";
            this.chkBMT.Size = new System.Drawing.Size(159, 27);
            this.chkBMT.TabIndex = 8;
            this.chkBMT.Text = "Bánh mỳ trứng";
            this.chkBMT.UseVisualStyleBackColor = true;
            this.chkBMT.CheckedChanged += new System.EventHandler(this.chkBMT_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoCafeKem);
            this.groupBox1.Controls.Add(this.rdoCafeSuaDa);
            this.groupBox1.Controls.Add(this.rdoCafeSua);
            this.groupBox1.Controls.Add(this.rdoCafeDa);
            this.groupBox1.Controls.Add(this.rdoCafeDen);
            this.groupBox1.Location = new System.Drawing.Point(130, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 161);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nước uống";
            // 
            // rdoCafeKem
            // 
            this.rdoCafeKem.AutoSize = true;
            this.rdoCafeKem.Location = new System.Drawing.Point(144, 72);
            this.rdoCafeKem.Name = "rdoCafeKem";
            this.rdoCafeKem.Size = new System.Drawing.Size(109, 27);
            this.rdoCafeKem.TabIndex = 4;
            this.rdoCafeKem.TabStop = true;
            this.rdoCafeKem.Text = "Cafe kem";
            this.rdoCafeKem.UseVisualStyleBackColor = true;
            // 
            // rdoCafeSuaDa
            // 
            this.rdoCafeSuaDa.AutoSize = true;
            this.rdoCafeSuaDa.Location = new System.Drawing.Point(14, 115);
            this.rdoCafeSuaDa.Name = "rdoCafeSuaDa";
            this.rdoCafeSuaDa.Size = new System.Drawing.Size(131, 27);
            this.rdoCafeSuaDa.TabIndex = 3;
            this.rdoCafeSuaDa.TabStop = true;
            this.rdoCafeSuaDa.Text = "Cafe sữa đá";
            this.rdoCafeSuaDa.UseVisualStyleBackColor = true;
            // 
            // rdoCafeSua
            // 
            this.rdoCafeSua.AutoSize = true;
            this.rdoCafeSua.Location = new System.Drawing.Point(14, 72);
            this.rdoCafeSua.Name = "rdoCafeSua";
            this.rdoCafeSua.Size = new System.Drawing.Size(104, 27);
            this.rdoCafeSua.TabIndex = 2;
            this.rdoCafeSua.TabStop = true;
            this.rdoCafeSua.Text = "Cafe sữa";
            this.rdoCafeSua.UseVisualStyleBackColor = true;
            // 
            // rdoCafeDa
            // 
            this.rdoCafeDa.AutoSize = true;
            this.rdoCafeDa.Location = new System.Drawing.Point(144, 31);
            this.rdoCafeDa.Name = "rdoCafeDa";
            this.rdoCafeDa.Size = new System.Drawing.Size(95, 27);
            this.rdoCafeDa.TabIndex = 1;
            this.rdoCafeDa.TabStop = true;
            this.rdoCafeDa.Text = "Cafe đá";
            this.rdoCafeDa.UseVisualStyleBackColor = true;
            // 
            // rdoCafeDen
            // 
            this.rdoCafeDen.AutoSize = true;
            this.rdoCafeDen.Location = new System.Drawing.Point(14, 31);
            this.rdoCafeDen.Name = "rdoCafeDen";
            this.rdoCafeDen.Size = new System.Drawing.Size(106, 27);
            this.rdoCafeDen.TabIndex = 0;
            this.rdoCafeDen.TabStop = true;
            this.rdoCafeDen.Text = "Cafe đen";
            this.rdoCafeDen.UseVisualStyleBackColor = true;
            // 
            // chkSV
            // 
            this.chkSV.AutoSize = true;
            this.chkSV.Location = new System.Drawing.Point(308, 135);
            this.chkSV.Name = "chkSV";
            this.chkSV.Size = new System.Drawing.Size(124, 27);
            this.chkSV.TabIndex = 20;
            this.chkSV.Text = "Sinh viên ?";
            this.chkSV.UseVisualStyleBackColor = true;
            // 
            // txtSoKH
            // 
            this.txtSoKH.Location = new System.Drawing.Point(308, 98);
            this.txtSoKH.Name = "txtSoKH";
            this.txtSoKH.Size = new System.Drawing.Size(350, 30);
            this.txtSoKH.TabIndex = 19;
            this.txtSoKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoKH_KeyPress);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(308, 62);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(350, 30);
            this.txtTenKH.TabIndex = 18;
            this.txtTenKH.Leave += new System.EventHandler(this.txtTenKH_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Số khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(293, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "CAFE SINH VIÊN";
            // 
            // txtTongTT
            // 
            this.txtTongTT.Enabled = false;
            this.txtTongTT.Location = new System.Drawing.Point(365, 489);
            this.txtTongTT.Name = "txtTongTT";
            this.txtTongTT.Size = new System.Drawing.Size(293, 30);
            this.txtTongTT.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Tổng tiền thanh toán";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 544);
            this.Controls.Add(this.txtTongTT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTongKH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkSV);
            this.Controls.Add(this.txtSoKH);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTongKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkMC;
        private System.Windows.Forms.CheckBox chkMXB;
        private System.Windows.Forms.CheckBox chkMTT;
        private System.Windows.Forms.CheckBox chkBMC;
        private System.Windows.Forms.CheckBox chkBMT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoCafeKem;
        private System.Windows.Forms.RadioButton rdoCafeSuaDa;
        private System.Windows.Forms.RadioButton rdoCafeSua;
        private System.Windows.Forms.RadioButton rdoCafeDa;
        private System.Windows.Forms.RadioButton rdoCafeDen;
        private System.Windows.Forms.CheckBox chkSV;
        private System.Windows.Forms.TextBox txtSoKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongTT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

