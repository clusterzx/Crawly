Imports System.Text.RegularExpressions

Public Class Excavator
    Private Shared Function ExcavatePattern(ByVal source As String) As List(Of String)
        Dim resultList As New List(Of String)
        Try
                Dim src As String = GetSourceCode(source)
                Const regExPattern As String = "([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})"
                Dim matches As MatchCollection = Regex.Matches(src, RegExPattern, RegexOptions.IgnoreCase)
                For Each m As Match In matches
                    For Each c As Capture In m.Captures
                        If c.Value.Contains(".jpg") Or c.Value.Contains(".jpeg") Or c.Value.Contains(".png") Or c.Value.Contains(".bmp") Or c.Value.Contains(".gif") Then
                            resultList.Add("wrong@wrong.wrong")
                        Else 
                            resultList.Add(c.Value)
                        End If
                    Next
                Next
            Return resultList
        Catch ex As Exception
            MsgBox("Error! " + ex.Message, vbCritical, "Error!")
        End Try
    End Function
    Private Shared Function GetSourceCode(ByVal url As String) As String
        Try
            Dim sourceString As String = New System.Net.WebClient().DownloadString(url)
            Return sourceString
        Catch ex As Exception
            Return "Server does not respond"
        End Try
    End Function
    Public Function StartExcavation(ByVal site As String) As List(Of String)
        Return ExcavatePattern(site)
    End Function
End Class
