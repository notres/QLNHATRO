namespace C_PL.Views
{
    partial class FrmQLHopDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQLHopDong));
            this.txt_MaHopDong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Find = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dtg_HoaDon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtg_CTHoaDon = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_CTHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_MaHopDong
            // 
            this.txt_MaHopDong.Location = new System.Drawing.Point(150, 47);
            this.txt_MaHopDong.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MaHopDong.Name = "txt_MaHopDong";
            this.txt_MaHopDong.Size = new System.Drawing.Size(241, 27);
            this.txt_MaHopDong.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Mã hợp đồng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(374, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(402, 46);
            this.label8.TabIndex = 24;
            this.label8.Text = "DANH MỤC HỢP ĐỒNG";
            // 
            // btn_Find
            // 
            this.btn_Find.AutoSize = true;
            this.btn_Find.Image = ((System.Drawing.Image)(resources.GetObject("btn_Find.Image")));
            this.btn_Find.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Find.Location = new System.Drawing.Point(427, 33);
            this.btn_Find.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(128, 54);
            this.btn_Find.TabIndex = 54;
            this.btn_Find.Text = "Tìm kiếm";
            this.btn_Find.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.AutoSize = true;
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(970, 33);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(108, 54);
            this.btn_Delete.TabIndex = 52;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // dtg_HoaDon
            // 
            this.dtg_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_HoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column7});
            this.dtg_HoaDon.Location = new System.Drawing.Point(12, 176);
            this.dtg_HoaDon.Name = "dtg_HoaDon";
            this.dtg_HoaDon.RowHeadersWidth = 51;
            this.dtg_HoaDon.RowTemplate.Height = 29;
            this.dtg_HoaDon.Size = new System.Drawing.Size(1105, 251);
            this.dtg_HoaDon.TabIndex = 55;
            this.dtg_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_HoaDon_CellClick);
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
            this.Column2.HeaderText = "MaHopDong";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "NgayTao";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "TongTien";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "TrangThai";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.btn_Find);
            this.groupBox1.Controls.Add(this.txt_MaHopDong);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1111, 352);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hợp đồng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtg_CTHoaDon);
            this.groupBox2.Location = new System.Drawing.Point(12, 433);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1105, 357);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hợp đồng chi tiết";
            // 
            // dtg_CTHoaDon
            // 
            this.dtg_CTHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_CTHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_CTHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column11,
            this.Column4});
            this.dtg_CTHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_CTHoaDon.Location = new System.Drawing.Point(3, 23);
            this.dtg_CTHoaDon.Name = "dtg_CTHoaDon";
            this.dtg_CTHoaDon.RowHeadersWidth = 51;
            this.dtg_CTHoaDon.RowTemplate.Height = 29;
            this.dtg_CTHoaDon.Size = new System.Drawing.Size(1099, 331);
            this.dtg_CTHoaDon.TabIndex = 0;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Id";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "MaPhong";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "TenDichVu";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // FrmQLHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 802);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtg_HoaDon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmQLHopDong";
            this.Text = "FrmQLHopDong";
            this.Load += new System.EventHandler(this.FrmQLHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_CTHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txt_MaHopDong;
        private Label label5;
        private Label label8;
        private Button btn_Find;
        private Button btn_Delete;
        private DataGridView dtg_HoaDon;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dtg_CTHoaDon;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column4;
    }
}