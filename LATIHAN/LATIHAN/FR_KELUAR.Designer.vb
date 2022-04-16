<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TRANSAKSI
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PNATAS = New System.Windows.Forms.Panel()
        Me.PNCARI = New System.Windows.Forms.Panel()
        Me.DGCARI = New System.Windows.Forms.DataGridView()
        Me.BTNKELUAR = New System.Windows.Forms.Button()
        Me.TXTCARI = New System.Windows.Forms.TextBox()
        Me.BTNMENU = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LBTOTAL = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTNCARI = New System.Windows.Forms.Button()
        Me.TXTHARGA = New System.Windows.Forms.TextBox()
        Me.TXTSTATUS = New System.Windows.Forms.TextBox()
        Me.TXTMENU = New System.Windows.Forms.TextBox()
        Me.TXTKODE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNMINIMIZE = New System.Windows.Forms.Button()
        Me.PNBAYAR = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BTNTUTUP = New System.Windows.Forms.Button()
        Me.TXTKEMBALIAN = New System.Windows.Forms.TextBox()
        Me.TXTTUNAI = New System.Windows.Forms.TextBox()
        Me.TXTBAYAR = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PNBAWAH = New System.Windows.Forms.Panel()
        Me.BTNBAYAR = New System.Windows.Forms.Button()
        Me.DGTAMPIL = New System.Windows.Forms.DataGridView()
        Me.KODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MENU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HARGA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KLIK_KANAN = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HAPUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.nota = New System.Drawing.Printing.PrintDocument()
        Me.btntr = New System.Windows.Forms.Button()
        Me.PNATAS.SuspendLayout()
        Me.PNCARI.SuspendLayout()
        CType(Me.DGCARI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PNBAYAR.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.PNBAWAH.SuspendLayout()
        CType(Me.DGTAMPIL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KLIK_KANAN.SuspendLayout()
        Me.SuspendLayout()
        '
        'PNATAS
        '
        Me.PNATAS.Controls.Add(Me.PNCARI)
        Me.PNATAS.Controls.Add(Me.BTNMENU)
        Me.PNATAS.Controls.Add(Me.GroupBox2)
        Me.PNATAS.Controls.Add(Me.GroupBox1)
        Me.PNATAS.Controls.Add(Me.BTNMINIMIZE)
        Me.PNATAS.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNATAS.Location = New System.Drawing.Point(0, 0)
        Me.PNATAS.Name = "PNATAS"
        Me.PNATAS.Size = New System.Drawing.Size(1045, 176)
        Me.PNATAS.TabIndex = 0
        '
        'PNCARI
        '
        Me.PNCARI.Controls.Add(Me.DGCARI)
        Me.PNCARI.Controls.Add(Me.BTNKELUAR)
        Me.PNCARI.Controls.Add(Me.TXTCARI)
        Me.PNCARI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PNCARI.Location = New System.Drawing.Point(0, 0)
        Me.PNCARI.Name = "PNCARI"
        Me.PNCARI.Size = New System.Drawing.Size(1045, 176)
        Me.PNCARI.TabIndex = 3
        Me.PNCARI.Visible = False
        '
        'DGCARI
        '
        Me.DGCARI.AllowUserToAddRows = False
        Me.DGCARI.AllowUserToDeleteRows = False
        Me.DGCARI.AllowUserToResizeColumns = False
        Me.DGCARI.AllowUserToResizeRows = False
        Me.DGCARI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGCARI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGCARI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGCARI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCARI.Location = New System.Drawing.Point(3, 29)
        Me.DGCARI.Name = "DGCARI"
        Me.DGCARI.ReadOnly = True
        Me.DGCARI.RowHeadersVisible = False
        Me.DGCARI.Size = New System.Drawing.Size(1017, 144)
        Me.DGCARI.TabIndex = 2
        '
        'BTNKELUAR
        '
        Me.BTNKELUAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNKELUAR.BackColor = System.Drawing.Color.Red
        Me.BTNKELUAR.Location = New System.Drawing.Point(961, 4)
        Me.BTNKELUAR.Name = "BTNKELUAR"
        Me.BTNKELUAR.Size = New System.Drawing.Size(75, 23)
        Me.BTNKELUAR.TabIndex = 1
        Me.BTNKELUAR.Text = "X"
        Me.BTNKELUAR.UseVisualStyleBackColor = False
        '
        'TXTCARI
        '
        Me.TXTCARI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTCARI.Location = New System.Drawing.Point(5, 6)
        Me.TXTCARI.Name = "TXTCARI"
        Me.TXTCARI.Size = New System.Drawing.Size(952, 20)
        Me.TXTCARI.TabIndex = 0
        '
        'BTNMENU
        '
        Me.BTNMENU.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNMENU.BackColor = System.Drawing.Color.Red
        Me.BTNMENU.Location = New System.Drawing.Point(992, 12)
        Me.BTNMENU.Name = "BTNMENU"
        Me.BTNMENU.Size = New System.Drawing.Size(44, 23)
        Me.BTNMENU.TabIndex = 11
        Me.BTNMENU.Text = "X"
        Me.BTNMENU.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.LBTOTAL)
        Me.GroupBox2.Location = New System.Drawing.Point(383, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(659, 131)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TOTAL BARANG"
        '
        'LBTOTAL
        '
        Me.LBTOTAL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBTOTAL.Font = New System.Drawing.Font("Arial Black", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBTOTAL.Location = New System.Drawing.Point(6, 16)
        Me.LBTOTAL.Name = "LBTOTAL"
        Me.LBTOTAL.Size = New System.Drawing.Size(644, 112)
        Me.LBTOTAL.TabIndex = 1
        Me.LBTOTAL.Text = "0"
        Me.LBTOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTNCARI)
        Me.GroupBox1.Controls.Add(Me.TXTHARGA)
        Me.GroupBox1.Controls.Add(Me.TXTSTATUS)
        Me.GroupBox1.Controls.Add(Me.TXTMENU)
        Me.GroupBox1.Controls.Add(Me.TXTKODE)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(365, 134)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA BARANG"
        '
        'BTNCARI
        '
        Me.BTNCARI.Location = New System.Drawing.Point(256, 20)
        Me.BTNCARI.Name = "BTNCARI"
        Me.BTNCARI.Size = New System.Drawing.Size(72, 23)
        Me.BTNCARI.TabIndex = 8
        Me.BTNCARI.Text = "CARI (F1)"
        Me.BTNCARI.UseVisualStyleBackColor = True
        '
        'TXTHARGA
        '
        Me.TXTHARGA.Location = New System.Drawing.Point(62, 101)
        Me.TXTHARGA.Name = "TXTHARGA"
        Me.TXTHARGA.ReadOnly = True
        Me.TXTHARGA.Size = New System.Drawing.Size(266, 20)
        Me.TXTHARGA.TabIndex = 7
        '
        'TXTSTATUS
        '
        Me.TXTSTATUS.Location = New System.Drawing.Point(62, 75)
        Me.TXTSTATUS.Name = "TXTSTATUS"
        Me.TXTSTATUS.ReadOnly = True
        Me.TXTSTATUS.Size = New System.Drawing.Size(266, 20)
        Me.TXTSTATUS.TabIndex = 6
        '
        'TXTMENU
        '
        Me.TXTMENU.Location = New System.Drawing.Point(62, 49)
        Me.TXTMENU.Name = "TXTMENU"
        Me.TXTMENU.ReadOnly = True
        Me.TXTMENU.Size = New System.Drawing.Size(266, 20)
        Me.TXTMENU.TabIndex = 5
        '
        'TXTKODE
        '
        Me.TXTKODE.Location = New System.Drawing.Point(62, 22)
        Me.TXTKODE.Name = "TXTKODE"
        Me.TXTKODE.Size = New System.Drawing.Size(188, 20)
        Me.TXTKODE.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "HARGA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "STATUS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MENU"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KODE"
        '
        'BTNMINIMIZE
        '
        Me.BTNMINIMIZE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNMINIMIZE.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BTNMINIMIZE.Location = New System.Drawing.Point(942, 12)
        Me.BTNMINIMIZE.Name = "BTNMINIMIZE"
        Me.BTNMINIMIZE.Size = New System.Drawing.Size(44, 23)
        Me.BTNMINIMIZE.TabIndex = 10
        Me.BTNMINIMIZE.Text = "-"
        Me.BTNMINIMIZE.UseVisualStyleBackColor = False
        '
        'PNBAYAR
        '
        Me.PNBAYAR.Controls.Add(Me.GroupBox3)
        Me.PNBAYAR.Location = New System.Drawing.Point(596, 253)
        Me.PNBAYAR.Name = "PNBAYAR"
        Me.PNBAYAR.Size = New System.Drawing.Size(413, 176)
        Me.PNBAYAR.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.BTNTUTUP)
        Me.GroupBox3.Controls.Add(Me.TXTKEMBALIAN)
        Me.GroupBox3.Controls.Add(Me.TXTTUNAI)
        Me.GroupBox3.Controls.Add(Me.TXTBAYAR)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(373, 152)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PEMBAYARAN"
        '
        'BTNTUTUP
        '
        Me.BTNTUTUP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNTUTUP.BackColor = System.Drawing.Color.Red
        Me.BTNTUTUP.Location = New System.Drawing.Point(279, 44)
        Me.BTNTUTUP.Name = "BTNTUTUP"
        Me.BTNTUTUP.Size = New System.Drawing.Size(75, 23)
        Me.BTNTUTUP.TabIndex = 11
        Me.BTNTUTUP.Text = "X"
        Me.BTNTUTUP.UseVisualStyleBackColor = False
        '
        'TXTKEMBALIAN
        '
        Me.TXTKEMBALIAN.Location = New System.Drawing.Point(104, 111)
        Me.TXTKEMBALIAN.Name = "TXTKEMBALIAN"
        Me.TXTKEMBALIAN.ReadOnly = True
        Me.TXTKEMBALIAN.Size = New System.Drawing.Size(153, 20)
        Me.TXTKEMBALIAN.TabIndex = 10
        Me.TXTKEMBALIAN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTTUNAI
        '
        Me.TXTTUNAI.Location = New System.Drawing.Point(104, 78)
        Me.TXTTUNAI.Name = "TXTTUNAI"
        Me.TXTTUNAI.Size = New System.Drawing.Size(153, 20)
        Me.TXTTUNAI.TabIndex = 9
        Me.TXTTUNAI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTBAYAR
        '
        Me.TXTBAYAR.Location = New System.Drawing.Point(104, 45)
        Me.TXTBAYAR.Name = "TXTBAYAR"
        Me.TXTBAYAR.ReadOnly = True
        Me.TXTBAYAR.Size = New System.Drawing.Size(153, 20)
        Me.TXTBAYAR.TabIndex = 8
        Me.TXTBAYAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "KEMBALIAN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "TUNAI"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "TOTAL BAYAR"
        '
        'PNBAWAH
        '
        Me.PNBAWAH.Controls.Add(Me.btntr)
        Me.PNBAWAH.Controls.Add(Me.BTNBAYAR)
        Me.PNBAWAH.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PNBAWAH.Location = New System.Drawing.Point(0, 410)
        Me.PNBAWAH.Name = "PNBAWAH"
        Me.PNBAWAH.Size = New System.Drawing.Size(1045, 48)
        Me.PNBAWAH.TabIndex = 1
        '
        'BTNBAYAR
        '
        Me.BTNBAYAR.Location = New System.Drawing.Point(21, 13)
        Me.BTNBAYAR.Name = "BTNBAYAR"
        Me.BTNBAYAR.Size = New System.Drawing.Size(72, 23)
        Me.BTNBAYAR.TabIndex = 9
        Me.BTNBAYAR.Text = "BAYAR (F2)"
        Me.BTNBAYAR.UseVisualStyleBackColor = True
        '
        'DGTAMPIL
        '
        Me.DGTAMPIL.AllowUserToAddRows = False
        Me.DGTAMPIL.AllowUserToDeleteRows = False
        Me.DGTAMPIL.AllowUserToResizeColumns = False
        Me.DGTAMPIL.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGTAMPIL.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGTAMPIL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTAMPIL.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KODE, Me.MENU, Me.STATUS, Me.HARGA, Me.QTY, Me.TOTAL})
        Me.DGTAMPIL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGTAMPIL.Location = New System.Drawing.Point(0, 176)
        Me.DGTAMPIL.Name = "DGTAMPIL"
        Me.DGTAMPIL.RowHeadersVisible = False
        Me.DGTAMPIL.Size = New System.Drawing.Size(1045, 234)
        Me.DGTAMPIL.TabIndex = 2
        '
        'KODE
        '
        Me.KODE.HeaderText = "KODE"
        Me.KODE.Name = "KODE"
        Me.KODE.ReadOnly = True
        Me.KODE.Width = 150
        '
        'MENU
        '
        Me.MENU.HeaderText = "MENU"
        Me.MENU.Name = "MENU"
        Me.MENU.ReadOnly = True
        Me.MENU.Width = 150
        '
        'STATUS
        '
        Me.STATUS.HeaderText = "STATUS"
        Me.STATUS.Name = "STATUS"
        Me.STATUS.ReadOnly = True
        Me.STATUS.Width = 150
        '
        'HARGA
        '
        Me.HARGA.HeaderText = "HARGA"
        Me.HARGA.Name = "HARGA"
        Me.HARGA.ReadOnly = True
        Me.HARGA.Width = 180
        '
        'QTY
        '
        Me.QTY.HeaderText = "QTY"
        Me.QTY.Name = "QTY"
        Me.QTY.Width = 80
        '
        'TOTAL
        '
        Me.TOTAL.HeaderText = "TOTAL"
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.ReadOnly = True
        Me.TOTAL.Width = 200
        '
        'KLIK_KANAN
        '
        Me.KLIK_KANAN.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HAPUSToolStripMenuItem})
        Me.KLIK_KANAN.Name = "ContextMenuStrip1"
        Me.KLIK_KANAN.Size = New System.Drawing.Size(113, 26)
        '
        'HAPUSToolStripMenuItem
        '
        Me.HAPUSToolStripMenuItem.Name = "HAPUSToolStripMenuItem"
        Me.HAPUSToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.HAPUSToolStripMenuItem.Text = "HAPUS"
        '
        'nota
        '
        '
        'btntr
        '
        Me.btntr.Location = New System.Drawing.Point(144, 13)
        Me.btntr.Name = "btntr"
        Me.btntr.Size = New System.Drawing.Size(118, 23)
        Me.btntr.TabIndex = 10
        Me.btntr.Text = "Data Transaksi (F2)"
        Me.btntr.UseVisualStyleBackColor = True
        '
        'TRANSAKSI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 458)
        Me.Controls.Add(Me.PNBAYAR)
        Me.Controls.Add(Me.DGTAMPIL)
        Me.Controls.Add(Me.PNBAWAH)
        Me.Controls.Add(Me.PNATAS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "TRANSAKSI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRANSAKSI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PNATAS.ResumeLayout(False)
        Me.PNCARI.ResumeLayout(False)
        Me.PNCARI.PerformLayout()
        CType(Me.DGCARI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PNBAYAR.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.PNBAWAH.ResumeLayout(False)
        CType(Me.DGTAMPIL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KLIK_KANAN.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PNATAS As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PNBAWAH As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTHARGA As System.Windows.Forms.TextBox
    Friend WithEvents TXTSTATUS As System.Windows.Forms.TextBox
    Friend WithEvents TXTMENU As System.Windows.Forms.TextBox
    Friend WithEvents TXTKODE As System.Windows.Forms.TextBox
    Friend WithEvents BTNCARI As System.Windows.Forms.Button
    Friend WithEvents LBTOTAL As System.Windows.Forms.Label
    Friend WithEvents BTNBAYAR As System.Windows.Forms.Button
    Friend WithEvents BTNMENU As System.Windows.Forms.Button
    Friend WithEvents BTNMINIMIZE As System.Windows.Forms.Button
    Friend WithEvents PNCARI As System.Windows.Forms.Panel
    Friend WithEvents TXTCARI As System.Windows.Forms.TextBox
    Friend WithEvents PNBAYAR As System.Windows.Forms.Panel
    Friend WithEvents DGTAMPIL As System.Windows.Forms.DataGridView
    Friend WithEvents DGCARI As System.Windows.Forms.DataGridView
    Friend WithEvents BTNKELUAR As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TXTKEMBALIAN As System.Windows.Forms.TextBox
    Friend WithEvents TXTTUNAI As System.Windows.Forms.TextBox
    Friend WithEvents TXTBAYAR As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BTNTUTUP As System.Windows.Forms.Button
    Friend WithEvents KLIK_KANAN As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HAPUSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KODE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MENU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STATUS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HARGA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nota As System.Drawing.Printing.PrintDocument
    Friend WithEvents btntr As System.Windows.Forms.Button
End Class
