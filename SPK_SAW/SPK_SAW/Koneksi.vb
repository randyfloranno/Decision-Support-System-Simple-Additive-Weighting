Imports System.Data.SqlClient
Module Koneksi
    Public conn As SqlConnection
    Sub open()
        Try
            conn = New SqlConnection("data source=" & My.Computer.Name & "; database=SPK_SAW; Integrated Security=True")
            conn.Open()
        Catch ex As Exception
            MsgBox("Error While Establishing Database Connection !")
        End Try
    End Sub
End Module
