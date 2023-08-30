Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Hide()
        Me.Text = "Расчёт количества дней между датами"
        End Sub
        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Dim d1 As DateTime = DateTimePicker1.Value
            Dim d2 As DateTime = DateTimePicker2.Value
        Dim result As TimeSpan = d2.Subtract(d1)
        Dim days As Integer = result.TotalDays
        Label1.Show()
        Label1.Text = days
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

End Class
