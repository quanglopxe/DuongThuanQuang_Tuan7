namespace BTMAU_Bai5
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.trv_Department = new System.Windows.Forms.TreeView();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.cbo_Department = new System.Windows.Forms.ComboBox();
            this.btn_Add_Emp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Delete_Dept = new System.Windows.Forms.Button();
            this.btn_Add_Dept = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Department = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(327, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỒ SƠ NHÂN VIÊN";
            // 
            // trv_Department
            // 
            this.trv_Department.Location = new System.Drawing.Point(16, 33);
            this.trv_Department.Name = "trv_Department";
            this.trv_Department.Size = new System.Drawing.Size(264, 287);
            this.trv_Department.TabIndex = 0;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(436, 73);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(117, 30);
            this.txt_ID.TabIndex = 0;
            // 
            // cbo_Department
            // 
            this.cbo_Department.FormattingEnabled = true;
            this.cbo_Department.Location = new System.Drawing.Point(436, 181);
            this.cbo_Department.Name = "cbo_Department";
            this.cbo_Department.Size = new System.Drawing.Size(452, 30);
            this.cbo_Department.TabIndex = 1;
            // 
            // btn_Add_Emp
            // 
            this.btn_Add_Emp.Location = new System.Drawing.Point(436, 257);
            this.btn_Add_Emp.Name = "btn_Add_Emp";
            this.btn_Add_Emp.Size = new System.Drawing.Size(90, 46);
            this.btn_Add_Emp.TabIndex = 2;
            this.btn_Add_Emp.Text = "Thêm";
            this.btn_Add_Emp.UseVisualStyleBackColor = true;
            this.btn_Add_Emp.Click += new System.EventHandler(this.btn_Add_Emp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trv_Department);
            this.groupBox1.Controls.Add(this.btn_Delete_Dept);
            this.groupBox1.Controls.Add(this.btn_Add_Dept);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Department);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 467);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phòng ban";
            // 
            // btn_Delete_Dept
            // 
            this.btn_Delete_Dept.Location = new System.Drawing.Point(113, 414);
            this.btn_Delete_Dept.Name = "btn_Delete_Dept";
            this.btn_Delete_Dept.Size = new System.Drawing.Size(167, 34);
            this.btn_Delete_Dept.TabIndex = 2;
            this.btn_Delete_Dept.Text = "Xóa phòng ban";
            this.btn_Delete_Dept.UseVisualStyleBackColor = true;
            this.btn_Delete_Dept.Click += new System.EventHandler(this.btn_Delete_Dept_Click);
            // 
            // btn_Add_Dept
            // 
            this.btn_Add_Dept.Location = new System.Drawing.Point(113, 374);
            this.btn_Add_Dept.Name = "btn_Add_Dept";
            this.btn_Add_Dept.Size = new System.Drawing.Size(167, 34);
            this.btn_Add_Dept.TabIndex = 2;
            this.btn_Add_Dept.Text = "Thêm phòng ban";
            this.btn_Add_Dept.UseVisualStyleBackColor = true;
            this.btn_Add_Dept.Click += new System.EventHandler(this.btn_Add_Dept_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phòng ban";
            // 
            // txt_Department
            // 
            this.txt_Department.Location = new System.Drawing.Point(113, 338);
            this.txt_Department.Name = "txt_Department";
            this.txt_Department.Size = new System.Drawing.Size(167, 30);
            this.txt_Department.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã số";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phòng ban";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(591, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Họ tên";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(670, 73);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(218, 30);
            this.txt_Name.TabIndex = 0;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(436, 128);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(452, 30);
            this.txt_Address.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(577, 257);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(93, 46);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 550);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Add_Emp);
            this.Controls.Add(this.cbo_Department);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView trv_Department;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.ComboBox cbo_Department;
        private System.Windows.Forms.Button btn_Add_Emp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Department;
        private System.Windows.Forms.Button btn_Delete_Dept;
        private System.Windows.Forms.Button btn_Add_Dept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Button btn_Exit;
    }
}