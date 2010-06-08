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
            this.lsv_DanhSachHienCo = new System.Windows.Forms.ListView();
            this.grb_ThaoTac = new System.Windows.Forms.GroupBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.grb_ThongTin = new System.Windows.Forms.GroupBox();
            this.txt_ThongTin = new System.Windows.Forms.TextBox();
            this.btnThemHangXe = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.chk_ChonTatCa = new System.Windows.Forms.CheckBox();
            this.cms_DanhSachHang = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sửaTêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grb_HangXeHienCo.SuspendLayout();
            this.grb_ThaoTac.SuspendLayout();
            this.grb_ThongTin.SuspendLayout();
            this.cms_DanhSachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Title.Location = new System.Drawing.Point(85, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(350, 25);
            this.lbl_Title.TabIndex = 12;
            this.lbl_Title.Text = "QUẢN LÝ THÔNG TIN HÃNG XE";
            // 
            // grb_HangXeHienCo
            // 
            this.grb_HangXeHienCo.Controls.Add(this.chk_ChonTatCa);
            this.grb_HangXeHienCo.Controls.Add(this.lsv_DanhSachHienCo);
            this.grb_HangXeHienCo.Location = new System.Drawing.Point(12, 37);
            this.grb_HangXeHienCo.Name = "grb_HangXeHienCo";
            this.grb_HangXeHienCo.Size = new System.Drawing.Size(229, 323);
            this.grb_HangXeHienCo.TabIndex = 13;
            this.grb_HangXeHienCo.TabStop = false;
            this.grb_HangXeHienCo.Text = "Các hãng xe hiện có";
            // 
            // lsv_DanhSachHienCo
            // 
            this.lsv_DanhSachHienCo.CheckBoxes = true;
            this.lsv_DanhSachHienCo.ContextMenuStrip = this.cms_DanhSachHang;
            this.lsv_DanhSachHienCo.LabelEdit = true;
            this.lsv_DanhSachHienCo.Location = new System.Drawing.Point(7, 20);
            this.lsv_DanhSachHienCo.Name = "lsv_DanhSachHienCo";
            this.lsv_DanhSachHienCo.Size = new System.Drawing.Size(216, 266);
            this.lsv_DanhSachHienCo.TabIndex = 0;
            this.lsv_DanhSachHienCo.UseCompatibleStateImageBehavior = false;
            this.lsv_DanhSachHienCo.View = System.Windows.Forms.View.List;
            // 
            // grb_ThaoTac
            // 
            this.grb_ThaoTac.Controls.Add(this.btnXoa);
            this.grb_ThaoTac.Controls.Add(this.btn_Sua);
            this.grb_ThaoTac.Controls.Add(this.btnThemHangXe);
            this.grb_ThaoTac.Location = new System.Drawing.Point(248, 206);
            this.grb_ThaoTac.Name = "grb_ThaoTac";
            this.grb_ThaoTac.Size = new System.Drawing.Size(261, 117);
            this.grb_ThaoTac.TabIndex = 14;
            this.grb_ThaoTac.TabStop = false;
            this.grb_ThaoTac.Text = "Thao tác";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(433, 337);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 15;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // grb_ThongTin
            // 
            this.grb_ThongTin.Controls.Add(this.txt_ThongTin);
            this.grb_ThongTin.Location = new System.Drawing.Point(248, 37);
            this.grb_ThongTin.Name = "grb_ThongTin";
            this.grb_ThongTin.Size = new System.Drawing.Size(260, 163);
            this.grb_ThongTin.TabIndex = 16;
            this.grb_ThongTin.TabStop = false;
            this.grb_ThongTin.Text = "Thông tin";
            // 
            // txt_ThongTin
            // 
            this.txt_ThongTin.Location = new System.Drawing.Point(7, 16);
            this.txt_ThongTin.Multiline = true;
            this.txt_ThongTin.Name = "txt_ThongTin";
            this.txt_ThongTin.ReadOnly = true;
            this.txt_ThongTin.Size = new System.Drawing.Size(247, 141);
            this.txt_ThongTin.TabIndex = 0;
            // 
            // btnThemHangXe
            // 
            this.btnThemHangXe.Location = new System.Drawing.Point(6, 30);
            this.btnThemHangXe.Name = "btnThemHangXe";
            this.btnThemHangXe.Size = new System.Drawing.Size(99, 23);
            this.btnThemHangXe.TabIndex = 0;
            this.btnThemHangXe.Text = "Thêm hãng xe";
            this.btnThemHangXe.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(111, 30);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(143, 23);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa tên hãng xe đã chọn";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(59, 73);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(140, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa các hãng xe đã chọn";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // chk_ChonTatCa
            // 
            this.chk_ChonTatCa.AutoSize = true;
            this.chk_ChonTatCa.Location = new System.Drawing.Point(7, 300);
            this.chk_ChonTatCa.Name = "chk_ChonTatCa";
            this.chk_ChonTatCa.Size = new System.Drawing.Size(81, 17);
            this.chk_ChonTatCa.TabIndex = 1;
            this.chk_ChonTatCa.Text = "Chọn tất cả";
            this.chk_ChonTatCa.UseVisualStyleBackColor = true;
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
            this.sửaTêToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sửaTêToolStripMenuItem.Text = "&Sửa tên hãng";
            // 
            // frm_QuanLyHangXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 372);
            this.Controls.Add(this.grb_ThongTin);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.grb_ThaoTac);
            this.Controls.Add(this.grb_HangXeHienCo);
            this.Controls.Add(this.lbl_Title);
            this.MaximizeBox = false;
            this.Name = "frm_QuanLyHangXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan ly hang xe";
            this.grb_HangXeHienCo.ResumeLayout(false);
            this.grb_HangXeHienCo.PerformLayout();
            this.grb_ThaoTac.ResumeLayout(false);
            this.grb_ThongTin.ResumeLayout(false);
            this.grb_ThongTin.PerformLayout();
            this.cms_DanhSachHang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox grb_HangXeHienCo;
        private System.Windows.Forms.ListView lsv_DanhSachHienCo;
        private System.Windows.Forms.GroupBox grb_ThaoTac;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.GroupBox grb_ThongTin;
        private System.Windows.Forms.TextBox txt_ThongTin;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btnThemHangXe;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.CheckBox chk_ChonTatCa;
        private System.Windows.Forms.ContextMenuStrip cms_DanhSachHang;
        private System.Windows.Forms.ToolStripMenuItem sửaTêToolStripMenuItem;
    }
}