Public Class frmElementosDoElipsoide
    Dim azimute, raioDoAzimute, raioDoParalelo, latGeodGraus, latGeodMin, latGeodSeg, latGeodDec, semiEixoMaior, semiEixoMenor, achatamento, inversoAchatamento As Double
    Dim primExcAoQuad, segExcAoQuad, raioMedio, raioPrimVertical, raioSecMeridiana, peqNormal As Double
    Dim latGeocGraus, latGeocMin, latGeocSeg, latGeocDec, latRedGraus, latRedMin, latRedSeg, latRedDec, x_m, y_m, dist As Double
    Private Sub frmElementosDoElipsoide_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rdLatSul.Checked = True
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        inversoAchatamento = Val(txtInversoAchatamento.Text)
        achatamento = 1 / inversoAchatamento

        txtAchatamento.Text = achatamento

        latGeodGraus = Val(txtLatGeodGraus.Text)
        latGeodMin = Val(txtLatGeodMin.Text)
        latGeodSeg = Val(txtLatGeodSeg.Text)
        latGeodDec = latGeodGraus + latGeodMin / 60 + latGeodSeg / 3600
        txtLatGeodDecimal.Text = latGeodDec

        primExcAoQuad = Math.Round(2 * achatamento - Math.Pow(achatamento, 2), 9)
        txtPrimeiraExcentricidade.Text = primExcAoQuad
        semiEixoMaior = Val(txtSemiEixoMaior.Text)
        semiEixoMenor = Math.Round(semiEixoMaior * (1 - achatamento), 3)
        txtSemiEixoMenor.Text = semiEixoMenor
        raioPrimVertical = Math.Round(semiEixoMaior / Math.Sqrt(1 - primExcAoQuad * Math.Pow(Math.Sin(latGeodDec * Math.PI / 180), 2)), 3)
        txtRaioCurvPrimVertical.Text = raioPrimVertical

        If rdLatSul.Checked Then
            latGeodDec = -latGeodDec
            txtLatGeodDecimal.Text = latGeodDec
        Else
            latGeodDec = latGeodDec
            txtLatGeodDecimal.Text = latGeodDec
        End If


        'Pequena Normal
        peqNormal = Math.Round(raioPrimVertical * (1 - primExcAoQuad), 3)
        txtPeqNormal.Text = peqNormal

        'Raio de curvatura da seccao meridiana
        raioSecMeridiana = Math.Round((semiEixoMaior * (1 - primExcAoQuad)) / Math.Sqrt(Math.Pow(1 - primExcAoQuad * Math.Pow(Math.Sin(latGeodDec * Math.PI / 180), 2), 3)), 3)
        txtRaioCurvSecMeridiana.Text = raioSecMeridiana

        'Raio medio de curvatura
        raioMedio = Math.Round(Math.Sqrt(raioPrimVertical * raioSecMeridiana), 3)
        txtRaioMedioCurvatura.Text = raioMedio

        'Raio duma seccao de Azimute A
        azimute = Val(txtAzimute.Text)
        raioDoAzimute = Math.Round((raioPrimVertical * raioSecMeridiana) / (raioPrimVertical * Math.Pow(Math.Cos(azimute * Math.PI / 180), 2) +
                                                                            raioSecMeridiana * Math.Pow(Math.Sin(azimute * Math.PI / 180), 2)), 3)
        txtRaioAzimute.Text = raioDoAzimute

        'Raio do paralelo
        raioDoParalelo = Math.Round(raioPrimVertical * Math.Cos(latGeodDec * Math.PI / 180), 3)
        txtRaioDoParalelo.Text = raioDoParalelo

        'Segunda Excentricidade ao quadrado
        segExcAoQuad = Math.Round((Math.Pow(semiEixoMaior, 2) - Math.Pow(semiEixoMenor, 2)) / Math.Pow(semiEixoMenor, 2), 3)
        txtSegundaExcentricidade.Text = segExcAoQuad

        'Latitude Geocentrica
        latGeocDec = (Math.Atan((1 - primExcAoQuad) * Math.Tan(latGeodDec * Math.PI / 180))) * 180 / Math.PI
        txtLatGeocDec.Text = latGeocDec
        latGeocDec = Math.Abs(latGeocDec)
        txtLatGeocGraus.Text = Int(latGeocDec)
        txtLatGeocMin.Text = Int((latGeocDec - Int(latGeocDec)) * 60)
        txtLatGeocSeg.Text = Math.Round((((latGeocDec - Int(latGeocDec)) * 60) - Int((latGeocDec - Int(latGeocDec)) * 60)) * 60, 2)

        'Latutude Reduzida
        latRedDec = (Math.Atan(Math.Sqrt((1 - primExcAoQuad)) * Math.Tan(latGeodDec * Math.PI / 180))) * 180 / Math.PI
        txtLatRedDec.Text = latRedDec
        latRedDec = Math.Abs(latRedDec)
        txtLatRedGraus.Text = Int(latRedDec)
        txtLatRedMin.Text = Int((latRedDec - Int(latRedDec)) * 60)
        txtLatRedSeg.Text = Math.Round((((latRedDec - Int(latRedDec)) * 60) - Int((latRedDec - Int(latRedDec)) * 60)) * 60, 2)

        'Distancia do ponto ao centro do elipsoide
        x_m = raioDoParalelo
        y_m = Math.Round(peqNormal * Math.Sin(latGeodDec * Math.PI / 180), 3)
        dist = Math.Round(Math.Sqrt(Math.Pow(x_m, 2) + Math.Pow(y_m, 2)), 3)
        txtX.Text = x_m
        txtY.Text = y_m
        txtDist.Text = dist
    End Sub

    Private Sub btnLimparDadosEntrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimparDadosEntrada.Click
        txtInversoAchatamento.Text = ""
        txtAchatamento.Text = ""
        txtSemiEixoMaior.Text = ""
        txtLatGeodDecimal.Text = ""
        txtLatGeodGraus.Text = ""
        txtLatGeodMin.Text = ""
        txtLatGeodSeg.Text = ""
        txtAzimute.Text = ""
    End Sub

    Private Sub btnLimparResultados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimparResultados.Click
        txtSemiEixoMenor.Text = ""
        txtPrimeiraExcentricidade.Text = ""
        txtSegundaExcentricidade.Text = ""
        txtRaioCurvPrimVertical.Text = ""
        txtRaioCurvSecMeridiana.Text = ""
        txtRaioAzimute.Text = ""
        txtRaioDoParalelo.Text = ""
        txtRaioMedioCurvatura.Text = ""
        txtPeqNormal.Text = ""
        txtLatGeocDec.Text = ""
        txtLatGeocGraus.Text = ""
        txtLatGeocMin.Text = ""
        txtLatGeocSeg.Text = ""
        txtLatRedDec.Text = ""
        txtLatRedGraus.Text = ""
        txtLatRedMin.Text = ""
        txtLatRedSeg.Text = ""
        txtX.Text = ""
        txtY.Text = ""
        txtDist.Text = ""

    End Sub

    Private Sub rdLatNorte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdLatNorte.CheckedChanged
        If rdLatNorte.Checked = True Then
            'lblLatGDHem.Text = "N"
            lblLatGHem.Text = "N"
            'lblLatRDHem.Text = "N"
            lblLatRHem.Text = "N"

        End If
    End Sub

    Private Sub rdLatSul_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdLatSul.CheckedChanged
        If rdLatSul.Checked = True Then
            'lblLatGDHem.Text = "S"
            lblLatGHem.Text = "S"
            'lblLatRDHem.Text = "S"
            lblLatRHem.Text = "S"
        End If

    End Sub

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        If MsgBox("Deseja realmente sair do programa?", MsgBoxStyle.YesNo, "Confirmacao de saida") = vbYes Then
            Me.Close()
        End If
    End Sub

    
    Private Sub OAutorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OAutorToolStripMenuItem.Click
        MsgBox("Programa criado por Samuel Ouana", MsgBoxStyle.Information, "Desenvolvedor")
    End Sub
End Class
