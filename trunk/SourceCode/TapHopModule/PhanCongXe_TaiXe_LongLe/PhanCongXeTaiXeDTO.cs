using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class PhanCongXeTaiXeDTO
    {
        #region Thuộc tính
        private int m_iMa;
        private int m_iMaNhanVienPhanCong;
        private DateTime m_NgayPhanCong;
        #endregion

        #region Phương thức truy xuất
        public int Ma
        {
            get { return m_iMa; }
            set { m_iMa = value; }
        }

        public int MaNhanVienPhanCong
        {
            get { return m_iMaNhanVienPhanCong; }
            set { m_iMaNhanVienPhanCong = value; }
        }

        public DateTime NgayPhanCong
        {
            get { return m_NgayPhanCong; }
            set { m_NgayPhanCong = value; }
        }
        #endregion

        #region Phương thức thiết lập
        public PhanCongXeTaiXeDTO()
        {
            m_iMa = -1;
            m_iMaNhanVienPhanCong = -1;
            m_NgayPhanCong = DateTime.MinValue;
        }
        #endregion
    }
}
