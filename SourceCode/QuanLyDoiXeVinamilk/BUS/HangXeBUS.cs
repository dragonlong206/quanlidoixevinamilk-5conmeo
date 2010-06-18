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
        public static String GetTenHangXe(int nMaHangXe)
        {
            String strTieuChiTimKiem = " Where MaHang = " + nMaHangXe;
            List<DTO.HangXeDTO> lstHangXe = DocDanhSachHangXe(strTieuChiTimKiem);

            if (lstHangXe.Count > 0)
            {
                return lstHangXe[0].TenHang;
            }
            else
                return "Không có";            
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
