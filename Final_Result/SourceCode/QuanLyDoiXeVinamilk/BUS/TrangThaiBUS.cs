using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;
using DAO;

namespace BUS
{
    public class TrangThaiBUS
    {
        public static List<TrangThaiDTO> DocDanhSachTrangThai(String strTieuChiTimKiem)
        {
            List<TrangThaiDTO> lstTrangThai = null;
            try
            {
                lstTrangThai = TrangThaiDAO.DocDanhSachTrangThai(strTieuChiTimKiem);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstTrangThai;
        }
    }
}
