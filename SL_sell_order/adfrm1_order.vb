Imports System.Data.SqlClient


Public Class adfrm1_order

          Dim cn As New SqlConnection("Data Source=TOMMY;Initial Catalog=TEST;User ID=sa;Password=Norame1808")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim Parmas As New List(Of SqlParameter)
    Dim dr As SqlDataReader
    Dim sql As String = ""
    Dim recount As Integer
   
    Friend Sub connect()
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Friend Sub cmd_database_to_object(obj As Object)
        connect()
        cmd = New SqlCommand(sql, cn)
        dr = cmd.ExecuteReader
        obj.Items.clear()
        While dr.Read
            obj.Items.add(dr(0))
        End While
        dr.Close()

    End Sub
    Friend Sub execquary(query As String)
        Try
            connect()
            cmd = New SqlCommand(query, cn)
            Parmas.ForEach(Sub(x) cmd.Parameters.Add(x))
            Parmas.Clear()

            ds = New DataSet
            da = New SqlDataAdapter(cmd)
            recount = da.Fill(ds)

        Catch ex As Exception
            MsgBox("wrong")

        End Try
    End Sub
    Private Sub txt_total()

        txt_sum.Text = Sum_Column_Currency(ListView1, 7)

    End Sub

    Friend Function Sum_Column_Currency(ByVal listview_name As ListView, ByVal Index_column As Integer)
        Dim result As Double = 0
        Dim i As Integer = listview_name.Items.Count - 1
        For j As Integer = 0 To i
            result += CType(listview_name.Items(j).SubItems(Index_column).Text, Double)
        Next
        Return FormatNumber(result)
    End Function

    Friend Function cmd_executeNonquery()
        connect()
        cmd = New SqlCommand(sql, cn)
        Return cmd.ExecuteNonQuery
    End Function

    Friend Function cmd_executeScalar()
        connect()
        cmd = New SqlCommand(sql, cn)
        Return cmd.ExecuteScalar
    End Function

    Friend Function cmd_executeToDataTable()        '1.1 หาเครื่องมือมาทำให้มันแสดงผล
        connect()
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "table")
        Return ds.Tables("table")
    End Function

    Friend Sub change_column_datagrid(datagrid As DataGridView, header() As String) 'อีก1 ของความสุดยอดเปลี่ยนตัวหัวของคอลั่มในดาต้ากริซ ให้เป็นภาษาไทย แจ้วมากกกกกกก
        Dim datagrid_total As Integer = datagrid.Columns.Count
        For i As Integer = 0 To datagrid_total - 1
            datagrid.Columns(i).HeaderText = header(i)
        Next
    End Sub
    Private Sub change_all_column()
        Dim header() As String = {"ถุง ID", "วัตถุดิบ", "ขนาด", "หนา", "ราคา"}  'ขั้นตอนการเปลี่ยนชื่อเอา function sub จากข้างบนมาใช้ 
        change_column_datagrid(DataGridView_show, header)
       
    End Sub
    Private Sub refresh_data_table()                          '1.2 assing ค่ามันลงไป
        sql = "select * from bag_tb "
        DataGridView_show.DataSource = cmd_executeToDataTable()
        change_all_column()
    End Sub
    ' Private Sub refresh_everything()
    'Dim f3 As New adfrm1_order

    '      Me.Dispose()

    '     With frm_search
    '        frm_search.Pnlmain.Controls.Clear()
    '   Dim frm_Selldeil As New adfrm1_order()
    ' frm_Selldeil.Size = Pnlmain.Size
    '      frm_Selldeil.TopLevel = False
    '       frm_Selldeil.Parent = frm_search.Pnlmain
    '     frm_Selldeil.Show()
    '    End With
    '   End Sub

    Private Sub adfrm1_order_Load(sender As Object, e As EventArgs) Handles MyBase.Load, txt_sdnumber.Click
        get_autonumbercystal()
        txt_newnote.Select()
        refresh_data_table() '1.3 เอามันมาใช้
        get_autonumber()
        get_customer_name()



        ListView1.FullRowSelect = True

        Timer1.Stop()

        Panel1.BackColor = Color.Black
        lbl3.BackColor = Color.Black
        lbl3.ForeColor = Color.Red
        lbl3.Left = Panel1.Right

        Timer1.Interval = 1
        Timer1.Start()


    End Sub

    Private Sub get_autonumber()   '2.1
        sql = "select max(order_id) from advorder_tb"
        Try ' ถ้าไม่มีเลขไรเลยจะเกิด error
            txt_sdnumber.Text = "8" & (Date.Now.Date).ToString("yy") & (cmd_executeScalar() + 1).ToString.PadLeft(5, "0") & "/" & Date.Now.Month
        Catch ex As Exception
            txt_sdnumber.Text = "8" & (Date.Now.Date).ToString("yy") & "/00001"
        End Try

    End Sub
    Private Sub get_autonumbercystal()

        sql = "select max(crytalorder_id) from crytalorder"

        txt_cryorder.Text = cmd_executeScalar() + 1

    End Sub
    Private Sub get_customer_name()

        sql = "select customer_name from customer_detail"
        cmd_database_to_object(txt_combo_name)

    End Sub

    Private Sub AddParam(name As String, value As Object)  'อันนีเอาใว้เวลาใข้คำสั้ง 

        Dim newParam As New SqlParameter(name, value)
        Parmas.Add(newParam)

    End Sub

    Private Sub getcustomerphonenumber(phone As String)
        'add a serch parameter
        AddParam("@phone", phone)

        'run qurey
        execquary("select customer_contact from Customer_detail where customer_name = @phone")

        'if customer_name so send phonenumber to our textbox
        If recount > 0 Then txt_phone.Text = ds.Tables(0).Rows(0).Item("customer_contact")

    End Sub
    Private Sub radiocusnew(radionew As String)

        AddParam("@radionew", radionew)

        execquary("select customer_newold from Customer_detail where customer_name = @radionew")

        If recount > 0 Then SqlabC_RadioButton1.Checked = ds.Tables(0).Rows(0).Item("customer_newold")


    End Sub
    Private Sub radiocusold(radioold As String)

        AddParam("@radioold", radioold)

        execquary("select customer_old from Customer_detail where customer_name = @radioold")

        If recount > 0 Then SqlabC_RadioButton2.Checked = ds.Tables(0).Rows(0).Item("customer_old")


    End Sub

    Private Sub getcustomershopname(shop As String)
        AddParam("@shop", shop)

        execquary("select shop_name from Customer_detail where customer_name = @shop")

        If recount > 0 Then txt_shopname.Text = ds.Tables(0).Rows(0).Item("shop_name")

    End Sub
    Private Sub getcustomeraddress(address As String)
        AddParam("@address", address)

        execquary("select shop_address from Customer_detail where customer_name = @address")

        If recount > 0 Then txt_address.Text = ds.Tables(0).Rows(0).Item("shop_address")

    End Sub
    Private Sub getcustomerid(customer_id As String)
        AddParam("@customer_id", customer_id)

        execquary("select customer_id from Customer_detail where customer_name = @customer_id")

        If recount > 0 Then txt_cusid.Text = ds.Tables(0).Rows(0).Item("customer_id")

    End Sub
    Private Sub getcustomercomboname(customer_name As String)

        AddParam("@customer_name", customer_name)

        execquary("select customer_name from Customer_detail where customer_name = @customer_name")

        If recount > 0 Then txt_combo_name.Text = ds.Tables(0).Rows(0).Item("customer_name")

    End Sub

    Private Sub txt_combo_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_combo_name.SelectedIndexChanged

        getcustomerphonenumber(txt_combo_name.Text)
        getcustomershopname(txt_combo_name.Text)
        getcustomeraddress(txt_combo_name.Text)
        getcustomerid(txt_combo_name.Text)
        radiocusnew(txt_combo_name.Text)
        radiocusold(txt_combo_name.Text)
        txt_searchcus.Text = txt_combo_name.Text


    End Sub
    Private Sub txt_combo_name_TextChanged(sender As Object, e As EventArgs) Handles txt_combo_name.TextChanged

        getcustomerphonenumber(txt_combo_name.Text)
        getcustomershopname(txt_combo_name.Text)
        getcustomeraddress(txt_combo_name.Text)
        getcustomerid(txt_combo_name.Text)
        radiocusnew(txt_combo_name.Text)
        radiocusold(txt_combo_name.Text)
        txt_searchcus.Text = txt_combo_name.Text

    End Sub

    Private Sub txt_searchcus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_searchcus.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 13 Then
            MessageBox.Show("ทายสิใครเอ๋ย")
        Else
            e.Handled = True
        End If
    End Sub
     
    Private Sub txt_searchcus_TextChanged(sender As Object, e As EventArgs) Handles txt_searchcus.TextChanged
        ' txt_searchcus.Text = txt_combo_name.Text
        ' sql = "select customer_id ,customer_name ,customer_lastname,shop_name,shop_address,customer_contact from Customer_detail where customer_id like '%" & txt_searchcus.Text & "%' or customer_name like '%" & txt_searchcus.Text & "%' or customer_contact like '%" & txt_searchcus.Text & "%' "
        ' txt_searchcus.Text = cmd_executeToDataTable()
        ' getcustomerphonenumber(txt_searchcus.Text)
        ' getcustomershopname(txt_searchcus.Text)
        ' getcustomeraddress(txt_searchcus.Text)
        'radiocusnew(txt_searchcus.Text)
        ' radiocusold(txt_searchcus.Text)

    End Sub
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_bag_amount.Text = "" Or Not IsNumeric(txt_bag_amount.Text) Then

            MsgBox("เอ้ยๆๆ กรองข้อมูลหน่อยดิและก็กรองแต่ตัวเลขนะไม่งันไม่ทำงาน ")
            Return
        End If

        Dim arr(7) As String
        Dim i As Integer = DataGridView_show.CurrentRow.Index
        Dim bagid As Integer = DataGridView_show.Item(0, i).Value
        Dim bagtype As String = DataGridView_show.Item(1, i).Value
        Dim bagsize As String = DataGridView_show.Item(2, i).Value
        Dim bagthick As Integer = DataGridView_show.Item(3, i).Value ' ตรงนี้สำคัญอย่าลีมมันคือ integer  ไม่งัน ยอดรวมไม่ออก         
        Dim bagprice As Integer = DataGridView_show.Item(4, i).Value
        ' Dim numchar_id As String = "8" & (Date.Now.Date).ToString("yy") & (cmd_excuteScalar() + 1).ToString.PadLeft(5, "0") & "/" & Date.Now.Month



        arr(0) = bagtype
        arr(1) = txt_sdnumber.Text
        arr(2) = bagthick
        arr(3) = txt_print.Text
        arr(4) = bagsize
        arr(5) = txt_bag_amount.Text
        arr(6) = bagprice
        arr(7) = arr(5) * arr(6)


        txt_sdnumber.Text = Val(txt_sdnumber.Text) + (1) & "/" & Date.Now.Month

        Dim itm As New ListViewItem(arr)

        ListView1.Items.Add(itm)


        Me.txt_total()
        Refresh()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Timer1.Enabled = False
        lbl3.Text = "วันนี้คุณโทรหาลูกค้าแล้วยัง ยัง ยัง อีก"
        If lbl3.Right <= 0 Then
            lbl3.Left = Panel1.Right
        Else
            lbl3.Left -= IIf(Panel1.Size.Width / 355 > 0, Panel1.Size.Width / 355, 1)
        End If
        Timer1.Enabled = True
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

        frm_search.Show()
        Me.Hide()


    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim sql As String

        sql = "insert into crytalorder(total_sum,upprice1,upprice2,upprice3,note_order,note_order2) values(@total_sum,@upprice1,@upprice2,@upprice3,@note_order,@note_order2) "
        get_autonumbercystal()
        Refresh()
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@total_sum", txt_sum.Text)
        cmd.Parameters.AddWithValue("@upprice1", txt_upprice1.Text)
        cmd.Parameters.AddWithValue("@upprice2", txt_upprice2.Text)
        cmd.Parameters.AddWithValue("@upprice3", txt_upprice3.Text)
        cmd.Parameters.AddWithValue("@note_order", txt_newnote.Text)
        cmd.Parameters.AddWithValue("@note_order2", txt_newnote2.Text)
        If cmd.ExecuteNonQuery = 0 Then
            MsgBox("can not save sum")
        Else
            For Each itm As ListViewItem In ListView1.Items

                sql = " insert into  advorder_tb(staff_id,Order_day,crytalorder_id,customer_id,SDnumber,bag_type,thick_bag,colour_bag,bag_size,bag_total,bag_price,total_price) values(@staff_id,@Order_day,@crytalorder_id,@customer_id,@SDnumber,@bag_type,@thick_bag,@colour_bag,@bag_size,@bag_total,@bag_price,@total_price)"
                get_autonumber()

                Refresh()
                cmd = New SqlCommand(sql, cn)

                ListView1.Items.Clear()
                cmd.Parameters.AddWithValue("@staff_id", frm_search.lbl_staffID.Text)
                cmd.Parameters.AddWithValue("@Order_day", lbl_timeorder.Text)
                cmd.Parameters.AddWithValue("@crytalorder_id", txt_cryorder.Text)
                cmd.Parameters.AddWithValue("@customer_id", txt_cusid.Text)
                '    cmd.Parameters.AddWithValue("@Deliver_day", DateTimePicker1.Value)
                cmd.Parameters.AddWithValue("@SDnumber", txt_sdnumber.Text)
                cmd.Parameters.AddWithValue("@bag_type", itm.SubItems(0).Text)
                cmd.Parameters.AddWithValue("@thick_bag", itm.SubItems(2).Text)
                cmd.Parameters.AddWithValue("@colour_bag", itm.SubItems(3).Text)
                cmd.Parameters.AddWithValue("@bag_size", itm.SubItems(4).Text)
                cmd.Parameters.AddWithValue("@bag_total", itm.SubItems(5).Text)
                cmd.Parameters.AddWithValue("@bag_price", itm.SubItems(6).Text)
                cmd.Parameters.AddWithValue("@total_price", itm.SubItems(7).Text)
                If cmd.ExecuteNonQuery = 0 Then
                    MsgBox("Save ลงฐานข้อมูลไม่สำเร็จ")
                End If
            Next  ' ถ้าขยับ Next ไปใว้ข้างล่างติดกับ refresh จะทำให้ crytalorder values ซ้ำกันตามจำนวน add ใน listview


            MsgBox("SAVEEEEEEEEEEEEEEEEEEEEE")

        End If
        txt_sum.Text = "0.00"
        txt_bag_amount.Clear()
        txt_newnote.Clear()
        txt_upprice1.Clear()
        txt_upprice2.Clear()
        txt_upprice3.Clear()
        txt_print.Clear()
        '  refresh_everything()

    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs)
        '  Dim f3 As New adfrm1_order

        '   Me.Dispose()

        '    With frm_search
        'frm_search.Pnlmain.Controls.Clear()
        '    Dim frm_Selldeil As New adfrm1_order()
        ' frm_Selldeil.Size = Pnlmain.Size
        '    frm_Selldeil.TopLevel = False
        '    frm_Selldeil.Parent = frm_search.Pnlmain
        '   frm_Selldeil.Show()
        '   End With

        txt_bag_amount.Clear()
        txt_newnote.Clear()
        txt_upprice1.Clear()
        txt_upprice2.Clear()
        txt_upprice3.Clear()
        txt_print.Clear()
        Refresh()

    End Sub
    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click

        For Each i As ListViewItem In ListView1.SelectedItems
            txt_sdnumber.Text = Val(txt_sdnumber.Text) - (1) & "/" & Date.Now.Month
            ListView1.Items.Remove(i)
            txt_total()
        Next

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_crytalview.Show()
        'REPORT OBJECT
        Dim MyRpt As New Order_Report

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("ListViewData")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("bagtype1", Type.GetType("System.String"))
            .Add("SDnumber1", Type.GetType("System.String"))
            .Add("thickbag1", Type.GetType("System.String"))
            .Add("colourbag1", Type.GetType("System.String"))
            .Add("bagsize1", Type.GetType("System.String"))
            .Add("bagtotal1", Type.GetType("System.String"))
            .Add("bagprice1", Type.GetType("System.String"))
            .Add("totalprice1", Type.GetType("System.String"))



        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        For Each LVI As ListViewItem In ListView1.Items
            row = DS.Tables(0).NewRow
            row(0) = LVI.SubItems(0).Text
            row(1) = LVI.SubItems(1).Text
            row(2) = LVI.SubItems(2).Text
            row(3) = LVI.SubItems(3).Text
            row(4) = LVI.SubItems(4).Text
            row(5) = LVI.SubItems(5).Text
            row(6) = LVI.SubItems(6).Text
            row(7) = LVI.SubItems(7).Text
            DS.Tables(0).Rows.Add(row)
        Next

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)
        MyRpt.SetParameterValue("prName", txt_searchcus.Text)
        MyRpt.SetParameterValue("Praddress", txt_address.Text)
        MyRpt.SetParameterValue("Prnumber", txt_phone.Text)
        MyRpt.SetParameterValue("prordernum", txt_cryorder.Text)
        MyRpt.SetParameterValue("prup1", txt_upprice1.Text)
        MyRpt.SetParameterValue("prup2", txt_upprice2.Text)
        MyRpt.SetParameterValue("prup3", txt_upprice3.Text)
        MyRpt.SetParameterValue("Prdaynow", lbl_timeorder.Text)
        '    MyRpt.SetParameterValue("Prdeliverly", DateTimePicker1.Value)
        MyRpt.SetParameterValue("prnote", txt_newnote.Text)
        MyRpt.SetParameterValue("prnote2", txt_newnote2.Text)
        MyRpt.SetParameterValue("prlogin", frm_search.lbl_login_name.Text)
        MyRpt.SetParameterValue("prcontact", frm_search.lbl_contactlogin.Text)
        MyRpt.SetParameterValue("prcusnew", SqlabC_RadioButton1.Checked)
        MyRpt.SetParameterValue("prcusold", SqlabC_RadioButton2.Checked)
        MyRpt.SetParameterValue("prshopname", txt_shopname.Text)
        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        frm_crytalview.crytal.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        '  DS = Nothing

    End Sub


    'OK HERE IS THE ROUTINE THAT MAKES THIS ALL WORK. YOU ONLY NEED TO RUN THIS ONCE (UNLESS YOU CHANGE YOUR TABLE'S SCHEMA (ADD A COLUMN, ETC...)
    'WHAT THIS DOES, IS TAKES THE SCHEMA OF YOUR TABLE, AND WRITES IT TO AN XSD FILE. CR CAN USE AN XSD FILE AS A DB SCHEMA, SO YOU CAN LAYOUT YOUR REPORT AT DESIGN TIME
    'BASICALLY WHEN YOU DO IS, RUN THIS ROUTINE. THEN ADD A CR REPORT TO YOUR APP, AND WHEN YOU HOOK UP THE DATA SOURCE TO IT, SELECT
    '"MORE DATA SOURCES" -> "ADO.NET (XML)" AND THEN SELECT YOUR XSD FILE YOU CREATED (IT WILL BE IN THE BIN FOLDER OF THIS PROJECT)
    'THIS WILL ALLOW YOU TO LAYOUT YOUR REPORT USING THE EXACT FIELDS YOU WILL SEND OVER WHEN CREATING THE REPORT DYNAMICALLY.
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim DA As DataTable = Nothing
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        DS.Tables.Add("ListViewData")
        With DS.Tables(0).Columns
            .Add("bagtype1", Type.GetType("System.String"))
            .Add("SDnumber1", Type.GetType("System.String"))
            .Add("thickbag1", Type.GetType("System.String"))
            .Add("colourbag1", Type.GetType("System.String"))
            .Add("bagsize1", Type.GetType("System.String"))
            .Add("bagtotal1", Type.GetType("System.String"))
            .Add("bagprice1", Type.GetType("System.String"))
            .Add("totalprice1", Type.GetType("System.String"))
        End With

        'THIS LINE IS IMPORTANT.
        DS.WriteXmlSchema(Application.StartupPath & "\ReportSchema.xsd")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        frm_crytalview.Show()
    End Sub

    Private Sub DataGridView_show_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_show.CellContentClick
        '   With Me
        '.Activate()
        '   End With
    End Sub

    Private Sub timefororder_Tick(sender As Object, e As EventArgs) Handles time2.Tick

        lbl_timeorder.Text = Format(Now, "long date")

    End Sub

    Private Sub txt_searchbag_TextChanged(sender As Object, e As EventArgs) Handles txt_searchbag.TextChanged
        sql = String.Format("select * from bag_tb where bag_type like '{0}' or bag_size like '{0}' or thick_bag like '{0}' or bag_price like '{0}'",
           txt_searchbag.Text)
        DataGridView_show.DataSource = cmd_executeToDataTable()
    End Sub

    Private Sub btn_searchbag_Click(sender As Object, e As EventArgs) Handles btn_searchbag.Click
        refresh_data_table()
    End Sub


    Private Sub SqlabC_CheckedButton1_Click(sender As Object, e As EventArgs) Handles SqlabC_CheckedButton1.Click
        frm_search.Show()
        Me.Hide()

    End Sub

    Private Sub txt_phone_TextChanged(sender As Object, e As EventArgs) Handles txt_phone.TextChanged
        getcustomerphonenumber(txt_phone.Text)
        getcustomershopname(txt_phone.Text)
        getcustomeraddress(txt_phone.Text)
        getcustomerid(txt_phone.Text)
        radiocusnew(txt_phone.Text)
        radiocusold(txt_phone.Text)
        getcustomercomboname(txt_phone.Text)

    End Sub
    Private Sub btn_searchnum_Click(sender As Object, e As EventArgs) Handles btn_searchnum.Click
        Try
            sql = "select *  from Customer_detail where customer_contact='" & txt_searchcus.Text & "' "
            Dim dts As DataTable = cmd_executeToDataTable()
            txt_combo_name.Text = dts.Rows(0)("customer_name")
        Catch ex As Exception
            MsgBox("ใส่แต่หมายเลขเท่านั้นจ๊ะ")
        End Try
       

    End Sub
End Class
