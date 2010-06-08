namespace GUI
{
    partial class TimKiemDaiLyFrm
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
            this.grbTieuChi = new System.Windows.Forms.GroupBox();
            this.txtMaHopDen = new System.Windows.Forms.TextBox();
            this.lblTenDaiLy = new System.Windows.Forms.Label();
            this.txtTenDaiLy = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.chkTimChinhXac = new System.Windows.Forms.CheckBox();
            this.grbKetQua = new System.Windows.Forms.GroupBox();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.btnTim = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbTieuChi.SuspendLayout();
            this.grbKetQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Location = new System.Drawing.Point(126, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(193, 25);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "TÌM KIẾM ĐẠI LÝ";
            // 
            // grbTieuChi
            // 
            this.grbTieuChi.Controls.Add(this.btnTim);
            this.grbTieuChi.Controls.Add(this.chkTimChinhXac);
            this.grbTieuChi.Controls.Add(this.txtMaHopDen);
            this.grbTieuChi.Controls.Add(this.txtTenDaiLy);
            this.grbTieuChi.Controls.Add(this.lblDiaChi);
            this.grbTieuChi.Controls.Add(this.lblTenDaiLy);
            this.grbTieuChi.Location = new System.Drawing.Point(13, 49);
            this.grbTieuChi.Name = "grbTieuChi";
            this.grbTieuChi.Size = new System.Drawing.Size(423, 148);
            this.grbTieuChi.TabIndex = 9;
            this.grbTieuChi.TabStop = false;
            this.grbTieuChi.Text = "Tiêu chí tìm kiếm";
            // 
            // txtMaHopDen
            // 
            this.txtMaHopDen.Location = new System.Drawing.Point(78, 74);
            this.txtMaHopDen.Name = "txtMaHopDen";
            this.txtMaHopDen.Size = new System.Drawing.Size(312, 20);
            this.txtMaHopDen.TabIndex = 13;
            // 
            // lblTenDaiLy
            // 
            this.lblTenDaiLy.AutoSize = true;
            this.lblTenDaiLy.Location = new System.Drawing.Point(6, 35);
            this.lblTenDaiLy.Name = "lblTenDaiLy";
            this.lblTenDaiLy.Size = new System.Drawing.Size(54, 13);
            this.lblTenDaiLy.TabIndex = 12;
            this.lblTenDaiLy.Text = "Tên đại lý";
            // 
            // txtTenDaiLy
            // 
            this.txtTenDaiLy.Location = new System.Drawing.Point(78, 32);
            this.txtTenDaiLy.Name = "txtTenDaiLy";
            this.txtTenDaiLy.Size = new System.Drawing.Size(119, 20);
            this.txtTenDaiLy.TabIndex = 15;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(6, 77);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(40, 13);
            this.lblDiaChi.TabIndex = 14;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // chkTimChinhXac
            // 
            this.chkTimChinhXac.AutoSize = true;
            this.chkTimChinhXac.Location = new System.Drawing.Point(78, 123);
            this.chkTimChinhXac.Name = "chkTimChinhXac";
            this.chkTimChinhXac.Size = new System.Drawing.Size(94, 17);
            this.chkTimChinhXac.TabIndex = 16;
            this.chkTimChinhXac.Text = "Tìm chính xác";
            this.chkTimChinhXac.UseVisualStyleBackColor = true;
            // 
            // grbKetQua
            // 
            this.grbKetQua.Controls.Add(this.dgvKetQua);
            this.grbKetQua.Location = new System.Drawing.Point(12, 203);
            this.grbKetQua.Name = "grbKetQua";
            this.grbKetQua.Size = new System.Drawing.Size(423, 168);
            this.grbKetQua.TabIndex = 10;
            this.grbKetQua.TabStop = false;
            this.grbKetQua.Text = "Kết quả";
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenDaiLy,
            this.DiaChi,
            this.DienThoai});
            this.dgvKetQua.Location = new System.Drawing.Point(9, 20);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.Size = new System.Drawing.Size(408, 139);
            this.dgvKetQua.TabIndex = 0;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(315, 119);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 17;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 30;
            // 
            // TenDaiLy
            // 
            this.TenDaiLy.HeaderText = "Tên đại lý";
            this.TenDaiLy.Name = "TenDaiLy";
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 150;
            // 
            // DienThoai
            // 
            this.DienThoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DienThoai.HeaderText = "Điện thoại";
            this.DienThoai.Name = "DienThoai";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(360, 383);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // TimKiemDaiLyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 418);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grbKetQua);
            this.Controls.Add(this.grbTieuChi);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.Name = "TimKiemDaiLyFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tim kiem dai ly";
            this.grbTieuChi.ResumeLayout(false);
            this.grbTieuChi.PerformLayout();
            this.grbKetQua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbTieuChi;
        private System.Windows.Forms.TextBox txtTenDaiLy;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtMaHopDen;
        private System.Windows.Forms.Label lblTenDaiLy;
        private System.Windows.Forms.CheckBox chkTimChinhXac;
        private System.Windows.Forms.GroupBox grbKetQua;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.Button btnThoat;
    }
}