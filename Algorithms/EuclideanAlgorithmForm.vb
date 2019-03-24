Public Class EuclideanAlgorithmForm
    Dim A, B, C As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClearData()
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles Button1.Click
        Try
            Try
                A = Integer.Parse(TextBoxA.Text)
            Catch ex As FormatException
                MsgBox("Enter correct value A")
                Throw ex
            End Try
            Try
                B = Integer.Parse(TextBoxB.Text)
            Catch ex As FormatException
                MsgBox("Enter correct value B")
                Throw ex
            End Try
        Catch ex As Exception
            Return
        End Try
        StartEvklidAlgoritm()
        TextBoxC.Text = C.ToString
    End Sub

    Private Sub StartEvklidAlgoritm()
        Do While A <> 0 And B <> 0
            If A > B Then
                A = A Mod B
            Else
                B = B Mod A
            End If
        Loop
        C = A + B
    End Sub

    Private Sub ClearData()
        TextBoxA.Clear()
        TextBoxB.Clear()
        TextBoxC.Clear()
    End Sub
End Class