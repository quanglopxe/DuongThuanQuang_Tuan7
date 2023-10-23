namespace BTMAU_Bai5
{
    partial class Form2
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
            this.btn_Load = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_Select_Nation = new System.Windows.Forms.ComboBox();
            this.btn_Show = new System.Windows.Forms.Button();
            this.lb_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Load
            // 
            this.btn_Load.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Load.Location = new System.Drawing.Point(103, 25);
            this.btn_Load.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(289, 32);
            this.btn_Load.TabIndex = 0;
            this.btn_Load.Text = "Load dữ liệu Combobox";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dân tộc";
            // 
            // cbo_Select_Nation
            // 
            this.cbo_Select_Nation.FormattingEnabled = true;
            this.cbo_Select_Nation.Location = new System.Drawing.Point(206, 96);
            this.cbo_Select_Nation.Name = "cbo_Select_Nation";
            this.cbo_Select_Nation.Size = new System.Drawing.Size(213, 30);
            this.cbo_Select_Nation.TabIndex = 2;
            this.cbo_Select_Nation.SelectedIndexChanged += new System.EventHandler(this.cbo_Select_Nation_SelectedIndexChanged);
            // 
            // btn_Show
            // 
            this.btn_Show.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show.Location = new System.Drawing.Point(206, 165);
            this.btn_Show.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(171, 32);
            this.btn_Show.TabIndex = 0;
            this.btn_Show.Text = "Hiển thị";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // lb_Result
            // 
            this.lb_Result.AutoSize = true;
            this.lb_Result.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Result.ForeColor = System.Drawing.Color.Red;
            this.lb_Result.Location = new System.Drawing.Point(167, 260);
            this.lb_Result.Name = "lb_Result";
            this.lb_Result.Size = new System.Drawing.Size(83, 23);
            this.lb_Result.TabIndex = 1;
            this.lb_Result.Text = "Kết quả";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 427);
            this.Controls.Add(this.cbo_Select_Nation);
            this.Controls.Add(this.lb_Result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.btn_Load);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_Select_Nation;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Label lb_Result;
    }
}