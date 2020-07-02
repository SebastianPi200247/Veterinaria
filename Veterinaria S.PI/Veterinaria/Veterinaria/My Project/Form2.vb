Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Nom1 As String
        Nom1 = tbxNom1.Text

        Dim CI1 As Integer = CInt(CI1)
        CI1 = tbxCI1.Text

        Dim Año As Integer
        Año = tbxAño.Text

        Dim Re1 As String
        Re1 = CI1 & Nom1 & Año
        tbxRe1.Text = Re1

    End Sub


End Class