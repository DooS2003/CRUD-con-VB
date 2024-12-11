Imports System.Data.SqlClient

Public Class StoreProcedures

    Private conexion As bd

    Public Sub New()
        conexion = New bd
    End Sub

    Public Sub InsertJugos(codigo As String, marca As String, sabor As String)
        Try
            conexion.abrir()
            Dim cmd As String = "SP_insertarJugo"
            Using comando As New SqlCommand(cmd, conexion.conectarbd)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@codigo", codigo)
                comando.Parameters.AddWithValue("@marca", marca)
                comando.Parameters.AddWithValue("@sabor", sabor)
                comando.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw New Exception("Error al insertar el jugo" + ex.Message)
        Finally
            conexion.cerrar()
        End Try
    End Sub


    Public Function MostrarJugos()
        Dim tabla As New DataTable
        Try
            conexion.abrir()
            Dim cmd As String = "SP_mostrarJugo"
            Dim comando As New SqlDataAdapter(cmd, conexion.conectarbd)
            comando.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error al obtener el listado" + ex.Message)
        Finally
            conexion.cerrar()
        End Try

        Return tabla
    End Function



End Class
