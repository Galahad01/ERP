<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_search
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_search))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_timeofday = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Pnlmain = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panal_records = New System.Windows.Forms.Panel()
        Me.btn_stock = New System.Windows.Forms.Button()
        Me.btnCalculator = New System.Windows.Forms.Button()
        Me.btn_openmainmenu = New System.Windows.Forms.Button()
        Me.btn_orderfrm = New System.Windows.Forms.Button()
        Me.btnNotepad = New System.Windows.Forms.Button()
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.txt_po = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel_tool = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_staff = New System.Windows.Forms.Button()
        Me.btn_openlogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_staffID = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.lbl_contactlogin = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.lbl_login_name = New System.Windows.Forms.ToolStripTextBox()
        Me.tootip = New System.Windows.Forms.ToolStripTextBox()
        Me.lbl_logintime = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox()
        Me.Pnlmain.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panal_records.SuspendLayout()
        Me.Panel_tool.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_timeofday
        '
        Me.lbl_timeofday.AutoSize = True
        Me.lbl_timeofday.BackColor = System.Drawing.Color.Transparent
        Me.lbl_timeofday.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_timeofday.Location = New System.Drawing.Point(37, 674)
        Me.lbl_timeofday.Name = "lbl_timeofday"
        Me.lbl_timeofday.Size = New System.Drawing.Size(62, 18)
        Me.lbl_timeofday.TabIndex = 13
        Me.lbl_timeofday.Text = "Label4"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Pnlmain
        '
        Me.Pnlmain.AutoSize = True
        Me.Pnlmain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Pnlmain.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Pnlmain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Pnlmain.Controls.Add(Me.Label3)
        Me.Pnlmain.Controls.Add(Me.PictureBox1)
        Me.Pnlmain.Location = New System.Drawing.Point(163, 30)
        Me.Pnlmain.Name = "Pnlmain"
        Me.Pnlmain.Size = New System.Drawing.Size(892, 689)
        Me.Pnlmain.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(784, 673)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Power by@ Galahad"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Galahadone.My.Resources.Resources.Logo___SL
        Me.PictureBox1.Location = New System.Drawing.Point(749, 593)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 93)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panal_records
        '
        Me.Panal_records.BackColor = System.Drawing.Color.Transparent
        Me.Panal_records.BackgroundImage = Global.Galahadone.My.Resources.Resources.passwords_back
        Me.Panal_records.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panal_records.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panal_records.Controls.Add(Me.btn_stock)
        Me.Panal_records.Controls.Add(Me.btnCalculator)
        Me.Panal_records.Controls.Add(Me.btn_openmainmenu)
        Me.Panal_records.Controls.Add(Me.btn_orderfrm)
        Me.Panal_records.Controls.Add(Me.btnNotepad)
        Me.Panal_records.Controls.Add(Me.btn_customer)
        Me.Panal_records.Controls.Add(Me.txt_po)
        Me.Panal_records.Controls.Add(Me.Label2)
        Me.Panal_records.Location = New System.Drawing.Point(12, 30)
        Me.Panal_records.Name = "Panal_records"
        Me.Panal_records.Size = New System.Drawing.Size(140, 374)
        Me.Panal_records.TabIndex = 9
        '
        'btn_stock
        '
        Me.btn_stock.FlatAppearance.BorderSize = 0
        Me.btn_stock.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_stock.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stock.Image = Global.Galahadone.My.Resources.Resources.MsoverBtn
        Me.btn_stock.Location = New System.Drawing.Point(19, 176)
        Me.btn_stock.Name = "btn_stock"
        Me.btn_stock.Size = New System.Drawing.Size(104, 29)
        Me.btn_stock.TabIndex = 12
        Me.btn_stock.Text = "เพิ่มสินค้า"
        Me.btn_stock.UseVisualStyleBackColor = True
        '
        'btnCalculator
        '
        Me.btnCalculator.FlatAppearance.BorderSize = 0
        Me.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCalculator.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculator.Image = Global.Galahadone.My.Resources.Resources.MsoverBtn
        Me.btnCalculator.Location = New System.Drawing.Point(19, 314)
        Me.btnCalculator.Name = "btnCalculator"
        Me.btnCalculator.Size = New System.Drawing.Size(104, 29)
        Me.btnCalculator.TabIndex = 9
        Me.btnCalculator.Text = "เครื่องคิดเลข"
        '
        'btn_openmainmenu
        '
        Me.btn_openmainmenu.FlatAppearance.BorderSize = 0
        Me.btn_openmainmenu.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_openmainmenu.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_openmainmenu.Image = Global.Galahadone.My.Resources.Resources.MsoverBtn
        Me.btn_openmainmenu.Location = New System.Drawing.Point(19, 268)
        Me.btn_openmainmenu.Name = "btn_openmainmenu"
        Me.btn_openmainmenu.Size = New System.Drawing.Size(104, 29)
        Me.btn_openmainmenu.TabIndex = 11
        Me.btn_openmainmenu.Text = "ย่อ"
        '
        'btn_orderfrm
        '
        Me.btn_orderfrm.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_orderfrm.FlatAppearance.BorderSize = 0
        Me.btn_orderfrm.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_orderfrm.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_orderfrm.Image = Global.Galahadone.My.Resources.Resources.MsoverBtn
        Me.btn_orderfrm.Location = New System.Drawing.Point(19, 87)
        Me.btn_orderfrm.Name = "btn_orderfrm"
        Me.btn_orderfrm.Size = New System.Drawing.Size(104, 29)
        Me.btn_orderfrm.TabIndex = 7
        Me.btn_orderfrm.Text = "ค้นหา"
        '
        'btnNotepad
        '
        Me.btnNotepad.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnNotepad.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotepad.Image = Global.Galahadone.My.Resources.Resources.MsoverBtn
        Me.btnNotepad.Location = New System.Drawing.Point(19, 222)
        Me.btnNotepad.Name = "btnNotepad"
        Me.btnNotepad.Size = New System.Drawing.Size(104, 29)
        Me.btnNotepad.TabIndex = 10
        Me.btnNotepad.Text = "เตือนความจำ"
        '
        'btn_customer
        '
        Me.btn_customer.FlatAppearance.BorderSize = 0
        Me.btn_customer.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_customer.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customer.Image = Global.Galahadone.My.Resources.Resources.MsoverBtn
        Me.btn_customer.Location = New System.Drawing.Point(19, 131)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(104, 29)
        Me.btn_customer.TabIndex = 8
        Me.btn_customer.Text = "รายชื่อลูกค้า "
        Me.btn_customer.UseVisualStyleBackColor = True
        '
        'txt_po
        '
        Me.txt_po.Cursor = System.Windows.Forms.Cursors.Default
        Me.txt_po.FlatAppearance.BorderSize = 0
        Me.txt_po.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_po.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.txt_po.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_po.Image = Global.Galahadone.My.Resources.Resources.MsoverBtn
        Me.txt_po.Location = New System.Drawing.Point(19, 43)
        Me.txt_po.Name = "txt_po"
        Me.txt_po.Size = New System.Drawing.Size(104, 29)
        Me.txt_po.TabIndex = 6
        Me.txt_po.Text = "ใบเสนอราคา"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label2.Location = New System.Drawing.Point(7, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 32)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Records"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_tool
        '
        Me.Panel_tool.BackColor = System.Drawing.Color.Transparent
        Me.Panel_tool.BackgroundImage = Global.Galahadone.My.Resources.Resources.passwords_back
        Me.Panel_tool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_tool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_tool.Controls.Add(Me.Button2)
        Me.Panel_tool.Controls.Add(Me.btn_staff)
        Me.Panel_tool.Controls.Add(Me.btn_openlogin)
        Me.Panel_tool.Controls.Add(Me.Label1)
        Me.Panel_tool.Location = New System.Drawing.Point(10, 426)
        Me.Panel_tool.Name = "Panel_tool"
        Me.Panel_tool.Size = New System.Drawing.Size(140, 227)
        Me.Panel_tool.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Galahadone.My.Resources.Resources.MsoverBtn
        Me.Button2.Location = New System.Drawing.Point(19, 155)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 29)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "อิปโปวิ่ง"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn_staff
        '
        Me.btn_staff.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_staff.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_staff.Image = Global.Galahadone.My.Resources.Resources.MsoverBtn
        Me.btn_staff.Location = New System.Drawing.Point(19, 58)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Size = New System.Drawing.Size(104, 29)
        Me.btn_staff.TabIndex = 9
        Me.btn_staff.Text = "พนักงาน"
        Me.btn_staff.UseVisualStyleBackColor = True
        '
        'btn_openlogin
        '
        Me.btn_openlogin.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_openlogin.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_openlogin.Image = Global.Galahadone.My.Resources.Resources.MsoverBtn
        Me.btn_openlogin.Location = New System.Drawing.Point(19, 108)
        Me.btn_openlogin.Name = "btn_openlogin"
        Me.btn_openlogin.Size = New System.Drawing.Size(104, 29)
        Me.btn_openlogin.TabIndex = 12
        Me.btn_openlogin.Text = "หน้า Log in"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Salmon
        Me.Label1.Location = New System.Drawing.Point(24, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tools"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolToolStripMenuItem, Me.EditToolStripMenuItem, Me.lbl_staffID, Me.ToolStripTextBox1, Me.lbl_contactlogin, Me.ToolStripTextBox2, Me.lbl_login_name, Me.tootip, Me.lbl_logintime, Me.ToolStripTextBox3})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1058, 27)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(41, 23)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(125, 24)
        Me.LogOutToolStripMenuItem.Text = "LogOut"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(125, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolToolStripMenuItem
        '
        Me.ToolToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ToolToolStripMenuItem.Name = "ToolToolStripMenuItem"
        Me.ToolToolStripMenuItem.Size = New System.Drawing.Size(47, 23)
        Me.ToolToolStripMenuItem.Text = "Tool"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.toolStripSeparator3, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.toolStripSeparator4, Me.SelectAllToolStripMenuItem})
        Me.EditToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(44, 23)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(161, 24)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(161, 24)
        Me.RedoToolStripMenuItem.Text = "&Redo"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(158, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(161, 24)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(161, 24)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(161, 24)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(158, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(161, 24)
        Me.SelectAllToolStripMenuItem.Text = "Select &All"
        '
        'lbl_staffID
        '
        Me.lbl_staffID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lbl_staffID.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.lbl_staffID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_staffID.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffID.ForeColor = System.Drawing.Color.White
        Me.lbl_staffID.Name = "lbl_staffID"
        Me.lbl_staffID.ReadOnly = True
        Me.lbl_staffID.Size = New System.Drawing.Size(20, 23)
        Me.lbl_staffID.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.ToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox1.ForeColor = System.Drawing.Color.White
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.ReadOnly = True
        Me.ToolStripTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripTextBox1.ShortcutsEnabled = False
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(15, 20)
        Me.ToolStripTextBox1.Text = "ID:"
        Me.ToolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_contactlogin
        '
        Me.lbl_contactlogin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lbl_contactlogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.lbl_contactlogin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_contactlogin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contactlogin.ForeColor = System.Drawing.Color.White
        Me.lbl_contactlogin.Name = "lbl_contactlogin"
        Me.lbl_contactlogin.ReadOnly = True
        Me.lbl_contactlogin.Size = New System.Drawing.Size(70, 23)
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripTextBox2.AutoSize = False
        Me.ToolStripTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.ToolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ToolStripTextBox2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox2.ForeColor = System.Drawing.Color.White
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.ReadOnly = True
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(110, 20)
        Me.ToolStripTextBox2.Text = "เบอร์ติดต่อผู้ใช้ :"
        Me.ToolStripTextBox2.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_login_name
        '
        Me.lbl_login_name.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lbl_login_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.lbl_login_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_login_name.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_login_name.ForeColor = System.Drawing.Color.White
        Me.lbl_login_name.Name = "lbl_login_name"
        Me.lbl_login_name.ReadOnly = True
        Me.lbl_login_name.Size = New System.Drawing.Size(100, 23)
        Me.lbl_login_name.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tootip
        '
        Me.tootip.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tootip.AutoSize = False
        Me.tootip.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.tootip.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tootip.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tootip.ForeColor = System.Drawing.Color.White
        Me.tootip.Name = "tootip"
        Me.tootip.ReadOnly = True
        Me.tootip.Size = New System.Drawing.Size(110, 20)
        Me.tootip.Text = "ชื่อผู้ใช้งานตอนนี้ :"
        Me.tootip.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_logintime
        '
        Me.lbl_logintime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lbl_logintime.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.lbl_logintime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_logintime.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_logintime.ForeColor = System.Drawing.Color.White
        Me.lbl_logintime.Name = "lbl_logintime"
        Me.lbl_logintime.ReadOnly = True
        Me.lbl_logintime.Size = New System.Drawing.Size(130, 23)
        '
        'ToolStripTextBox3
        '
        Me.ToolStripTextBox3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripTextBox3.AutoSize = False
        Me.ToolStripTextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.ToolStripTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ToolStripTextBox3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox3.ForeColor = System.Drawing.Color.White
        Me.ToolStripTextBox3.Name = "ToolStripTextBox3"
        Me.ToolStripTextBox3.ReadOnly = True
        Me.ToolStripTextBox3.Size = New System.Drawing.Size(70, 20)
        Me.ToolStripTextBox3.Text = "เวลา login :"
        '
        'frm_search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1058, 720)
        Me.Controls.Add(Me.lbl_timeofday)
        Me.Controls.Add(Me.Panal_records)
        Me.Controls.Add(Me.Panel_tool)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Pnlmain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frm_search"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Pnlmain.ResumeLayout(False)
        Me.Pnlmain.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panal_records.ResumeLayout(False)
        Me.Panel_tool.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel_tool As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnNotepad As System.Windows.Forms.Button
    Friend WithEvents btnCalculator As System.Windows.Forms.Button
    Friend WithEvents Panal_records As System.Windows.Forms.Panel
    Friend WithEvents btn_orderfrm As System.Windows.Forms.Button
    Friend WithEvents txt_po As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_openlogin As System.Windows.Forms.Button
    Friend WithEvents btn_openmainmenu As System.Windows.Forms.Button
    Friend WithEvents Pnlmain As System.Windows.Forms.Panel
    Friend WithEvents btn_customer As System.Windows.Forms.Button
    Friend WithEvents lbl_timeofday As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents btn_staff As System.Windows.Forms.Button
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tootip As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents lbl_login_name As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents lbl_staffID As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents lbl_contactlogin As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripTextBox3 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents lbl_logintime As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_stock As System.Windows.Forms.Button
End Class
