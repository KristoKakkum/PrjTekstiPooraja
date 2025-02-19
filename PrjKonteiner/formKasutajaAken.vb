Imports PrjTekstiPoorajaKomponent

Public Class formKasutajaAken


    Private kasAlgoritmiline As Boolean = False

    Private Sub btnPooraProtseduuriga_Click(sender As Object, e As EventArgs) _
         Handles btnPooraProtseduuriga.Click

        ' 1) Loome ITeisendaja viite
        Dim pooraja As ITeisendaja

        ' 2) Sõltuvalt sellest, kas nupp AlgoritmilinePooramine on vajutatud
        If kasAlgoritmiline Then
            pooraja = New AlgoritmilinePooraja()
        Else
            pooraja = New TekstiPooraja()
        End If

        ' 3) Kasutame 'TeisendaTekst'
        pooraja.TeisendaTekst(txtSisendTekst.Text)

        ' 4) Näitame tulemust
        txtValjundTekst2.Text = pooraja.Tekst
    End Sub

    Private Sub btnPooraFunktsiooniga_Click(sender As Object, e As EventArgs) _
         Handles btnPooraFunktsiooniga.Click

        Dim pooraja As ITeisendaja

        If kasAlgoritmiline Then
            pooraja = New AlgoritmilinePooraja()
        Else
            pooraja = New TekstiPooraja()
        End If

        pooraja.Tekst = txtSisendTekst.Text

        txtValjundTekst1.Text = pooraja.PooraTekst()
    End Sub

    Private Sub txtSisendTekst_TextChanged(sender As Object, e As EventArgs) _
    Handles txtSisendTekst.TextChanged

        ' Loome viite liidesele:
        Dim pooraja As ITeisendaja = New TekstiPooraja()

        ' Nüüd on meil ligipääs TÄPSELT nendele liikmetele, mis on liideses defineeritud
        pooraja.Tekst = txtSisendTekst.Text

        Dim pikkus As Integer = pooraja.Tekst.Length
        Dim taisHaalikuid As Integer = pooraja.TaisHaalikuteArv()

        Dim infoStr As String = $"Pikkus: {pikkus}  |  Täishäälikuid: {taisHaalikuid}"

        If pikkus > 0 Then
            Dim esimeneAscii As Integer = Asc(pooraja.Tekst(0))
            Dim viimaneAscii As Integer = Asc(pooraja.Tekst(pikkus - 1))
            infoStr &= $"  |  Esimene tähe ASCII: {esimeneAscii}  |  Viimane tähe ASCII: {viimaneAscii}"
        End If

        lblTextInfo.Text = infoStr
    End Sub

    Private Sub txtValjundTekst1_TextChanged(sender As Object, e As EventArgs) Handles txtValjundTekst1.TextChanged

    End Sub

    Private Sub txtValjundTekst2_TextChanged(sender As Object, e As EventArgs) Handles txtValjundTekst2.TextChanged

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        ' Vajutus nupul lülitab taimeri timerUuenda sisse
        timerUuenda.Enabled = True

        ' nupp btnStart ise lülitatakse välja, vältimaks korduvat vajutamist
        btnStart.Enabled = False

        ' nupp btnStop lülitatakse sisse, et timerit saaks välja lülitada
        btnStopp.Enabled = True
    End Sub

    Private Sub btnStopp_Click(sender As Object, e As EventArgs) Handles btnStopp.Click

        timerUuenda.Enabled = False

        btnStart.Enabled = True
    End Sub

    Private Sub timerUuenda_Tick(sender As Object, e As EventArgs) Handles timerUuenda.Tick
        ' Objekti loomine liidese baasil; referentsmuutuja poorja deklaratsioon
        Dim pooraja As PrjTekstiPoorajaKomponent.ITeisendaja

        ' Seadistame referentsmuutuja viitama uuele objektile
        pooraja = New PrjTekstiPoorajaKomponent.TekstiPooraja

        ' Teostame teksti pööramise kasutades parametriseerimata funktsiooni pooraTekst
        ' ning liidese atribuuti strTekst

        ' Omistame liidese atribuudile txtSisendTekst tekstiväljal oleva sõna
        pooraja.Tekst = txtSisendTekst.Text

        ' Kasutades komponendis sisalduvat funktsiooni m,äärame tagastatud
        ' sõna tekstivälja txtValjundTekst1 tekstiks
        txtValjundTekst1.Text = pooraja.PooraTekst()
    End Sub

    Private Sub btnAlgoritmilinePooramine_Click(sender As Object, e As EventArgs) Handles btnAlgoritmilinePooramine.Click
        kasAlgoritmiline = True
    End Sub

    Private Sub btnAlgoritmOff_Click(sender As Object, e As EventArgs) Handles btnAlgoritmOff.Click
        kasAlgoritmiline = False
    End Sub
End Class
