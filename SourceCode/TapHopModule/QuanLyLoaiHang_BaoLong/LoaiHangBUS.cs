using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DAO;
using DTO;

namespace BUS
{
    public class LoaiHangBUS
    {        
        public static int GetMaLoaiHang(String strLoaiHang)
        {
            //Tam thoi dung ham nay: chinh sua truy xuat CSDL sau.
            switch(strLoaiHang)
            {
                case "hàng thường":
                    return 1;
                case "hàng nóng":
                    return 2;
                case "hàng lạnh":
                    return 3;
                default:
                    return -1;
            }
        }

        public static String GetTenLoaiHang(int nMaLoaiHang)
        {
            //Tam thoi dung ham nay: chinh sua truy xuat CSDL sau.
            switch(nMaLoaiHang)
            {
                case 1:
                    return "hàng thường";
                case 2:
                    return "hàng nóng";
                case 3:
                    return "hàng lạnh";
                default:
                    return "erorr!";
            }
        }

        public static Boolean ThemLoaihang(LoaiHangDTO LoaiHang)
        {
            Boolean blnDaThemDuoc = false;
            try
            {
                blnDaThemDuoc = LoaiHangDAO.ThemLoaiHang(LoaiHang);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return blnDaThemDuoc;
        }

        public static Boolean XoaLoaiHang(LoaiHangDTO LoaiHang)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = LoaiHangDAO.XoaLoaiHang(LoaiHang);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return blnKetQua;
        }

        public static List<LoaiHangDTO> DocDanhSachLoaiHang()
        {
            List<LoaiHangDTO> dsLoaiHang = LoaiHangDAO.LayDanhSachLoaiHang();
            return dsLoaiHang;
        }
    }   
}
