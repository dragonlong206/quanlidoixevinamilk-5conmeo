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
            Boolean blnDaThemDuoc = false;
            try
            {
                blnDaThemDuoc = XeDAO.ThemXe(xe);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnDaThemDuoc;
        }

        public static Boolean CapNhatXe(DTO.XeDTO aXe)
        {
            Boolean blnDaThemDuoc = false;
            try
            {
                blnDaThemDuoc = XeDAO.CapNhatXe(aXe);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnDaThemDuoc;
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

        public static List<DTO.XeDTO> DocDanhSachXe()
        {
            List<DTO.XeDTO> lstXe = DAO.XeDAO.DocDanhSachXe();
            return lstXe;
        }
    }
}
