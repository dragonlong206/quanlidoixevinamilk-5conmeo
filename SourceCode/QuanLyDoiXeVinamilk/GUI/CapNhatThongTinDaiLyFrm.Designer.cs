namespace GUI
{
    partial class CapNhatThongTinDaiLyFrm
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbDanhSachDaiLy = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTenDaiLy = new System.Windows.Forms.Label();
            this.txtTenDaiLy = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.grbDanhSachDaiLy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(80, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(302, 24);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "CẬP NHẬT THÔNG TIN ĐẠI LÝ";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(232, 446);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(343, 446);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // grbDanhSachDaiLy
            // 
            this.grbDanhSachDaiLy.Controls.Add(this.dgvDanhSach);
            this.grbDanhSachDaiLy.Location = new System.Drawing.Point(27, 93);
            this.grbDanhSachDaiLy.Name = "grbDanhSachDaiLy";
            this.grbDanhSachDaiLy.Size = new System.Drawing.Size(391, 347);
            this.grbDanhSachDaiLy.TabIndex = 12;
            this.grbDanhSachDaiLy.TabStop = false;
            this.grbDanhSachDaiLy.Text = "Danh đại lý";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenDaiLy,
            this.DiaChi,
            this.DienThoai});
            this.dgvDanhSach.Location = new System.Drawing.Point(7, 20);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.Size = new System.Drawing.Size(378, 321);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellContentClick);
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
            // 
            // DienThoai
            // 
            this.DienThoai.HeaderText = "Điện Thoại";
            this.DienThoai.Name = "DienThoai";
            // 
            // lblTenDaiLy
            // 
            this.lblTenDaiLy.AutoSize = true;
            this.lblTenDaiLy.Location = new System.Drawing.Point(31, 59);
            this.lblTenDaiLy.Name = "lblTenDaiLy";
            this.lblTenDaiLy.Size = new System.Drawing.Size(54, 13);
            this.lblTenDaiLy.TabIndex = 16;
            this.lblTenDaiLy.Text = "Tên đại lý";
            // 
            // txtTenDaiLy
            // 
            this.txtTenDaiLy.Location = new System.Drawing.Point(127, 52);
            this.txtTenDaiLy.Name = "txtTenDaiLy";
            this.txtTenDaiLy.Size = new System.Drawing.Size(101, 20);
            this.txtTenDaiLy.TabIndex = 17;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(266, 50);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 18;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // CapNhatThongTinDaiLyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 481);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTenDaiLy);
            this.Controls.Add(this.lblTenDaiLy);
            this.Controls.Add(this.grbDanhSachDaiLy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblTitle);
            this.Name = "CapNhatThongTinDaiLyFrm";
            this.Text = "CapNhatThongTinDaiLyFrm";
            this.grbDanhSachDaiLy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grbDanhSachDaiLy;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Label lblTenDaiLy;
        private System.Windows.Forms.TextBox txtTenDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.Button btnTim;
    }
}