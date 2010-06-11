using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NhanVienDTO
    {
        #region 1.ThuocTinh
        int m_iMaNhanVien;
        String m_strTenNhanVien;
        String m_strSoDienThoai;
        #endregion

        #region 2.PhuongThucTruyXuat
        public int MaNhanVien
        {
            get { return m_iMaNhanVien; }
            set { m_iMaNhanVien = value; }
        }

        public String TenNhanVien
        {
            get { return m_strTenNhanVien; }
            set { m_strTenNhanVien = value; }
        }

        public String SoDienThoai
        {
            get { return m_strSoDienThoai; }
            set { m_strSoDienThoai = value; }
        }
        #endregion

        #region 3.PhuongThucThietLap
        public NhanVienDTO()
        {
            m_iMaNhanVien = -1;
            m_strSoDienThoai = String.Empty;
            m_strTenNhanVien = String.Empty;
        }
        #endregion
    }
}
