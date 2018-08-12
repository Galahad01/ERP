Imports System.Data.SqlClient

Public Class frm_staffparty

          Dim cn As New SqlConnection("Data Source=TOMMY;Initial Catalog=TEST;User ID=sa;Password=Norame1808")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim sql As String = ""

    Friend Sub connect()
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
        Catch ex As Exception
            MsgBox("ex.message")
        End Try

    End Sub

    Friend Function cmd_executeTodatatable()

        connect()
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "table")
        Return ds.Tables("table")

    End Function
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

    Private Sub refresh_datagride_table()

        sql = " select * from slusers_table "
        DataGridView_useradd.DataSource = cmd_executeTodatatable()

    End Sub
    Private Sub refresh_datagrideedit_table()

        sql = " select * from slusers_table "
        DataGridView_edit.DataSource = cmd_executeTodatatable()

    End Sub

    Private Sub frm_staffparty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_datagride_table()
        refresh_datagrideedit_table()
        '   Me.BackColor = Color.FromArgb(64, 128, 128)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        hippo.Location = New Point(hippo.Location.X + 5, hippo.Location.Y)
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If MsgBox("นายต้องการเพิ่มข้อมูลหรือเปล่าครับ ?") = vbNo Then Return

        sql = "select count(*) from slusers_table where username='" & txt_userlogin.Text & "'"    ' check ว่ามีชื่อซ้ำกันไหม 
        If cmd_executeScalar() > 0 Then
            MsgBox("ชื่อนี้มีคนเอาไปแล้วเสียใจด้วย")    'ถ้ามีชื่อซ้ำมันก้จะหยุดอยุ่ตรงนี้ไม่ลงไปข้างล่างแล้ว ถ้าไม่มีชื่อซื้ามันก้จะข้ามขั้นตอนนี้ไปเลย 
            txt_name.Clear()
            txt_userlogin.Clear()
            txt_password.Clear()
            txt_dept.Clear()
            txt_contact.Clear()
            txt_name.Select()
            Return

        End If
        sql = "insert into slusers_table values('" & txt_name.Text & "','" & txt_userlogin.Text & "','" & txt_password.Text & "','" & txt_dept.Text & "','" & txt_contact.Text & "')"

        If cmd_executeNoquery() = 0 Then
            MsgBox("ล้มเหลว")
        Else
            MsgBox("สำเร็จ")
            refresh_datagride_table()
            refresh_datagrideedit_table()
        End If
        txt_name.Clear()
        txt_userlogin.Clear()
        txt_password.Clear()
        txt_dept.Clear()
        txt_contact.Clear()
        txt_name.Select()

    End Sub

    Private Sub DataGridView_edit_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_edit.CellClick
        Dim i As Integer = DataGridView_edit.CurrentRow.Index
        lbl_id_edit.Text = DataGridView_edit.Item(0, i).Value
        txt_name_edit.Text = DataGridView_edit.Item(1, i).Value
        txt_userlogin_edit.Text = DataGridView_edit.Item(2, i).Value
        txt_password_edit.Text = DataGridView_edit.Item(3, i).Value
        txt_dept_edit.Text = DataGridView_edit.Item(4, i).Value
        txt_contact_edit.Text = DataGridView_edit.Item(5, i).Value
    End Sub

    Private Sub btn_save_edit_Click(sender As Object, e As EventArgs) Handles btn_save_edit.Click
        If MsgBox("คุณต้องการแก้ไข หรือไม่ ?") = vbNo Then Return

        sql = String.Format("update slusers_table set name='{0}',UserName='{1}', UserPassword='{2}' , Usertype='{3}' ,Contact_number='{4}' where staff_ID='{5}'",
                             txt_name_edit.Text, txt_userlogin_edit.Text, txt_password_edit.Text, txt_dept_edit.Text, txt_contact_edit.Text, lbl_id_edit.Text)

        If cmd_executeNoquery() = 0 Then
            MsgBox("ล้มเหลว")  'ลูกเล่น diglog box 
        Else
            MsgBox("สำเร็จ")
            refresh_datagrideedit_table()
            refresh_datagride_table()

        End If

    End Sub
    Private Sub btn_del_edit_Click(sender As Object, e As EventArgs) Handles btn_del_edit.Click
        If MsgBox("ยืนยันการลบข้อมูลหรือไม่ ?") = vbNo Then Return

        Dim i As Integer = DataGridView_edit.CurrentRow.Index
        Dim userid As String = DataGridView_edit.Item(0, i).Value
        'sql = "delete from slusers_table where UserName = '" & txtdelete.Text & "'" ของเก่า 

        sql = "delete from slusers_table where staff_ID = '" & userid & "'"

        If cmd_executeNoquery() = 0 Then
            MsgBox("ลบไม่สำเร็จ")
        Else
            MsgBox("สำเร็จ")
            refresh_datagrideedit_table() 'คือทำไรเสร้จให้รีเพรส ดาต้าเลย 
            refresh_datagride_table()
        End If
    End Sub

  
End Class