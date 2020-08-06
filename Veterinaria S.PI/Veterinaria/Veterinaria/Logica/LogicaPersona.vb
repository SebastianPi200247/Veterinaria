Public Class LogicaPersona
    Public Sub altapersona (personita As personas) 
        Dim persistencia As New PersistenciaPersona
        persistencia.Altapersona(personita)


    End Sub
    Public Function buscarPersonas(ci As integer) As personas
        Dim persistencia As New PersistenciaPersona
        return.persistencia.Buscarpersona(ci)

    End Function
End Class