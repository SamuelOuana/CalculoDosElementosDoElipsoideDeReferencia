<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmElementosDoElipsoide
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
        Me.grpDadosEntrada = New System.Windows.Forms.GroupBox()
        Me.grpHemisferio = New System.Windows.Forms.GroupBox()
        Me.rdLatNorte = New System.Windows.Forms.RadioButton()
        Me.rdLatSul = New System.Windows.Forms.RadioButton()
        Me.lblMetros = New System.Windows.Forms.Label()
        Me.lblLGDS = New System.Windows.Forms.Label()
        Me.lblLGDM = New System.Windows.Forms.Label()
        Me.lblLGDG = New System.Windows.Forms.Label()
        Me.txtLatGeodSeg = New System.Windows.Forms.TextBox()
        Me.txtLatGeodMin = New System.Windows.Forms.TextBox()
        Me.lblLatGeodDecimal = New System.Windows.Forms.Label()
        Me.lblLatGeod = New System.Windows.Forms.Label()
        Me.lblAchatamento = New System.Windows.Forms.Label()
        Me.lblInversoAchatamento = New System.Windows.Forms.Label()
        Me.txtLatGeodDecimal = New System.Windows.Forms.TextBox()
        Me.txtLatGeodGraus = New System.Windows.Forms.TextBox()
        Me.txtAchatamento = New System.Windows.Forms.TextBox()
        Me.txtInversoAchatamento = New System.Windows.Forms.TextBox()
        Me.txtSemiEixoMaior = New System.Windows.Forms.TextBox()
        Me.lblSemiEixoMaior = New System.Windows.Forms.Label()
        Me.grpElementosCalculados = New System.Windows.Forms.GroupBox()
        Me.lblY = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtY = New System.Windows.Forms.TextBox()
        Me.txtDist = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblLatRHem = New System.Windows.Forms.Label()
        Me.lblLatGHem = New System.Windows.Forms.Label()
        Me.lblLatRedDec = New System.Windows.Forms.Label()
        Me.txtLatRedDec = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtLatRedSeg = New System.Windows.Forms.TextBox()
        Me.txtLatRedMin = New System.Windows.Forms.TextBox()
        Me.lblLatRed = New System.Windows.Forms.Label()
        Me.txtLatRedGraus = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtLatGeocSeg = New System.Windows.Forms.TextBox()
        Me.txtLatGeocMin = New System.Windows.Forms.TextBox()
        Me.lblLatGeoc = New System.Windows.Forms.Label()
        Me.txtLatGeocGraus = New System.Windows.Forms.TextBox()
        Me.lblLatGeocDecimal = New System.Windows.Forms.Label()
        Me.txtLatGeocDec = New System.Windows.Forms.TextBox()
        Me.txtSegundaExcentricidade = New System.Windows.Forms.TextBox()
        Me.lblSegundaExcentricidade = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRaioAzimute = New System.Windows.Forms.TextBox()
        Me.txtRaioDoParalelo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRaioCurvPrimVertical = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDm = New System.Windows.Forms.Label()
        Me.txtRaioMedioCurvatura = New System.Windows.Forms.TextBox()
        Me.txtAzimute = New System.Windows.Forms.TextBox()
        Me.txtPeqNormal = New System.Windows.Forms.TextBox()
        Me.txtRaioCurvSecMeridiana = New System.Windows.Forms.TextBox()
        Me.txtPrimeiraExcentricidade = New System.Windows.Forms.TextBox()
        Me.txtSemiEixoMenor = New System.Windows.Forms.TextBox()
        Me.lblR = New System.Windows.Forms.Label()
        Me.lblRaioDoParaleloContemPontoDado = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblRaioMedioCurvatura = New System.Windows.Forms.Label()
        Me.lblRaioCurvaturaSeccaoMeridiana = New System.Windows.Forms.Label()
        Me.lblPequenaNormal = New System.Windows.Forms.Label()
        Me.lblRaioCurvaturaSeccaoPrimeiroVertical = New System.Windows.Forms.Label()
        Me.lblSemiEixoMenor = New System.Windows.Forms.Label()
        Me.lblPrimeiraExcentricidade = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimparDadosEntrada = New System.Windows.Forms.Button()
        Me.btnLimparResultados = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OProgramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OAutorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpDadosEntrada.SuspendLayout()
        Me.grpHemisferio.SuspendLayout()
        Me.grpElementosCalculados.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDadosEntrada
        '
        Me.grpDadosEntrada.Controls.Add(Me.grpHemisferio)
        Me.grpDadosEntrada.Controls.Add(Me.lblMetros)
        Me.grpDadosEntrada.Controls.Add(Me.lblLGDS)
        Me.grpDadosEntrada.Controls.Add(Me.lblLGDM)
        Me.grpDadosEntrada.Controls.Add(Me.lblLGDG)
        Me.grpDadosEntrada.Controls.Add(Me.txtLatGeodSeg)
        Me.grpDadosEntrada.Controls.Add(Me.txtLatGeodMin)
        Me.grpDadosEntrada.Controls.Add(Me.lblLatGeodDecimal)
        Me.grpDadosEntrada.Controls.Add(Me.lblLatGeod)
        Me.grpDadosEntrada.Controls.Add(Me.lblAchatamento)
        Me.grpDadosEntrada.Controls.Add(Me.lblInversoAchatamento)
        Me.grpDadosEntrada.Controls.Add(Me.txtLatGeodDecimal)
        Me.grpDadosEntrada.Controls.Add(Me.txtLatGeodGraus)
        Me.grpDadosEntrada.Controls.Add(Me.txtAchatamento)
        Me.grpDadosEntrada.Controls.Add(Me.txtInversoAchatamento)
        Me.grpDadosEntrada.Controls.Add(Me.txtSemiEixoMaior)
        Me.grpDadosEntrada.Controls.Add(Me.lblSemiEixoMaior)
        Me.grpDadosEntrada.Location = New System.Drawing.Point(12, 21)
        Me.grpDadosEntrada.Name = "grpDadosEntrada"
        Me.grpDadosEntrada.Size = New System.Drawing.Size(481, 176)
        Me.grpDadosEntrada.TabIndex = 0
        Me.grpDadosEntrada.TabStop = False
        Me.grpDadosEntrada.Text = "Dados de entrada:"
        '
        'grpHemisferio
        '
        Me.grpHemisferio.Controls.Add(Me.rdLatNorte)
        Me.grpHemisferio.Controls.Add(Me.rdLatSul)
        Me.grpHemisferio.Location = New System.Drawing.Point(325, 117)
        Me.grpHemisferio.Name = "grpHemisferio"
        Me.grpHemisferio.Size = New System.Drawing.Size(135, 37)
        Me.grpHemisferio.TabIndex = 18
        Me.grpHemisferio.TabStop = False
        Me.grpHemisferio.Text = "Hemisferio:"
        '
        'rdLatNorte
        '
        Me.rdLatNorte.AutoSize = True
        Me.rdLatNorte.Location = New System.Drawing.Point(6, 14)
        Me.rdLatNorte.Name = "rdLatNorte"
        Me.rdLatNorte.Size = New System.Drawing.Size(33, 17)
        Me.rdLatNorte.TabIndex = 1
        Me.rdLatNorte.TabStop = True
        Me.rdLatNorte.Text = "N"
        Me.rdLatNorte.UseVisualStyleBackColor = True
        '
        'rdLatSul
        '
        Me.rdLatSul.AutoSize = True
        Me.rdLatSul.Location = New System.Drawing.Point(93, 14)
        Me.rdLatSul.Name = "rdLatSul"
        Me.rdLatSul.Size = New System.Drawing.Size(32, 17)
        Me.rdLatSul.TabIndex = 0
        Me.rdLatSul.TabStop = True
        Me.rdLatSul.Text = "S"
        Me.rdLatSul.UseVisualStyleBackColor = True
        '
        'lblMetros
        '
        Me.lblMetros.AutoSize = True
        Me.lblMetros.Location = New System.Drawing.Point(304, 34)
        Me.lblMetros.Name = "lblMetros"
        Me.lblMetros.Size = New System.Drawing.Size(38, 13)
        Me.lblMetros.TabIndex = 17
        Me.lblMetros.Text = "metros"
        '
        'lblLGDS
        '
        Me.lblLGDS.AutoSize = True
        Me.lblLGDS.Location = New System.Drawing.Point(300, 122)
        Me.lblLGDS.Name = "lblLGDS"
        Me.lblLGDS.Size = New System.Drawing.Size(12, 13)
        Me.lblLGDS.TabIndex = 16
        Me.lblLGDS.Text = """"
        '
        'lblLGDM
        '
        Me.lblLGDM.AutoSize = True
        Me.lblLGDM.Location = New System.Drawing.Point(255, 120)
        Me.lblLGDM.Name = "lblLGDM"
        Me.lblLGDM.Size = New System.Drawing.Size(9, 13)
        Me.lblLGDM.TabIndex = 15
        Me.lblLGDM.Text = "'"
        '
        'lblLGDG
        '
        Me.lblLGDG.AutoSize = True
        Me.lblLGDG.Location = New System.Drawing.Point(202, 120)
        Me.lblLGDG.Name = "lblLGDG"
        Me.lblLGDG.Size = New System.Drawing.Size(13, 13)
        Me.lblLGDG.TabIndex = 14
        Me.lblLGDG.Text = "o"
        '
        'txtLatGeodSeg
        '
        Me.txtLatGeodSeg.Location = New System.Drawing.Point(264, 123)
        Me.txtLatGeodSeg.Name = "txtLatGeodSeg"
        Me.txtLatGeodSeg.Size = New System.Drawing.Size(36, 20)
        Me.txtLatGeodSeg.TabIndex = 13
        Me.txtLatGeodSeg.Text = " "
        '
        'txtLatGeodMin
        '
        Me.txtLatGeodMin.Location = New System.Drawing.Point(215, 123)
        Me.txtLatGeodMin.Name = "txtLatGeodMin"
        Me.txtLatGeodMin.Size = New System.Drawing.Size(36, 20)
        Me.txtLatGeodMin.TabIndex = 12
        Me.txtLatGeodMin.Text = " "
        '
        'lblLatGeodDecimal
        '
        Me.lblLatGeodDecimal.AutoSize = True
        Me.lblLatGeodDecimal.Location = New System.Drawing.Point(21, 150)
        Me.lblLatGeodDecimal.Name = "lblLatGeodDecimal"
        Me.lblLatGeodDecimal.Size = New System.Drawing.Size(139, 13)
        Me.lblLatGeodDecimal.TabIndex = 11
        Me.lblLatGeodDecimal.Text = "Latitude geodésica decimal:"
        '
        'lblLatGeod
        '
        Me.lblLatGeod.AutoSize = True
        Me.lblLatGeod.Location = New System.Drawing.Point(60, 124)
        Me.lblLatGeod.Name = "lblLatGeod"
        Me.lblLatGeod.Size = New System.Drawing.Size(100, 13)
        Me.lblLatGeod.TabIndex = 10
        Me.lblLatGeod.Text = "Latitude geodésica:"
        '
        'lblAchatamento
        '
        Me.lblAchatamento.AutoSize = True
        Me.lblAchatamento.Location = New System.Drawing.Point(75, 85)
        Me.lblAchatamento.Name = "lblAchatamento"
        Me.lblAchatamento.Size = New System.Drawing.Size(85, 13)
        Me.lblAchatamento.TabIndex = 9
        Me.lblAchatamento.Text = "Achatamento (f):"
        '
        'lblInversoAchatamento
        '
        Me.lblInversoAchatamento.AutoSize = True
        Me.lblInversoAchatamento.Location = New System.Drawing.Point(6, 59)
        Me.lblInversoAchatamento.Name = "lblInversoAchatamento"
        Me.lblInversoAchatamento.Size = New System.Drawing.Size(154, 13)
        Me.lblInversoAchatamento.TabIndex = 8
        Me.lblInversoAchatamento.Text = "Inverso do achatamento (1 / f):"
        '
        'txtLatGeodDecimal
        '
        Me.txtLatGeodDecimal.Location = New System.Drawing.Point(166, 150)
        Me.txtLatGeodDecimal.Name = "txtLatGeodDecimal"
        Me.txtLatGeodDecimal.ReadOnly = True
        Me.txtLatGeodDecimal.Size = New System.Drawing.Size(136, 20)
        Me.txtLatGeodDecimal.TabIndex = 7
        '
        'txtLatGeodGraus
        '
        Me.txtLatGeodGraus.Location = New System.Drawing.Point(166, 122)
        Me.txtLatGeodGraus.Name = "txtLatGeodGraus"
        Me.txtLatGeodGraus.Size = New System.Drawing.Size(36, 20)
        Me.txtLatGeodGraus.TabIndex = 6
        Me.txtLatGeodGraus.Text = " "
        '
        'txtAchatamento
        '
        Me.txtAchatamento.Location = New System.Drawing.Point(166, 85)
        Me.txtAchatamento.Name = "txtAchatamento"
        Me.txtAchatamento.ReadOnly = True
        Me.txtAchatamento.Size = New System.Drawing.Size(136, 20)
        Me.txtAchatamento.TabIndex = 4
        '
        'txtInversoAchatamento
        '
        Me.txtInversoAchatamento.Location = New System.Drawing.Point(166, 59)
        Me.txtInversoAchatamento.Name = "txtInversoAchatamento"
        Me.txtInversoAchatamento.Size = New System.Drawing.Size(136, 20)
        Me.txtInversoAchatamento.TabIndex = 2
        '
        'txtSemiEixoMaior
        '
        Me.txtSemiEixoMaior.Location = New System.Drawing.Point(166, 31)
        Me.txtSemiEixoMaior.Name = "txtSemiEixoMaior"
        Me.txtSemiEixoMaior.Size = New System.Drawing.Size(136, 20)
        Me.txtSemiEixoMaior.TabIndex = 1
        '
        'lblSemiEixoMaior
        '
        Me.lblSemiEixoMaior.AutoSize = True
        Me.lblSemiEixoMaior.Location = New System.Drawing.Point(62, 34)
        Me.lblSemiEixoMaior.Name = "lblSemiEixoMaior"
        Me.lblSemiEixoMaior.Size = New System.Drawing.Size(98, 13)
        Me.lblSemiEixoMaior.TabIndex = 0
        Me.lblSemiEixoMaior.Text = "Semi-eixo maior (a):"
        '
        'grpElementosCalculados
        '
        Me.grpElementosCalculados.Controls.Add(Me.lblY)
        Me.grpElementosCalculados.Controls.Add(Me.lblX)
        Me.grpElementosCalculados.Controls.Add(Me.Label23)
        Me.grpElementosCalculados.Controls.Add(Me.Label24)
        Me.grpElementosCalculados.Controls.Add(Me.txtX)
        Me.grpElementosCalculados.Controls.Add(Me.Label20)
        Me.grpElementosCalculados.Controls.Add(Me.Label21)
        Me.grpElementosCalculados.Controls.Add(Me.Label22)
        Me.grpElementosCalculados.Controls.Add(Me.txtY)
        Me.grpElementosCalculados.Controls.Add(Me.txtDist)
        Me.grpElementosCalculados.Controls.Add(Me.Label19)
        Me.grpElementosCalculados.Controls.Add(Me.lblLatRHem)
        Me.grpElementosCalculados.Controls.Add(Me.lblLatGHem)
        Me.grpElementosCalculados.Controls.Add(Me.lblLatRedDec)
        Me.grpElementosCalculados.Controls.Add(Me.txtLatRedDec)
        Me.grpElementosCalculados.Controls.Add(Me.Label14)
        Me.grpElementosCalculados.Controls.Add(Me.Label15)
        Me.grpElementosCalculados.Controls.Add(Me.Label16)
        Me.grpElementosCalculados.Controls.Add(Me.txtLatRedSeg)
        Me.grpElementosCalculados.Controls.Add(Me.txtLatRedMin)
        Me.grpElementosCalculados.Controls.Add(Me.lblLatRed)
        Me.grpElementosCalculados.Controls.Add(Me.txtLatRedGraus)
        Me.grpElementosCalculados.Controls.Add(Me.Label5)
        Me.grpElementosCalculados.Controls.Add(Me.Label11)
        Me.grpElementosCalculados.Controls.Add(Me.Label12)
        Me.grpElementosCalculados.Controls.Add(Me.txtLatGeocSeg)
        Me.grpElementosCalculados.Controls.Add(Me.txtLatGeocMin)
        Me.grpElementosCalculados.Controls.Add(Me.lblLatGeoc)
        Me.grpElementosCalculados.Controls.Add(Me.txtLatGeocGraus)
        Me.grpElementosCalculados.Controls.Add(Me.lblLatGeocDecimal)
        Me.grpElementosCalculados.Controls.Add(Me.txtLatGeocDec)
        Me.grpElementosCalculados.Controls.Add(Me.txtSegundaExcentricidade)
        Me.grpElementosCalculados.Controls.Add(Me.lblSegundaExcentricidade)
        Me.grpElementosCalculados.Controls.Add(Me.Label1)
        Me.grpElementosCalculados.Controls.Add(Me.Label9)
        Me.grpElementosCalculados.Controls.Add(Me.Label10)
        Me.grpElementosCalculados.Controls.Add(Me.txtRaioAzimute)
        Me.grpElementosCalculados.Controls.Add(Me.txtRaioDoParalelo)
        Me.grpElementosCalculados.Controls.Add(Me.Label8)
        Me.grpElementosCalculados.Controls.Add(Me.txtRaioCurvPrimVertical)
        Me.grpElementosCalculados.Controls.Add(Me.Label6)
        Me.grpElementosCalculados.Controls.Add(Me.Label7)
        Me.grpElementosCalculados.Controls.Add(Me.Label2)
        Me.grpElementosCalculados.Controls.Add(Me.Label3)
        Me.grpElementosCalculados.Controls.Add(Me.lblDm)
        Me.grpElementosCalculados.Controls.Add(Me.txtRaioMedioCurvatura)
        Me.grpElementosCalculados.Controls.Add(Me.txtAzimute)
        Me.grpElementosCalculados.Controls.Add(Me.txtPeqNormal)
        Me.grpElementosCalculados.Controls.Add(Me.txtRaioCurvSecMeridiana)
        Me.grpElementosCalculados.Controls.Add(Me.txtPrimeiraExcentricidade)
        Me.grpElementosCalculados.Controls.Add(Me.txtSemiEixoMenor)
        Me.grpElementosCalculados.Controls.Add(Me.lblR)
        Me.grpElementosCalculados.Controls.Add(Me.lblRaioDoParaleloContemPontoDado)
        Me.grpElementosCalculados.Controls.Add(Me.Label4)
        Me.grpElementosCalculados.Controls.Add(Me.lblRaioMedioCurvatura)
        Me.grpElementosCalculados.Controls.Add(Me.lblRaioCurvaturaSeccaoMeridiana)
        Me.grpElementosCalculados.Controls.Add(Me.lblPequenaNormal)
        Me.grpElementosCalculados.Controls.Add(Me.lblRaioCurvaturaSeccaoPrimeiroVertical)
        Me.grpElementosCalculados.Controls.Add(Me.lblSemiEixoMenor)
        Me.grpElementosCalculados.Controls.Add(Me.lblPrimeiraExcentricidade)
        Me.grpElementosCalculados.Location = New System.Drawing.Point(12, 214)
        Me.grpElementosCalculados.Name = "grpElementosCalculados"
        Me.grpElementosCalculados.Size = New System.Drawing.Size(771, 288)
        Me.grpElementosCalculados.TabIndex = 1
        Me.grpElementosCalculados.TabStop = False
        Me.grpElementosCalculados.Text = "Elementos calculados:"
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.Location = New System.Drawing.Point(592, 228)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(20, 13)
        Me.lblY.TabIndex = 71
        Me.lblY.Text = "Y="
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(592, 202)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(20, 13)
        Me.lblX.TabIndex = 70
        Me.lblX.Text = "X="
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(752, 199)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(15, 13)
        Me.Label23.TabIndex = 69
        Me.Label23.Text = "m"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(752, 202)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(0, 13)
        Me.Label24.TabIndex = 68
        '
        'txtX
        '
        Me.txtX.Location = New System.Drawing.Point(613, 199)
        Me.txtX.Name = "txtX"
        Me.txtX.ReadOnly = True
        Me.txtX.Size = New System.Drawing.Size(136, 20)
        Me.txtX.TabIndex = 67
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(752, 228)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(15, 13)
        Me.Label20.TabIndex = 66
        Me.Label20.Text = "m"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(752, 257)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(15, 13)
        Me.Label21.TabIndex = 65
        Me.Label21.Text = "m"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(752, 231)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(0, 13)
        Me.Label22.TabIndex = 64
        '
        'txtY
        '
        Me.txtY.Location = New System.Drawing.Point(613, 228)
        Me.txtY.Name = "txtY"
        Me.txtY.ReadOnly = True
        Me.txtY.Size = New System.Drawing.Size(136, 20)
        Me.txtY.TabIndex = 63
        '
        'txtDist
        '
        Me.txtDist.Location = New System.Drawing.Point(613, 254)
        Me.txtDist.Name = "txtDist"
        Me.txtDist.ReadOnly = True
        Me.txtDist.Size = New System.Drawing.Size(136, 20)
        Me.txtDist.TabIndex = 62
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(545, 177)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(206, 13)
        Me.Label19.TabIndex = 61
        Me.Label19.Text = "Distância do ponto ao centro do elipsóide:"
        '
        'lblLatRHem
        '
        Me.lblLatRHem.AutoSize = True
        Me.lblLatRHem.Location = New System.Drawing.Point(748, 149)
        Me.lblLatRHem.Name = "lblLatRHem"
        Me.lblLatRHem.Size = New System.Drawing.Size(14, 13)
        Me.lblLatRHem.TabIndex = 60
        Me.lblLatRHem.Text = "S"
        '
        'lblLatGHem
        '
        Me.lblLatGHem.AutoSize = True
        Me.lblLatGHem.Location = New System.Drawing.Point(747, 86)
        Me.lblLatGHem.Name = "lblLatGHem"
        Me.lblLatGHem.Size = New System.Drawing.Size(14, 13)
        Me.lblLatGHem.TabIndex = 58
        Me.lblLatGHem.Text = "S"
        '
        'lblLatRedDec
        '
        Me.lblLatRedDec.AutoSize = True
        Me.lblLatRedDec.Location = New System.Drawing.Point(466, 119)
        Me.lblLatRedDec.Name = "lblLatRedDec"
        Me.lblLatRedDec.Size = New System.Drawing.Size(130, 13)
        Me.lblLatRedDec.TabIndex = 56
        Me.lblLatRedDec.Text = "Latitude reduzida decimal:"
        '
        'txtLatRedDec
        '
        Me.txtLatRedDec.Location = New System.Drawing.Point(603, 116)
        Me.txtLatRedDec.Name = "txtLatRedDec"
        Me.txtLatRedDec.ReadOnly = True
        Me.txtLatRedDec.Size = New System.Drawing.Size(136, 20)
        Me.txtLatRedDec.TabIndex = 55
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(737, 144)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(12, 13)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = """"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(692, 142)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(9, 13)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "'"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(639, 142)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(13, 13)
        Me.Label16.TabIndex = 52
        Me.Label16.Text = "o"
        '
        'txtLatRedSeg
        '
        Me.txtLatRedSeg.Location = New System.Drawing.Point(701, 145)
        Me.txtLatRedSeg.Name = "txtLatRedSeg"
        Me.txtLatRedSeg.ReadOnly = True
        Me.txtLatRedSeg.Size = New System.Drawing.Size(36, 20)
        Me.txtLatRedSeg.TabIndex = 51
        Me.txtLatRedSeg.Text = " "
        '
        'txtLatRedMin
        '
        Me.txtLatRedMin.Location = New System.Drawing.Point(652, 145)
        Me.txtLatRedMin.Name = "txtLatRedMin"
        Me.txtLatRedMin.ReadOnly = True
        Me.txtLatRedMin.Size = New System.Drawing.Size(36, 20)
        Me.txtLatRedMin.TabIndex = 50
        Me.txtLatRedMin.Text = " "
        '
        'lblLatRed
        '
        Me.lblLatRed.AutoSize = True
        Me.lblLatRed.Location = New System.Drawing.Point(503, 146)
        Me.lblLatRed.Name = "lblLatRed"
        Me.lblLatRed.Size = New System.Drawing.Size(91, 13)
        Me.lblLatRed.TabIndex = 49
        Me.lblLatRed.Text = "Latitude reduzida:"
        '
        'txtLatRedGraus
        '
        Me.txtLatRedGraus.Location = New System.Drawing.Point(603, 144)
        Me.txtLatRedGraus.Name = "txtLatRedGraus"
        Me.txtLatRedGraus.ReadOnly = True
        Me.txtLatRedGraus.Size = New System.Drawing.Size(36, 20)
        Me.txtLatRedGraus.TabIndex = 48
        Me.txtLatRedGraus.Text = " "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(737, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = """"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(692, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(9, 13)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "'"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(639, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 13)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "o"
        '
        'txtLatGeocSeg
        '
        Me.txtLatGeocSeg.Location = New System.Drawing.Point(701, 85)
        Me.txtLatGeocSeg.Name = "txtLatGeocSeg"
        Me.txtLatGeocSeg.ReadOnly = True
        Me.txtLatGeocSeg.Size = New System.Drawing.Size(36, 20)
        Me.txtLatGeocSeg.TabIndex = 44
        Me.txtLatGeocSeg.Text = " "
        '
        'txtLatGeocMin
        '
        Me.txtLatGeocMin.Location = New System.Drawing.Point(652, 85)
        Me.txtLatGeocMin.Name = "txtLatGeocMin"
        Me.txtLatGeocMin.ReadOnly = True
        Me.txtLatGeocMin.Size = New System.Drawing.Size(36, 20)
        Me.txtLatGeocMin.TabIndex = 43
        Me.txtLatGeocMin.Text = " "
        '
        'lblLatGeoc
        '
        Me.lblLatGeoc.AutoSize = True
        Me.lblLatGeoc.Location = New System.Drawing.Point(489, 86)
        Me.lblLatGeoc.Name = "lblLatGeoc"
        Me.lblLatGeoc.Size = New System.Drawing.Size(107, 13)
        Me.lblLatGeoc.TabIndex = 42
        Me.lblLatGeoc.Text = "Latitude geocêntrica:"
        '
        'txtLatGeocGraus
        '
        Me.txtLatGeocGraus.Location = New System.Drawing.Point(603, 84)
        Me.txtLatGeocGraus.Name = "txtLatGeocGraus"
        Me.txtLatGeocGraus.ReadOnly = True
        Me.txtLatGeocGraus.Size = New System.Drawing.Size(36, 20)
        Me.txtLatGeocGraus.TabIndex = 41
        Me.txtLatGeocGraus.Text = " "
        '
        'lblLatGeocDecimal
        '
        Me.lblLatGeocDecimal.AutoSize = True
        Me.lblLatGeocDecimal.Location = New System.Drawing.Point(451, 54)
        Me.lblLatGeocDecimal.Name = "lblLatGeocDecimal"
        Me.lblLatGeocDecimal.Size = New System.Drawing.Size(146, 13)
        Me.lblLatGeocDecimal.TabIndex = 40
        Me.lblLatGeocDecimal.Text = "Latitude geocêntrica decimal:"
        '
        'txtLatGeocDec
        '
        Me.txtLatGeocDec.Location = New System.Drawing.Point(603, 51)
        Me.txtLatGeocDec.Name = "txtLatGeocDec"
        Me.txtLatGeocDec.ReadOnly = True
        Me.txtLatGeocDec.Size = New System.Drawing.Size(136, 20)
        Me.txtLatGeocDec.TabIndex = 39
        '
        'txtSegundaExcentricidade
        '
        Me.txtSegundaExcentricidade.Location = New System.Drawing.Point(603, 25)
        Me.txtSegundaExcentricidade.Name = "txtSegundaExcentricidade"
        Me.txtSegundaExcentricidade.ReadOnly = True
        Me.txtSegundaExcentricidade.Size = New System.Drawing.Size(136, 20)
        Me.txtSegundaExcentricidade.TabIndex = 38
        '
        'lblSegundaExcentricidade
        '
        Me.lblSegundaExcentricidade.AutoSize = True
        Me.lblSegundaExcentricidade.Location = New System.Drawing.Point(409, 28)
        Me.lblSegundaExcentricidade.Name = "lblSegundaExcentricidade"
        Me.lblSegundaExcentricidade.Size = New System.Drawing.Size(188, 13)
        Me.lblSegundaExcentricidade.TabIndex = 37
        Me.lblSegundaExcentricidade.Text = "Segunda excentricidade ao quadrado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(396, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "m"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(396, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "m"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(396, 234)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 34
        '
        'txtRaioAzimute
        '
        Me.txtRaioAzimute.Location = New System.Drawing.Point(257, 231)
        Me.txtRaioAzimute.Name = "txtRaioAzimute"
        Me.txtRaioAzimute.ReadOnly = True
        Me.txtRaioAzimute.Size = New System.Drawing.Size(136, 20)
        Me.txtRaioAzimute.TabIndex = 33
        '
        'txtRaioDoParalelo
        '
        Me.txtRaioDoParalelo.Location = New System.Drawing.Point(257, 257)
        Me.txtRaioDoParalelo.Name = "txtRaioDoParalelo"
        Me.txtRaioDoParalelo.ReadOnly = True
        Me.txtRaioDoParalelo.Size = New System.Drawing.Size(136, 20)
        Me.txtRaioDoParalelo.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(396, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "m"
        '
        'txtRaioCurvPrimVertical
        '
        Me.txtRaioCurvPrimVertical.Location = New System.Drawing.Point(257, 87)
        Me.txtRaioCurvPrimVertical.Name = "txtRaioCurvPrimVertical"
        Me.txtRaioCurvPrimVertical.ReadOnly = True
        Me.txtRaioCurvPrimVertical.Size = New System.Drawing.Size(136, 20)
        Me.txtRaioCurvPrimVertical.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(296, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "o"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(396, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "m"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(396, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "m"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(396, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "m"
        '
        'lblDm
        '
        Me.lblDm.AutoSize = True
        Me.lblDm.Location = New System.Drawing.Point(396, 57)
        Me.lblDm.Name = "lblDm"
        Me.lblDm.Size = New System.Drawing.Size(15, 13)
        Me.lblDm.TabIndex = 25
        Me.lblDm.Text = "m"
        '
        'txtRaioMedioCurvatura
        '
        Me.txtRaioMedioCurvatura.Location = New System.Drawing.Point(257, 173)
        Me.txtRaioMedioCurvatura.Name = "txtRaioMedioCurvatura"
        Me.txtRaioMedioCurvatura.ReadOnly = True
        Me.txtRaioMedioCurvatura.Size = New System.Drawing.Size(136, 20)
        Me.txtRaioMedioCurvatura.TabIndex = 23
        '
        'txtAzimute
        '
        Me.txtAzimute.Location = New System.Drawing.Point(257, 199)
        Me.txtAzimute.Name = "txtAzimute"
        Me.txtAzimute.Size = New System.Drawing.Size(38, 20)
        Me.txtAzimute.TabIndex = 22
        '
        'txtPeqNormal
        '
        Me.txtPeqNormal.Location = New System.Drawing.Point(257, 116)
        Me.txtPeqNormal.Name = "txtPeqNormal"
        Me.txtPeqNormal.ReadOnly = True
        Me.txtPeqNormal.Size = New System.Drawing.Size(136, 20)
        Me.txtPeqNormal.TabIndex = 21
        '
        'txtRaioCurvSecMeridiana
        '
        Me.txtRaioCurvSecMeridiana.Location = New System.Drawing.Point(257, 142)
        Me.txtRaioCurvSecMeridiana.Name = "txtRaioCurvSecMeridiana"
        Me.txtRaioCurvSecMeridiana.ReadOnly = True
        Me.txtRaioCurvSecMeridiana.Size = New System.Drawing.Size(136, 20)
        Me.txtRaioCurvSecMeridiana.TabIndex = 20
        '
        'txtPrimeiraExcentricidade
        '
        Me.txtPrimeiraExcentricidade.Location = New System.Drawing.Point(257, 28)
        Me.txtPrimeiraExcentricidade.Name = "txtPrimeiraExcentricidade"
        Me.txtPrimeiraExcentricidade.ReadOnly = True
        Me.txtPrimeiraExcentricidade.Size = New System.Drawing.Size(136, 20)
        Me.txtPrimeiraExcentricidade.TabIndex = 19
        '
        'txtSemiEixoMenor
        '
        Me.txtSemiEixoMenor.Location = New System.Drawing.Point(257, 54)
        Me.txtSemiEixoMenor.Name = "txtSemiEixoMenor"
        Me.txtSemiEixoMenor.ReadOnly = True
        Me.txtSemiEixoMenor.Size = New System.Drawing.Size(136, 20)
        Me.txtSemiEixoMenor.TabIndex = 18
        '
        'lblR
        '
        Me.lblR.AutoSize = True
        Me.lblR.Location = New System.Drawing.Point(239, 231)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(18, 13)
        Me.lblR.TabIndex = 17
        Me.lblR.Text = "R:"
        '
        'lblRaioDoParaleloContemPontoDado
        '
        Me.lblRaioDoParaleloContemPontoDado.AutoSize = True
        Me.lblRaioDoParaleloContemPontoDado.Location = New System.Drawing.Point(45, 260)
        Me.lblRaioDoParaleloContemPontoDado.Name = "lblRaioDoParaleloContemPontoDado"
        Me.lblRaioDoParaleloContemPontoDado.Size = New System.Drawing.Size(212, 13)
        Me.lblRaioDoParaleloContemPontoDado.TabIndex = 16
        Me.lblRaioDoParaleloContemPontoDado.Text = "Raio do paralelo que contém o ponto dado:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(246, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Raio de curvatura duma secção cujo azimute é A="
        '
        'lblRaioMedioCurvatura
        '
        Me.lblRaioMedioCurvatura.AutoSize = True
        Me.lblRaioMedioCurvatura.Location = New System.Drawing.Point(106, 176)
        Me.lblRaioMedioCurvatura.Name = "lblRaioMedioCurvatura"
        Me.lblRaioMedioCurvatura.Size = New System.Drawing.Size(151, 13)
        Me.lblRaioMedioCurvatura.TabIndex = 14
        Me.lblRaioMedioCurvatura.Text = "Raio médio de curvatura (Rm):"
        '
        'lblRaioCurvaturaSeccaoMeridiana
        '
        Me.lblRaioCurvaturaSeccaoMeridiana.AutoSize = True
        Me.lblRaioCurvaturaSeccaoMeridiana.Location = New System.Drawing.Point(43, 147)
        Me.lblRaioCurvaturaSeccaoMeridiana.Name = "lblRaioCurvaturaSeccaoMeridiana"
        Me.lblRaioCurvaturaSeccaoMeridiana.Size = New System.Drawing.Size(214, 13)
        Me.lblRaioCurvaturaSeccaoMeridiana.TabIndex = 13
        Me.lblRaioCurvaturaSeccaoMeridiana.Text = "Raio de curvatura da secção meridiana (M):"
        '
        'lblPequenaNormal
        '
        Me.lblPequenaNormal.AutoSize = True
        Me.lblPequenaNormal.Location = New System.Drawing.Point(151, 119)
        Me.lblPequenaNormal.Name = "lblPequenaNormal"
        Me.lblPequenaNormal.Size = New System.Drawing.Size(106, 13)
        Me.lblPequenaNormal.TabIndex = 12
        Me.lblPequenaNormal.Text = "Pequena normal (N'):"
        '
        'lblRaioCurvaturaSeccaoPrimeiroVertical
        '
        Me.lblRaioCurvaturaSeccaoPrimeiroVertical.AutoSize = True
        Me.lblRaioCurvaturaSeccaoPrimeiroVertical.Location = New System.Drawing.Point(16, 90)
        Me.lblRaioCurvaturaSeccaoPrimeiroVertical.Name = "lblRaioCurvaturaSeccaoPrimeiroVertical"
        Me.lblRaioCurvaturaSeccaoPrimeiroVertical.Size = New System.Drawing.Size(241, 13)
        Me.lblRaioCurvaturaSeccaoPrimeiroVertical.TabIndex = 11
        Me.lblRaioCurvaturaSeccaoPrimeiroVertical.Text = "Raio de curvatura da secção primeiro vertical (N):"
        '
        'lblSemiEixoMenor
        '
        Me.lblSemiEixoMenor.AutoSize = True
        Me.lblSemiEixoMenor.Location = New System.Drawing.Point(155, 57)
        Me.lblSemiEixoMenor.Name = "lblSemiEixoMenor"
        Me.lblSemiEixoMenor.Size = New System.Drawing.Size(102, 13)
        Me.lblSemiEixoMenor.TabIndex = 10
        Me.lblSemiEixoMenor.Text = "Semi-eixo menor (b):"
        '
        'lblPrimeiraExcentricidade
        '
        Me.lblPrimeiraExcentricidade.AutoSize = True
        Me.lblPrimeiraExcentricidade.Location = New System.Drawing.Point(75, 31)
        Me.lblPrimeiraExcentricidade.Name = "lblPrimeiraExcentricidade"
        Me.lblPrimeiraExcentricidade.Size = New System.Drawing.Size(182, 13)
        Me.lblPrimeiraExcentricidade.TabIndex = 9
        Me.lblPrimeiraExcentricidade.Text = "Primeira excentricidade ao quadrado:"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(522, 25)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(112, 34)
        Me.btnCalcular.TabIndex = 2
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimparDadosEntrada
        '
        Me.btnLimparDadosEntrada.Location = New System.Drawing.Point(592, 98)
        Me.btnLimparDadosEntrada.Name = "btnLimparDadosEntrada"
        Me.btnLimparDadosEntrada.Size = New System.Drawing.Size(112, 34)
        Me.btnLimparDadosEntrada.TabIndex = 3
        Me.btnLimparDadosEntrada.Text = "Limpar Dados de Entrada"
        Me.btnLimparDadosEntrada.UseVisualStyleBackColor = True
        '
        'btnLimparResultados
        '
        Me.btnLimparResultados.Location = New System.Drawing.Point(671, 163)
        Me.btnLimparResultados.Name = "btnLimparResultados"
        Me.btnLimparResultados.Size = New System.Drawing.Size(112, 34)
        Me.btnLimparResultados.TabIndex = 4
        Me.btnLimparResultados.Text = "Limpar Resultados"
        Me.btnLimparResultados.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem, Me.SobreToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(795, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OProgramaToolStripMenuItem, Me.OAutorToolStripMenuItem})
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SobreToolStripMenuItem.Text = "Sobre"
        '
        'OProgramaToolStripMenuItem
        '
        Me.OProgramaToolStripMenuItem.Name = "OProgramaToolStripMenuItem"
        Me.OProgramaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OProgramaToolStripMenuItem.Text = "O Programa"
        '
        'OAutorToolStripMenuItem
        '
        Me.OAutorToolStripMenuItem.Name = "OAutorToolStripMenuItem"
        Me.OAutorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OAutorToolStripMenuItem.Text = "O Autor"
        '
        'frmElementosDoElipsoide
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 514)
        Me.Controls.Add(Me.btnLimparResultados)
        Me.Controls.Add(Me.btnLimparDadosEntrada)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.grpElementosCalculados)
        Me.Controls.Add(Me.grpDadosEntrada)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmElementosDoElipsoide"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elementos do elipsóide de referência"
        Me.grpDadosEntrada.ResumeLayout(False)
        Me.grpDadosEntrada.PerformLayout()
        Me.grpHemisferio.ResumeLayout(False)
        Me.grpHemisferio.PerformLayout()
        Me.grpElementosCalculados.ResumeLayout(False)
        Me.grpElementosCalculados.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpDadosEntrada As System.Windows.Forms.GroupBox
    Friend WithEvents lblLGDG As System.Windows.Forms.Label
    Friend WithEvents txtLatGeodSeg As System.Windows.Forms.TextBox
    Friend WithEvents txtLatGeodMin As System.Windows.Forms.TextBox
    Friend WithEvents lblLatGeodDecimal As System.Windows.Forms.Label
    Friend WithEvents lblLatGeod As System.Windows.Forms.Label
    Friend WithEvents lblAchatamento As System.Windows.Forms.Label
    Friend WithEvents lblInversoAchatamento As System.Windows.Forms.Label
    Friend WithEvents txtLatGeodDecimal As System.Windows.Forms.TextBox
    Friend WithEvents txtLatGeodGraus As System.Windows.Forms.TextBox
    Friend WithEvents txtAchatamento As System.Windows.Forms.TextBox
    Friend WithEvents txtInversoAchatamento As System.Windows.Forms.TextBox
    Friend WithEvents txtSemiEixoMaior As System.Windows.Forms.TextBox
    Friend WithEvents lblSemiEixoMaior As System.Windows.Forms.Label
    Friend WithEvents grpElementosCalculados As System.Windows.Forms.GroupBox
    Friend WithEvents lblLGDS As System.Windows.Forms.Label
    Friend WithEvents lblLGDM As System.Windows.Forms.Label
    Friend WithEvents grpHemisferio As System.Windows.Forms.GroupBox
    Friend WithEvents rdLatNorte As System.Windows.Forms.RadioButton
    Friend WithEvents rdLatSul As System.Windows.Forms.RadioButton
    Friend WithEvents lblMetros As System.Windows.Forms.Label
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents btnLimparDadosEntrada As System.Windows.Forms.Button
    Friend WithEvents btnLimparResultados As System.Windows.Forms.Button
    Friend WithEvents lblRaioDoParaleloContemPontoDado As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblRaioMedioCurvatura As System.Windows.Forms.Label
    Friend WithEvents lblRaioCurvaturaSeccaoMeridiana As System.Windows.Forms.Label
    Friend WithEvents lblPequenaNormal As System.Windows.Forms.Label
    Friend WithEvents lblRaioCurvaturaSeccaoPrimeiroVertical As System.Windows.Forms.Label
    Friend WithEvents lblSemiEixoMenor As System.Windows.Forms.Label
    Friend WithEvents lblPrimeiraExcentricidade As System.Windows.Forms.Label
    Friend WithEvents lblR As System.Windows.Forms.Label
    Friend WithEvents txtSemiEixoMenor As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblDm As System.Windows.Forms.Label
    Friend WithEvents txtRaioMedioCurvatura As System.Windows.Forms.TextBox
    Friend WithEvents txtAzimute As System.Windows.Forms.TextBox
    Friend WithEvents txtPeqNormal As System.Windows.Forms.TextBox
    Friend WithEvents txtRaioCurvSecMeridiana As System.Windows.Forms.TextBox
    Friend WithEvents txtPrimeiraExcentricidade As System.Windows.Forms.TextBox
    Friend WithEvents txtRaioCurvPrimVertical As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtRaioAzimute As System.Windows.Forms.TextBox
    Friend WithEvents txtRaioDoParalelo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLatGeocDecimal As System.Windows.Forms.Label
    Friend WithEvents txtLatGeocDec As System.Windows.Forms.TextBox
    Friend WithEvents txtSegundaExcentricidade As System.Windows.Forms.TextBox
    Friend WithEvents lblSegundaExcentricidade As System.Windows.Forms.Label
    Friend WithEvents lblLatRedDec As System.Windows.Forms.Label
    Friend WithEvents txtLatRedDec As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtLatRedSeg As System.Windows.Forms.TextBox
    Friend WithEvents txtLatRedMin As System.Windows.Forms.TextBox
    Friend WithEvents lblLatRed As System.Windows.Forms.Label
    Friend WithEvents txtLatRedGraus As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtLatGeocSeg As System.Windows.Forms.TextBox
    Friend WithEvents txtLatGeocMin As System.Windows.Forms.TextBox
    Friend WithEvents lblLatGeoc As System.Windows.Forms.Label
    Friend WithEvents txtLatGeocGraus As System.Windows.Forms.TextBox
    Friend WithEvents lblLatRHem As System.Windows.Forms.Label
    Friend WithEvents lblLatGHem As System.Windows.Forms.Label
    Friend WithEvents lblY As System.Windows.Forms.Label
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtX As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtY As System.Windows.Forms.TextBox
    Friend WithEvents txtDist As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OProgramaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OAutorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
