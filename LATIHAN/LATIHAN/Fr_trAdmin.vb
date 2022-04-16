Imports System.Data.SqlClient
Public Class Fr_trAdmin

    Sub tampil()
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter("select a.ID,a.TGL,a.KODE,rtrim(b.menu) as MENU ,a.JUMLAH,a.HARGA from tbl_transaksi as a inner join tbl_menu as b on a.kode=b.kode where admin='" & txtNik.Text & "' and tgl='" & Format(dttgl.Value, "MM-dd-yyyy") & "'", CONN)
        Dim tbl As New DataTable
        da.Fill(tbl)
        Dgtampil.DataSource = tbl
        hitung_total()
    End Sub

    Private Sub txtNIk_TextChanged(sender As Object, e As EventArgs) Handles txtNik.TextChanged
        Dim cmd As New SqlCommand("select rtrim(nama) as nama from tbl_karyawan where rtrim(nik)='" & txtNik.Text & "'", CONN)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            txtNama.Text = rd.Item("nama").ToString
            rd.Close()
        Else
            rd.Close()
            txtNama.Clear()
        End If
        tampil()
    End Sub

    Private Sub Fr_trAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNik.Text = nikAdmin
    End Sub


    Sub hitung_total()
        Dim jlh As Long = 0
        For n = 0 To Dgtampil.Rows.Count - 1
            jlh = jlh + Dgtampil.Item("HARGA", n).Value
        Next
        txtJumlah.Text = jlh
    End Sub

    Private Sub dttgl_ValueChanged(sender As Object, e As EventArgs) Handles dttgl.ValueChanged
        tampil()
    End Sub
End Class
