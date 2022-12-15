namespace C_PL.Views
{
    partial class FrmForgotPW
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Sdt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_FindAcc = new System.Windows.Forms.Button();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(164, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 46);
            this.label3.TabIndex = 46;
            this.label3.Text = "QUÊN MẬT KHẨU";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(184, 222);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(388, 27);
            this.txt_Email.TabIndex = 50;
            this.txt_Email.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Email";
            // 
            // txt_Sdt
            // 
            this.txt_Sdt.Location = new System.Drawing.Point(184, 174);
            this.txt_Sdt.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Sdt.Name = "txt_Sdt";
            this.txt_Sdt.Size = new System.Drawing.Size(388, 27);
            this.txt_Sdt.TabIndex = 48;
            this.txt_Sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Sdt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Số điện thoại";
            // 
            // btn_FindAcc
            // 
            this.btn_FindAcc.AutoSize = true;
            this.btn_FindAcc.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_FindAcc.FlatAppearance.BorderSize = 0;
            this.btn_FindAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FindAcc.ForeColor = System.Drawing.Color.White;
            this.btn_FindAcc.Location = new System.Drawing.Point(267, 288);
            this.btn_FindAcc.Margin = new System.Windows.Forms.Padding(2);
            this.btn_FindAcc.Name = "btn_FindAcc";
            this.btn_FindAcc.Size = new System.Drawing.Size(116, 43);
            this.btn_FindAcc.TabIndex = 51;
            this.btn_FindAcc.Text = "Tìm tài khoản";
            this.btn_FindAcc.UseVisualStyleBackColor = false;
            this.btn_FindAcc.Click += new System.EventHandler(this.btn_FindAcc_Click);
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(184, 121);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(388, 27);
            this.txt_Username.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "Tên tài khoản";
            // 
            // FrmForgotPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 366);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_FindAcc);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Sdt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "FrmForgotPW";
            this.Text = "FrmForgotPW";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private TextBox txt_Email;
        private Label label2;
        private TextBox txt_Sdt;
        private Label label1;
        private Button btn_FindAcc;
        private TextBox txt_Username;
        private Label label4;
    }
}