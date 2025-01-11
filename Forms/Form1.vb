Imports System.Data.SqlClient

Public Class Form1

    Private dal As New Jugos
    Public Sub guardar_jugos()
        Try
            dal.guardaJugos(Text_codigo.Text, Text_marca.Text, Text_sabor.Text)
            MsgBox("Producto Guardado correctamente")
            listar_datos()
            limpiar_campos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub modificar_jugos()
        Try
            dal.modificarJugos(Text_codigo.Text, Text_marca.Text, Text_sabor.Text)
            MsgBox("Producto modificado correctamente")
            listar_datos()
            limpiar_campos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub eliminar_jugos()
        Try
            dal.eliminarJugos(Text_codigo.Text)
            MsgBox("Producto eliminado correctamente")
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

    Private Sub Button_modificar_Click(sender As Object, e As EventArgs) Handles Button_modificar.Click
        modificar_jugos()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If (e.RowIndex > 0) Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Text_codigo.Text = row.Cells("Codigo").Value.ToString
            Text_marca.Text = row.Cells("Marca").Value.ToString
            Text_sabor.Text = row.Cells("Sabor").Value.ToString
        End If
    End Sub

    Private Sub Button_delete_Click(sender As Object, e As EventArgs) Handles Button_delete.Click
        Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este elemento?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            eliminar_jugos()
        End If
    End Sub

End Class
