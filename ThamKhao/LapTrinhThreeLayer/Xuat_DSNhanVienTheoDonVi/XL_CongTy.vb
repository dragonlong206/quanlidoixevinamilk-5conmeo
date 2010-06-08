Module XL_CongTy
    Public Structure CONG_TY
        Dim MCT As Integer
        Dim Ten As String
        Dim DienThoai As String
        Dim DiaChi As String
    End Structure

    Public Function Doc() As CONG_TY
        Dim CongTy As New CONG_TY
        Dim strLenh = "Select * From CONG_TY"
        Dim Bang As DataTable = LT_CongTy.Doc(strLenh)
        Dim Dong As DataRow = Bang.Rows(0)
        CongTy.MCT = Dong.Item("MCT")
        CongTy.Ten = Dong.Item("Ten")
        CongTy.DienThoai = Dong.Item("DienThoai")
        CongTy.DiaChi = Dong.Item("DiaChi")
        Return CongTy
    End Function
End Module
