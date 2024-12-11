Public Class validaciones
    Public Shared Sub validar_campos(ByVal campos As String())
        For Each campo In campos
            If String.IsNullOrEmpty(campo) Then
                Throw New InvalidOperationException("Llene todos los campos")
            End If
        Next
    End Sub
End Class
