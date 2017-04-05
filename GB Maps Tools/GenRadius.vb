Imports System.Text

Public Class GenRadius

    Private Sub ButtonGenerate_Click(sender As Object, e As EventArgs) Handles ButtonGenerate.Click
        Dim radiusTxt As New StringBuilder
        Dim gauge = CInt(NumericUpDownGauge.Value)
        Dim cant = CInt(NumericUpDownCant.Value)

        For i = 0 To CheckedListBoxDesignSpeed.CheckedItems.Count - 1
            Dim speed = CheckedListBoxDesignSpeed.CheckedItems.Item(i)
            Dim Ds = CInt(speed)
            Dim radius = Math.Round((gauge * Ds * Ds) / (127 * cant))

            If radiusTxt.ToString = "" Then
                radiusTxt.Append(radius & ",-" & radius)
            Else
                radiusTxt.Append("," & radius & ",-" & radius)
            End If
        Next

        FormGenRail.txtRadius.Text = radiusTxt.ToString

        Close()
    End Sub
End Class