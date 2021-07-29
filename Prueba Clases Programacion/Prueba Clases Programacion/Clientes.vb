Public Class Clientes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Datos As ClasePersona = New ClasePersona()
        Datos.Apellido_Paterno = TxbPaterno.Text
        Datos.Apellido_Materno = TxbMaterno.Text
        Datos.Seguro_Social = TxbSocial.Text
        Datos.Sexo = CmbSexo.Text
        Datos.Categoria = CmbCategoria.Text
        If Datos.Categoria = "Electrodomestricos" Then
            Datos.CodigoPedido = "236544"
        Else
            If Datos.Categoria = "Inmobiliaria" Then
                Datos.CodigoPedido = "214325"
            Else
                If Datos.Categoria = "Computo" Then
                    Datos.CodigoPedido = "355677"
                End If
            End If
        End If


        TxbResultado.Text = Datos.Cliente()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f2 As Principal = New Principal()
        f2.Show()
        Me.Hide()
    End Sub
End Class