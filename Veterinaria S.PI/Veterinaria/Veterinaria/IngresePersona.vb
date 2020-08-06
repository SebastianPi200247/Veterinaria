Public Class IngresePersona

    Private Sub IngresePersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NombrePersona As String
        NombrePersona = NombrePersonaInput.Text

        Dim CIPersona As Integer
        CIPersona = CIPersonaInput.Text

        Dim DireccionPersona As String
        DireccionPersona = DireccionPersonaInput.Text

        Dim personanueva = New personas
        personanueva.Ci = CIPersona
        personanueva.Nombre = NombrePersona
        personanueva.direccion = DireccionPersona

        Dim Logica = New LogicaPersona
        Logica.altapersona(personanueva)


    End Sub


End Class
