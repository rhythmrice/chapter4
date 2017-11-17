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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUserAgeInput = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.ButtonInsult = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(168, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input Age"
        '
        'txtUserAgeInput
        '
        Me.txtUserAgeInput.Location = New System.Drawing.Point(272, 88)
        Me.txtUserAgeInput.Name = "txtUserAgeInput"
        Me.txtUserAgeInput.Size = New System.Drawing.Size(100, 20)
        Me.txtUserAgeInput.TabIndex = 1
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(48, 138)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(426, 39)
        Me.lblResult.TabIndex = 2
        '
        'ButtonInsult
        '
        Me.ButtonInsult.Location = New System.Drawing.Point(79, 306)
        Me.ButtonInsult.Name = "ButtonInsult"
        Me.ButtonInsult.Size = New System.Drawing.Size(75, 23)
        Me.ButtonInsult.TabIndex = 3
        Me.ButtonInsult.Text = "Insult"
        Me.ButtonInsult.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(250, 306)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClear.TabIndex = 4
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(416, 305)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonExit.TabIndex = 5
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 459)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonInsult)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtUserAgeInput)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUserAgeInput As System.Windows.Forms.TextBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents ButtonInsult As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents ButtonExit As System.Windows.Forms.Button

End Class
