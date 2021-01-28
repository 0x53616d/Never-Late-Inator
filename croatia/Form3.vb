Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub closeprogram()
        Me.Hide()
        Me.WindowState = FormWindowState.Minimized
    End Sub

End Class