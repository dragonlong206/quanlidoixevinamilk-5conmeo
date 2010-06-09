using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data.OleDb;
using System.Data;

namespace BUS
{
    public class HangXeBUS
    {
        public static int GetMaHangXe(String strTenHangXe)
        {
            //Tam thoi dung ham nay: chinh sua truy xuat CSDL sau.
            switch(strTenHangXe)
            {
                case "TOYOTA":
                    return 1;
                case "HONDA":
                    return 2;
                case "MERCIDES":
                    return 3;
                default:
                    return -1;
            }
        }

        public static String GetTenHangXe(int nMaHangXe)
        {
            //Tam thoi dung ham nay: chinh sua truy xuat CSDL sau.
            switch(nMaHangXe)
            {
                case 1:
                    return "TOYOTA";
                case 2:
                    return "HONDA";
                case 3:
                    return "MERCIDES";
                default:
                    return "Error!";
            }
        }

        #region 1.Insert
        public static Boolean ThemHangXeBus(HangXeDTO HangXe)
        {
            Boolean blnDaThemDuoc = false;
            try
            {
                blnDaThemDuoc = HangXeDAO.ThemHangXeDAO(HangXe);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return blnDaThemDuoc;

        }
        #endregion
      

        #region 2.Delete
        public static Boolean XoaHangXeBUS(HangXeDTO HangXe)
        {
            Boolean blnDaXoaDuoc = false;
            try
            {
                blnDaXoaDuoc = HangXeDAO.XoaHangXeDAO(HangXe);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return blnDaXoaDuoc;
        }
        #endregion
        #region 3.Update
        public static bool CapNhatHangXe(HangXeDTO  hx)
        {
            try
            {
                if (HangXeDAO.KiemTraMaHangXe(hx.MaHang))
                {
                    return HangXeDAO.CapNhatHangXeDAO(hx);
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #endregion

        #region 4.Select
        public static List<HangXeDTO> LayDanhSachTatCaCacHangXe()
        {
            return HangXeDAO.LayDanhSachTatCaCacHangXe();
        }
        public static HangXeDTO LayDanhSachHangXeTheMaHangXe(int MaHangXe)
        {
            if (HangXeDAO.KiemTraMaHangXe(MaHangXe))
            {
                return null;
            }
            return HangXeDAO.LayHangXeTheoMaHang(MaHangXe);
        }

        #endregion

    }
}
