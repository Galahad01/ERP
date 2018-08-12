<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_staffparty
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
        Me.hippo = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_contact = New System.Windows.Forms.TextBox()
        Me.txt_dept = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_userlogin = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView_useradd = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_del_edit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_contact_edit = New System.Windows.Forms.TextBox()
        Me.txt_dept_edit = New System.Windows.Forms.TextBox()
        Me.txt_password_edit = New System.Windows.Forms.TextBox()
        Me.txt_userlogin_edit = New System.Windows.Forms.TextBox()
        Me.txt_name_edit = New System.Windows.Forms.TextBox()
        Me.btn_save_edit = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_id_edit = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DataGridView_edit = New System.Windows.Forms.DataGridView()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.btn_savenote = New System.Windows.Forms.Button()
        CType(Me.hippo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView_useradd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView_edit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'hippo
        '
        Me.hippo.Image = Global.Galahadone.My.Resources.Resources.ฮิปโปแดง
        Me.hippo.Location = New System.Drawing.Point(12, 399)
        Me.hippo.Name = "hippo"
        Me.hippo.Size = New System.Drawing.Size(120, 55)
        Me.hippo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hippo.TabIndex = 4
        Me.hippo.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Galahadone.My.Resources.Resources.Logo___SL
        Me.PictureBox2.Location = New System.Drawing.Point(12, 236)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(140, 77)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Galahadone.My.Resources.Resources.download__2_
        Me.PictureBox1.Location = New System.Drawing.Point(8, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(148, 227)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(38, 335)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("TH SarabunPSK", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(158, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(880, 479)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txt_contact)
        Me.TabPage1.Controls.Add(Me.txt_dept)
        Me.TabPage1.Controls.Add(Me.txt_password)
        Me.TabPage1.Controls.Add(Me.txt_userlogin)
        Me.TabPage1.Controls.Add(Me.txt_name)
        Me.TabPage1.Controls.Add(Me.btn_save)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.DataGridView_useradd)
        Me.TabPage1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TabPage1.Location = New System.Drawing.Point(4, 40)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(872, 435)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "เพิ่ม"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("TH SarabunPSK", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(696, 282)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 31)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "เบอร์โทรติดต่อ"
        '
        'txt_contact
        '
        Me.txt_contact.Location = New System.Drawing.Point(696, 319)
        Me.txt_contact.Name = "txt_contact"
        Me.txt_contact.Size = New System.Drawing.Size(152, 27)
        Me.txt_contact.TabIndex = 12
        '
        'txt_dept
        '
        Me.txt_dept.Location = New System.Drawing.Point(696, 252)
        Me.txt_dept.Name = "txt_dept"
        Me.txt_dept.Size = New System.Drawing.Size(152, 27)
        Me.txt_dept.TabIndex = 11
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(696, 188)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(152, 27)
        Me.txt_password.TabIndex = 10
        '
        'txt_userlogin
        '
        Me.txt_userlogin.Location = New System.Drawing.Point(696, 124)
        Me.txt_userlogin.Name = "txt_userlogin"
        Me.txt_userlogin.Size = New System.Drawing.Size(152, 27)
        Me.txt_userlogin.TabIndex = 9
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(696, 49)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(152, 27)
        Me.txt_name.TabIndex = 8
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("TH SarabunPSK", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save.Location = New System.Drawing.Point(696, 368)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(115, 27)
        Me.btn_save.TabIndex = 7
        Me.btn_save.Text = "เพิ่มชื่อ"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("TH SarabunPSK", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(696, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 31)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "แผนก"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("TH SarabunPSK", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(696, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 31)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("TH SarabunPSK", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(696, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 31)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ชื่อLogin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("TH SarabunPSK", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(696, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 31)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ชื่อ นามสกุล"
        '
        'DataGridView_useradd
        '
        Me.DataGridView_useradd.AllowUserToAddRows = False
        Me.DataGridView_useradd.AllowUserToDeleteRows = False
        Me.DataGridView_useradd.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_useradd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_useradd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_useradd.Location = New System.Drawing.Point(44, 70)
        Me.DataGridView_useradd.Name = "DataGridView_useradd"
        Me.DataGridView_useradd.ReadOnly = True
        Me.DataGridView_useradd.RowHeadersVisible = False
        Me.DataGridView_useradd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_useradd.Size = New System.Drawing.Size(624, 209)
        Me.DataGridView_useradd.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.btn_del_edit)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txt_contact_edit)
        Me.TabPage2.Controls.Add(Me.txt_dept_edit)
        Me.TabPage2.Controls.Add(Me.txt_password_edit)
        Me.TabPage2.Controls.Add(Me.txt_userlogin_edit)
        Me.TabPage2.Controls.Add(Me.txt_name_edit)
        Me.TabPage2.Controls.Add(Me.btn_save_edit)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.lbl_id_edit)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.DataGridView_edit)
        Me.TabPage2.Location = New System.Drawing.Point(4, 40)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(872, 435)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "แก้ไข"
        '
        'btn_del_edit
        '
        Me.btn_del_edit.Font = New System.Drawing.Font("TH SarabunPSK", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_del_edit.Location = New System.Drawing.Point(191, 388)
        Me.btn_del_edit.Name = "btn_del_edit"
        Me.btn_del_edit.Size = New System.Drawing.Size(115, 28)
        Me.btn_del_edit.TabIndex = 28
        Me.btn_del_edit.Text = "ลบ"
        Me.btn_del_edit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("TH SarabunPSK", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 327)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 31)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "เบอร์โทรติดต่อ"
        '
        'txt_contact_edit
        '
        Me.txt_contact_edit.Location = New System.Drawing.Point(117, 327)
        Me.txt_contact_edit.Name = "txt_contact_edit"
        Me.txt_contact_edit.Size = New System.Drawing.Size(189, 38)
        Me.txt_contact_edit.TabIndex = 26
        '
        'txt_dept_edit
        '
        Me.txt_dept_edit.Location = New System.Drawing.Point(117, 277)
        Me.txt_dept_edit.Name = "txt_dept_edit"
        Me.txt_dept_edit.Size = New System.Drawing.Size(189, 38)
        Me.txt_dept_edit.TabIndex = 25
        '
        'txt_password_edit
        '
        Me.txt_password_edit.Location = New System.Drawing.Point(117, 220)
        Me.txt_password_edit.Name = "txt_password_edit"
        Me.txt_password_edit.Size = New System.Drawing.Size(189, 38)
        Me.txt_password_edit.TabIndex = 24
        '
        'txt_userlogin_edit
        '
        Me.txt_userlogin_edit.Location = New System.Drawing.Point(117, 168)
        Me.txt_userlogin_edit.Name = "txt_userlogin_edit"
        Me.txt_userlogin_edit.Size = New System.Drawing.Size(189, 38)
        Me.txt_userlogin_edit.TabIndex = 23
        '
        'txt_name_edit
        '
        Me.txt_name_edit.Location = New System.Drawing.Point(117, 116)
        Me.txt_name_edit.Name = "txt_name_edit"
        Me.txt_name_edit.Size = New System.Drawing.Size(189, 38)
        Me.txt_name_edit.TabIndex = 22
        '
        'btn_save_edit
        '
        Me.btn_save_edit.Font = New System.Drawing.Font("TH SarabunPSK", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save_edit.Location = New System.Drawing.Point(52, 389)
        Me.btn_save_edit.Name = "btn_save_edit"
        Me.btn_save_edit.Size = New System.Drawing.Size(115, 27)
        Me.btn_save_edit.TabIndex = 21
        Me.btn_save_edit.Text = "แก้ไข"
        Me.btn_save_edit.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("TH SarabunPSK", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(2, 277)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 31)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "แผนก"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("TH SarabunPSK", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(2, 220)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 31)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Password"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("TH SarabunPSK", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(2, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 31)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "ชื่อLogin"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("TH SarabunPSK", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(2, 119)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 31)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "ชื่อ นามสกุล"
        '
        'lbl_id_edit
        '
        Me.lbl_id_edit.AutoSize = True
        Me.lbl_id_edit.Font = New System.Drawing.Font("TH SarabunPSK", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id_edit.Location = New System.Drawing.Point(159, 50)
        Me.lbl_id_edit.Name = "lbl_id_edit"
        Me.lbl_id_edit.Size = New System.Drawing.Size(63, 31)
        Me.lbl_id_edit.TabIndex = 16
        Me.lbl_id_edit.Text = "Label2"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("TH SarabunPSK", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(66, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(29, 31)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "ID"
        '
        'DataGridView_edit
        '
        Me.DataGridView_edit.AllowUserToAddRows = False
        Me.DataGridView_edit.AllowUserToDeleteRows = False
        Me.DataGridView_edit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_edit.Location = New System.Drawing.Point(328, 116)
        Me.DataGridView_edit.Name = "DataGridView_edit"
        Me.DataGridView_edit.ReadOnly = True
        Me.DataGridView_edit.RowHeadersVisible = False
        Me.DataGridView_edit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_edit.Size = New System.Drawing.Size(538, 237)
        Me.DataGridView_edit.TabIndex = 14
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("TH SarabunPSK", 15.7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(178, 488)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(579, 188)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = "โน๊ต"
        '
        'btn_savenote
        '
        Me.btn_savenote.Font = New System.Drawing.Font("TH SarabunPSK", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_savenote.Location = New System.Drawing.Point(789, 514)
        Me.btn_savenote.Name = "btn_savenote"
        Me.btn_savenote.Size = New System.Drawing.Size(115, 27)
        Me.btn_savenote.TabIndex = 7
        Me.btn_savenote.Text = "บันทึก"
        Me.btn_savenote.UseVisualStyleBackColor = True
        '
        'frm_staffparty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1050, 699)
        Me.Controls.Add(Me.btn_savenote)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.hippo)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_staffparty"
        Me.Text = "staffparty"
        CType(Me.hippo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView_useradd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView_edit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents hippo As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_contact As System.Windows.Forms.TextBox
    Friend WithEvents txt_dept As System.Windows.Forms.TextBox
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents txt_userlogin As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView_useradd As System.Windows.Forms.DataGridView
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents btn_savenote As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btn_del_edit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_contact_edit As System.Windows.Forms.TextBox
    Friend WithEvents txt_dept_edit As System.Windows.Forms.TextBox
    Friend WithEvents txt_password_edit As System.Windows.Forms.TextBox
    Friend WithEvents txt_userlogin_edit As System.Windows.Forms.TextBox
    Friend WithEvents txt_name_edit As System.Windows.Forms.TextBox
    Friend WithEvents btn_save_edit As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbl_id_edit As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DataGridView_edit As System.Windows.Forms.DataGridView
End Class
