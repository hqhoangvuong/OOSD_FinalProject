namespace QuanLyTuyenSinh.PresentationLayer
{
    partial class QuanLynganh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLynganh));
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvnganh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl = new System.Windows.Forms.Panel();
            this.cmbDiemchuan = new System.Windows.Forms.ComboBox();
            this.cmbChitieu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTennganh = new System.Windows.Forms.ComboBox();
            this.lbMaNganh = new System.Windows.Forms.Label();
            this.cmbManganh = new System.Windows.Forms.ComboBox();
            this.lbTenNganh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnganh)).BeginInit();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnThoat.Location = new System.Drawing.Point(493, 146);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(59, 23);
            this.btnThoat.TabIndex = 44;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnhuy
            // 
            this.btnhuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhuy.BackgroundImage")));
            this.btnhuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnhuy.Location = new System.Drawing.Point(402, 146);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(58, 23);
            this.btnhuy.TabIndex = 43;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.BackgroundImage")));
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnLuu.Location = new System.Drawing.Point(306, 146);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(58, 23);
            this.btnLuu.TabIndex = 42;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnXoa.Location = new System.Drawing.Point(216, 146);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(61, 23);
            this.btnXoa.TabIndex = 41;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnThem.Location = new System.Drawing.Point(26, 146);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(58, 23);
            this.btnThem.TabIndex = 39;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvnganh
            // 
            this.dgvnganh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvnganh.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvnganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnganh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3});
            this.dgvnganh.Location = new System.Drawing.Point(18, 186);
            this.dgvnganh.Name = "dgvnganh";
            this.dgvnganh.Size = new System.Drawing.Size(607, 245);
            this.dgvnganh.TabIndex = 45;
            this.dgvnganh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnganh_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MANGANH";
            this.Column1.HeaderText = "Mã Ngành";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENNGANH";
            this.Column2.HeaderText = "Tên Ngành";
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "CHITIEU";
            this.Column5.HeaderText = "Chỉ Tiêu";
            this.Column5.Name = "Column5";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DIEMCHUAN";
            this.Column3.HeaderText = "Điểm Chuẩn";
            this.Column3.Name = "Column3";
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnSua.Location = new System.Drawing.Point(114, 146);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(58, 23);
            this.btnSua.TabIndex = 40;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Image = global::QuanLyTuyenSinh.Properties.Resources._43;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Location = new System.Drawing.Point(187, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 33);
            this.label2.TabIndex = 37;
            this.label2.Text = "Thông tin chi tiết";
            // 
            // pnl
            // 
            this.pnl.BackgroundImage = global::QuanLyTuyenSinh.Properties.Resources._431;
            this.pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl.Controls.Add(this.cmbDiemchuan);
            this.pnl.Controls.Add(this.cmbChitieu);
            this.pnl.Controls.Add(this.label3);
            this.pnl.Controls.Add(this.label1);
            this.pnl.Controls.Add(this.cmbTennganh);
            this.pnl.Controls.Add(this.lbMaNganh);
            this.pnl.Controls.Add(this.cmbManganh);
            this.pnl.Controls.Add(this.lbTenNganh);
            this.pnl.Location = new System.Drawing.Point(26, 59);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(558, 65);
            this.pnl.TabIndex = 46;
            // 
            // cmbDiemchuan
            // 
            this.cmbDiemchuan.FormattingEnabled = true;
            this.cmbDiemchuan.Location = new System.Drawing.Point(344, 32);
            this.cmbDiemchuan.Name = "cmbDiemchuan";
            this.cmbDiemchuan.Size = new System.Drawing.Size(163, 21);
            this.cmbDiemchuan.TabIndex = 13;
            // 
            // cmbChitieu
            // 
            this.cmbChitieu.FormattingEnabled = true;
            this.cmbChitieu.Location = new System.Drawing.Point(344, 5);
            this.cmbChitieu.Name = "cmbChitieu";
            this.cmbChitieu.Size = new System.Drawing.Size(163, 21);
            this.cmbChitieu.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(257, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Điểm Chuẩn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(257, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chỉ Tiêu";
            // 
            // cmbTennganh
            // 
            this.cmbTennganh.FormattingEnabled = true;
            this.cmbTennganh.Location = new System.Drawing.Point(88, 5);
            this.cmbTennganh.Name = "cmbTennganh";
            this.cmbTennganh.Size = new System.Drawing.Size(163, 21);
            this.cmbTennganh.TabIndex = 9;
            // 
            // lbMaNganh
            // 
            this.lbMaNganh.AutoSize = true;
            this.lbMaNganh.Image = ((System.Drawing.Image)(resources.GetObject("lbMaNganh.Image")));
            this.lbMaNganh.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbMaNganh.Location = new System.Drawing.Point(12, 35);
            this.lbMaNganh.Name = "lbMaNganh";
            this.lbMaNganh.Size = new System.Drawing.Size(57, 13);
            this.lbMaNganh.TabIndex = 6;
            this.lbMaNganh.Text = "Mã Ngành";
            // 
            // cmbManganh
            // 
            this.cmbManganh.FormattingEnabled = true;
            this.cmbManganh.Location = new System.Drawing.Point(88, 32);
            this.cmbManganh.Name = "cmbManganh";
            this.cmbManganh.Size = new System.Drawing.Size(163, 21);
            this.cmbManganh.TabIndex = 8;
            // 
            // lbTenNganh
            // 
            this.lbTenNganh.AutoSize = true;
            this.lbTenNganh.Image = ((System.Drawing.Image)(resources.GetObject("lbTenNganh.Image")));
            this.lbTenNganh.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbTenNganh.Location = new System.Drawing.Point(7, 10);
            this.lbTenNganh.Name = "lbTenNganh";
            this.lbTenNganh.Size = new System.Drawing.Size(61, 13);
            this.lbTenNganh.TabIndex = 5;
            this.lbTenNganh.Text = "Tên Ngành";
            // 
            // QuanLynganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyTuyenSinh.Properties.Resources._431;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 440);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvnganh);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label2);
            this.Name = "QuanLynganh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLynganh";
            this.Load += new System.EventHandler(this.QuanLynganh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnganh)).EndInit();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvnganh;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.ComboBox cmbDiemchuan;
        private System.Windows.Forms.ComboBox cmbChitieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTennganh;
        private System.Windows.Forms.Label lbMaNganh;
        private System.Windows.Forms.ComboBox cmbManganh;
        private System.Windows.Forms.Label lbTenNganh;
    }
}