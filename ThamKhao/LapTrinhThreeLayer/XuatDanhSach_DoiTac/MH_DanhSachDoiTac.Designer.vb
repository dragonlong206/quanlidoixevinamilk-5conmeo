<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_DanhSachDoiTac
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Th_DanhSach = New System.Windows.Forms.ListView
        Me.Ten = New System.Windows.Forms.ColumnHeader
        Me.DienThoai = New System.Windows.Forms.ColumnHeader
        Me.DiaChi = New System.Windows.Forms.ColumnHeader
        Me.Xl_Them = New System.Windows.Forms.Button
        Me.Th_DiaChi = New System.Windows.Forms.TextBox
        Me.Th_DienThoai = New System.Windows.Forms.TextBox
        Me.Th_Ten = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Xl_Xoa = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(113, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DANH SÁCH ĐỐI TÁC"
        '
        'Th_DanhSach
        '
        Me.Th_DanhSach.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Ten, Me.DienThoai, Me.DiaChi})
        Me.Th_DanhSach.Location = New System.Drawing.Point(41, 51)
        Me.Th_DanhSach.Name = "Th_DanhSach"
        Me.Th_DanhSach.Size = New System.Drawing.Size(325, 155)
        Me.Th_DanhSach.TabIndex = 2
        Me.Th_DanhSach.UseCompatibleStateImageBehavior = False
        Me.Th_DanhSach.View = System.Windows.Forms.View.Details
        '
        'Ten
        '
        Me.Ten.Text = "Tên"
        Me.Ten.Width = 100
        '
        'DienThoai
        '
        Me.DienThoai.Text = "Điện thoại"
        Me.DienThoai.Width = 120
        '
        'DiaChi
        '
        Me.DiaChi.Text = "Địa chỉ"
        Me.DiaChi.Width = 180
        '
        'Xl_Them
        '
        Me.Xl_Them.Location = New System.Drawing.Point(83, 368)
        Me.Xl_Them.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Xl_Them.Name = "Xl_Them"
        Me.Xl_Them.Size = New System.Drawing.Size(104, 32)
        Me.Xl_Them.TabIndex = 20
        Me.Xl_Them.Text = "Thêm"
        Me.Xl_Them.UseVisualStyleBackColor = True
        '
        'Th_DiaChi
        '
        Me.Th_DiaChi.Location = New System.Drawing.Point(130, 332)
        Me.Th_DiaChi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Th_DiaChi.Name = "Th_DiaChi"
        Me.Th_DiaChi.Size = New System.Drawing.Size(236, 26)
        Me.Th_DiaChi.TabIndex = 19
        '
        'Th_DienThoai
        '
        Me.Th_DienThoai.Location = New System.Drawing.Point(130, 276)
        Me.Th_DienThoai.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Th_DienThoai.Name = "Th_DienThoai"
        Me.Th_DienThoai.Size = New System.Drawing.Size(236, 26)
        Me.Th_DienThoai.TabIndex = 18
        '
        'Th_Ten
        '
        Me.Th_Ten.Location = New System.Drawing.Point(130, 218)
        Me.Th_Ten.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Th_Ten.Name = "Th_Ten"
        Me.Th_Ten.Size = New System.Drawing.Size(236, 26)
        Me.Th_Ten.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 332)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Địa chỉ:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 277)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Điện thoại:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 224)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Tên:"
        '
        'Xl_Xoa
        '
        Me.Xl_Xoa.Location = New System.Drawing.Point(240, 368)
        Me.Xl_Xoa.Name = "Xl_Xoa"
        Me.Xl_Xoa.Size = New System.Drawing.Size(95, 32)
        Me.Xl_Xoa.TabIndex = 21
        Me.Xl_Xoa.Text = "Xóa"
        Me.Xl_Xoa.UseVisualStyleBackColor = True
        '
        'MH_DanhSachDoiTac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 410)
        Me.Controls.Add(Me.Xl_Xoa)
        Me.Controls.Add(Me.Xl_Them)
        Me.Controls.Add(Me.Th_DiaChi)
        Me.Controls.Add(Me.Th_DienThoai)
        Me.Controls.Add(Me.Th_Ten)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Th_DanhSach)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MH_DanhSachDoiTac"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Th_DanhSach As System.Windows.Forms.ListView
    Friend WithEvents Ten As System.Windows.Forms.ColumnHeader
    Friend WithEvents DienThoai As System.Windows.Forms.ColumnHeader
    Friend WithEvents DiaChi As System.Windows.Forms.ColumnHeader
    Friend WithEvents Xl_Them As System.Windows.Forms.Button
    Friend WithEvents Th_DiaChi As System.Windows.Forms.TextBox
    Friend WithEvents Th_DienThoai As System.Windows.Forms.TextBox
    Friend WithEvents Th_Ten As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Xl_Xoa As System.Windows.Forms.Button

End Class
