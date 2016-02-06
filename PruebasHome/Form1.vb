Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Programa que calcula àrea i perímetre d'un cercle
        Const PI = 3.141592 'Definició de la constant PI 
        Dim radi, area, perimetre As Double
        Dim salida As String = ""
        radi = InputBox("Introdueix el radi del cercle:")
        If radi > 0 Then 'que el radi sigui positiu'
            area = PI * radi * radi
            perimetre = 2 * PI * radi
            salida += "L'area del cercle és: " + area.ToString + vbNewLine +
            "El perimetre de la circumferencia és: " + perimetre.ToString + vbNewLine
        End If
        MessageBox.Show(salida)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Programa que calcula àrea i perímetre d'un cercle
        Const PI = 3.141592 'Definició de la constant PI 
        Dim radi, area, perimetre As Double
        Dim salida As String = ""
        radi = InputBox("Introdueix el radi del cercle:")
        If radi > 0 Then 'que el radi sigui positiu'
            area = PI * radi * radi
            perimetre = 2 * PI * radi
            salida += "L'area del cercle és: " + area.ToString + vbNewLine +
            "El perimetre de la circumferencia és: " + perimetre.ToString + vbNewLine
        Else 'Error si el valor del radi és negatiu'
            salida += "El valor ha de ser positiu"
        End If
        MessageBox.Show(salida)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Programa que simula el funcionament d'una calculadora simple'
        Dim operacio As Char 'Operació que s'ha de realitzar.'
        Dim x, y As Integer 'Valors d'entrada. */
        x = InputBox("Introdueix un número: ")
        y = InputBox("Introdueix un número: ")
        operacio = InputBox("Introdueix una operació vàlida: ")

        Select Case operacio

            Case "+"
                MessageBox.Show(x + y)
            Case "-"
                MessageBox.Show(x - y)

            Case "*"
                MessageBox.Show(x * y)

            Case "/"
                MessageBox.Show(x / y)
            Case Else
                MessageBox.Show("Operació incorrecta.")
        End Select

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Programa que calcula el factorial d'un nombre enter amb bucle while'
        Dim n, factorial, i As Integer
        Dim salida As String = ""

        n = InputBox("Introdueix un nombre positiu:")
        factorial = 1 'Inicialització variables bucle'
        i = 1
        While i < n 'Condició de finalització

            i = i + 1 'Actualització variables bucle'
            factorial = factorial * i ' Accions del bucle'

            salida += "El factorial és: " + factorial.ToString + vbNewLine

        End While
        MessageBox.Show(salida)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Programa que calcula el factorial d'un nombre enter bucle for
        Dim n, factorial, i As Integer
        Dim salida As String = ""
        n = InputBox("Introdueix un numero positiu:")
        factorial = 1 'Inicialització, actualització var control, condició final dins del for
        For i = 2 To i <= n
            factorial = factorial * i 'Accions del bucle'
            salida += "El factorial és: " + factorial.ToString
        Next
        MessageBox.Show(salida)
    End Sub
End Class
