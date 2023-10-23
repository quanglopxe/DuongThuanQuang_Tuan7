namespace BTMAU_Bai5
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
            this.listBoxLeft = new System.Windows.Forms.ListBox();
            this.listBoxRight = new System.Windows.Forms.ListBox();
            this.btn_Right = new System.Windows.Forms.Button();
            this.btn_Right_All = new System.Windows.Forms.Button();
            this.btn_Left = new System.Windows.Forms.Button();
            this.btn_Left_All = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxLeft
            // 
            this.listBoxLeft.FormattingEnabled = true;
            this.listBoxLeft.ItemHeight = 22;
            this.listBoxLeft.Items.AddRange(new object[] {
            "Cóc",
            "Ổi",
            "Xoài",
            "Me",
            "Bưởi",
            "Cam"});
            this.listBoxLeft.Location = new System.Drawing.Point(35, 58);
            this.listBoxLeft.Name = "listBoxLeft";
            this.listBoxLeft.Size = new System.Drawing.Size(287, 356);
            this.listBoxLeft.TabIndex = 0;
            // 
            // listBoxRight
            // 
            this.listBoxRight.FormattingEnabled = true;
            this.listBoxRight.ItemHeight = 22;
            this.listBoxRight.Location = new System.Drawing.Point(431, 58);
            this.listBoxRight.Name = "listBoxRight";
            this.listBoxRight.Size = new System.Drawing.Size(287, 356);
            this.listBoxRight.TabIndex = 0;
            // 
            // btn_Right
            // 
            this.btn_Right.Location = new System.Drawing.Point(344, 94);
            this.btn_Right.Name = "btn_Right";
            this.btn_Right.Size = new System.Drawing.Size(65, 39);
            this.btn_Right.TabIndex = 1;
            this.btn_Right.Text = ">";
            this.btn_Right.UseVisualStyleBackColor = true;
            this.btn_Right.Click += new System.EventHandler(this.btn_Right_Click);
            // 
            // btn_Right_All
            // 
            this.btn_Right_All.Location = new System.Drawing.Point(344, 158);
            this.btn_Right_All.Name = "btn_Right_All";
            this.btn_Right_All.Size = new System.Drawing.Size(65, 39);
            this.btn_Right_All.TabIndex = 1;
            this.btn_Right_All.Text = ">>";
            this.btn_Right_All.UseVisualStyleBackColor = true;
            this.btn_Right_All.Click += new System.EventHandler(this.btn_Right_All_Click);
            // 
            // btn_Left
            // 
            this.btn_Left.Location = new System.Drawing.Point(344, 226);
            this.btn_Left.Name = "btn_Left";
            this.btn_Left.Size = new System.Drawing.Size(65, 39);
            this.btn_Left.TabIndex = 1;
            this.btn_Left.Text = "<";
            this.btn_Left.UseVisualStyleBackColor = true;
            this.btn_Left.Click += new System.EventHandler(this.btn_Left_Click);
            // 
            // btn_Left_All
            // 
            this.btn_Left_All.Location = new System.Drawing.Point(344, 291);
            this.btn_Left_All.Name = "btn_Left_All";
            this.btn_Left_All.Size = new System.Drawing.Size(65, 39);
            this.btn_Left_All.TabIndex = 1;
            this.btn_Left_All.Text = "<<";
            this.btn_Left_All.UseVisualStyleBackColor = true;
            this.btn_Left_All.Click += new System.EventHandler(this.btn_Left_All_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 503);
            this.Controls.Add(this.btn_Left_All);
            this.Controls.Add(this.btn_Left);
            this.Controls.Add(this.btn_Right_All);
            this.Controls.Add(this.btn_Right);
            this.Controls.Add(this.listBoxRight);
            this.Controls.Add(this.listBoxLeft);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Sử dụng listBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLeft;
        private System.Windows.Forms.ListBox listBoxRight;
        private System.Windows.Forms.Button btn_Right;
        private System.Windows.Forms.Button btn_Right_All;
        private System.Windows.Forms.Button btn_Left;
        private System.Windows.Forms.Button btn_Left_All;
    }
}

