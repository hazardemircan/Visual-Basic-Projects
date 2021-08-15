Public Class Form1
    Dim agirlik As Double
    Dim uzunluk As Double
    Dim sonuc As Double
    Private Sub hesapla_Click(sender As Object, e As EventArgs) Handles hesapla.Click
        agirlik = kilo.Text
        uzunluk = boy.Text / 100
        sonuc = agirlik / ((uzunluk * uzunluk))

        hesap.Text = String.Format("{0:f}", sonuc)

        If sonuc <= 18.5 Then
            aciklama.BackColor = Color.Red
            aciklama.Text = "Düşük Kilodasınız"
        End If
        If sonuc <= 24.9 And sonuc > 18.5 Then
            aciklama.BackColor = Color.SkyBlue
            aciklama.Text = "Normal kilodasınız"
        End If
        If sonuc <= 29.9 And sonuc > 24.9 Then
            aciklama.BackColor = Color.YellowGreen
            aciklama.Text = "Fazla Kilolarınız Var"
        End If
        If sonuc <= 40 And sonuc > 29.9 Then
            aciklama.BackColor = Color.Red
            aciklama.Text = "Obezite sahibisiniz, sağlığınıza dikkat edin"
        End If
        If sonuc >= 40 Then
            aciklama.BackColor = Color.DarkRed
            aciklama.Text = "Asırı obezsiniz, acilen bir uzmandan yardım almalısınız"
        End If
    End Sub

    Private Sub Cikis_Click(sender As Object, e As EventArgs) Handles Cikis.Click
        Application.Exit()

    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        boy.Clear()
        kilo.Clear()


    End Sub
End Class
