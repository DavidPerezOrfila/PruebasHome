Public Class Fruteria
    Dim platanos As Double = 40
    Dim manzanas As Double = 50
    Dim peras As Double = 60
    Dim precio, cambio, total As Double
    Const ekplatano As Double = 7.1
    Const ekmanzana As Double = 4.9
    Const ekpera As Double = 6.2


    Private Sub Stockpla_TextChanged(sender As Object, e As EventArgs) Handles Stockpla.TextChanged
        platanos = CDbl(Stockpla.Text)

    End Sub

    Private Sub Stockman_TextChanged(sender As Object, e As EventArgs) Handles Stockman.TextChanged
        manzanas = CDbl(Stockman.Text)

    End Sub

    Private Sub Stockper_TextChanged(sender As Object, e As EventArgs) Handles Stockper.TextChanged
        peras = CDbl(Stockper.Text)

    End Sub

    Private Sub PrecioCom_TextChanged(sender As Object, e As EventArgs) Handles PrecioCom.TextChanged
        precio = CDbl(PrecioCom.Text)

    End Sub

    Private Sub pagado_TextChanged(sender As Object, e As EventArgs) Handles pagado.TextChanged
        Cambiopagado.Text = FormatNumber(CDbl(Val(pagado.Text) - Val(PrecioCom.Text)), 2)
    End Sub

    Private Sub Preciopla_TextChanged(sender As Object, e As EventArgs) Handles Preciopla.TextChanged

    End Sub

    Private Sub Precioman_TextChanged(sender As Object, e As EventArgs) Handles Precioman.TextChanged

    End Sub

    Private Sub Precioper_TextChanged(sender As Object, e As EventArgs) Handles Precioper.TextChanged

    End Sub

    Private Sub Comprapla_TextChanged(sender As Object, e As EventArgs) Handles Comprapla.TextChanged
        Stockpla.Text = CDbl(Val(Stockpla.Text) - Val(Comprapla.Text))
        PrecioCom.Text = FormatNumber(CDbl(Val(Preciopla.Text) * Val(Comprapla.Text)), 2)
        If Stockpla.Text <= 0 Then
            MessageBox.Show("No hay suficiente stock!!!")
            Return
        End If
    End Sub

    Private Sub Compraman_TextChanged(sender As Object, e As EventArgs) Handles Compraman.TextChanged
        Stockman.Text = Val(Stockman.Text) - Val(Compraman.Text)
        PrecioCom.Text = FormatNumber(CDbl(Val(Precioman.Text) * Val(Compraman.Text)), 2)
        If Stockman.Text <= 0 Then
            MessageBox.Show("No hay suficiente stock!!!")
            Return
        End If
    End Sub

    Private Sub Compraper_TextChanged(sender As Object, e As EventArgs) Handles Compraper.TextChanged
        Stockper.Text = Val(Stockper.Text) - Val(Compraper.Text)
        PrecioCom.Text = FormatNumber(CDbl(Val(Precioper.Text) * Val(Compraper.Text)), 2)
        If Stockper.Text <= 0 Then
            MessageBox.Show("No hay suficiente stock!!!")
            Return
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Comprapla.Text = 0
        Compraman.Text = 0
        Compraper.Text = 0

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Cambiopagado_TextChanged(sender As Object, e As EventArgs) Handles Cambiopagado.TextChanged

    End Sub

    Private Sub TotalC_TextChanged(sender As Object, e As EventArgs) Handles TotalC.TextChanged

    End Sub

    Private Sub Fruteria_Load(sender As Object, e As EventArgs) Handles Me.Load
        Stockpla.Text = platanos
        Stockman.Text = manzanas
        Stockper.Text = peras
        Precioper.Text = ekpera
        Preciopla.Text = ekplatano
        Precioman.Text = ekmanzana
        Comprapla.Text = 0
        Compraman.Text = 0
        Compraper.Text = 0
    End Sub
End Class