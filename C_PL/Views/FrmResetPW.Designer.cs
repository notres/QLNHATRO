namespace C_PL.Views
{
    partial class FrmResetPW
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
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_RePassword = new System.Windows.Forms.Button();
            this.txt_RePassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(244, 130);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(341, 27);
            this.txt_Password.TabIndex = 61;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 60;
            this.label4.Text = "Nhập mật khẩu mới";
            // 
            // btn_RePassword
            // 
            this.btn_RePassword.AutoSize = true;
            this.btn_RePassword.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_RePassword.FlatAppearance.BorderSize = 0;
            this.btn_RePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RePassword.ForeColor = System.Drawing.Color.White;
            this.btn_RePassword.Location = new System.Drawing.Point(263, 279);
            this.btn_RePassword.Margin = new System.Windows.Forms.Padding(2);
            this.btn_RePassword.Name = "btn_RePassword";
            this.btn_RePassword.Size = new System.Drawing.Size(116, 43);
            this.btn_RePassword.TabIndex = 59;
            this.btn_RePassword.Text = "Đổi mật khẩu";
            this.btn_RePassword.UseVisualStyleBackColor = false;
            this.btn_RePassword.Click += new System.EventHandler(this.btn_RePassword_Click);
            // 
            // txt_RePassword
            // 
            this.txt_RePassword.Location = new System.Drawing.Point(244, 200);
            this.txt_RePassword.Margin = new System.Windows.Forms.Padding(2);
            this.txt_RePassword.Name = "txt_RePassword";
            this.txt_RePassword.Size = new System.Drawing.Size(341, 27);
            this.txt_RePassword.TabIndex = 56;
            this.txt_RePassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Xác nhận mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(141, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(371, 46);
            this.label3.TabIndex = 54;
            this.label3.Text = "THAY ĐỔI MẬT KHẨU";
            // 
            // FrmResetPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 366);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_RePassword);
            this.Controls.Add(this.txt_RePassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "FrmResetPW";
            this.Text = "FrmResetPW";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_Password;
        private Label label4;
        private Button btn_RePassword;
        private TextBox txt_RePassword;
        private Label label1;
        private Label label3;
    }
}