namespace GUI
{
    partial class XoaDiaDiemGUI
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
            this.lsv_DanhSachDiaDiem = new System.Windows.Forms.ListView();
            this.STT = new System.Windows.Forms.ColumnHeader();
            this.TenDiaDiem = new System.Windows.Forms.ColumnHeader();
            this.LoaiDiaDiem = new System.Windows.Forms.ColumnHeader();
            this.DienThoai = new System.Windows.Forms.ColumnHeader();
            this.DiaChi = new System.Windows.Forms.ColumnHeader();
            this.grb_TieuChiTimKiem = new System.Windows.Forms.GroupBox();
            this.chk_TimChinhXac = new System.Windows.Forms.CheckBox();
            this.txt_DiaChi_TimKiem = new System.Windows.Forms.TextBox();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.txt_TenDiaDiem_TimKiem = new System.Windows.Forms.TextBox();
            this.lbl_TenDiaDiem = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.grb_KetQuaTongQuan = new System.Windows.Forms.GroupBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.chk_ChonTatCa = new System.Windows.Forms.CheckBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.grb_TieuChiTimKiem.SuspendLayout();
            this.grb_KetQuaTongQuan.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsv_DanhSachDiaDiem
            // 
            this.lsv_DanhSachDiaDiem.CheckBoxes = true;
            this.lsv_DanhSachDiaDiem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.TenDiaDiem,
            this.LoaiDiaDiem,
            this.DienThoai,
            this.DiaChi});
            this.lsv_DanhSachDiaDiem.FullRowSelect = true;
            this.lsv_DanhSachDiaDiem.GridLines = true;
            this.lsv_DanhSachDiaDiem.Location = new System.Drawing.Point(6, 19);
            this.lsv_DanhSachDiaDiem.Name = "lsv_DanhSachDiaDiem";
            this.lsv_DanhSachDiaDiem.Size = new System.Drawing.Size(652, 260);
            this.lsv_DanhSachDiaDiem.TabIndex = 26;
            this.lsv_DanhSachDiaDiem.UseCompatibleStateImageBehavior = false;
            this.lsv_DanhSachDiaDiem.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 50;
            // 
            // TenDiaDiem
            // 
            this.TenDiaDiem.Text = "Tên Địa Điểm";
            this.TenDiaDiem.Width = 130;
            // 
            // LoaiDiaDiem
            // 
            this.LoaiDiaDiem.Text = "Loại Địa Điểm";
            this.LoaiDiaDiem.Width = 110;
            // 
            // DienThoai
            // 
            this.DienThoai.Text = "Điện Thoại";
            this.DienThoai.Width = 100;
            // 
            // DiaChi
            // 
            this.DiaChi.Text = "Địa Chỉ";
            this.DiaChi.Width = 250;
            // 
            // grb_TieuChiTimKiem
            // 
            this.grb_TieuChiTimKiem.Controls.Add(this.chk_TimChinhXac);
            this.grb_TieuChiTimKiem.Controls.Add(this.txt_DiaChi_TimKiem);
            this.grb_TieuChiTimKiem.Controls.Add(this.lbl_DiaChi);
            this.grb_TieuChiTimKiem.Controls.Add(this.txt_TenDiaDiem_TimKiem);
            this.grb_TieuChiTimKiem.Controls.Add(this.lbl_TenDiaDiem);
            this.grb_TieuChiTimKiem.Controls.Add(this.btn_TimKiem);
            this.grb_TieuChiTimKiem.Location = new System.Drawing.Point(18, 50);
            this.grb_TieuChiTimKiem.Name = "grb_TieuChiTimKiem";
            this.grb_TieuChiTimKiem.Size = new System.Drawing.Size(664, 79);
            this.grb_TieuChiTimKiem.TabIndex = 0;
            this.grb_TieuChiTimKiem.TabStop = false;
            this.grb_TieuChiTimKiem.Text = "Tìm kiếm địa điểm";
            // 
            // chk_TimChinhXac
            // 
            this.chk_TimChinhXac.AutoSize = true;
            this.chk_TimChinhXac.Location = new System.Drawing.Point(17, 49);
            this.chk_TimChinhXac.Name = "chk_TimChinhXac";
            this.chk_TimChinhXac.Size = new System.Drawing.Size(94, 17);
            this.chk_TimChinhXac.TabIndex = 30;
            this.chk_TimChinhXac.Text = "Tì&m chính xác";
            this.chk_TimChinhXac.UseVisualStyleBackColor = true;
            // 
            // txt_DiaChi_TimKiem
            // 
            this.txt_DiaChi_TimKiem.Location = new System.Drawing.Point(416, 18);
            this.txt_DiaChi_TimKiem.Name = "txt_DiaChi_TimKiem";
            this.txt_DiaChi_TimKiem.Size = new System.Drawing.Size(227, 20);
            this.txt_DiaChi_TimKiem.TabIndex = 1;
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Location = new System.Drawing.Point(351, 21);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(40, 13);
            this.lbl_DiaChi.TabIndex = 28;
            this.lbl_DiaChi.Text = "Địa chỉ";
            // 
            // txt_TenDiaDiem_TimKiem
            // 
            this.txt_TenDiaDiem_TimKiem.Location = new System.Drawing.Point(99, 18);
            this.txt_TenDiaDiem_TimKiem.Name = "txt_TenDiaDiem_TimKiem";
            this.txt_TenDiaDiem_TimKiem.Size = new System.Drawing.Size(193, 20);
            this.txt_TenDiaDiem_TimKiem.TabIndex = 0;
            // 
            // lbl_TenDiaDiem
            // 
            this.lbl_TenDiaDiem.AutoSize = true;
            this.lbl_TenDiaDiem.Location = new System.Drawing.Point(14, 21);
            this.lbl_TenDiaDiem.Name = "lbl_TenDiaDiem";
            this.lbl_TenDiaDiem.Size = new System.Drawing.Size(70, 13);
            this.lbl_TenDiaDiem.TabIndex = 26;
            this.lbl_TenDiaDiem.Text = "Tên địa điểm";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackgroundImage = global::GUI.Properties.Resources.Search;
            this.btn_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_TimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TimKiem.Location = new System.Drawing.Point(294, 49);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(70, 24);
            this.btn_TimKiem.TabIndex = 2;
            this.btn_TimKiem.TabStop = false;
            this.btn_TimKiem.Text = "T&ìm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // grb_KetQuaTongQuan
            // 
            this.grb_KetQuaTongQuan.Controls.Add(this.btn_Xoa);
            this.grb_KetQuaTongQuan.Controls.Add(this.chk_ChonTatCa);
            this.grb_KetQuaTongQuan.Controls.Add(this.lsv_DanhSachDiaDiem);
            this.grb_KetQuaTongQuan.Location = new System.Drawing.Point(18, 135);
            this.grb_KetQuaTongQuan.Name = "grb_KetQuaTongQuan";
            this.grb_KetQuaTongQuan.Size = new System.Drawing.Size(664, 314);
            this.grb_KetQuaTongQuan.TabIndex = 1;
            this.grb_KetQuaTongQuan.TabStop = false;
            this.grb_KetQuaTongQuan.Text = "Danh sách địa điểm";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(583, 285);
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
            this.chk_ChonTatCa.Location = new System.Drawing.Point(6, 289);
            this.chk_ChonTatCa.Name = "chk_ChonTatCa";
            this.chk_ChonTatCa.Size = new System.Drawing.Size(81, 17);
            this.chk_ChonTatCa.TabIndex = 0;
            this.chk_ChonTatCa.Text = "Chọn tất &cả";
            this.chk_ChonTatCa.UseVisualStyleBackColor = true;
            this.chk_ChonTatCa.CheckedChanged += new System.EventHandler(this.chk_ChonTatCa_CheckedChanged);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Title.Location = new System.Drawing.Point(259, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(166, 25);
            this.lbl_Title.TabIndex = 27;
            this.lbl_Title.Text = "XÓA ĐỊA ĐIỂM";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(601, 455);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "&Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // XoaDiaDiemGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 484);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.grb_TieuChiTimKiem);
            this.Controls.Add(this.grb_KetQuaTongQuan);
            this.Controls.Add(this.lbl_Title);
            this.Name = "XoaDiaDiemGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xoa dia diem";
            this.Load += new System.EventHandler(this.XoaDiaDiemGUI_Load);
            this.grb_TieuChiTimKiem.ResumeLayout(false);
            this.grb_TieuChiTimKiem.PerformLayout();
            this.grb_KetQuaTongQuan.ResumeLayout(false);
            this.grb_KetQuaTongQuan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsv_DanhSachDiaDiem;
        private System.Windows.Forms.GroupBox grb_TieuChiTimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.GroupBox grb_KetQuaTongQuan;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TextBox txt_TenDiaDiem_TimKiem;
        private System.Windows.Forms.Label lbl_TenDiaDiem;
        private System.Windows.Forms.TextBox txt_DiaChi_TimKiem;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.CheckBox chk_TimChinhXac;
        private System.Windows.Forms.CheckBox chk_ChonTatCa;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader TenDiaDiem;
        private System.Windows.Forms.ColumnHeader LoaiDiaDiem;
        private System.Windows.Forms.ColumnHeader DienThoai;
        private System.Windows.Forms.ColumnHeader DiaChi;
    }
}