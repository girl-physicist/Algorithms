Public Class SimpleAlgorithmsForm

    Dim Generator As Random = New Random()
    Dim Arr(6, 6) As Integer
    Private Sub ButtonInit_Click(sender As Object, e As EventArgs) Handles ButtonInit.Click

        For i = 0 To 5
            DataGridView1.Columns.Add("", "")
            DataGridView1.Rows.Insert(i)
        Next
        For i = 0 To 5
            For j = 0 To 5
                Arr(i, j) = Generator.Next(500)
                DataGridView1.Item(i, j).Value = Arr(i, j)
            Next
        Next

    End Sub

    Private Sub ButtonSortDescending_Click(sender As Object, e As EventArgs) Handles ButtonSortDescending.Click
        'Bubble sort 
        'Shaker sort
        'Comb sort
        'Insertion sort
        'Shellsort
        'Tree sort
        'Gnome sort
        'Selection sort
        'and other types of sorting (https://habr.com/ru/post/335920/)
    End Sub

    Private Sub ButtonSortAscending_Click(sender As Object, e As EventArgs) Handles ButtonSortAscending.Click

    End Sub

    Private Sub ButtonMin_Click(sender As Object, e As EventArgs) Handles ButtonMin.Click
        Dim Min As Single
        Min = Arr(0, 0)
        For i = 0 To 5
            For j = 0 To 5
                If Min > Arr(i, j) Then
                    Min = Arr(i, j)
                End If
            Next
        Next
        ButtonMin.Text = "Min = " + Min.ToString
    End Sub

    Private Sub ButtonMax_Click(sender As Object, e As EventArgs) Handles ButtonMax.Click
        Dim Max As Single
        Max = Arr(0, 0)
        For i = 0 To 5
            For j = 0 To 5
                If Max < Arr(i, j) Then
                    Max = Arr(i, j)
                End If
            Next
        Next
        ButtonMax.Text = "Max = " + Max.ToString
    End Sub
End Class

