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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxsalary = New System.Windows.Forms.TextBox()
        Me.TextBoxyears = New System.Windows.Forms.TextBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.ButtonCheck = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxyears)
        Me.GroupBox1.Controls.Add(Me.TextBoxsalary)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(81, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 131)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter the following information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(107, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Annual Salary"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of years at your current job"
        '
        'TextBoxsalary
        '
        Me.TextBoxsalary.Location = New System.Drawing.Point(224, 49)
        Me.TextBoxsalary.Name = "TextBoxsalary"
        Me.TextBoxsalary.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxsalary.TabIndex = 2
        '
        'TextBoxyears
        '
        Me.TextBoxyears.Location = New System.Drawing.Point(224, 91)
        Me.TextBoxyears.Name = "TextBoxyears"
        Me.TextBoxyears.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxyears.TabIndex = 3
        '
        'lblMessage
        '
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessage.Location = New System.Drawing.Point(81, 203)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(390, 23)
        Me.lblMessage.TabIndex = 1
        '
        'ButtonCheck
        '
        Me.ButtonCheck.Location = New System.Drawing.Point(81, 294)
        Me.ButtonCheck.Name = "ButtonCheck"
        Me.ButtonCheck.Size = New System.Drawing.Size(75, 42)
        Me.ButtonCheck.TabIndex = 2
        Me.ButtonCheck.Text = "Check Qualifications"
        Me.ButtonCheck.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(246, 294)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClear.TabIndex = 3
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(395, 294)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonExit.TabIndex = 4
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 397)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonCheck)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxyears As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxsalary As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents ButtonCheck As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents ButtonExit As System.Windows.Forms.Button

End Class
