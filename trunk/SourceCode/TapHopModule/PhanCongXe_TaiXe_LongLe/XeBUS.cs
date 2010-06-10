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
    public class XeBUS
    {
        public static Boolean ThemXe(XeDTO xe)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = XeDAO.ThemXe(xe);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }

        public static Boolean CapNhatXe(DTO.XeDTO aXe)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = XeDAO.CapNhatXe(aXe);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }

        public static Boolean XoaXe(DTO.XeDTO aXe)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = DAO.XeDAO.XoaXe(aXe);
            }
            catch (System.Exception ex)
            {
            	throw ex;
            }            
            return blnKetQua;
        }

        public static List<DTO.XeDTO> DocDanhSachXe(String strTieuChiTimKiem)
        {
            List<DTO.XeDTO> lstXe = DAO.XeDAO.DocDanhSachXe(strTieuChiTimKiem);
            return lstXe;
        }

        public static DataTable LayDanhSachXeLinhHoat(String strCommand, List<OleDbParameter> lstParams)
        {
            DataTable table = null;
            try
            {
                table = DAO.XeDAO.LayDanhSachXeLinhHoat(strCommand, lstParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return table;
        }

        public static DataTable LayDanhSachXeCoThePhanCong()
        {
            String strCommand = @"Select BienSo
                                  From Xe, Trong_Tai
                                  Where Xe.MaTrongTai = Trong_Tai.MaTrongTai
                                  And Trong_Tai.GiaTri >= @TrongTaiNhoNhatDuocPhanCong";
// Chỗ này phải đọc từ CSDL
            int iTrongTaiNhoNhatDuocPhanCong = 5;
            List<OleDbParameter> lstParams = new List<OleDbParameter>();
            lstParams.Add(new OleDbParameter("@TrongTaiNhoNhatDuocPhanCong", iTrongTaiNhoNhatDuocPhanCong));

            DataTable tblKetQua = null;
            try
            {
                tblKetQua = XeDAO.LayDanhSachXeLinhHoat(strCommand, lstParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return tblKetQua;
        }
    }
}
