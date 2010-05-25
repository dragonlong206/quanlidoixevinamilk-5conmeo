Imports System.Data.OleDb

Module LT_CongTy
    Private KetNoi As String = "Provider=Microsoft.Jet.OLEDB.4.0;"
    Private CSDL As String = "Data Source=..\\..\\..\\DuLieu\\CONG_TY.mdb"
    Private strKetNoi As String = KetNoi & CSDL

    Public Function Doc(ByVal strLenh As String) As DataTable
        Dim Bang As New DataTable
        Try
            Dim KetNoi As New OleDbConnection(strKetNoi)
            Dim BoThichUng As New OleDbDataAdapter(strLenh, KetNoi)
            BoThichUng.FillSchema(Bang, SchemaType.Source)
            BoThichUng.Fill(Bang)
        Catch ex As Exception
            MessageBox.Show("Loi at LT_CongTy/Doc: " & strLenh & ex.Message)
        End Try        
        Return Bang
    End Function
End Module
