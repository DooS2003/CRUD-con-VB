Imports System.Data.SqlClient

Public Class Form1

    Private dal As New Jugos
    Public Sub guardar_jugos()
        Try
            dal.guardaJugos(Text_codigo.Text, Text_sabor.Text, Text_marca.Text)
            MsgBox("Producto Guardado correctamente")
            listar_datos()
            limpiar_campos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Function listar_datos()
        Try
            DataGridView1.DataSource = dal.ObtenerJugos
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Sub limpiar_campos()
        Text_codigo.Text = ""
        Text_marca.Text = ""
        Text_sabor.Text = ""
    End Sub
    Private Sub Button_guardar_Click(sender As Object, e As EventArgs) Handles Button_guardar.Click
        guardar_jugos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        listar_datos()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text_codigo.MaxLength = 5
        Text_sabor.MaxLength = 20
        Text_marca.MaxLength = 20
    End Sub

End Class
