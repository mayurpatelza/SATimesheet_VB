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
        Me.SuspendLayout()
        '
        'btnImportTimesheet
        '
        Me.btnImportTimesheet.Location = New System.Drawing.Point(82, 42)
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
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 261)
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
End Class
