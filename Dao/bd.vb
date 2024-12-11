Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class bd
    Dim stringconexion As String = "Data Source=LAPTOP-1DM90IEE;Initial Catalog=jugos;Integrated Security=False;User=sa;Password=1234"

    Public conectarbd As New SqlConnection(stringconexion)
    Public Sub abrir()
        Try
            conectarbd.Open()
            Console.WriteLine("BDconect")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cerrar()
        conectarbd.Close()
    End Sub

End Class
