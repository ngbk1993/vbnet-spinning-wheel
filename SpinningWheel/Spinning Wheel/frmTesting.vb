Public Class frmTesting
    'This form is for testing purposes, changing the angle and position realtime to understand how they move
    Public PI As Double = 3.141592654

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        DrawScreen()
    End Sub

    Public Sub DrawScreen()
        Dim midX As Integer
        Dim midY As Integer
        Dim X2 As Double
        Dim Y2 As Double
        Dim Xlbl As Double
        Dim Ylbl As Double
        Dim XName As Double
        Dim YName As Double
        Dim I As Integer
        Dim Radius As Integer
        Dim TotalItem As Integer
        Dim theAngle As Integer

        On Error Resume Next

        midX = Me.Width / 2
        midY = Me.Height / 2

        Radius = (IIf(Me.Width > Me.Height, Me.Height, Me.Width) / 2) - 70
        TotalItem = CInt(txtTotal.Text)
        theAngle = CInt(txtAng.Text)
        Dim TextRadius = CInt(txtRadius.Text)
        Dim surface As Graphics = CreateGraphics()
        Dim pen1 As Pen = New Pen(Color.Black, 2)

        Dim rectangle2 As Rectangle
        rectangle2 = New Rectangle(midX - Radius, midY - Radius, Radius * 2, Radius * 2)

        surface.Clear(Me.BackColor)
        surface.DrawEllipse(pen1, rectangle2)

        Dim lblSelectILoop = Me.Controls.OfType(Of Label)
        For Each lblSelectI As Label In lblSelectILoop
            If lblSelectI.Tag = "lblSelectN" Then
                lblSelectI.Invalidate()
                Controls.Remove(lblSelectI)
            End If
        Next

        For I = 0 To TotalItem - 1
            Dim lblSelectN As Label = New Label()
            Dim Rad As Double
            Rad = (360 / TotalItem)
            X2 = midX + (Radius * Math.Sin(I * Rad * PI / 180))
            Y2 = midY + (Radius * Math.Cos(I * Rad * PI / 180))

            Xlbl = midX + ((Radius + 25) * Math.Sin(((I * Rad) + (Rad / 2)) * PI / 180))
            Ylbl = midY + ((Radius + 25) * Math.Cos(((I * Rad) + (Rad / 2)) * PI / 180))

            XName = midX + CInt(txtOfstX.Text) + ((TextRadius) * Math.Sin(((I * Rad) + (Rad / 2)) * PI / 180))
            YName = midY + CInt(txtOfstY.Text) + ((TextRadius) * Math.Cos(((I * Rad) + (Rad / 2)) * PI / 180))

            surface.DrawLine(pen1, midX, midY, CInt(X2), CInt(Y2))

            'Draw Text
            Dim theFontSize As Integer = 20
            Dim thefont As Font = New Font("Segoe UI", theFontSize)

            DrawRotateText(Me.CreateGraphics(), theAngle, "This is a testing", XName, YName, thefont, Brushes.Blue)
        Next

    End Sub
    Public Sub DrawRotateText(ByVal gr As Graphics, ByVal angle As Decimal, ByVal txt As String, ByVal x As Integer, ByVal y As Integer, ByVal thefont As Font, ByVal thebrush As Brush)

        gr.ResetTransform()
        gr.RotateTransform(angle)
        gr.TranslateTransform(x, y, Drawing2D.MatrixOrder.Append)
        gr.DrawString(txt, thefont, thebrush, 0, 0)

    End Sub
    Private Sub txtAng_TextChanged(sender As Object, e As EventArgs) Handles txtAng.TextChanged
        DrawScreen()
    End Sub

    Private Sub txtRadius_TextChanged(sender As Object, e As EventArgs) Handles txtRadius.TextChanged
        DrawScreen()
    End Sub

    Private Sub txtOfstY_TextChanged(sender As Object, e As EventArgs) Handles txtOfstY.TextChanged
        DrawScreen()
    End Sub

    Private Sub txtOfstX_TextChanged(sender As Object, e As EventArgs) Handles txtOfstX.TextChanged
        DrawScreen()
    End Sub

    Private Sub frmTesting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class