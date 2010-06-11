using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class PhanCongXeTaiXeBUS
    {
        #region 1.Insert

        public static bool ThemPhanCong(PhanCongXeTaiXeDTO aPhanCong)
        {
            bool blnDaThemDuoc = false;

            try
            {
                blnDaThemDuoc = PhanCongXeTaiXeDAO.ThemPhanCong(aPhanCong);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnDaThemDuoc;
        }

        #endregion

        #region 2.Select
        public static PhanCongXeTaiXeDTO LayPhanCongTheoNgay(DateTime NgayPhanCong)
        {
            PhanCongXeTaiXeDTO aPhanCong = null;
            try
            {
                aPhanCong = PhanCongXeTaiXeDAO.LayPhanCongTheoNgay(NgayPhanCong);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return aPhanCong;
        }

        public static PhanCongXeTaiXeDTO LayPhanCongTheoNgayVaNhanVienPC(DateTime NgayPhanCong, int iMaNhanVien)
        {
            PhanCongXeTaiXeDTO aPhanCong = null;
            try
            {
                aPhanCong = PhanCongXeTaiXeDAO.LayPhanCongTheoNgayVaNhanVienPC(NgayPhanCong, iMaNhanVien);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return aPhanCong;
        }
        #endregion
    }
}
