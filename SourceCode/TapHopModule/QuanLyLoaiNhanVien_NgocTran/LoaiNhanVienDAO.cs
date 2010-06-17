using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class LoaiNhanVienDAO
    {
        #region Insert
        public static Boolean ThemLoaiNhanVien(LoaiNhanVienDTO LoaiNhanVien)
        {
            Boolean blnKetQua = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@TenLoai", LoaiNhanVien.TenLoai));

                String strCommand = @"Insert into LOAI_NHAN_VIEN(TenLoai)
                                    values (?)";

                int nRecord = SqlDataAccessHelper.ExcuteNonQuery(strCommand, arrParams);
                if (nRecord == 1) // Số dòng insert được
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

        #region Delete
        public static Boolean XoaLoaiNhanVien(DTO.LoaiNhanVienDTO aLoaiNhanVien)
        {
            Boolean blnKetQua = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@MaLoai", aLoaiNhanVien.MaLoai));
                String strCommand = @"Delete from LOAI_NHAN_VIEN
                                      Where MaLoai = ?";

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

        #region Update
        public static bool CapNhatLoaiNhanVien(LoaiNhanVienDTO LoaiNhanVien)
        {
            bool blnDaCapNhat = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@TenLoai", LoaiNhanVien.TenLoai));
                arrParams.Add(new OleDbParameter("@MaLoai", LoaiNhanVien.MaLoai));
                String strCommand = @"Update LOAI_NHAN_VIEN 
                                      Set TenLoai = ? 
                                      Where MaLoai = ?";
                int nRecord = SqlDataAccessHelper.ExcuteNonQuery(strCommand, arrParams);
                if (nRecord == 1)
                {
                    blnDaCapNhat = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return blnDaCapNhat;
        }
        #endregion

        #region Select
        public static List<LoaiNhanVienDTO> DocDanhSachLoaiNhanVien(String strTieuChiTimKiem)
        {
            List<LoaiNhanVienDTO> lstLoaiNhanVien = new List<LoaiNhanVienDTO>();

            String strCommand = "Select * from LOAI_NHAN_VIEN " + strTieuChiTimKiem;
            DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);

            foreach (DataRow aDong in table.Rows)
            {
                lstLoaiNhanVien.Add(KhoiTao(aDong));
            }

            return lstLoaiNhanVien;
        }
        public static DTO.LoaiNhanVienDTO KhoiTao(DataRow aDong)
        {
            DTO.LoaiNhanVienDTO aLoaiNhanVien = new DTO.LoaiNhanVienDTO();
            aLoaiNhanVien.MaLoai = int.Parse(aDong["MaLoai"].ToString());
            aLoaiNhanVien.TenLoai = aDong["TenLoai"].ToString();
            return aLoaiNhanVien;
        }
        #endregion
    }
}
