Imports System.Data.SqlClient
Public Class FormTempat
    Dim comm As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim da2 As SqlDataAdapter
    Dim ds2 As DataSet
    Dim rdr As SqlDataReader
    Dim a As String
    Dim b As String
    Dim cek As String
    Dim status As String
    Private Sub FormTempat_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            tampil()
        Catch ex As Exception

        End Try
    End Sub

    Sub tampil()
        da = New SqlDataAdapter("select * from tempat order by kode_tempat asc", conn)
        ds = New DataSet
        da.Fill(ds, "tempat")
        dgvTempat.DataSource = ds.Tables("tempat")
    End Sub

    Sub clear()
        txtKodeTempat.Text = " "
        txtNamaTempat.Text = ""
    End Sub

    Private Sub btnInsert_Click(sender As System.Object, e As System.EventArgs) Handles btnInsert.Click
        Try
            If txtNamaTempat.Text = "" Then
                MsgBox("Data Tidak Boleh Kosong!")
            Else
                comm = New SqlCommand("select dbo.cekNamaTempatIns('" & txtNamaTempat.Text & "')", conn)
                cek = comm.ExecuteScalar
                If (cek = "tidak boleh") Then
                    MsgBox("Data sudah ada !")
                Else
                    comm.Dispose()
                    comm.Dispose()
                    comm = New SqlCommand("dbo.insTempat", conn)
                    comm.CommandType = CommandType.StoredProcedure
                    comm.Parameters.Add("@nama_Tempat", SqlDbType.VarChar, 100).Value = txtNamaTempat.Text
                    comm.ExecuteNonQuery()
                    MsgBox("Simpan Sukses!")
                    tampil()
                    comm.Dispose()
                End If
                clear()
                txtNamaTempat.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            clear()
            txtNamaTempat.Focus()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        Try
            If txtNamaTempat.Text = "" Then
                MsgBox("Data tidak boleh kosong !")
            Else
                comm = New SqlCommand("select dbo.cekNamaKriteriaUpd('" & txtKodeTempat.Text & "', '" & txtNamaTempat.Text & "')", conn)
                cek = comm.ExecuteScalar
                If (cek = "tidak boleh") Then
                    MsgBox("Data sudah ada !")
                    clear()
                    btnInsert.Enabled = True
                    btnUpdate.Enabled = False
                    txtNamaTempat.Focus()
                Else
                    comm.Dispose()
                    comm.Dispose()
                    comm = New SqlCommand("dbo.updTempat", conn)
                    comm.CommandType = CommandType.StoredProcedure
                    comm.Parameters.Add("@kode_tempat", SqlDbType.VarChar, 13).Value = txtKodeTempat.Text
                    comm.Parameters.Add("@nama_tempat", SqlDbType.VarChar, 100).Value = txtNamaTempat.Text
                    comm.ExecuteNonQuery()
                    MsgBox("Update Sukses!")
                    tampil()
                End If
                clear()
                txtNamaTempat.Focus()
                comm.Dispose()
                btnInsert.Enabled = True
                btnUpdate.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            clear()
        End Try
    End Sub

    Private Sub dgvTempat_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTempat.CellClick
        Try
            txtKodeTempat.Text = " "
            txtNamaTempat.Text = ""
            btnInsert.Enabled = True
            btnUpdate.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvTempat_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTempat.CellDoubleClick
        Try
            btnInsert.Enabled = False
            btnUpdate.Enabled = True
            txtNamaTempat.Focus()
            txtKodeTempat.Text = dgvTempat.CurrentRow.Cells(0).Value
            txtNamaTempat.Text = dgvTempat.CurrentRow.Cells(1).Value
        Catch ex As Exception

        End Try
    End Sub
End Class