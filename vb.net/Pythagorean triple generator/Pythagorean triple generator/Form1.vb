Public Class LTo
    Dim S As Byte = 0
    Dim A As ULong
    Dim B As ULong
    Dim C As Decimal
    Private Sub BTNStart_Click(sender As Object, e As EventArgs) Handles BTNStart.Click
        A = From.Value
        B = A
        BTNStart.Text = "Stop"
        BTNStart.ForeColor = Color.Red
        Do While S = 0
            C = Math.Sqrt((A * A) + (B * B))
            If Math.Round(C, 0) = C Then
                LBOutput.Items.Add(Str(A) + "/" + Str(B) + "/" + Str(C))
            End If
            If A And B = ToN.Value Then
                S = 1
            End If
            If A = ToN.Value Then
                A = B
                B = B + 1
            End If
            A = A + 1
            LBOutput.Refresh()
            ' LBOutput.SetSelected(LBOutput.TopIndex, True)
        Loop
        BTNStart.Text = "Start"
        BTNStart.ForeColor = Color.FromArgb(0, 192, 0)
        A = Nothing
        B = Nothing
        C = Nothing
        S = 0
    End Sub
End Class
