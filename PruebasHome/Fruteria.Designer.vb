<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fruteria
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PrecioCom = New System.Windows.Forms.TextBox()
        Me.Stockpla = New System.Windows.Forms.TextBox()
        Me.Stockman = New System.Windows.Forms.TextBox()
        Me.Stockper = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Preciopla = New System.Windows.Forms.TextBox()
        Me.Precioman = New System.Windows.Forms.TextBox()
        Me.Precioper = New System.Windows.Forms.TextBox()
        Me.Comprapla = New System.Windows.Forms.TextBox()
        Me.Compraman = New System.Windows.Forms.TextBox()
        Me.Compraper = New System.Windows.Forms.TextBox()
        Me.pagado = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Cambiopagado = New System.Windows.Forms.TextBox()
        Me.TotalC = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PrecioCom
        '
        Me.PrecioCom.Location = New System.Drawing.Point(130, 211)
        Me.PrecioCom.Name = "PrecioCom"
        Me.PrecioCom.Size = New System.Drawing.Size(100, 22)
        Me.PrecioCom.TabIndex = 0
        '
        'Stockpla
        '
        Me.Stockpla.Location = New System.Drawing.Point(130, 75)
        Me.Stockpla.Name = "Stockpla"
        Me.Stockpla.Size = New System.Drawing.Size(100, 22)
        Me.Stockpla.TabIndex = 1
        '
        'Stockman
        '
        Me.Stockman.Location = New System.Drawing.Point(130, 120)
        Me.Stockman.Name = "Stockman"
        Me.Stockman.Size = New System.Drawing.Size(100, 22)
        Me.Stockman.TabIndex = 2
        '
        'Stockper
        '
        Me.Stockper.Location = New System.Drawing.Point(130, 161)
        Me.Stockper.Name = "Stockper"
        Me.Stockper.Size = New System.Drawing.Size(100, 22)
        Me.Stockper.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Platanos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Manzanas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Peras"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Precio Compra"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(156, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Stock"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(303, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "€/Kilo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(459, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Kilo Compra"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 309)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Pagado"
        '
        'Preciopla
        '
        Me.Preciopla.Location = New System.Drawing.Point(287, 73)
        Me.Preciopla.Name = "Preciopla"
        Me.Preciopla.Size = New System.Drawing.Size(100, 22)
        Me.Preciopla.TabIndex = 12
        '
        'Precioman
        '
        Me.Precioman.Location = New System.Drawing.Point(287, 120)
        Me.Precioman.Name = "Precioman"
        Me.Precioman.Size = New System.Drawing.Size(100, 22)
        Me.Precioman.TabIndex = 13
        '
        'Precioper
        '
        Me.Precioper.Location = New System.Drawing.Point(287, 161)
        Me.Precioper.Name = "Precioper"
        Me.Precioper.Size = New System.Drawing.Size(100, 22)
        Me.Precioper.TabIndex = 14
        '
        'Comprapla
        '
        Me.Comprapla.Location = New System.Drawing.Point(453, 73)
        Me.Comprapla.Name = "Comprapla"
        Me.Comprapla.Size = New System.Drawing.Size(100, 22)
        Me.Comprapla.TabIndex = 16
        '
        'Compraman
        '
        Me.Compraman.Location = New System.Drawing.Point(453, 120)
        Me.Compraman.Name = "Compraman"
        Me.Compraman.Size = New System.Drawing.Size(100, 22)
        Me.Compraman.TabIndex = 17
        '
        'Compraper
        '
        Me.Compraper.Location = New System.Drawing.Point(453, 161)
        Me.Compraper.Name = "Compraper"
        Me.Compraper.Size = New System.Drawing.Size(100, 22)
        Me.Compraper.TabIndex = 18
        '
        'pagado
        '
        Me.pagado.Location = New System.Drawing.Point(130, 306)
        Me.pagado.Name = "pagado"
        Me.pagado.Size = New System.Drawing.Size(100, 22)
        Me.pagado.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 358)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Cambio"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 415)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Total Caja"
        '
        'Cambiopagado
        '
        Me.Cambiopagado.Location = New System.Drawing.Point(130, 358)
        Me.Cambiopagado.Name = "Cambiopagado"
        Me.Cambiopagado.Size = New System.Drawing.Size(100, 22)
        Me.Cambiopagado.TabIndex = 23
        '
        'TotalC
        '
        Me.TotalC.Location = New System.Drawing.Point(130, 412)
        Me.TotalC.Name = "TotalC"
        Me.TotalC.Size = New System.Drawing.Size(100, 22)
        Me.TotalC.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(420, 306)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 44)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Nueva compra"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(420, 390)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 44)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Fruteria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 492)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TotalC)
        Me.Controls.Add(Me.Cambiopagado)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.pagado)
        Me.Controls.Add(Me.Compraper)
        Me.Controls.Add(Me.Compraman)
        Me.Controls.Add(Me.Comprapla)
        Me.Controls.Add(Me.Precioper)
        Me.Controls.Add(Me.Precioman)
        Me.Controls.Add(Me.Preciopla)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Stockper)
        Me.Controls.Add(Me.Stockman)
        Me.Controls.Add(Me.Stockpla)
        Me.Controls.Add(Me.PrecioCom)
        Me.Name = "Fruteria"
        Me.Text = "Fruteria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrecioCom As TextBox
    Friend WithEvents Stockpla As TextBox
    Friend WithEvents Stockman As TextBox
    Friend WithEvents Stockper As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Preciopla As TextBox
    Friend WithEvents Precioman As TextBox
    Friend WithEvents Precioper As TextBox
    Friend WithEvents Comprapla As TextBox
    Friend WithEvents Compraman As TextBox
    Friend WithEvents Compraper As TextBox
    Friend WithEvents pagado As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Cambiopagado As TextBox
    Friend WithEvents TotalC As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
