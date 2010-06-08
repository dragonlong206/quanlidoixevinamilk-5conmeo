namespace GUI
{
    partial class ThemHopDenFrm
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
            this.lblMaSoHopDen = new System.Windows.Forms.Label();
            this.txtNhapHopDen = new System.Windows.Forms.TextBox();
            this.lblBienSoXe = new System.Windows.Forms.Label();
            this.txtBienSoXe = new System.Windows.Forms.TextBox();
            this.lblLoaiXe = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.cboLoaiXe = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(42, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(168, 24);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "THÊM HỘP ĐEN";
            // 
            // lblMaSoHopDen
            // 
            this.lblMaSoHopDen.AutoSize = true;
            this.lblMaSoHopDen.Location = new System.Drawing.Point(32, 62);
            this.lblMaSoHopDen.Name = "lblMaSoHopDen";
            this.lblMaSoHopDen.Size = new System.Drawing.Size(65, 13);
            this.lblMaSoHopDen.TabIndex = 7;
            this.lblMaSoHopDen.Text = "Mã hộp đen";
            // 
            // txtNhapHopDen
            // 
            this.txtNhapHopDen.Location = new System.Drawing.Point(118, 55);
            this.txtNhapHopDen.Name = "txtNhapHopDen";
            this.txtNhapHopDen.Size = new System.Drawing.Size(101, 20);
            this.txtNhapHopDen.TabIndex = 8;
            // 
            // lblBienSoXe
            // 
            this.lblBienSoXe.AutoSize = true;
            this.lblBienSoXe.Location = new System.Drawing.Point(32, 107);
            this.lblBienSoXe.Name = "lblBienSoXe";
            this.lblBienSoXe.Size = new System.Drawing.Size(56, 13);
            this.lblBienSoXe.TabIndex = 9;
            this.lblBienSoXe.Text = "Biển số xe";
            this.lblBienSoXe.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBienSoXe
            // 
            this.txtBienSoXe.Location = new System.Drawing.Point(118, 100);
            this.txtBienSoXe.Name = "txtBienSoXe";
            this.txtBienSoXe.Size = new System.Drawing.Size(101, 20);
            this.txtBienSoXe.TabIndex = 10;
            // 
            // lblLoaiXe
            // 
            this.lblLoaiXe.AutoSize = true;
            this.lblLoaiXe.Location = new System.Drawing.Point(32, 154);
            this.lblLoaiXe.Name = "lblLoaiXe";
            this.lblLoaiXe.Size = new System.Drawing.Size(41, 13);
            this.lblLoaiXe.TabIndex = 11;
            this.lblLoaiXe.Text = "Loại xe";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(35, 190);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // bntThoat
            // 
            this.bntThoat.Location = new System.Drawing.Point(144, 190);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(75, 23);
            this.bntThoat.TabIndex = 14;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            // 
            // cboLoaiXe
            // 
            this.cboLoaiXe.FormattingEnabled = true;
            this.cboLoaiXe.Location = new System.Drawing.Point(118, 151);
            this.cboLoaiXe.Name = "cboLoaiXe";
            this.cboLoaiXe.Size = new System.Drawing.Size(101, 21);
            this.cboLoaiXe.TabIndex = 15;
            // 
            // ThemHopDenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 227);
            this.Controls.Add(this.cboLoaiXe);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblLoaiXe);
            this.Controls.Add(this.txtBienSoXe);
            this.Controls.Add(this.lblBienSoXe);
            this.Controls.Add(this.txtNhapHopDen);
            this.Controls.Add(this.lblMaSoHopDen);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ThemHopDenFrm";
            this.Text = "ThemHopDenFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaSoHopDen;
        private System.Windows.Forms.TextBox txtNhapHopDen;
        private System.Windows.Forms.Label lblBienSoXe;
        private System.Windows.Forms.TextBox txtBienSoXe;
        private System.Windows.Forms.Label lblLoaiXe;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.ComboBox cboLoaiXe;
    }
}