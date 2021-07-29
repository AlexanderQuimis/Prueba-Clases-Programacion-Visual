Public Class ClasePersona
    'Propiedades/Atributos
    Public Apellido_Paterno As String
    Public Apellido_Materno As String
    Public Seguro_Social As Integer
    Public Sexo As String
    Public Categoria As String
    Public CodigoPedido As String
    Public Tipo_Contrato As String
    Public Sueldo As String
    Public Function Cliente()
        Return Me.Apellido_Paterno & " " & Me.Apellido_Materno & ", Seguro Social " & Seguro_Social & " Categoria de pedido: " & Categoria & " No. Pedido: " & CodigoPedido
    End Function

    Public Function Empleado()
        Return Me.Apellido_Paterno & " " & Me.Apellido_Materno & " Seguro Social, " & Seguro_Social & " Tipo de contrato: " & Tipo_Contrato & ", Sueldo: " & Sueldo
    End Function

End Class
