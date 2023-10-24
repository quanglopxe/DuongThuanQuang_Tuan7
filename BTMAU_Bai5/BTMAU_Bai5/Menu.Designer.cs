namespace BTMAU_Bai5
{
    partial class Menu
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
            this.btn_Bai2 = new System.Windows.Forms.Button();
            this.btn_Bai3 = new System.Windows.Forms.Button();
            this.btn_Bai1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Bai2
            // 
            this.btn_Bai2.Location = new System.Drawing.Point(237, 45);
            this.btn_Bai2.Name = "btn_Bai2";
            this.btn_Bai2.Size = new System.Drawing.Size(110, 51);
            this.btn_Bai2.TabIndex = 0;
            this.btn_Bai2.Text = "Bài 2";
            this.btn_Bai2.UseVisualStyleBackColor = true;
            this.btn_Bai2.Click += new System.EventHandler(this.btn_Bai2_Click);
            // 
            // btn_Bai3
            // 
            this.btn_Bai3.Location = new System.Drawing.Point(391, 45);
            this.btn_Bai3.Name = "btn_Bai3";
            this.btn_Bai3.Size = new System.Drawing.Size(110, 51);
            this.btn_Bai3.TabIndex = 0;
            this.btn_Bai3.Text = "Bài 3";
            this.btn_Bai3.UseVisualStyleBackColor = true;
            this.btn_Bai3.Click += new System.EventHandler(this.btn_Bai3_Click);
            // 
            // btn_Bai1
            // 
            this.btn_Bai1.Location = new System.Drawing.Point(75, 45);
            this.btn_Bai1.Name = "btn_Bai1";
            this.btn_Bai1.Size = new System.Drawing.Size(110, 51);
            this.btn_Bai1.TabIndex = 0;
            this.btn_Bai1.Text = "Bài 1";
            this.btn_Bai1.UseVisualStyleBackColor = true;
            this.btn_Bai1.Click += new System.EventHandler(this.btn_Bai1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 417);
            this.Controls.Add(this.btn_Bai3);
            this.Controls.Add(this.btn_Bai1);
            this.Controls.Add(this.btn_Bai2);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Bai2;
        private System.Windows.Forms.Button btn_Bai3;
        private System.Windows.Forms.Button btn_Bai1;
    }
}