<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_customer
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView_showcus = New System.Windows.Forms.DataGridView()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txtshop_name = New System.Windows.Forms.TextBox()
        Me.txt_lastname = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.ชื่อ = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_refresh = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_customerID = New System.Windows.Forms.Label()
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.cbDateien = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.gbGroesse = New System.Windows.Forms.GroupBox()
        Me.rdOriginal = New System.Windows.Forms.RadioButton()
        Me.rdProgramm = New System.Windows.Forms.RadioButton()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_phone = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.picBild = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radio_cusold = New System.Windows.Forms.RadioButton()
        Me.radio_cusnew = New System.Windows.Forms.RadioButton()
        CType(Me.DataGridView_showcus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGroesse.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picBild, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView_showcus
        '
        Me.DataGridView_showcus.AllowUserToAddRows = False
        Me.DataGridView_showcus.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Cornsilk
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_showcus.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView_showcus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Cornsilk
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_showcus.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView_showcus.Location = New System.Drawing.Point(5, 17)
        Me.DataGridView_showcus.MultiSelect = False
        Me.DataGridView_showcus.Name = "DataGridView_showcus"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Cornsilk
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_showcus.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView_showcus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_showcus.Size = New System.Drawing.Size(643, 280)
        Me.DataGridView_showcus.TabIndex = 0
        '
        'txt_search
        '
        Me.txt_search.BackColor = System.Drawing.Color.Cornsilk
        Me.txt_search.Location = New System.Drawing.Point(213, 21)
        Me.txt_search.Multiline = True
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(127, 30)
        Me.txt_search.TabIndex = 2
        '
        'txt_address
        '
        Me.txt_address.BackColor = System.Drawing.Color.Cornsilk
        Me.txt_address.Font = New System.Drawing.Font("TH SarabunPSK", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_address.Location = New System.Drawing.Point(73, 166)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(352, 129)
        Me.txt_address.TabIndex = 3
        '
        'txtshop_name
        '
        Me.txtshop_name.BackColor = System.Drawing.Color.Cornsilk
        Me.txtshop_name.Font = New System.Drawing.Font("TH SarabunPSK", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtshop_name.Location = New System.Drawing.Point(65, 107)
        Me.txtshop_name.Name = "txtshop_name"
        Me.txtshop_name.Size = New System.Drawing.Size(150, 38)
        Me.txtshop_name.TabIndex = 4
        '
        'txt_lastname
        '
        Me.txt_lastname.BackColor = System.Drawing.Color.Cornsilk
        Me.txt_lastname.Font = New System.Drawing.Font("TH SarabunPSK", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_lastname.Location = New System.Drawing.Point(282, 51)
        Me.txt_lastname.Name = "txt_lastname"
        Me.txt_lastname.Size = New System.Drawing.Size(143, 38)
        Me.txt_lastname.TabIndex = 6
        '
        'txt_name
        '
        Me.txt_name.AcceptsReturn = True
        Me.txt_name.BackColor = System.Drawing.Color.Cornsilk
        Me.txt_name.Font = New System.Drawing.Font("TH SarabunPSK", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_name.Location = New System.Drawing.Point(65, 51)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(150, 38)
        Me.txt_name.TabIndex = 7
        '
        'ชื่อ
        '
        Me.ชื่อ.AutoSize = True
        Me.ชื่อ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ชื่อ.Location = New System.Drawing.Point(36, 60)
        Me.ชื่อ.Name = "ชื่อ"
        Me.ชื่อ.Size = New System.Drawing.Size(24, 18)
        Me.ชื่อ.TabIndex = 8
        Me.ชื่อ.Text = "ชื่อ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ชื่อร้าน"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(221, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "นามสกุล"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(221, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 18)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "เบอร์โทร"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "ที่อยู่ลูกค้า"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Galahadone.My.Resources.Resources.images__7_
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(183, 229)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'txt_refresh
        '
        Me.txt_refresh.Location = New System.Drawing.Point(12, 247)
        Me.txt_refresh.Name = "txt_refresh"
        Me.txt_refresh.Size = New System.Drawing.Size(75, 23)
        Me.txt_refresh.TabIndex = 13
        Me.txt_refresh.Text = "Refresh"
        Me.txt_refresh.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(93, 247)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 14
        Me.btn_add.Text = "เพิ่ม"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(93, 277)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 15
        Me.btn_delete.Text = "ลบ"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(12, 277)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 16
        Me.btn_update.Text = "แก้ไข"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 18)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "ID"
        '
        'lbl_customerID
        '
        Me.lbl_customerID.AutoSize = True
        Me.lbl_customerID.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customerID.Location = New System.Drawing.Point(62, 21)
        Me.lbl_customerID.Name = "lbl_customerID"
        Me.lbl_customerID.Size = New System.Drawing.Size(62, 18)
        Me.lbl_customerID.TabIndex = 18
        Me.lbl_customerID.Text = "Label6"
        '
        'cmdLoad
        '
        Me.cmdLoad.Font = New System.Drawing.Font("TH SarabunPSK", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdLoad.Location = New System.Drawing.Point(769, 17)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(63, 34)
        Me.cmdLoad.TabIndex = 20
        Me.cmdLoad.Text = "โหลด"
        Me.cmdLoad.UseVisualStyleBackColor = True
        '
        'cbDateien
        '
        Me.cbDateien.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDateien.FormattingEnabled = True
        Me.cbDateien.Location = New System.Drawing.Point(839, 20)
        Me.cbDateien.Name = "cbDateien"
        Me.cbDateien.Size = New System.Drawing.Size(198, 26)
        Me.cbDateien.TabIndex = 21
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Bilder JPG;GIF;PNG|*.jpg;*.gif;*.png"
        Me.OpenFileDialog1.Multiselect = True
        '
        'gbGroesse
        '
        Me.gbGroesse.AutoSize = True
        Me.gbGroesse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbGroesse.Controls.Add(Me.rdOriginal)
        Me.gbGroesse.Controls.Add(Me.rdProgramm)
        Me.gbGroesse.Location = New System.Drawing.Point(673, 10)
        Me.gbGroesse.Name = "gbGroesse"
        Me.gbGroesse.Size = New System.Drawing.Size(80, 84)
        Me.gbGroesse.TabIndex = 22
        Me.gbGroesse.TabStop = False
        Me.gbGroesse.Text = "ขยาย"
        '
        'rdOriginal
        '
        Me.rdOriginal.AutoSize = True
        Me.rdOriginal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdOriginal.Location = New System.Drawing.Point(6, 43)
        Me.rdOriginal.Name = "rdOriginal"
        Me.rdOriginal.Size = New System.Drawing.Size(68, 22)
        Me.rdOriginal.TabIndex = 0
        Me.rdOriginal.Text = "ซูมออก"
        Me.rdOriginal.UseVisualStyleBackColor = True
        '
        'rdProgramm
        '
        Me.rdProgramm.AutoSize = True
        Me.rdProgramm.Checked = True
        Me.rdProgramm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdProgramm.Location = New System.Drawing.Point(7, 20)
        Me.rdProgramm.Name = "rdProgramm"
        Me.rdProgramm.Size = New System.Drawing.Size(62, 22)
        Me.rdProgramm.TabIndex = 0
        Me.rdProgramm.TabStop = True
        Me.rdProgramm.Text = "ซูมเข้า"
        Me.rdProgramm.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.Location = New System.Drawing.Point(819, 54)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(45, 29)
        Me.cmdNext.TabIndex = 23
        Me.cmdNext.Text = ">"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        Me.cmdBack.Location = New System.Drawing.Point(769, 54)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(44, 29)
        Me.cmdBack.TabIndex = 24
        Me.cmdBack.Text = "<"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(346, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 18)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "ค้นหา"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_phone)
        Me.GroupBox1.Controls.Add(Me.lbl_customerID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ชื่อ)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.txt_lastname)
        Me.GroupBox1.Controls.Add(Me.txtshop_name)
        Me.GroupBox1.Controls.Add(Me.txt_address)
        Me.GroupBox1.Location = New System.Drawing.Point(204, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 318)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'txt_phone
        '
        Me.txt_phone.BackColor = System.Drawing.Color.Cornsilk
        Me.txt_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_phone.Font = New System.Drawing.Font("TH SarabunPSK", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_phone.Location = New System.Drawing.Point(282, 107)
        Me.txt_phone.Mask = "000-0000000"
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(99, 38)
        Me.txt_phone.TabIndex = 19
        Me.txt_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView_showcus)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 375)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(654, 307)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        '
        'picBild
        '
        Me.picBild.Location = New System.Drawing.Point(680, 117)
        Me.picBild.Name = "picBild"
        Me.picBild.Size = New System.Drawing.Size(344, 473)
        Me.picBild.TabIndex = 28
        Me.picBild.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radio_cusold)
        Me.GroupBox3.Controls.Add(Me.radio_cusnew)
        Me.GroupBox3.Location = New System.Drawing.Point(435, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(186, 42)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        '
        'radio_cusold
        '
        Me.radio_cusold.AutoSize = True
        Me.radio_cusold.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.radio_cusold.Location = New System.Drawing.Point(104, 15)
        Me.radio_cusold.Name = "radio_cusold"
        Me.radio_cusold.Size = New System.Drawing.Size(73, 22)
        Me.radio_cusold.TabIndex = 1
        Me.radio_cusold.TabStop = True
        Me.radio_cusold.Text = "ลูกค้าเก่า"
        Me.radio_cusold.UseVisualStyleBackColor = True
        '
        'radio_cusnew
        '
        Me.radio_cusnew.AutoSize = True
        Me.radio_cusnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.radio_cusnew.Location = New System.Drawing.Point(7, 15)
        Me.radio_cusnew.Name = "radio_cusnew"
        Me.radio_cusnew.Size = New System.Drawing.Size(79, 22)
        Me.radio_cusnew.TabIndex = 0
        Me.radio_cusnew.TabStop = True
        Me.radio_cusnew.Text = "ลูกค้าใหม่"
        Me.radio_cusnew.UseVisualStyleBackColor = True
        '
        'frm_customer
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1050, 699)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.picBild)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.gbGroesse)
        Me.Controls.Add(Me.cbDateien)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.txt_refresh)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ฐานข้อมูลลูกค้า"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.DataGridView_showcus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGroesse.ResumeLayout(False)
        Me.gbGroesse.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.picBild, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView_showcus As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents txtshop_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_lastname As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents ชื่อ As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_refresh As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_customerID As System.Windows.Forms.Label
    Friend WithEvents cmdLoad As System.Windows.Forms.Button
    Friend WithEvents cbDateien As System.Windows.Forms.ComboBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents gbGroesse As System.Windows.Forms.GroupBox
    Friend WithEvents rdOriginal As System.Windows.Forms.RadioButton
    Friend WithEvents rdProgramm As System.Windows.Forms.RadioButton
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_phone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents picBild As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents radio_cusold As System.Windows.Forms.RadioButton
    Friend WithEvents radio_cusnew As System.Windows.Forms.RadioButton
End Class
