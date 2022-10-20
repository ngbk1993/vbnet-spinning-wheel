<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTesting
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtAng = New System.Windows.Forms.TextBox()
        Me.txtRadius = New System.Windows.Forms.TextBox()
        Me.txtOfstX = New System.Windows.Forms.TextBox()
        Me.txtOfstY = New System.Windows.Forms.TextBox()
        Me.lblTotalSegment = New System.Windows.Forms.Label()
        Me.lblOfstX = New System.Windows.Forms.Label()
        Me.lblOfstY = New System.Windows.Forms.Label()
        Me.lblRadius = New System.Windows.Forms.Label()
        Me.lblAngle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(165, 12)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 22)
        Me.txtTotal.TabIndex = 0
        Me.txtTotal.Text = "10"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txtAng
        '
        Me.txtAng.Location = New System.Drawing.Point(165, 162)
        Me.txtAng.Name = "txtAng"
        Me.txtAng.Size = New System.Drawing.Size(100, 22)
        Me.txtAng.TabIndex = 3
        Me.txtAng.Text = "2"
        '
        'txtRadius
        '
        Me.txtRadius.Location = New System.Drawing.Point(165, 134)
        Me.txtRadius.Name = "txtRadius"
        Me.txtRadius.Size = New System.Drawing.Size(100, 22)
        Me.txtRadius.TabIndex = 5
        Me.txtRadius.Text = "2"
        '
        'txtOfstX
        '
        Me.txtOfstX.Location = New System.Drawing.Point(165, 50)
        Me.txtOfstX.Name = "txtOfstX"
        Me.txtOfstX.Size = New System.Drawing.Size(100, 22)
        Me.txtOfstX.TabIndex = 6
        Me.txtOfstX.Text = "2"
        '
        'txtOfstY
        '
        Me.txtOfstY.Location = New System.Drawing.Point(165, 78)
        Me.txtOfstY.Name = "txtOfstY"
        Me.txtOfstY.Size = New System.Drawing.Size(100, 22)
        Me.txtOfstY.TabIndex = 7
        Me.txtOfstY.Text = "2"
        '
        'lblTotalSegment
        '
        Me.lblTotalSegment.AutoSize = True
        Me.lblTotalSegment.Location = New System.Drawing.Point(12, 15)
        Me.lblTotalSegment.Name = "lblTotalSegment"
        Me.lblTotalSegment.Size = New System.Drawing.Size(137, 17)
        Me.lblTotalSegment.TabIndex = 8
        Me.lblTotalSegment.Text = "Number Of Segment"
        '
        'lblOfstX
        '
        Me.lblOfstX.AutoSize = True
        Me.lblOfstX.Location = New System.Drawing.Point(12, 50)
        Me.lblOfstX.Name = "lblOfstX"
        Me.lblOfstX.Size = New System.Drawing.Size(101, 21)
        Me.lblOfstX.TabIndex = 9
        Me.lblOfstX.Text = "Offset MidX"
        '
        'lblOfstY
        '
        Me.lblOfstY.AutoSize = True
        Me.lblOfstY.Location = New System.Drawing.Point(12, 81)
        Me.lblOfstY.Name = "lblOfstY"
        Me.lblOfstY.Size = New System.Drawing.Size(81, 17)
        Me.lblOfstY.TabIndex = 10
        Me.lblOfstY.Text = "Offset MidY"
        '
        'lblRadius
        '
        Me.lblRadius.AutoSize = True
        Me.lblRadius.Location = New System.Drawing.Point(12, 137)
        Me.lblRadius.Name = "lblRadius"
        Me.lblRadius.Size = New System.Drawing.Size(65, 21)
        Me.lblRadius.TabIndex = 11
        Me.lblRadius.Text = "Radius"
        '
        'lblAngle
        '
        Me.lblAngle.AutoSize = True
        Me.lblAngle.Location = New System.Drawing.Point(12, 165)
        Me.lblAngle.Name = "lblAngle"
        Me.lblAngle.Size = New System.Drawing.Size(55, 21)
        Me.lblAngle.TabIndex = 12
        Me.lblAngle.Text = "Angle"
        '
        'frmTesting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 751)
        Me.Controls.Add(Me.lblAngle)
        Me.Controls.Add(Me.lblRadius)
        Me.Controls.Add(Me.lblOfstY)
        Me.Controls.Add(Me.lblOfstX)
        Me.Controls.Add(Me.lblTotalSegment)
        Me.Controls.Add(Me.txtOfstY)
        Me.Controls.Add(Me.txtOfstX)
        Me.Controls.Add(Me.txtRadius)
        Me.Controls.Add(Me.txtAng)
        Me.Controls.Add(Me.txtTotal)
        Me.Name = "frmTesting"
        Me.Text = "frmTesting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTotal As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtAng As TextBox
    Friend WithEvents txtRadius As TextBox
    Friend WithEvents txtOfstX As TextBox
    Friend WithEvents txtOfstY As TextBox
    Friend WithEvents lblTotalSegment As Label
    Friend WithEvents lblOfstX As Label
    Friend WithEvents lblOfstY As Label
    Friend WithEvents lblRadius As Label
    Friend WithEvents lblAngle As Label
End Class
