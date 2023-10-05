namespace DuongThuanQuang_Bai2
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
            this.lb_Name = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbox_Bold_Italic = new System.Windows.Forms.CheckBox();
            this.cbox_Italic = new System.Windows.Forms.CheckBox();
            this.cbox_Bold = new System.Windows.Forms.CheckBox();
            this.cbox_Regular = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtn_Blue = new System.Windows.Forms.RadioButton();
            this.rbtn_Green = new System.Windows.Forms.RadioButton();
            this.rbtn_Red = new System.Windows.Forms.RadioButton();
            this.rbtn_Auto = new System.Windows.Forms.RadioButton();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Name
            // 
            this.lb_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Name.Location = new System.Drawing.Point(150, 9);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(313, 107);
            this.lb_Name.TabIndex = 0;
            this.lb_Name.Text = "TRƯỜNG ĐẠI HỌC CÔNG THƯƠNG TPHCM KHOA CÔNG NGHỆ THÔNG TIN";
            this.lb_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbox_Bold_Italic);
            this.groupBox2.Controls.Add(this.cbox_Italic);
            this.groupBox2.Controls.Add(this.cbox_Bold);
            this.groupBox2.Controls.Add(this.cbox_Regular);
            this.groupBox2.Location = new System.Drawing.Point(85, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 241);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font Style";
            // 
            // cbox_Bold_Italic
            // 
            this.cbox_Bold_Italic.AutoSize = true;
            this.cbox_Bold_Italic.Location = new System.Drawing.Point(31, 167);
            this.cbox_Bold_Italic.Name = "cbox_Bold_Italic";
            this.cbox_Bold_Italic.Size = new System.Drawing.Size(118, 22);
            this.cbox_Bold_Italic.TabIndex = 0;
            this.cbox_Bold_Italic.Text = "Bold and Italic";
            this.cbox_Bold_Italic.UseVisualStyleBackColor = true;
            this.cbox_Bold_Italic.CheckedChanged += new System.EventHandler(this.cbox_Bold_Italic_CheckedChanged);
            // 
            // cbox_Italic
            // 
            this.cbox_Italic.AutoSize = true;
            this.cbox_Italic.Location = new System.Drawing.Point(31, 122);
            this.cbox_Italic.Name = "cbox_Italic";
            this.cbox_Italic.Size = new System.Drawing.Size(57, 22);
            this.cbox_Italic.TabIndex = 0;
            this.cbox_Italic.Text = "Italic";
            this.cbox_Italic.UseVisualStyleBackColor = true;
            this.cbox_Italic.CheckedChanged += new System.EventHandler(this.cbox_Italic_CheckedChanged);
            // 
            // cbox_Bold
            // 
            this.cbox_Bold.AutoSize = true;
            this.cbox_Bold.Location = new System.Drawing.Point(31, 78);
            this.cbox_Bold.Name = "cbox_Bold";
            this.cbox_Bold.Size = new System.Drawing.Size(54, 22);
            this.cbox_Bold.TabIndex = 0;
            this.cbox_Bold.Text = "Bold";
            this.cbox_Bold.UseVisualStyleBackColor = true;
            this.cbox_Bold.CheckedChanged += new System.EventHandler(this.cbox_Bold_CheckedChanged);
            // 
            // cbox_Regular
            // 
            this.cbox_Regular.AutoSize = true;
            this.cbox_Regular.Location = new System.Drawing.Point(31, 39);
            this.cbox_Regular.Name = "cbox_Regular";
            this.cbox_Regular.Size = new System.Drawing.Size(75, 22);
            this.cbox_Regular.TabIndex = 0;
            this.cbox_Regular.Text = "Regular";
            this.cbox_Regular.UseVisualStyleBackColor = true;
            this.cbox_Regular.CheckedChanged += new System.EventHandler(this.cbox_Regular_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtn_Blue);
            this.groupBox3.Controls.Add(this.rbtn_Green);
            this.groupBox3.Controls.Add(this.rbtn_Red);
            this.groupBox3.Controls.Add(this.rbtn_Auto);
            this.groupBox3.Location = new System.Drawing.Point(347, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 241);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Color";
            // 
            // rbtn_Blue
            // 
            this.rbtn_Blue.AutoSize = true;
            this.rbtn_Blue.Location = new System.Drawing.Point(40, 166);
            this.rbtn_Blue.Name = "rbtn_Blue";
            this.rbtn_Blue.Size = new System.Drawing.Size(53, 22);
            this.rbtn_Blue.TabIndex = 0;
            this.rbtn_Blue.TabStop = true;
            this.rbtn_Blue.Text = "Blue";
            this.rbtn_Blue.UseVisualStyleBackColor = true;
            this.rbtn_Blue.CheckedChanged += new System.EventHandler(this.rbtn_Blue_CheckedChanged);
            // 
            // rbtn_Green
            // 
            this.rbtn_Green.AutoSize = true;
            this.rbtn_Green.Location = new System.Drawing.Point(40, 121);
            this.rbtn_Green.Name = "rbtn_Green";
            this.rbtn_Green.Size = new System.Drawing.Size(65, 22);
            this.rbtn_Green.TabIndex = 0;
            this.rbtn_Green.TabStop = true;
            this.rbtn_Green.Text = "Green";
            this.rbtn_Green.UseVisualStyleBackColor = true;
            this.rbtn_Green.CheckedChanged += new System.EventHandler(this.rbtn_Green_CheckedChanged);
            // 
            // rbtn_Red
            // 
            this.rbtn_Red.AutoSize = true;
            this.rbtn_Red.Location = new System.Drawing.Point(40, 78);
            this.rbtn_Red.Name = "rbtn_Red";
            this.rbtn_Red.Size = new System.Drawing.Size(51, 22);
            this.rbtn_Red.TabIndex = 0;
            this.rbtn_Red.TabStop = true;
            this.rbtn_Red.Text = "Red";
            this.rbtn_Red.UseVisualStyleBackColor = true;
            this.rbtn_Red.CheckedChanged += new System.EventHandler(this.rbtn_Red_CheckedChanged);
            // 
            // rbtn_Auto
            // 
            this.rbtn_Auto.AutoSize = true;
            this.rbtn_Auto.Location = new System.Drawing.Point(40, 38);
            this.rbtn_Auto.Name = "rbtn_Auto";
            this.rbtn_Auto.Size = new System.Drawing.Size(88, 22);
            this.rbtn_Auto.TabIndex = 0;
            this.rbtn_Auto.TabStop = true;
            this.rbtn_Auto.Text = "AutoColor";
            this.rbtn_Auto.UseVisualStyleBackColor = true;
            this.rbtn_Auto.CheckedChanged += new System.EventHandler(this.rbtn_Auto_CheckedChanged);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(387, 403);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(152, 38);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "E&xit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 453);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lb_Name);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbox_Bold_Italic;
        private System.Windows.Forms.CheckBox cbox_Italic;
        private System.Windows.Forms.CheckBox cbox_Bold;
        private System.Windows.Forms.CheckBox cbox_Regular;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtn_Blue;
        private System.Windows.Forms.RadioButton rbtn_Green;
        private System.Windows.Forms.RadioButton rbtn_Red;
        private System.Windows.Forms.RadioButton rbtn_Auto;
        private System.Windows.Forms.Button btn_Exit;

    }
}

