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
        #region Insert
        public static Boolean ThemLoaiDiaDiem(LoaiDiaDiemDTO LoaiDiaDiem)
        {
            Boolean blnKetQua = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();                
                arrParams.Add(new OleDbParameter("@TenLoai", LoaiDiaDiem.TenLoai));

                String strCommand = @"Insert into LOAI_DIA_DIEM(TenLoai)
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
        public static Boolean XoaLoaiDiaDiem(DTO.LoaiDiaDiemDTO aLoaiDiaDiem)
        {
            Boolean blnKetQua = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@MaLoai", aLoaiDiaDiem.MaLoai));
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

        #region Update
        public static bool CapNhatLoaiDiaDiem(LoaiDiaDiemDTO LoaiDiaDiem)
        {
            bool blnDaCapNhat = false;

            try
            {                
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@TenLoai", LoaiDiaDiem.TenLoai));
                arrParams.Add(new OleDbParameter("@MaLoai", LoaiDiaDiem.MaLoai));                
                String strCommand = @"Update LOAI_DIA_DIEM 
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
        public static List<LoaiDiaDiemDTO> DocDanhSachLoaiDiaDiem(String strTieuChiTimKiem)
        {
            List<LoaiDiaDiemDTO> lstLoaiDiaDiem = new List<LoaiDiaDiemDTO>();

            String strCommand = "Select * from LOAI_DIA_DIEM " + strTieuChiTimKiem;
            DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);

            foreach (DataRow aDong in table.Rows)
            {
                lstLoaiDiaDiem.Add(KhoiTao(aDong));
            }

            return lstLoaiDiaDiem;
        }
        public static DTO.LoaiDiaDiemDTO KhoiTao(DataRow aDong)
        {
            DTO.LoaiDiaDiemDTO aLoaiDiaDiem = new DTO.LoaiDiaDiemDTO();
            aLoaiDiaDiem.MaLoai = int.Parse(aDong["MaLoai"].ToString());
            aLoaiDiaDiem.TenLoai = aDong["TenLoai"].ToString();
            return aLoaiDiaDiem;
        }

        public static List<LoaiDiaDiemDTO> LayDanhSachTatCaDiaDiem()
        {
            List<LoaiDiaDiemDTO> DanhSachLoaiDiaDiem = null;

            try
            {
                string strCommand = "Select * from Loai_Dia_Diem";

                DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);
                if (table.Rows.Count > 0)
                {
                    DanhSachLoaiDiaDiem = new List<LoaiDiaDiemDTO>();
                    foreach (DataRow aRow in table.Rows)
                    {
                        DanhSachLoaiDiaDiem.Add(KhoiTao(aRow));
                    }                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return DanhSachLoaiDiaDiem;
        }
        #endregion
    }
}
