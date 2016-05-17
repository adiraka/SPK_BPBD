Public Class main 

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AToolStripMenuItem.Click
        Dim NewMDIChild As New inDataPemohon()
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
    End Sub

    Private Sub TesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TesToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class