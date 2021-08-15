<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.hesapla = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.kilo = New System.Windows.Forms.TextBox()
        Me.boy = New System.Windows.Forms.TextBox()
        Me.Reset = New System.Windows.Forms.Button()
        Me.Cikis = New System.Windows.Forms.Button()
        Me.vki = New System.Windows.Forms.Label()
        Me.hesap = New System.Windows.Forms.TextBox()
        Me.aciklama = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'hesapla
        '
        Me.hesapla.Location = New System.Drawing.Point(18, 285)
        Me.hesapla.Margin = New System.Windows.Forms.Padding(4)
        Me.hesapla.Name = "hesapla"
        Me.hesapla.Size = New System.Drawing.Size(128, 60)
        Me.hesapla.TabIndex = 0
        Me.hesapla.Text = "Hesapla"
        Me.hesapla.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(11, 25)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(54, 17)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Kilonuz"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(13, 82)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(95, 17)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Boyunuz (cm)"
        '
        'kilo
        '
        Me.kilo.Location = New System.Drawing.Point(13, 46)
        Me.kilo.Margin = New System.Windows.Forms.Padding(4)
        Me.kilo.Multiline = True
        Me.kilo.Name = "kilo"
        Me.kilo.Size = New System.Drawing.Size(133, 32)
        Me.kilo.TabIndex = 5
        '
        'boy
        '
        Me.boy.Location = New System.Drawing.Point(14, 103)
        Me.boy.Margin = New System.Windows.Forms.Padding(4)
        Me.boy.Multiline = True
        Me.boy.Name = "boy"
        Me.boy.Size = New System.Drawing.Size(132, 32)
        Me.boy.TabIndex = 7
        '
        'Reset
        '
        Me.Reset.Location = New System.Drawing.Point(172, 285)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(117, 60)
        Me.Reset.TabIndex = 9
        Me.Reset.Text = "Resetle"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Cikis
        '
        Me.Cikis.Location = New System.Drawing.Point(318, 285)
        Me.Cikis.Name = "Cikis"
        Me.Cikis.Size = New System.Drawing.Size(110, 60)
        Me.Cikis.TabIndex = 10
        Me.Cikis.Text = "Çıkış"
        Me.Cikis.UseVisualStyleBackColor = True
        '
        'vki
        '
        Me.vki.AutoSize = True
        Me.vki.Location = New System.Drawing.Point(160, 176)
        Me.vki.Name = "vki"
        Me.vki.Size = New System.Drawing.Size(129, 17)
        Me.vki.TabIndex = 11
        Me.vki.Text = "Vücut Kitle Endeksi"
        '
        'hesap
        '
        Me.hesap.Location = New System.Drawing.Point(141, 210)
        Me.hesap.Multiline = True
        Me.hesap.Name = "hesap"
        Me.hesap.Size = New System.Drawing.Size(166, 45)
        Me.hesap.TabIndex = 12
        '
        'aciklama
        '
        Me.aciklama.Location = New System.Drawing.Point(231, 37)
        Me.aciklama.Multiline = True
        Me.aciklama.Name = "aciklama"
        Me.aciklama.Size = New System.Drawing.Size(208, 98)
        Me.aciklama.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 358)
        Me.Controls.Add(Me.aciklama)
        Me.Controls.Add(Me.hesap)
        Me.Controls.Add(Me.vki)
        Me.Controls.Add(Me.Cikis)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.boy)
        Me.Controls.Add(Me.kilo)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.hesapla)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents hesapla As Button
    Friend WithEvents label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents kilo As TextBox
    Friend WithEvents boy As TextBox
    Friend WithEvents Reset As Button
    Friend WithEvents Cikis As Button
    Friend WithEvents vki As Label
    Friend WithEvents hesap As TextBox
    Friend WithEvents aciklama As TextBox
End Class
