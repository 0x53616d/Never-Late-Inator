<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtype = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.helpbutton = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.grammadd = New System.Windows.Forms.Button()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Day Type"
        '
        'dtype
        '
        Me.dtype.AccessibleDescription = "Determines what periods to open"
        Me.dtype.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.dtype.Location = New System.Drawing.Point(13, 13)
        Me.dtype.Name = "dtype"
        Me.dtype.Size = New System.Drawing.Size(148, 20)
        Me.dtype.TabIndex = 0
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(167, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 22)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Check Day Type"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'helpbutton
        '
        Me.helpbutton.Location = New System.Drawing.Point(328, 12)
        Me.helpbutton.Name = "helpbutton"
        Me.helpbutton.Size = New System.Drawing.Size(110, 22)
        Me.helpbutton.TabIndex = 2
        Me.helpbutton.Text = "Settings"
        Me.helpbutton.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(444, 15)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(98, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Always On Top"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(548, 15)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(103, 17)
        Me.CheckBox2.TabIndex = 5
        Me.CheckBox2.Text = "Listen For Name"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'grammadd
        '
        Me.grammadd.Location = New System.Drawing.Point(1187, 11)
        Me.grammadd.Name = "grammadd"
        Me.grammadd.Size = New System.Drawing.Size(110, 22)
        Me.grammadd.TabIndex = 6
        Me.grammadd.Text = "emulate add gram"
        Me.grammadd.UseVisualStyleBackColor = True
        '
        'Timer3
        '
        Me.Timer3.Interval = 500
        '
        'Timer4
        '
        Me.Timer4.Interval = 500
        '
        'Timer5
        '
        Me.Timer5.Enabled = True
        Me.Timer5.Interval = 500
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(657, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 22)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Lag"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 43)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.grammadd)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.helpbutton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtype)
        Me.Name = "Form1"
        Me.Text = "Never-Late-Inator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents dtype As TextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents helpbutton As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents grammadd As Button
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Button2 As Button
End Class