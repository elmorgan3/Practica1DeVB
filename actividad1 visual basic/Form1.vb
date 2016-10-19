Public Class Form1
    Private numeroX As String
    Private numeroY As String
    Private numero2X As String
    Private numero2Y As String
    Private boton As String

    Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles MyBase.DoubleClick

        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If

    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Me.Text = "El ancho es " & Me.Width & " y la altura " & Me.Height

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp


        If e.KeyCode = Keys.Escape Then
            Me.Text = ""
        End If
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

        If UCase(e.KeyChar) = Chr(Keys.I) Or UCase(e.KeyChar) = Chr(Keys.Enter) Or UCase(e.KeyChar) = Chr(Keys.Return) Then

            Me.Text = StrReverse(Me.Text)

        Else
            Me.Text = Me.Text + e.KeyChar
        End If
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        numeroX = e.X
        numeroY = e.Y

    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        numero2X = e.X
        numero2Y = e.Y
        If e.Button = Windows.Forms.MouseButtons.Right Then
            boton = "derecha"
        Else
            boton = "izquierda"
        End If

        Me.Text = "La linea empieza en las cordenadas X:" & numeroX & " y Y: " & numeroY & " y termina en las cordenadas X: " & numero2X & " y la Y: " & numero2Y & ". Se a pulsado con la tecla " & boton

        Dim Lineas As Graphics = Me.CreateGraphics
        Dim colorLapiz As New Pen(Color.Black, 3)

        Dim inicio As New Point(numeroX, numeroY)
        Dim fin As New Point(numero2X, numero2Y)

        Lineas.DrawLine(colorLapiz, inicio, fin)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Hola mother fuckers"
    End Sub

    ' Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
    ' Static last As New Point
    '    If e.Button = Windows.Forms.MouseButtons.Left Then
    '        Me.CreateGraphics.DrawLine(Pens.Black, last.X, last.Y, e.X, e.Y)

    '    End If
    '    last = e.Location
    ' End Sub

End Class

