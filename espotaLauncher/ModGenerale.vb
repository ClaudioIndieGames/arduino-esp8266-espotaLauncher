Option Explicit On

Imports System.IO
Imports System.Text
Imports System.Runtime.InteropServices

Module ModGenerale
    Public Const SeparatoreCartelle As String = "\"
    Public Const FileImpostazioni As String = "Settings.txt"

    Public Impostazioni As ESP_Impostazioni

    Private Declare Auto Function GetShortPathName Lib "kernel32" (ByVal lpszLongPath As String, ByVal lpszShortPath As StringBuilder, ByVal cchBuffer As Integer) As Integer

    Public Structure ESP_Impostazioni
        Dim Dati As ESP_Dati
        Dim PercorsiFile As ESP_PercorsiFile
    End Structure

    Public Structure ESP_Dati
        Dim IP As String
        Dim Port As String
        Dim Password As String
    End Structure

    Public Structure ESP_PercorsiFile
        Dim python As String
        Dim espota As String
        Dim sketch As String
        Dim spiffs As String
    End Structure

    Public Structure strImpostazioni
        Const strpython As String = "python"
        Const strespota As String = "espota"
        Const sketch As String = "sketch"
        Const strspiffs As String = "spiffs"
        Const strip As String = "IP"
        Const strport As String = "Port"
        Const strpassword As String = "Password"
    End Structure


    'Procedure e funzioni
    '------------------------------------------------------------------
    Public Function IsFileOpen(ByVal FileFullName As String) As Boolean
        Dim stream As FileStream = Nothing
        Dim file As New FileInfo(FileFullName)

        IsFileOpen = False
        Try
            stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None)
            stream.Close()
        Catch ex As Exception

            If TypeOf ex Is IOException AndAlso IsFileLocked(ex) Then
                Return True
            End If
        End Try
    End Function

    Private Function IsFileLocked(exception As Exception) As Boolean
        Dim errorCode As Integer = Marshal.GetHRForException(exception) And ((1 << 16) - 1)
        Return errorCode = 32 OrElse errorCode = 33
    End Function

    Public Function GetShortPath(ByVal longPath As String) As String
        Dim requiredSize As Integer = GetShortPathName(longPath, Nothing, 0)
        Dim buffer As New StringBuilder(requiredSize)

        GetShortPathName(longPath, buffer, buffer.Capacity)
        Return buffer.ToString()
    End Function

    Public Function TextBoxPathColor(ByVal Path As String) As Color
        If My.Computer.FileSystem.FileExists(Path) Then
            Return Color.Chartreuse
        Else
            Return Color.Tomato
        End If
    End Function
End Module

