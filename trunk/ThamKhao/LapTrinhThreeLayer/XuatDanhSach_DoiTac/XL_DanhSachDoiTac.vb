Module XL_DanhSachDoiTac

    Public Structure DOI_TAC
        Dim MDT As Integer
        Dim Ten As String
        Dim DienThoai As String
        Dim DiaChi As String
    End Structure

    Public Function DocDanhSach() As ArrayList
        Dim DanhSach As New ArrayList
        Dim strLenh As String = "Select * From DOI_TAC"
        Dim Bang As DataTable = LT_DanhSachDoiTac.Doc(strLenh)
        For Each Dong As DataRow In Bang.Rows
            DanhSach.Add(KhoiTao(Dong))
        Next
        Return DanhSach
    End Function

    Public Function KhoiTao(ByVal Dong As DataRow) As DOI_TAC
        Dim DoiTac As New DOI_TAC
        DoiTac.MDT = Dong.Item("MDT")
        DoiTac.Ten = Dong.Item("Ten")
        DoiTac.DienThoai = Dong.Item("DienThoai")
        DoiTac.DiaChi = Dong.Item("DiaChi")
        Return DoiTac
    End Function

    Public Function Ghi(ByVal DoiTac As DOI_TAC) As Boolean
        Dim blnKetQua As Boolean = True
        Dim strLenh As String = "Select * From DOI_TAC "
        strLenh = strLenh & "Where MDT = " & DoiTac.MDT
        Dim Bang As DataTable = LT_DanhSachDoiTac.Doc(strLenh)
        Dim Dong As DataRow
        If Bang.Rows.Count = 1 Then
            Dong = Bang.Rows(0)
        Else
            Dong = Bang.NewRow()
            Bang.Rows.Add(Dong)
        End If
        Dong.Item("Ten") = DoiTac.Ten
        Dong.Item("DienThoai") = DoiTac.DienThoai
        Dong.Item("DiaChi") = DoiTac.DiaChi
        blnKetQua = LT_DanhSachDoiTac.Ghi(Bang, "DOI_TAC")
        Return blnKetQua
    End Function

    Public Function KiemTraXoa() As Boolean
        Dim blnKetQua As Boolean = True
        'Bo sung tai day.
        Return blnKetQua
    End Function

    Public Function Xoa(ByVal DoiTac As DOI_TAC) As Boolean
        Dim blnKetQua As Boolean = KiemTraXoa()
        If blnKetQua Then
            Dim strLenh As String = "Select * From DOI_TAC "
            strLenh = strLenh & "Where MDT = " & DoiTac.MDT
            Dim Bang As DataTable = LT_DanhSachDoiTac.Doc(strLenh)
            blnKetQua = False
            If Bang.Rows.Count > 0 Then
                Dim Dong As DataRow = Bang.Rows(0)
                Dong.Delete()
                blnKetQua = LT_DanhSachDoiTac.Ghi(Bang, "DOI_TAC")
            End If
        End If
        Return blnKetQua
    End Function

    'Xem them ve xu li chuoi.
    Public Function Chuoi(ByVal DoiTac As DOI_TAC) As String
        Dim strChuoi As String = ""
        strChuoi = strChuoi & DoiTac.Ten & vbTab
        strChuoi = strChuoi & DoiTac.DienThoai & vbTab
        strChuoi = strChuoi & DoiTac.DiaChi & vbCrLf
        Return strChuoi
    End Function

    Public Function ChuoiDanhSach(ByVal DanhSach As ArrayList) As String
        Dim strChuoiDanhSach As String = ""
        For i As Integer = 0 To DanhSach.Count - 1
            strChuoiDanhSach = strChuoiDanhSach & i & vbTab & Chuoi(DanhSach(i))
        Next
        Return strChuoiDanhSach
    End Function
End Module
