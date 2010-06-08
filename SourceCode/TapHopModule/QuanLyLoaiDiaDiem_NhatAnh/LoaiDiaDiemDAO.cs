using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class LoaiDiaDiemDAO
    {
        #region Select
        public static List<LoaiDiaDiemDTO> DocDanhSachLoaiDD()
        {
            List<LoaiDiaDiemDTO> dsLoaiDD = new List<LoaiDiaDiemDTO>();

            String strCommand = "Select * from LOAI_DIA_DIEM Order by MaLoai";
            DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);

            foreach (DataRow aDong in table.Rows)
            {
                dsLoaiDD.Add(KhoiTao(aDong));
            }

            return dsLoaiDD;
        }
        public static DTO.LoaiDiaDiemDTO KhoiTao(DataRow aDong)
        {
            DTO.LoaiDiaDiemDTO aLoaiDD = new DTO.LoaiDiaDiemDTO();
            aLoaiDD.MaLoai = int.Parse(aDong["MaLoai"].ToString());
            aLoaiDD.TenLoai = aDong["TenLoai"].ToString();
            return aLoaiDD;
        }

        public static LoaiDiaDiemDTO LayLoaiDDTheoMaLoai(int nMaLoai)
        {
            LoaiDiaDiemDTO loaiDD = null;

            String strCommand = "Select * from LOAI_DIA_DIEM where MaLoai = ?";
            OleDbParameter param = new OleDbParameter("@MaLoai", nMaLoai);
            List<OleDbParameter> arrParams = new List<OleDbParameter>();
            arrParams.Add(param);

            DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, arrParams);

            if (table.Rows.Count > 0)
            {
                loaiDD = new LoaiDiaDiemDTO();
                loaiDD.MaLoai = int.Parse(table.Rows[0]["MaLoai"].ToString());
                loaiDD.TenLoai = table.Rows[0]["TenLoai"].ToString();
            }

            return loaiDD;
        }

        #endregion

        #region Delete
        public static Boolean XoaLoaiDD(DTO.LoaiDiaDiemDTO aLoaiDD)
        {
            Boolean blnKetQua = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@MaLoai", aLoaiDD.MaLoai));
                String strCommand = @"Delete from LOAI_DIA_DIEM
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

        #region Insert
        public static Boolean ThemLoaiDD(LoaiDiaDiemDTO loaiDD)
        {
            Boolean blnDaThemDuoc = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@MaLoai", loaiDD.MaLoai));
                arrParams.Add(new OleDbParameter("@TenLoai", loaiDD.TenLoai));
         
                String strCommand = @"Insert into LOAI_DIA_DIEM(MaLoai, TenLoai)
                                    values (?, ?)";
   
                int nRecord = SqlDataAccessHelper.ExcuteNonQuery(strCommand, arrParams);
                if (nRecord == 1) // Số dòng insert được
                {
                    blnDaThemDuoc = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnDaThemDuoc;
        }
        #endregion

        #region Update
        public static bool CapNhatLoaiDD(LoaiDiaDiemDTO loaiDD)
        {
            bool blnDaCapNhat = false;
            try
            {
                // Create List Sql Parameter
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@MaLoai", loaiDD.MaLoai));
                arrParams.Add(new OleDbParameter("@TenLoai", loaiDD.TenLoai));

                //chi cap nhat lai ten loai
                String strCommand = @"Update LOAI_DIA_DIEM set TenLoai = ? where MaLoai = ?";
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

        public static bool KiemTraMaLoaiDD(int nMaLoai)
        {
            try
            {
                LoaiDiaDiemDTO loaiDD = DAO.LoaiDiaDiemDAO.LayLoaiDDTheoMaLoai(nMaLoai);

                if (loaiDD != null)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return false;
        }
        #endregion
    }
}
