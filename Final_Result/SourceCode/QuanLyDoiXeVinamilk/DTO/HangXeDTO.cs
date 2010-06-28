using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class HangXeDTO
    {
        #region ThuocTinhHangXe 
        private int m_nMaHang;       
        private string m_strTenHang;       
        #endregion
        #region TRuyXuat
        public int MaHang
        {
            get { return m_nMaHang; }
            set { m_nMaHang = value; }
        }
        public string TenHang
        {
            get { return m_strTenHang; }
            set { m_strTenHang = value; }
        }
        #endregion
        #region KhoiGan
        public HangXeDTO()
        {
        m_nMaHang = -1;
        m_strTenHang = String.Empty;
        }

        #endregion
    }
}
