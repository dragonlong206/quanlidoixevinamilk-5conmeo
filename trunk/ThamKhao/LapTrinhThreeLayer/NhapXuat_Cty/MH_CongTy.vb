Public Class MH_CongTy

    Private Sub MH_CongTy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim CongTy As CONG_TY = XL_CongTy.Doc()
        Xuat(CongTy)
    End Sub

    Private Sub Xl_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Xl_Button.Click
        Dim CongTy As CONG_TY = Nhap()
        Dim strThongBao As String = "MH_CongTy/XlButtonClick:" & vbCrLf & "Thong tin chua cap nhat."
        If XL_CongTy.Ghi(CongTy) Then
            strThongBao = "MH_CongTy/XlButtonClick:" & vbCrLf & "Cong ty da duoc cap nhat."
        End If
        MessageBox.Show(strThongBao)
    End Sub

    Private Function Nhap() As CONG_TY
        Dim CongTy As CONG_TY        
        CongTy.Ten = Th_Ten.Text
        CongTy.DienThoai = Th_DienThoai.Text
        CongTy.DiaChi = Th_DiaChi.Text
        Return CongTy
    End Function

    Private Sub Xuat(ByVal CongTy As CONG_TY)
        Th_Ten.Text = CongTy.Ten
        Th_DienThoai.Text = CongTy.DienThoai
        Th_DiaChi.Text = CongTy.DiaChi
    End Sub
End Class
