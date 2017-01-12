Imports System.Data.SqlClient
Public Class FormKriteria
    Dim comm As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim da2 As SqlDataAdapter
    Dim ds2 As DataSet
    Dim rdr As SqlDataReader
    Dim a As String
    Dim b As String
    Dim cek As String
    Dim jenis As String
    Private Sub FormKriteria_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            cmbJenisKriteria.SelectedIndex = 0
            tampil()
        Catch ex As Exception

        End Try
    End Sub

    Sub tampil()
        da = New SqlDataAdapter("select * from kriteria order by kode_kriteria asc", conn)
        ds = New DataSet
        da.Fill(ds, "kriteria")
        dgvKriteria.DataSource = ds.Tables("kriteria")
    End Sub

    Sub clear()
        txtKodeKriteria.Text = " "
        txtNamaKriteria.Text = ""
        cmbJenisKriteria.Text = ""
        txtBobot.Value = 1
    End Sub

    Private Sub btnInsert_Click(sender As System.Object, e As System.EventArgs) Handles btnInsert.Click
        Try
            If txtNamaKriteria.Text = "" Then
                MsgBox("Data Tidak Boleh Kosong!")
            Else
                comm = New SqlCommand("select dbo.cekNamaKriteriaIns('" & txtNamaKriteria.Text & "')", conn)
                cek = comm.ExecuteScalar
                If (cek = "tidak boleh") Then
                    MsgBox("Data sudah ada !")
                Else
                    comm.Dispose()
                    comm = New SqlCommand("dbo.insKriteria", conn)
                    comm.CommandType = CommandType.StoredProcedure
                    comm.Parameters.Add("@nama_kriteria", SqlDbType.VarChar, 100).Value = txtNamaKriteria.Text
                    comm.Parameters.Add("@jenis_kriteria", SqlDbType.VarChar, 10).Value = cmbJenisKriteria.Text
                    comm.Parameters.Add("@bobot_kriteria", SqlDbType.Int).Value = txtBobot.Text
                    comm.ExecuteNonQuery()
                    MsgBox("Simpan Sukses!")
                    tampil()
                    comm.Dispose()
                End If
            clear()
            txtNamaKriteria.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            clear()
            txtNamaKriteria.Focus()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        Try
            If txtNamaKriteria.Text = "" Then
                MsgBox("Data tidak boleh kosong !")
            Else
                comm = New SqlCommand("select dbo.cekNamaKriteriaUpd('" & txtKodeKriteria.Text & "', '" & txtNamaKriteria.Text & "')", conn)
                cek = comm.ExecuteScalar
                If (cek = "tidak boleh") Then
                    MsgBox("Data sudah ada !")
                    clear()
                    btnInsert.Enabled = True
                    btnUpdate.Enabled = False
                    txtNamaKriteria.Focus()
                Else
                    If (jenis <> cmbJenisKriteria.Text) Then
                        comm.Dispose()
                        comm = New SqlCommand("dbo.updKriteria", conn)
                        comm.CommandType = CommandType.StoredProcedure
                        comm.Parameters.Add("@kode_kriteria", SqlDbType.VarChar, 13).Value = txtKodeKriteria.Text
                        comm.Parameters.Add("@nama_kriteria", SqlDbType.VarChar, 100).Value = txtNamaKriteria.Text
                        comm.Parameters.Add("@jenis_kriteria", SqlDbType.VarChar, 10).Value = cmbJenisKriteria.Text
                        comm.Parameters.Add("@bobot_kriteria", SqlDbType.Int).Value = txtBobot.Text
                        comm.ExecuteNonQuery()
                        MsgBox("Update Sukses!")
                        tampil()

                        comm.Dispose()
                        comm = New SqlCommand("dbo.updDetilPenilaian2", conn)
                        comm.CommandType = CommandType.StoredProcedure
                        comm.ExecuteNonQuery()
                    Else
                        comm.Dispose()
                        comm = New SqlCommand("dbo.updKriteria", conn)
                        comm.CommandType = CommandType.StoredProcedure
                        comm.Parameters.Add("@kode_kriteria", SqlDbType.VarChar, 13).Value = txtKodeKriteria.Text
                        comm.Parameters.Add("@nama_kriteria", SqlDbType.VarChar, 100).Value = txtNamaKriteria.Text
                        comm.Parameters.Add("@jenis_kriteria", SqlDbType.VarChar, 10).Value = cmbJenisKriteria.Text
                        comm.Parameters.Add("@bobot_kriteria", SqlDbType.Int).Value = txtBobot.Text
                        comm.ExecuteNonQuery()
                        MsgBox("Update Sukses!")
                        tampil()
                    End If
                End If
                clear()
                txtNamaKriteria.Focus()
                comm.Dispose()
                btnInsert.Enabled = True
                btnUpdate.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            clear()
        End Try
    End Sub

    Private Sub dgvKriteria_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvKriteria.CellClick
        Try
            txtKodeKriteria.Text = " "
            txtNamaKriteria.Text = ""
            btnInsert.Enabled = True
            btnUpdate.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvKriteria_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvKriteria.CellDoubleClick
        Try
            btnInsert.Enabled = False
            btnUpdate.Enabled = True
            txtNamaKriteria.Focus()
            txtKodeKriteria.Text = dgvKriteria.CurrentRow.Cells(0).Value
            txtNamaKriteria.Text = dgvKriteria.CurrentRow.Cells(1).Value
            cmbJenisKriteria.Text = dgvKriteria.CurrentRow.Cells(2).Value
            txtBobot.Value = dgvKriteria.CurrentRow.Cells(3).Value
            jenis = cmbJenisKriteria.Text
        Catch ex As Exception

        End Try
    End Sub
End Class