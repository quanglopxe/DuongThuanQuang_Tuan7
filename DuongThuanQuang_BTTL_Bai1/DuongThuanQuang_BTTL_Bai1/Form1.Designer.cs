namespace DuongThuanQuang_BTTL_Bai1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_PT1 = new System.Windows.Forms.RadioButton();
            this.rbtn_PT2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.btn_Solve = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.lb_c = new System.Windows.Forms.Label();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(271, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIẢI PHƯƠNG TRÌNH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_PT2);
            this.groupBox1.Controls.Add(this.rbtn_PT1);
            this.groupBox1.Location = new System.Drawing.Point(214, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 124);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bạn vui lòng chọn";
            // 
            // rbtn_PT1
            // 
            this.rbtn_PT1.AutoSize = true;
            this.rbtn_PT1.Location = new System.Drawing.Point(22, 36);
            this.rbtn_PT1.Name = "rbtn_PT1";
            this.rbtn_PT1.Size = new System.Drawing.Size(149, 22);
            this.rbtn_PT1.TabIndex = 0;
            this.rbtn_PT1.TabStop = true;
            this.rbtn_PT1.Text = "Phương trình bậc 1";
            this.rbtn_PT1.UseVisualStyleBackColor = true;
            this.rbtn_PT1.CheckedChanged += new System.EventHandler(this.rbtn_PT1_CheckedChanged);
            // 
            // rbtn_PT2
            // 
            this.rbtn_PT2.AutoSize = true;
            this.rbtn_PT2.Location = new System.Drawing.Point(22, 76);
            this.rbtn_PT2.Name = "rbtn_PT2";
            this.rbtn_PT2.Size = new System.Drawing.Size(149, 22);
            this.rbtn_PT2.TabIndex = 0;
            this.rbtn_PT2.TabStop = true;
            this.rbtn_PT2.Text = "Phương trình bậc 2";
            this.rbtn_PT2.UseVisualStyleBackColor = true;
            this.rbtn_PT2.CheckedChanged += new System.EventHandler(this.rbtn_PT2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập a";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(274, 238);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(100, 25);
            this.txt_a.TabIndex = 3;
            this.txt_a.TextChanged += new System.EventHandler(this.txt_a_TextChanged);
            // 
            // btn_Solve
            // 
            this.btn_Solve.Enabled = false;
            this.btn_Solve.Location = new System.Drawing.Point(408, 238);
            this.btn_Solve.Name = "btn_Solve";
            this.btn_Solve.Size = new System.Drawing.Size(83, 51);
            this.btn_Solve.TabIndex = 4;
            this.btn_Solve.Text = "Giải";
            this.btn_Solve.UseVisualStyleBackColor = true;
            this.btn_Solve.Click += new System.EventHandler(this.btn_Solve_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập b";
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(274, 280);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(100, 25);
            this.txt_b.TabIndex = 3;
            this.txt_b.TextChanged += new System.EventHandler(this.txt_b_TextChanged);
            // 
            // lb_c
            // 
            this.lb_c.AutoSize = true;
            this.lb_c.Location = new System.Drawing.Point(211, 324);
            this.lb_c.Name = "lb_c";
            this.lb_c.Size = new System.Drawing.Size(54, 18);
            this.lb_c.TabIndex = 2;
            this.lb_c.Text = "Nhập c";
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(274, 320);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(100, 25);
            this.txt_c.TabIndex = 3;
            this.txt_c.TextChanged += new System.EventHandler(this.txt_c_TextChanged);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(408, 295);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(83, 51);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kết quả";
            // 
            // txt_Result
            // 
            this.txt_Result.Enabled = false;
            this.txt_Result.Location = new System.Drawing.Point(274, 377);
            this.txt_Result.Multiline = true;
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(217, 88);
            this.txt_Result.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 510);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Solve);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_c);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Giải phương trình bậc 1-2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_PT2;
        private System.Windows.Forms.RadioButton rbtn_PT1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Button btn_Solve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.Label lb_c;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

