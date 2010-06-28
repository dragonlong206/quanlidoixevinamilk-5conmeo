namespace GUI
{
    partial class QuanLyHangXeGUI
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
            this.chk_ChonTatCa = new System.Windows.Forms.CheckBox();
            this.lsv_DanhSachHangXe = new System.Windows.Forms.ListView();
            this.STT = new System.Windows.Forms.ColumnHeader();
            this.TenHang = new System.Windows.Forms.ColumnHeader();
            this.cms_DanhSachHang = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sửaTêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grb_ThaoTac = new System.Windows.Forms.GroupBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.txt_TenHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_ThemHangXe = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
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
            this.lbl_Title.Location = new System.Drawing.Point(103, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(220, 25);
            this.lbl_Title.TabIndex = 12;
            this.lbl_Title.Text = "QUẢN LÝ HÃNG XE";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grb_HangXeHienCo
            // 
            this.grb_HangXeHienCo.Controls.Add(this.chk_ChonTatCa);
            this.grb_HangXeHienCo.Controls.Add(this.lsv_DanhSachHangXe);
            this.grb_HangXeHienCo.Location = new System.Drawing.Point(9, 56);
            this.grb_HangXeHienCo.Name = "grb_HangXeHienCo";
            this.grb_HangXeHienCo.Size = new System.Drawing.Size(200, 228);
            this.grb_HangXeHienCo.TabIndex = 13;
            this.grb_HangXeHienCo.TabStop = false;
            this.grb_HangXeHienCo.Text = "Các hãng xe hiện có";
            // 
            // chk_ChonTatCa
            // 
            this.chk_ChonTatCa.AutoSize = true;
            this.chk_ChonTatCa.Location = new System.Drawing.Point(6, 205);
            this.chk_ChonTatCa.Name = "chk_ChonTatCa";
            this.chk_ChonTatCa.Size = new System.Drawing.Size(81, 17);
            this.chk_ChonTatCa.TabIndex = 2;
            this.chk_ChonTatCa.Text = "Chọn tất cả";
            this.chk_ChonTatCa.UseVisualStyleBackColor = true;
            this.chk_ChonTatCa.CheckedChanged += new System.EventHandler(this.chk_ChonTatCa_CheckedChanged);
            // 
            // lsv_DanhSachHangXe
            // 
            this.lsv_DanhSachHangXe.CheckBoxes = true;
            this.lsv_DanhSachHangXe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.TenHang});
            this.lsv_DanhSachHangXe.FullRowSelect = true;
            this.lsv_DanhSachHangXe.GridLines = true;
            this.lsv_DanhSachHangXe.Location = new System.Drawing.Point(5, 18);
            this.lsv_DanhSachHangXe.Margin = new System.Windows.Forms.Padding(2);
            this.lsv_DanhSachHangXe.Name = "lsv_DanhSachHangXe";
            this.lsv_DanhSachHangXe.Size = new System.Drawing.Size(187, 182);
            this.lsv_DanhSachHangXe.TabIndex = 0;
            this.lsv_DanhSachHangXe.UseCompatibleStateImageBehavior = false;
            this.lsv_DanhSachHangXe.View = System.Windows.Forms.View.Details;
            this.lsv_DanhSachHangXe.SelectedIndexChanged += new System.EventHandler(this.lsv_DanhSachHangXe_SelectedIndexChanged);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            // 
            // TenHang
            // 
            this.TenHang.Text = "Tên Hãng";
            this.TenHang.Width = 121;
            // 
            // cms_DanhSachHang
            // 
            this.cms_DanhSachHang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaTêToolStripMenuItem});
            this.cms_DanhSachHang.Name = "cms_DanhSachHang";
            this.cms_DanhSachHang.ShowImageMargin = false;
            this.cms_DanhSachHang.Size = new System.Drawing.Size(126, 26);
            // 
            // sửaTêToolStripMenuItem
            // 
            this.sửaTêToolStripMenuItem.Name = "sửaTêToolStripMenuItem";
            this.sửaTêToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.sửaTêToolStripMenuItem.Text = "&Sửa tên hãng";
            // 
            // grb_ThaoTac
            // 
            this.grb_ThaoTac.Controls.Add(this.btn_Tim);
            this.grb_ThaoTac.Controls.Add(this.btn_Xoa);
            this.grb_ThaoTac.Controls.Add(this.txt_TenHang);
            this.grb_ThaoTac.Controls.Add(this.label2);
            this.grb_ThaoTac.Controls.Add(this.btn_Sua);
            this.grb_ThaoTac.Controls.Add(this.btn_ThemHangXe);
            this.grb_ThaoTac.Location = new System.Drawing.Point(225, 56);
            this.grb_ThaoTac.Name = "grb_ThaoTac";
            this.grb_ThaoTac.Size = new System.Drawing.Size(207, 228);
            this.grb_ThaoTac.TabIndex = 0;
            this.grb_ThaoTac.TabStop = false;
            this.grb_ThaoTac.Text = "Thao tác";
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(16, 134);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(82, 23);
            this.btn_Tim.TabIndex = 2;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(16, 182);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(82, 23);
            this.btn_Xoa.TabIndex = 4;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txt_TenHang
            // 
            this.txt_TenHang.Location = new System.Drawing.Point(17, 71);
            this.txt_TenHang.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TenHang.Name = "txt_TenHang";
            this.txt_TenHang.Size = new System.Drawing.Size(127, 20);
            this.txt_TenHang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên hãng";
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(118, 182);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(82, 23);
            this.btn_Sua.TabIndex = 5;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_ThemHangXe
            // 
            this.btn_ThemHangXe.Location = new System.Drawing.Point(118, 134);
            this.btn_ThemHangXe.Name = "btn_ThemHangXe";
            this.btn_ThemHangXe.Size = new System.Drawing.Size(82, 23);
            this.btn_ThemHangXe.TabIndex = 3;
            this.btn_ThemHangXe.Text = "Thêm";
            this.btn_ThemHangXe.UseVisualStyleBackColor = true;
            this.btn_ThemHangXe.Click += new System.EventHandler(this.btnThemHangXe_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(343, 299);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(82, 23);
            this.btn_Thoat.TabIndex = 1;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click_1);
            // 
            // QuanLyHangXeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 332);
            this.Controls.Add(this.grb_HangXeHienCo);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.grb_ThaoTac);
            this.Controls.Add(this.btn_Thoat);
            this.MaximizeBox = false;
            this.Name = "QuanLyHangXeGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan ly hang xe";
            this.Load += new System.EventHandler(this.QuanLyHangXeGUI_Load);
            this.grb_HangXeHienCo.ResumeLayout(false);
            this.grb_HangXeHienCo.PerformLayout();
            this.cms_DanhSachHang.ResumeLayout(false);
            this.grb_ThaoTac.ResumeLayout(false);
            this.grb_ThaoTac.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox grb_HangXeHienCo;
        private System.Windows.Forms.GroupBox grb_ThaoTac;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_ThemHangXe;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.ContextMenuStrip cms_DanhSachHang;
        private System.Windows.Forms.ToolStripMenuItem sửaTêToolStripMenuItem;
        private System.Windows.Forms.ListView lsv_DanhSachHangXe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TenHang;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader TenHang;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.CheckBox chk_ChonTatCa;
    }
}