using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class DiaDiemDAO
    {
        #region 1.Insert
        public static Boolean ThemDiaDiem(DiaDiemDTO aDiaDiem)
        {
            Boolean blnDaThemDuoc = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@TenDiaDiem", aDiaDiem.TenDiaDiem));
                arrParams.Add(new OleDbParameter("@MaLoai", aDiaDiem.MaLoaiDiaDiem));
                arrParams.Add(new OleDbParameter("@NguoiLienHe", aDiaDiem.NguoiLienHe));
                arrParams.Add(new OleDbParameter("@DiaChi", aDiaDiem.DiaChi));
                arrParams.Add(new OleDbParameter("@Email", aDiaDiem.Email));
                arrParams.Add(new OleDbParameter("@SoDienThoai", aDiaDiem.DienThoai));
                arrParams.Add(new OleDbParameter("@ToaDo", aDiaDiem.ToaDo));

                String strCommand = @"Insert Into DIA_DIEM(TenDiaDiem, MaLoai, NguoiLienHe, DiaChi,
                                                           Email, SoDienThoai, ToaDo)
                                      Values(?,?,?,?,?,?,?)";

                int nRecord = SqlDataAccessHelper.ExcuteNonQuery(strCommand, arrParams);
                if (nRecord == 1)
                {
                    return blnDaThemDuoc = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnDaThemDuoc;
        }
        #endregion

        #region 2.Delete
        public static Boolean XoaDiaDiem(DiaDiemDTO aDiaDiem)
        {
            Boolean blnKetQua = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@MaDiaDiem", aDiaDiem.MaDiaDiem));
                String strCommand = @"Delete from DIA_DIEM
                                      Where MaDiaDiem = ?";

                int nRecord = SqlDataAccessHelper.ExcuteNonQuery(strCommand, arrParams);
                if (nRecord == 1)
                {
                    blnKetQua = true;
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }
        #endregion

        #region 3.Update
        public static Boolean CapNhatDiaDiem(DiaDiemDTO aDiaDiem)
        {
            Boolean blnDaUpdate = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@TenDiaDiem", aDiaDiem.TenDiaDiem));
                arrParams.Add(new OleDbParameter("@MaLoai", aDiaDiem.MaLoaiDiaDiem));
                arrParams.Add(new OleDbParameter("@NguoiLienHe", aDiaDiem.NguoiLienHe));
                arrParams.Add(new OleDbParameter("@DiaChi", aDiaDiem.DiaChi));
                arrParams.Add(new OleDbParameter("@Email", aDiaDiem.Email));
                arrParams.Add(new OleDbParameter("@SoDienThoai", aDiaDiem.DienThoai));
                arrParams.Add(new OleDbParameter("@ToaDo", aDiaDiem.ToaDo));
                arrParams.Add(new OleDbParameter("@MaDiaDiem", aDiaDiem.MaDiaDiem));

                String strCommand = @"Update DIA_DIEM
                                     Set TenDiaDiem = ?, MaLoai = ?, NguoiLienHe = ?, DiaChi = ?,
                                         Email = ?, SoDienThoai = ?, ToaDo = ?
                                     Where MaDiaDiem = ?";

                int nRecord = SqlDataAccessHelper.ExcuteNonQuery(strCommand, arrParams);
                if (nRecord == 1)
                {
                    return blnDaUpdate = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnDaUpdate;
        }
        #endregion

        #region 4.Select
        public static List<DiaDiemDTO> DocDanhSachDiaDiem(String strTieuChiTimKiem)
        {
            List<DiaDiemDTO> lstDiaDiem = new List<DiaDiemDTO>();

            String strCommand = "Select * from DIA_DIEM" + strTieuChiTimKiem;
            DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);

            foreach (DataRow aDong in table.Rows)
            {
                lstDiaDiem.Add(KhoiTao(aDong));
            }

            return lstDiaDiem;
        }

        public static DTO.DiaDiemDTO KhoiTao(DataRow aDong)
        {
            DTO.DiaDiemDTO aDiaDiem = new DTO.DiaDiemDTO();

            aDiaDiem.MaDiaDiem = int.Parse(aDong["MaDiaDiem"].ToString());
            aDiaDiem.TenDiaDiem = aDong["TenDiaDiem"].ToString();
            aDiaDiem.MaLoaiDiaDiem = int.Parse(aDong["MaLoai"].ToString());
            aDiaDiem.NguoiLienHe = aDong["NguoiLienHe"].ToString();
            aDiaDiem.DiaChi = aDong["DiaChi"].ToString();
            aDiaDiem.Email = aDong["Email"].ToString();
            aDiaDiem.DienThoai = aDong["SoDienThoai"].ToString();
            aDiaDiem.ToaDo = aDong["ToaDo"].ToString();

            return aDiaDiem;
        }

        #endregion
    }
}
