Imports System.Data.SqlClient
Public Class FormMenuUtama
    Private Sub FormMenuUtama_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        open()
    End Sub

    Private Sub KriteriaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KriteriaToolStripMenuItem.Click
        FormKriteria.ShowDialog()
    End Sub

    Private Sub IntensityRatingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IntensityRatingToolStripMenuItem.Click
        FormTempat.ShowDialog()
    End Sub

    Private Sub PenilaianToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PenilaianToolStripMenuItem.Click
        FormPenilaian.ShowDialog()
    End Sub
End Class
