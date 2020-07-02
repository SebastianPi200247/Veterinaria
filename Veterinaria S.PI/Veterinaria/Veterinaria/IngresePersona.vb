Public Class IngresePersona

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Nom As String
        Nom = tbxNom.Text

        Dim Dire As String
        Dire = tbxDire.Text

        Dim CI As Integer = CInt(CI)
        CI = tbxCI.Text

        Dim Re As String
        Re = CI & Nom & Dire
        tbxRe.Text = Re


    End Sub


End Class
