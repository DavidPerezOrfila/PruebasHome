Public Class Bucles
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Escriure un programa que llegeixi dos nombres enters i digui si el primer és divisible pel segon o no.'
        Dim n1, n2 As Integer
        Dim salida As String = ""
        n1 = InputBox("Introduce un número")
        n2 = InputBox("introduce un número")
        If n1 / n2 Then
            MessageBox.Show("El segundo número es divisible por el primero")
        Else
            MessageBox.Show("El segundo número no es divisible por el primero")

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Escriure un programa que llegeixi tres nombres enters i digui quin és el màxim i
        'quin el mínim, amb el menor nombre de comparacions possibles. 
        Dim n1, n2, n3, menor As Integer
        Dim salida As String = " "
        n1 = InputBox("Introduce un número: ")
        n2 = InputBox("Introduce un número: ")
        n3 = InputBox("Introduce un número: ")

        If n1 < n2 And n1 < n3 Then
            menor = n1
            salida += "El número menor es: " + menor.ToString
        ElseIf n2 < n1 And n2 < n3 Then
            menor = n2
            salida += "El número menor es: " + menor.ToString
        ElseIf n3 < n1 And n3 < n2 Then
            menor = n3
            salida += "El número menor es: " + menor.ToString
        End If
        MessageBox.Show(salida)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Escriure un programa que llegeixi un caràcter i digui si correspon a una vocal o a
        'una consonant.Si no és ni una vocal ni una consonant, s'haurà de donar un missatge
        'd 'error.
        Dim vocal As String = "", consonante As String = "", salida As String = "", caracter As String = ""
        vocal = "a,e,i,o,u"
        consonante = "b,c,d,f,g,h,j,k,l,m,n,p,q,r,s,t,v,w,x,y,z"
        caracter = InputBox("Introduce un caracter: ")
        If InStr(vocal, caracter) <> 0 Then 'InStr busca dintre d'una cadena de caràcters'

            salida += caracter.ToString + vbNewLine + "El caracter es una vocal "
        ElseIf InStr(consonante, caracter) <> 0 Then

            salida += caracter.ToString + vbNewLine + "El caracter es una consonante"
        Else
            salida += caracter.ToString + vbNewLine + "El caracter no es ni vocal ni consonante"
        End If
        MessageBox.Show(salida)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Escriure un programa, que a partir del valor numèric de la nota d’un alumne i fent
        'servir el mínim nombre de comparacions, escrigui un caràcter que codifiqui la nota
        'que li sortirà a l'acta, segons la taula següent:
        'Nota numèrica        Nota de l'acta  Codificació de l’acta
        '0 <= Nota < 5             Suspès                S
        '5 <= Nota < 6,5           Aprovat               A
        '6,5 <= Nota < 8,5         Notable               N
        '8,5 <= Nota < 9,75        Excel·lent            E
        '9,75 <= Nota <= 10        Matrícula             M
        Dim nota As Double
        Dim salida As String = ""
        nota = InputBox("Introduce tu nota: ")

        If nota < 5 Then
            salida = "La teva nota és: Suspès"
        ElseIf nota >= 5 And nota < 6.5 Then
            salida = "La teva nota és: Aprovat"
        ElseIf nota >= 6.5 And nota < 8.5 Then
            salida = "La teva nota és: Notable"
        ElseIf nota >= 8.5 And nota < 9.75 Then
            salida = "La teva nota és: Excel.lent"
        ElseIf nota >= 9.75 And nota < 10 Then
            salida = "La teva nota és: Matricula"

        End If
        MessageBox.Show(salida)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Escriure un programa que llegeixi un nombre entre 1 i 7, i utilitzant l’estructura
        'condicional Select case, escrigui el nom del dia de la setmana corresponent. És a dir
        'si s'introdueix un 1, ha d’escriure “dilluns”, si s’introdueix un 2, ha d’escriure
        '“dimarts”, etc...
        Dim dia As Integer
        Dim salida As String = ""
        dia = InputBox("introduce un número del día de la semana: ")
        Select Case dia
            Case 1
                salida = dia.ToString + vbNewLine + "Lunes"
            Case 2
                salida = dia.ToString + vbNewLine + "Martes"
            Case 3
                salida = dia.ToString + vbNewLine + "Miércoles"
            Case 4
                salida = dia.ToString + vbNewLine + "Jueves"
            Case 5
                salida = dia.ToString + vbNewLine + "Viernes"
            Case 6
                salida = dia.ToString + vbNewLine + "Sábado"
            Case 7
                salida = dia.ToString + vbNewLine + "Domingo"

        End Select
        MessageBox.Show(salida)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Convertir l’estructura switch/case de l’exercici anterior a una estructura equivalent
        'utilitzant If/else
        Dim dia As Integer
        Dim salida As String = ""
        dia = InputBox("Introduce el número de la semana: ")
        If dia = 1 Then
            salida = dia.ToString + vbNewLine + "Lunes"
        ElseIf dia = 2
            salida = dia.ToString + vbNewLine + "Martes"
        ElseIf dia = 3
            salida = dia.ToString + vbNewLine + "Miércoles"
        ElseIf dia = 4
            salida = dia.ToString + vbNewLine + "Jueves"
        ElseIf dia = 5
            salida = dia.ToString + vbNewLine + "Viernes"
        ElseIf dia = 6
            salida = dia.ToString + vbNewLine + "Sábado"
        ElseIf dia = 7
            salida = dia.ToString + vbNewLine + "Domingo"

        End If
        MessageBox.Show(salida)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Suposant que la variable nota només pot agafar valors enters, convertir l’estructura
        'següent en una altra equivalent utilitzant la instrucció select case.
        Dim nota As Integer
        Dim salida As String = ""
        nota = InputBox("Introduce una nota con números enteros: ")
        Select Case nota
            Case 0 To 4
                salida = nota.ToString + vbNewLine + "Suspès"
            Case 5 To 6
                salida = nota.ToString + vbNewLine + "Aprovat"
            Case 7 To 8
                salida = nota.ToString + vbNewLine + "Notable"
            Case 9 To 10
                salida = nota.ToString + vbNewLine + "Excel.lent"
        End Select
        MessageBox.Show(salida)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'Escriure un programa que llegeixi el número d’un mes (entre 1 i 12), i un any, i
        'indiqui el nombre de dies que té aquell mes. Recordar que el mes de febrer té 29
        'dies si l'any és divisible per 4, menys quan també és divisible per 100 però no per
        '400. Així, el mes de febrer de 1900 va tenir 28 dies, però el de 2000 en va tenir 29. 
        Dim dia, mes, anyo As Integer
        Dim salida As String = ""
        mes = InputBox("Introduce un mes del año en número: ")
        anyo = InputBox("Introduce un año: ")
        If mes = 2 And anyo Mod 4 = 0 And anyo Mod 100 = 0 And anyo Mod 400 <> 0 Then
            dia = 28
            salida = "el mes contiene: " + dia.ToString + " días"
        ElseIf mes = 2 And anyo Mod 4 = 0 Then
            dia = 29
            salida = "el mes contiene: " + dia.ToString + " días"
        ElseIf mes = 2
            dia = 28
            salida = "el mes contiene: " + dia.ToString + " días"
        ElseIf mes = 1 Or mes = 3 Or mes = 5 Or mes = 7 Or mes = 8 Or mes = 10 Or mes = 12 Then
            dia = 31
            salida = "el mes contiene: " + dia.ToString + " días"
        Else
            dia = 30
            salida = "el mes contiene: " + dia.ToString + " días"
        End If
        MessageBox.Show(salida)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'Escriure un programa que escrigui la suma dels n primers nombres parells,
        'considerant que el primer nombre parell és el 2. Podeu suposar que n és sempre més
        'gran o igual que 0. Si n val 0, el programa ha d'escriure també 0. El valor de n és
        'introduït per teclat. Heu d'escriure tres versions diferents del programa, utilitzant les
        'tres estructures iteratives del C: While ... , do ... while, for ...
        Dim n, cnt, suma As Integer
        Dim salida As String = ""
        n = InputBox("Introduce un número")
        If n = 0 Then
            MessageBox.Show(" 0")

        End If
        For cnt = 0 To n Step 2
            suma = suma + cnt
            salida += suma.ToString
        Next
        MessageBox.Show(salida)




    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'Escriure un programa que escrigui la suma dels n primers nombres parells,
        'considerant que el primer nombre parell és el 2. Podeu suposar que n és sempre més
        'gran o igual que 0. Si n val 0, el programa ha d'escriure també 0. El valor de n és
        'introduït per teclat. Heu d'escriure tres versions diferents del programa, utilitzant les
        'tres estructures iteratives del C: While ... , do ... while, for ...
        Dim n, cnt, par, suma As Integer
        Dim salida As String = ""
        n = InputBox("Introduce un número")
        If n = 0 Then
            MessageBox.Show(" 0")

        End If
        par = 2
        For cnt = 0 To n Step 2
            suma += cnt
            salida = (suma + " " + cnt.ToString + "= " + suma.ToString)

        Next
        MessageBox.Show(salida)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'Mostra el factorial d'un número introduït per teclat
        Dim factorial, num, cnt As Integer
        Dim salida As String = ""
        num = InputBox("Introduce un número: ")
        factorial = 1
        For cnt = 1 To num
            factorial = factorial * cnt
            MessageBox.Show(factorial.ToString)
        Next


    End Sub
End Class