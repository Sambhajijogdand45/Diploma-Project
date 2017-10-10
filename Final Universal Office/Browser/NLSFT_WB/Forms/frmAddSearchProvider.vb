Imports System.Data.OleDb
Public Class frmAddSearchProvider

    Public strXML As String
    Dim oDs As New DataSet

    Private Sub frmAddSearchProvider_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        oDs.Dispose()
    End Sub

    Private Sub frmAddSearchProvider_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Here we are just using a simple method to read the xml file so we can 
        'add it to our own internal search provider datatable. Obviously you might want to
        'read the xml in a different way, for this example application...this does the trick.
        Label1.Text = "Do you want to add the following search provider to " & My.Resources.AppName & "?"
        Try
            oDs.ReadXml(Trim(strXML))
            Dim ofrm As New frmAddSearchProvider
            lblName.Text = AppManager.CurrentBrowser.Document.Domain
            lblFrom.Text = oDs.Tables(0).Rows(0).Item("ShortName")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If chkDefault.Checked Then
            setdefault()
        End If
        AddProvider()
    End Sub

    Private Sub AddProvider()
        'In this example application, we do not care if a user adds more than 1
        'of the same provider, so we will not check for that.
        Dim oConn As New OleDbConnection(AppManager.ConnString)
        Dim strSQL As String = _
        "INSERT INTO SearchProviders (ProviderTitle, ProviderURL, IsDefault) VALUES " & _
        "('" & oDs.Tables(0).Rows(0).Item("ShortName") & _
        "', '" & oDs.Tables(1).Rows(0).Item("Template") & _
        "', " & chkDefault.Checked & ")"
        Dim oCmd As New OleDbCommand(strSQL, oConn)

        Try
            oConn.Open()
            oCmd.ExecuteNonQuery()
            oConn.Close()
            AppManager.MainForm.LoadSearchProviders()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub SetDefault()
        Dim strSQL As String = "Update SearchProviders Set IsDefault=False"
        Dim oConn As New OleDbConnection(AppManager.ConnString)
        Dim oCmd As New OleDbCommand(strSQL, oConn)
        Try
            oConn.Open()
            oCmd.ExecuteNonQuery()
            oConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            oConn.Dispose()
            oCmd.Dispose()
        End Try
    End Sub

End Class