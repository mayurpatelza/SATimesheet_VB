Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmMain
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblFileName.Click

    End Sub

    Private Sub btnImportTimesheet_Click(sender As Object, e As EventArgs) Handles btnImportTimesheet.Click

        'open file dialog to pick file
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Select timesheet file"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            If strFileName <> "" Then
                lblFileValue.Text = strFileName
            End If
        End If

        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Open(strFileName)
        xlWorkSheet = xlWorkBook.Worksheets(1)
        'display the cells value B2
        MsgBox(xlWorkSheet.Cells(2, 2).value)




    End Sub
End Class
