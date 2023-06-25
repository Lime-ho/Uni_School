namespace Homework_Dohune
{
    partial class UserPayment
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
            this.payRun = new ReaLTaiizor.Controls.MetroButton();
            this.payCancel = new ReaLTaiizor.Controls.MetroButton();
            this.menuList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // payRun
            // 
            this.payRun.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.payRun.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.payRun.DisabledForeColor = System.Drawing.Color.Gray;
            this.payRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.payRun.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.payRun.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.payRun.HoverTextColor = System.Drawing.Color.White;
            this.payRun.IsDerivedStyle = true;
            this.payRun.Location = new System.Drawing.Point(72, 372);
            this.payRun.Name = "payRun";
            this.payRun.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.payRun.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.payRun.NormalTextColor = System.Drawing.Color.White;
            this.payRun.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.payRun.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.payRun.PressTextColor = System.Drawing.Color.White;
            this.payRun.Size = new System.Drawing.Size(119, 35);
            this.payRun.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.payRun.StyleManager = null;
            this.payRun.TabIndex = 1;
            this.payRun.Text = "결제";
            this.payRun.ThemeAuthor = "Taiizor";
            this.payRun.ThemeName = "MetroLight";
            this.payRun.Click += new System.EventHandler(this.payRun_Click);
            // 
            // payCancel
            // 
            this.payCancel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.payCancel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.payCancel.DisabledForeColor = System.Drawing.Color.Gray;
            this.payCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.payCancel.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.payCancel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.payCancel.HoverTextColor = System.Drawing.Color.White;
            this.payCancel.IsDerivedStyle = true;
            this.payCancel.Location = new System.Drawing.Point(355, 372);
            this.payCancel.Name = "payCancel";
            this.payCancel.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.payCancel.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.payCancel.NormalTextColor = System.Drawing.Color.White;
            this.payCancel.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.payCancel.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.payCancel.PressTextColor = System.Drawing.Color.White;
            this.payCancel.Size = new System.Drawing.Size(119, 35);
            this.payCancel.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.payCancel.StyleManager = null;
            this.payCancel.TabIndex = 1;
            this.payCancel.Text = "취소";
            this.payCancel.ThemeAuthor = "Taiizor";
            this.payCancel.ThemeName = "MetroLight";
            this.payCancel.Click += new System.EventHandler(this.payCancel_Click);
            // 
            // menuList
            // 
            this.menuList.Font = new System.Drawing.Font("굴림", 15F);
            this.menuList.FormattingEnabled = true;
            this.menuList.ItemHeight = 20;
            this.menuList.Location = new System.Drawing.Point(0, 0);
            this.menuList.Name = "menuList";
            this.menuList.Size = new System.Drawing.Size(604, 344);
            this.menuList.TabIndex = 2;
            // 
            // UserPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 442);
            this.Controls.Add(this.menuList);
            this.Controls.Add(this.payCancel);
            this.Controls.Add(this.payRun);
            this.Name = "UserPayment";
            this.Text = "UserPayment";
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.MetroButton payRun;
        private ReaLTaiizor.Controls.MetroButton payCancel;
        private System.Windows.Forms.ListBox menuList;
    }
}