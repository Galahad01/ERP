<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Selldeil
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
        Dim BirthdayLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim LastnameLabel As System.Windows.Forms.Label
        Dim CourseIDLabel As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Selldeil))
        Me.DataGridView_showcus1 = New System.Windows.Forms.DataGridView()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SqlabC_AlertBox2 = New SQLABC_ModernUI.SQLABC_AlertBox()
        Me.SqlabC_AlertBox1 = New SQLABC_ModernUI.SQLABC_AlertBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.radio_cusold = New System.Windows.Forms.RadioButton()
        Me.radio_cusnew = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btn_savenote = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_upprice3 = New System.Windows.Forms.TextBox()
        Me.txt_upprice2 = New System.Windows.Forms.TextBox()
        Me.txt_upprice1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_noteorder2 = New System.Windows.Forms.TextBox()
        Me.txt_noteorder = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_lastname = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_crytalorderID = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_colourbag = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_totalprice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_bagprice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_bagtotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_bagsize = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_thickbag = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txt_customer_name = New System.Windows.Forms.TextBox()
        Me.txt_bagtype = New System.Windows.Forms.TextBox()
        Me.lbl_customername = New System.Windows.Forms.Label()
        Me.lbl_orderid = New System.Windows.Forms.Label()
        Me.txt_customerphone = New System.Windows.Forms.TextBox()
        Me.txt_customeraddress = New System.Windows.Forms.TextBox()
        Me.txt_shopname = New System.Windows.Forms.TextBox()
        Me.txt_searchcus = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_delete = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_sonumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_customercombo = New System.Windows.Forms.ComboBox()
        Me.btn_scarch = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        BirthdayLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        LastnameLabel = New System.Windows.Forms.Label()
        CourseIDLabel = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        CType(Me.DataGridView_showcus1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BirthdayLabel
        '
        BirthdayLabel.AutoSize = True
        BirthdayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BirthdayLabel.Location = New System.Drawing.Point(7, 182)
        BirthdayLabel.Name = "BirthdayLabel"
        BirthdayLabel.Size = New System.Drawing.Size(53, 20)
        BirthdayLabel.TabIndex = 11
        BirthdayLabel.Text = "ชื่อร้าน:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(185, 117)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(39, 20)
        AddressLabel.TabIndex = 13
        AddressLabel.Text = "ที่อยุ่:"
        '
        'LastnameLabel
        '
        LastnameLabel.AutoSize = True
        LastnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastnameLabel.Location = New System.Drawing.Point(7, 111)
        LastnameLabel.Name = "LastnameLabel"
        LastnameLabel.Size = New System.Drawing.Size(102, 20)
        LastnameLabel.TabIndex = 12
        LastnameLabel.Text = "เบอร์โทรติดต่อ:"
        '
        'CourseIDLabel
        '
        CourseIDLabel.AutoSize = True
        CourseIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        CourseIDLabel.Location = New System.Drawing.Point(10, 49)
        CourseIDLabel.Name = "CourseIDLabel"
        CourseIDLabel.Size = New System.Drawing.Size(52, 20)
        CourseIDLabel.TabIndex = 6
        CourseIDLabel.Text = "ชื่อจริง:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Label12.Location = New System.Drawing.Point(185, 49)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(64, 20)
        Label12.TabIndex = 80
        Label12.Text = "นามสกุล:"
        '
        'DataGridView_showcus1
        '
        Me.DataGridView_showcus1.AllowUserToAddRows = False
        Me.DataGridView_showcus1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_showcus1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_showcus1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Cornsilk
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_showcus1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_showcus1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView_showcus1.MultiSelect = False
        Me.DataGridView_showcus1.Name = "DataGridView_showcus1"
        Me.DataGridView_showcus1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Cornsilk
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_showcus1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView_showcus1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_showcus1.Size = New System.Drawing.Size(1008, 314)
        Me.DataGridView_showcus1.TabIndex = 0
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(56, 24)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(99, 23)
        Me.btn_update.TabIndex = 20
        Me.btn_update.Text = "บันทึก:UpDate"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.IndianRed
        Me.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.Black
        Me.btn_close.Location = New System.Drawing.Point(185, 62)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(98, 23)
        Me.btn_close.TabIndex = 21
        Me.btn_close.Text = "ปิด"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SqlabC_AlertBox2)
        Me.GroupBox2.Controls.Add(Me.SqlabC_AlertBox1)
        Me.GroupBox2.Controls.Add(Me.DataGridView_showcus1)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 361)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1020, 326)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        '
        'SqlabC_AlertBox2
        '
        Me.SqlabC_AlertBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.SqlabC_AlertBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SqlabC_AlertBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.SqlabC_AlertBox2.kind = SQLABC_ModernUI.SQLABC_AlertBox._Kind.[Error]
        Me.SqlabC_AlertBox2.Location = New System.Drawing.Point(438, 67)
        Me.SqlabC_AlertBox2.Name = "SqlabC_AlertBox2"
        Me.SqlabC_AlertBox2.Size = New System.Drawing.Size(576, 42)
        Me.SqlabC_AlertBox2.TabIndex = 2
        Me.SqlabC_AlertBox2.Text = "ไม่สำเร็จ กากอ่ะ"
        Me.SqlabC_AlertBox2.Visible = False
        '
        'SqlabC_AlertBox1
        '
        Me.SqlabC_AlertBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.SqlabC_AlertBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SqlabC_AlertBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.SqlabC_AlertBox1.kind = SQLABC_ModernUI.SQLABC_AlertBox._Kind.Success
        Me.SqlabC_AlertBox1.Location = New System.Drawing.Point(438, 19)
        Me.SqlabC_AlertBox1.Name = "SqlabC_AlertBox1"
        Me.SqlabC_AlertBox1.Size = New System.Drawing.Size(576, 42)
        Me.SqlabC_AlertBox1.TabIndex = 1
        Me.SqlabC_AlertBox1.Text = "สำเร็จแล้วจ้า"
        Me.SqlabC_AlertBox1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.txt_lastname)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lbl_crytalorderID)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_colourbag)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_totalprice)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_bagprice)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_bagtotal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_bagsize)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_thickbag)
        Me.GroupBox1.Controls.Add(Me.label2)
        Me.GroupBox1.Controls.Add(Me.txt_customer_name)
        Me.GroupBox1.Controls.Add(Me.txt_bagtype)
        Me.GroupBox1.Controls.Add(Me.lbl_customername)
        Me.GroupBox1.Controls.Add(Me.lbl_orderid)
        Me.GroupBox1.Controls.Add(Me.txt_customerphone)
        Me.GroupBox1.Controls.Add(CourseIDLabel)
        Me.GroupBox1.Controls.Add(LastnameLabel)
        Me.GroupBox1.Controls.Add(AddressLabel)
        Me.GroupBox1.Controls.Add(BirthdayLabel)
        Me.GroupBox1.Controls.Add(Me.txt_customeraddress)
        Me.GroupBox1.Controls.Add(Me.txt_shopname)
        Me.GroupBox1.Controls.Add(Label12)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1020, 247)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.radio_cusold)
        Me.GroupBox6.Controls.Add(Me.radio_cusnew)
        Me.GroupBox6.Location = New System.Drawing.Point(524, 33)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(106, 140)
        Me.GroupBox6.TabIndex = 62
        Me.GroupBox6.TabStop = False
        '
        'radio_cusold
        '
        Me.radio_cusold.AutoSize = True
        Me.radio_cusold.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.radio_cusold.Location = New System.Drawing.Point(13, 88)
        Me.radio_cusold.Name = "radio_cusold"
        Me.radio_cusold.Size = New System.Drawing.Size(80, 22)
        Me.radio_cusold.TabIndex = 1
        Me.radio_cusold.TabStop = True
        Me.radio_cusold.Text = "ลูกค้าเก่า"
        Me.radio_cusold.UseVisualStyleBackColor = True
        '
        'radio_cusnew
        '
        Me.radio_cusnew.AutoSize = True
        Me.radio_cusnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.radio_cusnew.Location = New System.Drawing.Point(13, 42)
        Me.radio_cusnew.Name = "radio_cusnew"
        Me.radio_cusnew.Size = New System.Drawing.Size(86, 22)
        Me.radio_cusnew.TabIndex = 0
        Me.radio_cusnew.TabStop = True
        Me.radio_cusnew.Text = "ลูกค้าใหม่"
        Me.radio_cusnew.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btn_savenote)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.txt_upprice3)
        Me.GroupBox5.Controls.Add(Me.txt_upprice2)
        Me.GroupBox5.Controls.Add(Me.txt_upprice1)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.txt_noteorder2)
        Me.GroupBox5.Controls.Add(Me.txt_noteorder)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Location = New System.Drawing.Point(636, 20)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(372, 221)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        '
        'btn_savenote
        '
        Me.btn_savenote.BackColor = System.Drawing.Color.Lime
        Me.btn_savenote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_savenote.Location = New System.Drawing.Point(242, 121)
        Me.btn_savenote.Name = "btn_savenote"
        Me.btn_savenote.Size = New System.Drawing.Size(98, 22)
        Me.btn_savenote.TabIndex = 87
        Me.btn_savenote.Text = "Save โน๊ต"
        Me.btn_savenote.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(213, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 18)
        Me.Label14.TabIndex = 86
        Me.Label14.Text = "เลข 3 ตัว บน"
        '
        'txt_upprice3
        '
        Me.txt_upprice3.BackColor = System.Drawing.SystemColors.WindowText
        Me.txt_upprice3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_upprice3.ForeColor = System.Drawing.Color.Lime
        Me.txt_upprice3.Location = New System.Drawing.Point(312, 52)
        Me.txt_upprice3.Multiline = True
        Me.txt_upprice3.Name = "txt_upprice3"
        Me.txt_upprice3.Size = New System.Drawing.Size(42, 33)
        Me.txt_upprice3.TabIndex = 85
        Me.txt_upprice3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_upprice2
        '
        Me.txt_upprice2.BackColor = System.Drawing.SystemColors.WindowText
        Me.txt_upprice2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_upprice2.ForeColor = System.Drawing.Color.Lime
        Me.txt_upprice2.Location = New System.Drawing.Point(264, 52)
        Me.txt_upprice2.Multiline = True
        Me.txt_upprice2.Name = "txt_upprice2"
        Me.txt_upprice2.Size = New System.Drawing.Size(42, 33)
        Me.txt_upprice2.TabIndex = 84
        Me.txt_upprice2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_upprice1
        '
        Me.txt_upprice1.BackColor = System.Drawing.SystemColors.WindowText
        Me.txt_upprice1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_upprice1.ForeColor = System.Drawing.Color.Lime
        Me.txt_upprice1.Location = New System.Drawing.Point(216, 52)
        Me.txt_upprice1.Multiline = True
        Me.txt_upprice1.Name = "txt_upprice1"
        Me.txt_upprice1.Size = New System.Drawing.Size(42, 33)
        Me.txt_upprice1.TabIndex = 83
        Me.txt_upprice1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(35, 95)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 20)
        Me.Label13.TabIndex = 82
        Me.Label13.Text = "โน๊ต"
        '
        'txt_noteorder2
        '
        Me.txt_noteorder2.BackColor = System.Drawing.SystemColors.WindowText
        Me.txt_noteorder2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_noteorder2.ForeColor = System.Drawing.Color.Lime
        Me.txt_noteorder2.Location = New System.Drawing.Point(39, 118)
        Me.txt_noteorder2.Multiline = True
        Me.txt_noteorder2.Name = "txt_noteorder2"
        Me.txt_noteorder2.Size = New System.Drawing.Size(197, 95)
        Me.txt_noteorder2.TabIndex = 81
        '
        'txt_noteorder
        '
        Me.txt_noteorder.BackColor = System.Drawing.SystemColors.WindowText
        Me.txt_noteorder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_noteorder.ForeColor = System.Drawing.Color.Lime
        Me.txt_noteorder.Location = New System.Drawing.Point(39, 52)
        Me.txt_noteorder.Multiline = True
        Me.txt_noteorder.Name = "txt_noteorder"
        Me.txt_noteorder.Size = New System.Drawing.Size(155, 33)
        Me.txt_noteorder.TabIndex = 74
        Me.txt_noteorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 20)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "วันส่งของ"
        '
        'txt_lastname
        '
        Me.txt_lastname.BackColor = System.Drawing.Color.Cornsilk
        Me.txt_lastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lastname.Location = New System.Drawing.Point(184, 75)
        Me.txt_lastname.Multiline = True
        Me.txt_lastname.Name = "txt_lastname"
        Me.txt_lastname.ReadOnly = True
        Me.txt_lastname.Size = New System.Drawing.Size(172, 30)
        Me.txt_lastname.TabIndex = 79
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(185, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 20)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "PO ID"
        '
        'lbl_crytalorderID
        '
        Me.lbl_crytalorderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_crytalorderID.Location = New System.Drawing.Point(243, 20)
        Me.lbl_crytalorderID.Name = "lbl_crytalorderID"
        Me.lbl_crytalorderID.Size = New System.Drawing.Size(112, 29)
        Me.lbl_crytalorderID.TabIndex = 77
        Me.lbl_crytalorderID.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(447, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 20)
        Me.Label9.TabIndex = 73
        Me.Label9.Text = "พิมพ์"
        '
        'txt_colourbag
        '
        Me.txt_colourbag.BackColor = System.Drawing.SystemColors.WindowText
        Me.txt_colourbag.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_colourbag.ForeColor = System.Drawing.Color.Lime
        Me.txt_colourbag.Location = New System.Drawing.Point(442, 75)
        Me.txt_colourbag.Multiline = True
        Me.txt_colourbag.Name = "txt_colourbag"
        Me.txt_colourbag.Size = New System.Drawing.Size(73, 33)
        Me.txt_colourbag.TabIndex = 72
        Me.txt_colourbag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(540, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 20)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "ราคารวม"
        '
        'txt_totalprice
        '
        Me.txt_totalprice.BackColor = System.Drawing.SystemColors.WindowText
        Me.txt_totalprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalprice.ForeColor = System.Drawing.Color.Lime
        Me.txt_totalprice.Location = New System.Drawing.Point(521, 208)
        Me.txt_totalprice.Multiline = True
        Me.txt_totalprice.Name = "txt_totalprice"
        Me.txt_totalprice.Size = New System.Drawing.Size(95, 33)
        Me.txt_totalprice.TabIndex = 70
        Me.txt_totalprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(434, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 20)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "ราคา / หน่วย"
        '
        'txt_bagprice
        '
        Me.txt_bagprice.BackColor = System.Drawing.Color.Black
        Me.txt_bagprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bagprice.ForeColor = System.Drawing.Color.Lime
        Me.txt_bagprice.Location = New System.Drawing.Point(438, 208)
        Me.txt_bagprice.Multiline = True
        Me.txt_bagprice.Name = "txt_bagprice"
        Me.txt_bagprice.Size = New System.Drawing.Size(77, 33)
        Me.txt_bagprice.TabIndex = 68
        Me.txt_bagprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(361, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 20)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "จำนวนสั่ง"
        '
        'txt_bagtotal
        '
        Me.txt_bagtotal.BackColor = System.Drawing.SystemColors.WindowText
        Me.txt_bagtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bagtotal.ForeColor = System.Drawing.Color.Lime
        Me.txt_bagtotal.Location = New System.Drawing.Point(365, 208)
        Me.txt_bagtotal.Multiline = True
        Me.txt_bagtotal.Name = "txt_bagtotal"
        Me.txt_bagtotal.Size = New System.Drawing.Size(67, 33)
        Me.txt_bagtotal.TabIndex = 66
        Me.txt_bagtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(438, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 20)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "ขนาด"
        '
        'txt_bagsize
        '
        Me.txt_bagsize.BackColor = System.Drawing.SystemColors.WindowText
        Me.txt_bagsize.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bagsize.ForeColor = System.Drawing.Color.Lime
        Me.txt_bagsize.Location = New System.Drawing.Point(442, 141)
        Me.txt_bagsize.Multiline = True
        Me.txt_bagsize.Name = "txt_bagsize"
        Me.txt_bagsize.Size = New System.Drawing.Size(73, 33)
        Me.txt_bagsize.TabIndex = 64
        Me.txt_bagsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(361, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 20)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "หนา"
        '
        'txt_thickbag
        '
        Me.txt_thickbag.BackColor = System.Drawing.SystemColors.WindowText
        Me.txt_thickbag.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_thickbag.ForeColor = System.Drawing.Color.Lime
        Me.txt_thickbag.Location = New System.Drawing.Point(365, 140)
        Me.txt_thickbag.Multiline = True
        Me.txt_thickbag.Name = "txt_thickbag"
        Me.txt_thickbag.Size = New System.Drawing.Size(67, 33)
        Me.txt_thickbag.TabIndex = 62
        Me.txt_thickbag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.label2.Location = New System.Drawing.Point(361, 45)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(52, 20)
        Me.label2.TabIndex = 59
        Me.label2.Text = "วัตถุดิบ"
        '
        'txt_customer_name
        '
        Me.txt_customer_name.BackColor = System.Drawing.Color.Cornsilk
        Me.txt_customer_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_customer_name.Location = New System.Drawing.Point(6, 75)
        Me.txt_customer_name.Multiline = True
        Me.txt_customer_name.Name = "txt_customer_name"
        Me.txt_customer_name.ReadOnly = True
        Me.txt_customer_name.Size = New System.Drawing.Size(172, 33)
        Me.txt_customer_name.TabIndex = 54
        '
        'txt_bagtype
        '
        Me.txt_bagtype.BackColor = System.Drawing.SystemColors.WindowText
        Me.txt_bagtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bagtype.ForeColor = System.Drawing.Color.Lime
        Me.txt_bagtype.Location = New System.Drawing.Point(365, 75)
        Me.txt_bagtype.Multiline = True
        Me.txt_bagtype.Name = "txt_bagtype"
        Me.txt_bagtype.Size = New System.Drawing.Size(67, 33)
        Me.txt_bagtype.TabIndex = 55
        Me.txt_bagtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_customername
        '
        Me.lbl_customername.AutoSize = True
        Me.lbl_customername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customername.Location = New System.Drawing.Point(7, 23)
        Me.lbl_customername.Name = "lbl_customername"
        Me.lbl_customername.Size = New System.Drawing.Size(66, 20)
        Me.lbl_customername.TabIndex = 15
        Me.lbl_customername.Text = "OrderID"
        '
        'lbl_orderid
        '
        Me.lbl_orderid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid.Location = New System.Drawing.Point(71, 19)
        Me.lbl_orderid.Name = "lbl_orderid"
        Me.lbl_orderid.Size = New System.Drawing.Size(107, 29)
        Me.lbl_orderid.TabIndex = 14
        Me.lbl_orderid.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_customerphone
        '
        Me.txt_customerphone.BackColor = System.Drawing.Color.Cornsilk
        Me.txt_customerphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_customerphone.Location = New System.Drawing.Point(6, 134)
        Me.txt_customerphone.Multiline = True
        Me.txt_customerphone.Name = "txt_customerphone"
        Me.txt_customerphone.ReadOnly = True
        Me.txt_customerphone.Size = New System.Drawing.Size(172, 33)
        Me.txt_customerphone.TabIndex = 3
        '
        'txt_customeraddress
        '
        Me.txt_customeraddress.BackColor = System.Drawing.Color.Cornsilk
        Me.txt_customeraddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_customeraddress.Location = New System.Drawing.Point(184, 146)
        Me.txt_customeraddress.Multiline = True
        Me.txt_customeraddress.Name = "txt_customeraddress"
        Me.txt_customeraddress.ReadOnly = True
        Me.txt_customeraddress.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_customeraddress.Size = New System.Drawing.Size(163, 95)
        Me.txt_customeraddress.TabIndex = 4
        '
        'txt_shopname
        '
        Me.txt_shopname.BackColor = System.Drawing.Color.Cornsilk
        Me.txt_shopname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_shopname.Location = New System.Drawing.Point(5, 205)
        Me.txt_shopname.Multiline = True
        Me.txt_shopname.Name = "txt_shopname"
        Me.txt_shopname.ReadOnly = True
        Me.txt_shopname.Size = New System.Drawing.Size(173, 33)
        Me.txt_shopname.TabIndex = 2
        '
        'txt_searchcus
        '
        Me.txt_searchcus.BackColor = System.Drawing.Color.Cornsilk
        Me.txt_searchcus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_searchcus.Location = New System.Drawing.Point(11, 18)
        Me.txt_searchcus.Multiline = True
        Me.txt_searchcus.Name = "txt_searchcus"
        Me.txt_searchcus.Size = New System.Drawing.Size(274, 29)
        Me.txt_searchcus.TabIndex = 61
        Me.txt_searchcus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SkyBlue
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.Location = New System.Drawing.Point(157, 53)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(57, 24)
        Me.Button2.TabIndex = 55
        Me.Button2.Text = "Refresh "
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txt_delete
        '
        Me.txt_delete.BackColor = System.Drawing.Color.IndianRed
        Me.txt_delete.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.txt_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_delete.ForeColor = System.Drawing.Color.Black
        Me.txt_delete.Location = New System.Drawing.Point(56, 62)
        Me.txt_delete.Name = "txt_delete"
        Me.txt_delete.Size = New System.Drawing.Size(99, 23)
        Me.txt_delete.TabIndex = 54
        Me.txt_delete.Text = "ลบ"
        Me.txt_delete.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PeachPuff
        Me.Button1.Location = New System.Drawing.Point(185, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "Report"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_close)
        Me.GroupBox4.Controls.Add(Me.btn_update)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.txt_delete)
        Me.GroupBox4.Location = New System.Drawing.Point(709, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(335, 100)
        Me.GroupBox4.TabIndex = 60
        Me.GroupBox4.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(470, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 20)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "เลขที่ SO number"
        '
        'txt_sonumber
        '
        Me.txt_sonumber.BackColor = System.Drawing.Color.Cornsilk
        Me.txt_sonumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sonumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_sonumber.Location = New System.Drawing.Point(301, 18)
        Me.txt_sonumber.Multiline = True
        Me.txt_sonumber.Name = "txt_sonumber"
        Me.txt_sonumber.ReadOnly = True
        Me.txt_sonumber.Size = New System.Drawing.Size(163, 29)
        Me.txt_sonumber.TabIndex = 60
        Me.txt_sonumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(470, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 20)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "ค้นหารายชื่อลูกค้า"
        '
        'txt_customercombo
        '
        Me.txt_customercombo.BackColor = System.Drawing.Color.Cornsilk
        Me.txt_customercombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_customercombo.FormattingEnabled = True
        Me.txt_customercombo.Location = New System.Drawing.Point(301, 62)
        Me.txt_customercombo.Name = "txt_customercombo"
        Me.txt_customercombo.Size = New System.Drawing.Size(163, 28)
        Me.txt_customercombo.TabIndex = 5
        '
        'btn_scarch
        '
        Me.btn_scarch.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_scarch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_scarch.Location = New System.Drawing.Point(225, 52)
        Me.btn_scarch.Name = "btn_scarch"
        Me.btn_scarch.Size = New System.Drawing.Size(60, 25)
        Me.btn_scarch.TabIndex = 54
        Me.btn_scarch.Text = "ค้นหา"
        Me.btn_scarch.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_searchcus)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.btn_scarch)
        Me.GroupBox3.Controls.Add(Me.txt_customercombo)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txt_sonumber)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(616, 100)
        Me.GroupBox3.TabIndex = 58
        Me.GroupBox3.TabStop = False
        '
        'frm_Selldeil
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1050, 699)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Selldeil"
        Me.Text = "frm_Selldeil"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.DataGridView_showcus1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView_showcus1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_shopname As System.Windows.Forms.TextBox
    Friend WithEvents txt_customeraddress As System.Windows.Forms.TextBox
    Friend WithEvents txt_customerphone As System.Windows.Forms.TextBox
    Friend WithEvents lbl_orderid As System.Windows.Forms.Label
    Friend WithEvents lbl_customername As System.Windows.Forms.Label
    Friend WithEvents txt_bagtype As System.Windows.Forms.TextBox
    Friend WithEvents txt_customer_name As System.Windows.Forms.TextBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents txt_thickbag As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_bagsize As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_bagtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_bagprice As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_totalprice As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_colourbag As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_noteorder As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbl_crytalorderID As System.Windows.Forms.Label
    Friend WithEvents txt_delete As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_lastname As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_noteorder2 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_savenote As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_upprice3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_upprice2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_upprice1 As System.Windows.Forms.TextBox
    Friend WithEvents SqlabC_AlertBox1 As SQLABC_ModernUI.SQLABC_AlertBox
    Friend WithEvents SqlabC_AlertBox2 As SQLABC_ModernUI.SQLABC_AlertBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_sonumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_customercombo As System.Windows.Forms.ComboBox
    Friend WithEvents btn_scarch As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents radio_cusold As System.Windows.Forms.RadioButton
    Friend WithEvents radio_cusnew As System.Windows.Forms.RadioButton
    Friend WithEvents txt_searchcus As System.Windows.Forms.TextBox
End Class
