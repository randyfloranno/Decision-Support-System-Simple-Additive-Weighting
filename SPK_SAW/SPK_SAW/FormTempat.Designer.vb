<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTempat
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
        Me.dgvTempat = New System.Windows.Forms.DataGridView()
        Me.txtNamaTempat = New System.Windows.Forms.TextBox()
        Me.lblNamaTempat = New System.Windows.Forms.Label()
        Me.lblKodeTempat = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.txtKodeTempat = New System.Windows.Forms.TextBox()
        CType(Me.dgvTempat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTempat
        '
        Me.dgvTempat.AllowUserToAddRows = False
        Me.dgvTempat.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        Me.dgvTempat.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTempat.BackgroundColor = System.Drawing.SystemColors.InactiveBorder
        Me.dgvTempat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTempat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTempat.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvTempat.Location = New System.Drawing.Point(13, 65)
        Me.dgvTempat.Name = "dgvTempat"
        Me.dgvTempat.Size = New System.Drawing.Size(438, 300)
        Me.dgvTempat.TabIndex = 55
        '
        'txtNamaTempat
        '
        Me.txtNamaTempat.Location = New System.Drawing.Point(96, 39)
        Me.txtNamaTempat.MaxLength = 50
        Me.txtNamaTempat.Name = "txtNamaTempat"
        Me.txtNamaTempat.Size = New System.Drawing.Size(174, 20)
        Me.txtNamaTempat.TabIndex = 50
        '
        'lblNamaTempat
        '
        Me.lblNamaTempat.AutoSize = True
        Me.lblNamaTempat.Location = New System.Drawing.Point(10, 43)
        Me.lblNamaTempat.Name = "lblNamaTempat"
        Me.lblNamaTempat.Size = New System.Drawing.Size(80, 13)
        Me.lblNamaTempat.TabIndex = 54
        Me.lblNamaTempat.Text = "Nama Tempat :"
        '
        'lblKodeTempat
        '
        Me.lblKodeTempat.AutoSize = True
        Me.lblKodeTempat.Location = New System.Drawing.Point(13, 15)
        Me.lblKodeTempat.Name = "lblKodeTempat"
        Me.lblKodeTempat.Size = New System.Drawing.Size(77, 13)
        Me.lblKodeTempat.TabIndex = 49
        Me.lblKodeTempat.Text = "Kode Tempat :"
        '
        'btnUpdate
        '
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(371, 15)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 39)
        Me.btnUpdate.TabIndex = 52
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInsert.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInsert.Location = New System.Drawing.Point(286, 15)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(79, 39)
        Me.btnInsert.TabIndex = 51
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'txtKodeTempat
        '
        Me.txtKodeTempat.Location = New System.Drawing.Point(96, 12)
        Me.txtKodeTempat.MaxLength = 5
        Me.txtKodeTempat.Name = "txtKodeTempat"
        Me.txtKodeTempat.ReadOnly = True
        Me.txtKodeTempat.Size = New System.Drawing.Size(174, 20)
        Me.txtKodeTempat.TabIndex = 53
        '
        'FormTempat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 377)
        Me.Controls.Add(Me.dgvTempat)
        Me.Controls.Add(Me.txtNamaTempat)
        Me.Controls.Add(Me.lblNamaTempat)
        Me.Controls.Add(Me.lblKodeTempat)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.txtKodeTempat)
        Me.Name = "FormTempat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormTempat"
        CType(Me.dgvTempat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvTempat As System.Windows.Forms.DataGridView
    Friend WithEvents txtNamaTempat As System.Windows.Forms.TextBox
    Friend WithEvents lblNamaTempat As System.Windows.Forms.Label
    Friend WithEvents lblKodeTempat As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents txtKodeTempat As System.Windows.Forms.TextBox
End Class
