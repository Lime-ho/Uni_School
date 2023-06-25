namespace Homework_Dohune
{
    partial class PaymentSuccess
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
            this.bigTextBox1 = new ReaLTaiizor.Controls.BigTextBox();
            this.successButton = new ReaLTaiizor.Controls.PoisonButton();
            this.SuspendLayout();
            // 
            // bigTextBox1
            // 
            this.bigTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.bigTextBox1.Enabled = false;
            this.bigTextBox1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.bigTextBox1.ForeColor = System.Drawing.Color.ForestGreen;
            this.bigTextBox1.Image = null;
            this.bigTextBox1.Location = new System.Drawing.Point(72, 32);
            this.bigTextBox1.MaxLength = 32767;
            this.bigTextBox1.Multiline = false;
            this.bigTextBox1.Name = "bigTextBox1";
            this.bigTextBox1.ReadOnly = false;
            this.bigTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bigTextBox1.Size = new System.Drawing.Size(102, 41);
            this.bigTextBox1.TabIndex = 0;
            this.bigTextBox1.Text = "결제 성공";
            this.bigTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.bigTextBox1.UseSystemPasswordChar = false;
            // 
            // successButton
            // 
            this.successButton.Location = new System.Drawing.Point(85, 92);
            this.successButton.Name = "successButton";
            this.successButton.Size = new System.Drawing.Size(75, 23);
            this.successButton.TabIndex = 1;
            this.successButton.Text = "확인";
            this.successButton.UseSelectable = true;
            this.successButton.Click += new System.EventHandler(this.successButton_Click);
            // 
            // PaymentSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 127);
            this.Controls.Add(this.successButton);
            this.Controls.Add(this.bigTextBox1);
            this.Name = "PaymentSuccess";
            this.Text = "PaymentSuccess";
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.BigTextBox bigTextBox1;
        private ReaLTaiizor.Controls.PoisonButton successButton;
    }
}