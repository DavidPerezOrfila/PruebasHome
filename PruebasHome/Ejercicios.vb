Public Class Ejercicios
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dados 3 vectores i, p, v, de 4, 4 y 9. Pida valores a v y rellene i con impares y p con pares. Al final mostrar V
        Dim i(4), p(4), v(9) As Integer
        Dim cnti, cntp, cntv As Integer
        Dim salidai As String = ""
        Dim salidap As String = ""
        Dim salidav As String = ""
        For cntv = 0 To 9
            v(cntv) = InputBox("Introduce un número: ")
        Next
        For cntv = 0 To 9
            If v(cntv) Mod 2 = 0 Then
                p(cntp) = v(cntv)
                salidap = p(cntp).ToString + vbNewLine
            Else
                i(cnti) = v(cntv)
                salidai = i(cnti).ToString + vbNewLine
            End If
            salidav = salidap.ToString + vbNewLine + salidai.ToString + vbNewLine
        Next
        MessageBox.Show(salidav)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim salida As String =
        "'Ambito de una variable:
        'donde la variable es accesible y tiene vigencia.
        'Si una variable esta dentro de un sub sólo se verá en ese sub, si está dentro de un for solamente tendrá vigencia dentro
        'Constante: no varía, tiene el mismo valor
        'Declaración: Asigna un tipo de datos a la variable reservando espacio en memoria
        'Instanciar variable: Asignar valor a una variable
        'Tipos de datos simples o compuestos: Variable, integer, char, double, boolean (simples)/ arrays(compuestos)
        'Operador: Función que recibe argumentos y devuelve un resultado (concanetación, Mod, /)
        'Operando: Argumentos que van a ser operados
        'Variable: valor que se va modificando y almacenando en la memoria como resultado de una operación dentro del programa
        'Tipo de dato: Conjunto de valores guardados en memoria con restricciones"

        MessageBox.Show(salida)
    End Sub
End Class