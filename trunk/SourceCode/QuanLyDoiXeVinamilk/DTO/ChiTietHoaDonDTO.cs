using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChiTietHoaDonDTO
    {
        #region Thuộc tính
        private int m_iMa;
        private int m_iMaDiaDiem;
        private int m_iMaHoaDon;
        private int m_iMaMatHang;
        private int m_iMaTrangThai;
        private int m_nSoLuong;
        #endregion

        #region Phương thức truy xuất
        public int Ma
        {
            get { return m_iMa; }
            set { m_iMa = value; }
        }

        public int MaDiaDiem
        {
            get { return m_iMaDiaDiem; }
            set { m_iMaDiaDiem = value; }
        }

        public int MaHoaDon
        {
            get { return m_iMaHoaDon; }
            set { m_iMaHoaDon = value; }
        }

        public int MaMatHang
        {
            get { return m_iMaMatHang; }
            set { m_iMaMatHang = value; }
        }

        public int MaTrangThai
        {
            get { return m_iMaTrangThai; }
            set { m_iMaTrangThai = value; }
        }

        public int SoLuong
        {
            get { return m_nSoLuong; }
            set { m_nSoLuong = value; }
        }
        #endregion

        #region Phương thức thiết lập

        #endregion
    }
}
