Imports System.Data.SqlClient
Public Class TRANSAKSI

    Private Sub BTNMENU_Click(sender As Object, e As EventArgs) Handles BTNMENU.Click
        Dim FR As New FR_MENU
        FR.Show()
        Me.Close()
    End Sub

    Private Sub BTNMINIMIZE_Click(sender As Object, e As EventArgs) Handles BTNMINIMIZE.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TXTKODE_TextChanged(sender As Object, e As EventArgs) Handles TXTKODE.TextChanged
        Dim STR As String = "SELECT KODE,MENU,STATUS,HARGA_SATUAN FROM TBL_MENU WHERE RTRIM(KODE)='" & TXTKODE.Text & "'"
        Dim CMD As New SqlCommand(STR, CONN)
        Dim RD As SqlDataReader
        RD = CMD.ExecuteReader
        If RD.HasRows Then
            RD.Read()
            TXTMENU.Text = RD.Item("MENU").ToString.Trim
            TXTSTATUS.Text = RD.Item("STATUS").ToString.Trim
            TXTHARGA.Text = CInt(RD.Item("HARGA_SATUAN"))
            RD.Close()
            MASUK_DATA()
            TXTKODE.Clear()
        Else
            RD.Close()
        End If
    End Sub

    Sub MASUK_DATA()
        Dim QTY As Integer = 0
        Dim ADA_DATA As Boolean = False
        Dim BARIS_DATA As Integer = 0

        For N = 0 To DGTAMPIL.Rows.Count - 1
            Dim KODE As String = DGTAMPIL.Item("KODE", N).Value
            If KODE = TXTKODE.Text Then
                ADA_DATA = True
                BARIS_DATA = N
                Exit For
            End If

        Next
        If ADA_DATA = True Then
            DGTAMPIL.Rows(BARIS_DATA).Cells("QTY").Value = DGTAMPIL.Rows(BARIS_DATA).Cells("QTY").Value + 1
            DGTAMPIL.Rows(DGTAMPIL.Rows.Count - 1).Cells("TOTAL").Value =
                DGTAMPIL.Rows(BARIS_DATA).Cells("QTY").Value * DGTAMPIL.Rows(BARIS_DATA).Cells("HARGA").Value
        Else
            DGTAMPIL.Rows.Add()
            DGTAMPIL.Rows(DGTAMPIL.Rows.Count - 1).Cells("KODE").Value = TXTKODE.Text
            DGTAMPIL.Rows(DGTAMPIL.Rows.Count - 1).Cells("MENU").Value = TXTMENU.Text
            DGTAMPIL.Rows(DGTAMPIL.Rows.Count - 1).Cells("STATUS").Value = TXTSTATUS.Text
            DGTAMPIL.Rows(DGTAMPIL.Rows.Count - 1).Cells("HARGA").Value = TXTHARGA.Text
            DGTAMPIL.Rows(DGTAMPIL.Rows.Count - 1).Cells("QTY").Value = "1"
            DGTAMPIL.Rows(DGTAMPIL.Rows.Count - 1).Cells("TOTAL").Value = TXTHARGA.Text
        End If
        TOTAL_HARGA()
    End Sub

    Private Sub DGTAMPIL_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGTAMPIL.CellEndEdit
        If e.ColumnIndex = 4 Then
            Dim QTY As String = ""
            QTY = DGTAMPIL.Item("QTY", e.RowIndex).Value
            If IsNumeric(QTY) Then
                DGTAMPIL.Item("TOTAL", e.RowIndex).Value = QTY * DGTAMPIL.Item("HARGA", e.RowIndex).Value
                TOTAL_HARGA()
            Else
                MsgBox("NILAI TIDAK VALID...")
                DGTAMPIL.Item("QTY", e.RowIndex).Value = QTY_LAMA
            End If
        End If
    End Sub

    Dim QTY_LAMA As Integer = 0
    Private Sub DGTAMPIL_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DGTAMPIL.CellBeginEdit
        If e.ColumnIndex = 4 Then
            QTY_LAMA = DGTAMPIL.Item("QTY", e.RowIndex).Value
        End If
    End Sub

    'LANGSUNG VIDIO 21 AKHIR'
    Sub TOTAL_HARGA()
        Dim TOTHARGA As Integer = 0
        For N = 0 To DGTAMPIL.Rows.Count - 1
            TOTHARGA = TOTHARGA + DGTAMPIL.Item("TOTAL", N).Value
        Next
        LBTOTAL.TEXT = FormatCurrency(TOTHARGA, 0)
    End Sub

    Private Sub BTNCARI_Click(sender As Object, e As EventArgs) Handles BTNCARI.Click
        BUKA_CARI()
    End Sub

    Private Sub TXTCARI_TextChanged(sender As Object, e As EventArgs) Handles TXTCARI.TextChanged
        Dim STR As String = "SELECT TOP 10 RTRIM(KODE) AS KODE,RTRIM(MENU) AS MENU,RTRIM(STATUS)" & _
        " AS STATUS,HARGA_SATUAN FROM TBL_MENU WHERE MENU LIKE '%" & TXTCARI.Text & "%'"
        Dim DA As New SqlDataAdapter(STR, CONN)
        Dim TBL As New DataTable
        DA.Fill(TBL)
        DGCARI.DataSource = TBL
    End Sub

    Private Sub DGCARI_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCARI.CellDoubleClick
        TXTKODE.Text = DGCARI.Item("KODE", e.RowIndex).Value
        PNCARI.Visible = False
    End Sub

    Private Sub BTNKELUAR_Click(sender As Object, e As EventArgs) Handles BTNKELUAR.Click
        TUTUP_CARI()
    End Sub


    Private Sub TRANSAKSI_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                If PNCARI.Visible = False Then
                    BUKA_CARI()
                Else
                    TUTUP_CARI()
                End If

            Case Keys.F2
                If PNBAYAR.Visible = False Then
                    BUKA_BAYAR()
                Else
                    TUTUP_BAYAR()
                End If

        End Select
    End Sub

    Sub BUKA_CARI()
        PNBAYAR.Visible = False
        PNCARI.Visible = True
        TXTCARI.Clear()
        TXTCARI.Select()
    End Sub

    Sub BUKA_BAYAR()
        If CInt(LBTOTAL.Text) <= 0 Then Exit Sub
        DGTAMPIL.Enabled = False
        PNCARI.Visible = False
        PNBAYAR.Visible = True
        TXTBAYAR.Text = CInt(LBTOTAL.Text)
        TXTTUNAI.Clear()
        TXTTUNAI.Select()
    End Sub

    Sub TUTUP_CARI()
        PNCARI.Visible = False
        TXTKODE.Select()
    End Sub

    Sub TUTUP_BAYAR()
        PNBAYAR.Visible = False
        DGTAMPIL.Enabled = True
        TXTKODE.Select()
    End Sub

    Private Sub BTNBAYAR_Click(sender As Object, e As EventArgs) Handles BTNBAYAR.Click
        BUKA_BAYAR()
    End Sub

    Private Sub BTNTUTUP_Click(sender As Object, e As EventArgs) Handles BTNTUTUP.Click
        TUTUP_BAYAR()
    End Sub

    Private Sub TXTTUNAI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTTUNAI.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            If CInt(TXTKEMBALIAN.Text) >= 0 Then
                MASUK_DATABASE()
            Else
                MsgBox("PEMBAYARAN TIDAK MENCUKUPI...")
            End If
        End If
    End Sub

    Private Sub TXTTUNAI_TextChanged(sender As Object, e As EventArgs) Handles TXTTUNAI.TextChanged
        If TXTTUNAI.Text = "" Then Exit Sub
        TXTKEMBALIAN.Text = TXTTUNAI.Text - TXTBAYAR.Text
    End Sub

 
    Private Sub DGTAMPIL_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGTAMPIL.CellMouseClick
        If DGTAMPIL.Rows.Count > 0 AndAlso e.RowIndex > -1 Then
            KLIK_KANAN.Show(Cursor.Position.X, Cursor.Position.Y)
        End If
    End Sub

    Private Sub HAPUSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HAPUSToolStripMenuItem.Click
        For Each ECELL As DataGridViewCell In DGTAMPIL.SelectedCells
            DGTAMPIL.Rows.RemoveAt(ECELL.RowIndex)
        Next
    End Sub

    'APAKAH JENIS DIUBAH STATUS'
    'TAMBAH KODE DIM STATUS'
    Sub MASUK_DATABASE()
        If DGTAMPIL.Rows.Count <= 0 Then Exit Sub
        For Each EROW As DataGridViewRow In DGTAMPIL.Rows
            Dim KODE As String = EROW.Cells("KODE").Value
            Dim STATUS As String = EROW.Cells("STATUS").Value
            Dim JUMLAH As Integer = EROW.Cells("QTY").Value
            Dim HARGA As Integer = EROW.Cells("TOTAL").Value

            Dim STR As String = "INSERT INTO TBL_TRANSAKSI (KODE,JUMLAH,STATUS,HARGA,TGL,ADMIN) VALUES" & _
                "('" & KODE & "','" & JUMLAH & "','" & STATUS & "','" & HARGA & "','" & Format(Date.Now, "MM/dd/yyyy") & "','" & nikAdmin & "')"

            Dim CMD As New SqlCommand(STR, CONN)
            CMD.ExecuteNonQuery()
        Next
        print_nota()
        TUTUP_BAYAR()
        DGTAMPIL.Rows.Clear()
        TOTAL_HARGA()
        TXTKODE.Select()

    End Sub

    Private Sub nota_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles nota.PrintPage
        Dim tinggi As Integer = 10
        e.Graphics.DrawString(nama_cafe, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString(no_cafe, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString(alamat_cafe, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 20
        e.Graphics.DrawString("---------------------------------", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Barang" & vbTab & vbTab & "Qty" & vbTab & "Total", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("---------------------------------", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        For Each erow As DataGridViewRow In DGTAMPIL.Rows
            tinggi = tinggi + 10
            e.Graphics.DrawString(erow.Cells("Menu").Value, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

            tinggi = tinggi + 10
            e.Graphics.DrawString(vbTab & vbTab & erow.Cells("QTY").Value & vbTab & erow.Cells("TOTAL").Value, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        Next

        tinggi = tinggi + 10
        e.Graphics.DrawString("---------------------------------", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Total" & vbTab & vbTab & ":" & TXTBAYAR.Text, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Tunai" & vbTab & vbTab & ":" & TXTTUNAI.Text, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Kembali" & vbTab & vbTab & ":" & TXTKEMBALIAN.Text, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("---------------------------------", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Terima Kasih Atas Kunjungan Anda", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)
    End Sub

    Sub print_nota()
        nota.PrinterSettings.PrinterName = printer_nota
        nota.Print()
    End Sub

    Private Sub FR_KELUAR_Load(sender As Object, e As EventArgs) Handles Me.Load
        ambil_data()
    End Sub

    Private Sub btntr_Click(sender As Object, e As EventArgs) Handles btntr.Click
        Dim tr As New Fr_trAdmin
        tr.ShowDialog()
    End Sub
End Class
