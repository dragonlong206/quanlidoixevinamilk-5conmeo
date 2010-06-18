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
        public static String GetTenLoaiHang(int nMaLoaiHang)
        {
            String strTieuChiTimKiem = " Where MaLoai = " + nMaLoaiHang;
            List<DTO.LoaiHangDTO> lstLoaiHang = DocDanhSachLoaiHang(strTieuChiTimKiem);

            if (lstLoaiHang.Count > 0)
            {
                return lstLoaiHang[0].TenLoaiHang;
            }
            else
                return "Không có"; 
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
