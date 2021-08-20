Imports bym_dll
Imports DevExpress.XtraGrid.Views.Base
Imports System.Data
Public Class Form2

    'Public Function xgrid(x As Object, kolonSayi As Integer, tbl_name As String, tbl As String, uzunluk As Integer, karakterSayi As Integer, degismek As Boolean, gorunur As Boolean, dt As DataTable, sorgu As String)
    '    For i As Integer = 0 To kolonSayi
    '        x.X_Kolon_Ekle("T", i, tbl_name, tbl, uzunluk, karakterSayi, "", "", 0, degismek, gorunur, Color.DarkGray, Color.Black, DataGridViewColumnSortMode.NotSortable, f)
    '    Next

    '    XGrid_musteri.X_Tasarim_Yukle()


    '    dt = SQL_TABLO(B_SQL, sorgu)

    '    x.DataSource = dt
    '    x.GridView1.OptionsView.EnableAppearanceEvenRow = True   'Çift Satır Renklendirme
    '    x.XGrpPanel = False
    '    x.B_Ozel.Visible = True

    '    x.XSatirYuks = 40
    '    x.GridView1.OptionsView.ColumnAutoWidth = True


    '    x.GridView1.Appearance.SelectedRow.BackColor = Color.LightGreen
    '    x.GridView1.OptionsSelection.MultiSelect = True
    '    x.GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
    '    x.Renk_Tayfi = True

    '    x.MenuItem28.Enabled = False
    '    x.Filtre_Kapat()
    '    x.X_Tasarim_Yukle()
    'End Function

    Public f As New Font("Microsoft Sans Serif", 7.8)
    Public dt As New DataTable
    Public dt1 As New DataTable
    Public dt2 As New DataTable
    Public dt3 As New DataTable
    Public joinsorgu As String = "SELECT musteriler.musteriID, musteriler.isim, musteriler.soyisim, siparisler.siparisID,siparisler.urun, musteriler.adres From musteriler inner join siparisler on musteriler.musteriID=siparisler.musteriID "
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SQL_TUR = "2005"
        B_SQL = "Data Source=V1;Initial Catalog=ornekProje;Integrated Security=True"
        SQL_TEST(B_SQL)



        XGrid_musteri.X_Kolon_Ekle("T", 0, "Musteri ID", "musteriID", 5, 5, "", "", 0, True, True, Color.DarkGray, Color.Black, DataGridViewColumnSortMode.NotSortable, f)
        XGrid_musteri.X_Kolon_Ekle("T", 1, "İsim", "isim", 8, 8, "", "", 0, False, True, Color.DarkGray, Color.Black, DataGridViewColumnSortMode.NotSortable, f)
        XGrid_musteri.X_Kolon_Ekle("T", 2, "Soyisim", "soyisim", 10, 10, "", "", 0, False, True, Color.DarkGray, Color.Black, DataGridViewColumnSortMode.NotSortable, f)
        XGrid_musteri.X_Kolon_Ekle("T", 3, "Şehir", "adres", 10, 10, "", "", 0, False, True, Color.DarkGray, Color.Black, DataGridViewColumnSortMode.NotSortable, f)

        XGrid_musteri.X_Tasarim_Yukle()


        dt = SQL_TABLO(B_SQL, "SELECT * From musteriler", "T", True, True, True)

        XGrid_musteri.DataSource = dt
        XGrid_musteri.GridView1.OptionsView.EnableAppearanceEvenRow = True   'Çift Satır Renklendirme
        XGrid_musteri.XGrpPanel = False
        XGrid_musteri.B_Ozel.Visible = True

        XGrid_musteri.XSatirYuks = 40
        XGrid_musteri.GridView1.OptionsView.ColumnAutoWidth = True


        XGrid_musteri.GridView1.Appearance.SelectedRow.BackColor = Color.LightGreen
        XGrid_musteri.GridView1.OptionsSelection.MultiSelect = True
        XGrid_musteri.GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        XGrid_musteri.Renk_Tayfi = True

        XGrid_musteri.MenuItem28.Enabled = False
        XGrid_musteri.Filtre_Kapat()
        XGrid_musteri.X_Tasarim_Yukle()

        '-------------------------------------------------

        XGrid_siparis.X_Kolon_Ekle("T", 0, "Sipariş ID", "siparisID", 5, 5, "", "", 0, True, True, Color.DarkGray, Color.Black, DataGridViewColumnSortMode.NotSortable, f)
        XGrid_siparis.X_Kolon_Ekle("T", 1, "Muşteri ID", "musteriID", 8, 8, "", "", 0, True, True, Color.DarkGray, Color.Black, DataGridViewColumnSortMode.NotSortable, f)
        XGrid_siparis.X_Kolon_Ekle("T", 2, "Ürün", "urun", 10, 10, "", "", 0, True, True, Color.DarkGray, Color.Black, DataGridViewColumnSortMode.NotSortable, f)


        XGrid_siparis.X_Tasarim_Yukle()


        dt1 = SQL_TABLO(B_SQL, "SELECT * From siparisler")

        XGrid_siparis.DataSource = dt1
        XGrid_siparis.GridView1.OptionsView.EnableAppearanceEvenRow = True   'Çift Satır Renklendirme
        XGrid_siparis.XGrpPanel = False
        XGrid_siparis.B_Ozel.Visible = True

        XGrid_siparis.XSatirYuks = 40
        XGrid_siparis.GridView1.OptionsView.ColumnAutoWidth = True


        XGrid_siparis.GridView1.Appearance.SelectedRow.BackColor = Color.LightGreen
        XGrid_siparis.GridView1.OptionsSelection.MultiSelect = True
        XGrid_siparis.GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        XGrid_siparis.Renk_Tayfi = True

        XGrid_siparis.MenuItem28.Enabled = False
        XGrid_siparis.Filtre_Kapat()
        XGrid_siparis.X_Tasarim_Yukle()

        '--------------------------------------------------
        XGrid_siparisler.X_Kolon_Ekle("T", 0, "Muşteri ID", "musteriID", 5, 5, "", "", 0, True, True, Color.DarkGray, Color.Black, DataGridViewColumnSortMode.NotSortable, f)
        XGrid_siparisler.X_Kolon_Ekle("T", 1, "Müşteri Adı", "isim", 8, 8, "", "", 0, True, True, Color.DarkGray, Color.Black, DataGridViewColumnSortMode.NotSortable, f)
        XGrid_siparisler.X_Kolon_Ekle("T", 2, "Müşteri Soyadı", "soyisim", 8, 8, "", "", 0, True, True, Color.DarkGray, Color.Black, DataGridViewColumnSortMode.NotSortable, f)
        XGrid_siparisler.X_Kolon_Ekle("T", 4, "Sipariş ID", "siparisID", 5, 5, "", "", 0, True, True, Color.DarkGray, Color.Black, DataGridViewColumnSortMode.NotSortable, f)
        XGrid_siparisler.X_Kolon_Ekle("T", 5, "Ürün Adı", "urun", 8, 8, "", "", 0, True, True, Color.DarkGray, Color.Black, DataGridViewColumnSortMode.NotSortable, f)
        XGrid_siparisler.X_Kolon_Ekle("T", 6, "Şehir", "adres", 9, 9, "", "", 0, True, True, Color.DarkGray, Color.Black, DataGridViewColumnSortMode.NotSortable, f)
        XGrid_siparisler.X_Tasarim_Yukle()

        dt2 = SQL_TABLO(B_SQL, joinsorgu, "T", True, True, True)

        XGrid_siparisler.DataSource = dt2
        XGrid_siparisler.GridView1.OptionsView.EnableAppearanceEvenRow = True   'Çift Satır Renklendirme
        XGrid_siparisler.XGrpPanel = False
        XGrid_siparisler.B_Ozel.Visible = True

        XGrid_siparisler.XSatirYuks = 40
        XGrid_siparisler.GridView1.OptionsView.ColumnAutoWidth = True


        XGrid_siparisler.GridView1.Appearance.SelectedRow.BackColor = Color.LightGreen
        XGrid_siparisler.GridView1.OptionsSelection.MultiSelect = True
        XGrid_siparisler.GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        XGrid_siparisler.Renk_Tayfi = True

        XGrid_siparisler.MenuItem28.Enabled = False
        XGrid_siparisler.Filtre_Kapat()
        XGrid_siparisler.X_Tasarim_Yukle()
    End Sub

    Private Sub ekle_Click(sender As Object, e As EventArgs) Handles ekle.Click

        SQL_KOS("INSERT INTO musteriler values('" + IDmusteri.Text + "','" + isim.Text + "','" + soyisim.Text + "','" + adres.Text + "');")

        dt = SQL_TABLO(B_SQL, "SELECT * From musteriler")
        dt1 = SQL_TABLO(B_SQL, "SELECT * From siparisler")
        dt2 = SQL_TABLO(B_SQL, joinsorgu, "T", True, True, True)
        XGrid_musteri.DataSource = dt
        XGrid_siparis.DataSource = dt1
        XGrid_siparisler.DataSource = dt2
        IDmusteri.Clear()
        isim.Clear()
        soyisim.Clear()
        adres.Clear()
    End Sub

    Private Sub sil_Click(sender As Object, e As EventArgs) Handles sil.Click
        SQL_KOS("DELETE FROM musteriler where musteriID='" + silMusteri.Text + "';")
        SQL_KOS("DELETE FROM siparisler where musteriID='" + silMusteri.Text + "';")
        dt = SQL_TABLO(B_SQL, "SELECT * From musteriler")
        dt1 = SQL_TABLO(B_SQL, "select * from siparisler")
        dt2 = SQL_TABLO(B_SQL, joinsorgu, "T", True, True, True)
        XGrid_musteri.DataSource = dt
        XGrid_siparis.DataSource = dt1
        XGrid_siparisler.DataSource = dt2
        silMusteri.Clear()
    End Sub

    'Private Sub mussip_listele_Click(sender As Object, e As EventArgs) Handles mussip_listele.Click
    '    dt3 = SQL_TABLO("Select musteriler.musteriID,musteriler.isim,musteriler.soyisim,musteriler.adres,siparisler.siparisID,siparisler.urun from musteriler inner join siparisler On musteriler.musteriID=siparisler.musteriID where musteriID='" + musID.Text + "';")

    '    '!!!!SORUN VAR LİSTELEMİYOR!!!!!!!
    '    XGrid_join.DataSource = dt3
    '    XGrid_join.GridView1.OptionsView.EnableAppearanceEvenRow = True   'Çift Satır Renklendirme
    '    XGrid_join.XGrpPanel = False
    '    XGrid_join.B_Ozel.Visible = True

    '    XGrid_join.XSatirYuks = 40
    '    XGrid_join.GridView1.OptionsView.ColumnAutoWidth = True


    '    XGrid_join.GridView1.Appearance.SelectedRow.BackColor = Color.LightGreen
    '    XGrid_join.GridView1.OptionsSelection.MultiSelect = True
    '    XGrid_join.GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
    '    XGrid_join.Renk_Tayfi = True

    '    XGrid_join.MenuItem28.Enabled = False
    '    XGrid_join.Filtre_Kapat()
    '    XGrid_join.X_Tasarim_Yukle()
    '    musID.Clear()
    'End Sub


    Private Sub XGrid_musteri_XGrid_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles XGrid_musteri.XGrid_RowCellClick

        'If MKUTU(XGrid_musteri.X_NULA(e.RowHandle, "adres"), "EH", "Uyarı") = XL_Hayir Then

        'End If

        Dim id As String = NULA(XGrid_musteri, e.RowHandle, "musteriID")
        'Dim ad As String = NULA(XGrid_musteri, e.RowHandle, "isim")
        '   Dim sip As String = NULA(XGrid_siparis, e.RowHandle, "siparisID")
        '   Dim adr As String = NULA(XGrid_musteri, e.RowHandle, "adres")

        dt1 = SQL_TABLO(B_SQL, "select siparisID, musteriID, urun from siparisler where musteriID = '" & id & "' ")
        XGrid_siparis.DataSource = dt1
        'SQL_KOS("INSERT INTO musteri_siparis (musteriID,isim,siparisID,adres) values('" + id + "','" + ad + "','" + sip + "','" + adr + "')")
        'SQL_KOS("delete from musteri_siparis where siparisID='" + "" + "'")
    End Sub

    Private Sub XGrid_musteri_XGrid_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles XGrid_musteri.XGrid_CellValueChanged

        Dim COL As String = ""

        COL = XGrid_musteri.X_Secili_Sutun

        If NULA(XGrid_musteri, e.RowHandle, "musteriID") = "" Then

        Else
            If COL = "musteriID" Then
                Exit Sub
            Else
                Dim sq As String = "UPDATE musteriler set " & COL & " = '" & NULA(XGrid_musteri, e.RowHandle, COL) & "' WHERE musteriID = '" & NULA(XGrid_musteri, e.RowHandle, "musteriID") & "'"
                SQL_KOS(sq)
                dt2 = SQL_TABLO(B_SQL, joinsorgu, "T", True, True, True)
                XGrid_siparisler.DataSource = dt2
            End If
        End If
    End Sub

    Private Sub siparisekle_Click(sender As Object, e As EventArgs) Handles siparisekle.Click
        SQL_KOS("If EXISTS (SELECT * FROM musteriler WHERE musteriID = '" + mussiparisID.Text + "')
BEGIN
INSERT INTO siparisler VALUES('" + IDsiparis.Text + "','" + mussiparisID.Text + "','" + urunismi.Text + "');
END
Else
BEGIN
DELETE FROM siparisler WHERE musteriID='" + mussiparisID.Text + "'
End")
        dt1 = SQL_TABLO(B_SQL, "SELECT * From siparisler")
        dt2 = SQL_TABLO(B_SQL, joinsorgu, "T", True, True, True)
        XGrid_siparis.DataSource = dt1
        XGrid_siparisler.DataSource = dt2

        mussiparisID.Clear()
        IDsiparis.Clear()
        urunismi.Clear()
        'SQL_KOS("INSERT INTO siparisler values('" + IDsiparis.Text + "','" + mussiparisID.Text + "', '" + urunismi.Text + "') where musteriID='" + mussiparisID.Text + "'")
        'MKUTU("Sipariş eklemek istediğiniz müşteri sistemde kayıtlı değil!", "T", "Uyarı") 
    End Sub


End Class