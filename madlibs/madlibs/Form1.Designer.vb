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
        Me.ListBoxcolor = New System.Windows.Forms.ListBox()
        Me.ListBoxest = New System.Windows.Forms.ListBox()
        Me.ListBoxnumber = New System.Windows.Forms.ListBox()
        Me.ListBoxbodypart = New System.Windows.Forms.ListBox()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListBoxcolor
        '
        Me.ListBoxcolor.FormattingEnabled = True
        Me.ListBoxcolor.Items.AddRange(New Object() {"Blue", "Red", "Yellow", "Green", "Pink", "Black", "White", "Brown", "Orange", "Purple"})
        Me.ListBoxcolor.Location = New System.Drawing.Point(77, 92)
        Me.ListBoxcolor.Name = "ListBoxcolor"
        Me.ListBoxcolor.Size = New System.Drawing.Size(120, 95)
        Me.ListBoxcolor.TabIndex = 0
        '
        'ListBoxest
        '
        Me.ListBoxest.FormattingEnabled = True
        Me.ListBoxest.Items.AddRange(New Object() {"Happiest", "Saddest", "Dumbest", "Saddest", "roundest", "softest", "coolest", "nicest", "meanest", "greenest"})
        Me.ListBoxest.Location = New System.Drawing.Point(280, 92)
        Me.ListBoxest.Name = "ListBoxest"
        Me.ListBoxest.Size = New System.Drawing.Size(120, 95)
        Me.ListBoxest.TabIndex = 1
        '
        'ListBoxnumber
        '
        Me.ListBoxnumber.FormattingEnabled = True
        Me.ListBoxnumber.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "12"})
        Me.ListBoxnumber.Location = New System.Drawing.Point(508, 92)
        Me.ListBoxnumber.Name = "ListBoxnumber"
        Me.ListBoxnumber.Size = New System.Drawing.Size(120, 95)
        Me.ListBoxnumber.TabIndex = 2
        '
        'ListBoxbodypart
        '
        Me.ListBoxbodypart.FormattingEnabled = True
        Me.ListBoxbodypart.Location = New System.Drawing.Point(77, 238)
        Me.ListBoxbodypart.Name = "ListBoxbodypart"
        Me.ListBoxbodypart.Size = New System.Drawing.Size(120, 95)
        Me.ListBoxbodypart.TabIndex = 3
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.Location = New System.Drawing.Point(280, 238)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(120, 95)
        Me.ListBox5.TabIndex = 4
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(508, 238)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 5
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(77, 387)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 95)
        Me.ListBox2.TabIndex = 6
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(280, 387)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(120, 95)
        Me.ListBox3.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 516)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ListBox5)
        Me.Controls.Add(Me.ListBoxbodypart)
        Me.Controls.Add(Me.ListBoxnumber)
        Me.Controls.Add(Me.ListBoxest)
        Me.Controls.Add(Me.ListBoxcolor)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBoxcolor As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxest As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxnumber As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxbodypart As System.Windows.Forms.ListBox
    Friend WithEvents ListBox5 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox

End Class
