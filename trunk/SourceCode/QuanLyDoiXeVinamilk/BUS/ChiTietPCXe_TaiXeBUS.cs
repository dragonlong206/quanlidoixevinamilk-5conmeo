using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class ChiTietPCXe_TaiXeBUS
    {
        #region 1.Insert
        public static bool ThemChiTiet(ChiTietPCXe_TaiXeDTO aChiTiet)
        {
            bool blnDaThemDuoc = false;

            try
            {
                int nSoDongThemDuoc = ChiTietPCXe_TaiXeDAO.ThemChiTiet(aChiTiet);
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
