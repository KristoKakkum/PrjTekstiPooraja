Public Class formKasutajaAken
    Private Sub btnPooraProtseduuriga_Click(sender As Object, e As EventArgs) _
        Handles btnPooraProtseduuriga.Click


        ' Objecti loomine liidese baasil; referentsmuutuja pooraja deklaratsioon
        Dim pooraja As PrjTekstiPoorajaKomponent.ITeisendaja

        ' Seadistame referentsmuutuja viitama uuele objektile
        pooraja = New PrjTekstiPoorajaKomponent.TekstiPooraja

        ' teostame tektsi pööramise kasutades parametriseeritud protseduuri teisendatekst()
        ' ning liidese atribuuti strTekst

        ' Kutsume välja komponendis sisalduva protseduuri,
        ' andes kaasa tekstiväljal txtSisendTekst oleva sõna
        pooraja.TeisendaTekst(txtSisendTekst.Text)

        ' omistame tekstivälja txtvaljundText2 väärtuseks liidese atribuudi väärtuse
        txtValjundTekst2.Text = pooraja.Tekst
    End Sub

    Private Sub btnPooraFunktsiooniga_Click(sender As Object, e As EventArgs) _
        Handles btnPooraFunktsiooniga.Click

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

    Private Sub txtSisendTekst_TextChanged(sender As Object, e As EventArgs) Handles txtSisendTekst.TextChanged

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



    Private Sub lblTextInfo_Click(sender As Object, e As EventArgs) Handles lblTextInfo.Click

    End Sub
End Class
