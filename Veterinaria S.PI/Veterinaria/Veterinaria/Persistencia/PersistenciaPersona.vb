Public Class PersistenciaPersona
    Dim conexion As Npgsql.NpgsqlConnection
    Public Sub altapersona(personita As personas)
        Try
            Dim classcnn = New Conexion
            conexion = classcnn.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conexion
            Dim cadenadecomando As String
            cadenadecomando = "insert into (ci,nombre,direccion) values(@ci,@nombre,@direccion);"

            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = personita.Ci
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = personita.Nombre
            cmd.Parameters.Add("@direccion", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = personita.direccion

            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Function Buscarpersona(ci As integer) As personas 
        Try
        Dim ClaseSln As New Conexion  
        conexion = ClaseSln.AbrirConexion
        Dim cmd As NpgsqlCommand 
        cmd.Connection = conexion
    
        Dim CadenaDeComandos = "Select * from persona where cedulapersona = @ci "
        cmd.CommandText= CadenaDeComandos 
        cmd.Parameters.add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci
        Dim lector As npgsql.DataReader = cmd.ExecuteReader
        Dim personaNueva As personas

    If lector.hasRows Then 
        lector.Read()
        personaNueva.Ci = Convert.ToInt32(lector(0).ToString)
        personaNueva.Nombre = lector(1).ToString
        personaNueva.direccion =lector(2).ToString

    End if
    Catch ex As Exception
     
    Finally
    Return personaNueva
    End Try
    End Function
End Class
