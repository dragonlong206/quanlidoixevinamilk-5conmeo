using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class ChiTietHoaDonBUS
    {
        #region 1.Insert
        public static bool ThemChiTiet(ChiTietHoaDonDTO aChiTiet)
        {
            bool blnDaThemDuoc = false;

            try
            {
                int nSoDongThemDuoc = ChiTietHoaDonDAO.ThemChiTiet(aChiTiet);
                if (nSoDongThemDuoc == 1)
                {
                    blnDaThemDuoc = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnDaThemDuoc;
        }
        #endregion
    }
}
