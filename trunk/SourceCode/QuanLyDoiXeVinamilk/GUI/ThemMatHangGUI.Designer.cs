namespace GUI
{
    partial class frm_ThemMatHang
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
            this.grb_ThongTinMatHang = new System.Windows.Forms.GroupBox();
            this.dtgv_DanhSachMatHang = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btn_Import = new System.Windows.Forms.Button();
            this.grb_ThongTinMatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DanhSachMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Title.Location = new System.Drawing.Point(168, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(200, 25);
            this.lbl_Title.TabIndex = 13;
            this.lbl_Title.Text = "NHẬP MẶT HÀNG";
            // 
            // grb_ThongTinMatHang
            // 
            this.grb_ThongTinMatHang.Controls.Add(this.dtgv_DanhSachMatHang);
            this.grb_ThongTinMatHang.Location = new System.Drawing.Point(12, 37);
            this.grb_ThongTinMatHang.Name = "grb_ThongTinMatHang";
            this.grb_ThongTinMatHang.Size = new System.Drawing.Size(520, 289);
            this.grb_ThongTinMatHang.TabIndex = 14;
            this.grb_ThongTinMatHang.TabStop = false;
            this.grb_ThongTinMatHang.Text = "Thông tin mặt hàng";
            // 
            // dtgv_DanhSachMatHang
            // 
            this.dtgv_DanhSachMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_DanhSachMatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenMatHang,
            this.SoLuong,
            this.DonViTinh,
            this.LoaiHang});
            this.dtgv_DanhSachMatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_DanhSachMatHang.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgv_DanhSachMatHang.Location = new System.Drawing.Point(3, 16);
            this.dtgv_DanhSachMatHang.Name = "dtgv_DanhSachMatHang";
            this.dtgv_DanhSachMatHang.RowHeadersVisible = false;
            this.dtgv_DanhSachMatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgv_DanhSachMatHang.Size = new System.Drawing.Size(514, 270);
            this.dtgv_DanhSachMatHang.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 30;
            // 
            // TenMatHang
            // 
            this.TenMatHang.HeaderText = "Tên mặt hàng";
            this.TenMatHang.Name = "TenMatHang";
            this.TenMatHang.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // DonViTinh
            // 
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.Name = "DonViTinh";
            // 
            // LoaiHang
            // 
            this.LoaiHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LoaiHang.HeaderText = "Loại hàng";
            this.LoaiHang.Name = "LoaiHang";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(359, 332);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(454, 332);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btn_Import
            // 
            this.btn_Import.Image = global::GUI.Properties.Resources.Import_Data_Blue;
            this.btn_Import.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Import.Location = new System.Drawing.Point(15, 332);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(95, 23);
            this.btn_Import.TabIndex = 17;
            this.btn_Import.Text = "&Import";
            this.btn_Import.UseVisualStyleBackColor = true;
            // 
            // frm_ThemMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 363);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grb_ThongTinMatHang);
            this.Controls.Add(this.lbl_Title);
            this.MaximizeBox = false;
            this.Name = "frm_ThemMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhap mat hang";
            this.grb_ThongTinMatHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DanhSachMatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox grb_ThongTinMatHang;
        private System.Windows.Forms.DataGridView dtgv_DanhSachMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewComboBoxColumn LoaiHang;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
    }
}