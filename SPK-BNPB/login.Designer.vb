<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.blogin = New System.Windows.Forms.Button()
        Me.vpass = New System.Windows.Forms.TextBox()
        Me.vuname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(351, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(213, 26)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "BENCANA KEBAKARAN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(352, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 26)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "PEMBERIAN BANTUAN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(261, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(303, 26)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "SISTEM PENUNJANG KEPUTUSAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(275, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "PASSWORD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(275, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "USERNAME"
        '
        'blogin
        '
        Me.blogin.BackColor = System.Drawing.Color.Transparent
        Me.blogin.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blogin.ForeColor = System.Drawing.Color.DarkGreen
        Me.blogin.Image = Global.SPK_BNPB.My.Resources.Resources.Paomedia_Small_N_Flat_Sign_check
        Me.blogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.blogin.Location = New System.Drawing.Point(453, 211)
        Me.blogin.Name = "blogin"
        Me.blogin.Size = New System.Drawing.Size(111, 49)
        Me.blogin.TabIndex = 11
        Me.blogin.Text = "LOGIN"
        Me.blogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.blogin.UseVisualStyleBackColor = False
        '
        'vpass
        '
        Me.vpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vpass.Location = New System.Drawing.Point(399, 165)
        Me.vpass.Name = "vpass"
        Me.vpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.vpass.Size = New System.Drawing.Size(165, 30)
        Me.vpass.TabIndex = 10
        '
        'vuname
        '
        Me.vuname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vuname.Location = New System.Drawing.Point(399, 119)
        Me.vuname.Name = "vuname"
        Me.vuname.Size = New System.Drawing.Size(165, 30)
        Me.vuname.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(254, 15)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "2016 @ BPBD Kab. Solok All Right Reserved."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SPK_BNPB.My.Resources.Resources.BPBD_SOLOK
        Me.PictureBox1.Location = New System.Drawing.Point(34, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 164)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SPK_BNPB.My.Resources.Resources.texture_green_paper_pattern_scratch_background_photo_hd_wallpaper
        Me.ClientSize = New System.Drawing.Size(576, 271)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.blogin)
        Me.Controls.Add(Me.vpass)
        Me.Controls.Add(Me.vuname)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "login"
        Me.Text = " BPBD | Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents blogin As System.Windows.Forms.Button
    Friend WithEvents vpass As System.Windows.Forms.TextBox
    Friend WithEvents vuname As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
