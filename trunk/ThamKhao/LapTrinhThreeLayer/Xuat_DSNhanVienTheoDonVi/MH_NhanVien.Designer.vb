<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_NhanVien
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Th_Cay = New System.Windows.Forms.TreeView
        Me.Th_DanhSach = New System.Windows.Forms.ListView
        Me.Ten = New System.Windows.Forms.ColumnHeader
        Me.DiaChi = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.GioiTinh = New System.Windows.Forms.ColumnHeader
        Me.NgaySinh = New System.Windows.Forms.ColumnHeader
        Me.Tuoi = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Th_Cay
        '
        Me.Th_Cay.Location = New System.Drawing.Point(29, 61)
        Me.Th_Cay.Name = "Th_Cay"
        Me.Th_Cay.Size = New System.Drawing.Size(114, 208)
        Me.Th_Cay.TabIndex = 0
        '
        'Th_DanhSach
        '
        Me.Th_DanhSach.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Ten, Me.GioiTinh, Me.NgaySinh, Me.Tuoi, Me.DiaChi})
        Me.Th_DanhSach.Location = New System.Drawing.Point(179, 61)
        Me.Th_DanhSach.Name = "Th_DanhSach"
        Me.Th_DanhSach.Size = New System.Drawing.Size(291, 208)
        Me.Th_DanhSach.TabIndex = 1
        Me.Th_DanhSach.UseCompatibleStateImageBehavior = False
        Me.Th_DanhSach.View = System.Windows.Forms.View.Details
        '
        'Ten
        '
        Me.Ten.Text = "Tên"
        Me.Ten.Width = 120
        '
        'DiaChi
        '
        Me.DiaChi.Text = "Địa chỉ"
        Me.DiaChi.Width = 200
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(241, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DANH SÁCH NHÂN VIÊN"
        '
        'GioiTinh
        '
        Me.GioiTinh.DisplayIndex = 2
        Me.GioiTinh.Text = "Giới tính"
        '
        'NgaySinh
        '
        Me.NgaySinh.DisplayIndex = 3
        Me.NgaySinh.Text = "Ngày sinh"
        Me.NgaySinh.Width = 80
        '
        'Tuoi
        '
        Me.Tuoi.DisplayIndex = 4
        Me.Tuoi.Text = "Tuổi"
        Me.Tuoi.Width = 50
        '
        'MH_NhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 308)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Th_DanhSach)
        Me.Controls.Add(Me.Th_Cay)
        Me.Name = "MH_NhanVien"
        Me.Text = "MH_NhanVien"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Th_Cay As System.Windows.Forms.TreeView
    Friend WithEvents Th_DanhSach As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ten As System.Windows.Forms.ColumnHeader
    Friend WithEvents DiaChi As System.Windows.Forms.ColumnHeader
    Friend WithEvents GioiTinh As System.Windows.Forms.ColumnHeader
    Friend WithEvents NgaySinh As System.Windows.Forms.ColumnHeader
    Friend WithEvents Tuoi As System.Windows.Forms.ColumnHeader
End Class
