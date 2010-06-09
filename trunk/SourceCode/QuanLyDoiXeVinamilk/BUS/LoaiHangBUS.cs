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
                case "Hàng Thường":
                    return 1;
                case "Hàng Nóng":
                    return 2;
                case "Hàng Lạnh":
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
                    return "Hàng Thường";
                case 2:
                    return "Hàng Nóng";
                case 3:
                    return "Hàng Lạnh";
                default:
                    return "Error!";
            }
        }        

        public static Boolean ThemLoaihang(DTO.LoaiHangDTO LoaiHang)
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

        public static bool CapNhatLoaiHang(DTO.LoaiHangDTO aLoaiHang)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = DAO.LoaiHangDAO.CapNhatLoaiHang(aLoaiHang);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }

        public static List<LoaiHangDTO> DocDanhSachLoaiHang(String strTieuChiTimKiem)
        {
            List<LoaiHangDTO> lstLoaiHang = LoaiHangDAO.DocDanhSachLoaiHang(strTieuChiTimKiem);
            return lstLoaiHang;
        }
    }   
}
