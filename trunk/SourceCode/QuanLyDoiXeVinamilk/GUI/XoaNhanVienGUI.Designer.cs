namespace GUI
{
    partial class frm_XoaNhanVien
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
            this.dtgv_DanhSachNhanVien = new System.Windows.Forms.DataGridView();
            this.Chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.grb_DanhSachNhanVien = new System.Windows.Forms.GroupBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DanhSachNhanVien)).BeginInit();
            this.grb_DanhSachNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_DanhSachNhanVien
            // 
            this.dtgv_DanhSachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_DanhSachNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chon,
            this.TenNhanVien,
            this.DienThoai});
            this.dtgv_DanhSachNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_DanhSachNhanVien.Location = new System.Drawing.Point(3, 16);
            this.dtgv_DanhSachNhanVien.Name = "dtgv_DanhSachNhanVien";
            this.dtgv_DanhSachNhanVien.RowHeadersVisible = false;
            this.dtgv_DanhSachNhanVien.Size = new System.Drawing.Size(385, 328);
            this.dtgv_DanhSachNhanVien.TabIndex = 0;
            // 
            // Chon
            // 
            this.Chon.HeaderText = "Chọn";
            this.Chon.Name = "Chon";
            this.Chon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Chon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Chon.Width = 50;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.HeaderText = "Họ tên";
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.Width = 200;
            // 
            // DienThoai
            // 
            this.DienThoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DienThoai.HeaderText = "Điện Thoại";
            this.DienThoai.Name = "DienThoai";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(248, 406);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 0;
            this.btn_Xoa.Text = "&Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // grb_DanhSachNhanVien
            // 
            this.grb_DanhSachNhanVien.Controls.Add(this.dtgv_DanhSachNhanVien);
            this.grb_DanhSachNhanVien.Location = new System.Drawing.Point(27, 51);
            this.grb_DanhSachNhanVien.Name = "grb_DanhSachNhanVien";
            this.grb_DanhSachNhanVien.Size = new System.Drawing.Size(391, 347);
            this.grb_DanhSachNhanVien.TabIndex = 2;
            this.grb_DanhSachNhanVien.TabStop = false;
            this.grb_DanhSachNhanVien.Text = "Danh sách nhân viên";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(343, 406);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 1;
            this.btn_Thoat.Text = "&Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Location = new System.Drawing.Point(131, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(174, 24);
            this.lblTitle.TabIndex = 39;
            this.lblTitle.Text = "XÓA NHÂN VIÊN";
            // 
            // frm_XoaNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 434);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.grb_DanhSachNhanVien);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.Name = "frm_XoaNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xoa nhan vien";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DanhSachNhanVien)).EndInit();
            this.grb_DanhSachNhanVien.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_DanhSachNhanVien;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.GroupBox grb_DanhSachNhanVien;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label lblTitle;
    }
}