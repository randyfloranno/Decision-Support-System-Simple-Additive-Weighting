<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuUtama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KriteriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntensityRatingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenilaianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.PenilaianToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KriteriaToolStripMenuItem, Me.IntensityRatingToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'KriteriaToolStripMenuItem
        '
        Me.KriteriaToolStripMenuItem.Name = "KriteriaToolStripMenuItem"
        Me.KriteriaToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.KriteriaToolStripMenuItem.Text = "Kriteria"
        '
        'IntensityRatingToolStripMenuItem
        '
        Me.IntensityRatingToolStripMenuItem.Name = "IntensityRatingToolStripMenuItem"
        Me.IntensityRatingToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.IntensityRatingToolStripMenuItem.Text = "Tempat"
        '
        'PenilaianToolStripMenuItem
        '
        Me.PenilaianToolStripMenuItem.Name = "PenilaianToolStripMenuItem"
        Me.PenilaianToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.PenilaianToolStripMenuItem.Text = "Penilaian"
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 750)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FormMenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KriteriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IntensityRatingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenilaianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
