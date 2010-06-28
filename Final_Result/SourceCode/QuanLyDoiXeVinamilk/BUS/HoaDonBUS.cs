using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class HoaDonBUS
    {
        #region 1.Insert

        public static bool ThemHoaDon(HoaDonDTO aHoaDon)
        {
            bool blnDaThemDuoc = false;

            try
            {
                blnDaThemDuoc = HoaDonDAO.ThemHoaDon(aHoaDon);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnDaThemDuoc;
        }

        #endregion

        #region 2.Select

        public static HoaDonDTO LayHoaDonTheoNgayGiaoVaBienSoXe(DateTime NgayGiao, String strBienSoXe)
        {
            HoaDonDTO aHoaDon = null;

            try
            {
                aHoaDon = HoaDonDAO.LayHoaDonTheoNgayGiaoVaBienSoXe(NgayGiao, strBienSoXe);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return aHoaDon;
        }

        #endregion
    }
}
