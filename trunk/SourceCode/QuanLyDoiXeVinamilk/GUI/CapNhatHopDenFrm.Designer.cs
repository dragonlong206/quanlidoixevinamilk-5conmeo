namespace GUI
{
    partial class CapNhatHopDenFrm
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
            this.bntThoat = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtLoaiXe = new System.Windows.Forms.TextBox();
            this.lblLoaiXe = new System.Windows.Forms.Label();
            this.txtBienSoXe = new System.Windows.Forms.TextBox();
            this.lblBienSoXe = new System.Windows.Forms.Label();
            this.txtNhapHopDen = new System.Windows.Forms.TextBox();
            this.lblMaSoHopDen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(38, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(213, 24);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "CẬP NHẬT HỘP ĐEN";
            // 
            // bntThoat
            // 
            this.bntThoat.Location = new System.Drawing.Point(161, 187);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(75, 23);
            this.bntThoat.TabIndex = 22;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(52, 187);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 21;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // txtLoaiXe
            // 
            this.txtLoaiXe.Location = new System.Drawing.Point(135, 144);
            this.txtLoaiXe.Name = "txtLoaiXe";
            this.txtLoaiXe.Size = new System.Drawing.Size(101, 20);
            this.txtLoaiXe.TabIndex = 20;
            // 
            // lblLoaiXe
            // 
            this.lblLoaiXe.AutoSize = true;
            this.lblLoaiXe.Location = new System.Drawing.Point(49, 151);
            this.lblLoaiXe.Name = "lblLoaiXe";
            this.lblLoaiXe.Size = new System.Drawing.Size(41, 13);
            this.lblLoaiXe.TabIndex = 19;
            this.lblLoaiXe.Text = "Loại xe";
            // 
            // txtBienSoXe
            // 
            this.txtBienSoXe.Location = new System.Drawing.Point(135, 97);
            this.txtBienSoXe.Name = "txtBienSoXe";
            this.txtBienSoXe.Size = new System.Drawing.Size(101, 20);
            this.txtBienSoXe.TabIndex = 18;
            // 
            // lblBienSoXe
            // 
            this.lblBienSoXe.AutoSize = true;
            this.lblBienSoXe.Location = new System.Drawing.Point(49, 104);
            this.lblBienSoXe.Name = "lblBienSoXe";
            this.lblBienSoXe.Size = new System.Drawing.Size(56, 13);
            this.lblBienSoXe.TabIndex = 17;
            this.lblBienSoXe.Text = "Biển số xe";
            // 
            // txtNhapHopDen
            // 
            this.txtNhapHopDen.Location = new System.Drawing.Point(135, 52);
            this.txtNhapHopDen.Name = "txtNhapHopDen";
            this.txtNhapHopDen.Size = new System.Drawing.Size(101, 20);
            this.txtNhapHopDen.TabIndex = 16;
            // 
            // lblMaSoHopDen
            // 
            this.lblMaSoHopDen.AutoSize = true;
            this.lblMaSoHopDen.Location = new System.Drawing.Point(49, 59);
            this.lblMaSoHopDen.Name = "lblMaSoHopDen";
            this.lblMaSoHopDen.Size = new System.Drawing.Size(65, 13);
            this.lblMaSoHopDen.TabIndex = 15;
            this.lblMaSoHopDen.Text = "Mã hộp đen";
            // 
            // CapNhatHopDenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 226);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtLoaiXe);
            this.Controls.Add(this.lblLoaiXe);
            this.Controls.Add(this.txtBienSoXe);
            this.Controls.Add(this.lblBienSoXe);
            this.Controls.Add(this.txtNhapHopDen);
            this.Controls.Add(this.lblMaSoHopDen);
            this.Controls.Add(this.lblTitle);
            this.Name = "CapNhatHopDenFrm";
            this.Text = "CapNhatHopDenFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtLoaiXe;
        private System.Windows.Forms.Label lblLoaiXe;
        private System.Windows.Forms.TextBox txtBienSoXe;
        private System.Windows.Forms.Label lblBienSoXe;
        private System.Windows.Forms.TextBox txtNhapHopDen;
        private System.Windows.Forms.Label lblMaSoHopDen;
    }
}