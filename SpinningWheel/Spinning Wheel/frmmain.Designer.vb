<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmmain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cmdDraw = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.txtAddItem = New System.Windows.Forms.TextBox()
        Me.lstChoose = New System.Windows.Forms.ListBox()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdSpinOnly = New System.Windows.Forms.Button()
        Me.cmdSpinDelete = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.tmrSpin = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'cmdDraw
        '
        Me.cmdDraw.Location = New System.Drawing.Point(12, 308)
        Me.cmdDraw.Name = "cmdDraw"
        Me.cmdDraw.Size = New System.Drawing.Size(214, 32)
        Me.cmdDraw.TabIndex = 0
        Me.cmdDraw.Text = "Draw"
        Me.cmdDraw.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(178, 199)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(48, 32)
        Me.cmdAdd.TabIndex = 4
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'txtAddItem
        '
        Me.txtAddItem.Location = New System.Drawing.Point(12, 204)
        Me.txtAddItem.Name = "txtAddItem"
        Me.txtAddItem.Size = New System.Drawing.Size(160, 22)
        Me.txtAddItem.TabIndex = 5
        '
        'lstChoose
        '
        Me.lstChoose.FormattingEnabled = True
        Me.lstChoose.ItemHeight = 16
        Me.lstChoose.Items.AddRange(New Object() {"this", "is just ", "a tesitng", "script", "can", "already", "bye bye"})
        Me.lstChoose.Location = New System.Drawing.Point(12, 12)
        Me.lstChoose.Name = "lstChoose"
        Me.lstChoose.Size = New System.Drawing.Size(214, 180)
        Me.lstChoose.TabIndex = 6
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(12, 237)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(105, 32)
        Me.cmdDelete.TabIndex = 7
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdSpinOnly
        '
        Me.cmdSpinOnly.Location = New System.Drawing.Point(12, 374)
        Me.cmdSpinOnly.Name = "cmdSpinOnly"
        Me.cmdSpinOnly.Size = New System.Drawing.Size(214, 32)
        Me.cmdSpinOnly.TabIndex = 8
        Me.cmdSpinOnly.Text = "Spin Only"
        Me.cmdSpinOnly.UseVisualStyleBackColor = True
        '
        'cmdSpinDelete
        '
        Me.cmdSpinDelete.Location = New System.Drawing.Point(12, 412)
        Me.cmdSpinDelete.Name = "cmdSpinDelete"
        Me.cmdSpinDelete.Size = New System.Drawing.Size(214, 32)
        Me.cmdSpinDelete.TabIndex = 9
        Me.cmdSpinDelete.Text = "Spin Delete"
        Me.cmdSpinDelete.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(123, 237)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(103, 32)
        Me.cmdClear.TabIndex = 10
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'tmrSpin
        '
        Me.tmrSpin.Interval = 1000
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1597, 847)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdSpinDelete)
        Me.Controls.Add(Me.cmdSpinOnly)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.lstChoose)
        Me.Controls.Add(Me.txtAddItem)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdDraw)
        Me.Name = "frmmain"
        Me.Text = "Spinning Wheel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdDraw As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents txtAddItem As TextBox
    Friend WithEvents lstChoose As ListBox
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdSpinOnly As Button
    Friend WithEvents cmdSpinDelete As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents tmrSpin As Timer
End Class
