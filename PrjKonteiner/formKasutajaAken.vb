Public Class formKasutajaAken
    Private Sub btnPooraProtseduuriga_Click(sender As Object, e As EventArgs) Handles btnPooraProtseduuriga.Click

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
End Class
