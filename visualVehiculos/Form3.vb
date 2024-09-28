Imports System.IO

Public Class Form3
    Private placaOriginal As String
    Private marcaOriginal As String
    Private lineaOriginal As String
    Private modeloOriginal As String
    Private colorOriginal As String

    Public Sub New(placa As String, marca As String, lineac As String, modelo As String, color As String)
        InitializeComponent()

        placaOriginal = placa
        marcaOriginal = marca
        lineaOriginal = lineac
        modeloOriginal = modelo
        colorOriginal = color

        TextBox1.Text = placa
        TextBox2.Text = marca
        TextBox3.Text = lineac
        TextBox4.Text = modelo
        TextBox5.Text = color
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim placa As String = TextBox1.Text
        Dim marca As String = TextBox2.Text
        Dim lineac As String = TextBox3.Text
        Dim modelo As String = TextBox4.Text
        Dim color As String = TextBox5.Text

        Dim lineas As New List(Of String)
        Dim rutaCarpeta As String = "C:\Users\Ces\source\repos\visualVehiculos"
        Dim rutaArchivo As String = Path.Combine(rutaCarpeta, "productos.txt")

        Using lector As StreamReader = New StreamReader(rutaArchivo)
            Do While lector.Peek() >= 0
                lineas.Add(lector.ReadLine())
            Loop
        End Using

        Dim productoModificado As String = $"{placa},{marca},{lineac},{modelo},{color}"

        For i As Integer = 0 To lineas.Count - 1
            If lineas(i) = $"{placaOriginal},{marcaOriginal},{lineaOriginal},{modeloOriginal},{colorOriginal}" Then
                lineas(i) = productoModificado
                Exit For
            End If
        Next

        Using escritor As StreamWriter = New StreamWriter(rutaArchivo, False)
            For Each linea As String In lineas
                escritor.WriteLine(linea)
            Next
        End Using

        Dim form1 As Form1 = DirectCast(Application.OpenForms("Form1"), Form1)
        form1.obtenerDatos()

        MsgBox("Cambios guardados exitosamente.")
        Me.Close()
    End Sub

End Class
