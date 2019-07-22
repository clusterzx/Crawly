<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbTerms = New System.Windows.Forms.ListBox()
        Me.cmdAddTerm = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdLoadTerms = New System.Windows.Forms.Button()
        Me.cmdSaveTerms = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grpCustomPattern = New System.Windows.Forms.GroupBox()
        Me.txtPattern = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbPattern = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbFinalResults = New System.Windows.Forms.ListBox()
        Me.lbResults = New System.Windows.Forms.ListBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdExcavation = New System.Windows.Forms.Button()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.menuTerms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.progressbar = New System.Windows.Forms.ProgressBar()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNewCampaign = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUpdates = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLicense = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.grpCustomPattern.SuspendLayout
        Me.GroupBox3.SuspendLayout
        Me.GroupBox5.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.menuTerms.SuspendLayout
        Me.MenuStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search terms :"
        '
        'lbTerms
        '
        Me.lbTerms.FormattingEnabled = true
        Me.lbTerms.Location = New System.Drawing.Point(13, 44)
        Me.lbTerms.Name = "lbTerms"
        Me.lbTerms.Size = New System.Drawing.Size(190, 173)
        Me.lbTerms.TabIndex = 1
        '
        'cmdAddTerm
        '
        Me.cmdAddTerm.Location = New System.Drawing.Point(130, 22)
        Me.cmdAddTerm.Name = "cmdAddTerm"
        Me.cmdAddTerm.Size = New System.Drawing.Size(73, 19)
        Me.cmdAddTerm.TabIndex = 2
        Me.cmdAddTerm.Text = "Add"
        Me.cmdAddTerm.UseVisualStyleBackColor = true
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 695)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(584, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(35, 17)
        Me.lblStatus.Text = "Idle..."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdLoadTerms)
        Me.GroupBox1.Controls.Add(Me.cmdSaveTerms)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbTerms)
        Me.GroupBox1.Controls.Add(Me.cmdAddTerm)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 169)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 279)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Search terms options"
        '
        'cmdLoadTerms
        '
        Me.cmdLoadTerms.Location = New System.Drawing.Point(13, 223)
        Me.cmdLoadTerms.Name = "cmdLoadTerms"
        Me.cmdLoadTerms.Size = New System.Drawing.Size(190, 22)
        Me.cmdLoadTerms.TabIndex = 3
        Me.cmdLoadTerms.Text = "Load list of terms (.txt)"
        Me.cmdLoadTerms.UseVisualStyleBackColor = true
        '
        'cmdSaveTerms
        '
        Me.cmdSaveTerms.Location = New System.Drawing.Point(13, 249)
        Me.cmdSaveTerms.Name = "cmdSaveTerms"
        Me.cmdSaveTerms.Size = New System.Drawing.Size(190, 22)
        Me.cmdSaveTerms.TabIndex = 3
        Me.cmdSaveTerms.Text = "Save list of terms (.txt)"
        Me.cmdSaveTerms.UseVisualStyleBackColor = true
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grpCustomPattern)
        Me.GroupBox2.Controls.Add(Me.cmbPattern)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(241, 169)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(330, 136)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Crawler options"
        '
        'grpCustomPattern
        '
        Me.grpCustomPattern.Controls.Add(Me.txtPattern)
        Me.grpCustomPattern.Controls.Add(Me.Label3)
        Me.grpCustomPattern.Enabled = false
        Me.grpCustomPattern.Location = New System.Drawing.Point(18, 50)
        Me.grpCustomPattern.Name = "grpCustomPattern"
        Me.grpCustomPattern.Size = New System.Drawing.Size(300, 74)
        Me.grpCustomPattern.TabIndex = 3
        Me.grpCustomPattern.TabStop = false
        Me.grpCustomPattern.Text = "Custom pattern"
        '
        'txtPattern
        '
        Me.txtPattern.Location = New System.Drawing.Point(15, 39)
        Me.txtPattern.Name = "txtPattern"
        Me.txtPattern.Size = New System.Drawing.Size(270, 20)
        Me.txtPattern.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(12, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Note: Use valid RegEx for a pattern"
        '
        'cmbPattern
        '
        Me.cmbPattern.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPattern.Enabled = false
        Me.cmbPattern.FormattingEnabled = true
        Me.cmbPattern.Items.AddRange(New Object() {"E-Mails", "URLs", "Social Media", "Custom pattern"})
        Me.cmbPattern.Location = New System.Drawing.Point(106, 23)
        Me.cmbPattern.Name = "cmbPattern"
        Me.cmbPattern.Size = New System.Drawing.Size(212, 21)
        Me.cmbPattern.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Crawl for :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblProgress)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.lbFinalResults)
        Me.GroupBox3.Controls.Add(Me.lbResults)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 454)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(559, 236)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = false
        Me.GroupBox3.Text = "   Log - Results"
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = true
        Me.lblProgress.Location = New System.Drawing.Point(443, 16)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(77, 13)
        Me.lblProgress.TabIndex = 3
        Me.lblProgress.Text = "Progress: 0 / 0"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(278, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Results"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Temporary Links crawled"
        '
        'lbFinalResults
        '
        Me.lbFinalResults.FormattingEnabled = true
        Me.lbFinalResults.Location = New System.Drawing.Point(278, 31)
        Me.lbFinalResults.Name = "lbFinalResults"
        Me.lbFinalResults.Size = New System.Drawing.Size(275, 199)
        Me.lbFinalResults.TabIndex = 1
        '
        'lbResults
        '
        Me.lbResults.FormattingEnabled = true
        Me.lbResults.Location = New System.Drawing.Point(5, 31)
        Me.lbResults.Name = "lbResults"
        Me.lbResults.Size = New System.Drawing.Size(267, 199)
        Me.lbResults.TabIndex = 1
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.cmdClear)
        Me.GroupBox5.Controls.Add(Me.cmdExcavation)
        Me.GroupBox5.Controls.Add(Me.cmdStart)
        Me.GroupBox5.Location = New System.Drawing.Point(240, 311)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(330, 137)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = false
        Me.GroupBox5.Text = "Control actions"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Enabled = false
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(6, 95)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(318, 3)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Stop Crawly"
        Me.Button2.UseVisualStyleBackColor = false
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(6, 109)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(318, 22)
        Me.cmdClear.TabIndex = 0
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = true
        '
        'cmdExcavation
        '
        Me.cmdExcavation.Enabled = false
        Me.cmdExcavation.Location = New System.Drawing.Point(6, 55)
        Me.cmdExcavation.Name = "cmdExcavation"
        Me.cmdExcavation.Size = New System.Drawing.Size(318, 30)
        Me.cmdExcavation.TabIndex = 0
        Me.cmdExcavation.Text = "2. Start excavation"
        Me.cmdExcavation.UseVisualStyleBackColor = true
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(6, 19)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(318, 30)
        Me.cmdStart.TabIndex = 0
        Me.cmdStart.Text = "1. Start Crawly"
        Me.cmdStart.UseVisualStyleBackColor = true
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.Crawly.My.Resources.Resources.bnner
        Me.PictureBox1.Location = New System.Drawing.Point(17, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(553, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = false
        '
        'menuTerms
        '
        Me.menuTerms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.menuTerms.Name = "menuTerms"
        Me.menuTerms.Size = New System.Drawing.Size(165, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItem1.Text = "Clear"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItem2.Text = "Remove Selected"
        '
        'progressbar
        '
        Me.progressbar.Location = New System.Drawing.Point(347, 699)
        Me.progressbar.Name = "progressbar"
        Me.progressbar.Size = New System.Drawing.Size(217, 15)
        Me.progressbar.TabIndex = 9
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(584, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MainToolStripMenuItem
        '
        Me.MainToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewCampaign, Me.mnuExit})
        Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        Me.MainToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.MainToolStripMenuItem.Text = "Main"
        '
        'mnuNewCampaign
        '
        Me.mnuNewCampaign.Name = "mnuNewCampaign"
        Me.mnuNewCampaign.Size = New System.Drawing.Size(198, 22)
        Me.mnuNewCampaign.Text = "Open Advertisy (extern)"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(198, 22)
        Me.mnuExit.Text = "Exit Crawly"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuUpdates, Me.mnuAbout, Me.mnuLicense})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.AboutToolStripMenuItem.Text = "Info"
        '
        'mnuUpdates
        '
        Me.mnuUpdates.Name = "mnuUpdates"
        Me.mnuUpdates.Size = New System.Drawing.Size(180, 22)
        Me.mnuUpdates.Text = "Updates"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(180, 22)
        Me.mnuAbout.Text = "About"
        '
        'mnuLicense
        '
        Me.mnuLicense.Name = "mnuLicense"
        Me.mnuLicense.Size = New System.Drawing.Size(180, 22)
        Me.mnuLicense.Text = "License"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 717)
        Me.Controls.Add(Me.progressbar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crawly v0.1 alpha"
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.grpCustomPattern.ResumeLayout(false)
        Me.grpCustomPattern.PerformLayout
        Me.GroupBox3.ResumeLayout(false)
        Me.GroupBox3.PerformLayout
        Me.GroupBox5.ResumeLayout(false)
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.menuTerms.ResumeLayout(false)
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbTerms As ListBox
    Friend WithEvents cmdAddTerm As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdLoadTerms As Button
    Friend WithEvents cmdSaveTerms As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbPattern As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents grpCustomPattern As GroupBox
    Friend WithEvents txtPattern As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents cmdStart As Button
    Friend WithEvents lbResults As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents menuTerms As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbFinalResults As ListBox
    Friend WithEvents cmdExcavation As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblProgress As Label
    Friend WithEvents progressbar As ProgressBar
    Friend WithEvents cmdClear As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MainToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuNewCampaign As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuUpdates As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents mnuLicense As ToolStripMenuItem
End Class
