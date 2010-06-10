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
            this.lsv_DanhSachMatHang = new System.Windows.Forms.ListView();
            this.Chon = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.grb_TieuChiTimKiem = new System.Windows.Forms.GroupBox();
            this.txt_TenMatHang_TimKiem = new System.Windows.Forms.TextBox();
            this.lbl_TenMatHang = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.grb_DanhSachMatHang.SuspendLayout();
            this.grb_TieuChiTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(579, 520);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(100, 28);
            this.btn_Thoat.TabIndex = 4;
            this.btn_Thoat.Text = "&Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // grb_DanhSachMatHang
            // 
            this.grb_DanhSachMatHang.Controls.Add(this.lsv_DanhSachMatHang);
            this.grb_DanhSachMatHang.Location = new System.Drawing.Point(16, 134);
            this.grb_DanhSachMatHang.Margin = new System.Windows.Forms.Padding(4);
            this.grb_DanhSachMatHang.Name = "grb_DanhSachMatHang";
            this.grb_DanhSachMatHang.Padding = new System.Windows.Forms.Padding(4);
            this.grb_DanhSachMatHang.Size = new System.Drawing.Size(672, 378);
            this.grb_DanhSachMatHang.TabIndex = 3;
            this.grb_DanhSachMatHang.TabStop = false;
            this.grb_DanhSachMatHang.Text = "Danh sách mặt hàng";
            // 
            // lsv_DanhSachMatHang
            // 
            this.lsv_DanhSachMatHang.CheckBoxes = true;
            this.lsv_DanhSachMatHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Chon,
            this.columnHeader1});
            this.lsv_DanhSachMatHang.FullRowSelect = true;
            this.lsv_DanhSachMatHang.Location = new System.Drawing.Point(8, 23);
            this.lsv_DanhSachMatHang.Margin = new System.Windows.Forms.Padding(4);
            this.lsv_DanhSachMatHang.Name = "lsv_DanhSachMatHang";
            this.lsv_DanhSachMatHang.Size = new System.Drawing.Size(655, 319);
            this.lsv_DanhSachMatHang.TabIndex = 26;
            this.lsv_DanhSachMatHang.UseCompatibleStateImageBehavior = false;
            this.lsv_DanhSachMatHang.View = System.Windows.Forms.View.Details;
            this.lsv_DanhSachMatHang.SelectedIndexChanged += new System.EventHandler(this.lsv_DanhSachMatHang_SelectedIndexChanged);
            // 
            // Chon
            // 
            this.Chon.Text = "Chọn";
            this.Chon.Width = 93;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Mặt Hàng";
            this.columnHeader1.Width = 148;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(423, 520);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(100, 28);
            this.btn_Xoa.TabIndex = 1;
            this.btn_Xoa.Text = "&Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Title.Location = new System.Drawing.Point(235, 11);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(233, 31);
            this.lbl_Title.TabIndex = 28;
            this.lbl_Title.Text = "XÓA MẶT HÀNG";
            // 
            // grb_TieuChiTimKiem
            // 
            this.grb_TieuChiTimKiem.Controls.Add(this.txt_TenMatHang_TimKiem);
            this.grb_TieuChiTimKiem.Controls.Add(this.lbl_TenMatHang);
            this.grb_TieuChiTimKiem.Controls.Add(this.btn_TimKiem);
            this.grb_TieuChiTimKiem.Location = new System.Drawing.Point(24, 60);
            this.grb_TieuChiTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.grb_TieuChiTimKiem.Name = "grb_TieuChiTimKiem";
            this.grb_TieuChiTimKiem.Padding = new System.Windows.Forms.Padding(4);
            this.grb_TieuChiTimKiem.Size = new System.Drawing.Size(664, 66);
            this.grb_TieuChiTimKiem.TabIndex = 33;
            this.grb_TieuChiTimKiem.TabStop = false;
            this.grb_TieuChiTimKiem.Text = "Tìm kiếm mặt hàng";
            // 
            // txt_TenMatHang_TimKiem
            // 
            this.txt_TenMatHang_TimKiem.Location = new System.Drawing.Point(116, 25);
            this.txt_TenMatHang_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenMatHang_TimKiem.Name = "txt_TenMatHang_TimKiem";
            this.txt_TenMatHang_TimKiem.Size = new System.Drawing.Size(256, 22);
            this.txt_TenMatHang_TimKiem.TabIndex = 0;
            // 
            // lbl_TenMatHang
            // 
            this.lbl_TenMatHang.AutoSize = true;
            this.lbl_TenMatHang.Location = new System.Drawing.Point(11, 28);
            this.lbl_TenMatHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenMatHang.Name = "lbl_TenMatHang";
            this.lbl_TenMatHang.Size = new System.Drawing.Size(96, 17);
            this.lbl_TenMatHang.TabIndex = 31;
            this.lbl_TenMatHang.Text = "Tên mặt hàng";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackgroundImage = global::GUI.Properties.Resources.Search;
            this.btn_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_TimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TimKiem.Location = new System.Drawing.Point(399, 21);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(93, 30);
            this.btn_TimKiem.TabIndex = 2;
            this.btn_TimKiem.TabStop = false;
            this.btn_TimKiem.Text = "T&ìm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // frm_XoaMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 554);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.grb_TieuChiTimKiem);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.grb_DanhSachMatHang);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_XoaMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xoa mat hang";
            this.Load += new System.EventHandler(this.frm_XoaMatHang_Load);
            this.grb_DanhSachMatHang.ResumeLayout(false);
            this.grb_TieuChiTimKiem.ResumeLayout(false);
            this.grb_TieuChiTimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.GroupBox grb_DanhSachMatHang;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.ListView lsv_DanhSachMatHang;
        private System.Windows.Forms.ColumnHeader Chon;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox grb_TieuChiTimKiem;
        private System.Windows.Forms.TextBox txt_TenMatHang_TimKiem;
        private System.Windows.Forms.Label lbl_TenMatHang;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}