Public Class AlgoritmilinePooraja
    Implements ITeisendaja

    ' Samad klassi muutujad, mis ka TekstiPooraja puhul
    Private AlgusSymbol As Integer
    Private LoppSymbol As Integer
    Private PooratavTekst As String

    ' Liidese atribuudid (ASCII koodid, tekst)
    Private Property EsimeseTaheAsciiKood As Integer Implements ITeisendaja.EsimeseTaheAsciiKood
        Get
            Return AlgusSymbol
        End Get
        Set(value As Integer)
            AlgusSymbol = value
        End Set
    End Property

    Private Property ViimaseTaheAsciiKood As Integer Implements ITeisendaja.ViimaseTaheAsciiKood
        Get
            Return LoppSymbol
        End Get
        Set(value As Integer)
            LoppSymbol = value
        End Set
    End Property

    Private Property Tekst As String Implements ITeisendaja.Tekst
        Get
            Return PooratavTekst
        End Get
        Set(value As String)
            PooratavTekst = value
        End Set
    End Property

    ' Liidese meetod: võtame parameetrina etteantud teksti
    ' ja salvestame tagurpidi kujul.
    Private Sub TeisendaTekst(ByRef sisendtekst As String) Implements ITeisendaja.TeisendaTekst
        Dim reversed As String = ""
        For i As Integer = sisendtekst.Length - 1 To 0 Step -1
            reversed &= sisendtekst(i)
        Next

        PooratavTekst = reversed

        ' Värskendame ASCII koode, kui tekst ei ole tühi
        If reversed.Length > 0 Then
            AlgusSymbol = Asc(reversed(0))
            LoppSymbol = Asc(reversed(reversed.Length - 1))
        Else
            AlgusSymbol = 0
            LoppSymbol = 0
        End If
    End Sub

    ' Funktsioon: pöörab juba klassi sees hoitavat PooratavTekst-i 
    Private Function PooraTekst() As String Implements ITeisendaja.PooraTekst
        Dim reversed As String = ""
        If PooratavTekst IsNot Nothing Then
            For i As Integer = PooratavTekst.Length - 1 To 0 Step -1
                reversed &= PooratavTekst(i)
            Next
        End If
        Return reversed
    End Function

    Public Function TaisHaalikuteArv() As Integer Implements ITeisendaja.TaisHaalikuteArv
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
