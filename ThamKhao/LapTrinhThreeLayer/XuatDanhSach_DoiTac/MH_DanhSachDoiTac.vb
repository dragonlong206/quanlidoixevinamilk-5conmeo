Public Class MH_DanhSachDoiTac

    Private Sub MH_DanhSachDoiTac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DanhSach As ArrayList = XL_DanhSachDoiTac.DocDanhSach()
        XuatDanhSach(DanhSach)
    End Sub

    Private Sub Xl_Them_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Xl_Them.Click
        Dim DoiTac As DOI_TAC = Nhap()
        Dim strThongBao As String = "Loi ghi!"
        If XL_DanhSachDoiTac.Ghi(DoiTac) Then
            strThongBao = "Da ghi!"
            Th_DanhSach.Items.Add(TheHien(DoiTac))
        End If
        MessageBox.Show(strThongBao)
    End Sub

    Private Sub Xl_Xoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Xl_Xoa.Click
        Dim strThongBao As String = "Chua chon doi tac!"
        If Th_DanhSach.SelectedItems.Count > 0 Then            
            Dim TheHien As ListViewItem = Th_DanhSach.SelectedItems(0)
            Dim DoiTac As DOI_TAC = TheHien.Tag
            strThongBao = "Khong xoa duoc!"
            If XL_DanhSachDoiTac.Xoa(DoiTac) Then
                strThongBao = "Da xoa!"
                Th_DanhSach.Items.Remove(TheHien)
            End If
        End If
        MessageBox.Show(strThongBao)
    End Sub

    Private Function Nhap() As DOI_TAC
        Dim DoiTac As New DOI_TAC
        DoiTac.Ten = Th_Ten.Text
        DoiTac.DienThoai = Th_DienThoai.Text
        DoiTac.DiaChi = Th_DiaChi.Text
        Return DoiTac
    End Function

    Private Sub XuatDanhSach(ByVal DanhSach As ArrayList)
        Th_DanhSach.Items.Clear()
        For Each DoiTac As DOI_TAC In DanhSach
            Th_DanhSach.Items.Add(TheHien(DoiTac))
        Next
    End Sub

    Private Function TheHien(ByVal DoiTac As DOI_TAC) As ListViewItem
        Dim itemKetQua As New ListViewItem
        itemKetQua.Text = DoiTac.Ten
        itemKetQua.SubItems.Add(DoiTac.DienThoai)
        itemKetQua.SubItems.Add(DoiTac.DiaChi)
        itemKetQua.Tag = DoiTac
        Return itemKetQua
    End Function
End Class
