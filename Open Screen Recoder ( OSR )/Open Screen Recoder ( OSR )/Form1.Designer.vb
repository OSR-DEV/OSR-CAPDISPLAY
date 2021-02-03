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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.startpreview = New System.Windows.Forms.Button()
        Me.stoppreview = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.PR = New System.Windows.Forms.PictureBox()
        CType(Me.PR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.Window
        Me.ListBox1.Enabled = False
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Items.AddRange(New Object() {"Capture Screen"})
        Me.ListBox1.Location = New System.Drawing.Point(2, -1)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(113, 79)
        Me.ListBox1.TabIndex = 3
        '
        'startpreview
        '
        Me.startpreview.BackColor = System.Drawing.SystemColors.Control
        Me.startpreview.Location = New System.Drawing.Point(12, 18)
        Me.startpreview.Name = "startpreview"
        Me.startpreview.Size = New System.Drawing.Size(88, 23)
        Me.startpreview.TabIndex = 4
        Me.startpreview.Text = "Start Capture Screen"
        Me.startpreview.UseVisualStyleBackColor = False
        '
        'stoppreview
        '
        Me.stoppreview.BackColor = System.Drawing.SystemColors.Control
        Me.stoppreview.Location = New System.Drawing.Point(12, 47)
        Me.stoppreview.Name = "stoppreview"
        Me.stoppreview.Size = New System.Drawing.Size(88, 23)
        Me.stoppreview.TabIndex = 5
        Me.stoppreview.Text = "Stop Capture Screen"
        Me.stoppreview.UseVisualStyleBackColor = False
        '
        'Timer
        '
        '
        'PR
        '
        Me.PR.Location = New System.Drawing.Point(107, 18)
        Me.PR.Name = "PR"
        Me.PR.Size = New System.Drawing.Size(100, 50)
        Me.PR.TabIndex = 6
        Me.PR.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(120, 73)
        Me.Controls.Add(Me.PR)
        Me.Controls.Add(Me.stoppreview)
        Me.Controls.Add(Me.startpreview)
        Me.Controls.Add(Me.ListBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form1"
        Me.Text = "OSR Studio"
        CType(Me.PR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents startpreview As Button
    Friend WithEvents stoppreview As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents PR As PictureBox
End Class
