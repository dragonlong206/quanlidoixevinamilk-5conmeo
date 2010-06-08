Imports System.Data.OleDb

Module LT_DanhSachDoiTac
    Private LoaiKetNoi As String = "Provider=Microsoft.Jet.OLEDB.4.0;"
    Private CSDL As String = "Data Source=..\\..\\..\\DuLieu\\CONG_TY.mdb"
    Private strKetNoi As String = LoaiKetNoi & CSDL

    Public Function Doc(ByVal strLenh As String) As DataTable
        Dim Bang As New DataTable
        Try
            Dim KetNoi As New OleDbConnection(strKetNoi)
            Dim BoThichUng As New OleDbDataAdapter(strLenh, KetNoi)
            BoThichUng.FillSchema(Bang, SchemaType.Source)
            BoThichUng.Fill(Bang)
        Catch Loi As Exception
            MessageBox.Show("Loi at LT_DanhSachDoiTac.vb/Ghi: " & strLenh & Loi.Message)
        End Try
        Return Bang
    End Function

    Public Function Ghi(ByVal Bang As DataTable, ByVal strLenh As String) As Boolean
        Dim blnKetQua As Boolean = True
        strLenh = "Select * From " & strLenh
        Try
            Dim KetNoi As New OleDbConnection(strKetNoi)
            Dim BoThichUng As New OleDbDataAdapter(strLenh, KetNoi)
            Dim BoPhaiSinh As New OleDbCommandBuilder(BoThichUng)
            BoThichUng.Update(Bang)
        Catch Loi As Exception
            blnKetQua = False
            MessageBox.Show("Loi at LT_DanhSachDoiTac.vb/Ghi: " & strLenh & Loi.Message)
        End Try        
        Return blnKetQua
    End Function
End Module
