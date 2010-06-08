Module XL_DonVi

    Public Structure DON_VI
        Dim MDV As Integer
        Dim Ten As String
    End Structure

    Public Function DocDanhSach() As ArrayList
        Dim DanhSach As New ArrayList
        Dim strLenh As String = "Select * From DON_VI"
        Dim Bang As DataTable = LT_CongTy.Doc(strLenh)
        For Each Dong As DataRow In Bang.Rows
            DanhSach.Add(KhoiTao(Dong))
        Next        
        Return DanhSach
    End Function

    Public Function KhoiTao(ByVal Dong As DataRow) As DON_VI
        Dim DonVi As New DON_VI
        DonVi.MDV = Dong.Item("MDV")
        DonVi.Ten = Dong.Item("Ten")        
        Return DonVi
    End Function
End Module
