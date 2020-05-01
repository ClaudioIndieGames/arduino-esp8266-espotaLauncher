Option Explicit On

Imports System
Imports System.IO
Imports System.Text

Public Class FrmMain

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Const TagPercorso As String = "path"


        CaricaFileImpostazioni()

        TxtPython.Text = Impostazioni.PercorsiFile.python
        TxtPython.SelectionStart = TxtPython.TextLength
        TxtEspota.Text = Impostazioni.PercorsiFile.espota
        TxtEspota.SelectionStart = TxtEspota.TextLength
        TxtSketch.Text = Impostazioni.PercorsiFile.sketch
        TxtSketch.SelectionStart = TxtSketch.TextLength
        TxtSpiffs.Text = Impostazioni.PercorsiFile.spiffs
        TxtSpiffs.SelectionStart = TxtSpiffs.TextLength
        TxtIP.Text = Impostazioni.Dati.IP
        TxtIP.SelectionStart = TxtIP.TextLength
        TxtPort.Text = Impostazioni.Dati.Port
        TxtPort.SelectionStart = TxtPort.TextLength
        TxtPassword.Text = Impostazioni.Dati.Password
        TxtPassword.SelectionStart = TxtPassword.TextLength

        'Imposta sfondo TextBox
        Dim Pannello As Control
        For Each Pannello In Me.Controls
            If TypeOf Pannello Is Panel Then
                Dim Controllo As Control
                For Each Controllo In Pannello.Controls
                    If TypeOf Controllo Is TextBox Then
                        If (Controllo.Tag = TagPercorso) Then
                            Controllo.BackColor = TextBoxPathColor(Controllo.Text)
                        End If
                    End If
                Next
            End If
        Next

        BtnPathEspota.Select()
    End Sub

    Private Sub FrmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        SalvaFileImpostazioni()

    End Sub

    Private Sub BtnPathFind(sender As Object, e As EventArgs) Handles BtnPathPython.Click, BtnPathEspota.Click, BtnPathSpiffs.Click, BtnPathSketch.Click

        Select Case sender.tag

            Case strImpostazioni.strpython
                OpenFileDialog1.FileName = "python3"
                OpenFileDialog1.DefaultExt = ".exe"
                OpenFileDialog1.Filter = "python 3 (.exe)|*.exe"

                If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                    Impostazioni.PercorsiFile.python = OpenFileDialog1.FileName
                    TxtPython.Text = OpenFileDialog1.FileName
                    TxtPython.SelectionStart = TxtPython.TextLength
                    TxtPython.BackColor = TextBoxPathColor(OpenFileDialog1.FileName)
                End If

            Case strImpostazioni.strespota
                OpenFileDialog1.FileName = "espota"
                OpenFileDialog1.DefaultExt = ".py"
                OpenFileDialog1.Filter = "espota script (.py)|*.py"

                If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                    Impostazioni.PercorsiFile.espota = OpenFileDialog1.FileName
                    TxtEspota.Text = OpenFileDialog1.FileName
                    TxtEspota.SelectionStart = TxtEspota.TextLength
                    TxtEspota.BackColor = TextBoxPathColor(OpenFileDialog1.FileName)
                End If

            Case strImpostazioni.sketch
                OpenFileDialog1.FileName = "sketch"
                OpenFileDialog1.DefaultExt = ".bin"
                OpenFileDialog1.Filter = "sketch compiled (.bin)|*.bin"

                If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                    Impostazioni.PercorsiFile.sketch = OpenFileDialog1.FileName
                    TxtSketch.Text = OpenFileDialog1.FileName
                    TxtSketch.SelectionStart = TxtSketch.TextLength
                    TxtSketch.BackColor = TextBoxPathColor(OpenFileDialog1.FileName)
                End If

            Case strImpostazioni.strspiffs
                OpenFileDialog1.FileName = "spiffs"
                OpenFileDialog1.DefaultExt = ".bin"
                OpenFileDialog1.Filter = "spiffs compiled (.bin)|*.bin"

                If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                    Impostazioni.PercorsiFile.spiffs = OpenFileDialog1.FileName
                    TxtSpiffs.Text = OpenFileDialog1.FileName
                    TxtSpiffs.SelectionStart = TxtSpiffs.TextLength
                    TxtSpiffs.BackColor = TextBoxPathColor(OpenFileDialog1.FileName)
                End If

        End Select
    End Sub

    Private Sub BtnLauncher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLaunchSketch.Click, BtnLaunchSpiffs.Click
        Dim strArguments As String = ""


        If My.Computer.FileSystem.FileExists(Impostazioni.PercorsiFile.python) Then
            If My.Computer.FileSystem.FileExists(Impostazioni.PercorsiFile.espota) Then
                Select Case sender.tag

                    Case strImpostazioni.sketch
                        If My.Computer.FileSystem.FileExists(Impostazioni.PercorsiFile.sketch) Then
                            strArguments = GetShortPath(Impostazioni.PercorsiFile.espota) & " -i " & Impostazioni.Dati.IP & " -p " & Impostazioni.Dati.Port & " --auth=" & Impostazioni.Dati.Password & " -f " & GetShortPath(Impostazioni.PercorsiFile.sketch)
                        Else
                            MsgBox("Invalid sketch file path", vbCritical, "Error")
                        End If

                    Case strImpostazioni.strspiffs
                        If My.Computer.FileSystem.FileExists(Impostazioni.PercorsiFile.spiffs) Then
                            strArguments = GetShortPath(Impostazioni.PercorsiFile.espota) & " -i " & Impostazioni.Dati.IP & " -p " & Impostazioni.Dati.Port & " --auth=" & Impostazioni.Dati.Password & " -s -f " & GetShortPath(Impostazioni.PercorsiFile.spiffs)
                        Else
                            MsgBox("Invalid spiffs file path", vbCritical, "Error")
                        End If

                End Select
            Else
                MsgBox("Invalid espota file path", vbCritical, "Error")
            End If
        Else
            MsgBox("Invalid python3 file path", vbCritical, "Error")
        End If

        If (strArguments.Length > 0) Then
            Try
                TxtShellOutput.Text = TimeString & " - Launching espota: " & sender.tag & Environment.NewLine
                TxtShellOutput.SelectionStart = TxtShellOutput.Text.Length
                GestioneTuttiControlliDelegate(False)
                SetCursorDelegate(Cursors.WaitCursor)


                Dim p As New Process()
                Dim pInfo As New ProcessStartInfo(GetShortPath(Impostazioni.PercorsiFile.python), strArguments)
                pInfo.UseShellExecute = False
                pInfo.RedirectStandardOutput = True
                pInfo.RedirectStandardError = True
                pInfo.CreateNoWindow = True
                p.StartInfo = pInfo
                p.EnableRaisingEvents = True
                Application.DoEvents()

                AddHandler p.ErrorDataReceived, AddressOf p_OutputDataReceived
                AddHandler p.OutputDataReceived, AddressOf p_OutputDataReceived
                AddHandler p.Exited, New EventHandler(AddressOf p_Exited)
                p.Start()
                p.BeginErrorReadLine()
                p.BeginOutputReadLine()

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub



    'Asynch shell
    '------------------------------------------------------------------
    Delegate Sub UpdateTextBoxDelg(Text As String)
    Delegate Sub GestioneTuttiControlliDelg(Stato As Boolean)
    Delegate Sub SetCursorDelg(Cursore As Cursor)

    Private TxtShellOutputDelegate As UpdateTextBoxDelg = New UpdateTextBoxDelg(AddressOf TxtShellOutput_Add)
    Private GestioneTuttiControlliDelegate As GestioneTuttiControlliDelg = New GestioneTuttiControlliDelg(AddressOf GestioneTuttiControlli_Delegate)
    Private SetCursorDelegate As SetCursorDelg = New SetCursorDelg(AddressOf SetCursor_Delegate)

    Private Sub TxtShellOutput_Add(Text As String)
        TxtShellOutput.Text += Text & Environment.NewLine
        TxtShellOutput.SelectionStart = TxtShellOutput.Text.Length
        TxtShellOutput.ScrollToCaret()
    End Sub

    Private Sub GestioneTuttiControlli_Delegate(ByVal Stato As Boolean)
        Const strShellOutput As String = "ShellOutput"
        Dim Pannello As Control

        For Each Pannello In Me.Controls
            If TypeOf Pannello Is Panel Then
                Dim Controllo As Control
                For Each Controllo In Pannello.Controls
                    If (TypeOf Controllo Is TextBox) Or (TypeOf Controllo Is Button) Then
                        If (Controllo.Tag <> strShellOutput) Then
                            Controllo.Enabled = Stato
                        End If
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub SetCursor_Delegate(ByVal Cursore As Cursor)
        Cursor = Cursore
    End Sub

    Private Sub p_OutputDataReceived(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
        If Me.InvokeRequired = True Then
            Me.Invoke(TxtShellOutputDelegate, e.Data)
        Else
            TxtShellOutputDelegate(e.Data)
        End If
    End Sub

    Private Sub p_Exited(ByVal sender As Object, ByVal e As System.EventArgs)
        Const strProcessTerminated As String = " - Process terminated"

        If Me.InvokeRequired = True Then
            Me.Invoke(TxtShellOutputDelegate, TimeString & strProcessTerminated)
            Me.Invoke(GestioneTuttiControlliDelegate, True)
            Me.Invoke(SetCursorDelegate, Cursors.Default)
        Else
            TxtShellOutputDelegate(TimeString & strProcessTerminated)
            GestioneTuttiControlliDelegate(True)
            SetCursorDelegate(Cursors.Default)
        End If
    End Sub
    '------------------------------------------------------------------


    'Procedure e funzioni
    '------------------------------------------------------------------
    Private Sub CaricaFileImpostazioni()
        Dim PercorsoApplicazione As String
        Dim PercorsoCompletoFileImpostazioni As String


        PercorsoApplicazione = Application.StartupPath
        If (Strings.Right(PercorsoApplicazione, 1) <> SeparatoreCartelle) Then
            PercorsoApplicazione = PercorsoApplicazione & SeparatoreCartelle
        End If
        PercorsoCompletoFileImpostazioni = (PercorsoApplicazione & FileImpostazioni)

        If My.Computer.FileSystem.FileExists(PercorsoCompletoFileImpostazioni) Then
            Const SeparatoreCampi As String = "="
            Dim File As New StreamReader(PercorsoCompletoFileImpostazioni, Encoding.Default)
            Dim Riga As String
            Dim PosSeparatoreCampi As Integer


            Do
                Riga = File.ReadLine
                PosSeparatoreCampi = InStr(Riga, SeparatoreCampi)
                If (PosSeparatoreCampi > 0) Then
                    If (InStr(Strings.Left(Riga, PosSeparatoreCampi - 1), strImpostazioni.strpython) > 0) Then
                        Impostazioni.PercorsiFile.python = Mid(Riga, (PosSeparatoreCampi + 1))
                    End If
                    If (InStr(Strings.Left(Riga, PosSeparatoreCampi - 1), strImpostazioni.strespota) > 0) Then
                        Impostazioni.PercorsiFile.espota = Mid(Riga, (PosSeparatoreCampi + 1))
                    End If
                    If (InStr(Strings.Left(Riga, PosSeparatoreCampi - 1), strImpostazioni.sketch) > 0) Then
                        Impostazioni.PercorsiFile.sketch = Mid(Riga, (PosSeparatoreCampi + 1))
                    End If
                    If (InStr(Strings.Left(Riga, PosSeparatoreCampi - 1), strImpostazioni.strspiffs) > 0) Then
                        Impostazioni.PercorsiFile.spiffs = Mid(Riga, (PosSeparatoreCampi + 1))
                    End If
                    If (InStr(Strings.Left(Riga, PosSeparatoreCampi - 1), strImpostazioni.strip) > 0) Then
                        Impostazioni.Dati.IP = Mid(Riga, (PosSeparatoreCampi + 1))
                    End If
                    If (InStr(Strings.Left(Riga, PosSeparatoreCampi - 1), strImpostazioni.strport) > 0) Then
                        Impostazioni.Dati.Port = Mid(Riga, (PosSeparatoreCampi + 1))
                    End If
                    If (InStr(Strings.Left(Riga, PosSeparatoreCampi - 1), strImpostazioni.strpassword) > 0) Then
                        Impostazioni.Dati.Password = Mid(Riga, (PosSeparatoreCampi + 1))
                    End If
                End If
            Loop Until Riga Is Nothing

            File.Close()
        End If
    End Sub

    Private Sub SalvaFileImpostazioni()
        Dim PercorsoApplicazione As String
        Dim PercorsoCompletoFileImpostazioni As String


        PercorsoApplicazione = Application.StartupPath
        If (Strings.Right(PercorsoApplicazione, 1) <> SeparatoreCartelle) Then
            PercorsoApplicazione = PercorsoApplicazione & SeparatoreCartelle
        End If
        PercorsoCompletoFileImpostazioni = (PercorsoApplicazione & FileImpostazioni)

        Try
            Const SeparatoreCampi As String = "="
            Dim File As New StreamWriter(PercorsoCompletoFileImpostazioni, False)

            File.WriteLine(strImpostazioni.strpython & SeparatoreCampi & TxtPython.Text)
            File.WriteLine(strImpostazioni.strespota & SeparatoreCampi & TxtEspota.Text)
            File.WriteLine(strImpostazioni.sketch & SeparatoreCampi & TxtSketch.Text)
            File.WriteLine(strImpostazioni.strspiffs & SeparatoreCampi & TxtSpiffs.Text)
            File.WriteLine(strImpostazioni.strip & SeparatoreCampi & TxtIP.Text)
            File.WriteLine(strImpostazioni.strport & SeparatoreCampi & TxtPort.Text)
            File.WriteLine(strImpostazioni.strpassword & SeparatoreCampi & TxtPassword.Text)
            File.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

End Class