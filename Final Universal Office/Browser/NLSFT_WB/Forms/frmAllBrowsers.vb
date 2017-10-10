Public Class frmAllBrowsers

    Private Sub frmAllBrowsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.SplitContainer1.Panel1MinSize = Me.Width / 2
        'Dim ofrm As frmBrowser
        'Dim i As Integer
        'With AppManager.MainForm.tc1()
        '    For i = 0 To .TabPages.Count - 1
        '        If TypeOf .TabPages(i).Form Is frmBrowser Then
        '            ofrm = .TabPages(i).Form
        '            Dim ob As New CapBrowser
        '            ob.pb.Image = ofrm.PageImage.Image

        '            If IsOdd(i) Then
        '                ob.Top = SplitContainer1.Panel1.Controls.Count * ob.Height + 10
        '                ob.Width = Me.SplitContainer1.Panel1.Width
        '                Me.SplitContainer1.Panel1.Controls.Add(ob)
        '            Else
        '                ob.Top = SplitContainer1.Panel2.Controls.Count * ob.Height + 10
        '                ob.Width = Me.SplitContainer1.Panel2.Width
        '                Me.SplitContainer1.Panel2.Controls.Add(ob)
        '            End If
        '        End If
        '    Next
        'End With
    End Sub

    Public Function IsOdd(ByVal lngNumber As Long) As Boolean

        Return (lngNumber Mod 2)

    End Function

    Private Sub SplitContainer1_SplitterMoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.SplitterEventArgs) Handles SplitContainer1.SplitterMoved

    End Sub
End Class