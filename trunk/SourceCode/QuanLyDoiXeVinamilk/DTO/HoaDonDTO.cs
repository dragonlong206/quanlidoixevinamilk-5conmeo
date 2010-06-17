using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class HoaDonDTO
    {
        #region Thuộc tính

        private int m_iMa;
        private DateTime m_NgayGiaoHang;
        private DateTime m_NgayLap;
        private String m_XeGiaoHang = String.Empty;

        #endregion

        #region Phương thức truy xuất
        public int Ma
        {
            get { return m_iMa; }
            set { m_iMa = value; }
        }

        public DateTime NgayGiaoHang
        {
            get { return m_NgayGiaoHang; }
            set { m_NgayGiaoHang = value; }
        }

        public DateTime NgayLap
        {
            get { return m_NgayLap; }
            set { m_NgayLap = value; }
        }

        public String XeGiaoHang
        {
            get { return m_XeGiaoHang; }
            set { m_XeGiaoHang = value; }
        }
        #endregion
    }
}
