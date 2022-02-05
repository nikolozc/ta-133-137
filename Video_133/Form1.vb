Public Class Form1

    Private myArray() As Integer = {5, 4, 3, 2, 1}

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim index As Integer
        Try
            For index = 0 To 5
                'If index >= myArray.Length Then
                '    Throw New IndexOutOfRangeException("Error text")
                'End If
                ListBox1.Items.Add(myArray(index))
            Next
        Catch ex As IndexOutOfRangeException When index = 5
            'MsgBox(ex.Message)
            MessageBox.Show("Error message. index out of bounds")
        Finally
            MessageBox.Show("I am the finally")
            Beep()
        End Try
    End Sub
End Class
