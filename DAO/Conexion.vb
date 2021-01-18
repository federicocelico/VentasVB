Imports System.Data.SqlClient
Imports System.Configuration


Public Class Conexion

    Dim conexion As SqlConnection



    Public Function conectar() As SqlConnection
        Try
            conexion = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Return conexion
        Catch ex As Exception
            MsgBox("No se pudo conectar a la Base de Datos", MsgBoxStyle.Critical)
        End Try

    End Function





End Class
