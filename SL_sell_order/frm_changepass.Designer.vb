<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_changepass
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
        Me.frm_changpass = New SQLABC_ModernUI.SQLABC_Theme()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn_changpass = New SQLABC_ModernUI.SQLABC_ButtonB()
        Me.txt_confirm = New SQLABC_ModernUI.SQLABC_TextBox()
        Me.txt_newpassword = New SQLABC_ModernUI.SQLABC_TextBox()
        Me.SqlabC_Label2 = New SQLABC_ModernUI.SQLABC_Label()
        Me.SqlabC_Label1 = New SQLABC_ModernUI.SQLABC_Label()
        Me.SqlabC_ButtonB1 = New SQLABC_ModernUI.SQLABC_ButtonB()
        Me.frm_changpass.SuspendLayout()
        Me.SuspendLayout()
        '
        'frm_changpass
        '
        Me.frm_changpass.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.frm_changpass.Controls.Add(Me.SqlabC_ButtonB1)
        Me.frm_changpass.Controls.Add(Me.TextBox1)
        Me.frm_changpass.Controls.Add(Me.btn_changpass)
        Me.frm_changpass.Controls.Add(Me.txt_confirm)
        Me.frm_changpass.Controls.Add(Me.txt_newpassword)
        Me.frm_changpass.Controls.Add(Me.SqlabC_Label2)
        Me.frm_changpass.Controls.Add(Me.SqlabC_Label1)
        Me.frm_changpass.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frm_changpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frm_changpass.Location = New System.Drawing.Point(0, 0)
        Me.frm_changpass.Name = "frm_changpass"
        Me.frm_changpass.Size = New System.Drawing.Size(359, 462)
        Me.frm_changpass.TabIndex = 0
        Me.frm_changpass.Text = "เปลี่ยน Password ที่นี้"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(175, 440)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(180, 19)
        Me.TextBox1.TabIndex = 8
        '
        'btn_changpass
        '
        Me.btn_changpass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_changpass.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.btn_changpass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_changpass.GlowColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_changpass.Image = Nothing
        Me.btn_changpass.Location = New System.Drawing.Point(175, 302)
        Me.btn_changpass.Name = "btn_changpass"
        Me.btn_changpass.Size = New System.Drawing.Size(147, 28)
        Me.btn_changpass.TabIndex = 6
        Me.btn_changpass.Text = "ยืนยันการเปลี่น"
        '
        'txt_confirm
        '
        Me.txt_confirm.BackColor = System.Drawing.Color.Transparent
        Me.txt_confirm.Location = New System.Drawing.Point(175, 225)
        Me.txt_confirm.MaxLength = 32767
        Me.txt_confirm.Multiline = False
        Me.txt_confirm.Name = "txt_confirm"
        Me.txt_confirm.ReadOnly = False
        Me.txt_confirm.Size = New System.Drawing.Size(147, 29)
        Me.txt_confirm.TabIndex = 3
        Me.txt_confirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_confirm.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_confirm.UseSystemPasswordChar = False
        '
        'txt_newpassword
        '
        Me.txt_newpassword.BackColor = System.Drawing.Color.Transparent
        Me.txt_newpassword.Location = New System.Drawing.Point(175, 163)
        Me.txt_newpassword.MaxLength = 32767
        Me.txt_newpassword.Multiline = False
        Me.txt_newpassword.Name = "txt_newpassword"
        Me.txt_newpassword.ReadOnly = False
        Me.txt_newpassword.Size = New System.Drawing.Size(147, 29)
        Me.txt_newpassword.TabIndex = 2
        Me.txt_newpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_newpassword.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_newpassword.UseSystemPasswordChar = False
        '
        'SqlabC_Label2
        '
        Me.SqlabC_Label2.AutoSize = True
        Me.SqlabC_Label2.BackColor = System.Drawing.Color.Transparent
        Me.SqlabC_Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SqlabC_Label2.ForeColor = System.Drawing.Color.White
        Me.SqlabC_Label2.Location = New System.Drawing.Point(12, 236)
        Me.SqlabC_Label2.Name = "SqlabC_Label2"
        Me.SqlabC_Label2.Size = New System.Drawing.Size(147, 18)
        Me.SqlabC_Label2.TabIndex = 1
        Me.SqlabC_Label2.Text = "พิม pass เหมือนด้านบน"
        '
        'SqlabC_Label1
        '
        Me.SqlabC_Label1.AutoSize = True
        Me.SqlabC_Label1.BackColor = System.Drawing.Color.Transparent
        Me.SqlabC_Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SqlabC_Label1.ForeColor = System.Drawing.Color.White
        Me.SqlabC_Label1.Location = New System.Drawing.Point(50, 174)
        Me.SqlabC_Label1.Name = "SqlabC_Label1"
        Me.SqlabC_Label1.Size = New System.Drawing.Size(109, 18)
        Me.SqlabC_Label1.TabIndex = 0
        Me.SqlabC_Label1.Text = "เปลี่ยน pass ใหม่"
        '
        'SqlabC_ButtonB1
        '
        Me.SqlabC_ButtonB1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SqlabC_ButtonB1.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.SqlabC_ButtonB1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.SqlabC_ButtonB1.GlowColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.SqlabC_ButtonB1.Image = Nothing
        Me.SqlabC_ButtonB1.Location = New System.Drawing.Point(175, 336)
        Me.SqlabC_ButtonB1.Name = "SqlabC_ButtonB1"
        Me.SqlabC_ButtonB1.Size = New System.Drawing.Size(147, 26)
        Me.SqlabC_ButtonB1.TabIndex = 9
        Me.SqlabC_ButtonB1.Text = "กลับไปหน้า login"
        '
        'frm_changepass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 462)
        Me.Controls.Add(Me.frm_changpass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_changepass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_changepass"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.frm_changpass.ResumeLayout(False)
        Me.frm_changpass.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frm_changpass As SQLABC_ModernUI.SQLABC_Theme
    Friend WithEvents btn_changpass As SQLABC_ModernUI.SQLABC_ButtonB
    Friend WithEvents txt_confirm As SQLABC_ModernUI.SQLABC_TextBox
    Friend WithEvents txt_newpassword As SQLABC_ModernUI.SQLABC_TextBox
    Friend WithEvents SqlabC_Label2 As SQLABC_ModernUI.SQLABC_Label
    Friend WithEvents SqlabC_Label1 As SQLABC_ModernUI.SQLABC_Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SqlabC_ButtonB1 As SQLABC_ModernUI.SQLABC_ButtonB
End Class
