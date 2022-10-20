Public Class frmmain
    Public PI As Double = 3.141592654
    Public Inc As Integer
    Public SpinDelete As Boolean
    Private Sub cmdDraw_Click(sender As Object, e As EventArgs) Handles cmdDraw.Click

        Dim midX As Integer         'Mid point of the window
        Dim midY As Integer         'Mid point of the window

        Dim X2 As Double            'X2 of the lines. X1 is midX
        Dim Y2 As Double            'Y2 of the lines. Y1 is midY

        Dim Xlbl As Double          'X position of the indicator label
        Dim Ylbl As Double          'Y position of the indicator label

        Dim XName As Double         'X position of the name from the list
        Dim YName As Double         'Y position of the name from the list
        Dim theAngle As Integer     'Angle of name from the list

        Dim I As Integer            'I for looping purposes
        Dim Radius As Integer       'Radius of the circle
        Dim TotalItem As Integer    'Number of the total items from the list


        '#############################
        '## Initializing the Value  ##
        '#############################
        midX = Me.Width / 2     'Find mid point of the windows
        midY = Me.Height / 2    'Find mid point of the windows
        theAngle = 90           'The placement of the text need to be start at align with 90 degree (get From Experiment)

        Radius = (IIf(Me.Width > Me.Height, Me.Height, Me.Width) / 2) - 120     'This is to get the Radius based on the heigh or width, which ever the larger, minus with offset 120(get from experiment) is because need to leave some space for the indicator
        TotalItem = IIf(lstChoose.Items.Count > 1, lstChoose.Items.Count, 2)    'This is to get the total item from the list

        '#########################################
        '## To draw lines, label, text etc      ##
        '#########################################
        Dim surface As Graphics = CreateGraphics()      'Create a surface class
        Dim DrawingPen As Pen = New Pen(Color.Black, 2) 'Create a drawing pen with clor black and width 2 

        Dim CircleRect As Rectangle                     'Create a rectangle, well i'm not sure how vb draw a circle from rectangle
        CircleRect = New Rectangle(midX - Radius, midY - Radius, Radius * 2, Radius * 2)    'Drawing hte Rectangle

        surface.Clear(Me.BackColor)                     'Clear every drawing from the frmMain
        surface.DrawEllipse(DrawingPen, CircleRect)     'Draw the circle out

        '################################
        '## Delete existing Label      ##
        '################################
        'Label is used here to easily change the color later.

        Dim lblSelectILoop = Me.Controls.OfType(Of Label)
        For I = 0 To 10
            'Loops few times makesure all Labels is deleted 
            For Each lblSelectI As Label In lblSelectILoop
                If lblSelectI.Tag = "lblSelectN" Then   'Delete only label with lblSelectN tagging
                    lblSelectI.Invalidate()
                    Controls.Remove(lblSelectI)         'Delete the label
                End If
            Next
        Next

        For I = 0 To TotalItem - 1
            'Create new Label Object
            Dim lblSelectN As Label = New Label()

            'Get the steps of each item by dividing 360 degree
            Dim Rad As Double
            Rad = (360 / TotalItem)

            '###################################
            '## Draw the lines                ##
            '###################################
            'Some math, drop me email if you want further explaination or you can google for trigonometry
            X2 = midX + (Radius * Math.Sin(I * Rad * PI / 180))
            Y2 = midY + (Radius * Math.Cos(I * Rad * PI / 180))

            surface.DrawLine(DrawingPen, midX, midY, CInt(X2), CInt(Y2))

            '###################################
            '## Draw the indicator label      ##
            '###################################
            'Some math, drop me email if you want further explaination or you can google for trigonometry
            Xlbl = midX + ((Radius + 25) * Math.Sin(((I * Rad) + (Rad / 2)) * PI / 180))
            Ylbl = midY + ((Radius + 25) * Math.Cos(((I * Rad) + (Rad / 2)) * PI / 180))

            lblSelectN.Tag = "lblSelectN"
            lblSelectN.Width = 38
            lblSelectN.Height = 38
            lblSelectN.Location = New Point(CInt(Xlbl - (lblSelectN.Width / 2)), CInt(Ylbl - (lblSelectN.Height / 2)))
            lblSelectN.Text = "O"
            lblSelectN.TextAlign = ContentAlignment.MiddleCenter
            lblSelectN.Name = "lblSelectN" & CStr(I)
            lblSelectN.Font = New Font("Georgia", 30, FontStyle.Bold)
            Controls.Add(lblSelectN)

            '###################################
            '## Draw the name from the list   ##
            '###################################
            'Some math, drop me email if you want further explaination or you can google for trigonometry
            XName = midX + ((Radius / (TotalItem / 5)) * Math.Sin(((I * Rad) + (Rad / 2)) * PI / 180))
            YName = midY + ((Radius / (TotalItem / 5)) * Math.Cos(((I * Rad) + (Rad / 2)) * PI / 180))

            Dim theFontSize As Integer = 20
            Dim thefont As Font = New Font("Segoe UI", theFontSize)
            DrawRotateText(Me.CreateGraphics(), theAngle, lstChoose.Items(I).ToString, XName, YName, thefont, Brushes.Blue)
            theAngle = theAngle - Rad
        Next

    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        lstChoose.Items.Add(txtAddItem.Text)    'Add item to the list
        txtAddItem.Text = ""                    'After add clear the text box
        txtAddItem.Select()                     'Trying to more user friendly, slect the text box after add :)
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        On Error GoTo err
        lstChoose.Items.RemoveAt(lstChoose.SelectedIndex) 'Delete the item from the list. Some error handling incase someone did not selected the item properly
