namespace GUI
{
    partial class frm_TiepNhanNhanVien
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
            this.grb_DanhSachNhanVien = new System.Windows.Forms.GroupBox();
            this.dgv_DanhSachNhanVien = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btn_Import = new System.Windows.Forms.Button();
            this.grb_DanhSachNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Location = new System.Drawing.Point(135, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(186, 24);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "NHẬP NHÂN VIÊN";
            // 
            // grb_DanhSachNhanVien
            // 
            this.grb_DanhSachNhanVien.Controls.Add(this.dgv_DanhSachNhanVien);
            this.grb_DanhSachNhanVien.Location = new System.Drawing.Point(38, 51);
            this.grb_DanhSachNhanVien.Name = "grb_DanhSachNhanVien";
            this.grb_DanhSachNhanVien.Size = new System.Drawing.Size(391, 347);
            this.grb_DanhSachNhanVien.TabIndex = 0;
            this.grb_DanhSachNhanVien.TabStop = false;
            this.grb_DanhSachNhanVien.Text = "Danh sách nhân viên";
            // 
            // dgv_DanhSachNhanVien
            // 
            this.dgv_DanhSachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenNhanVien,
            this.DienThoai});
            this.dgv_DanhSachNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSachNhanVien.Location = new System.Drawing.Point(3, 16);
            this.dgv_DanhSachNhanVien.Name = "dgv_DanhSachNhanVien";
            this.dgv_DanhSachNhanVien.RowHeadersVisible = false;
            this.dgv_DanhSachNhanVien.Size = new System.Drawing.Size(385, 328);
            this.dgv_DanhSachNhanVien.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 30;
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
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(259, 406);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(354, 406);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btn_Import
            // 
            this.btn_Import.Location = new System.Drawing.Point(41, 406);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(75, 23);
            this.btn_Import.TabIndex = 10;
            this.btn_Import.Text = "&Import";
            this.btn_Import.UseVisualStyleBackColor = true;
            // 
            // frm_TiepNhanNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 437);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.grb_DanhSachNhanVien);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.Name = "frm_TiepNhanNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhap nhan vien";
            this.grb_DanhSachNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grb_DanhSachNhanVien;
        private System.Windows.Forms.DataGridView dgv_DanhSachNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btn_Import;
    }
}