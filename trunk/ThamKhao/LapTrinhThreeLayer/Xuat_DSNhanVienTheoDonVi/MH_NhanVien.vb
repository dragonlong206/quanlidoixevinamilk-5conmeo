Public Class MH_NhanVien

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim CongTy As CONG_TY = XL_CongTy.Doc()
        Dim dsDonVi As ArrayList = XL_DonVi.DocDanhSach()
        XuatCay(CongTy, dsDonVi)
        Th_Cay.ExpandAll()
    End Sub

    Private Sub Th_Cay_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles Th_Cay.AfterSelect
        Dim nodDuocChon As TreeNode = Th_Cay.SelectedNode
        If Not nodDuocChon Is Nothing AndAlso nodDuocChon.Tag.GetType Is GetType(DON_VI) Then
            Dim dsNhanVien As ArrayList = XL_NhanVien.DocDanhSach(nodDuocChon.Tag)
            XuatDanhSach(dsNhanVien)
        End If
    End Sub

    Private Sub XuatCay(ByVal CongTy As CONG_TY, ByVal dsDonVi As ArrayList)
        Dim nodCongTy As TreeNode = TheHien(CongTy)
        Th_Cay.Nodes.Add(nodCongTy)
        For Each DonVi As DON_VI In dsDonVi
            nodCongTy.Nodes.Add(TheHien(DonVi))
        Next
    End Sub

    Private Sub XuatDanhSach(ByVal DanhSach As ArrayList)
        Th_DanhSach.Items.Clear()
        For Each NhanVien As NHAN_VIEN In DanhSach
            Th_DanhSach.Items.Add(TheHien(NhanVien))
        Next
        Th_DanhSach.View = View.Details
    End Sub

    Private Function TheHien(ByVal CongTy As CONG_TY) As TreeNode
        Dim nodCongTy As New TreeNode
        nodCongTy.Text = CongTy.Ten
        nodCongTy.Tag = CongTy
        Return nodCongTy
    End Function

    Private Function TheHien(ByVal DonVi As DON_VI) As TreeNode
        Dim nodDonVi As New TreeNode
        nodDonVi.Text = DonVi.Ten
        nodDonVi.Tag = DonVi
        Return nodDonVi
    End Function

    Private Function TheHien(ByVal NhanVien As NHAN_VIEN) As ListViewItem
        Dim itemNhanVien As New ListViewItem
        itemNhanVien.Text = NhanVien.Ten
        itemNhanVien.SubItems.Add(XL_NhanVien.ChuoiGioiTinh(NhanVien))
        itemNhanVien.SubItems.Add(NhanVien.NgaySinh)
        itemNhanVien.SubItems.Add(XL_NhanVien.Tuoi(NhanVien))
        itemNhanVien.SubItems.Add(NhanVien.DiaChi)
        itemNhanVien.Tag = NhanVien
        Return itemNhanVien
    End Function
End Class
