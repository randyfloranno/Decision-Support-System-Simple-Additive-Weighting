Imports System.Data.SqlClient
Public Class FormPenilaian
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
    Dim jumlahKriteria As Integer
    Dim jumlahTempat As Integer
    Private Sub FormPenilaian_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            comm = New SqlCommand("select count (nama_kriteria) from kriteria", conn)
            jumlahkriteria = comm.ExecuteScalar()
            comm.Dispose()
            comm = New SqlCommand("select count (nama_tempat) from tempat", conn)
            jumlahTempat = comm.ExecuteScalar()
            comm.Dispose()
            dgvPenilaian.ColumnCount = jumlahKriteria
            dgvPenilaian.RowCount = jumlahTempat
            dgvNormalisasi.ColumnCount = jumlahKriteria
            dgvNormalisasi.RowCount = jumlahTempat

            comm = New SqlCommand("select nama_kriteria from kriteria", conn)
            Dim i As Integer = 0
            rdr = comm.ExecuteReader()
            While rdr.Read()
                dgvPenilaian.Columns(i).Name = (rdr("nama_kriteria"))
                dgvNormalisasi.Columns(i).Name = (rdr("nama_kriteria"))
                i = i + 1
            End While
            rdr.Close()
            comm.Dispose()

            comm = New SqlCommand("select nama_tempat from tempat", conn)
            Dim i2 As Integer = 0
            rdr = comm.ExecuteReader()
            While rdr.Read()
                dgvPenilaian.Rows.Item(i2).HeaderCell.Value = (rdr("nama_tempat"))
                dgvNormalisasi.Rows.Item(i2).HeaderCell.Value = (rdr("nama_tempat"))
                i2 = i2 + 1
            End While
            rdr.Close()
            comm.Dispose()
            dgvPenilaian.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders)
            dgvNormalisasi.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders)

            '--------------------------------------------------------------------------------------
            For y As Integer = 0 To jumlahKriteria - 1
                For x As Integer = 0 To jumlahTempat - 1
                    comm = New SqlCommand("select kode_kriteria from kriteria where nama_kriteria = ('" & dgvPenilaian.Columns(y).Name & "')", conn)
                    a = comm.ExecuteScalar
                    comm.Dispose()
                    comm = New SqlCommand("select kode_tempat from tempat where nama_tempat = ('" & dgvPenilaian.Rows.Item(x).HeaderCell.Value & "')", conn)
                    b = comm.ExecuteScalar
                    comm.Dispose()

                    comm = New SqlCommand("select dp_nilai from detil_penilaian where kode_kriteria = '" & a & "' and kode_tempat = '" & b & "'", conn)
                    dgvPenilaian.Item(y, x).Value = comm.ExecuteScalar()
                    comm.Dispose()

                    comm = New SqlCommand("select dp_normalisasi from detil_penilaian where kode_kriteria = '" & a & "' and kode_tempat = '" & b & "'", conn)
                    dgvNormalisasi.Item(y, x).Value = comm.ExecuteScalar()
                    comm.Dispose()
                Next
            Next

            comm.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvPenilaian_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPenilaian.CellEndEdit
        Try
            btnInsert.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnInsert_Click(sender As System.Object, e As System.EventArgs) Handles btnInsert.Click
        Try
            comm = New SqlCommand("select dbo.cekDetilPenilaian('" & dgvPenilaian.Columns(dgvPenilaian.CurrentCell.ColumnIndex).Name & "', '" & dgvPenilaian.Rows.Item(dgvPenilaian.CurrentCell.RowIndex).HeaderCell.Value & "')", conn)
            Dim cek As String = comm.ExecuteScalar
            If (cek = "tidak ada") Then
                comm.Dispose()
                comm = New SqlCommand("dbo.insDetilPenilaian", conn)
                comm.CommandType = CommandType.StoredProcedure
                comm.Parameters.Add("@nama_kriteria", SqlDbType.VarChar, 100).Value = dgvPenilaian.Columns(dgvPenilaian.CurrentCell.ColumnIndex).Name
                comm.Parameters.Add("@nama_tempat", SqlDbType.VarChar, 100).Value = dgvPenilaian.Rows.Item(dgvPenilaian.CurrentCell.RowIndex).HeaderCell.Value
                comm.Parameters.Add("@dp_nilai", SqlDbType.Decimal, 18, 2).Value = dgvPenilaian.CurrentCell.Value
                comm.ExecuteNonQuery()
            Else
                comm.Dispose()
                comm = New SqlCommand("dbo.updDetilPenilaian", conn)
                comm.CommandType = CommandType.StoredProcedure
                comm.Parameters.Add("@nama_kriteria", SqlDbType.VarChar, 100).Value = dgvPenilaian.Columns(dgvPenilaian.CurrentCell.ColumnIndex).Name
                comm.Parameters.Add("@nama_tempat", SqlDbType.VarChar, 100).Value = dgvPenilaian.Rows.Item(dgvPenilaian.CurrentCell.RowIndex).HeaderCell.Value
                comm.Parameters.Add("@dp_nilai", SqlDbType.Decimal, 18, 2).Value = dgvPenilaian.CurrentCell.Value
                comm.ExecuteNonQuery()
            End If
            comm.Dispose()
            FormPenilaian_Load(Me, New System.EventArgs)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class