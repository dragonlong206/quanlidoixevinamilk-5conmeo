namespace GUI
{
    partial class XoaNhanVienGUI
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
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_TimChinhXac = new System.Windows.Forms.CheckBox();
            this.txt_TenNhanVien_TimKiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_TimNhanVien = new System.Windows.Forms.Button();
            this.grb_DanhSachNhanVien = new System.Windows.Forms.GroupBox();
            this.chk_ChonTatCa = new System.Windows.Forms.CheckBox();
            this.lsv_DanhSachNhanVien = new System.Windows.Forms.ListView();
            this.STT = new System.Windows.Forms.ColumnHeader();
            this.TenNhanVien = new System.Windows.Forms.ColumnHeader();
            this.LoaiNhanVien = new System.Windows.Forms.ColumnHeader();
            this.DienThoai = new System.Windows.Forms.ColumnHeader();
            this.NgayVaoCongTy = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.grb_DanhSachNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(417, 263);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 0;
            this.btn_Xoa.Text = "&Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(429, 433);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 1;
            this.btn_Thoat.Text = "&Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Location = new System.Drawing.Point(175, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(174, 24);
            this.lblTitle.TabIndex = 39;
            this.lblTitle.Text = "XÓA NHÂN VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_TimChinhXac);
            this.groupBox1.Controls.Add(this.txt_TenNhanVien_TimKiem);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_TimNhanVien);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 69);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // chk_TimChinhXac
            // 
            this.chk_TimChinhXac.AutoSize = true;
            this.chk_TimChinhXac.Location = new System.Drawing.Point(389, 36);
            this.chk_TimChinhXac.Name = "chk_TimChinhXac";
            this.chk_TimChinhXac.Size = new System.Drawing.Size(94, 17);
            this.chk_TimChinhXac.TabIndex = 32;
            this.chk_TimChinhXac.Text = "Tì&m chính xác";
            this.chk_TimChinhXac.UseVisualStyleBackColor = true;
            // 
            // txt_TenNhanVien_TimKiem
            // 
            this.txt_TenNhanVien_TimKiem.Location = new System.Drawing.Point(118, 34);
            this.txt_TenNhanVien_TimKiem.Name = "txt_TenNhanVien_TimKiem";
            this.txt_TenNhanVien_TimKiem.Size = new System.Drawing.Size(142, 20);
            this.txt_TenNhanVien_TimKiem.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Họ tên nhân viên";
            // 
            // btn_TimNhanVien
            // 
            this.btn_TimNhanVien.Location = new System.Drawing.Point(295, 32);
            this.btn_TimNhanVien.Name = "btn_TimNhanVien";
            this.btn_TimNhanVien.Size = new System.Drawing.Size(75, 23);
            this.btn_TimNhanVien.TabIndex = 1;
            this.btn_TimNhanVien.Text = "Tìm";
            this.btn_TimNhanVien.UseVisualStyleBackColor = true;
            this.btn_TimNhanVien.Click += new System.EventHandler(this.btn_TimNhanVien_Click);
            // 
            // grb_DanhSachNhanVien
            // 
            this.grb_DanhSachNhanVien.Controls.Add(this.chk_ChonTatCa);
            this.grb_DanhSachNhanVien.Controls.Add(this.lsv_DanhSachNhanVien);
            this.grb_DanhSachNhanVien.Controls.Add(this.btn_Xoa);
            this.grb_DanhSachNhanVien.Location = new System.Drawing.Point(12, 135);
            this.grb_DanhSachNhanVien.Name = "grb_DanhSachNhanVien";
            this.grb_DanhSachNhanVien.Size = new System.Drawing.Size(506, 292);
            this.grb_DanhSachNhanVien.TabIndex = 40;
            this.grb_DanhSachNhanVien.TabStop = false;
            this.grb_DanhSachNhanVien.Text = "Danh sách nhân viên";
            // 
            // chk_ChonTatCa
            // 
            this.chk_ChonTatCa.AutoSize = true;
            this.chk_ChonTatCa.Location = new System.Drawing.Point(18, 267);
            this.chk_ChonTatCa.Name = "chk_ChonTatCa";
            this.chk_ChonTatCa.Size = new System.Drawing.Size(81, 17);
            this.chk_ChonTatCa.TabIndex = 33;
            this.chk_ChonTatCa.Text = "Chọn tất cả";
            this.chk_ChonTatCa.UseVisualStyleBackColor = true;
            this.chk_ChonTatCa.CheckedChanged += new System.EventHandler(this.chk_ChonTatCa_CheckedChanged);
            // 
            // lsv_DanhSachNhanVien
            // 
            this.lsv_DanhSachNhanVien.CheckBoxes = true;
            this.lsv_DanhSachNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.TenNhanVien,
            this.LoaiNhanVien,
            this.DienThoai,
            this.NgayVaoCongTy});
            this.lsv_DanhSachNhanVien.FullRowSelect = true;
            this.lsv_DanhSachNhanVien.GridLines = true;
            this.lsv_DanhSachNhanVien.Location = new System.Drawing.Point(3, 16);
            this.lsv_DanhSachNhanVien.Name = "lsv_DanhSachNhanVien";
            this.lsv_DanhSachNhanVien.Size = new System.Drawing.Size(500, 241);
            this.lsv_DanhSachNhanVien.TabIndex = 1;
            this.lsv_DanhSachNhanVien.UseCompatibleStateImageBehavior = false;
            this.lsv_DanhSachNhanVien.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 50;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.Text = "Tên Nhân Viên";
            this.TenNhanVien.Width = 130;
            // 
            // LoaiNhanVien
            // 
            this.LoaiNhanVien.Text = "Loại Nhân Viên";
            this.LoaiNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoaiNhanVien.Width = 102;
            // 
            // DienThoai
            // 
            this.DienThoai.Text = "Điện Thoại";
            this.DienThoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DienThoai.Width = 88;
            // 
            // NgayVaoCongTy
            // 
            this.NgayVaoCongTy.Text = "Ngày Vào Công Ty";
            this.NgayVaoCongTy.Width = 119;
            // 
            // XoaNhanVienGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grb_DanhSachNhanVien);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.Name = "XoaNhanVienGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xoa nhan vien";
            this.Load += new System.EventHandler(this.XoaNhanVienGUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grb_DanhSachNhanVien.ResumeLayout(false);
            this.grb_DanhSachNhanVien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_TimChinhXac;
        private System.Windows.Forms.TextBox txt_TenNhanVien_TimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_TimNhanVien;
        private System.Windows.Forms.GroupBox grb_DanhSachNhanVien;
        private System.Windows.Forms.ListView lsv_DanhSachNhanVien;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader TenNhanVien;
        private System.Windows.Forms.ColumnHeader LoaiNhanVien;
        private System.Windows.Forms.ColumnHeader DienThoai;
        private System.Windows.Forms.ColumnHeader NgayVaoCongTy;
        private System.Windows.Forms.CheckBox chk_ChonTatCa;
    }
}