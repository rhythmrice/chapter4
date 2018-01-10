<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Tbox1 = New System.Windows.Forms.TextBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Tbox1
        '
        Me.Tbox1.Location = New System.Drawing.Point(161, 93)
        Me.Tbox1.Name = "Tbox1"
        Me.Tbox1.Size = New System.Drawing.Size(305, 20)
        Me.Tbox1.TabIndex = 0
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(248, 163)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(136, 23)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "Get Horoscope"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(12, 249)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(0, 13)
        Me.lbl3.TabIndex = 2
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(245, 37)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(143, 13)
        Me.lbl1.TabIndex = 3
        Me.lbl1.Text = "Enter your horoscope symbol"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 435)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.Tbox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tbox1 As System.Windows.Forms.TextBox
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label

End Class
