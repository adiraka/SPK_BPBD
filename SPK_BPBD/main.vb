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

    Private Sub BToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BToolStripMenuItem.Click
        Dim NewMDIChild As New viDataPemohon()
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
    End Sub
End Class