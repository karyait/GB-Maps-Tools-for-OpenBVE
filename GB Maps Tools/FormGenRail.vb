'Imports System.Text

Public Class FormGenRail

    Private Sub ButtonGen_Click(sender As Object, e As EventArgs) Handles ButtonGen.Click
        'Dim txt As New StringBuilder

        Dim no As Integer = NumericUpDownNo.Value
        Dim no0 As Integer = NumericUpDownNo.Value
        Dim nama As String = TextBoxName.Text
        Dim title As String = TextBoxTitle.Text
        Dim jenis As String = cbtype.Text
        Dim imgP As String = TextBoxImg0.Text
        Dim imgN As String = TextBoxImg1.Text
        Dim filedir As String = TextBoxfiledir.Text
        Dim sw0 = TextBoxSw0.Text
        Dim sw1 = TextBoxSw1.Text
        Dim gauge = TextBoxGauge.Text
        Dim radiusList = txtRadius.Text.Split(",")

        ProgressBar1.Visible = True
        For Each item In radiusList
            If item <> "" Then
                Dim noTxt = item.ToString
                Dim nama0 = nama.Replace("XXXXX", noTxt)
                Dim title0 = title.Replace("XXXXX", noTxt)
                Dim imgfile = ""
                If CInt(noTxt) > 0 Then
                    imgfile = imgP.Replace("XXXXX", noTxt)
                Else
                    imgfile = imgN.Replace("XXXXX", noTxt)
                End If
                Dim filedir0 = filedir.Replace("XXXXX", noTxt)
                'rail,2,BL1067-1R100,Curve R100 1067mm - 1,cv_ballast,,gb_maps\rail\1067\ballast\1067ballast1r100i0o105.csv,radius,0,0,1067
                'Dim addTxt As String = "rail," & no0.ToString & "," & nama0 & "," & title0 & "," & jenis & "," & imgfile & "," & filedir0 & "," & noTxt & "," & sw0 & "," & sw1 & "," & gauge
                'txt.AppendLine(addTxt)
                If nama0 <> "" And title0 <> "" And filedir0 <> "" And jenis <> "" Then
                    Main.DataGridViewRailType.Rows.Add(New String() {Main.DataGridViewRailType.RowCount - 1, nama0, _
                        title0, "cv", jenis, filedir0, imgfile, noTxt, _
                        sw0, sw1, gauge})
                End If

                no0 += 1
                ProgressBar1.Value = CInt(((no0 - no) / radiusList.Count) * 100)
            End If
        Next
        ProgressBar1.Visible = False
        'TextBoxExport.Text = txt.ToString
        Close()
    End Sub




    Private Sub btnPtImg_Click(sender As Object, e As EventArgs) Handles btnPtImg.Click
        Main.OpenFileDialog2.InitialDirectory = Main.gbIdir
        If Main.OpenFileDialog2.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Try
                TextBoxImg0.Text = Main.OpenFileDialog2.FileName.ToLower.Replace(Main.gbIdir.ToLower & "\", "")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnNvImg_Click(sender As Object, e As EventArgs) Handles btnNvImg.Click
        Main.OpenFileDialog2.InitialDirectory = Main.gbIdir
        If Main.OpenFileDialog2.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Try
                TextBoxImg1.Text = Main.OpenFileDialog2.FileName.ToLower.Replace(Main.gbIdir.ToLower & "\", "")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ButtonGenRadius_Click(sender As Object, e As EventArgs) Handles ButtonGenRadius.Click
        GenRadius.ShowDialog(Me)
    End Sub
End Class