using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class TrongTaiDAO
    {        
        #region Thêm TrongTai
        public static Boolean ThemTrongTai(TrongTaiDTO aTrongTai)
        {
            Boolean blnKetQua = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();                
                arrParams.Add(new OleDbParameter("@GiaTri", aTrongTai.GiaTri));
                arrParams.Add(new OleDbParameter("@DonVi", aTrongTai.DonVi));
                String strCommand = @"Insert into TRONG_TAI(GiaTri, DonVi)
                                      Values (?, ?)";

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

        #region Xoa TrongTai
        public static Boolean XoaTrongTai(DTO.TrongTaiDTO aTrongTai)
        {
            Boolean blnKetQua = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@MaTrongTai", aTrongTai.MaTrongTai));
                String strCommand = @"Delete from TRONG_TAI
                                      Where MaTrongTai = ?";

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

        #region Cap nhat TrongTai

        public static bool CapNhatTrongTai(TrongTaiDTO aTrongTai)
        {
            Boolean blnKetQua = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@GiaTri", aTrongTai.GiaTri));
                arrParams.Add(new OleDbParameter("@DonVi", aTrongTai.DonVi));
                arrParams.Add(new OleDbParameter("@MaTrongTai", aTrongTai.MaTrongTai));
                String strCommand = @"Update TRONG_TAI
                                     Set GiaTri = ?, DonVi = ? 
                                     Where MaTrongTai = ?";

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

        #region Đọc danh sách TrongTai
        public static List<TrongTaiDTO> DocDanhSachTrongTai(String strTieuChiTimKiem)
        {
            List<TrongTaiDTO> lstTrongTai = new List<TrongTaiDTO>();

            String strCommand = "Select * from TRONG_TAI" + strTieuChiTimKiem;
            DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);

            foreach (DataRow aDong in table.Rows)
            {
                lstTrongTai.Add(KhoiTao(aDong));
            }

            return lstTrongTai;
        }
        public static DTO.TrongTaiDTO KhoiTao(DataRow aDong)
        {
            DTO.TrongTaiDTO aTrongTai = new DTO.TrongTaiDTO();

            aTrongTai.MaTrongTai = int.Parse(aDong["MaTrongTai"].ToString());
            aTrongTai.GiaTri = int.Parse(aDong["GiaTri"].ToString());
            aTrongTai.DonVi = aDong["DonVi"].ToString();

            return aTrongTai;
        }
        
        #endregion
    }
}
