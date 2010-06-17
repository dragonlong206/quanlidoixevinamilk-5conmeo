using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.OleDb;
using System.Data;

namespace DAO
{
    public class NhanVienDAO
    {
        #region 1.Insert
        public static Boolean ThemNhanVien(NhanVienDTO NhanVien)
        {
            Boolean blnKetQua = false;
            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@TenNhanVien",NhanVien.TenNhanVien));
                arrParams.Add(new OleDbParameter("@SoDienThoai", NhanVien.SoDienThoai));
                String strCommand = @"Insert into Nhan_Vien (TenNhanVien,SoDienThoai)
                                   Values(?,?)";

                int nRecord = SqlDataAccessHelper.ExcuteNonQuery(strCommand, arrParams);
                if (nRecord == 1)
                {
                    blnKetQua = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return blnKetQua;
        }
        #endregion
        #region 2.Delete
        public static Boolean XoaNhanVien(NhanVienDTO aNV)
        {
            Boolean blnKetQua = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@MaNhanVien",aNV.MaNhanVien));
                String strCommand = @"Delete from Nhan_Vien 
                                      Where MaNhanVien = ?";

                int nRecord = SqlDataAccessHelper.ExcuteNonQuery(strCommand, arrParams);
                if (nRecord == 1)
                {
                    blnKetQua = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }
        #endregion
         #region 4.Select 

        public static List<NhanVienDTO> DocDanhSachNV(String strTieuChiTimKiem)
        {
           List<NhanVienDTO> lstNV = new List<NhanVienDTO>();

           String strCommand = "Select * from Nhan_vien" + strTieuChiTimKiem;
           DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);

           foreach (DataRow aDong in table.Rows)
           {
               lstNV.Add(KhoiTao(aDong));
            
           }

           return lstNV;                    
        }      
 
        public static NhanVienDTO KhoiTao(DataRow aDong)
        {
            NhanVienDTO aNV = new NhanVienDTO();
            aNV.MaNhanVien = int.Parse(aDong["MaNhanVien"].ToString());
            aNV.TenNhanVien = aDong["TenNhanVien"].ToString();
            aNV.SoDienThoai = int.Parse(aDong["SoDienThoai"].ToString());
         

            return aNV;
        }

       #endregion
    }
    }

