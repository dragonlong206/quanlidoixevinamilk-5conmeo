using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;


namespace GUI
{
    public partial class NhapMatHangGUI : Form
    {
        public NhapMatHangGUI()
        {
            InitializeComponent();
        }

        private void NhapMatHangFrm_Load(object sender, EventArgs e)
        {

        }        

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            MatHangDTO aMatHang = NhapMatHang();
            if (aMatHang == null)
                return; //khong lam gi ca.

            try
            {

                Boolean blnDaThemDuoc = MatHangBUS.ThemMatHang(aMatHang);
                if (blnDaThemDuoc == true)
                {
                    MessageBox.Show("Thêm mặt hàng thành công");
                }
                else
                {
                    MessageBox.Show("Loi ghi du lieu.\r\n vui long kiem tra du lieu nhap");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private MatHangDTO NhapMatHang()
        {
            MatHangDTO aMatHang = new MatHangDTO();
            if (!KiemTraNhap())
                return null;

            #region Gan gia tri tu giao dien vao MatHang.
            aMatHang.TenMatHang = txt_TenMatHang.Text;
            aMatHang.SoLuong = int.Parse(txt_SoLuong.Text);
            aMatHang.DonViTinh = txt_DonViTinh.Text;
            aMatHang.MaLoai = BUS.LoaiHangBUS.GetMaLoaiHang(cbo_LoaiHang.Text);
            #endregion

            return aMatHang;
        }

        private bool KiemTraNhap()
        {
            bool blnKetQua = true;

            #region Kiem tra tinh hop le.
            //KiemTra01: Kiem tra du lieu nhap co day du hay khong?
            blnKetQua &= !String.IsNullOrEmpty(txt_TenMatHang.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_SoLuong.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_DonViTinh.Text);
            blnKetQua &= !String.IsNullOrEmpty(cbo_LoaiHang.Text);           
            if (!blnKetQua)
            {
                MessageBox.Show("Du lieu nhap vao khong day du\r\nVui long kiem tra lai");
                return blnKetQua;
            }            
            #endregion            

            return blnKetQua;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
    }

      

        

    

}
