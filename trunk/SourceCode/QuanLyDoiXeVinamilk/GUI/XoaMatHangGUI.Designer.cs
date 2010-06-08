namespace GUI
{
    partial class frm_XoaMatHang
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
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.grb_DanhSachMatHang = new System.Windows.Forms.GroupBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.chk_ChonTatCa = new System.Windows.Forms.CheckBox();
            this.lsv_DanhSachXe = new System.Windows.Forms.ListView();
            this.Chon = new System.Windows.Forms.ColumnHeader();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.grb_TieuChiTimKiem = new System.Windows.Forms.GroupBox();
            this.chc_TimChinhXac = new System.Windows.Forms.CheckBox();
            this.txt_TenMatHang_TimKiem = new System.Windows.Forms.TextBox();
            this.lbl_TenMatHang = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.grb_DanhSachMatHang.SuspendLayout();
            this.grb_TieuChiTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(441, 422);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 4;
            this.btn_Thoat.Text = "&Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // grb_DanhSachMatHang
            // 
            this.grb_DanhSachMatHang.Controls.Add(this.btn_Xoa);
            this.grb_DanhSachMatHang.Controls.Add(this.chk_ChonTatCa);
            this.grb_DanhSachMatHang.Controls.Add(this.lsv_DanhSachXe);
            this.grb_DanhSachMatHang.Location = new System.Drawing.Point(12, 109);
            this.grb_DanhSachMatHang.Name = "grb_DanhSachMatHang";
            this.grb_DanhSachMatHang.Size = new System.Drawing.Size(504, 307);
            this.grb_DanhSachMatHang.TabIndex = 3;
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
            // lsv_DanhSachXe
            // 
            this.lsv_DanhSachXe.CheckBoxes = true;
            this.lsv_DanhSachXe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Chon});
            this.lsv_DanhSachXe.FullRowSelect = true;
            this.lsv_DanhSachXe.Location = new System.Drawing.Point(6, 19);
            this.lsv_DanhSachXe.Name = "lsv_DanhSachXe";
            this.lsv_DanhSachXe.Size = new System.Drawing.Size(492, 260);
            this.lsv_DanhSachXe.TabIndex = 26;
            this.lsv_DanhSachXe.UseCompatibleStateImageBehavior = false;
            this.lsv_DanhSachXe.View = System.Windows.Forms.View.Details;
            // 
            // Chon
            // 
            this.Chon.Text = "Chọn";
            this.Chon.Width = 41;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Title.Location = new System.Drawing.Point(176, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(185, 25);
            this.lbl_Title.TabIndex = 28;
            this.lbl_Title.Text = "XÓA MẶT HÀNG";
            // 
            // grb_TieuChiTimKiem
            // 
            this.grb_TieuChiTimKiem.Controls.Add(this.chc_TimChinhXac);
            this.grb_TieuChiTimKiem.Controls.Add(this.txt_TenMatHang_TimKiem);
            this.grb_TieuChiTimKiem.Controls.Add(this.lbl_TenMatHang);
            this.grb_TieuChiTimKiem.Controls.Add(this.btn_TimKiem);
            this.grb_TieuChiTimKiem.Location = new System.Drawing.Point(18, 49);
            this.grb_TieuChiTimKiem.Name = "grb_TieuChiTimKiem";
            this.grb_TieuChiTimKiem.Size = new System.Drawing.Size(498, 54);
            this.grb_TieuChiTimKiem.TabIndex = 33;
            this.grb_TieuChiTimKiem.TabStop = false;
            this.grb_TieuChiTimKiem.Text = "Tìm kiếm mặt hàng";
            // 
            // chc_TimChinhXac
            // 
            this.chc_TimChinhXac.AutoSize = true;
            this.chc_TimChinhXac.Location = new System.Drawing.Point(395, 22);
            this.chc_TimChinhXac.Name = "chc_TimChinhXac";
            this.chc_TimChinhXac.Size = new System.Drawing.Size(94, 17);
            this.chc_TimChinhXac.TabIndex = 32;
            this.chc_TimChinhXac.Text = "Tì&m chính xác";
            this.chc_TimChinhXac.UseVisualStyleBackColor = true;
            // 
            // txt_TenMatHang_TimKiem
            // 
            this.txt_TenMatHang_TimKiem.Location = new System.Drawing.Point(87, 20);
            this.txt_TenMatHang_TimKiem.Name = "txt_TenMatHang_TimKiem";
            this.txt_TenMatHang_TimKiem.Size = new System.Drawing.Size(193, 20);
            this.txt_TenMatHang_TimKiem.TabIndex = 0;
            // 
            // lbl_TenMatHang
            // 
            this.lbl_TenMatHang.AutoSize = true;
            this.lbl_TenMatHang.Location = new System.Drawing.Point(8, 23);
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
            this.btn_TimKiem.Location = new System.Drawing.Point(299, 17);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(70, 24);
            this.btn_TimKiem.TabIndex = 2;
            this.btn_TimKiem.TabStop = false;
            this.btn_TimKiem.Text = "T&ìm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // frm_XoaMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.grb_TieuChiTimKiem);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.grb_DanhSachMatHang);
            this.MaximizeBox = false;
            this.Name = "frm_XoaMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xoa mat hang";
            this.grb_DanhSachMatHang.ResumeLayout(false);
            this.grb_DanhSachMatHang.PerformLayout();
            this.grb_TieuChiTimKiem.ResumeLayout(false);
            this.grb_TieuChiTimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.GroupBox grb_DanhSachMatHang;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.CheckBox chk_ChonTatCa;
        private System.Windows.Forms.ListView lsv_DanhSachXe;
        private System.Windows.Forms.ColumnHeader Chon;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox grb_TieuChiTimKiem;
        private System.Windows.Forms.CheckBox chc_TimChinhXac;
        private System.Windows.Forms.TextBox txt_TenMatHang_TimKiem;
        private System.Windows.Forms.Label lbl_TenMatHang;
        private System.Windows.Forms.Button btn_TimKiem;
    }
}