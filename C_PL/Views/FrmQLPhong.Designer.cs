namespace C_PL.Views
{
    partial class FrmQLPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQLPhong));
            this.txt_DienTich = new System.Windows.Forms.TextBox();
            this.txt_SoNguoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaPhong = new System.Windows.Forms.TextBox();
            this.btn_Find = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dtg_Show = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Gia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.rd_DaThue = new System.Windows.Forms.RadioButton();
            this.rd_ConTrong = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_DienTich
            // 
            this.txt_DienTich.Enabled = false;
            this.txt_DienTich.Location = new System.Drawing.Point(165, 206);
            this.txt_DienTich.Margin = new System.Windows.Forms.Padding(2);
            this.txt_DienTich.Name = "txt_DienTich";
            this.txt_DienTich.Size = new System.Drawing.Size(234, 27);
            this.txt_DienTich.TabIndex = 16;
            this.txt_DienTich.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DienTich_KeyPress);
            // 
            // txt_SoNguoi
            // 
            this.txt_SoNguoi.Enabled = false;
            this.txt_SoNguoi.Location = new System.Drawing.Point(165, 139);
            this.txt_SoNguoi.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SoNguoi.Name = "txt_SoNguoi";
            this.txt_SoNguoi.Size = new System.Drawing.Size(234, 27);
            this.txt_SoNguoi.TabIndex = 15;
            this.txt_SoNguoi.TextChanged += new System.EventHandler(this.txt_SoNguoi_TextChanged);
            this.txt_SoNguoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoNguoi_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Diện tích";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Số người";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã phòng";
            // 
            // txt_MaPhong
            // 
            this.txt_MaPhong.Location = new System.Drawing.Point(165, 70);
            this.txt_MaPhong.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MaPhong.Name = "txt_MaPhong";
            this.txt_MaPhong.Size = new System.Drawing.Size(234, 27);
            this.txt_MaPhong.TabIndex = 11;
            // 
            // btn_Find
            // 
            this.btn_Find.AutoSize = true;
            this.btn_Find.Image = ((System.Drawing.Image)(resources.GetObject("btn_Find.Image")));
            this.btn_Find.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Find.Location = new System.Drawing.Point(801, 269);
            this.btn_Find.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(128, 54);
            this.btn_Find.TabIndex = 59;
            this.btn_Find.Text = "Tìm kiếm";
            this.btn_Find.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.AutoSize = true;
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(622, 269);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(99, 54);
            this.btn_Save.TabIndex = 58;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.AutoSize = true;
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(419, 269);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(108, 54);
            this.btn_Delete.TabIndex = 57;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.AutoSize = true;
            this.btn_Update.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.Image")));
            this.btn_Update.Location = new System.Drawing.Point(228, 269);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(92, 54);
            this.btn_Update.TabIndex = 56;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.AutoSize = true;
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(35, 269);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(105, 54);
            this.btn_Add.TabIndex = 55;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dtg_Show
            // 
            this.dtg_Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Show.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dtg_Show.Location = new System.Drawing.Point(12, 341);
            this.dtg_Show.Name = "dtg_Show";
            this.dtg_Show.RowHeadersWidth = 51;
            this.dtg_Show.RowTemplate.Height = 29;
            this.dtg_Show.Size = new System.Drawing.Size(936, 204);
            this.dtg_Show.TabIndex = 60;
            this.dtg_Show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Show_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "MaPhong";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "SoNguoi";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "DienTich";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "DiaChi";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "DonGiaPhong";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "TrangThai";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(323, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(300, 46);
            this.label8.TabIndex = 10;
            this.label8.Text = "QUẢN LÝ PHÒNG";
            // 
            // txt_Gia
            // 
            this.txt_Gia.Enabled = false;
            this.txt_Gia.Location = new System.Drawing.Point(632, 137);
            this.txt_Gia.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.Size = new System.Drawing.Size(234, 27);
            this.txt_Gia.TabIndex = 65;
            this.txt_Gia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Gia_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "Trạng thái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 63;
            this.label5.Text = "Giá phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 62;
            this.label6.Text = "Địa chỉ ";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Enabled = false;
            this.txt_DiaChi.Location = new System.Drawing.Point(632, 68);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(234, 27);
            this.txt_DiaChi.TabIndex = 61;
            // 
            // rd_DaThue
            // 
            this.rd_DaThue.AutoSize = true;
            this.rd_DaThue.Enabled = false;
            this.rd_DaThue.Location = new System.Drawing.Point(632, 209);
            this.rd_DaThue.Name = "rd_DaThue";
            this.rd_DaThue.Size = new System.Drawing.Size(82, 24);
            this.rd_DaThue.TabIndex = 66;
            this.rd_DaThue.TabStop = true;
            this.rd_DaThue.Text = "Đã thuê";
            this.rd_DaThue.UseVisualStyleBackColor = true;
            // 
            // rd_ConTrong
            // 
            this.rd_ConTrong.AutoSize = true;
            this.rd_ConTrong.Enabled = false;
            this.rd_ConTrong.Location = new System.Drawing.Point(749, 209);
            this.rd_ConTrong.Name = "rd_ConTrong";
            this.rd_ConTrong.Size = new System.Drawing.Size(96, 24);
            this.rd_ConTrong.TabIndex = 67;
            this.rd_ConTrong.TabStop = true;
            this.rd_ConTrong.Text = "Còn trống";
            this.rd_ConTrong.UseVisualStyleBackColor = true;
            // 
            // FrmQLPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 557);
            this.Controls.Add(this.rd_ConTrong);
            this.Controls.Add(this.rd_DaThue);
            this.Controls.Add(this.txt_Gia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.dtg_Show);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_DienTich);
            this.Controls.Add(this.txt_SoNguoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MaPhong);
            this.Controls.Add(this.label8);
            this.Name = "FrmQLPhong";
            this.Text = "FrmQLPhong";
            this.Load += new System.EventHandler(this.FrmQLPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_DienTich;
        private TextBox txt_SoNguoi;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_MaPhong;
        private Button btn_Find;
        private Button btn_Save;
        private Button btn_Delete;
        private Button btn_Update;
        private Button btn_Add;
        private DataGridView dtg_Show;
        private Label label8;
        private TextBox txt_Gia;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_DiaChi;
        private RadioButton rd_DaThue;
        private RadioButton rd_ConTrong;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}