Imports System.IO

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rutaCarpeta As String = "C:\Users\Ces\source\repos\visualVehiculos"
        Dim rutaArchivo As String = Path.Combine(rutaCarpeta, "productos.txt")
        Dim Placa As String = TextBox1.Text
        Dim marca As String = TextBox2.Text
        Dim lineac As String = TextBox3.Text
        Dim modelo As String = TextBox4.Text
        Dim color As String = TextBox5.Text

        ' Verifica si los campos están vacíos
        If Placa = "" Or marca = "" Or lineac = "" Or modelo = "" Or color = "" Then
            MsgBox("Por favor, complete todos los campos antes de registrar el producto.")
            Return
        End If

        Dim producto As String = Placa & "," & marca & "," & lineac & "," & modelo & "," & color

        Try
            ' Abre el archivo en modo de escritura de texto y agrega el nuevo producto
            Using escritor As StreamWriter = File.AppendText(rutaArchivo)
                escritor.WriteLine(producto)
            End Using

            MsgBox("Producto registrado exitosamente.")
            Me.Close()
        Catch ex As Exception
            MsgBox("Error al registrar el producto: " & ex.Message)
        End Try
    End Sub
End Class
