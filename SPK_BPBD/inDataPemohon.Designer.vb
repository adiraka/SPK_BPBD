<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inDataPemohon
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.vnik = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.vnama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.vtmpt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.vtgllhr = New System.Windows.Forms.DateTimePicker()
        Me.vjekel = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.valamat = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.vrt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.vrw = New System.Windows.Forms.TextBox()
        Me.vkel = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.vkec = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.vstat = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.vpekerjaan = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.vkwn = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.bCari = New System.Windows.Forms.Button()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.bSimpan = New System.Windows.Forms.Button()
        Me.Aksi = New System.Windows.Forms.GroupBox()
        Me.bBatal = New System.Windows.Forms.Button()
        Me.vgoldar = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.vagama = New System.Windows.Forms.ComboBox()
        Me.bData = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Aksi.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORM INPUT DATA PEMOHON"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIK"
        '
        'vnik
        '
        Me.vnik.Location = New System.Drawing.Point(112, 52)
        Me.vnik.Name = "vnik"
        Me.vnik.Size = New System.Drawing.Size(189, 21)
        Me.vnik.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama Lengkap"
        '
        'vnama
        '
        Me.vnama.Location = New System.Drawing.Point(112, 79)
        Me.vnama.Name = "vnama"
        Me.vnama.Size = New System.Drawing.Size(189, 21)
        Me.vnama.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Tempat Lahir"
        '
        'vtmpt
        '
        Me.vtmpt.Location = New System.Drawing.Point(112, 106)
        Me.vtmpt.Name = "vtmpt"
        Me.vtmpt.Size = New System.Drawing.Size(189, 21)
        Me.vtmpt.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Tanggal Lahir"
        '
        'vtgllhr
        '
        Me.vtgllhr.CustomFormat = ""
        Me.vtgllhr.Location = New System.Drawing.Point(112, 133)
        Me.vtgllhr.Name = "vtgllhr"
        Me.vtgllhr.Size = New System.Drawing.Size(189, 21)
        Me.vtgllhr.TabIndex = 3
        '
        'vjekel
        '
        Me.vjekel.FormattingEnabled = True
        Me.vjekel.Items.AddRange(New Object() {"LAKI-LAKI", "PEREMPUAN"})
        Me.vjekel.Location = New System.Drawing.Point(112, 160)
        Me.vjekel.Name = "vjekel"
        Me.vjekel.Size = New System.Drawing.Size(121, 21)
        Me.vjekel.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Jenis Kelamin"
        '
        'valamat
        '
        Me.valamat.Location = New System.Drawing.Point(112, 188)
        Me.valamat.Name = "valamat"
        Me.valamat.Size = New System.Drawing.Size(189, 83)
        Me.valamat.TabIndex = 5
        Me.valamat.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Alamat"
        '
        'vrt
        '
        Me.vrt.Location = New System.Drawing.Point(112, 278)
        Me.vrt.Name = "vrt"
        Me.vrt.Size = New System.Drawing.Size(55, 21)
        Me.vrt.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "RT/RW"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(173, 281)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "/"
        '
        'vrw
        '
        Me.vrw.Location = New System.Drawing.Point(190, 278)
        Me.vrw.Name = "vrw"
        Me.vrw.Size = New System.Drawing.Size(55, 21)
        Me.vrw.TabIndex = 6
        '
        'vkel
        '
        Me.vkel.Location = New System.Drawing.Point(112, 306)
        Me.vkel.Name = "vkel"
        Me.vkel.Size = New System.Drawing.Size(189, 21)
        Me.vkel.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 309)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Kel/Desa"
        '
        'vkec
        '
        Me.vkec.Location = New System.Drawing.Point(112, 333)
        Me.vkec.Name = "vkec"
        Me.vkec.Size = New System.Drawing.Size(189, 21)
        Me.vkec.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 336)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Kecamatan"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(374, 109)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Status Perkawinan"
        '
        'vstat
        '
        Me.vstat.FormattingEnabled = True
        Me.vstat.Items.AddRange(New Object() {"KAWIN", "BELUM KAWIN"})
        Me.vstat.Location = New System.Drawing.Point(490, 106)
        Me.vstat.Name = "vstat"
        Me.vstat.Size = New System.Drawing.Size(121, 21)
        Me.vstat.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(374, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Pekerjaan"
        '
        'vpekerjaan
        '
        Me.vpekerjaan.FormattingEnabled = True
        Me.vpekerjaan.Items.AddRange(New Object() {"PELAJAR", "SWASTA", "PNS", "PENSIUNAN"})
        Me.vpekerjaan.Location = New System.Drawing.Point(490, 133)
        Me.vpekerjaan.Name = "vpekerjaan"
        Me.vpekerjaan.Size = New System.Drawing.Size(121, 21)
        Me.vpekerjaan.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(374, 82)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Golongan Darah"
        '
        'vkwn
        '
        Me.vkwn.Location = New System.Drawing.Point(490, 160)
        Me.vkwn.Name = "vkwn"
        Me.vkwn.Size = New System.Drawing.Size(189, 21)
        Me.vkwn.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(374, 163)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Kewarganegaraan"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(494, 214)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 140)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(374, 190)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(29, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Foto"
        '
        'bCari
        '
        Me.bCari.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bCari.Location = New System.Drawing.Point(490, 185)
        Me.bCari.Name = "bCari"
        Me.bCari.Size = New System.Drawing.Size(48, 23)
        Me.bCari.TabIndex = 9
        Me.bCari.Text = "CARI"
        Me.bCari.UseVisualStyleBackColor = True
        '
        'TextBox10
        '
        Me.TextBox10.Enabled = False
        Me.TextBox10.Location = New System.Drawing.Point(544, 185)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(135, 21)
        Me.TextBox10.TabIndex = 7
        '
        'bSimpan
        '
        Me.bSimpan.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bSimpan.Location = New System.Drawing.Point(6, 20)
        Me.bSimpan.Name = "bSimpan"
        Me.bSimpan.Size = New System.Drawing.Size(98, 33)
        Me.bSimpan.TabIndex = 11
        Me.bSimpan.Text = "SIMPAN"
        Me.bSimpan.UseVisualStyleBackColor = True
        '
        'Aksi
        '
        Me.Aksi.Controls.Add(Me.bData)
        Me.Aksi.Controls.Add(Me.bBatal)
        Me.Aksi.Controls.Add(Me.bSimpan)
        Me.Aksi.Location = New System.Drawing.Point(720, 12)
        Me.Aksi.Name = "Aksi"
        Me.Aksi.Size = New System.Drawing.Size(110, 342)
        Me.Aksi.TabIndex = 12
        Me.Aksi.TabStop = False
        '
        'bBatal
        '
        Me.bBatal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bBatal.Location = New System.Drawing.Point(6, 98)
        Me.bBatal.Name = "bBatal"
        Me.bBatal.Size = New System.Drawing.Size(98, 33)
        Me.bBatal.TabIndex = 11
        Me.bBatal.Text = "BATAL"
        Me.bBatal.UseVisualStyleBackColor = True
        '
        'vgoldar
        '
        Me.vgoldar.FormattingEnabled = True
        Me.vgoldar.Items.AddRange(New Object() {"A", "B", "AB", "O"})
        Me.vgoldar.Location = New System.Drawing.Point(490, 76)
        Me.vgoldar.Name = "vgoldar"
        Me.vgoldar.Size = New System.Drawing.Size(121, 21)
        Me.vgoldar.TabIndex = 4
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(374, 55)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 13)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Agama"
        '
        'vagama
        '
        Me.vagama.FormattingEnabled = True
        Me.vagama.Items.AddRange(New Object() {"ISLAM", "KATOLIK", "PROTESTAN", "HINDU", "BUDDHA", "KONGHUCU"})
        Me.vagama.Location = New System.Drawing.Point(490, 49)
        Me.vagama.Name = "vagama"
        Me.vagama.Size = New System.Drawing.Size(121, 21)
        Me.vagama.TabIndex = 4
        '
        'bData
        '
        Me.bData.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bData.Location = New System.Drawing.Point(6, 59)
        Me.bData.Name = "bData"
        Me.bData.Size = New System.Drawing.Size(98, 33)
        Me.bData.TabIndex = 11
        Me.bData.Text = "ALL DATA"
        Me.bData.UseVisualStyleBackColor = True
        '
        'inDataPemohon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(866, 374)
        Me.Controls.Add(Me.Aksi)
        Me.Controls.Add(Me.bCari)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.vkec)
        Me.Controls.Add(Me.vkel)
        Me.Controls.Add(Me.vrw)
        Me.Controls.Add(Me.vrt)
        Me.Controls.Add(Me.valamat)
        Me.Controls.Add(Me.vpekerjaan)
        Me.Controls.Add(Me.vagama)
        Me.Controls.Add(Me.vgoldar)
        Me.Controls.Add(Me.vstat)
        Me.Controls.Add(Me.vjekel)
        Me.Controls.Add(Me.vtgllhr)
        Me.Controls.Add(Me.vtmpt)
        Me.Controls.Add(Me.vnama)
        Me.Controls.Add(Me.vkwn)
        Me.Controls.Add(Me.vnik)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "inDataPemohon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Data Pemohon"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Aksi.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents vnik As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents vnama As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents vtmpt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents vtgllhr As System.Windows.Forms.DateTimePicker
    Friend WithEvents vjekel As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents valamat As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents vrt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents vrw As System.Windows.Forms.TextBox
    Friend WithEvents vkel As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents vkec As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents vstat As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents vpekerjaan As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents vkwn As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents bCari As System.Windows.Forms.Button
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents bSimpan As System.Windows.Forms.Button
    Friend WithEvents Aksi As System.Windows.Forms.GroupBox
    Friend WithEvents bBatal As System.Windows.Forms.Button
    Friend WithEvents vgoldar As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents vagama As System.Windows.Forms.ComboBox
    Friend WithEvents bData As System.Windows.Forms.Button
End Class
