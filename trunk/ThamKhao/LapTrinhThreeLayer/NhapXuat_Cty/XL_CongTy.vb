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

    Public Function Ghi(ByVal CongTy As CONG_TY) As Boolean
        Dim blnKetQua As Boolean = False
        Dim strLenh = "Select * From CONG_TY"
        Dim Bang As DataTable = LT_CongTy.Doc(strLenh)
        Dim Dong As DataRow = Bang.Rows(0)
        Dong.Item("Ten") = CongTy.Ten
        Dong.Item("DienThoai") = CongTy.DienThoai
        Dong.Item("DiaChi") = CongTy.DiaChi
        blnKetQua = LT_CongTy.Ghi(Bang, "CONG_TY")
        Return blnKetQua
    End Function

    'Vi du ve xu li chuoi
    Public Function Chuoi(ByVal CongTy As CONG_TY) As String
        Dim strChuoi As String = ""
        strChuoi = strChuoi & "Ten cong ty: " & CongTy.Ten & vbCrLf
        strChuoi = strChuoi & "Dien thoai: " & CongTy.DienThoai & vbCrLf
        strChuoi = strChuoi & "Dia chi: " & CongTy.DiaChi & vbCrLf
        Return strChuoi
    End Function
End Module
