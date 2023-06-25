namespace Homework_Dohune
{
    partial class UserWishList
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
            this.foreverButton1 = new ReaLTaiizor.Controls.ForeverButton();
            this.foreverButton2 = new ReaLTaiizor.Controls.ForeverButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.totalPrice = new ReaLTaiizor.Controls.BigTextBox();
            this.SuspendLayout();
            // 
            // foreverButton1
            // 
            this.foreverButton1.BackColor = System.Drawing.Color.Transparent;
            this.foreverButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.foreverButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.foreverButton1.Location = new System.Drawing.Point(130, 380);
            this.foreverButton1.Name = "foreverButton1";
            this.foreverButton1.Rounded = false;
            this.foreverButton1.Size = new System.Drawing.Size(132, 44);
            this.foreverButton1.TabIndex = 1;
            this.foreverButton1.Text = "메뉴 삭제";
            this.foreverButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.foreverButton1.Click += new System.EventHandler(this.foreverButton1_Click);
            // 
            // foreverButton2
            // 
            this.foreverButton2.BackColor = System.Drawing.Color.Transparent;
            this.foreverButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.foreverButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.foreverButton2.Location = new System.Drawing.Point(435, 380);
            this.foreverButton2.Name = "foreverButton2";
            this.foreverButton2.Rounded = false;
            this.foreverButton2.Size = new System.Drawing.Size(132, 44);
            this.foreverButton2.TabIndex = 1;
            this.foreverButton2.Text = "돌아가기";
            this.foreverButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.foreverButton2.Click += new System.EventHandler(this.foreverButton2_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(3, 1);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(791, 308);
            this.checkedListBox1.TabIndex = 2;
            // 
            // totalPrice
            // 
            this.totalPrice.BackColor = System.Drawing.Color.Transparent;
            this.totalPrice.Font = new System.Drawing.Font("Tahoma", 11F);
            this.totalPrice.ForeColor = System.Drawing.Color.DimGray;
            this.totalPrice.Image = null;
            this.totalPrice.Location = new System.Drawing.Point(162, 324);
            this.totalPrice.MaxLength = 32767;
            this.totalPrice.Multiline = false;
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = false;
            this.totalPrice.Size = new System.Drawing.Size(438, 41);
            this.totalPrice.TabIndex = 3;
            this.totalPrice.Text = "bigTextBox1";
            this.totalPrice.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.totalPrice.UseSystemPasswordChar = false;
            this.totalPrice.TextChanged += new System.EventHandler(this.bigTextBox1_TextChanged);
            // 
            // UserWishList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.foreverButton2);
            this.Controls.Add(this.foreverButton1);
            this.Name = "UserWishList";
            this.Text = "UserWishList";
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.ForeverButton foreverButton1;
        private ReaLTaiizor.Controls.ForeverButton foreverButton2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private ReaLTaiizor.Controls.BigTextBox totalPrice;
    }
}