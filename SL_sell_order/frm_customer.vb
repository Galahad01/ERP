Imports System.Data.SqlClient

Public Class frm_customer

          Dim cn As New SqlConnection("Data Source=TOMMY;Initial Catalog=TEST;User ID=sa;Password=Norame1808")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim sql As String = ""



    Friend Sub connect()
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
        Catch ex As Exception
            MsgBox("เสียใจด้วยต่อ sql server บ่ติดเด๋อบักหำน้อย ")

        End Try

    End Sub

    Friend Function cmd_executeNoquery()
        connect()
        cmd = New SqlCommand(sql, cn)
        Return cmd.ExecuteNonQuery

    End Function

    Friend Function cmd_executeScalar()
        connect()
        cmd = New SqlCommand(sql, cn)
        Return cmd.ExecuteScalar

    End Function
    Friend Function cmd_execuTodatatable()

        connect()
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "table ")
        Return ds.Tables("table ")

    End Function
    Friend Sub change_column_datagrid(datagrid As DataGridView, header() As String) 'อีก1 ของความสุดยอดเปลี่ยนตัวหัวของคอลั่มในดาต้ากริซ ให้เป็นภาษาไทย แจ้วมากกกกกกก
        Dim datagrid_total As Integer = datagrid.Columns.Count
        For i As Integer = 0 To datagrid_total - 1
            datagrid.Columns(i).HeaderText = header(i)
        Next
    End Sub
    Private Sub change_all_column()
        Dim header() As String = {"ลูกค้า ID", "ชื่อจริง", "นามสกุล", "ชื่อร้าน", "ที่อยู่", "เบอร์ติดต่อ", "ลูกค้าใหม่", "ลูกค้าเก่า", "รูป"}  'ขั้นตอนการเปลี่ยนชื่อเอา function sub จากข้างบนมาใช้ 
        change_column_datagrid(DataGridView_showcus, header)

    End Sub
    Private Sub refresh_datagried()

        sql = "select * from customer_detail "
        DataGridView_showcus.DataSource = cmd_execuTodatatable()
        change_all_column()

    End Sub

    Private Sub frm_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_datagried()
        Me.BackColor = Color.FromArgb(64, 128, 128)

    End Sub

    Private Sub txt_refresh_Click(sender As Object, e As EventArgs) Handles txt_refresh.Click
        refresh_datagried()
        txt_name.Clear()
        txtshop_name.Clear()
        txt_phone.Clear()
        txt_address.Clear()


    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If MsgBox("นายต้องการเพิ่มข้อมูลหรือเปล่าครับ ?") = vbNo Then Return

        sql = "select count(*) from Customer_detail where customer_name='" & txt_name.Text & "'"    ' check ว่ามีชื่อซ้ำกันไหม 
        If cmd_executeScalar() > 0 Then
            MsgBox("ชื่อนี้มีคนเอาไปแล้วเสียใจด้วย")    'ถ้ามีชื่อซ้ำมันก้จะหยุดอยุ่ตรงนี้ไม่ลงไปข้างล่างแล้ว ถ้าไม่มีชื่อซื้ามันก้จะข้ามขั้นตอนนี้ไปเลย 
            txt_name.Clear()
            txt_lastname.Clear()
            txt_address.Clear()
            txt_phone.Clear()
            txtshop_name.Clear()
            txt_name.Select()
            Return

        End If
        If picBild.Image Is Nothing Then
            '   sql = "insert into Customer_detail values('" & txt_name.Text & "','" & txt_lastname.Text & "','" & txtshop_name.Text & "','" & txt_address.Text & "','" & txt_phone.Text & "')"
            sql = " insert into Customer_detail (customer_name,customer_lastname,shop_name,shop_address,customer_contact,customer_newold,customer_old) values (@name,@lastname,@shopname,@shopaddress,@contact,@customer_newold,@customer_old)"
        Else
            sql = " insert into Customer_detail (customer_name,customer_lastname,shop_name,shop_address,customer_contact,map) values (@name,@lastname,@shopname,@shopaddress,@contact,@map)"
        End If
        cmd = New SqlClient.SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@name", txt_name.Text)
        cmd.Parameters.AddWithValue("@lastname", txt_lastname.Text)
        cmd.Parameters.AddWithValue("@shopname", txtshop_name.Text)
        cmd.Parameters.AddWithValue("@shopaddress", txt_address.Text)
        cmd.Parameters.AddWithValue("@contact", txt_phone.Text)
        cmd.Parameters.AddWithValue("@customer_newold", radio_cusnew.Checked)
        cmd.Parameters.AddWithValue("@customer_old", radio_cusold.Checked)

        If Not picBild.Image Is Nothing Then
            Dim mem As New IO.MemoryStream
            picBild.Image.Save(mem, Imaging.ImageFormat.Png)
            Dim pic_for_add() As Byte
            pic_for_add = mem.ToArray()
            cmd.Parameters.AddWithValue("@map", pic_for_add)


        End If

        If cmd.ExecuteNonQuery = 0 Then

            MsgBox("ล้มเหลว")
        Else
            MsgBox("สำเร็จ")
            refresh_datagried()
        End If
        picBild.Image = Nothing
        txt_name.Clear()
        txt_lastname.Clear()
        txt_address.Clear()
        txt_phone.Clear()
        txtshop_name.Clear()
        txt_name.Select()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MsgBox("ยืนยันการลบข้อมูลหรือไม่ ?") = vbNo Then Return

        Dim i As Integer = DataGridView_showcus.CurrentRow.Index
        Dim Customername As String = DataGridView_showcus.Item(0, i).Value
        'sql = "delete from slusers_table where UserName = '" & txtdelete.Text & "'" ของเก่า 

        sql = "delete from Customer_detail where customer_id = '" & Customername & "'"

        If cmd_executeNoquery() = 0 Then
            MsgBox("ลบไม่สำเร็จ")
        Else
            MsgBox("สำเร็จ")
            refresh_datagried() 'คือทำไรเสร้จให้รีเพรส ดาต้าเลย 
        End If
    End Sub

    Private Sub DataGridView_showcus_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_showcus.CellClick
        ' Dim i As Integer = DataGridView_showcus.CurrentRow.Index
        ' lbl_customerID.Text = DataGridView_showcus.Item(0, i).Value
        ' txt_name.Text = DataGridView_showcus.Item(1, i).Value
        ' txt_lastname.Text = DataGridView_showcus.Item(2, i).Value
        ' txtshop_name.Text = DataGridView_showcus.Item(3, i).Value
        ' txt_address.Text = DataGridView_showcus.Item(4, i).Value
        ' txt_phone.Text = DataGridView_showcus.Item(5, i).Value
        '  Dim img() As Byte = DataGridView_showcus.Item(6, i).Value
        '  picBild.Image = Image.FromStream(New IO.MemoryStream(CType(img, Byte())))

        Dim select_row As Integer = DataGridView_showcus.CurrentRow.Index
        Dim customer_id As String = DataGridView_showcus(0, select_row).Value
        sql = "select * from customer_detail where customer_id='" & customer_id & "'"
        Dim data_keep As DataTable = cmd_execuTodatatable()
        lbl_customerID.Text = data_keep.Rows(0)("customer_id")
        txt_name.Text = data_keep.Rows(0)("customer_name")
        txt_lastname.Text = data_keep.Rows(0)("customer_lastname")
        txtshop_name.Text = data_keep.Rows(0)("shop_name")
        txt_address.Text = data_keep.Rows(0)("shop_address")
        txt_phone.Text = data_keep.Rows(0)("customer_contact")
        radio_cusnew.Checked = data_keep.Rows(0)("customer_newold")
        radio_cusold.Checked = data_keep.Rows(0)("customer_old")
        '  Dim img() As Byte = data_keep.Rows(0)("map")
        '  picBild.Image = Image.FromStream(New IO.MemoryStream(CType(img, Byte())))

    End Sub

     Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        '   If MsgBox("นายต้องการแก้ไขข้อมูลหรือเปล่าครับ ?") = vbNo Then Return

        ' If picBild.Image Is Nothing Then
        '    sql = " insert into Customer_detail (customer_name,customer_lastname,shop_name,shop_address,customer_contact) values (@name,@lastname,@shopname,@shopaddress,@contact)"
        '   Else

        '  sql = " insert into Customer_detail (customer_name,customer_lastname,shop_name,shop_address,customer_contact,map) values (@name,@lastname,@shopname,@shopaddress,@contact,@map)"
        '   End If
        '   sql = " update Customer_detail set map= map where customer_name= @name"
        '   cmd = New SqlClient.SqlCommand(sql, cn)
        '   cmd.Parameters.Clear()
        '   cmd.Parameters.AddWithValue("@name", txt_name.Text)
        '   cmd.Parameters.AddWithValue("@lastname", txt_lastname.Text)
        '   cmd.Parameters.AddWithValue("@shopname", txtshop_name.Text)
        '   cmd.Parameters.AddWithValue("@shopaddress", txt_address.Text)
        '   cmd.Parameters.AddWithValue("@contact", txt_phone.Text)

        '   If Not picBild.Image Is Nothing Then
        'Dim mem As New IO.MemoryStream
        '   picBild.Image.Save(mem, Imaging.ImageFormat.Png)
        '   Dim pic_for_add() As Byte
        '   pic_for_add = mem.ToArray()
        ' cmd.Parameters.AddWithValue("map", pic_for_add)


        ' End If

        '  If cmd.ExecuteNonQuery = 0 Then

        'MsgBox("ล้มเหลว")
        '   Else
        '   MsgBox("สำเร็จ")
        '   refresh_datagried()
        '   End If
        '  picBild.Image = Nothing
        '   txt_name.Clear()
        '   txt_lastname.Clear()
        '  txt_address.Clear()
        '  txt_phone.Clear()
        '  txtshop_name.Clear()
        '  txt_name.Select()

        Dim cusnum As String
        cusnum = Me.lbl_customerID.Text
        If cn.State = ConnectionState.Closed Then cn.Open()
        cmd = New SqlCommand()
        cmd.CommandText = "update Customer_detail set Customer_name= '" & txt_name.Text & "',customer_lastname= '" & txt_lastname.Text & "',shop_name= '" & txtshop_name.Text & "',shop_address = '" & txt_address.Text & "',customer_contact = '" & txt_phone.Text & "',customer_newold = '" & radio_cusnew.Checked & "',customer_old = '" & radio_cusold.Checked & "' where customer_id = '" & cusnum & "'"
        cmd.Connection = cn
        cmd.ExecuteNonQuery()
        MsgBox("เปลี่ยนข้อมูลสำเร้จ")
        refresh_datagried()



    End Sub

    Private Sub cmdLoad_Click(sender As Object, e As EventArgs) Handles cmdLoad.Click
        Dim antw As DialogResult

        antw = OpenFileDialog1.ShowDialog

        If antw = Windows.Forms.DialogResult.OK Then
            For Each element As String In OpenFileDialog1.FileNames
                cbDateien.Items.Add(element)
            Next
            cbDateien.SelectedIndex = 0
        End If

        ' If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        'Dim img As Image
        ' img = Image.FromFile(OpenFileDialog1.FileName)
        ' picBild.Image = img

        ' End If
    End Sub

    Private Sub cbDateien_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDateien.SelectedIndexChanged
        picBild.Image = Image.FromFile(cbDateien.Items(cbDateien.SelectedIndex))

    End Sub

    Private Sub rdOriginal_CheckedChanged(sender As Object, e As EventArgs) Handles rdOriginal.CheckedChanged
        If rdProgramm.Checked = True Then
            picBild.SizeMode = PictureBoxSizeMode.Zoom
        ElseIf rdOriginal.Checked = True Then
            picBild.SizeMode = PictureBoxSizeMode.AutoSize
        End If
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        sql = "select customer_id, customer_name ,customer_lastname,shop_name,shop_address,customer_contact, map from customer_detail where customer_id like '%" & txt_search.Text & "%' or customer_name like '%" & txt_search.Text & "%'"
        DataGridView_showcus.DataSource = cmd_execuTodatatable()

    End Sub

    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        If cbDateien.SelectedIndex <> 0 And cbDateien.SelectedIndex <> -1 Then
            cbDateien.SelectedIndex -= 1
        End If
    End Sub
    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        If cbDateien.SelectedIndex <> cbDateien.Items.Count - 1 And cbDateien.SelectedIndex <> -1 Then
            cbDateien.SelectedIndex += 1
        End If
    End Sub


   
End Class