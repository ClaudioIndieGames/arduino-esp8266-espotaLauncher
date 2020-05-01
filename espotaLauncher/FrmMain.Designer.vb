<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.BtnLaunchSketch = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnLaunchSpiffs = New System.Windows.Forms.Button()
        Me.PnlTarget = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPort = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtIP = New System.Windows.Forms.TextBox()
        Me.PnlPaths = New System.Windows.Forms.Panel()
        Me.LblSpiffs = New System.Windows.Forms.Label()
        Me.TxtSpiffs = New System.Windows.Forms.TextBox()
        Me.BtnPathSpiffs = New System.Windows.Forms.Button()
        Me.LblSketch = New System.Windows.Forms.Label()
        Me.TxtSketch = New System.Windows.Forms.TextBox()
        Me.BtnPathSketch = New System.Windows.Forms.Button()
        Me.BtnPathEspota = New System.Windows.Forms.Button()
        Me.Lblespota = New System.Windows.Forms.Label()
        Me.TxtEspota = New System.Windows.Forms.TextBox()
        Me.BtnPathPython = New System.Windows.Forms.Button()
        Me.Lblpython = New System.Windows.Forms.Label()
        Me.TxtPython = New System.Windows.Forms.TextBox()
        Me.PnlButton = New System.Windows.Forms.Panel()
        Me.PnlOutput = New System.Windows.Forms.Panel()
        Me.TxtShellOutput = New System.Windows.Forms.TextBox()
        Me.PnlTarget.SuspendLayout()
        Me.PnlPaths.SuspendLayout()
        Me.PnlButton.SuspendLayout()
        Me.PnlOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnLaunchSketch
        '
        Me.BtnLaunchSketch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLaunchSketch.Location = New System.Drawing.Point(80, 25)
        Me.BtnLaunchSketch.Name = "BtnLaunchSketch"
        Me.BtnLaunchSketch.Size = New System.Drawing.Size(102, 71)
        Me.BtnLaunchSketch.TabIndex = 11
        Me.BtnLaunchSketch.Tag = "sketch"
        Me.BtnLaunchSketch.Text = "SKETCH"
        Me.BtnLaunchSketch.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnLaunchSpiffs
        '
        Me.BtnLaunchSpiffs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLaunchSpiffs.Location = New System.Drawing.Point(247, 25)
        Me.BtnLaunchSpiffs.Name = "BtnLaunchSpiffs"
        Me.BtnLaunchSpiffs.Size = New System.Drawing.Size(102, 71)
        Me.BtnLaunchSpiffs.TabIndex = 12
        Me.BtnLaunchSpiffs.Tag = "spiffs"
        Me.BtnLaunchSpiffs.Text = "SPIFFS"
        Me.BtnLaunchSpiffs.UseVisualStyleBackColor = True
        '
        'PnlTarget
        '
        Me.PnlTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlTarget.Controls.Add(Me.Label7)
        Me.PnlTarget.Controls.Add(Me.TxtPassword)
        Me.PnlTarget.Controls.Add(Me.Label6)
        Me.PnlTarget.Controls.Add(Me.TxtPort)
        Me.PnlTarget.Controls.Add(Me.Label5)
        Me.PnlTarget.Controls.Add(Me.TxtIP)
        Me.PnlTarget.Location = New System.Drawing.Point(12, 229)
        Me.PnlTarget.Name = "PnlTarget"
        Me.PnlTarget.Size = New System.Drawing.Size(438, 118)
        Me.PnlTarget.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(30, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(371, 18)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Password:"
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(31, 78)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(370, 20)
        Me.TxtPassword.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(246, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 18)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Port:"
        '
        'TxtPort
        '
        Me.TxtPort.Location = New System.Drawing.Point(248, 30)
        Me.TxtPort.Name = "TxtPort"
        Me.TxtPort.Size = New System.Drawing.Size(153, 20)
        Me.TxtPort.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(28, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 18)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "IP:"
        '
        'TxtIP
        '
        Me.TxtIP.Location = New System.Drawing.Point(30, 30)
        Me.TxtIP.Name = "TxtIP"
        Me.TxtIP.Size = New System.Drawing.Size(153, 20)
        Me.TxtIP.TabIndex = 8
        '
        'PnlPaths
        '
        Me.PnlPaths.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlPaths.Controls.Add(Me.LblSpiffs)
        Me.PnlPaths.Controls.Add(Me.TxtSpiffs)
        Me.PnlPaths.Controls.Add(Me.BtnPathSpiffs)
        Me.PnlPaths.Controls.Add(Me.LblSketch)
        Me.PnlPaths.Controls.Add(Me.TxtSketch)
        Me.PnlPaths.Controls.Add(Me.BtnPathSketch)
        Me.PnlPaths.Controls.Add(Me.BtnPathEspota)
        Me.PnlPaths.Controls.Add(Me.Lblespota)
        Me.PnlPaths.Controls.Add(Me.TxtEspota)
        Me.PnlPaths.Controls.Add(Me.BtnPathPython)
        Me.PnlPaths.Controls.Add(Me.Lblpython)
        Me.PnlPaths.Controls.Add(Me.TxtPython)
        Me.PnlPaths.Location = New System.Drawing.Point(12, 12)
        Me.PnlPaths.Name = "PnlPaths"
        Me.PnlPaths.Size = New System.Drawing.Size(438, 205)
        Me.PnlPaths.TabIndex = 23
        '
        'LblSpiffs
        '
        Me.LblSpiffs.Location = New System.Drawing.Point(10, 144)
        Me.LblSpiffs.Name = "LblSpiffs"
        Me.LblSpiffs.Size = New System.Drawing.Size(342, 18)
        Me.LblSpiffs.TabIndex = 17
        Me.LblSpiffs.Text = "spiffs.bin"
        '
        'TxtSpiffs
        '
        Me.TxtSpiffs.Location = New System.Drawing.Point(12, 162)
        Me.TxtSpiffs.Name = "TxtSpiffs"
        Me.TxtSpiffs.ReadOnly = True
        Me.TxtSpiffs.Size = New System.Drawing.Size(340, 20)
        Me.TxtSpiffs.TabIndex = 6
        Me.TxtSpiffs.Tag = "path"
        '
        'BtnPathSpiffs
        '
        Me.BtnPathSpiffs.Location = New System.Drawing.Point(373, 158)
        Me.BtnPathSpiffs.Name = "BtnPathSpiffs"
        Me.BtnPathSpiffs.Size = New System.Drawing.Size(46, 28)
        Me.BtnPathSpiffs.TabIndex = 7
        Me.BtnPathSpiffs.Tag = "spiffs"
        Me.BtnPathSpiffs.Text = "..."
        Me.BtnPathSpiffs.UseVisualStyleBackColor = True
        '
        'LblSketch
        '
        Me.LblSketch.Location = New System.Drawing.Point(9, 98)
        Me.LblSketch.Name = "LblSketch"
        Me.LblSketch.Size = New System.Drawing.Size(342, 18)
        Me.LblSketch.TabIndex = 16
        Me.LblSketch.Text = "sketch.bin"
        '
        'TxtSketch
        '
        Me.TxtSketch.Location = New System.Drawing.Point(11, 116)
        Me.TxtSketch.Name = "TxtSketch"
        Me.TxtSketch.ReadOnly = True
        Me.TxtSketch.Size = New System.Drawing.Size(340, 20)
        Me.TxtSketch.TabIndex = 4
        Me.TxtSketch.Tag = "path"
        '
        'BtnPathSketch
        '
        Me.BtnPathSketch.Location = New System.Drawing.Point(373, 112)
        Me.BtnPathSketch.Name = "BtnPathSketch"
        Me.BtnPathSketch.Size = New System.Drawing.Size(46, 28)
        Me.BtnPathSketch.TabIndex = 5
        Me.BtnPathSketch.Tag = "sketch"
        Me.BtnPathSketch.Text = "..."
        Me.BtnPathSketch.UseVisualStyleBackColor = True
        '
        'BtnPathEspota
        '
        Me.BtnPathEspota.Location = New System.Drawing.Point(373, 67)
        Me.BtnPathEspota.Name = "BtnPathEspota"
        Me.BtnPathEspota.Size = New System.Drawing.Size(46, 28)
        Me.BtnPathEspota.TabIndex = 3
        Me.BtnPathEspota.Tag = "espota"
        Me.BtnPathEspota.Text = "..."
        Me.BtnPathEspota.UseVisualStyleBackColor = True
        '
        'Lblespota
        '
        Me.Lblespota.Location = New System.Drawing.Point(9, 53)
        Me.Lblespota.Name = "Lblespota"
        Me.Lblespota.Size = New System.Drawing.Size(342, 18)
        Me.Lblespota.TabIndex = 15
        Me.Lblespota.Text = "espota.py"
        '
        'TxtEspota
        '
        Me.TxtEspota.Location = New System.Drawing.Point(11, 71)
        Me.TxtEspota.Name = "TxtEspota"
        Me.TxtEspota.ReadOnly = True
        Me.TxtEspota.Size = New System.Drawing.Size(340, 20)
        Me.TxtEspota.TabIndex = 2
        Me.TxtEspota.Tag = "path"
        '
        'BtnPathPython
        '
        Me.BtnPathPython.Location = New System.Drawing.Point(373, 22)
        Me.BtnPathPython.Name = "BtnPathPython"
        Me.BtnPathPython.Size = New System.Drawing.Size(46, 28)
        Me.BtnPathPython.TabIndex = 1
        Me.BtnPathPython.Tag = "python"
        Me.BtnPathPython.Text = "..."
        Me.BtnPathPython.UseVisualStyleBackColor = True
        '
        'Lblpython
        '
        Me.Lblpython.Location = New System.Drawing.Point(9, 8)
        Me.Lblpython.Name = "Lblpython"
        Me.Lblpython.Size = New System.Drawing.Size(342, 18)
        Me.Lblpython.TabIndex = 14
        Me.Lblpython.Text = "python3.exe"
        '
        'TxtPython
        '
        Me.TxtPython.Location = New System.Drawing.Point(11, 26)
        Me.TxtPython.Name = "TxtPython"
        Me.TxtPython.ReadOnly = True
        Me.TxtPython.Size = New System.Drawing.Size(340, 20)
        Me.TxtPython.TabIndex = 0
        Me.TxtPython.Tag = "path"
        '
        'PnlButton
        '
        Me.PnlButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlButton.Controls.Add(Me.BtnLaunchSpiffs)
        Me.PnlButton.Controls.Add(Me.BtnLaunchSketch)
        Me.PnlButton.Location = New System.Drawing.Point(13, 359)
        Me.PnlButton.Name = "PnlButton"
        Me.PnlButton.Size = New System.Drawing.Size(436, 121)
        Me.PnlButton.TabIndex = 25
        '
        'PnlOutput
        '
        Me.PnlOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlOutput.Controls.Add(Me.TxtShellOutput)
        Me.PnlOutput.Location = New System.Drawing.Point(13, 491)
        Me.PnlOutput.Name = "PnlOutput"
        Me.PnlOutput.Size = New System.Drawing.Size(435, 157)
        Me.PnlOutput.TabIndex = 26
        '
        'TxtShellOutput
        '
        Me.TxtShellOutput.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtShellOutput.ForeColor = System.Drawing.Color.Lime
        Me.TxtShellOutput.Location = New System.Drawing.Point(12, 13)
        Me.TxtShellOutput.Multiline = True
        Me.TxtShellOutput.Name = "TxtShellOutput"
        Me.TxtShellOutput.ReadOnly = True
        Me.TxtShellOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtShellOutput.Size = New System.Drawing.Size(408, 131)
        Me.TxtShellOutput.TabIndex = 13
        Me.TxtShellOutput.Tag = "ShellOutput"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 660)
        Me.Controls.Add(Me.PnlOutput)
        Me.Controls.Add(Me.PnlButton)
        Me.Controls.Add(Me.PnlPaths)
        Me.Controls.Add(Me.PnlTarget)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "espota launcher"
        Me.PnlTarget.ResumeLayout(False)
        Me.PnlTarget.PerformLayout()
        Me.PnlPaths.ResumeLayout(False)
        Me.PnlPaths.PerformLayout()
        Me.PnlButton.ResumeLayout(False)
        Me.PnlOutput.ResumeLayout(False)
        Me.PnlOutput.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnLaunchSketch As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BtnLaunchSpiffs As Button
    Friend WithEvents PnlTarget As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtPort As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtIP As TextBox
    Friend WithEvents PnlPaths As Panel
    Friend WithEvents BtnPathSpiffs As Button
    Friend WithEvents TxtSketch As TextBox
    Friend WithEvents BtnPathSketch As Button
    Friend WithEvents BtnPathEspota As Button
    Friend WithEvents Lblespota As Label
    Friend WithEvents TxtEspota As TextBox
    Friend WithEvents BtnPathPython As Button
    Friend WithEvents Lblpython As Label
    Friend WithEvents TxtPython As TextBox
    Friend WithEvents PnlButton As Panel
    Friend WithEvents PnlOutput As Panel
    Friend WithEvents TxtShellOutput As TextBox
    Friend WithEvents LblSpiffs As Label
    Friend WithEvents TxtSpiffs As TextBox
    Friend WithEvents LblSketch As Label
End Class
