Public Class Empleados
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Datos As ClasePersona = New ClasePersona()
        Datos.Apellido_Paterno = TxbPaterno.Text
        Datos.Apellido_Materno = TxbMaterno.Text
        Datos.Seguro_Social = TxbSocial.Text
        Datos.Sexo = CmbSexo.Text
        Datos.Tipo_Contrato = CmbContrato.Text
        If Datos.Tipo_Contrato = "Cajas" Then
            Datos.Sueldo = "400.00 $"
        Else
            If Datos.Tipo_Contrato = "Administrador" Then
                Datos.Sueldo = "750.00 $"
            Else
                If Datos.Tipo_Contrato = "Limpieza" Then
                    Datos.Sueldo = "350.00 $"
                End If
            End If
        End If
        TxbResultado.Text = Datos.Empleado()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f2 As Principal = New Principal()
        f2.Show()
        Me.Hide()
    End Sub
End Class