﻿Public Class personas
    Private _ci As Integer
    Private _nombre As String
    Private _direccion As String
    Private _telefono As Integer

    Public Property Ci As Integer
        Get
            Return _ci
        End Get
        Set(value As Integer)
            _ci = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property



    Public Property telefono As Integer
        Get
            Return _telefono
        End Get
        Set(value As Integer)
            _telefono = value
        End Set
    End Property

    Public Sub personas()

    End Sub

    Public Sub personas(ci_ As Integer, nombre_ As String, direccion_ As String, telefono_ As Integer)
        Ci = ci_
        Nombre = nombre_
        direccion = direccion_
        telefono = telefono_
    End Sub

End Class
