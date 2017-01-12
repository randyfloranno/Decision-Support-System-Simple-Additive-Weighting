<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenilaian
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvPenilaian = New System.Windows.Forms.DataGridView()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.dgvNormalisasi = New System.Windows.Forms.DataGridView()
        CType(Me.dgvPenilaian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvNormalisasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPenilaian
        '
        Me.dgvPenilaian.AllowUserToAddRows = False
        Me.dgvPenilaian.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        Me.dgvPenilaian.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPenilaian.BackgroundColor = System.Drawing.SystemColors.InactiveBorder
        Me.dgvPenilaian.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvPenilaian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPenilaian.Location = New System.Drawing.Point(12, 12)
        Me.dgvPenilaian.Name = "dgvPenilaian"
        Me.dgvPenilaian.Size = New System.Drawing.Size(442, 167)
        Me.dgvPenilaian.TabIndex = 26
        '
        'btnInsert
        '
        Me.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInsert.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInsert.Location = New System.Drawing.Point(563, 105)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(79, 39)
        Me.btnInsert.TabIndex = 39
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'dgvNormalisasi
        '
        Me.dgvNormalisasi.AllowUserToAddRows = False
        Me.dgvNormalisasi.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro
        Me.dgvNormalisasi.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvNormalisasi.BackgroundColor = System.Drawing.SystemColors.InactiveBorder
        Me.dgvNormalisasi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvNormalisasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNormalisasi.Location = New System.Drawing.Point(12, 185)
        Me.dgvNormalisasi.Name = "dgvNormalisasi"
        Me.dgvNormalisasi.ReadOnly = True
        Me.dgvNormalisasi.Size = New System.Drawing.Size(442, 167)
        Me.dgvNormalisasi.TabIndex = 40
        '
        'FormPenilaian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 361)
        Me.Controls.Add(Me.dgvNormalisasi)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.dgvPenilaian)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPenilaian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPenilaian"
        CType(Me.dgvPenilaian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvNormalisasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvPenilaian As System.Windows.Forms.DataGridView
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents dgvNormalisasi As System.Windows.Forms.DataGridView
End Class
