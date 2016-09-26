<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class laporan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(laporan))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.vcari = New System.Windows.Forms.ComboBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.tbview = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.tbview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 33)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "LAPORAN "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'vcari
        '
        Me.vcari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.vcari.FormattingEnabled = True
        Me.vcari.Items.AddRange(New Object() {"Data Admin", "Data Pemohon", "Data Surveyor", "Data Analisa"})
        Me.vcari.Location = New System.Drawing.Point(604, 16)
        Me.vcari.Name = "vcari"
        Me.vcari.Size = New System.Drawing.Size(196, 28)
        Me.vcari.TabIndex = 23
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Image = Global.SPK_BNPB.My.Resources.Resources.Search_icon
        Me.Button5.Location = New System.Drawing.Point(819, 16)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(36, 30)
        Me.Button5.TabIndex = 33
        Me.Button5.UseVisualStyleBackColor = False
        '
        'tbview
        '
        Me.tbview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tbview.Location = New System.Drawing.Point(18, 72)
        Me.tbview.Name = "tbview"
        Me.tbview.Size = New System.Drawing.Size(847, 317)
        Me.tbview.TabIndex = 34
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Image = Global.SPK_BNPB.My.Resources.Resources.Actions_dialog_cancel_icon
        Me.Button1.Location = New System.Drawing.Point(790, 395)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 64)
        Me.Button1.TabIndex = 35
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Image = Global.SPK_BNPB.My.Resources.Resources.SEO_icon
        Me.Button3.Location = New System.Drawing.Point(18, 395)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 64)
        Me.Button3.TabIndex = 35
        Me.Button3.UseVisualStyleBackColor = False
        '
        'laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SPK_BNPB.My.Resources.Resources.texture_green_paper_pattern_scratch_background_photo_hd_wallpaper
        Me.ClientSize = New System.Drawing.Size(877, 471)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbview)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.vcari)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "laporan"
        Me.Text = " BNPB | Laporan"
        CType(Me.tbview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents vcari As System.Windows.Forms.ComboBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents tbview As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
