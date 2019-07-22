Imports System.Text.RegularExpressions

Public Class GoogleWorker
    Private Shared Function GetSourceCode(ByVal url As String) As String
        Dim sourceString As String = New System.Net.WebClient().DownloadString(url)
        Return sourceString
    End Function
    Private Shared Function ReadSearchResults(ByVal sourceCode As String) As List(Of String)
        Dim resultsUrl As New List(Of String)()
        Const regExPattern As String = "((?:http|https)(?::\/{2}[\w]+)(?:[\/|\.]?)(?:[^\s""]*))"
        Dim matches As MatchCollection = Regex.Matches(sourceCode, RegExPattern, RegexOptions.IgnoreCase)
        For Each m As Match In matches
            For Each c As Capture In m.Captures
                If c.Value.ToString().Contains("&amp;") Then
                    Dim splitString() As String = c.Value.ToString().Split("&amp;")
                    If Not splitString(0).Contains("google.com") Then resultsUrl.Add(splitString(0))
                ElseIf c.Value.ToString().Contains("</div>")
                    Dim splitString() As String = c.Value.ToString().Split("</div>")
                    If Not splitString(0).Contains("google.com") Then resultsUrl.Add(splitString(0))
                Else 
                    If Not c.Value.Contains("google.com") Then resultsUrl.Add(c.Value)
                End If
            Next
        Next
        Return resultsUrl
    End Function
    Public Function DoCrawl(ByVal terms As List(Of String)) As List(Of String)
        Dim foundUrls As New List(Of String)
        Dim searchUrl As String = "https://www.google.com/search?hl=us&q="
        For Each term In terms
            Dim retString As String = GetSourceCode(searchUrl + term)
            Dim urlCollection As New List(Of String)
            urlCollection = ReadSearchResults(retString)
            For each url In urlCollection
                foundUrls.Add(url)
            Next
        Next
        Return foundUrls
    End Function
End Class
