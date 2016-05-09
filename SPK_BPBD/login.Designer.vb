<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.vuname = New DevExpress.XtraEditors.TextEdit()
        Me.vpass = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.blogin = New System.Windows.Forms.Button()
        CType(Me.vuname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vpass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vuname
        '
        Me.vuname.Location = New System.Drawing.Point(415, 130)
        Me.vuname.Name = "vuname"
        Me.vuname.Properties.AutoHeight = False
        Me.vuname.Size = New System.Drawing.Size(180, 30)
        Me.vuname.TabIndex = 0
        '
        'vpass
        '
        Me.vpass.Location = New System.Drawing.Point(415, 185)
        Me.vpass.Name = "vpass"
        Me.vpass.Properties.AutoHeight = False
        Me.vpass.Size = New System.Drawing.Size(180, 30)
        Me.vpass.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(415, 111)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Username :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(415, 166)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Password :"
        '
        'blogin
        '
        Me.blogin.Location = New System.Drawing.Point(497, 234)
        Me.blogin.Name = "blogin"
        Me.blogin.Size = New System.Drawing.Size(98, 31)
        Me.blogin.TabIndex = 4
        Me.blogin.Text = "LOGIN"
        Me.blogin.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 302)
        Me.Controls.Add(Me.blogin)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.vpass)
        Me.Controls.Add(Me.vuname)
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "login"
        Me.Text = "Welcome"
        CType(Me.vuname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vpass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vuname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents vpass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents blogin As System.Windows.Forms.Button
End Class
