namespace C_PL.Views
{
    partial class FrmDangNhap
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_Signup = new System.Windows.Forms.Label();
            this.lb_Forgot = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::C_PL.Properties.Resources._1564535_customer_user_userphoto_account_person_icon;
            this.pictureBox1.Location = new System.Drawing.Point(11, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(594, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // lb_Signup
            // 
            this.lb_Signup.AutoSize = true;
            this.lb_Signup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Signup.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_Signup.Location = new System.Drawing.Point(461, 350);
            this.lb_Signup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Signup.Name = "lb_Signup";
            this.lb_Signup.Size = new System.Drawing.Size(90, 28);
            this.lb_Signup.TabIndex = 23;
            this.lb_Signup.Text = "Đăng ký";
            this.lb_Signup.Click += new System.EventHandler(this.lb_Signup_Click);
            // 
            // lb_Forgot
            // 
            this.lb_Forgot.AutoSize = true;
            this.lb_Forgot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Forgot.Location = new System.Drawing.Point(53, 350);
            this.lb_Forgot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Forgot.Name = "lb_Forgot";
            this.lb_Forgot.Size = new System.Drawing.Size(166, 28);
            this.lb_Forgot.TabIndex = 22;
            this.lb_Forgot.Text = "Quên mật khẩu?";
            this.lb_Forgot.Click += new System.EventHandler(this.lb_Forgot_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(165, 201);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(386, 27);
            this.txt_Password.TabIndex = 21;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mật khẩu";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(251, 280);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(116, 43);
            this.btn_Login.TabIndex = 19;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(165, 124);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(386, 27);
            this.txt_Username.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tên tài khoản";
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_Signup);
            this.Controls.Add(this.lb_Forgot);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label1);
            this.Name = "FrmDangNhap";
            this.Text = "FrmDangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lb_Signup;
        private Label lb_Forgot;
        private TextBox txt_Password;
        private Label label2;
        private Button btn_Login;
        private TextBox txt_Username;
        private Label label1;
    }
}