Public Class SimpleAlgorithmsForm
    Dim _generator As Random = New Random()
    Dim _arr(5, 5) As Integer
    Private Sub ShowArray(mas As Array)
        For i = 0 To 5
            DataGridView1.Columns.Add("", "")
            DataGridView1.Rows.Insert(i)
        Next
        For i = 0 To 5
            For j = 0 To 5
                DataGridView1.Item(i, j).Value = mas(i, j)
            Next
        Next
    End Sub
    Private Function FindMin(mas As Array) As Single
        Dim min As Single
        min = mas(0, 0)
        For i = 0 To 5
            For j = 0 To 5
                If min > mas(i, j) Then
                    min = mas(i, j)
                End If
            Next
        Next
        Return min
    End Function
    Private Function FindMax(mas As Array) As Single
        Dim max As Single
        max = mas(0, 0)
        For i = 0 To 5
            For j = 0 To 5
                If max < mas(i, j) Then
                    max = mas(i, j)
                End If
            Next
        Next
        Return max
    End Function
    Private Function SortDesc(mas As Array) As Array
        Dim singlBuff As Integer
        Dim flag = False
        For i = 0 To 5
            For j = 0 To 4
                singlBuff = mas(i, j)
                If (mas(i, j) > mas(i, j + 1)) Then
                    mas(i, j) = mas(i, j + 1)
                    mas(i, j + 1) = singlBuff
                    flag = True
                End If
                If (j + 1) = 5 And i <> 5 Then
                    singlBuff = mas(i, j + 1)
                    If mas(i, j + 1) > mas(i + 1, 0) Then

                        mas(i, j + 1) = mas(i + 1, 0)
                        mas(i + 1, 0) = singlBuff
                        flag = True
                    End If
                End If
            Next
        Next

        If flag Then
            mas = SortDesc(mas)
        End If

        For i = 0 To 5
            For j = 0 To 4
                singlBuff = mas(j, i)
                If mas(j, i) > mas(j + 1, i) Then
                    mas(j, i) = mas(j + 1, i)
                    mas(j + 1, i) = singlBuff
                    flag = True
                End If
            Next
        Next

        If flag Then
            mas = SortDesc(mas)
        End If
        Return mas
    End Function

    Private Function SortAsc(mas As Array) As Array
        Return mas
    End Function

    Private Function InitData() As Array
        For i = 0 To 5
            For j = 0 To 5
                _arr(i, j) = _generator.Next(500)
            Next
        Next
        Return _arr
    End Function
    Private Sub ButtonInit_Click(sender As Object, e As EventArgs) Handles ButtonInit.Click
        Dim mas = InitData()
        ShowArray(mas)
    End Sub
    Private Sub ButtonSortDescending_Click(sender As Object, e As EventArgs) Handles ButtonSortDescending.Click
        _arr = SortDesc(_arr)
        ShowArray(_arr)
    End Sub
    Private Sub ButtonSortAscending_Click(sender As Object, e As EventArgs) Handles ButtonSortAscending.Click
        _arr = SortAsc(_arr)
        ShowArray(_arr)
    End Sub

    Private Sub ButtonMin_Click(sender As Object, e As EventArgs) Handles ButtonMin.Click
        Dim min As Single
        min = FindMin(_arr)
        ButtonMin.Text = "Min = " + min.ToString
    End Sub

    Private Sub ButtonMax_Click(sender As Object, e As EventArgs) Handles ButtonMax.Click
        Dim max As Single
        max = FindMax(_arr)
        ButtonMax.Text = "Max = " + max.ToString
    End Sub

End Class

