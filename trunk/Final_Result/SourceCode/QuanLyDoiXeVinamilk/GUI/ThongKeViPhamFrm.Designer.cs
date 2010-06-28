namespace GUI
{
    partial class ThongKeViPhamFrm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.lsvDanhSachViPham = new System.Windows.Forms.ListView();
            this.STT = new System.Windows.Forms.ColumnHeader();
            this.MaHopDen = new System.Windows.Forms.ColumnHeader();
            this.TenTaiXe = new System.Windows.Forms.ColumnHeader();
            this.ThoiGian = new System.Windows.Forms.ColumnHeader();
            this.NoiDung = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Location = new System.Drawing.Point(56, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(452, 25);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "DANH SÁCH XE VI PHẠM CÁC QUY ĐỊNH";
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Location = new System.Drawing.Point(61, 47);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(46, 13);
            this.lblNgayBatDau.TabIndex = 10;
            this.lblNgayBatDau.Text = "Từ ngày";
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.Location = new System.Drawing.Point(292, 47);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(53, 13);
            this.lblNgayKetThuc.TabIndex = 10;
            this.lblNgayKetThuc.Text = "Đến ngày";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(144, 43);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(120, 20);
            this.dtpNgayBatDau.TabIndex = 11;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(388, 43);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(120, 20);
            this.dtpNgayKetThuc.TabIndex = 11;
            // 
            // lsvDanhSachViPham
            // 
            this.lsvDanhSachViPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvDanhSachViPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.MaHopDen,
            this.TenTaiXe,
            this.ThoiGian,
            this.NoiDung});
            this.lsvDanhSachViPham.FullRowSelect = true;
            this.lsvDanhSachViPham.GridLines = true;
            this.lsvDanhSachViPham.Location = new System.Drawing.Point(13, 75);
            this.lsvDanhSachViPham.Name = "lsvDanhSachViPham";
            this.lsvDanhSachViPham.Size = new System.Drawing.Size(536, 310);
            this.lsvDanhSachViPham.TabIndex = 12;
            this.lsvDanhSachViPham.UseCompatibleStateImageBehavior = false;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            // 
            // MaHopDen
            // 
            this.MaHopDen.Text = "Mã hộp đen";
            // 
            // TenTaiXe
            // 
            this.TenTaiXe.Text = "Tên tài xế";
            // 
            // ThoiGian
            // 
            this.ThoiGian.Text = "Thời gian";
            // 
            // NoiDung
            // 
            this.NoiDung.Text = "Nội dung vi phạm";
            // 
            // ThongKeViPhamFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 438);
            this.Controls.Add(this.lsvDanhSachViPham);
            this.Controls.Add(this.dtpNgayKetThuc);
            this.Controls.Add(this.dtpNgayBatDau);
            this.Controls.Add(this.lblNgayKetThuc);
            this.Controls.Add(this.lblNgayBatDau);
            this.Controls.Add(this.lblTitle);
            this.Name = "ThongKeViPhamFrm";
            this.Text = "Thong ke xe vi pham";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.Label lblNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader MaHopDen;
        private System.Windows.Forms.ColumnHeader TenTaiXe;
        private System.Windows.Forms.ColumnHeader ThoiGian;
        private System.Windows.Forms.ColumnHeader NoiDung;
        private System.Windows.Forms.ListView lsvDanhSachViPham;
    }
}