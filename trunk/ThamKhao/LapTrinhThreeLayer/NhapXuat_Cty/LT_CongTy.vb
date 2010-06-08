Imports System.Data.OleDb

Module LT_CongTy
    Private KetNoi As String = "Provider=Microsoft.Jet.OLEDB.4.0;"
    Private CSDL As String = "Data Source=..\\..\\..\\DuLieu\\CONG_TY.mdb"
    Private ChuoiKetNoi As String = KetNoi & CSDL

    Public Function Doc(ByVal strLenh As String) As DataTable
        Dim tblKetQua As New DataTable        
        Dim KetNoi As New OleDbConnection(ChuoiKetNoi)
        Dim BoThichUng As New OleDbDataAdapter(strLenh, KetNoi)
        BoThichUng.FillSchema(tblKetQua, SchemaType.Source)
        BoThichUng.Fill(tblKetQua)
        Return tblKetQua
    End Function

    Public Function Ghi(ByVal Bang As DataTable, ByVal ChuoiLenh As String) As Boolean
        Dim blnKetQua As Boolean = True
        Dim strLenh As String = "Select * From CONG_TY"
        Dim KetNoi As New OleDbConnection(ChuoiKetNoi)
        Dim BoThichUng As New OleDbDataAdapter(strLenh, ChuoiKetNoi)
        Dim BoPhaiSinh As New OleDbCommandBuilder(BoThichUng)
        BoThichUng.Update(Bang)
        Return blnKetQua
    End Function
End Module