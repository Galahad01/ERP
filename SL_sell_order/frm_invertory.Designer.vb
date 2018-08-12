<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_invertory
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
        Me.txt_bagid = New SQLABC_ModernUI.SQLABC_Theme()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_bagprice = New System.Windows.Forms.TextBox()
        Me.txt_thickbag = New System.Windows.Forms.TextBox()
        Me.txt_bagsize = New System.Windows.Forms.TextBox()
        Me.txt_bagtype = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_search = New SQLABC_ModernUI.SQLABC_ButtonB()
        Me.lbl_bagid = New SQLABC_ModernUI.SQLABC_Label()
        Me.SqlabC_Label1 = New SQLABC_ModernUI.SQLABC_Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_del = New SQLABC_ModernUI.SQLABC_ButtonB()
        Me.btn_edit = New SQLABC_ModernUI.SQLABC_ButtonB()
        Me.btn_add = New SQLABC_ModernUI.SQLABC_ButtonB()
        Me.DataGridView_invertory = New System.Windows.Forms.DataGridView()
        Me.txt_search = New SQLABC_ModernUI.SQLABC_TextBox()
        Me.txt_bagid.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView_invertory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_bagid
        '
        Me.txt_bagid.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txt_bagid.Controls.Add(Me.PictureBox1)
        Me.txt_bagid.Controls.Add(Me.GroupBox1)
        Me.txt_bagid.Controls.Add(Me.btn_search)
        Me.txt_bagid.Controls.Add(Me.lbl_bagid)
        Me.txt_bagid.Controls.Add(Me.SqlabC_Label1)
        Me.txt_bagid.Controls.Add(Me.GroupBox2)
        Me.txt_bagid.Controls.Add(Me.DataGridView_invertory)
        Me.txt_bagid.Controls.Add(Me.txt_search)
        Me.txt_bagid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_bagid.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bagid.Location = New System.Drawing.Point(0, 0)
        Me.txt_bagid.Name = "txt_bagid"
        Me.txt_bagid.Size = New System.Drawing.Size(1050, 699)
        Me.txt_bagid.TabIndex = 0
        Me.txt_bagid.Text = "INVENTORY"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Galahadone.My.Resources.Resources.Logo___SL
        Me.PictureBox1.Location = New System.Drawing.Point(513, 508)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_bagprice)
        Me.GroupBox1.Controls.Add(Me.txt_thickbag)
        Me.GroupBox1.Controls.Add(Me.txt_bagsize)
        Me.GroupBox1.Controls.Add(Me.txt_bagtype)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(662, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 361)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'txt_bagprice
        '
        Me.txt_bagprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bagprice.Location = New System.Drawing.Point(129, 241)
        Me.txt_bagprice.Name = "txt_bagprice"
        Me.txt_bagprice.Size = New System.Drawing.Size(210, 26)
        Me.txt_bagprice.TabIndex = 56
        Me.txt_bagprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_thickbag
        '
        Me.txt_thickbag.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_thickbag.Location = New System.Drawing.Point(129, 171)
        Me.txt_thickbag.Name = "txt_thickbag"
        Me.txt_thickbag.Size = New System.Drawing.Size(210, 26)
        Me.txt_thickbag.TabIndex = 55
        Me.txt_thickbag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_bagsize
        '
        Me.txt_bagsize.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bagsize.Location = New System.Drawing.Point(129, 114)
        Me.txt_bagsize.Name = "txt_bagsize"
        Me.txt_bagsize.Size = New System.Drawing.Size(210, 26)
        Me.txt_bagsize.TabIndex = 54
        Me.txt_bagsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_bagtype
        '
        Me.txt_bagtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bagtype.Location = New System.Drawing.Point(129, 50)
        Me.txt_bagtype.Name = "txt_bagtype"
        Me.txt_bagtype.Size = New System.Drawing.Size(210, 26)
        Me.txt_bagtype.TabIndex = 53
        Me.txt_bagtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(51, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 21)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "ราคาถุง"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(39, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 21)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "ความหนา"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(69, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 21)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Size"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(54, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 21)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "ชนิดถุง"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_search
        '
        Me.btn_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_search.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.btn_search.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_search.GlowColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_search.Image = Nothing
        Me.btn_search.Location = New System.Drawing.Point(485, 126)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(79, 28)
        Me.btn_search.TabIndex = 8
        Me.btn_search.Text = "ค้นหา"
        '
        'lbl_bagid
        '
        Me.lbl_bagid.AutoSize = True
        Me.lbl_bagid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_bagid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bagid.ForeColor = System.Drawing.Color.White
        Me.lbl_bagid.Location = New System.Drawing.Point(708, 80)
        Me.lbl_bagid.Name = "lbl_bagid"
        Me.lbl_bagid.Size = New System.Drawing.Size(0, 18)
        Me.lbl_bagid.TabIndex = 7
        Me.lbl_bagid.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SqlabC_Label1
        '
        Me.SqlabC_Label1.AutoSize = True
        Me.SqlabC_Label1.BackColor = System.Drawing.Color.Transparent
        Me.SqlabC_Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SqlabC_Label1.ForeColor = System.Drawing.Color.White
        Me.SqlabC_Label1.Location = New System.Drawing.Point(656, 80)
        Me.SqlabC_Label1.Name = "SqlabC_Label1"
        Me.SqlabC_Label1.Size = New System.Drawing.Size(40, 18)
        Me.SqlabC_Label1.TabIndex = 4
        Me.SqlabC_Label1.Text = "ID ถุง"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_del)
        Me.GroupBox2.Controls.Add(Me.btn_edit)
        Me.GroupBox2.Controls.Add(Me.btn_add)
        Me.GroupBox2.Location = New System.Drawing.Point(662, 497)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(345, 135)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'btn_del
        '
        Me.btn_del.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_del.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.btn_del.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_del.GlowColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_del.Image = Nothing
        Me.btn_del.Location = New System.Drawing.Point(100, 80)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(147, 28)
        Me.btn_del.TabIndex = 9
        Me.btn_del.Text = "ลบ"
        '
        'btn_edit
        '
        Me.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.btn_edit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_edit.GlowColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_edit.Image = Nothing
        Me.btn_edit.Location = New System.Drawing.Point(183, 25)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(147, 28)
        Me.btn_edit.TabIndex = 8
        Me.btn_edit.Text = "แก้ไข"
        '
        'btn_add
        '
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.btn_add.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_add.GlowColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_add.Image = Nothing
        Me.btn_add.Location = New System.Drawing.Point(16, 25)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(147, 28)
        Me.btn_add.TabIndex = 7
        Me.btn_add.Text = "เพิ่ม"
        '
        'DataGridView_invertory
        '
        Me.DataGridView_invertory.AllowUserToAddRows = False
        Me.DataGridView_invertory.AllowUserToDeleteRows = False
        Me.DataGridView_invertory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_invertory.Location = New System.Drawing.Point(55, 198)
        Me.DataGridView_invertory.Name = "DataGridView_invertory"
        Me.DataGridView_invertory.ReadOnly = True
        Me.DataGridView_invertory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_invertory.Size = New System.Drawing.Size(558, 263)
        Me.DataGridView_invertory.TabIndex = 1
        '
        'txt_search
        '
        Me.txt_search.BackColor = System.Drawing.Color.Transparent
        Me.txt_search.Location = New System.Drawing.Point(110, 126)
        Me.txt_search.MaxLength = 32767
        Me.txt_search.Multiline = False
        Me.txt_search.Name = "txt_search"
        Me.txt_search.ReadOnly = False
        Me.txt_search.Size = New System.Drawing.Size(354, 29)
        Me.txt_search.TabIndex = 0
        Me.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_search.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_search.UseSystemPasswordChar = False
        '
        'frm_invertory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 699)
        Me.Controls.Add(Me.txt_bagid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_invertory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "invertory"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.txt_bagid.ResumeLayout(False)
        Me.txt_bagid.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView_invertory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_bagid As SQLABC_ModernUI.SQLABC_Theme
    Friend WithEvents txt_search As SQLABC_ModernUI.SQLABC_TextBox
    Friend WithEvents DataGridView_invertory As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SqlabC_Label1 As SQLABC_ModernUI.SQLABC_Label
    Friend WithEvents lbl_bagid As SQLABC_ModernUI.SQLABC_Label
    Friend WithEvents btn_del As SQLABC_ModernUI.SQLABC_ButtonB
    Friend WithEvents btn_edit As SQLABC_ModernUI.SQLABC_ButtonB
    Friend WithEvents btn_add As SQLABC_ModernUI.SQLABC_ButtonB
    Friend WithEvents btn_search As SQLABC_ModernUI.SQLABC_ButtonB
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_bagprice As System.Windows.Forms.TextBox
    Friend WithEvents txt_thickbag As System.Windows.Forms.TextBox
    Friend WithEvents txt_bagsize As System.Windows.Forms.TextBox
    Friend WithEvents txt_bagtype As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
