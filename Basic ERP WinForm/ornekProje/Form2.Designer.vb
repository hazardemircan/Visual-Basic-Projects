<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ekle = New System.Windows.Forms.Button()
        Me.XGrid_musteri = New bym_dll.XGrid()
        Me.sil = New System.Windows.Forms.Button()
        Me.IDmusteri = New System.Windows.Forms.TextBox()
        Me.XGrid_siparis = New bym_dll.XGrid()
        Me.label1 = New System.Windows.Forms.Label()
        Me.XGrid_siparisler = New bym_dll.XGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.isim = New System.Windows.Forms.TextBox()
        Me.adres = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.soyisim = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.silMusteri = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.siparisekle = New System.Windows.Forms.Button()
        Me.mussiparisID = New System.Windows.Forms.TextBox()
        Me.IDsiparis = New System.Windows.Forms.TextBox()
        Me.urunismi = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ekle
        '
        Me.ekle.Location = New System.Drawing.Point(0, 230)
        Me.ekle.Name = "ekle"
        Me.ekle.Size = New System.Drawing.Size(126, 39)
        Me.ekle.TabIndex = 2
        Me.ekle.Text = "Ekle"
        Me.ekle.UseVisualStyleBackColor = True
        '
        'XGrid_musteri
        '
        Me.XGrid_musteri.BackColor = System.Drawing.Color.White
        Me.XGrid_musteri.DataSource = Nothing
        Me.XGrid_musteri.Location = New System.Drawing.Point(267, 29)
        Me.XGrid_musteri.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.XGrid_musteri.MenuItem3 = Nothing
        Me.XGrid_musteri.MenuItem31 = Nothing
        Me.XGrid_musteri.MenuItem33 = Nothing
        Me.XGrid_musteri.MenuItem35 = Nothing
        Me.XGrid_musteri.Name = "XGrid_musteri"
        Me.XGrid_musteri.RowCount = 0
        Me.XGrid_musteri.Size = New System.Drawing.Size(1026, 220)
        Me.XGrid_musteri.TabIndex = 5
        Me.XGrid_musteri.X_RowCount = 0
        Me.XGrid_musteri.X_Secili_Satir = 0
        Me.XGrid_musteri.X_Secili_Sutun = ""
        Me.XGrid_musteri.XGrpPanel = True
        Me.XGrid_musteri.XSatirYuks = CType(-1, Short)
        Me.XGrid_musteri.XYukleniyor = False
        '
        'sil
        '
        Me.sil.Location = New System.Drawing.Point(0, 83)
        Me.sil.Name = "sil"
        Me.sil.Size = New System.Drawing.Size(122, 40)
        Me.sil.TabIndex = 6
        Me.sil.Text = "Sil"
        Me.sil.UseVisualStyleBackColor = True
        '
        'IDmusteri
        '
        Me.IDmusteri.Location = New System.Drawing.Point(6, 64)
        Me.IDmusteri.Multiline = True
        Me.IDmusteri.Name = "IDmusteri"
        Me.IDmusteri.Size = New System.Drawing.Size(100, 22)
        Me.IDmusteri.TabIndex = 7
        '
        'XGrid_siparis
        '
        Me.XGrid_siparis.BackColor = System.Drawing.Color.White
        Me.XGrid_siparis.DataSource = Nothing
        Me.XGrid_siparis.Location = New System.Drawing.Point(267, 266)
        Me.XGrid_siparis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.XGrid_siparis.MenuItem3 = Nothing
        Me.XGrid_siparis.MenuItem31 = Nothing
        Me.XGrid_siparis.MenuItem33 = Nothing
        Me.XGrid_siparis.MenuItem35 = Nothing
        Me.XGrid_siparis.Name = "XGrid_siparis"
        Me.XGrid_siparis.RowCount = 0
        Me.XGrid_siparis.Size = New System.Drawing.Size(1026, 203)
        Me.XGrid_siparis.TabIndex = 8
        Me.XGrid_siparis.X_RowCount = 0
        Me.XGrid_siparis.X_Secili_Satir = 0
        Me.XGrid_siparis.X_Secili_Sutun = ""
        Me.XGrid_siparis.XGrpPanel = True
        Me.XGrid_siparis.XSatirYuks = CType(-1, Short)
        Me.XGrid_siparis.XYukleniyor = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(7, 35)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(71, 17)
        Me.label1.TabIndex = 9
        Me.label1.Text = "Müşteri ID"
        '
        'XGrid_siparisler
        '
        Me.XGrid_siparisler.BackColor = System.Drawing.Color.White
        Me.XGrid_siparisler.DataSource = Nothing
        Me.XGrid_siparisler.Location = New System.Drawing.Point(267, 500)
        Me.XGrid_siparisler.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.XGrid_siparisler.MenuItem3 = Nothing
        Me.XGrid_siparisler.MenuItem31 = Nothing
        Me.XGrid_siparisler.MenuItem33 = Nothing
        Me.XGrid_siparisler.MenuItem35 = Nothing
        Me.XGrid_siparisler.Name = "XGrid_siparisler"
        Me.XGrid_siparisler.RowCount = 0
        Me.XGrid_siparisler.Size = New System.Drawing.Size(1026, 203)
        Me.XGrid_siparisler.TabIndex = 10
        Me.XGrid_siparisler.X_RowCount = 0
        Me.XGrid_siparisler.X_Secili_Satir = 0
        Me.XGrid_siparisler.X_Secili_Sutun = ""
        Me.XGrid_siparisler.XGrpPanel = True
        Me.XGrid_siparisler.XSatirYuks = CType(-1, Short)
        Me.XGrid_siparisler.XYukleniyor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.IDmusteri)
        Me.GroupBox1.Controls.Add(Me.isim)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Controls.Add(Me.adres)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.soyisim)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ekle)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(126, 279)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Müşteri Ekle"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 17)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Şehir"
        '
        'isim
        '
        Me.isim.Location = New System.Drawing.Point(6, 109)
        Me.isim.Name = "isim"
        Me.isim.Size = New System.Drawing.Size(100, 22)
        Me.isim.TabIndex = 20
        '
        'adres
        '
        Me.adres.Location = New System.Drawing.Point(6, 202)
        Me.adres.Name = "adres"
        Me.adres.Size = New System.Drawing.Size(100, 22)
        Me.adres.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "İsim"
        '
        'soyisim
        '
        Me.soyisim.Location = New System.Drawing.Point(6, 157)
        Me.soyisim.Name = "soyisim"
        Me.soyisim.Size = New System.Drawing.Size(100, 22)
        Me.soyisim.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Soyisim"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(0, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Müşteri ID"
        '
        'silMusteri
        '
        Me.silMusteri.Location = New System.Drawing.Point(0, 55)
        Me.silMusteri.Name = "silMusteri"
        Me.silMusteri.Size = New System.Drawing.Size(100, 22)
        Me.silMusteri.TabIndex = 17
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.sil)
        Me.GroupBox2.Controls.Add(Me.silMusteri)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(138, 147)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(122, 135)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Müşteri Sil"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(267, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Müşteriler"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(267, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(490, 17)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Müşteri Siparişleri (Listeleme için Müşteriler tablosundaki hücrelere tıklayınız)" &
    ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(267, 479)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(177, 17)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Müşterilerin Sipariş Bilgileri"
        '
        'siparisekle
        '
        Me.siparisekle.Location = New System.Drawing.Point(20, 168)
        Me.siparisekle.Name = "siparisekle"
        Me.siparisekle.Size = New System.Drawing.Size(100, 36)
        Me.siparisekle.TabIndex = 22
        Me.siparisekle.Text = "Sipariş Ekle"
        Me.siparisekle.UseVisualStyleBackColor = True
        '
        'mussiparisID
        '
        Me.mussiparisID.Location = New System.Drawing.Point(20, 49)
        Me.mussiparisID.Name = "mussiparisID"
        Me.mussiparisID.Size = New System.Drawing.Size(100, 22)
        Me.mussiparisID.TabIndex = 23
        '
        'IDsiparis
        '
        Me.IDsiparis.Location = New System.Drawing.Point(20, 91)
        Me.IDsiparis.Name = "IDsiparis"
        Me.IDsiparis.Size = New System.Drawing.Size(100, 22)
        Me.IDsiparis.TabIndex = 24
        '
        'urunismi
        '
        Me.urunismi.Location = New System.Drawing.Point(20, 133)
        Me.urunismi.Name = "urunismi"
        Me.urunismi.Size = New System.Drawing.Size(100, 22)
        Me.urunismi.TabIndex = 25
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.IDsiparis)
        Me.GroupBox3.Controls.Add(Me.urunismi)
        Me.GroupBox3.Controls.Add(Me.siparisekle)
        Me.GroupBox3.Controls.Add(Me.mussiparisID)
        Me.GroupBox3.Location = New System.Drawing.Point(53, 500)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(141, 203)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sipariş Ekle"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 17)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Muşteri ID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 17)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Sipariş ID"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 17)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Ürün "
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1347, 716)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.XGrid_siparisler)
        Me.Controls.Add(Me.XGrid_siparis)
        Me.Controls.Add(Me.XGrid_musteri)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ekle As Button
    Friend WithEvents XGrid_musteri As bym_dll.XGrid
    Friend WithEvents sil As Button
    Friend WithEvents IDmusteri As TextBox
    Friend WithEvents XGrid_siparis As bym_dll.XGrid
    Friend WithEvents label1 As Label
    Friend WithEvents XGrid_siparisler As bym_dll.XGrid
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents isim As TextBox
    Friend WithEvents adres As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents soyisim As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents silMusteri As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents siparisekle As Button
    Friend WithEvents mussiparisID As TextBox
    Friend WithEvents IDsiparis As TextBox
    Friend WithEvents urunismi As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
