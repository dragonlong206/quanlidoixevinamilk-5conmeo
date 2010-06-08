using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LoaiHangDTO
    {
        #region ThuocTinh LoaiHangDTO
        private String m_strTenLoai;        
        private int m_nMaLoaiHang;
        #endregion

        #region Ham KhoiTao LoaiHangDTO
        public LoaiHangDTO()
        {
            m_strTenLoai = String.Empty;
            m_nMaLoaiHang = -1;
        }
        #endregion

        #region PhuongThuc truy xuat LoaiHangDTO
        public String TenLoai
        {
            get { return m_strTenLoai; }
            set { m_strTenLoai = value; }
        }

        public int MaLoaiHang
        {
            get { return m_nMaLoaiHang; }
            set { m_nMaLoaiHang = value; }
        }
        #endregion
    }
}
