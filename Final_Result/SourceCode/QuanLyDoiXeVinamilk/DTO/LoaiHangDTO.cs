using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LoaiHangDTO
    {
        #region ThuocTinh LoaiHangDTO
        private String m_strTenLoaiHang;        
        private int m_nMaLoaiHang;
        #endregion

        #region Ham KhoiTao LoaiHangDTO
        public LoaiHangDTO()
        {
            m_strTenLoaiHang = String.Empty;
            m_nMaLoaiHang = -1;
        }
        #endregion

        #region PhuongThuc truy xuat LoaiHangDTO
        public String TenLoaiHang
        {
            get { return m_strTenLoaiHang; }
            set { m_strTenLoaiHang = value; }
        }

        public int MaLoaiHang
        {
            get { return m_nMaLoaiHang; }
            set { m_nMaLoaiHang = value; }
        }
        #endregion
    }
}
