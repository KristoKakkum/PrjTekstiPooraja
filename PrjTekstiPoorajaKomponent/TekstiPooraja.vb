Public Class TekstiPooraja
    Implements ITeisendaja

    ' Klassi TekstiPooraja attribuudid (muutujad)
    Private AlgusSymbol As Integer
    Private LoppSymbol As Integer
    Private PooratavTekst As String

    ' Atribuut EsimeseThaeAsciikood seadistamine 
    Private Property EsimeseTaheAsciiKood As Integer Implements ITeisendaja.EsimeseTaheAsciiKood
        Get
            Return AlgusSymbol      ' Atribuudi küsimisel tagastame AlgusSymbol väärtuse
        End Get
        Set(value As Integer)
            AlgusSymbol = value     ' Salvestame atribuudi antava väärtuse
        End Set
    End Property

    ' Atribuut ViimaseTaheAsciiKood seadistamine
    Private Property ViimaseTaheAsciiKood As Integer Implements ITeisendaja.ViimaseTaheAsciiKood
        Get
            Return LoppSymbol       ' Atribuudi küsimisel tagastame LoppSymbol väärtuse
        End Get
        Set(value As Integer)
            LoppSymbol = value      ' Salvestame atribuudile antava väärtuse
        End Set
    End Property

    ' Atribuut tekst seadistamine
    Private Property Tekst As String Implements ITeisendaja.Tekst
        Get
            Return PooratavTekst     ' Atribuudi küsimisel tagastame PooratavTekst väärtuse
        End Get
        Set(value As String)
            PooratavTekst = value    ' Salvestame atribuudile antava väärtuse
        End Set
    End Property

    ' Meetod võtab parameetrina edastatud sõna, pöörab
    ' selle tagurpidi ning salvestab atribuuti Pooratavtekst
    Private Sub TeisendaTekst(ByRef sisendtekst As String) Implements ITeisendaja.TeisendaTekst
        PooratavTekst = StrReverse(sisendtekst)
    End Sub

    Private Function PooraTekst() As String Implements ITeisendaja.PooraTekst
        Return StrReverse(PooratavTekst)
    End Function

    Private Function ITeisendaja_TaisHaalikuteArv() As Integer _
        Implements ITeisendaja.TaisHaalikuteArv

        Dim taishaaled As String = "aeiouõäöüAEIOUÕÄÖÜ"
        Dim loendur As Integer = 0

        For Each ch As Char In PooratavTekst
            If taishaaled.Contains(ch) Then
                loendur += 1
            End If
        Next
        Return loendur
    End Function
End Class
