Module XL_NhanVien

    Public Structure NHAN_VIEN
        Dim MNV As Integer
        Dim Ten As String
        Dim GioiTinh As Boolean
        Dim NgaySinh As Date
        Dim DiaChi As String
        Dim DonVi As DON_VI
    End Structure

    Public Function DocDanhSach(ByVal DonVi As DON_VI) As ArrayList
        Dim DanhSach As New ArrayList
        Dim strLenh As String = "Select * From NHAN_VIEN "
        strLenh = strLenh & "Where MDV = " & DonVi.MDV
        Dim Bang As DataTable = LT_CongTy.Doc(strLenh)
        For Each Dong As DataRow In Bang.Rows
            Dim NhanVien As NHAN_VIEN = KhoiTao(Dong)
            NhanVien.DonVi = DonVi
            DanhSach.Add(NhanVien)
        Next
        Return DanhSach
    End Function

    Public Function KhoiTao(ByVal Dong As DataRow) As NHAN_VIEN
        Dim NhanVien As New NHAN_VIEN
        NhanVien.MNV = Dong.Item("MNV")
        NhanVien.Ten = Dong.Item("Ten")
        NhanVien.GioiTinh = Dong.Item("GioiTinh")
        NhanVien.NgaySinh = Dong.Item("NgaySinh")
        NhanVien.DiaChi = Dong.Item("DiaChi")
        Return NhanVien
    End Function

    Public Function ChuoiGioiTinh(ByVal NhanVien As NHAN_VIEN) As String
        Dim strGioiTinh As String = "Nu"
        If NhanVien.GioiTinh Then
            strGioiTinh = "Nam"
        End If
        Return strGioiTinh
    End Function

    Public Function Tuoi(ByVal NhanVien As NHAN_VIEN) As String
        Dim strTuoi As String = ""
        strTuoi = strTuoi & (Year(Today) - Year(NhanVien.NgaySinh))
        Return strTuoi
    End Function
End Module
