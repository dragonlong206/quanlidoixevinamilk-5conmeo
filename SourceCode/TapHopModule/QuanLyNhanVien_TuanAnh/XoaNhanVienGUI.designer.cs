namespace GUI
{
    partial class XoaNhanVienGUI
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
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.grb_DanhSachNhanVien = new System.Windows.Forms.GroupBox();
            this.lsv_DanhSachNhanVien = new System.Windows.Forms.ListView();
            this.Chọn = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grb_DanhSachNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(331, 500);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(100, 28);
            this.btn_Xoa.TabIndex = 0;
            this.btn_Xoa.Text = "&Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // grb_DanhSachNhanVien
            // 
            this.grb_DanhSachNhanVien.Controls.Add(this.lsv_DanhSachNhanVien);
            this.grb_DanhSachNhanVien.Location = new System.Drawing.Point(36, 63);
            this.grb_DanhSachNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.grb_DanhSachNhanVien.Name = "grb_DanhSachNhanVien";
            this.grb_DanhSachNhanVien.Padding = new System.Windows.Forms.Padding(4);
            this.grb_DanhSachNhanVien.Size = new System.Drawing.Size(521, 427);
            this.grb_DanhSachNhanVien.TabIndex = 2;
            this.grb_DanhSachNhanVien.TabStop = false;
            this.grb_DanhSachNhanVien.Text = "Danh sách nhân viên";
            // 
            // lsv_DanhSachNhanVien
            // 
            this.lsv_DanhSachNhanVien.CheckBoxes = true;
            this.lsv_DanhSachNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Chọn,
            this.columnHeader1,
            this.columnHeader2});
            this.lsv_DanhSachNhanVien.GridLines = true;
            this.lsv_DanhSachNhanVien.Location = new System.Drawing.Point(42, 27);
            this.lsv_DanhSachNhanVien.Name = "lsv_DanhSachNhanVien";
            this.lsv_DanhSachNhanVien.Size = new System.Drawing.Size(461, 381);
            this.lsv_DanhSachNhanVien.TabIndex = 0;
            this.lsv_DanhSachNhanVien.UseCompatibleStateImageBehavior = false;
            this.lsv_DanhSachNhanVien.View = System.Windows.Forms.View.Details;
            this.lsv_DanhSachNhanVien.SelectedIndexChanged += new System.EventHandler(this.lsv_DanhSachNhanVien_SelectedIndexChanged);
            // 
            // Chọn
            // 
            this.Chọn.Text = "Chọn";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Nhân Viên";
            this.columnHeader1.Width = 111;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Điện Thoại";
            this.columnHeader2.Width = 136;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(457, 500);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(100, 28);
            this.btn_Thoat.TabIndex = 1;
            this.btn_Thoat.Text = "&Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Location = new System.Drawing.Point(175, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(212, 29);
            this.lblTitle.TabIndex = 39;
            this.lblTitle.Text = "XÓA NHÂN VIÊN";
            // 
            // XoaNhanVienGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 534);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.grb_DanhSachNhanVien);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "XoaNhanVienGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xoa nhan vien";
            this.Load += new System.EventHandler(this.XoaNhanVienGUI_Load);
            this.grb_DanhSachNhanVien.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.GroupBox grb_DanhSachNhanVien;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView lsv_DanhSachNhanVien;
        private System.Windows.Forms.ColumnHeader Chọn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}