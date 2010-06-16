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

        #region 2.Update
        public static bool CapNhatChiTiet(ChiTietPCXe_TaiXeDTO aChiTiet)
        {
            bool blnCapNhatThanhCong = false;

            try
            {
                int nSoDongCapNhatDuoc = ChiTietPCXe_TaiXeDAO.CapNhatChiTiet(aChiTiet);

                if (nSoDongCapNhatDuoc == 1)
                {
                    blnCapNhatThanhCong = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnCapNhatThanhCong;
        }
        #endregion

        #region 3.Delete
        public static bool XoaChiTiet(int iMaChiTiet)
        {
            bool blnDaXoaDuoc = false;

            try
            {
                int nSoDongXoaDuoc = ChiTietPCXe_TaiXeDAO.XoaChiTiet(iMaChiTiet);

                if (iMaChiTiet == 1)
                {
                    blnDaXoaDuoc = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnDaXoaDuoc;
        }
        #endregion

        #region 4.Select
        public static DataTable LayDanhSachChiTietTheoMaPhanCong(int iMaPhanCong)
        {
            DataTable KetQua = null;
            try
            {
                KetQua = ChiTietPCXe_TaiXeDAO.LayDanhSachChiTietTheoMaPhanCong(iMaPhanCong);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return KetQua;
        }
        #endregion
    }
}
