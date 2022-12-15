namespace C_PL.Views
{
    partial class FrmQLDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQLDichVu));
            this.dtg_Show = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Find = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Show
            // 
            this.dtg_Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Show.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dtg_Show.Location = new System.Drawing.Point(24, 306);
            this.dtg_Show.Name = "dtg_Show";
            this.dtg_Show.RowHeadersWidth = 51;
            this.dtg_Show.RowTemplate.Height = 29;
            this.dtg_Show.Size = new System.Drawing.Size(985, 293);
            this.dtg_Show.TabIndex = 75;
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
            this.Column2.HeaderText = "Ten";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DonGia";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // btn_Find
            // 
            this.btn_Find.AutoSize = true;
            this.btn_Find.Image = ((System.Drawing.Image)(resources.GetObject("btn_Find.Image")));
            this.btn_Find.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Find.Location = new System.Drawing.Point(825, 229);
            this.btn_Find.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(128, 54);
            this.btn_Find.TabIndex = 74;
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
            this.btn_Save.Location = new System.Drawing.Point(646, 229);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(99, 54);
            this.btn_Save.TabIndex = 73;
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
            this.btn_Delete.Location = new System.Drawing.Point(443, 229);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(108, 54);
            this.btn_Delete.TabIndex = 72;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.AutoSize = true;
            this.btn_Update.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.Image")));
            this.btn_Update.Location = new System.Drawing.Point(252, 229);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(92, 54);
            this.btn_Update.TabIndex = 71;
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
            this.btn_Add.Location = new System.Drawing.Point(59, 229);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(105, 54);
            this.btn_Add.TabIndex = 70;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(202, 99);
            this.txt_Ten.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(241, 27);
            this.txt_Ten.TabIndex = 62;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Enabled = false;
            this.txt_DonGia.Location = new System.Drawing.Point(203, 161);
            this.txt_DonGia.Margin = new System.Windows.Forms.Padding(2);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(241, 27);
            this.txt_DonGia.TabIndex = 61;
            this.txt_DonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DonGia_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Đơn giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(323, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(358, 46);
            this.label8.TabIndex = 56;
            this.label8.Text = "DANH MỤC DỊCH VỤ";
            // 
            // FrmQLDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 620);
            this.Controls.Add(this.dtg_Show);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_Ten);
            this.Controls.Add(this.txt_DonGia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Name = "FrmQLDichVu";
            this.Text = "FrmQLDichVu";
            this.Load += new System.EventHandler(this.FrmQLDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtg_Show;
        private Button btn_Find;
        private Button btn_Save;
        private Button btn_Delete;
        private Button btn_Update;
        private Button btn_Add;
        private TextBox txt_Ten;
        private TextBox txt_DonGia;
        private Label label5;
        private Label label4;
        private Label label8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}