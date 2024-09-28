Imports System.IO

Public Class Form1

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex <> -1 Then
            Dim datosProducto As String() = ListBox1.SelectedItem.ToString().Split(","c)
            Dim placa As String = datosProducto(0)
            Dim marca As String = datosProducto(1)
            Dim lineac As String = datosProducto(2)
            Dim modelo As String = datosProducto(3)
            Dim color As String = datosProducto(4)
            Dim editarForm As New Form3(placa, marca, lineac, modelo, color)
            editarForm.Show()
        End If
    End Sub

    Public Sub obtenerDatos()
        ListBox1.Items.Clear()
        Dim rutaCarpeta As String = "C:\Users\Ces\source\repos\visualVehiculos"
        Dim rutaArchivo As String = Path.Combine(rutaCarpeta, "productos.txt")

        Try
            If File.Exists(rutaArchivo) Then
                Using lector As New StreamReader(rutaArchivo)
                    Dim linea As String
                    Do While lector.Peek() >= 0
                        linea = lector.ReadLine()
                        ListBox1.Items.Add(linea)
                    Loop
                End Using
            Else
                MsgBox("El archivo productos.txt no existe en la ubicación especificada.")
            End If
        Catch ex As Exception
            MsgBox("Error al leer el archivo: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        obtenerDatos()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rutaCarpeta As String = "C:\Users\Ces\source\repos\visualVehiculos"
        Dim rutaArchivo As String = Path.Combine(rutaCarpeta, "productos.txt")

        Dim form2 As New Form2()
        AddHandler form2.FormClosed, AddressOf Form2_Closed
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Closed(sender As Object, e As EventArgs)
        obtenerDatos()
        Me.Show()
    End Sub
End Class
