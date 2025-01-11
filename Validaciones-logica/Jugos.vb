Imports System.CodeDom
Imports System.Runtime.InteropServices


Public Class Jugos
    Private dal As New StoreProcedures

    Public Sub guardaJugos(codigo As String, marca As String, sabor As String)
        Dim campos As String() = {codigo, marca, sabor}
        validaciones.validar_campos(campos)
        dal.InsertJugos(codigo, marca, sabor)
    End Sub

    Public Sub modificarJugos(codigo As String, marca As String, sabor As String)
        Dim campos As String() = {codigo, marca, sabor}
        validaciones.validar_campos(campos)
        dal.ModificarJugos(codigo, marca, sabor)
    End Sub

    Public Sub eliminarJugos(codigo As String)
        Dim v_codigo As String = codigo
        dal.EliminarJugos(v_codigo)
    End Sub

    Public Function ObtenerJugos() As DataTable
        Return dal.MostrarJugos
    End Function
End Class
