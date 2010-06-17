using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
   public class LoaiNhanVienDTO
    {
         #region Thuoc tinh cua LoaiNhanVienDTO
        private int m_nMaLoai;
        private String m_strTenLoai;
        #endregion

        #region Ham khoi tao LoaiNhanVienDTO
        public LoaiNhanVienDTO()
        {
            m_nMaLoai = -1;
            m_strTenLoai = String.Empty;
        }
        #endregion

        #region Cac phuong thuc truy xuat den LoaiNhanVienDTO
        public int MaLoai
        {
            get { return m_nMaLoai; }
            set { m_nMaLoai = value; }
        }
        public String TenLoai
        {
            get { return m_strTenLoai; }
            set { m_strTenLoai = value; }
        }

        #endregion
    }
}
