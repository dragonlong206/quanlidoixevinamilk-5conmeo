<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_CongTy
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
        Me.Xl_Button = New System.Windows.Forms.Button
        Me.Th_DiaChi = New System.Windows.Forms.TextBox
        Me.Th_DienThoai = New System.Windows.Forms.TextBox
        Me.Th_Ten = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Xl_Button
        '
        Me.Xl_Button.Location = New System.Drawing.Point(145, 261)
        Me.Xl_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Xl_Button.Name = "Xl_Button"
        Me.Xl_Button.Size = New System.Drawing.Size(104, 32)
        Me.Xl_Button.TabIndex = 13
        Me.Xl_Button.Text = "OK"
        Me.Xl_Button.UseVisualStyleBackColor = True
        '
        'Th_DiaChi
        '
        Me.Th_DiaChi.Location = New System.Drawing.Point(145, 214)
        Me.Th_DiaChi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Th_DiaChi.Name = "Th_DiaChi"
        Me.Th_DiaChi.Size = New System.Drawing.Size(212, 26)
        Me.Th_DiaChi.TabIndex = 12
        '
        'Th_DienThoai
        '
        Me.Th_DienThoai.Location = New System.Drawing.Point(145, 158)
        Me.Th_DienThoai.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Th_DienThoai.Name = "Th_DienThoai"
        Me.Th_DienThoai.Size = New System.Drawing.Size(212, 26)
        Me.Th_DienThoai.TabIndex = 11
        '
        'Th_Ten
        '
        Me.Th_Ten.Location = New System.Drawing.Point(145, 100)
        Me.Th_Ten.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Th_Ten.Name = "Th_Ten"
        Me.Th_Ten.Size = New System.Drawing.Size(212, 26)
        Me.Th_Ten.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 214)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Địa chỉ:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 159)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Điện thoại:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Tên:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "THÔNG TIN CÔNG TY"
        '
        'MH_CongTy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 310)
        Me.Controls.Add(Me.Xl_Button)
        Me.Controls.Add(Me.Th_DiaChi)
        Me.Controls.Add(Me.Th_DienThoai)
        Me.Controls.Add(Me.Th_Ten)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MH_CongTy"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Xl_Button As System.Windows.Forms.Button
    Friend WithEvents Th_DiaChi As System.Windows.Forms.TextBox
    Friend WithEvents Th_DienThoai As System.Windows.Forms.TextBox
    Friend WithEvents Th_Ten As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
