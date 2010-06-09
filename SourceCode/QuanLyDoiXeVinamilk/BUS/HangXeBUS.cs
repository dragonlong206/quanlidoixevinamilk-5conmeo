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
        
        public static Boolean ThemHangXe(HangXeDTO HangXe)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = DAO.HangXeDAO.ThemHangXe(HangXe);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return blnKetQua;

        }        
              
        public static Boolean XoaHangXe(HangXeDTO HangXe)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = HangXeDAO.XoaHangXeDAO(HangXe);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return blnKetQua;
        }
                
        public static bool CapNhatHangXe(HangXeDTO  aHangXe)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = DAO.HangXeDAO.CapNhatHangXe(aHangXe);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }

        public static List<HangXeDTO> DocDanhSachHangXe(String strTieuChiTimKiem)
        {
            List<DTO.HangXeDTO> lstHangXe = DAO.HangXeDAO.DocDanhSachHangXe(strTieuChiTimKiem);
            return lstHangXe;
        }       
    }
}
