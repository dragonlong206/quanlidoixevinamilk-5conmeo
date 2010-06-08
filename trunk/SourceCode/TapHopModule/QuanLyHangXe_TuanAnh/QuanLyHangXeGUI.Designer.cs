namespace GUI
{
    partial class frm_QuanLyHangXe
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
            this.components = new System.ComponentModel.Container();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.grb_HangXeHienCo = new System.Windows.Forms.GroupBox();
            this.lv_DanhSachHangXe = new System.Windows.Forms.ListView();
            this.MaHang = new System.Windows.Forms.ColumnHeader();
            this.TenHang = new System.Windows.Forms.ColumnHeader();
            this.cms_DanhSachHang = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sửaTêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grb_ThaoTac = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btnThemHangXe = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.txb_MaHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_HangXe = new System.Windows.Forms.TextBox();
            this.grb_HangXeHienCo.SuspendLayout();
            this.cms_DanhSachHang.SuspendLayout();
            this.grb_ThaoTac.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Title.Location = new System.Drawing.Point(113, 11);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(445, 31);
            this.lbl_Title.TabIndex = 12;
            this.lbl_Title.Text = "QUẢN LÝ THÔNG TIN HÃNG XE";
            // 
            // grb_HangXeHienCo
            // 
            this.grb_HangXeHienCo.Controls.Add(this.lv_DanhSachHangXe);
            this.grb_HangXeHienCo.Location = new System.Drawing.Point(16, 46);
            this.grb_HangXeHienCo.Margin = new System.Windows.Forms.Padding(4);
            this.grb_HangXeHienCo.Name = "grb_HangXeHienCo";
            this.grb_HangXeHienCo.Padding = new System.Windows.Forms.Padding(4);
            this.grb_HangXeHienCo.Size = new System.Drawing.Size(305, 398);
            this.grb_HangXeHienCo.TabIndex = 13;
            this.grb_HangXeHienCo.TabStop = false;
            this.grb_HangXeHienCo.Text = "Các hãng xe hiện có";
            // 
            // lv_DanhSachHangXe
            // 
            this.lv_DanhSachHangXe.CheckBoxes = true;
            this.lv_DanhSachHangXe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaHang,
            this.TenHang});
            this.lv_DanhSachHangXe.FullRowSelect = true;
            this.lv_DanhSachHangXe.GridLines = true;
            this.lv_DanhSachHangXe.Location = new System.Drawing.Point(7, 22);
            this.lv_DanhSachHangXe.Name = "lv_DanhSachHangXe";
            this.lv_DanhSachHangXe.Size = new System.Drawing.Size(291, 204);
            this.lv_DanhSachHangXe.TabIndex = 0;
            this.lv_DanhSachHangXe.UseCompatibleStateImageBehavior = false;
            this.lv_DanhSachHangXe.View = System.Windows.Forms.View.Details;
            this.lv_DanhSachHangXe.SelectedIndexChanged += new System.EventHandler(this.lv_DanhSachHangXe_SelectedIndexChanged);
            // 
            // MaHang
            // 
            this.MaHang.Text = "Mã Hãng";
            // 
            // TenHang
            // 
            this.TenHang.Text = "Tên Hàng";
            // 
            // cms_DanhSachHang
            // 
            this.cms_DanhSachHang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaTêToolStripMenuItem});
            this.cms_DanhSachHang.Name = "cms_DanhSachHang";
            this.cms_DanhSachHang.ShowImageMargin = false;
            this.cms_DanhSachHang.Size = new System.Drawing.Size(141, 28);
            // 
            // sửaTêToolStripMenuItem
            // 
            this.sửaTêToolStripMenuItem.Name = "sửaTêToolStripMenuItem";
            this.sửaTêToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.sửaTêToolStripMenuItem.Text = "&Sửa tên hãng";
            // 
            // grb_ThaoTac
            // 
            this.grb_ThaoTac.Controls.Add(this.btnXoa);
            this.grb_ThaoTac.Controls.Add(this.btn_Sua);
            this.grb_ThaoTac.Controls.Add(this.btnThemHangXe);
            this.grb_ThaoTac.Location = new System.Drawing.Point(392, 226);
            this.grb_ThaoTac.Margin = new System.Windows.Forms.Padding(4);
            this.grb_ThaoTac.Name = "grb_ThaoTac";
            this.grb_ThaoTac.Padding = new System.Windows.Forms.Padding(4);
            this.grb_ThaoTac.Size = new System.Drawing.Size(290, 181);
            this.grb_ThaoTac.TabIndex = 14;
            this.grb_ThaoTac.TabStop = false;
            this.grb_ThaoTac.Text = "Thao tác";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(69, 144);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(187, 28);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa các hãng xe đã chọn";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(69, 86);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(176, 28);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa tên hãng xe đã chọn";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btnThemHangXe
            // 
            this.btnThemHangXe.Location = new System.Drawing.Point(67, 36);
            this.btnThemHangXe.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemHangXe.Name = "btnThemHangXe";
            this.btnThemHangXe.Size = new System.Drawing.Size(132, 28);
            this.btnThemHangXe.TabIndex = 0;
            this.btnThemHangXe.Text = "Thêm hãng xe";
            this.btnThemHangXe.UseVisualStyleBackColor = true;
            this.btnThemHangXe.Click += new System.EventHandler(this.btnThemHangXe_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(577, 415);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(100, 28);
            this.btn_Thoat.TabIndex = 15;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click_1);
            // 
            // txb_MaHang
            // 
            this.txb_MaHang.Location = new System.Drawing.Point(464, 62);
            this.txb_MaHang.Name = "txb_MaHang";
            this.txb_MaHang.Size = new System.Drawing.Size(153, 22);
            this.txb_MaHang.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã Hãng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Hãng Xe";
            // 
            // txb_HangXe
            // 
            this.txb_HangXe.Location = new System.Drawing.Point(459, 117);
            this.txb_HangXe.Name = "txb_HangXe";
            this.txb_HangXe.Size = new System.Drawing.Size(153, 22);
            this.txb_HangXe.TabIndex = 18;
            // 
            // frm_QuanLyHangXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 458);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_HangXe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_MaHang);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.grb_HangXeHienCo);
            this.Controls.Add(this.grb_ThaoTac);
            this.Controls.Add(this.lbl_Title);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_QuanLyHangXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan ly hang xe";
            this.Load += new System.EventHandler(this.frm_QuanLyHangXe_Load);
            this.grb_HangXeHienCo.ResumeLayout(false);
            this.cms_DanhSachHang.ResumeLayout(false);
            this.grb_ThaoTac.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox grb_HangXeHienCo;
        private System.Windows.Forms.GroupBox grb_ThaoTac;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btnThemHangXe;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ContextMenuStrip cms_DanhSachHang;
        private System.Windows.Forms.ToolStripMenuItem sửaTêToolStripMenuItem;
        private System.Windows.Forms.ListView lv_DanhSachHangXe;
        private System.Windows.Forms.TextBox txb_MaHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_HangXe;
        private System.Windows.Forms.ColumnHeader MaHang;
        private System.Windows.Forms.ColumnHeader TenHang;
    }
}