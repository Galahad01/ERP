<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_note
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_note))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_appoint = New System.Windows.Forms.TextBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_close = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_timeset = New System.Windows.Forms.Label()
        Me.lbl_timealam = New System.Windows.Forms.Label()
        Me.btn_noti = New System.Windows.Forms.Button()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.btn_stop = New System.Windows.Forms.Button()
        Me.txt_messageboxtimer = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_maskbox = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(801, 673)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Power by@ Galahad"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.LemonChiffon
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(19, 26)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(242, 252)
        Me.TextBox1.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Image = Global.Galahadone.My.Resources.Resources.lapis_cores
        Me.PictureBox2.Location = New System.Drawing.Point(19, 560)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.Galahadone.My.Resources.Resources.Logo___SL
        Me.PictureBox1.Location = New System.Drawing.Point(948, 656)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(83, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(23, 28)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(19, 302)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(242, 252)
        Me.TextBox2.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txt_appoint)
        Me.Panel1.Controls.Add(Me.btn_back)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.MonthCalendar1)
        Me.Panel1.Controls.Add(Me.btnadd)
        Me.Panel1.Location = New System.Drawing.Point(17, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(224, 242)
        Me.Panel1.TabIndex = 10
        '
        'txt_appoint
        '
        Me.txt_appoint.Location = New System.Drawing.Point(23, 28)
        Me.txt_appoint.Multiline = True
        Me.txt_appoint.Name = "txt_appoint"
        Me.txt_appoint.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_appoint.Size = New System.Drawing.Size(178, 162)
        Me.txt_appoint.TabIndex = 31
        Me.txt_appoint.Visible = False
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.White
        Me.btn_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.Teal
        Me.btn_back.Location = New System.Drawing.Point(122, 198)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(79, 33)
        Me.btn_back.TabIndex = 30
        Me.btn_back.Text = "กลับ"
        Me.btn_back.UseVisualStyleBackColor = False
        Me.btn_back.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมเตือนสติ"
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.White
        Me.btnadd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.Teal
        Me.btnadd.Location = New System.Drawing.Point(23, 198)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(79, 33)
        Me.btnadd.TabIndex = 29
        Me.btnadd.Text = "บันทึก"
        Me.btnadd.UseVisualStyleBackColor = False
        Me.btnadd.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(12, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 24)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Death Note"
        '
        'Btn_close
        '
        Me.Btn_close.BackColor = System.Drawing.Color.Teal
        Me.Btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_close.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_close.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_close.ForeColor = System.Drawing.Color.White
        Me.Btn_close.Location = New System.Drawing.Point(996, 10)
        Me.Btn_close.Name = "Btn_close"
        Me.Btn_close.Size = New System.Drawing.Size(35, 27)
        Me.Btn_close.TabIndex = 42
        Me.Btn_close.Text = " X"
        Me.Btn_close.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TextBox7)
        Me.Panel2.Controls.Add(Me.TextBox6)
        Me.Panel2.Controls.Add(Me.TextBox5)
        Me.Panel2.Controls.Add(Me.TextBox4)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(12, 39)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(770, 615)
        Me.Panel2.TabIndex = 43
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(515, 302)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox7.Size = New System.Drawing.Size(242, 252)
        Me.TextBox7.TabIndex = 11
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.Highlight
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(515, 25)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox6.Size = New System.Drawing.Size(242, 252)
        Me.TextBox6.TabIndex = 10
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Orange
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(267, 302)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox5.Size = New System.Drawing.Size(242, 252)
        Me.TextBox5.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.GreenYellow
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(267, 26)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox4.Size = New System.Drawing.Size(242, 252)
        Me.TextBox4.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.ShapeContainer1)
        Me.Panel3.Location = New System.Drawing.Point(776, 39)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(255, 615)
        Me.Panel3.TabIndex = 44
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lbl_timeset)
        Me.Panel4.Controls.Add(Me.lbl_timealam)
        Me.Panel4.Controls.Add(Me.btn_noti)
        Me.Panel4.Controls.Add(Me.btn_start)
        Me.Panel4.Controls.Add(Me.btn_stop)
        Me.Panel4.Controls.Add(Me.txt_messageboxtimer)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.txt_maskbox)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.TextBox3)
        Me.Panel4.Location = New System.Drawing.Point(18, 302)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(223, 289)
        Me.Panel4.TabIndex = 12
        '
        'lbl_timeset
        '
        Me.lbl_timeset.AutoSize = True
        Me.lbl_timeset.Location = New System.Drawing.Point(14, 190)
        Me.lbl_timeset.Name = "lbl_timeset"
        Me.lbl_timeset.Size = New System.Drawing.Size(0, 13)
        Me.lbl_timeset.TabIndex = 34
        '
        'lbl_timealam
        '
        Me.lbl_timealam.AutoSize = True
        Me.lbl_timealam.BackColor = System.Drawing.Color.Teal
        Me.lbl_timealam.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_timealam.Location = New System.Drawing.Point(120, 3)
        Me.lbl_timealam.Name = "lbl_timealam"
        Me.lbl_timealam.Size = New System.Drawing.Size(0, 18)
        Me.lbl_timealam.TabIndex = 33
        '
        'btn_noti
        '
        Me.btn_noti.BackColor = System.Drawing.Color.White
        Me.btn_noti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_noti.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_noti.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btn_noti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_noti.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_noti.ForeColor = System.Drawing.Color.Teal
        Me.btn_noti.Image = Global.Galahadone.My.Resources.Resources.SBP3_Date_Icon
        Me.btn_noti.Location = New System.Drawing.Point(190, 257)
        Me.btn_noti.Name = "btn_noti"
        Me.btn_noti.Size = New System.Drawing.Size(28, 27)
        Me.btn_noti.TabIndex = 32
        Me.btn_noti.UseVisualStyleBackColor = False
        '
        'btn_start
        '
        Me.btn_start.BackColor = System.Drawing.Color.White
        Me.btn_start.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_start.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_start.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_start.ForeColor = System.Drawing.Color.Teal
        Me.btn_start.Location = New System.Drawing.Point(17, 221)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(86, 30)
        Me.btn_start.TabIndex = 31
        Me.btn_start.Text = "เริ่ม"
        Me.btn_start.UseVisualStyleBackColor = False
        '
        'btn_stop
        '
        Me.btn_stop.BackColor = System.Drawing.Color.White
        Me.btn_stop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_stop.Enabled = False
        Me.btn_stop.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stop.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stop.ForeColor = System.Drawing.Color.Red
        Me.btn_stop.Location = New System.Drawing.Point(123, 221)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Size = New System.Drawing.Size(86, 30)
        Me.btn_stop.TabIndex = 30
        Me.btn_stop.Text = "หยุด"
        Me.btn_stop.UseVisualStyleBackColor = False
        '
        'txt_messageboxtimer
        '
        Me.txt_messageboxtimer.Location = New System.Drawing.Point(17, 94)
        Me.txt_messageboxtimer.Multiline = True
        Me.txt_messageboxtimer.Name = "txt_messageboxtimer"
        Me.txt_messageboxtimer.Size = New System.Drawing.Size(185, 93)
        Me.txt_messageboxtimer.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ข้อความ"
        '
        'txt_maskbox
        '
        Me.txt_maskbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_maskbox.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_maskbox.Location = New System.Drawing.Point(24, 46)
        Me.txt_maskbox.Mask = "00:00"
        Me.txt_maskbox.Name = "txt_maskbox"
        Me.txt_maskbox.Size = New System.Drawing.Size(64, 26)
        Me.txt_maskbox.TabIndex = 3
        Me.txt_maskbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_maskbox.ValidatingType = GetType(Date)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "เวลา"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Teal
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(-1, -1)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(224, 28)
        Me.TextBox3.TabIndex = 1
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(253, 613)
        Me.ShapeContainer1.TabIndex = 11
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 17
        Me.LineShape1.X2 = 237
        Me.LineShape1.Y1 = 287
        Me.LineShape1.Y2 = 287
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "เดียวถึงเวลาเราจะเตือนนายเองนะ"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Simple Reminder"
        '
        'frm_note
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1050, 699)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btn_close)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_note"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frm_note"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Btn_close As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents txt_appoint As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lbl_timeset As System.Windows.Forms.Label
    Friend WithEvents btn_noti As System.Windows.Forms.Button
    Friend WithEvents lbl_timealam As System.Windows.Forms.Label
    Friend WithEvents btn_start As System.Windows.Forms.Button
    Friend WithEvents btn_stop As System.Windows.Forms.Button
    Friend WithEvents txt_messageboxtimer As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_maskbox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
End Class
