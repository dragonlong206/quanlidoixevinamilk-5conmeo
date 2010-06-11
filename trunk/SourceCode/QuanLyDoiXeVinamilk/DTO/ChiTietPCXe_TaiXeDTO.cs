using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChiTietPCXe_TaiXeDTO
    {
        #region Thuộc tính

        private int m_iMa;
        private string m_strBienSo;
        private int m_iMaPhanCong;
        private int m_iMaTaiXe;
        private string m_ThoiGianBatDau;
        private string m_ThoiGianKetThuc;

        #endregion

        #region Phương thức truy xuất

        public int Ma
        {
            get { return m_iMa; }
            set { m_iMa = value; }
        }

        public string BienSoXe
        {
            get { return m_strBienSo; }
            set { m_strBienSo = value; }
        }

        public int MaPhanCong
        {
            get { return m_iMaPhanCong; }
            set { m_iMaPhanCong = value; }
        }

        public int MaTaiXe
        {
            get { return m_iMaTaiXe; }
            set { m_iMaTaiXe = value; }
        }

        public string ThoiGianBatDau
        {
            get { return m_ThoiGianBatDau; }
            set { m_ThoiGianBatDau = value; }
        }

        public string ThoiGianKetThuc
        {
            get { return m_ThoiGianKetThuc; }
            set { m_ThoiGianKetThuc = value; }
        }

        #endregion

        #region Phương thức thiết lập

        public ChiTietPCXe_TaiXeDTO()
        {
            m_iMa = -1;
            m_strBienSo = string.Empty;
            m_iMaPhanCong = -1;
            m_iMaTaiXe = -1;
            m_ThoiGianBatDau = string.Empty;
            m_ThoiGianKetThuc = string.Empty;
        }

        #endregion
    }
}
