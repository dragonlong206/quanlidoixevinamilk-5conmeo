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
    public class MatHangBUS
    {
        public static Boolean ThemMatHang(MatHangDTO MatHang)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = MatHangDAO.ThemMatHang(MatHang);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return blnKetQua;

        }
        public static List<MatHangDTO> DocDanhSachMatHang(String strTieuChiTimKiem)
        {
            List<MatHangDTO> lstMH = MatHangDAO.DocDanhSachMatHang(strTieuChiTimKiem);            
            return lstMH;
        }
        public static Boolean XoaMatHang(MatHangDTO aMH)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = MatHangDAO.XoaMatHang(aMH);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return blnKetQua;
        }
    }
}
