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

        #region Xuat thong tin Xe.
        private void TiepNhanXeGUI_Load(object sender, EventArgs e)
        {
            try
            {
                List<DTO.XeDTO> lstXe = BUS.XeBUS.DocDanhSachXe(String.Empty);
                XuatDanhSachXe(lstXe);


                // Load tên hãng xe
                List<DTO.HangXeDTO> DanhSachHangXe = BUS.HangXeBUS.DocDanhSachHangXe(string.Empty);
                if (DanhSachHangXe.Count > 0)
                {
                    this.cbo_HangXe.DataSource = DanhSachHangXe;
                    this.cbo_HangXe.DisplayMember = "TenHang";
                    this.cbo_HangXe.ValueMember = "MaHang";
                }

                // Load loại hàng
                List<DTO.LoaiHangDTO> DanhSachLoaiHang = BUS.LoaiHangBUS.DocDanhSachLoaiHang(string.Empty);
                if (DanhSachLoaiHang.Count > 0)
                {
                    this.cbo_LoaiHang.DataSource = DanhSachLoaiHang;
                    this.cbo_LoaiHang.DisplayMember = "TenLoai";
                    this.cbo_LoaiHang.ValueMember = "MaLoai";
                }

                // Load nhân viên tiếp nhận
                List<DTO.NhanVienDTO> DanhSachNhanVien = BUS.NhanVienBUS.LayDanhSachNhanVien();
                if (DanhSachNhanVien.Count > 0)
                {
                    this.cbo_NhanVienTiepNhan.DataSource = DanhSachNhanVien;
                    this.cbo_NhanVienTiepNhan.DisplayMember = "TenNhanVien";
                    this.cbo_NhanVienTiepNhan.ValueMember = "MaNhanVien";
                }

                // Load loại trọng tải
                List<DTO.TrongTaiDTO> DanhSachTrongTai = BUS.TrongTaiBUS.DocDanhSachTrongTai(string.Empty);
                if (DanhSachTrongTai.Count > 0)
                {
                    this.cbo_TrongTai.DataSource = DanhSachTrongTai;
                    this.cbo_TrongTai.DisplayMember = "GiaTri";
                    this.cbo_TrongTai.ValueMember = "MaTrongTai";
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void XuatDanhSachXe(List<DTO.XeDTO> lstXe)
        {
            if (lstXe == null)
                return;     //khong lam gi ca.          

            lsv_DanhSachXe.Items.Clear();
            int nSoThuTu = 1;
            foreach (DTO.XeDTO aXeTemp in lstXe)
            {
                lsv_DanhSachXe.Items.Add(TheHienListItem(nSoThuTu, aXeTemp));
                nSoThuTu++;
            }
        }

        private ListViewItem TheHienListItem(int nSoThuTu, DTO.XeDTO aXe)
        {
            ListViewItem itemKetQua = new ListViewItem(nSoThuTu.ToString());
            itemKetQua.SubItems.Add(aXe.BienSo);            
            itemKetQua.SubItems.Add(aXe.NgayTiepNhan.ToString());
            itemKetQua.SubItems.Add(aXe.NamSanXuat.ToString());
            itemKetQua.SubItems.Add(aXe.HieuXe);
            itemKetQua.SubItems.Add(BUS.NhanVienBUS.GetTenNhanVien(aXe.MaNhanVienTiepNhan));

            itemKetQua.SubItems.Add(aXe.SoKhung);                       
            itemKetQua.SubItems.Add(aXe.SoMay);
            itemKetQua.SubItems.Add(aXe.DungTichBinh.ToString());
            itemKetQua.SubItems.Add(aXe.NgayDangKiem.ToString());
            itemKetQua.SubItems.Add(aXe.DinhMuc.ToString());
            itemKetQua.SubItems.Add(BUS.TrongTaiBUS.GetTenTrongTai(aXe.MaTrongTai));
            itemKetQua.SubItems.Add(BUS.HangXeBUS.GetTenHangXe(aXe.MaHangXe));
            itemKetQua.SubItems.Add(BUS.LoaiHangBUS.GetTenLoaiHang(aXe.MaLoaiHang));
            
            itemKetQua.Tag = aXe;

            return itemKetQua;
        }
        #endregion                                     

        #region Them Xe

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            DTO.XeDTO aXe = NhapXe();
            if (aXe == null)
                return; //khong lam gi ca.            
            
            try
            {
                String strThongBao = "Loi ghi du lieu: vui long kiem tra du lieu nhap";
                if (BUS.XeBUS.ThemXe(aXe))
                {
                    //TiepNhanXeGUI_Load(sender, e);
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
            if (!KiemTraNhap())  
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

        #endregion        

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

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lsv_DanhSachXe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grb_ThongTinXe_Enter(object sender, EventArgs e)
        {

        }

        private void lsv_DanhSachXe_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
       
    }
}