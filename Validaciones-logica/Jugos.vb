Imports System.CodeDom
Imports System.Runtime.InteropServices


Public Class Jugos
    Private dal As New StoreProcedures

    Public Sub guardaJugos(codigo As String, marca As String, sabor As String)
        Dim campos As String() = {codigo, marca, sabor}
        validaciones.validar_campos(campos)
        dal.InsertJugos(codigo, marca, sabor)
    End Sub

    Public Function ObtenerJugos() As DataTable
        Return dal.MostrarJugos
    End Function
End Class
