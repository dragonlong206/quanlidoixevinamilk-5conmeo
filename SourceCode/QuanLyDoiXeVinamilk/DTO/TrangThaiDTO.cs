using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TrangThaiDTO
    {
        #region Thuoc tinh

        private int m_iMaTrangThai;
        private string m_strTenTrangThai = String.Empty;

        #endregion

        #region Phuong thuc truy xuat

        public int MaTrangThai
        {
            get { return m_iMaTrangThai; }
            set { m_iMaTrangThai = value; }
        }

        public string TenTrangThai
        {
            get { return m_strTenTrangThai; }
            set { m_strTenTrangThai = value; }
        }

        #endregion

        #region Phuong thuc thiet lap

        public TrangThaiDTO()
        {
            m_iMaTrangThai = -1;
            m_strTenTrangThai = String.Empty;
        }

        #endregion
    }
}
