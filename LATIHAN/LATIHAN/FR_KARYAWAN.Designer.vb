﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FR_KARYAWAN
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTNIK = New System.Windows.Forms.TextBox()
        Me.TXTASAL = New System.Windows.Forms.TextBox()
        Me.TXTNAMA = New System.Windows.Forms.TextBox()
        Me.TGL = New System.Windows.Forms.DateTimePicker()
        Me.CBJK = New System.Windows.Forms.ComboBox()
        Me.TXTALAMAT = New System.Windows.Forms.TextBox()
        Me.TXTNO = New System.Windows.Forms.TextBox()
        Me.BTNSIMPAN = New System.Windows.Forms.Button()
        Me.DGTAMPIL = New System.Windows.Forms.DataGridView()
        Me.TXTCARI = New System.Windows.Forms.TextBox()
        Me.BTNBARU = New System.Windows.Forms.Button()
        Me.BTNHAPUS = New System.Windows.Forms.Button()
        Me.klik_kanan = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.JadikanUserAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DGTAMPIL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.klik_kanan.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NAMA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIK"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ASAL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TGL LAHIR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "JENIS KELAMIN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ALAMAT"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "NO HP"
        '
        'TXTNIK
        '
        Me.TXTNIK.Location = New System.Drawing.Point(126, 8)
        Me.TXTNIK.MaxLength = 12
        Me.TXTNIK.Name = "TXTNIK"
        Me.TXTNIK.ReadOnly = True
        Me.TXTNIK.Size = New System.Drawing.Size(93, 20)
        Me.TXTNIK.TabIndex = 7
        '
        'TXTASAL
        '
        Me.TXTASAL.Location = New System.Drawing.Point(126, 75)
        Me.TXTASAL.MaxLength = 50
        Me.TXTASAL.Name = "TXTASAL"
        Me.TXTASAL.Size = New System.Drawing.Size(93, 20)
        Me.TXTASAL.TabIndex = 8
        '
        'TXTNAMA
        '
        Me.TXTNAMA.Location = New System.Drawing.Point(126, 43)
        Me.TXTNAMA.MaxLength = 50
        Me.TXTNAMA.Name = "TXTNAMA"
        Me.TXTNAMA.Size = New System.Drawing.Size(193, 20)
        Me.TXTNAMA.TabIndex = 9
        '
        'TGL
        '
        Me.TGL.Location = New System.Drawing.Point(126, 107)
        Me.TGL.Name = "TGL"
        Me.TGL.Size = New System.Drawing.Size(193, 20)
        Me.TGL.TabIndex = 10
        '
        'CBJK
        '
        Me.CBJK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBJK.FormattingEnabled = True
        Me.CBJK.Items.AddRange(New Object() {"LAKI-LAKI", "PEREMPUAN"})
        Me.CBJK.Location = New System.Drawing.Point(126, 139)
        Me.CBJK.Name = "CBJK"
        Me.CBJK.Size = New System.Drawing.Size(114, 21)
        Me.CBJK.TabIndex = 11
        '
        'TXTALAMAT
        '
        Me.TXTALAMAT.Location = New System.Drawing.Point(126, 171)
        Me.TXTALAMAT.MaxLength = 100
        Me.TXTALAMAT.Name = "TXTALAMAT"
        Me.TXTALAMAT.Size = New System.Drawing.Size(307, 20)
        Me.TXTALAMAT.TabIndex = 12
        '
        'TXTNO
        '
        Me.TXTNO.Location = New System.Drawing.Point(126, 203)
        Me.TXTNO.MaxLength = 15
        Me.TXTNO.Name = "TXTNO"
        Me.TXTNO.Size = New System.Drawing.Size(193, 20)
        Me.TXTNO.TabIndex = 13
        '
        'BTNSIMPAN
        '
        Me.BTNSIMPAN.Location = New System.Drawing.Point(126, 241)
        Me.BTNSIMPAN.Name = "BTNSIMPAN"
        Me.BTNSIMPAN.Size = New System.Drawing.Size(75, 23)
        Me.BTNSIMPAN.TabIndex = 14
        Me.BTNSIMPAN.Text = "SIMPAN"
        Me.BTNSIMPAN.UseVisualStyleBackColor = True
        '
        'DGTAMPIL
        '
        Me.DGTAMPIL.AllowUserToAddRows = False
        Me.DGTAMPIL.AllowUserToDeleteRows = False
        Me.DGTAMPIL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGTAMPIL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGTAMPIL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTAMPIL.ContextMenuStrip = Me.klik_kanan
        Me.DGTAMPIL.Location = New System.Drawing.Point(30, 302)
        Me.DGTAMPIL.Name = "DGTAMPIL"
        Me.DGTAMPIL.ReadOnly = True
        Me.DGTAMPIL.RowHeadersVisible = False
        Me.DGTAMPIL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGTAMPIL.Size = New System.Drawing.Size(753, 195)
        Me.DGTAMPIL.TabIndex = 15
        '
        'TXTCARI
        '
        Me.TXTCARI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTCARI.Location = New System.Drawing.Point(30, 276)
        Me.TXTCARI.Name = "TXTCARI"
        Me.TXTCARI.Size = New System.Drawing.Size(753, 20)
        Me.TXTCARI.TabIndex = 16
        '
        'BTNBARU
        '
        Me.BTNBARU.Location = New System.Drawing.Point(207, 241)
        Me.BTNBARU.Name = "BTNBARU"
        Me.BTNBARU.Size = New System.Drawing.Size(75, 23)
        Me.BTNBARU.TabIndex = 17
        Me.BTNBARU.Text = "BARU"
        Me.BTNBARU.UseVisualStyleBackColor = True
        '
        'BTNHAPUS
        '
        Me.BTNHAPUS.Location = New System.Drawing.Point(288, 241)
        Me.BTNHAPUS.Name = "BTNHAPUS"
        Me.BTNHAPUS.Size = New System.Drawing.Size(75, 23)
        Me.BTNHAPUS.TabIndex = 18
        Me.BTNHAPUS.Text = "HAPUS"
        Me.BTNHAPUS.UseVisualStyleBackColor = True
        '
        'klik_kanan
        '
        Me.klik_kanan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JadikanUserAdminToolStripMenuItem})
        Me.klik_kanan.Name = "klik_kanan"
        Me.klik_kanan.Size = New System.Drawing.Size(179, 26)
        '
        'JadikanUserAdminToolStripMenuItem
        '
        Me.JadikanUserAdminToolStripMenuItem.Name = "JadikanUserAdminToolStripMenuItem"
        Me.JadikanUserAdminToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.JadikanUserAdminToolStripMenuItem.Text = "Jadikan User Admin"
        '
        'FR_KARYAWAN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 509)
        Me.Controls.Add(Me.BTNHAPUS)
        Me.Controls.Add(Me.BTNBARU)
        Me.Controls.Add(Me.TXTCARI)
        Me.Controls.Add(Me.DGTAMPIL)
        Me.Controls.Add(Me.BTNSIMPAN)
        Me.Controls.Add(Me.TXTNO)
        Me.Controls.Add(Me.TXTALAMAT)
        Me.Controls.Add(Me.CBJK)
        Me.Controls.Add(Me.TGL)
        Me.Controls.Add(Me.TXTNAMA)
        Me.Controls.Add(Me.TXTASAL)
        Me.Controls.Add(Me.TXTNIK)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FR_KARYAWAN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FR_KARYAWAN"
        CType(Me.DGTAMPIL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.klik_kanan.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXTNIK As System.Windows.Forms.TextBox
    Friend WithEvents TXTASAL As System.Windows.Forms.TextBox
    Friend WithEvents TXTNAMA As System.Windows.Forms.TextBox
    Friend WithEvents TGL As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBJK As System.Windows.Forms.ComboBox
    Friend WithEvents TXTALAMAT As System.Windows.Forms.TextBox
    Friend WithEvents TXTNO As System.Windows.Forms.TextBox
    Friend WithEvents BTNSIMPAN As System.Windows.Forms.Button
    Friend WithEvents DGTAMPIL As System.Windows.Forms.DataGridView
    Friend WithEvents TXTCARI As System.Windows.Forms.TextBox
    Friend WithEvents BTNBARU As System.Windows.Forms.Button
    Friend WithEvents BTNHAPUS As System.Windows.Forms.Button
    Friend WithEvents klik_kanan As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents JadikanUserAdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
