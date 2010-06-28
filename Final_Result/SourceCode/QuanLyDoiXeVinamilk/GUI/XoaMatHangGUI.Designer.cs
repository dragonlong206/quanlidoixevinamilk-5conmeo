namespace GUI
{
    partial class XoaMatHangGUI
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.grb_TieuChiTimKiem = new System.Windows.Forms.GroupBox();
            this.chk_TimChinhXac = new System.Windows.Forms.CheckBox();
            this.txt_TenMatHang_TimKiem = new System.Windows.Forms.TextBox();
            this.lbl_TenMatHang = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.grb_DanhSachMatHang = new System.Windows.Forms.GroupBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.chk_ChonTatCa = new System.Windows.Forms.CheckBox();
            this.lsv_DanhSachMatHang = new System.Windows.Forms.ListView();
            this.STT = new System.Windows.Forms.ColumnHeader();
            this.TenMatHang = new System.Windows.Forms.ColumnHeader();
            this.SoLuong = new System.Windows.Forms.ColumnHeader();
            this.DonVi = new System.Windows.Forms.ColumnHeader();
            this.LoaiHang = new System.Windows.Forms.ColumnHeader();
            this.grb_TieuChiTimKiem.SuspendLayout();
            this.grb_DanhSachMatHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Title.Location = new System.Drawing.Point(173, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(185, 25);
            this.lbl_Title.TabIndex = 28;
            this.lbl_Title.Text = "XÓA MẶT HÀNG";
            // 
            // grb_TieuChiTimKiem
            // 
            this.grb_TieuChiTimKiem.Controls.Add(this.chk_TimChinhXac);
            this.grb_TieuChiTimKiem.Controls.Add(this.txt_TenMatHang_TimKiem);
            this.grb_TieuChiTimKiem.Controls.Add(this.lbl_TenMatHang);
            this.grb_TieuChiTimKiem.Controls.Add(this.btn_TimKiem);
            this.grb_TieuChiTimKiem.Location = new System.Drawing.Point(6, 54);
            this.grb_TieuChiTimKiem.Name = "grb_TieuChiTimKiem";
            this.grb_TieuChiTimKiem.Size = new System.Drawing.Size(498, 71);
            this.grb_TieuChiTimKiem.TabIndex = 36;
            this.grb_TieuChiTimKiem.TabStop = false;
            this.grb_TieuChiTimKiem.Text = "Tìm kiếm mặt hàng";
            // 
            // chk_TimChinhXac
            // 
            this.chk_TimChinhXac.AutoSize = true;
            this.chk_TimChinhXac.Location = new System.Drawing.Point(393, 34);
            this.chk_TimChinhXac.Name = "chk_TimChinhXac";
            this.chk_TimChinhXac.Size = new System.Drawing.Size(94, 17);
            this.chk_TimChinhXac.TabIndex = 32;
            this.chk_TimChinhXac.Text = "Tì&m chính xác";
            this.chk_TimChinhXac.UseVisualStyleBackColor = true;
            // 
            // txt_TenMatHang_TimKiem
            // 
            this.txt_TenMatHang_TimKiem.Location = new System.Drawing.Point(85, 32);
            this.txt_TenMatHang_TimKiem.Name = "txt_TenMatHang_TimKiem";
            this.txt_TenMatHang_TimKiem.Size = new System.Drawing.Size(193, 20);
            this.txt_TenMatHang_TimKiem.TabIndex = 0;
            // 
            // lbl_TenMatHang
            // 
            this.lbl_TenMatHang.AutoSize = true;
            this.lbl_TenMatHang.Location = new System.Drawing.Point(6, 35);
            this.lbl_TenMatHang.Name = "lbl_TenMatHang";
            this.lbl_TenMatHang.Size = new System.Drawing.Size(73, 13);
            this.lbl_TenMatHang.TabIndex = 31;
            this.lbl_TenMatHang.Text = "Tên mặt hàng";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackgroundImage = global::GUI.Properties.Resources.Search;
            this.btn_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_TimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TimKiem.Location = new System.Drawing.Point(297, 29);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(70, 24);
            this.btn_TimKiem.TabIndex = 2;
            this.btn_TimKiem.TabStop = false;
            this.btn_TimKiem.Text = "T&ìm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(429, 444);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 35;
            this.btn_Thoat.Text = "&Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // grb_DanhSachMatHang
            // 
            this.grb_DanhSachMatHang.Controls.Add(this.btn_Xoa);
            this.grb_DanhSachMatHang.Controls.Add(this.chk_ChonTatCa);
            this.grb_DanhSachMatHang.Controls.Add(this.lsv_DanhSachMatHang);
            this.grb_DanhSachMatHang.Location = new System.Drawing.Point(6, 131);
            this.grb_DanhSachMatHang.Name = "grb_DanhSachMatHang";
            this.grb_DanhSachMatHang.Size = new System.Drawing.Size(504, 307);
            this.grb_DanhSachMatHang.TabIndex = 34;
            this.grb_DanhSachMatHang.TabStop = false;
            this.grb_DanhSachMatHang.Text = "Danh sách mặt hàng";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(423, 281);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 1;
            this.btn_Xoa.Text = "&Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // chk_ChonTatCa
            // 
            this.chk_ChonTatCa.AutoSize = true;
            this.chk_ChonTatCa.Location = new System.Drawing.Point(6, 285);
            this.chk_ChonTatCa.Name = "chk_ChonTatCa";
            this.chk_ChonTatCa.Size = new System.Drawing.Size(81, 17);
            this.chk_ChonTatCa.TabIndex = 0;
            this.chk_ChonTatCa.Text = "Chọn tất &cả";
            this.chk_ChonTatCa.UseVisualStyleBackColor = true;
            this.chk_ChonTatCa.CheckedChanged += new System.EventHandler(this.chk_ChonTatCa_CheckedChanged);
            // 
            // lsv_DanhSachMatHang
            // 
            this.lsv_DanhSachMatHang.CheckBoxes = true;
            this.lsv_DanhSachMatHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.TenMatHang,
            this.SoLuong,
            this.DonVi,
            this.LoaiHang});
            this.lsv_DanhSachMatHang.FullRowSelect = true;
            this.lsv_DanhSachMatHang.GridLines = true;
            this.lsv_DanhSachMatHang.Location = new System.Drawing.Point(6, 19);
            this.lsv_DanhSachMatHang.Name = "lsv_DanhSachMatHang";
            this.lsv_DanhSachMatHang.Size = new System.Drawing.Size(492, 260);
            this.lsv_DanhSachMatHang.TabIndex = 26;
            this.lsv_DanhSachMatHang.UseCompatibleStateImageBehavior = false;
            this.lsv_DanhSachMatHang.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 59;
            // 
            // TenMatHang
            // 
            this.TenMatHang.Text = "Tên Mặt Hàng";
            this.TenMatHang.Width = 134;
            // 
            // SoLuong
            // 
            this.SoLuong.Text = "Số Lượng";
            this.SoLuong.Width = 89;
            // 
            // DonVi
            // 
            this.DonVi.Text = "Đơn Vị";
            this.DonVi.Width = 85;
            // 
            // LoaiHang
            // 
            this.LoaiHang.Text = "Loại Hàng";
            this.LoaiHang.Width = 110;
            // 
            // XoaMatHangGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 476);
            this.Controls.Add(this.grb_TieuChiTimKiem);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.grb_DanhSachMatHang);
            this.Controls.Add(this.lbl_Title);
            this.MaximizeBox = false;
            this.Name = "XoaMatHangGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xoa mat hang";
            this.Load += new System.EventHandler(this.XoaMatHangGUI_Load);
            this.grb_TieuChiTimKiem.ResumeLayout(false);
            this.grb_TieuChiTimKiem.PerformLayout();
            this.grb_DanhSachMatHang.ResumeLayout(false);
            this.grb_DanhSachMatHang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox grb_TieuChiTimKiem;
        private System.Windows.Forms.CheckBox chk_TimChinhXac;
        private System.Windows.Forms.TextBox txt_TenMatHang_TimKiem;
        private System.Windows.Forms.Label lbl_TenMatHang;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.GroupBox grb_DanhSachMatHang;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.CheckBox chk_ChonTatCa;
        private System.Windows.Forms.ListView lsv_DanhSachMatHang;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader TenMatHang;
        private System.Windows.Forms.ColumnHeader SoLuong;
        private System.Windows.Forms.ColumnHeader DonVi;
        private System.Windows.Forms.ColumnHeader LoaiHang;
    }
}