using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    [Serializable]
    public class XeDTO
    {
        #region ThuocTinh XeDTO:
        private String m_strBienSo;
        private String m_strHieuXe;
        private DateTime m_timeNgayTiepNhan;
        private DateTime m_timeNgayDangKiem;
        private int m_nNamSanXuat;
        private String m_nSoKhung;
        private String m_nSoMay;
        private float m_dDungTichBinh;
        private float m_dDinhMuc;
        private int m_nMaHangXe;
        private int m_nMaTrongTai;
        private int m_nMaLoaiHang;
        private int m_nMaNhanVienTiepNhan;
        #endregion

        #region Ham KhoiTao XeDTO
        public XeDTO()
        {
            m_strBienSo = String.Empty;
            m_strHieuXe = String.Empty;
            m_timeNgayTiepNhan = DateTime.Today;
            m_timeNgayDangKiem = DateTime.MaxValue;
            m_nNamSanXuat = -1;
            m_nSoKhung = String.Empty;
            m_nSoMay = String.Empty;
            m_dDungTichBinh = -1;
            m_dDinhMuc = -1;
            m_nMaHangXe = -1;
            m_nMaTrongTai = -1;
            m_nMaLoaiHang = -1;
            m_nMaNhanVienTiepNhan = -1;
        }
        #endregion

        #region PhuongThuc truy xuat XeDTO
        public String BienSo
        {
            get { return m_strBienSo; }
            set { m_strBienSo = value; }
        }

        public String HieuXe
        {
            get { return m_strHieuXe; }
            set { m_strHieuXe = value; }
        }

        public DateTime NgayTiepNhan
        {
            get { return m_timeNgayTiepNhan; }
            set { m_timeNgayTiepNhan = value; }
        }

        public DateTime NgayDangKiem
        {
            get { return m_timeNgayDangKiem; }
            set { m_timeNgayDangKiem = value; }
        }

        public int NamSanXuat
        {
            get { return m_nNamSanXuat; }
            set { m_nNamSanXuat = value; }
        }

        public String SoKhung
        {
            get { return m_nSoKhung; }
            set { m_nSoKhung = value; }
        }

        public String SoMay
        {
            get { return m_nSoMay; }
            set { m_nSoMay = value; }
        }

        public float DungTichBinh
        {
            get { return m_dDungTichBinh; }
            set { m_dDungTichBinh = value; }
        }

        public float DinhMuc
        {
            get { return m_dDinhMuc; }
            set { m_dDinhMuc = value; }
        }

        public int MaHangXe
        {
            get { return m_nMaHangXe; }
            set { m_nMaHangXe = value; }
        }

        public int MaTrongTai
        {
            get { return m_nMaTrongTai; }
            set { m_nMaTrongTai = value; }
        }

        public int MaLoaiHang
        {
            get { return m_nMaLoaiHang; }
            set { m_nMaLoaiHang = value; }
        }

        public int MaNhanVienTiepNhan
        {
            get { return m_nMaNhanVienTiepNhan; }
            set { m_nMaNhanVienTiepNhan = value; }
        }
        #endregion
    }
}
