﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formKasutajaAken
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
        Me.components = New System.ComponentModel.Container()
        Me.txtSisendTekst = New System.Windows.Forms.TextBox()
        Me.txtValjundTekst1 = New System.Windows.Forms.TextBox()
        Me.txtValjundTekst2 = New System.Windows.Forms.TextBox()
        Me.btnPooraFunktsiooniga = New System.Windows.Forms.Button()
        Me.btnPooraProtseduuriga = New System.Windows.Forms.Button()
        Me.LblSisendTekst = New System.Windows.Forms.Label()
        Me.lblPooraFunktsiooniga = New System.Windows.Forms.Label()
        Me.lblPooraProtseduuriga = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStopp = New System.Windows.Forms.Button()
        Me.timerUuenda = New System.Windows.Forms.Timer(Me.components)
        Me.lblTextInfo = New System.Windows.Forms.Label()
        Me.btnAlgoritmilinePooramine = New System.Windows.Forms.Button()
        Me.btnAlgoritmOff = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSisendTekst
        '
        Me.txtSisendTekst.Location = New System.Drawing.Point(152, 38)
        Me.txtSisendTekst.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSisendTekst.Name = "txtSisendTekst"
        Me.txtSisendTekst.Size = New System.Drawing.Size(413, 20)
        Me.txtSisendTekst.TabIndex = 0
        '
        'txtValjundTekst1
        '
        Me.txtValjundTekst1.Location = New System.Drawing.Point(152, 85)
        Me.txtValjundTekst1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValjundTekst1.Name = "txtValjundTekst1"
        Me.txtValjundTekst1.Size = New System.Drawing.Size(413, 20)
        Me.txtValjundTekst1.TabIndex = 1
        '
        'txtValjundTekst2
        '
        Me.txtValjundTekst2.Location = New System.Drawing.Point(152, 157)
        Me.txtValjundTekst2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValjundTekst2.Name = "txtValjundTekst2"
        Me.txtValjundTekst2.Size = New System.Drawing.Size(413, 20)
        Me.txtValjundTekst2.TabIndex = 2
        '
        'btnPooraFunktsiooniga
        '
        Me.btnPooraFunktsiooniga.Location = New System.Drawing.Point(152, 112)
        Me.btnPooraFunktsiooniga.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPooraFunktsiooniga.Name = "btnPooraFunktsiooniga"
        Me.btnPooraFunktsiooniga.Size = New System.Drawing.Size(132, 24)
        Me.btnPooraFunktsiooniga.TabIndex = 3
        Me.btnPooraFunktsiooniga.Text = "Pööra funktsiooniga"
        Me.btnPooraFunktsiooniga.UseVisualStyleBackColor = True
        '
        'btnPooraProtseduuriga
        '
        Me.btnPooraProtseduuriga.Location = New System.Drawing.Point(152, 194)
        Me.btnPooraProtseduuriga.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPooraProtseduuriga.Name = "btnPooraProtseduuriga"
        Me.btnPooraProtseduuriga.Size = New System.Drawing.Size(132, 24)
        Me.btnPooraProtseduuriga.TabIndex = 4
        Me.btnPooraProtseduuriga.Text = "Pööra protseduuriga"
        Me.btnPooraProtseduuriga.UseVisualStyleBackColor = True
        '
        'LblSisendTekst
        '
        Me.LblSisendTekst.AutoSize = True
        Me.LblSisendTekst.Location = New System.Drawing.Point(9, 42)
        Me.LblSisendTekst.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSisendTekst.Name = "LblSisendTekst"
        Me.LblSisendTekst.Size = New System.Drawing.Size(66, 13)
        Me.LblSisendTekst.TabIndex = 5
        Me.LblSisendTekst.Text = "SisendTekst"
        '
        'lblPooraFunktsiooniga
        '
        Me.lblPooraFunktsiooniga.AutoSize = True
        Me.lblPooraFunktsiooniga.Location = New System.Drawing.Point(9, 89)
        Me.lblPooraFunktsiooniga.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPooraFunktsiooniga.Name = "lblPooraFunktsiooniga"
        Me.lblPooraFunktsiooniga.Size = New System.Drawing.Size(101, 13)
        Me.lblPooraFunktsiooniga.TabIndex = 6
        Me.lblPooraFunktsiooniga.Text = "Pööra funktsiooniga"
        '
        'lblPooraProtseduuriga
        '
        Me.lblPooraProtseduuriga.AutoSize = True
        Me.lblPooraProtseduuriga.Location = New System.Drawing.Point(8, 161)
        Me.lblPooraProtseduuriga.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPooraProtseduuriga.Name = "lblPooraProtseduuriga"
        Me.lblPooraProtseduuriga.Size = New System.Drawing.Size(124, 13)
        Me.lblPooraProtseduuriga.TabIndex = 7
        Me.lblPooraProtseduuriga.Text = "Pööramine protseduuriga"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(51, 225)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(50, 27)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStopp
        '
        Me.btnStopp.Location = New System.Drawing.Point(51, 276)
        Me.btnStopp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStopp.Name = "btnStopp"
        Me.btnStopp.Size = New System.Drawing.Size(50, 27)
        Me.btnStopp.TabIndex = 9
        Me.btnStopp.Text = "Stop"
        Me.btnStopp.UseVisualStyleBackColor = True
        '
        'timerUuenda
        '
        Me.timerUuenda.Interval = 3000
        '
        'lblTextInfo
        '
        Me.lblTextInfo.AutoSize = True
        Me.lblTextInfo.Location = New System.Drawing.Point(593, 47)
        Me.lblTextInfo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTextInfo.Name = "lblTextInfo"
        Me.lblTextInfo.Size = New System.Drawing.Size(29, 13)
        Me.lblTextInfo.TabIndex = 10
        Me.lblTextInfo.Text = "label"
        '
        'btnAlgoritmilinePooramine
        '
        Me.btnAlgoritmilinePooramine.Location = New System.Drawing.Point(406, 256)
        Me.btnAlgoritmilinePooramine.Name = "btnAlgoritmilinePooramine"
        Me.btnAlgoritmilinePooramine.Size = New System.Drawing.Size(142, 24)
        Me.btnAlgoritmilinePooramine.TabIndex = 11
        Me.btnAlgoritmilinePooramine.Text = "Algoritmiline pööramine"
        Me.btnAlgoritmilinePooramine.UseVisualStyleBackColor = True
        '
        'btnAlgoritmOff
        '
        Me.btnAlgoritmOff.Location = New System.Drawing.Point(406, 299)
        Me.btnAlgoritmOff.Name = "btnAlgoritmOff"
        Me.btnAlgoritmOff.Size = New System.Drawing.Size(142, 24)
        Me.btnAlgoritmOff.TabIndex = 12
        Me.btnAlgoritmOff.Text = "Algoritmiline off"
        Me.btnAlgoritmOff.UseVisualStyleBackColor = True
        '
        'formKasutajaAken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 402)
        Me.Controls.Add(Me.btnAlgoritmOff)
        Me.Controls.Add(Me.btnAlgoritmilinePooramine)
        Me.Controls.Add(Me.lblTextInfo)
        Me.Controls.Add(Me.btnStopp)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblPooraProtseduuriga)
        Me.Controls.Add(Me.lblPooraFunktsiooniga)
        Me.Controls.Add(Me.LblSisendTekst)
        Me.Controls.Add(Me.btnPooraProtseduuriga)
        Me.Controls.Add(Me.btnPooraFunktsiooniga)
        Me.Controls.Add(Me.txtValjundTekst2)
        Me.Controls.Add(Me.txtValjundTekst1)
        Me.Controls.Add(Me.txtSisendTekst)
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStopp As Button
    Friend WithEvents timerUuenda As Timer
    Friend WithEvents lblTextInfo As Label
    Friend WithEvents btnAlgoritmilinePooramine As Button
    Friend WithEvents btnAlgoritmOff As Button
End Class
