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
        int m_nMaLoaiNhanVien;
        String m_strSoDienThoai;
        DateTime m_timeNgayVaoCongTy;
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
        public int MaLoaiNhanVien
        {
            get { return m_nMaLoaiNhanVien; }
            set { m_nMaLoaiNhanVien = value; }
        }
        public DateTime NgayVaoCongTy
        {
            get { return m_timeNgayVaoCongTy; }
            set { m_timeNgayVaoCongTy = value; }
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
            m_strTenNhanVien = String.Empty;
            m_nMaLoaiNhanVien = -1;
            m_strSoDienThoai = String.Empty;
            m_timeNgayVaoCongTy = DateTime.MaxValue;
        }
        #endregion
    }
}
