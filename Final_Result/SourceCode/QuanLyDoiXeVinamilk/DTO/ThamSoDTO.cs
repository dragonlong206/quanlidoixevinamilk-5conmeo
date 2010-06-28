using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ThamSoDTO
    {
        #region Thuoc tinh cua ThamSoDTO

        private int m_nMaSo;
        private String m_strTenThamSo;
        private String m_strGiaTri;
        
        #endregion

        #region Ham khoi tao ThamSoDTO
        public ThamSoDTO()
        {
            m_nMaSo = -1;
            m_strTenThamSo = String.Empty;
            m_strGiaTri = String.Empty;            
        }
        #endregion

        #region Cac phuong thuc truy xuat den ThamSoDTO
        public int Ma
        {
            get { return m_nMaSo; }
            set { m_nMaSo = value; }
        }
        public String TenThamSo
        {
            get { return m_strTenThamSo; }
            set { m_strTenThamSo = value; }
        }

        public String GiaTri
        {
            get { return m_strGiaTri; }
            set { m_strGiaTri = value; }
        }        
        #endregion
    }
}
