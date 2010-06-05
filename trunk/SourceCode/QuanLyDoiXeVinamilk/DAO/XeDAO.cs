using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;


namespace DAO
{
    public class XeDAO
    {
        private static string strLoaiKetNoi = "Provider=Microsoft.Jet.OLEDB.4.0;";
        private static string strCSDL = "Data Source = ..\\..\\..\\DataBase\\Db_QuanLyDoiXeVinamilk.mdb";
        private static string strChuoiKetNoi = strLoaiKetNoi + strCSDL;

        public static OleDbConnection MoKetNoi()
        {
            OleDbConnection contKetNoi;

            try
            {
                contKetNoi = new OleDbConnection(strChuoiKetNoi);                
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

            return contKetNoi;
        }

        public static DataTable Doc(String strChuoiLoc)
        {
            DataTable tblBang = new DataTable();
            
            try
            {
                OleDbConnection contKetNoi = MoKetNoi();                
                OleDbDataAdapter adaptBoThichUng = new OleDbDataAdapter(strChuoiLoc, contKetNoi);
                adaptBoThichUng.FillSchema(tblBang, SchemaType.Source);
                adaptBoThichUng.Fill(tblBang);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }            

            return tblBang;
        }

        public static bool Ghi(DataTable tblBang, String strTenBang)
        {
            bool blnKetQua = true;
            String strChuoiLoc = "Select * From " + strTenBang;

            try
            {
                OleDbConnection contKetNoi = MoKetNoi();
                OleDbDataAdapter adaptBoThichUng = new OleDbDataAdapter(strChuoiLoc, contKetNoi);
                OleDbCommandBuilder comBoPhatSinh = new OleDbCommandBuilder(adaptBoThichUng);
                adaptBoThichUng.Update(tblBang);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return blnKetQua;
        }
    }
}
