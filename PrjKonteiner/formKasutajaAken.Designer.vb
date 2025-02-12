<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formKasutajaAken
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtSisendTekst = New System.Windows.Forms.TextBox()
        Me.txtValjundTekst1 = New System.Windows.Forms.TextBox()
        Me.txtValjundTekst2 = New System.Windows.Forms.TextBox()
        Me.btnPooraFunktsiooniga = New System.Windows.Forms.Button()
        Me.btnPooraProtseduuriga = New System.Windows.Forms.Button()
        Me.LblSisendTekst = New System.Windows.Forms.Label()
        Me.lblPooraFunktsiooniga = New System.Windows.Forms.Label()
        Me.lblPooraProtseduuriga = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtSisendTekst
        '
        Me.txtSisendTekst.Location = New System.Drawing.Point(228, 59)
        Me.txtSisendTekst.Name = "txtSisendTekst"
        Me.txtSisendTekst.Size = New System.Drawing.Size(618, 26)
        Me.txtSisendTekst.TabIndex = 0
        '
        'txtValjundTekst1
        '
        Me.txtValjundTekst1.Location = New System.Drawing.Point(228, 131)
        Me.txtValjundTekst1.Name = "txtValjundTekst1"
        Me.txtValjundTekst1.Size = New System.Drawing.Size(618, 26)
        Me.txtValjundTekst1.TabIndex = 1
        '
        'txtValjundTekst2
        '
        Me.txtValjundTekst2.Location = New System.Drawing.Point(228, 241)
        Me.txtValjundTekst2.Name = "txtValjundTekst2"
        Me.txtValjundTekst2.Size = New System.Drawing.Size(618, 26)
        Me.txtValjundTekst2.TabIndex = 2
        '
        'btnPooraFunktsiooniga
        '
        Me.btnPooraFunktsiooniga.Location = New System.Drawing.Point(372, 172)
        Me.btnPooraFunktsiooniga.Name = "btnPooraFunktsiooniga"
        Me.btnPooraFunktsiooniga.Size = New System.Drawing.Size(198, 37)
        Me.btnPooraFunktsiooniga.TabIndex = 3
        Me.btnPooraFunktsiooniga.Text = "Pööra funktsiooniga"
        Me.btnPooraFunktsiooniga.UseVisualStyleBackColor = True
        '
        'btnPooraProtseduuriga
        '
        Me.btnPooraProtseduuriga.Location = New System.Drawing.Point(372, 290)
        Me.btnPooraProtseduuriga.Name = "btnPooraProtseduuriga"
        Me.btnPooraProtseduuriga.Size = New System.Drawing.Size(198, 37)
        Me.btnPooraProtseduuriga.TabIndex = 4
        Me.btnPooraProtseduuriga.Text = "Pööra protseduuriga"
        Me.btnPooraProtseduuriga.UseVisualStyleBackColor = True
        '
        'LblSisendTekst
        '
        Me.LblSisendTekst.AutoSize = True
        Me.LblSisendTekst.Location = New System.Drawing.Point(13, 65)
        Me.LblSisendTekst.Name = "LblSisendTekst"
        Me.LblSisendTekst.Size = New System.Drawing.Size(97, 20)
        Me.LblSisendTekst.TabIndex = 5
        Me.LblSisendTekst.Text = "SisendTekst"
        '
        'lblPooraFunktsiooniga
        '
        Me.lblPooraFunktsiooniga.AutoSize = True
        Me.lblPooraFunktsiooniga.Location = New System.Drawing.Point(13, 137)
        Me.lblPooraFunktsiooniga.Name = "lblPooraFunktsiooniga"
        Me.lblPooraFunktsiooniga.Size = New System.Drawing.Size(150, 20)
        Me.lblPooraFunktsiooniga.TabIndex = 6
        Me.lblPooraFunktsiooniga.Text = "Pööra funktsiooniga"
        '
        'lblPooraProtseduuriga
        '
        Me.lblPooraProtseduuriga.AutoSize = True
        Me.lblPooraProtseduuriga.Location = New System.Drawing.Point(12, 247)
        Me.lblPooraProtseduuriga.Name = "lblPooraProtseduuriga"
        Me.lblPooraProtseduuriga.Size = New System.Drawing.Size(187, 20)
        Me.lblPooraProtseduuriga.TabIndex = 7
        Me.lblPooraProtseduuriga.Text = "Pööramine protseduuriga"
        '
        'formKasutajaAken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 450)
        Me.Controls.Add(Me.lblPooraProtseduuriga)
        Me.Controls.Add(Me.lblPooraFunktsiooniga)
        Me.Controls.Add(Me.LblSisendTekst)
        Me.Controls.Add(Me.btnPooraProtseduuriga)
        Me.Controls.Add(Me.btnPooraFunktsiooniga)
        Me.Controls.Add(Me.txtValjundTekst2)
        Me.Controls.Add(Me.txtValjundTekst1)
        Me.Controls.Add(Me.txtSisendTekst)
        Me.Name = "formKasutajaAken"
        Me.Text = "Tekstitöötlus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSisendTekst As TextBox
    Friend WithEvents txtValjundTekst1 As TextBox
    Friend WithEvents txtValjundTekst2 As TextBox
    Friend WithEvents btnPooraFunktsiooniga As Button
    Friend WithEvents btnPooraProtseduuriga As Button
    Friend WithEvents LblSisendTekst As Label
    Friend WithEvents lblPooraFunktsiooniga As Label
    Friend WithEvents lblPooraProtseduuriga As Label
End Class
