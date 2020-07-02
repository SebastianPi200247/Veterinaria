Public Class Conexion
    Public Function AbrirConexion() As Npgsql.NpgsqlConnection
        Dim Conexion As Npgsql.NpgsqlConnection
        Try

        Catch ex As Exception
            Throw ex
        End Try


        Return Conexion

    End Function
End Class
