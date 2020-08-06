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

        End sub

        Private Sub CIPersonaInput_TextChanged(sender As Object, e As EventArgs) Handles CIPersonaInput.TextChanged

        Dim cedula As integer
        cedula = CIPersonaInput.Text
        Dim personaNueva As personas 
        Dim logica As LogicaPersona
        personaNueva = logica.buscarPersonas(cedula)
        If  isNothing (personaNueva) Then 
            NombrePersonaInput.Text = personaNueva.Nombre
            DireccionPersonaInput.Text = personaNueva.direccion
        else
        End if
      End Sub
End Class
