<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.txt_passstaff = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_namestaff = New System.Windows.Forms.TextBox()
        Me.btn_newlogin = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chk_remenber = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_passstaff
        '
        Me.txt_passstaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_passstaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_passstaff.Location = New System.Drawing.Point(125, 153)
        Me.txt_passstaff.Name = "txt_passstaff"
        Me.txt_passstaff.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_passstaff.Size = New System.Drawing.Size(255, 22)
        Me.txt_passstaff.TabIndex = 22
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.WindowText
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(532, 84)
        Me.Panel1.TabIndex = 23
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Galahadone.My.Resources.Resources.images__7_
        Me.PictureBox2.Location = New System.Drawing.Point(443, -12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(104, 96)
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(45, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Log In"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(67, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(313, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "กรุณาใส่ชื่อ และ พาสเวิอร์ในการเข้าระบบ ด้วยนะจ๊ะ"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Galahadone.My.Resources.Resources.icons8_key_30
        Me.PictureBox1.Location = New System.Drawing.Point(140, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(43, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label4.Location = New System.Drawing.Point(424, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Power by Galahad @"
        '
        'txt_namestaff
        '
        Me.txt_namestaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_namestaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_namestaff.Location = New System.Drawing.Point(125, 107)
        Me.txt_namestaff.Name = "txt_namestaff"
        Me.txt_namestaff.Size = New System.Drawing.Size(255, 22)
        Me.txt_namestaff.TabIndex = 24
        '
        'btn_newlogin
        '
        Me.btn_newlogin.ForeColor = System.Drawing.SystemColors.MenuText
        Me.btn_newlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_newlogin.ImageKey = "Log Off.ico"
        Me.btn_newlogin.Location = New System.Drawing.Point(395, 153)
        Me.btn_newlogin.Name = "btn_newlogin"
        Me.btn_newlogin.Size = New System.Drawing.Size(88, 22)
        Me.btn_newlogin.TabIndex = 26
        Me.btn_newlogin.Text = "LOGIN"
        Me.btn_newlogin.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(39, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "User Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Password:"
        '
        'chk_remenber
        '
        Me.chk_remenber.AutoSize = True
        Me.chk_remenber.BackColor = System.Drawing.Color.Transparent
        Me.chk_remenber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chk_remenber.ForeColor = System.Drawing.Color.Red
        Me.chk_remenber.Location = New System.Drawing.Point(125, 130)
        Me.chk_remenber.Name = "chk_remenber"
        Me.chk_remenber.Size = New System.Drawing.Size(111, 19)
        Me.chk_remenber.TabIndex = 31
        Me.chk_remenber.Text = "จดจำ Username"
        Me.chk_remenber.UseVisualStyleBackColor = False
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Galahadone.My.Resources.Resources.BackGround
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(532, 199)
        Me.Controls.Add(Me.chk_remenber)
        Me.Controls.Add(Me.btn_newlogin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_namestaff)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_passstaff)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_login"
        Me.ShowInTaskbar = False
        Me.Text = "SIEW LAMNATION"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_passstaff As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_namestaff As System.Windows.Forms.TextBox
    Friend WithEvents btn_newlogin As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents chk_remenber As System.Windows.Forms.CheckBox
End Class
