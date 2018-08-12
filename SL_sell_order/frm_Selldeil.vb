Imports System.Data.SqlClient

Public Class frm_Selldeil

          Dim cn As New SqlConnection("Data Source=TOMMY;Initial Catalog=TEST;User ID=sa;Password=Norame1808")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim Parmas As New List(Of SqlParameter)
    Dim dr As SqlDataReader
    Dim m As New mb.ShowMessagebox
    Dim sql As String = ""
    Dim recount As Integer



    Friend Sub connect()
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
        Catch ex As Exception
            MsgBox("ต่อบ่ติดว่ะ")
        End Try

    End Sub
    Friend Function cmd_execuTodatatable()

        connect()
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "table ")
        Return ds.Tables("table ")

    End Function
    Friend Function cmd_excuteNonquery()
        connect()
        cmd = New SqlCommand(sql, cn)
        Return cmd.ExecuteNonQuery
    End Function

    Friend Function cmd_excuteScalar()    'นี้เป้นตัวรับข้อมูลกลับมาจากฐานข้อมูลแต่เป้นแค่เดียว เท่านั้น แต่ต้องใส่คำสั่่งไปก่อน *** และเรียกคำสั่งใช้ตามนี้ ที่ประกาศใว้ ที่เหลือคื่อขั้นตอนแต่จะเรียกใช้ให้ ใส่เหมือน นี้เลย cmd_excuteScalar(นี้คือค่าที่กลับมาจากตาราง)

        connect()
        cmd = New SqlCommand(sql, cn)
        'sql = คำสั้ง แบบว่าแบบแนวๆ น้อยกว่า หรือเท่ากับ 
        Return cmd.ExecuteScalar

    End Function

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
    Private Sub refresh_data_table()

        sql = "select * from alldata_View"
        DataGridView_showcus1.DataSource = cmd_execuTodatatable()

    End Sub
    Private Sub refresh_everything()
        Me.Dispose()
        With frm_search
            frm_search.Pnlmain.Controls.Clear()
            Dim frm_Selldeil As New frm_Selldeil()
            '  frm_Selldeil.Size = Pnlmain.Size
            frm_Selldeil.TopLevel = False
            frm_Selldeil.Parent = frm_search.Pnlmain
            frm_Selldeil.Show()
        End With
    End Sub

    Public Sub execquary(query As String)
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

    Private Sub AddParam(name As String, value As Object)  'อันนีเอาใว้เวลาใข้คำสั้ง 

        Dim newParam As New SqlParameter(name, value)
        Parmas.Add(newParam)

    End Sub

    Private Sub frm_Selldeil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cn.State = ConnectionState.Closed Then cn.Open()
        refresh_data_table()
        getcustomername()

        Me.txt_searchcus.BorderStyle = BorderStyle.FixedSingle
        Me.lbl_orderid.BackColor = Color.White
        Me.lbl_orderid.BorderStyle = BorderStyle.FixedSingle
        Me.lbl_crytalorderID.BackColor = Color.White
        Me.lbl_crytalorderID.BorderStyle = BorderStyle.FixedSingle
        Me.txt_customercombo.DropDownStyle = ComboBoxStyle.DropDownList
        Me.BackColor = Color.FromArgb(64, 128, 128)
        Me.txt_customercombo.DropDownHeight = 150
        AcceptButton = btn_scarch
        Me.MaximizeBox = False
        Me.Text = " ค้นหารายชื่อลูกค้าหรือจะไรก็แล้วแต่"

        'buttons properties
        btn_scarch.BackColor = Color.FromArgb(255, 192, 192)
        btn_update.BackColor = Color.FromArgb(192, 255, 192)
        btn_close.BackColor = Color.FromArgb(192, 255, 255)

        'textbox as type of item in groupbox
        For Each item As Control In GroupBox1.Controls
            If TypeOf item Is TextBox Then
                DirectCast(item, TextBox).BorderStyle = BorderStyle.FixedSingle
                DirectCast(item, TextBox).TextAlign = HorizontalAlignment.Center
            End If
        Next



    End Sub
    Private Sub getcustomername()

        sql = " select customer_name from customer_detail"
        cmd_database_to_object(txt_customercombo)
        ' For Each r As DataRow In ds.Tables(0).Rows
        'txt_customercombo.Items.Add(r("customer_name"))

        ' Next
    End Sub
    Private Sub getorderid(orderid As String)
        AddParam("@orderid", orderid)

        execquary("select order_id from alldata_View where customer_name = @orderid")

        If recount > 0 Then lbl_orderid.Text = ds.Tables(0).Rows(0).Item("order_id")

    End Sub
    Private Sub getcustomerphonenumber(phone As String)
        'add a serch parameter
        AddParam("@phone", phone)

        'run qurey
        execquary("select customer_contact from alldata_View where customer_name = @phone")

        'if customer_name so send phonenumber to our textbox
        If recount > 0 Then txt_customerphone.Text = ds.Tables(0).Rows(0).Item("customer_contact")


    End Sub
    Private Sub getcustomershopname(shop As String)
        AddParam("@shop", shop)

        execquary("select shop_name from alldata_View where customer_name  = @shop")

        If recount > 0 Then txt_shopname.Text = ds.Tables(0).Rows(0).Item("shop_name")

    End Sub
    Private Sub getcustomeraddress(address As String)
        AddParam("@address", address)

        execquary("select shop_address from alldata_View where customer_name = @address")

        If recount > 0 Then txt_customeraddress.Text = ds.Tables(0).Rows(0).Item("shop_address")

    End Sub
   
    
    Private Sub getcrytalorderid(crytal_id As String)
        AddParam("@crytal_id", crytal_id)

        execquary("select  crytalorder_id from alldata_View where customer_name = @crytal_id")

        If recount > 0 Then lbl_crytalorderID.Text = ds.Tables(0).Rows(0).Item("crytalorder_id")


    End Sub
    Private Sub getnameinname(customername As String)
        AddParam("@customername", customername)

        execquary("select customer_name from alldata_View where customer_name = @customername")

        If recount > 0 Then txt_customer_name.Text = ds.Tables(0).Rows(0).Item("customer_name")

    End Sub
    Private Sub getnameincombobox(combobox As String)
        AddParam("combobox", combobox)

        execquary("select customer_name from alldata_View where customer_name = @combobox")

        If recount > 0 Then txt_searchcus.Text = ds.Tables(0).Rows(0).Item("customer_name")

    End Sub
    Private Sub getbagtype(bagtype As String)
        AddParam("@bagtype", bagtype)

        execquary("select bag_type from alldata_View where customer_name = @bagtype")

        If recount > 0 Then txt_bagtype.Text = ds.Tables(0).Rows(0).Item("bag_type")

    End Sub
    Private Sub getsonumber(sonumber As String)
        AddParam("@sonumber", sonumber)

        execquary("select SDnumber from alldata_View where customer_name = @sonumber")

        If recount > 0 Then txt_sonumber.Text = ds.Tables(0).Rows(0).Item("SDnumber")

    End Sub
    Private Sub getthickbag(thickbag As String)
        AddParam("@thickbag", thickbag)

        execquary("select thick_bag from alldata_View where customer_name = @thickbag")

        If recount > 0 Then txt_thickbag.Text = ds.Tables(0).Rows(0).Item("thick_bag")


    End Sub
    Private Sub getcolourbag(colourbag As String)
        AddParam("@colourbag", colourbag)

        execquary("select colour_bag from alldata_View where customer_name = @colourbag")

        If recount > 0 Then txt_colourbag.Text = ds.Tables(0).Rows(0).Item("colour_bag")

    End Sub
    Private Sub getbagsize(bagsize As String)
        AddParam("@bagsize", bagsize)

        execquary("select bag_size from alldata_View where customer_name = @bagsize")

        If recount > 0 Then txt_bagsize.Text = ds.Tables(0).Rows(0).Item("bag_size")

    End Sub
    Private Sub getbagtotal(bagtotal As String)
        AddParam("@bagtotal", bagtotal)

        execquary("select bag_total from alldata_View where customer_name = @bagtotal")

        If recount > 0 Then txt_bagtotal.Text = ds.Tables(0).Rows(0).Item("bag_total")

    End Sub
    Private Sub getbagprice(bagprice As String)
        AddParam("@bagprice", bagprice)

        execquary("select bag_price from alldata_View where customer_name = @bagprice")

        If recount > 0 Then txt_bagprice.Text = ds.Tables(0).Rows(0).Item("bag_price")

    End Sub
    Private Sub gettotalprice(totalprice As String)
        AddParam("@totalprice", totalprice)

        execquary("select total_price from alldata_View where customer_name = @totalprice")

        If recount > 0 Then txt_totalprice.Text = ds.Tables(0).Rows(0).Item("total_price")

    End Sub
    Private Sub getnoteorder1(note_order As String)
        AddParam("@note_order", note_order)

        execquary("select note_order from alldata_View where customer_name = @note_order")

        If recount > 0 Then txt_noteorder.Text = ds.Tables(0).Rows(0).Item("note_order")

    End Sub
    Private Sub getnoteorder2(note_order2 As String)
        AddParam("@note_order2", note_order2)

        execquary("select note_order2 from alldata_View where customer_name = @note_order2")

        If recount > 0 Then txt_noteorder2.Text = ds.Tables(0).Rows(0).Item("note_order2")

    End Sub

    Private Sub txt_customercombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_customercombo.SelectedIndexChanged
        getcustomerphonenumber(txt_customercombo.Text)
        getcustomershopname(txt_customercombo.Text)
        getcustomeraddress(txt_customercombo.Text)
        getnameinname(txt_customercombo.Text)

        getnameinname(txt_customercombo.Text)
        getbagtype(txt_customercombo.Text)
        getsonumber(txt_customercombo.Text)
        getthickbag(txt_customercombo.Text)
        getbagsize(txt_customercombo.Text)
        getbagtotal(txt_customercombo.Text)
        getbagprice(txt_customercombo.Text)
        gettotalprice(txt_customercombo.Text)
        getnoteorder1(txt_customercombo.Text)
        getnoteorder2(txt_customercombo.Text)
        getcrytalorderid(txt_customercombo.Text)
        getcolourbag(txt_customercombo.Text)

        txt_searchcus.Text = txt_customercombo.Text


    End Sub
    Private Sub btn_scarch_Click(sender As Object, e As EventArgs) Handles btn_scarch.Click
        sql = String.Format("select * from alldata_View where  customer_name like '{0}' or customer_contact like '{0}' or crytalorder_id like '{0}' or shop_name like '{0}' or SDnumber like '{0}' or note_order like '{0}' or Order_day like '{0}'",
        txt_searchcus.Text)
        DataGridView_showcus1.DataSource = cmd_execuTodatatable()

    End Sub
    Private Sub searching()
        '  sql = "select customer_id,staff_ID, Crytalorder_id,SDnumber,Order_day,Deliver_day,customer_name ,customer_lastname,shop_name,shop_address,customer_contact,total_sum,total_price,upprice1,upprice2,upprice3,bag_type,bag_size,thick_bag,bag_total,bag_price,colour_bag,name,UserName,Contact_number from alldata_View where Crytalorder_id like '%" & txt_searchcus.Text & "%' or customer_name like '%" & txt_searchcus.Text & "%' or customer_contact like '%" & txt_searchcus.Text & "%' or SDnumber like '%" & txt_searchcus.Text & "%' or staff_ID like '%" & txt_searchcus.Text & "%' or Deliver_day like '%" & txt_searchcus.Text & "%' or Order_day like '%" & txt_searchcus.Text & "%' or Total_sum like '%" & txt_searchcus.Text & "%' or Total_price like '%" & txt_searchcus.Text & "%'"
        '  DataGridView_showcus1.DataSource = cmd_excuteTodatatable()
        sql = String.Format("select * from alldata_View where  customer_name like '{0}' or customer_contact like '{0}' or crytalorder_id like '{0}' or shop_name like '{0}' or SDnumber like '{0}' or note_order like '{0}' or Order_day like '{0}'",
        txt_searchcus.Text)
        DataGridView_showcus1.DataSource = cmd_execuTodatatable()

    End Sub
    Private Sub txt_searchcus_TextChanged(sender As Object, e As EventArgs) Handles txt_searchcus.TextChanged
        '  sql = "select customer_id,staff_ID, Crytalorder_id,SDnumber,Order_day,Deliver_day,customer_name ,customer_lastname,shop_name,shop_address,customer_contact,total_sum,total_price,upprice1,upprice2,upprice3,bag_type,bag_size,thick_bag,bag_total,bag_price,colour_bag,name,UserName,Contact_number from alldata_View where Crytalorder_id like '%" & txt_searchcus.Text & "%' or customer_name like '%" & txt_searchcus.Text & "%' or customer_contact like '%" & txt_searchcus.Text & "%' or SDnumber like '%" & txt_searchcus.Text & "%' or staff_ID like '%" & txt_searchcus.Text & "%' or Deliver_day like '%" & txt_searchcus.Text & "%' or Order_day like '%" & txt_searchcus.Text & "%' or Total_sum like '%" & txt_searchcus.Text & "%' or Total_price like '%" & txt_searchcus.Text & "%'"
        '  DataGridView_showcus1.DataSource = cmd_excuteTodatatable()
        getcustomerphonenumber(txt_searchcus.Text)
        getcustomershopname(txt_searchcus.Text)
        getcustomeraddress(txt_searchcus.Text)
        getnameinname(txt_searchcus.Text)
        getnameincombobox(txt_searchcus.Text)
        getbagtype(txt_searchcus.Text)
        getsonumber(txt_searchcus.Text)
        getthickbag(txt_searchcus.Text)
        getbagsize(txt_searchcus.Text)
        getbagtotal(txt_searchcus.Text)
        getbagprice(txt_searchcus.Text)
        gettotalprice(txt_searchcus.Text)
        getnoteorder1(txt_searchcus.Text)
        getnoteorder2(txt_searchcus.Text)
        getcrytalorderid(txt_searchcus.Text)
        getcolourbag(txt_searchcus.Text)
        searching()  'ตัวนี้ทำให้เพี้ยนๆ
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub DataGridView_showcus1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_showcus1.CellClick

        '   Dim i As Integer = DataGridView_showcus1.CurrentRow.Index
        '   txt_customercombo.Text = DataGridView_showcus1.Item(0, i).Value
        '    lbl_customer_id.Text = DataGridView_showcus1.Item(1, i).Value
        '   lbl_crytalorderID.Text = DataGridView_showcus1.Item(2, i).Value
        '   txt_sonumber.Text = DataGridView_showcus1.Item(3, i).Value
        '   txt_customer_name.Text = DataGridView_showcus1.Item(4, i).Value
        '   txt_lastname.Text = DataGridView_showcus1.Item(5, i).Value
        'txt_customeraddress.Text = DataGridView_showcus1.Item(7, i).Value
        '   txt_customerphone.Text = DataGridView_showcus1.Item(8, i).Value
        '    txt_bagtype.Text = DataGridView_showcus1.Item(9, i).Value
        '    txt_bagsize.Text = DataGridView_showcus1.Item(10, i).Value
        'txt_noteorder.Text = DataGridView_showcus1.Item(12, i).Value
        '  txt_noteorder2.Text = DataGridView_showcus1.Item(13, i).Value
        '  txt_bagtotal.Text = DataGridView_showcus1.Item(14, i).Value
        '  txt_colourbag.Text = DataGridView_showcus1.Item(15, i).Value
        '  txt_bagprice.Text = DataGridView_showcus1.Item(16, i).Value
        '  txt_totalprice.Text = DataGridView_showcus1.Item(17, i).Value


        Dim select_row As Integer = DataGridView_showcus1.CurrentRow.Index
        Dim order As String = DataGridView_showcus1(0, select_row).Value
        sql = "select * from alldata_View where order_id='" & order & "'"
        Dim data_keep As DataTable = cmd_execuTodatatable()
        lbl_orderid.Text = data_keep.Rows(0)("Order_id")
        lbl_crytalorderID.Text = data_keep.Rows(0)("crytalorder_id")
        txt_sonumber.Text = data_keep.Rows(0)("SDnumber")
        txt_customer_name.Text = data_keep.Rows(0)("customer_name")
        txt_lastname.Text = data_keep.Rows(0)("customer_lastname")
        txt_shopname.Text = data_keep.Rows(0)("shop_name")
        txt_customeraddress.Text = data_keep.Rows(0)("shop_address")
        txt_customerphone.Text = data_keep.Rows(0)("customer_contact")
        txt_bagtype.Text = data_keep.Rows(0)("bag_type")
        txt_bagsize.Text = data_keep.Rows(0)("bag_size")
        txt_thickbag.Text = data_keep.Rows(0)("thick_bag")
        txt_bagtotal.Text = data_keep.Rows(0)("bag_total")
        txt_colourbag.Text = data_keep.Rows(0)("colour_bag")
        txt_bagprice.Text = data_keep.Rows(0)("bag_price")
        txt_totalprice.Text = data_keep.Rows(0)("total_price")
        txt_noteorder.Text = data_keep.Rows(0)("note_order")
        txt_noteorder2.Text = data_keep.Rows(0)("note_order2")
        txt_upprice1.Text = data_keep.Rows(0)("upprice1")
        txt_upprice2.Text = data_keep.Rows(0)("upprice2")
        txt_upprice3.Text = data_keep.Rows(0)("upprice3")
        radio_cusnew.Checked = data_keep.Rows(0)("customer_newold")
        radio_cusold.Checked = data_keep.Rows(0)("customer_old")

    End Sub
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        Dim sonum As String
        sonum = Me.txt_sonumber.Text
        If cn.State = ConnectionState.Closed Then cn.Open()
        cmd = New SqlCommand()
        cmd.CommandText = "update alldata_View set bag_size= '" & txt_bagsize.Text & "',total_price= '" & txt_totalprice.Text & "',bag_total= '" & txt_bagtotal.Text & "',bag_type = '" & txt_bagtype.Text & "',thick_bag = '" & txt_thickbag.Text & "',colour_bag = '" & txt_colourbag.Text & "',bag_price='" & txt_bagprice.Text & "'  where SDnumber  = '" & sonum & "'"
        cmd.Connection = cn
        cmd.ExecuteNonQuery()
        m.Fonts(New Font("Arial", 20, FontStyle.Regular), mb.TextColor.DarkBlue)
        m.ShowBox("สำเร็จ", mb.MStyle.ok, mb.FStyle.Information, "Siew lamination")
        ' MsgBox("เปลี่ยนข้อมูลสำเร้จ")     
        refresh_everything()
        refresh_data_table()

        ' Dim crytalor As String
        '  crytalor = Me.lbl_crytalorderID.Text
        '  If cn.State = ConnectionState.Closed Then cn.Open()
        '  cmd = New SqlCommand()
        '  cmd.CommandText = "update crytalorder set note_order= '" & txt_noteorder.Text & "' , note_order2= '" & txt_noteorder2.Text & "' where  Crytalorder = '" & crytalor & "'"
        '  cmd.Connection = cn
        '  cmd.ExecuteNonQuery()


        ' If MsgBox("คุณต้องการแก้ไข หรือไม่ ?") = vbNo Then Return

        '  sql = String.Format("update alldata_View set bag_type='{0}',thick_bag='{1}'bag_size='{2}', bag_price='{3}' where crytalorder='{4}'",
        '  txt_bagtype.Text, txt_bagsize.Text, txt_thickbag.Text, txt_bagprice.Text, lbl_crytalorderID.Text)
        '
        '  If cmd_excuteNonquery() = 0 Then
        ' MsgBox("ล้มเหลว")  'ลูกเล่น diglog box 
        ' Else
        '  MsgBox("สำเร็จ")
        ' refresh_data_table()
        '  End If
        '


    End Sub


    Private Sub txt_delete_Click(sender As Object, e As EventArgs) Handles txt_delete.Click

        m.ButtonText("ตกลง", "ยกเลิก")
        m.Fonts(New Font("Arial", 30, FontStyle.Regular), mb.TextColor.Green)
        If m.ShowBox("ยืนยันการลบข้อมูลหรือไม่", mb.MStyle.YesNo, mb.FStyle.Question, "Tommy") = Windows.Forms.DialogResult.No Then Return



        '  If MsgBox("ยืนยันการลบข้อมูลหรือไม่ ?") = vbNo Then Return

        '  Dim i As Integer = DataGridView_showcus1.CurrentRow.Index
        '  Dim sonumber As String = DataGridView_showcus1.Item(2, i).Value
        'sql = "delete from slusers_table where UserName = '" & txtdelete.Text & "'" ของเก่า 

        sql = "delete from advorder_tb where SDnumber = '" & txt_sonumber.Text & "'"

        If cmd_excuteNonquery() = 0 Then
            SqlabC_AlertBox2.Show()
            ' MsgBox("ลบไม่สำเร็จ")
        Else
            SqlabC_AlertBox1.Show()

            ' MsgBox("สำเร็จ")
            refresh_data_table()
            '  refresh_all_data_user() 'คือทำไรเสร้จให้รีเพรส ดาต้าเลย 
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim dt As New DataTable
        dt = Me.DataGridView_showcus1.DataSource

        Dim cr As New search
        cr.SetDataSource(dt)

        Dim R As New frm_crytalorder
        R.CrystalReportViewer1.ReportSource = cr
        R.ShowDialog()

        '   frm_crytalorder.Show()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        refresh_everything()

    End Sub

    Private Sub btn_savenote_Click(sender As Object, e As EventArgs) Handles btn_savenote.Click
        Dim notesave As String
        notesave = Me.lbl_crytalorderID.Text
        If cn.State = ConnectionState.Closed Then cn.Open()
        cmd = New SqlCommand()
        cmd.CommandText = "update alldata_View set note_order= '" & txt_noteorder.Text & "', note_order2= '" & txt_noteorder2.Text & "',upprice1='" & txt_upprice1.Text & "',upprice2 = '" & txt_upprice2.Text & "',upprice3 = '" & txt_upprice3.Text & "' where crytalorder_id  = '" & notesave & "'"
        cmd.Connection = cn
        cmd.ExecuteNonQuery()
        MsgBox("เปลี่ยนข้อมูลสำเร้จ")
        refresh_everything()
        refresh_data_table()
    End Sub


    Private Sub SqlabC_AlertBox1_Click(sender As Object, e As EventArgs) Handles SqlabC_AlertBox1.Click

    End Sub

    Private Sub txt_searchcus1_TextChanged(sender As Object, e As EventArgs) Handles txt_searchcus.TextChanged

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class