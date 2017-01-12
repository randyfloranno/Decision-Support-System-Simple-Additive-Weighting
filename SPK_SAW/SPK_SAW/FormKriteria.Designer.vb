<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKriteria
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbJenisKriteria = New System.Windows.Forms.ComboBox()
        Me.dgvKriteria = New System.Windows.Forms.DataGridView()
        Me.txtNamaKriteria = New System.Windows.Forms.TextBox()
        Me.lblNamaKriteria = New System.Windows.Forms.Label()
        Me.lblKodeKriteria = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.txtKodeKriteria = New System.Windows.Forms.TextBox()
        Me.txtBobot = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvKriteria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBobot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Jenis Kriteria :"
        '
        'cmbJenisKriteria
        '
        Me.cmbJenisKriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbJenisKriteria.FormattingEnabled = True
        Me.cmbJenisKriteria.Items.AddRange(New Object() {"max", "min"})
        Me.cmbJenisKriteria.Location = New System.Drawing.Point(94, 65)
        Me.cmbJenisKriteria.MaxLength = 11
        Me.cmbJenisKriteria.Name = "cmbJenisKriteria"
        Me.cmbJenisKriteria.Size = New System.Drawing.Size(139, 21)
        Me.cmbJenisKriteria.TabIndex = 45
        '
        'dgvKriteria
        '
        Me.dgvKriteria.AllowUserToAddRows = False
        Me.dgvKriteria.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro
        Me.dgvKriteria.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvKriteria.BackgroundColor = System.Drawing.SystemColors.InactiveBorder
        Me.dgvKriteria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvKriteria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKriteria.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvKriteria.Location = New System.Drawing.Point(15, 119)
        Me.dgvKriteria.Name = "dgvKriteria"
        Me.dgvKriteria.Size = New System.Drawing.Size(438, 300)
        Me.dgvKriteria.TabIndex = 42
        '
        'txtNamaKriteria
        '
        Me.txtNamaKriteria.Location = New System.Drawing.Point(94, 38)
        Me.txtNamaKriteria.MaxLength = 50
        Me.txtNamaKriteria.Name = "txtNamaKriteria"
        Me.txtNamaKriteria.Size = New System.Drawing.Size(174, 20)
        Me.txtNamaKriteria.TabIndex = 37
        '
        'lblNamaKriteria
        '
        Me.lblNamaKriteria.AutoSize = True
        Me.lblNamaKriteria.Location = New System.Drawing.Point(12, 42)
        Me.lblNamaKriteria.Name = "lblNamaKriteria"
        Me.lblNamaKriteria.Size = New System.Drawing.Size(76, 13)
        Me.lblNamaKriteria.TabIndex = 41
        Me.lblNamaKriteria.Text = "Nama Kriteria :"
        '
        'lblKodeKriteria
        '
        Me.lblKodeKriteria.AutoSize = True
        Me.lblKodeKriteria.Location = New System.Drawing.Point(15, 16)
        Me.lblKodeKriteria.Name = "lblKodeKriteria"
        Me.lblKodeKriteria.Size = New System.Drawing.Size(73, 13)
        Me.lblKodeKriteria.TabIndex = 36
        Me.lblKodeKriteria.Text = "Kode Kriteria :"
        '
        'btnUpdate
        '
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(373, 47)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 39)
        Me.btnUpdate.TabIndex = 39
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInsert.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInsert.Location = New System.Drawing.Point(288, 47)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(79, 39)
        Me.btnInsert.TabIndex = 38
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'txtKodeKriteria
        '
        Me.txtKodeKriteria.Location = New System.Drawing.Point(94, 12)
        Me.txtKodeKriteria.MaxLength = 5
        Me.txtKodeKriteria.Name = "txtKodeKriteria"
        Me.txtKodeKriteria.ReadOnly = True
        Me.txtKodeKriteria.Size = New System.Drawing.Size(174, 20)
        Me.txtKodeKriteria.TabIndex = 40
        '
        'txtBobot
        '
        Me.txtBobot.Location = New System.Drawing.Point(94, 93)
        Me.txtBobot.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.txtBobot.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtBobot.Name = "txtBobot"
        Me.txtBobot.Size = New System.Drawing.Size(79, 20)
        Me.txtBobot.TabIndex = 47
        Me.txtBobot.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Bobot Kriteria :"
        '
        'FormKriteria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 431)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBobot)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbJenisKriteria)
        Me.Controls.Add(Me.dgvKriteria)
        Me.Controls.Add(Me.txtNamaKriteria)
        Me.Controls.Add(Me.lblNamaKriteria)
        Me.Controls.Add(Me.lblKodeKriteria)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.txtKodeKriteria)
        Me.Name = "FormKriteria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormKriteria"
        CType(Me.dgvKriteria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBobot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbJenisKriteria As System.Windows.Forms.ComboBox
    Friend WithEvents dgvKriteria As System.Windows.Forms.DataGridView
    Friend WithEvents txtNamaKriteria As System.Windows.Forms.TextBox
    Friend WithEvents lblNamaKriteria As System.Windows.Forms.Label
    Friend WithEvents lblKodeKriteria As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents txtKodeKriteria As System.Windows.Forms.TextBox
    Friend WithEvents txtBobot As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
