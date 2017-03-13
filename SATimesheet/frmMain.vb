Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmMain

    Dim iTargetRow As Integer
    Dim iAuditRow As Integer

    Private Sub btnImportTimesheet_Click(sender As Object, e As EventArgs) Handles btnImportTimesheet.Click

        'open file dialog to pick file
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim sSourceTimesheet As String

        fd.Title = "Select timesheet file"
        fd.InitialDirectory = "D:\Cloud Storage\OneDrive\Documents\Simply Asia Thrupps\20170214 Wages"
        'fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        fd.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        sSourceTimesheet = ""
        If fd.ShowDialog() = DialogResult.OK Then
            sSourceTimesheet = fd.FileName
            If sSourceTimesheet <> "" Then
                lblFileValue.Text = sSourceTimesheet
            Else
                MsgBox("No file found", MsgBoxStyle.Critical)
                Exit Sub
            End If
        Else
            MsgBox("File selection cancelled", MsgBoxStyle.Critical)
            Exit Sub
        End If

        'setup source excel workbook - existing timesheet
        Dim xlSourceApp As Excel.Application
        Dim xlSourceWorkBook As Excel.Workbook
        Dim xlSourceWorkSheet As Excel.Worksheet


        xlSourceApp = New Excel.Application
        xlSourceWorkBook = xlSourceApp.Workbooks.Open(sSourceTimesheet)
        xlSourceWorkSheet = xlSourceWorkBook.Worksheets(1)

        'setup target eexcel workbook - filtered records for wages
        Dim xlTargetApp As Excel.Application
        Dim xlTargetWorkBook As Excel.Workbook
        Dim xlTargetWorkSheet As Excel.Worksheet
        Dim xlTargetAuditSheet As Excel.Worksheet

        xlTargetApp = New Excel.Application
        xlTargetWorkBook = xlTargetApp.Workbooks.Add()
        xlTargetWorkSheet = xlTargetWorkBook.Worksheets(1)
        xlTargetAuditSheet = CType(xlTargetWorkBook.Worksheets.Add(), Excel.Worksheet)

        iTargetRow = 1  'account for target sheet header row
        iAuditRow = 1  'account for audit sheet header row

        parseTimesheet(xlSourceWorkSheet, xlTargetWorkSheet, xlTargetAuditSheet)

        'Save and close target excel
        Dim iLastIndex = sSourceTimesheet.LastIndexOf("\")
        Dim sTargetFilePath As String
        If iLastIndex > 0 Then
            sTargetFilePath = Microsoft.VisualBasic.Left(sSourceTimesheet, iLastIndex)
        Else
            sTargetFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        End If

        xlTargetWorkBook.SaveAs(sTargetFilePath & "\Target.xlsx", 51)

        xlTargetWorkBook.Close()
        xlTargetApp.Quit()
        releaseObject(xlTargetApp)
        releaseObject(xlTargetWorkBook)
        releaseObject(xlTargetWorkSheet)
        xlTargetApp = Nothing

        'close source excel
        xlSourceWorkBook.Close(False)
        xlSourceApp.Quit()
        releaseObject(xlSourceApp)
        releaseObject(xlSourceWorkBook)
        releaseObject(xlSourceWorkSheet)
        xlSourceApp = Nothing

    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub parseTimesheet(xSource As Excel.Worksheet, xTarget As Excel.Worksheet, xAudit As Excel.Worksheet)
        Dim xlRange As Excel.Range
        Dim xlRow As Integer
        Dim iMaxRows As Integer
        Dim iMaxCols As Integer

        'TODO: copy heading line

        xlRange = xSource.UsedRange

        iMaxRows = xlRange.Rows.Count
        iMaxCols = xlRange.Columns.Count
        prgbrTimes.Maximum = iMaxRows

        'setup header row for target sheet
        xTarget.Cells(1, 1) = "Old Row No"
        xTarget.Cells(1, 2) = CType(xlRange.Cells(1, 1), Excel.Range)
        xTarget.Cells(1, 3) = CType(xlRange.Cells(1, 2), Excel.Range)
        xTarget.Cells(1, 4) = CType(xlRange.Cells(1, 3), Excel.Range)
        xTarget.Cells(1, 5) = CType(xlRange.Cells(1, 4), Excel.Range)
        xTarget.Cells(1, 6) = CType(xlRange.Cells(1, 5), Excel.Range)
        xTarget.Cells(1, 7) = CType(xlRange.Cells(1, 6), Excel.Range)
        xTarget.Cells(1, 8) = CType(xlRange.Cells(1, 7), Excel.Range)
        xTarget.Cells(1, 9) = CType(xlRange.Cells(1, 8), Excel.Range)

        'setup header row for audit sheet
        xAudit.Cells(1, 1) = "Old Row No"
        xAudit.Cells(1, 2) = "Issue / Comment"

        For xlRow = 2 To xlRange.Rows.Count
            prgbrTimes.Value = xlRow
            lblProgressRecords.Text = xlRow & " / " & iMaxRows
            parseTimesheetLine(xlRange, xlRow, iMaxCols, iMaxRows, xSource, xTarget, xAudit)
        Next

    End Sub

    Private Sub parseTimesheetLine(xlRange As Excel.Range, iRow As Integer, iMaxCols As Integer, iMaxRows As Integer, xSource As Excel.Worksheet, xTarget As Excel.Worksheet, xAudit As Excel.Worksheet)

        'not sure yet if i need the previous line or the next line to figure out multiple logins and delayed logouts

        'exlcude row if completed = false
        If (String.Compare(CType(xlRange.Cells(iRow, 8), Excel.Range).Value, "False") <> 0) Then
            iTargetRow += 1

            'copy all needed columns to new sheet
            xTarget.Cells(iTargetRow, 1) = iRow
            xTarget.Cells(iTargetRow, 2) = CType(xlRange.Cells(iRow, 1), Excel.Range)
            xTarget.Cells(iTargetRow, 3) = CType(xlRange.Cells(iRow, 2), Excel.Range)
            xTarget.Cells(iTargetRow, 4) = CType(xlRange.Cells(iRow, 3), Excel.Range)
            xTarget.Cells(iTargetRow, 5) = CType(xlRange.Cells(iRow, 4), Excel.Range)
            xTarget.Cells(iTargetRow, 6) = CType(xlRange.Cells(iRow, 5), Excel.Range)
            xTarget.Cells(iTargetRow, 7) = CType(xlRange.Cells(iRow, 6), Excel.Range)
            xTarget.Cells(iTargetRow, 8) = CType(xlRange.Cells(iRow, 7), Excel.Range)
            xTarget.Cells(iTargetRow, 9) = CType(xlRange.Cells(iRow, 8), Excel.Range)

        Else
            'write line on audit sheet
            iAuditRow += 1
            xAudit.Cells(iAuditRow, 1) = iRow
            xAudit.Cells(iAuditRow, 2) = "Completed is false"


        End If

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Close()
    End Sub
End Class
