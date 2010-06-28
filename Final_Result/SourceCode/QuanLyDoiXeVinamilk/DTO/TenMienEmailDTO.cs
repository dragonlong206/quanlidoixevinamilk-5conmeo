using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TenMienEmailDTO
    {
         #region Thuoc tinh cua TenMienEmailDTO
        private int m_nMa;
        private String m_strTenMien;
        #endregion

        #region Ham khoi tao TenMienEmailDTO
        public TenMienEmailDTO()
        {
            m_nMa = -1;
            m_strTenMien = String.Empty;
        }
        #endregion

        #region Cac phuong thuc truy xuat den TenMienEmailDTO
        public int Ma
        {
            get { return m_nMa; }
            set { m_nMa = value; }
        }
        public String TenMien
        {
            get { return m_strTenMien; }
            set { m_strTenMien = value; }
        }

        #endregion
    }
}