err:
    End Sub
    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click

        Dim surface As Graphics = CreateGraphics()
        lstChoose.Items.Clear()

        Dim lblSelectILoop = Me.Controls.OfType(Of Label)
        For Each lblSelectI As Label In lblSelectILoop
            If lblSelectI.Tag = "lblSelectN" Then
                lblSelectI.Invalidate()
                Controls.Remove(lblSelectI)
            End If
        Next

        surface.Clear(Me.BackColor)

    End Sub

    Private Sub cmdSpinOnly_Click(sender As Object, e As EventArgs) Handles cmdSpinOnly.Click
        tmrSpin.Interval = 1
        tmrSpin.Enabled = True
    End Sub

    Private Sub tmrSpin_Tick(sender As Object, e As EventArgs) Handles tmrSpin.Tick
        Dim TotalItem As Integer
        Dim II As Integer

        TotalItem = IIf(lstChoose.Items.Count > 1, lstChoose.Items.Count, 2)
        Inc = Inc + 1

        If Inc >= TotalItem Then
            Inc = 0
        End If

        Dim LblSelectN As Label = Nothing
        Dim controlsArray() As Control

        For II = 0 To TotalItem - 1
            controlsArray = Me.Controls.Find("lblSelectN" & CStr(II), False)
            If controlsArray.Count > 0 Then LblSelectN = CType(controlsArray(0), Label)
            LblSelectN.ForeColor = Color.Black
        Next

        controlsArray = Me.Controls.Find("lblSelectN" & CStr(Inc), False)
        If controlsArray.Count > 0 Then LblSelectN = CType(controlsArray(0), Label)
        LblSelectN.ForeColor = Color.Red

        'Spining Algo
        If tmrSpin.Interval < 100 Then
            tmrSpin.Interval = tmrSpin.Interval + Int(Rnd() * 10)
        ElseIf tmrSpin.Interval > 100 And tmrSpin.Interval < 500 Then
            tmrSpin.Interval = tmrSpin.Interval + Int(Rnd() * 200)
        ElseIf tmrSpin.Interval > 500 And tmrSpin.Interval < 1000 Then
            tmrSpin.Interval = tmrSpin.Interval + Int(Rnd() * 200)
        Else
            tmrSpin.Interval = tmrSpin.Interval + Int(Rnd() * 300)
        End If

        If tmrSpin.Interval > 1000 Then
            tmrSpin.Enabled = False
        End If

    End Sub

    Public Sub DrawRotateText(ByVal gr As Graphics, ByVal angle As Decimal, ByVal txt As String, ByVal x As Integer, ByVal y As Integer, ByVal thefont As Font, ByVal thebrush As Brush)

        gr.ResetTransform()
        gr.RotateTransform(angle)
        gr.TranslateTransform(x, y, Drawing2D.MatrixOrder.Append)
        gr.DrawString(txt, thefont, thebrush, 0, 0)

    End Sub

    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdSpinDelete_Click(sender As Object, e As EventArgs) Handles cmdSpinDelete.Click

    End Sub
End Class
