using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class TiepNhanXeGUI : Form
    {
        public TiepNhanXeGUI()
        {
            InitializeComponent();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            DTO.XeDTO aXe = NhapXe();
            if (aXe == null)
                return; //khong lam gi ca.            
            
            try
            {
                String strThongBao = "Bi loi ghi du lieu: vui long kiem tra du lieu nhap";
                if (BUS.XeBUS.ThemXe(aXe))
                {
                    strThongBao = "Tiep nhan xe thanh cong";
                }
                MessageBox.Show(strThongBao);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
            }            
        }

        private DTO.XeDTO NhapXe()
        {
            DTO.XeDTO aXe = new DTO.XeDTO();
            if (!KiemTraNhap())  //Cac dong thong bao cu the duoc thuc hien trong KiemTraNhap()                          
                return null;            

            #region Gan gia tri tu giao dienvao aXe
            try
            {
                aXe.BienSo = txt_BienSo.Text;
                aXe.HieuXe = txt_HieuXe.Text;
                aXe.NgayTiepNhan = DateTime.Parse(dtp_NgayTiepNhan.Text);
                aXe.NgayDangKiem = DateTime.Parse(dtp_NgayDangKiem.Text);
                aXe.NamSanXuat = int.Parse(txt_NamSanXuat.Text);
                aXe.SoKhung = txt_SoKhung.Text;
                aXe.SoMay = txt_SoMay.Text;
                aXe.DungTichBinh = float.Parse(txt_DungTichBinh.Text);
                aXe.DinhMuc = float.Parse(txt_DinhMucNhienLieu.Text);
                aXe.MaHangXe = BUS.HangXeBUS.GetMaHangXe(cbo_HangXe.Text);                //Sua truy xuat qua CSDL
                aXe.MaTrongTai = BUS.TrongTaiBUS.GetMaTrongTai(cbo_TrongTai.Text);        //Sua truy xuat qua CSDL
                aXe.MaLoaiHang = BUS.LoaiHangBUS.GetMaLoaiHang(cbo_LoaiHang.Text);        //Sua truy xuat qua CSDL
                aXe.MaNhanVienTiepNhan = BUS.NhanVienBUS.GetMaNhanVien(cbo_NhanVienTiepNhan.Text);//Sua truy xuat qua CSDL
                //aXe.MaHangXe = this.cbo_HangXe.SelectedIndex;               //Chinh sua sau.
                //aXe.MaLoaiHang = this.cbo_LoaiHang.SelectedIndex;
                //aXe.MaNhanVienTiepNhan = this.cbo_NhanVienTiepNhan.SelectedIndex;
                //aXe.MaTrongTai = this.cbo_TrongTai.SelectedIndex;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
                return null;
            }
            #endregion

            return aXe;
        }

        private bool KiemTraNhap()
        {
            bool blnKetQua = true;

            #region Kiem tra tinh hop le.
            //KiemTra01: Kiem tra du lieu nhap co day du hay khong?
            blnKetQua &= !String.IsNullOrEmpty(txt_BienSo.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_HieuXe.Text);
            blnKetQua &= !String.IsNullOrEmpty(dtp_NgayTiepNhan.Text);
            blnKetQua &= !String.IsNullOrEmpty(dtp_NgayDangKiem.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_NamSanXuat.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_SoKhung.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_SoMay.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_DungTichBinh.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_DinhMucNhienLieu.Text);
            blnKetQua &= !String.IsNullOrEmpty(cbo_HangXe.Text);
            blnKetQua &= !String.IsNullOrEmpty(cbo_TrongTai.Text);
            blnKetQua &= !String.IsNullOrEmpty(cbo_LoaiHang.Text);
            blnKetQua &= !String.IsNullOrEmpty(cbo_NhanVienTiepNhan.Text);
            if(!blnKetQua)
            {
                MessageBox.Show("Du lieu nhap vao khong day du\r\nVui long kiem tra lai");
                return blnKetQua;
            }

            //KiemTra02: NgayDangKiem va NgayTiepNhan khong duoc vuot qua ngay hien tai.
            blnKetQua &= DateTime.Parse(dtp_NgayDangKiem.Text) <= DateTime.Today;
            blnKetQua &= DateTime.Parse(dtp_NgayTiepNhan.Text) <= DateTime.Today;
            if(!blnKetQua)
            {
                MessageBox.Show("Ngay Dang Kiem hoac Ngay Tiep Nhan vuot qua ngay hien tai");
                return blnKetQua;
            }           
            #endregion

            #region Kiem tra cac rang buoc.                         
            //RangBuoc01: Chi nhap cac xe trong thoi gian cho phep (vi du 10 nam tro lai):
            int nNamSanXuat = int.Parse(txt_NamSanXuat.Text);
            int nSoNamToiDa = BUS.ThamSoBUS.GetSoNamToiDa();
            blnKetQua &= (DateTime.Today.Year - nNamSanXuat) <= nSoNamToiDa;
            if (!blnKetQua)
            {
                MessageBox.Show("Chi tiep nhan cac xe trong vong " + nSoNamToiDa + " nam tro lai.");
                return blnKetQua;
            }
            //RangBuoc02: DinhMucNhienLieu phai nho hon hoac bang Dung Tich Binh.
            blnKetQua &= float.Parse(txt_DinhMucNhienLieu.Text) <= float.Parse(txt_DungTichBinh.Text);
            if(!blnKetQua)
            {
                MessageBox.Show("Dinh Muc Nhien Lieu phai nho hon hoac bang Dung Tich Binh");
                return blnKetQua;
            }

            //RangBuoc03: NgayDangKiem phai nho hon hoac bang NgayTiepNhan.            
            blnKetQua &= DateTime.Parse(dtp_NgayDangKiem.Text) <= DateTime.Parse(dtp_NgayTiepNhan.Text);
            if(!blnKetQua)
            {
                MessageBox.Show("Ngay Dang Kiem phai nho hon hoac bang Ngay Tiep Nhan");
                return blnKetQua;
            }            

            //RangBuoc04: Chi cho phep chon cac HangXe,NhanVien,... tu comboBox => Xy ly ve giao dien.            
            #endregion

            return blnKetQua;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            txt_BienSo.Text = String.Empty;
            txt_DinhMucNhienLieu.Text = String.Empty;
            txt_DungTichBinh.Text = String.Empty;
            txt_HieuXe.Text = String.Empty;
            txt_NamSanXuat.Text = String.Empty;
            txt_SoKhung.Text = String.Empty;
            txt_SoMay.Text = String.Empty;
            cbo_HangXe.Text = String.Empty;
            cbo_LoaiHang.Text = String.Empty;
            cbo_NhanVienTiepNhan.Text = String.Empty;
            cbo_TrongTai.Text = String.Empty;
            dtp_NgayDangKiem.Text = String.Empty;
        }              
    }
}