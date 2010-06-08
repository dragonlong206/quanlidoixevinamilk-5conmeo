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
            this.lsv_DanhSachXe = new System.Windows.Forms.ListView();
            this.Chon = new System.Windows.Forms.ColumnHeader();
            this.grb_TieuChiTimKiem = new System.Windows.Forms.GroupBox();
            this.chc_TimChinhXac = new System.Windows.Forms.CheckBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.txt_TenDiaDiem = new System.Windows.Forms.TextBox();
            this.lbl_TenDiaDiem = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.grb_KetQuaTongQuan = new System.Windows.Forms.GroupBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.chk_ChonTatCa = new System.Windows.Forms.CheckBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grb_TieuChiTimKiem.SuspendLayout();
            this.grb_KetQuaTongQuan.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsv_DanhSachXe
            // 
            this.lsv_DanhSachXe.CheckBoxes = true;
            this.lsv_DanhSachXe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Chon});
            this.lsv_DanhSachXe.FullRowSelect = true;
            this.lsv_DanhSachXe.Location = new System.Drawing.Point(6, 19);
            this.lsv_DanhSachXe.Name = "lsv_DanhSachXe";
            this.lsv_DanhSachXe.Size = new System.Drawing.Size(652, 260);
            this.lsv_DanhSachXe.TabIndex = 26;
            this.lsv_DanhSachXe.UseCompatibleStateImageBehavior = false;
            this.lsv_DanhSachXe.View = System.Windows.Forms.View.Details;
            // 
            // Chon
            // 
            this.Chon.Text = "Chọn";
            this.Chon.Width = 41;
            // 
            // grb_TieuChiTimKiem
            // 
            this.grb_TieuChiTimKiem.Controls.Add(this.chc_TimChinhXac);
            this.grb_TieuChiTimKiem.Controls.Add(this.txt_DiaChi);
            this.grb_TieuChiTimKiem.Controls.Add(this.lbl_DiaChi);
            this.grb_TieuChiTimKiem.Controls.Add(this.txt_TenDiaDiem);
            this.grb_TieuChiTimKiem.Controls.Add(this.lbl_TenDiaDiem);
            this.grb_TieuChiTimKiem.Controls.Add(this.btn_TimKiem);
            this.grb_TieuChiTimKiem.Location = new System.Drawing.Point(18, 50);
            this.grb_TieuChiTimKiem.Name = "grb_TieuChiTimKiem";
            this.grb_TieuChiTimKiem.Size = new System.Drawing.Size(664, 79);
            this.grb_TieuChiTimKiem.TabIndex = 0;
            this.grb_TieuChiTimKiem.TabStop = false;
            this.grb_TieuChiTimKiem.Text = "Tìm kiếm địa điểm";
            // 
            // chc_TimChinhXac
            // 
            this.chc_TimChinhXac.AutoSize = true;
            this.chc_TimChinhXac.Location = new System.Drawing.Point(17, 49);
            this.chc_TimChinhXac.Name = "chc_TimChinhXac";
            this.chc_TimChinhXac.Size = new System.Drawing.Size(94, 17);
            this.chc_TimChinhXac.TabIndex = 30;
            this.chc_TimChinhXac.Text = "Tì&m chính xác";
            this.chc_TimChinhXac.UseVisualStyleBackColor = true;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(416, 18);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(227, 20);
            this.txt_DiaChi.TabIndex = 1;
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
            // txt_TenDiaDiem
            // 
            this.txt_TenDiaDiem.Location = new System.Drawing.Point(99, 18);
            this.txt_TenDiaDiem.Name = "txt_TenDiaDiem";
            this.txt_TenDiaDiem.Size = new System.Drawing.Size(193, 20);
            this.txt_TenDiaDiem.TabIndex = 0;
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
            // 
            // grb_KetQuaTongQuan
            // 
            this.grb_KetQuaTongQuan.Controls.Add(this.btn_Xoa);
            this.grb_KetQuaTongQuan.Controls.Add(this.chk_ChonTatCa);
            this.grb_KetQuaTongQuan.Controls.Add(this.lsv_DanhSachXe);
            this.grb_KetQuaTongQuan.Location = new System.Drawing.Point(18, 135);
            this.grb_KetQuaTongQuan.Name = "grb_KetQuaTongQuan";
            this.grb_KetQuaTongQuan.Size = new System.Drawing.Size(664, 307);
            this.grb_KetQuaTongQuan.TabIndex = 1;
            this.grb_KetQuaTongQuan.TabStop = false;
            this.grb_KetQuaTongQuan.Text = "Danh sách địa điểm";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(583, 281);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 1;
            this.btn_Xoa.Text = "&Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
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
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(607, 448);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // XoaDiaDiemGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 482);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grb_TieuChiTimKiem);
            this.Controls.Add(this.grb_KetQuaTongQuan);
            this.Controls.Add(this.lbl_Title);
            this.Name = "XoaDiaDiemGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xoa dia diem";
            this.grb_TieuChiTimKiem.ResumeLayout(false);
            this.grb_TieuChiTimKiem.PerformLayout();
            this.grb_KetQuaTongQuan.ResumeLayout(false);
            this.grb_KetQuaTongQuan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsv_DanhSachXe;
        private System.Windows.Forms.ColumnHeader Chon;
        private System.Windows.Forms.GroupBox grb_TieuChiTimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.GroupBox grb_KetQuaTongQuan;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TextBox txt_TenDiaDiem;
        private System.Windows.Forms.Label lbl_TenDiaDiem;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.CheckBox chc_TimChinhXac;
        private System.Windows.Forms.CheckBox chk_ChonTatCa;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btnThoat;
    }
}