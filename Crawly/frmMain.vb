Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Windows.Forms.VisualStyles

Public Class frmMain
    Dim pattern As String
    Dim running As Boolean = False
    Dim thrCrawler = New Threading.Thread(AddressOf ThreadStartCrawler)
    Dim thrExcavator = New Threading.Thread(AddressOf ThreadStartExcavate)
    Private Sub cmdAddTerm_Click(sender As Object, e As EventArgs) Handles cmdAddTerm.Click
        Dim term = InputBox("Enter a search term","Add Term")
        If term <> "" Then
            lbTerms.Items.Add(term.ToString())
        End If

    End Sub

    Private Sub cmdLoadTerms_Click(sender As Object, e As EventArgs) Handles cmdLoadTerms.Click
        lbTerms.Items.Clear()
        Dim openTerms As New OpenFileDialog
        With openTerms
            .FileName = ""
            .Filter = "Textfile (*.txt)|*.txt"
            .DefaultExt = "txt"
            .InitialDirectory = My.Computer.FileSystem.CurrentDirectory
        End With
        If openTerms.ShowDialog() = DialogResult.OK Then
            Dim contents() As String = File.ReadAllLines(openTerms.FileName)
            lbTerms.Items.AddRange(contents)
        End If
    End Sub

    Private Sub cmdSaveTerms_Click(sender As Object, e As EventArgs) Handles cmdSaveTerms.Click
        Dim path As String = ""
        Dim saveTerms As New SaveFileDialog
        With saveTerms
            .FileName = ""
            .Filter = "Textfile (*.txt)|*.txt"
            .DefaultExt = "txt"
            .InitialDirectory = My.Computer.FileSystem.CurrentDirectory
        End With

        If saveTerms.ShowDialog() = DialogResult.OK Then
            path = saveTerms.FileName
            Dim sb As New System.Text.StringBuilder()

            For each item In lbTerms.Items
                sb.AppendLine(item)
            Next
            File.WriteAllText(path, sb.ToString())
        End If
        MsgBox("Saved to " & path & "!", 64,"Saved")
    End Sub

    Private Sub cmbPattern_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPattern.SelectedIndexChanged
        If cmbPattern.SelectedItem.ToString() = "Custom pattern" Then
            grpCustomPattern.Enabled = True
            pattern = "Custom"
        Else 
            grpCustomPattern.Enabled = False
            pattern = cmbPattern.SelectedItem.ToString()
        End If
    End Sub

    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        Try
            'Dim googleWorker As New GoogleWorker
            'Dim listOfTerms As New List(Of String)
            'For Each itm In lbTerms.Items
            '    listOfTerms.Add(itm)
            'Next

            'lbResults.Items.AddRange(googleWorker.DoCrawl(listOfTerms).ToArray())  
            lblStatus.Text = "Running... Please wait till the process is finished."
            running = True
            thrCrawler.Start()
            cmdStart.Enabled = False
        Catch ex As Exception
            MsgBox("An error occured. " + ex.Message, vbCritical, "Error")
            cmdStart.Enabled = True
        End Try


    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbTerms.ContextMenuStrip = menuTerms
        cmbPattern.SelectedIndex = 0
        Me.CheckForIllegalCrossThreadCalls = False
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        lbTerms.Items.Clear()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        lbTerms.Items.Remove(lbTerms.SelectedItem)
    End Sub
    Private Sub ThreadStartCrawler()

        Dim googleWorker As New GoogleWorker
        Dim listOfTerms As New List(Of String)
        For Each itm In lbTerms.Items
            If running = True Then 
                listOfTerms.Add(itm)
            Else 
                lblStatus.Text = "Idle..."
                Exit Sub
            End If
        Next

        lbResults.Items.AddRange(googleWorker.DoCrawl(listOfTerms).ToArray())
        MsgBox("Start the excavation of your " + cmbPattern.SelectedItem.ToString() +"!", vbInformation, "1. Step success")
        cmdExcavation.Enabled = True
        lblStatus.Text = "Start the excavation!..."
    End Sub
    Private Sub cmdExcavation_Click(sender As Object, e As EventArgs) Handles cmdExcavation.Click
        lblStatus.Text = "Running the excavation!..."
        running = True
        thrExcavator.Start()
        cmdStart.Enabled = False
    End Sub
    Private Sub ThreadStartExcavate()
        Dim excavator As New Excavator
        Dim actual As Integer = 0
        Dim max As Integer = 0

        Dim listSites As New List(Of String)
        Dim listTemp As New List(Of String)
        Dim listResults As New List(Of String)

        For Each item In lbResults.Items
            listSites.Add(item)
        Next

        max = lbResults.Items.Count
        lblProgress.Text = "Progress: " + actual.ToString() + " / " + max.ToString()
        progressbar.Maximum = max

        For i = 0 to max - 1
            listResults.AddRange(excavator.StartExcavation(listSites.Item(i)))
            listTemp.AddRange(listResults)
            listResults.Clear()
            actual += 1
            lblProgress.Text = "Progress: " + actual.ToString() + " / " + max.ToString()
            progressbar.Value += 1
        Next

        For Each lItem In listTemp
            lbFinalResults.Items.Add(lItem)
            Dim items(lbFinalResults.Items.Count - 1) As Object
            lbFinalResults.Items.CopyTo(items, 0)
            lbFinalResults.Items.Clear()
            lbFinalResults.Items.AddRange(items.AsEnumerable().Distinct().ToArray())
        Next
        
        cmdStart.Enabled = True
        cmdExcavation.Enabled = False

        lblStatus.Text = "Idle..."
        NewCampaign()
    End Sub
    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        lbResults.Items.Clear()
        lbFinalResults.Items.Clear()
    End Sub
    Public Function NewCampaign()
        Dim path As String = My.Computer.FileSystem.CurrentDirectory & "\E-Mail_" + DateAndTime.Now.ToString().Replace(":","-") + ".txt"
        Dim sb As New System.Text.StringBuilder()

        For each item In lbFinalResults.Items
            sb.AppendLine(item)
        Next
        File.WriteAllText(path, sb.ToString())
        MsgBox("E-Mails saved under:" & vbCrLf & path, vbInformation, "Success!")
        Application.ExitThread()
    End Function

    Private Sub mnuNewCampaign_Click(sender As Object, e As EventArgs) Handles mnuNewCampaign.Click

    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        MsgBox("Crawly is developed by Clusterzx. Crawly is a small scale webcrawler for email adresses and social media accounts." _
               & vbCrLf _
               & "(c) Clusterzx 2019" _
               ,vbInformation, "About Crawly")
    End Sub
End Class
