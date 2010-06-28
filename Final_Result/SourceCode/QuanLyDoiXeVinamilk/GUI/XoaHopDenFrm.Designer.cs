namespace GUI
{
    partial class XoaHopDenFrm
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
            this.lblMaHopDen = new System.Windows.Forms.Label();
            this.txtMaHopDen = new System.Windows.Forms.TextBox();
            this.lblBienSo = new System.Windows.Forms.Label();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.lblLoaiXe = new System.Windows.Forms.Label();
            this.txtLoaiXe = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Location = new System.Drawing.Point(95, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(168, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "XÓA HỘP ĐEN";
            // 
            // lblMaHopDen
            // 
            this.lblMaHopDen.AutoSize = true;
            this.lblMaHopDen.Location = new System.Drawing.Point(13, 59);
            this.lblMaHopDen.Name = "lblMaHopDen";
            this.lblMaHopDen.Size = new System.Drawing.Size(65, 13);
            this.lblMaHopDen.TabIndex = 3;
            this.lblMaHopDen.Text = "Mã hộp đen";
            // 
            // txtMaHopDen
            // 
            this.txtMaHopDen.Location = new System.Drawing.Point(113, 56);
            this.txtMaHopDen.Name = "txtMaHopDen";
            this.txtMaHopDen.Size = new System.Drawing.Size(184, 20);
            this.txtMaHopDen.TabIndex = 4;
            // 
            // lblBienSo
            // 
            this.lblBienSo.AutoSize = true;
            this.lblBienSo.Location = new System.Drawing.Point(13, 107);
            this.lblBienSo.Name = "lblBienSo";
            this.lblBienSo.Size = new System.Drawing.Size(56, 13);
            this.lblBienSo.TabIndex = 3;
            this.lblBienSo.Text = "Biển số xe";
            // 
            // txtBienSo
            // 
            this.txtBienSo.Location = new System.Drawing.Point(113, 104);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.ReadOnly = true;
            this.txtBienSo.Size = new System.Drawing.Size(184, 20);
            this.txtBienSo.TabIndex = 4;
            // 
            // lblLoaiXe
            // 
            this.lblLoaiXe.AutoSize = true;
            this.lblLoaiXe.Location = new System.Drawing.Point(13, 158);
            this.lblLoaiXe.Name = "lblLoaiXe";
            this.lblLoaiXe.Size = new System.Drawing.Size(41, 13);
            this.lblLoaiXe.TabIndex = 3;
            this.lblLoaiXe.Text = "Loại xe";
            // 
            // txtLoaiXe
            // 
            this.txtLoaiXe.Location = new System.Drawing.Point(113, 155);
            this.txtLoaiXe.Name = "txtLoaiXe";
            this.txtLoaiXe.ReadOnly = true;
            this.txtLoaiXe.Size = new System.Drawing.Size(184, 20);
            this.txtLoaiXe.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(222, 199);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(113, 199);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // XoaHopDenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 249);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtLoaiXe);
            this.Controls.Add(this.lblLoaiXe);
            this.Controls.Add(this.txtBienSo);
            this.Controls.Add(this.lblBienSo);
            this.Controls.Add(this.txtMaHopDen);
            this.Controls.Add(this.lblMaHopDen);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.Name = "XoaHopDenFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xoa hop den";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaHopDen;
        private System.Windows.Forms.TextBox txtMaHopDen;
        private System.Windows.Forms.Label lblBienSo;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.Label lblLoaiXe;
        private System.Windows.Forms.TextBox txtLoaiXe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
    }
}