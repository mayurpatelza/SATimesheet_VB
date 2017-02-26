<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnImportTimesheet = New System.Windows.Forms.Button()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.lblFileValue = New System.Windows.Forms.Label()
        Me.prgbrTimes = New System.Windows.Forms.ProgressBar()
        Me.lblTimesProgress = New System.Windows.Forms.Label()
        Me.lblProgressRecords = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnImportTimesheet
        '
        Me.btnImportTimesheet.Location = New System.Drawing.Point(180, 46)
        Me.btnImportTimesheet.Name = "btnImportTimesheet"
        Me.btnImportTimesheet.Size = New System.Drawing.Size(119, 42)
        Me.btnImportTimesheet.TabIndex = 0
        Me.btnImportTimesheet.Text = "Import Timesheet"
        Me.btnImportTimesheet.UseVisualStyleBackColor = True
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Location = New System.Drawing.Point(12, 109)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(26, 13)
        Me.lblFileName.TabIndex = 1
        Me.lblFileName.Text = "File:"
        '
        'lblFileValue
        '
        Me.lblFileValue.AutoSize = True
        Me.lblFileValue.Location = New System.Drawing.Point(44, 109)
        Me.lblFileValue.Name = "lblFileValue"
        Me.lblFileValue.Size = New System.Drawing.Size(27, 13)
        Me.lblFileValue.TabIndex = 2
        Me.lblFileValue.Text = "N/A"
        '
        'prgbrTimes
        '
        Me.prgbrTimes.Location = New System.Drawing.Point(88, 147)
        Me.prgbrTimes.Name = "prgbrTimes"
        Me.prgbrTimes.Size = New System.Drawing.Size(347, 30)
        Me.prgbrTimes.TabIndex = 3
        '
        'lblTimesProgress
        '
        Me.lblTimesProgress.AutoSize = True
        Me.lblTimesProgress.Location = New System.Drawing.Point(22, 153)
        Me.lblTimesProgress.Name = "lblTimesProgress"
        Me.lblTimesProgress.Size = New System.Drawing.Size(51, 13)
        Me.lblTimesProgress.TabIndex = 4
        Me.lblTimesProgress.Text = "Progress:"
        '
        'lblProgressRecords
        '
        Me.lblProgressRecords.AutoSize = True
        Me.lblProgressRecords.Location = New System.Drawing.Point(441, 153)
        Me.lblProgressRecords.Name = "lblProgressRecords"
        Me.lblProgressRecords.Size = New System.Drawing.Size(24, 13)
        Me.lblProgressRecords.TabIndex = 5
        Me.lblProgressRecords.Text = "- / -"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(180, 207)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(119, 42)
        Me.btnQuit.TabIndex = 6
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 261)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.lblProgressRecords)
        Me.Controls.Add(Me.lblTimesProgress)
        Me.Controls.Add(Me.prgbrTimes)
        Me.Controls.Add(Me.lblFileValue)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.btnImportTimesheet)
        Me.Name = "frmMain"
        Me.Text = "Simply Asia Timesheet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnImportTimesheet As Button
    Friend WithEvents lblFileName As Label
    Friend WithEvents lblFileValue As Label
    Friend WithEvents prgbrTimes As ProgressBar
    Friend WithEvents lblTimesProgress As Label
    Friend WithEvents lblProgressRecords As Label
    Friend WithEvents btnQuit As Button
End Class
