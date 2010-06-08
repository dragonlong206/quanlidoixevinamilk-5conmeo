namespace GUI
{
    partial class LapHoaDonGiaoHangFrm
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
            this.lbl_NgayGiaoHang = new System.Windows.Forms.Label();
            this.lbl_XeDiGiaoHang = new System.Windows.Forms.Label();
            this.lbl_NgayLapHoaDon = new System.Windows.Forms.Label();
            this.txt_XeDiGiaoHang = new System.Windows.Forms.TextBox();
            this.grb_DanhSachGiaoHang = new System.Windows.Forms.GroupBox();
            this.dgv_DanhSachGiaoHang = new System.Windows.Forms.DataGridView();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.dtp_NgayGiaoHang = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgayLapHoaDon = new System.Windows.Forms.DateTimePicker();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTrangThai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.grb_DanhSachGiaoHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachGiaoHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Title.Location = new System.Drawing.Point(223, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(299, 25);
            this.lbl_Title.TabIndex = 12;
            this.lbl_Title.Text = "LẬP HÓA ĐƠN GIAO HÀNG";
            // 
            // lbl_NgayGiaoHang
            // 
            this.lbl_NgayGiaoHang.AutoSize = true;
            this.lbl_NgayGiaoHang.Location = new System.Drawing.Point(32, 56);
            this.lbl_NgayGiaoHang.Name = "lbl_NgayGiaoHang";
            this.lbl_NgayGiaoHang.Size = new System.Drawing.Size(82, 13);
            this.lbl_NgayGiaoHang.TabIndex = 13;
            this.lbl_NgayGiaoHang.Text = "Ngày giao hàng";
            // 
            // lbl_XeDiGiaoHang
            // 
            this.lbl_XeDiGiaoHang.AutoSize = true;
            this.lbl_XeDiGiaoHang.Location = new System.Drawing.Point(271, 55);
            this.lbl_XeDiGiaoHang.Name = "lbl_XeDiGiaoHang";
            this.lbl_XeDiGiaoHang.Size = new System.Drawing.Size(82, 13);
            this.lbl_XeDiGiaoHang.TabIndex = 14;
            this.lbl_XeDiGiaoHang.Text = "Xe đi giao hàng";
            // 
            // lbl_NgayLapHoaDon
            // 
            this.lbl_NgayLapHoaDon.AutoSize = true;
            this.lbl_NgayLapHoaDon.Location = new System.Drawing.Point(505, 55);
            this.lbl_NgayLapHoaDon.Name = "lbl_NgayLapHoaDon";
            this.lbl_NgayLapHoaDon.Size = new System.Drawing.Size(92, 13);
            this.lbl_NgayLapHoaDon.TabIndex = 15;
            this.lbl_NgayLapHoaDon.Text = "Ngày lập hóa đơn";
            // 
            // txt_XeDiGiaoHang
            // 
            this.txt_XeDiGiaoHang.Location = new System.Drawing.Point(372, 49);
            this.txt_XeDiGiaoHang.Name = "txt_XeDiGiaoHang";
            this.txt_XeDiGiaoHang.Size = new System.Drawing.Size(114, 20);
            this.txt_XeDiGiaoHang.TabIndex = 17;
            // 
            // grb_DanhSachGiaoHang
            // 
            this.grb_DanhSachGiaoHang.Controls.Add(this.dgv_DanhSachGiaoHang);
            this.grb_DanhSachGiaoHang.Location = new System.Drawing.Point(35, 88);
            this.grb_DanhSachGiaoHang.Name = "grb_DanhSachGiaoHang";
            this.grb_DanhSachGiaoHang.Size = new System.Drawing.Size(690, 349);
            this.grb_DanhSachGiaoHang.TabIndex = 19;
            this.grb_DanhSachGiaoHang.TabStop = false;
            this.grb_DanhSachGiaoHang.Text = "Danh sách giao hàng";
            // 
            // dgv_DanhSachGiaoHang
            // 
            this.dgv_DanhSachGiaoHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachGiaoHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaKhachHang,
            this.MaDiaDiem,
            this.MaMatHang,
            this.SoLuong,
            this.MaTrangThai});
            this.dgv_DanhSachGiaoHang.Location = new System.Drawing.Point(6, 19);
            this.dgv_DanhSachGiaoHang.Name = "dgv_DanhSachGiaoHang";
            this.dgv_DanhSachGiaoHang.Size = new System.Drawing.Size(678, 321);
            this.dgv_DanhSachGiaoHang.TabIndex = 0;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(554, 443);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 23);
            this.btn_Luu.TabIndex = 20;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(650, 443);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 21;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // dtp_NgayGiaoHang
            // 
            this.dtp_NgayGiaoHang.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayGiaoHang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayGiaoHang.Location = new System.Drawing.Point(136, 49);
            this.dtp_NgayGiaoHang.Name = "dtp_NgayGiaoHang";
            this.dtp_NgayGiaoHang.Size = new System.Drawing.Size(115, 20);
            this.dtp_NgayGiaoHang.TabIndex = 22;
            // 
            // dtp_NgayLapHoaDon
            // 
            this.dtp_NgayLapHoaDon.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayLapHoaDon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayLapHoaDon.Location = new System.Drawing.Point(613, 49);
            this.dtp_NgayLapHoaDon.Name = "dtp_NgayLapHoaDon";
            this.dtp_NgayLapHoaDon.Size = new System.Drawing.Size(112, 20);
            this.dtp_NgayLapHoaDon.TabIndex = 23;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 30;
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.HeaderText = "Khách hàng";
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.Width = 150;
            // 
            // MaDiaDiem
            // 
            this.MaDiaDiem.HeaderText = "Địa chỉ";
            this.MaDiaDiem.Name = "MaDiaDiem";
            this.MaDiaDiem.Width = 150;
            // 
            // MaMatHang
            // 
            this.MaMatHang.HeaderText = "Loại hàng";
            this.MaMatHang.Name = "MaMatHang";
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // MaTrangThai
            // 
            this.MaTrangThai.HeaderText = "Trạng Thái";
            this.MaTrangThai.Name = "MaTrangThai";
            this.MaTrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaTrangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // LapHoaDonGiaoHangFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 473);
            this.Controls.Add(this.dtp_NgayLapHoaDon);
            this.Controls.Add(this.dtp_NgayGiaoHang);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.grb_DanhSachGiaoHang);
            this.Controls.Add(this.txt_XeDiGiaoHang);
            this.Controls.Add(this.lbl_NgayLapHoaDon);
            this.Controls.Add(this.lbl_XeDiGiaoHang);
            this.Controls.Add(this.lbl_NgayGiaoHang);
            this.Controls.Add(this.lbl_Title);
            this.Name = "LapHoaDonGiaoHangFrm";
            this.Text = "LapHoaDonGiaoHangFrm";
            this.grb_DanhSachGiaoHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachGiaoHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_NgayGiaoHang;
        private System.Windows.Forms.Label lbl_XeDiGiaoHang;
        private System.Windows.Forms.Label lbl_NgayLapHoaDon;
        private System.Windows.Forms.TextBox txt_XeDiGiaoHang;
        private System.Windows.Forms.GroupBox grb_DanhSachGiaoHang;
        private System.Windows.Forms.DataGridView dgv_DanhSachGiaoHang;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.DateTimePicker dtp_NgayGiaoHang;
        private System.Windows.Forms.DateTimePicker dtp_NgayLapHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaTrangThai;
    }
}