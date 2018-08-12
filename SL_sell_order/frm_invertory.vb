Imports System.Data.SqlClient

Public Class frm_invertory
          Dim cn As New SqlConnection("Data Source=TOMMY;Initial Catalog=TEST;User ID=sa;Password=Norame1808")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim sql As String

    Friend Sub connect()
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
        Catch ex As Exception
            MsgBox("ต่อ server ไม่ติดนะจ๊ะ")
        End Try

    End Sub
    Friend Function cmd_executeNoquery()
        connect()
        cmd = New SqlCommand(sql, cn)
        Return cmd.ExecuteNonQuery

    End Function
    Friend Function cmd_executeToDatatable()
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
        Dim header() As String = {"ถุง ID", "วัตถุดิบ", "ขนาด", "หนา", "ราคา"}  'ขั้นตอนการเปลี่ยนชื่อเอา function sub จากข้างบนมาใช้ 
        change_column_datagrid(DataGridView_invertory, header)

    End Sub
    Private Sub refresh_bag_datagride()

        sql = "select * from bag_tb"

        DataGridView_invertory.DataSource = cmd_executeToDatatable()
        change_all_column()
    End Sub

    Private Sub frm_invertory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_bag_datagride()
    End Sub

    Private Sub DataGridView_invertory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_invertory.CellClick
        Dim i As Integer = DataGridView_invertory.CurrentRow.Index
        lbl_bagid.Text = DataGridView_invertory.Item(0, i).Value
        txt_bagtype.Text = DataGridView_invertory.Item(1, i).Value
        txt_bagsize.Text = DataGridView_invertory.Item(2, i).Value
        txt_thickbag.Text = DataGridView_invertory.Item(3, i).Value
        txt_bagprice.Text = DataGridView_invertory.Item(4, i).Value
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        refresh_bag_datagride()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If MsgBox("นายต้องการเพิ่มข้อมูลหรือเปล่าครับ ?") = vbNo Then Return

        sql = " insert into bag_tb (bag_type,bag_size,thick_bag,bag_price) values (@bag_type,@bag_size,@thick_bag,@bag_price)"

        cmd = New SqlClient.SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@bag_type", txt_bagtype.Text)
        cmd.Parameters.AddWithValue("@bag_size", txt_bagsize.Text)
        cmd.Parameters.AddWithValue("@thick_bag", txt_thickbag.Text)
        cmd.Parameters.AddWithValue("@bag_price", txt_bagprice.Text)

        If cmd.ExecuteNonQuery = 0 Then

            MsgBox("ล้มเหลว")
        Else
            MsgBox("สำเร็จ")
            refresh_bag_datagride()
        End If

        txt_bagtype.clear()
        txt_bagsize.Clear()
        txt_thickbag.Clear()
        txt_bagprice.Clear()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If MsgBox("คุณต้องการแก้ไข หรือไม่ ?") = vbNo Then Return

        sql = String.Format("update bag_tb set bag_type='{0}',bag_size='{1}', thick_bag='{2}' , bag_price='{3}' where bag_id='{4}'",
                            txt_bagtype.Text, txt_bagsize.Text, txt_thickbag.Text, txt_bagprice.Text, lbl_bagid.Text)

        If cmd_executeNoquery() = 0 Then
            MsgBox("ล้มเหลว")  'ลูกเล่น diglog box 
        Else
            MsgBox("สำเร็จ")
            refresh_bag_datagride()


        End If
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        If MsgBox("ยืนยันการลบข้อมูลหรือไม่ ?") = vbNo Then Return

        Dim i As Integer = DataGridView_invertory.CurrentRow.Index
        Dim bagid As String = DataGridView_invertory.Item(0, i).Value
        'sql = "delete from slusers_table where UserName = '" & txtdelete.Text & "'" ของเก่า 

        sql = "delete from bag_tb where bag_id = '" & bagid & "'"

        If cmd_executeNoquery() = 0 Then
            MsgBox("ลบไม่สำเร็จ")
        Else
            MsgBox("สำเร็จ")
            refresh_bag_datagride() 'คือทำไรเสร้จให้รีเพรส ดาต้าเลย 

        End If
    End Sub

    Private Sub SqlabC_TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        sql = String.Format("select * from bag_tb where bag_type like '{0}' or bag_size like '{0}' or thick_bag like '{0}' or bag_price like '{0}'",
   txt_search.Text)
        DataGridView_invertory.DataSource = cmd_executeToDatatable()
    End Sub

  
End Class