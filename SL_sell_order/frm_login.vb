Imports System.Data.SqlClient

Public Class frm_login

          Dim cn As New SqlConnection("Data Source=TOMMY;Initial Catalog=TEST;User ID=sa;Password=Norame1808")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim m As New mb.ShowMessagebox
    Dim sql As String

    Friend Sub connect()
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
        Catch ex As Exception
            m.Fonts(New Font("Arial", 20, FontStyle.Regular), mb.TextColor.DarkBlue)
            m.ShowBox("ต่อ SQL Server ไม่ติด", mb.MStyle.ok, mb.FStyle.Critical, "Siew lamination")
            '   MsgBox("ต่อ SQL Server ไม่ติด")

        End Try

    End Sub
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

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cn.State = ConnectionState.Closed Then cn.Open()

        txt_namestaff.Text = My.Settings.username
        If My.Settings.username = "" Then
            chk_remenber.Checked = False

        Else
            chk_remenber.Checked = True
        End If

    End Sub

    Private Sub btn_newlogin_Click(sender As Object, e As EventArgs) Handles btn_newlogin.Click

        If txt_namestaff.Text = "" Or txt_passstaff.Text = "" Then
            m.Fonts(New Font("Arial", 20, FontStyle.Regular), mb.TextColor.DarkBlue)
            m.ShowBox("กรุณากรองอาไรสักนิดเถอะครับ", mb.MStyle.ok, mb.FStyle.Critical, "Siew lamination")
            ' MsgBox("กรุณากรองอาไรสักนิดเถอะครับ", vbCritical + vbOKOnly, "มีบ้างอย่างผิดพลาดก็คือลืมกรองอาไรหรือเปล่าครับ")
            Return
        End If

        sql = "select  count(*) from slusers_table where UserName='" & txt_namestaff.Text & "' AND UserPassword='" & txt_passstaff.Text & "'"
        Dim count_user As Integer = cmd_executeScalar()


        If count_user <= 0 Then

            m.Fonts(New Font("Arial", 20, FontStyle.Regular), mb.TextColor.DarkBlue)
            m.ShowBox("ขอร้องเถอะใส่ชื่อกับพาสให้ถูกต้องนะจ๊ะ", mb.MStyle.ok, mb.FStyle.Critical, "Siew lamination")
            ' Show("ขอร้องเถอะใส่ชื่อกับพาสให้ถูกต้องนะจ๊ะ", vbCritical + vbOKOnly, "ใส่ให้ถูกหน่อยจ๊ะ")
            txt_passstaff.Clear()
            txt_passstaff.Focus()
            txt_passstaff.Clear()
            txt_passstaff.Focus()
            Return
        End If

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If cn.State = ConnectionState.Closed Then cn.Open()

        sql = " select * from slusers_table where UserPassword ='" & txt_passstaff.Text & "'"
        da = New SqlClient.SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "table")


        Dim dtp As DataTable = ds.Tables("table")

        If dtp.Rows(0)("UserPassword") = "password" Then
            'txt_passstaff.Text = dtp.Rows(0)("UserPassword") = "password" Then 
            '    If ds.Tables("datatable").Rows(0)("UserPassword") = "password" Then
            MsgBox("กรุณาเปลี่ยนpasswordด้วยนะจ๊ะ", vbInformation, "สำเร้จ")
            frm_changepass.Show()
            Me.Hide()
            txt_passstaff.Clear()
            txt_passstaff.Clear()
            txt_passstaff.Select()
        Else
            ' m.ButtonText("ตกลง")
            m.Fonts(New Font("Arial", 20, FontStyle.Regular), mb.TextColor.DarkBlue)
            m.ShowBox("เข้าสู้ระบบสำเร็จ", mb.MStyle.ok, mb.FStyle.Keys, "Siew lamination")   '= Windows.Forms.DialogResult.No Then Return
            '  MsgBox("เข้าสู้ระบบสำเร็จ", vbInformation, "สำเร้จ")
            ' change_users.Show()

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


            sql = "select *  from slusers_table where UserName='" & txt_namestaff.Text & "' AND UserPassword='" & txt_passstaff.Text & "'"
            da = New SqlDataAdapter(sql, cn)
            ds = New DataSet
            da.Fill(ds, "table")

            If ds.Tables("table").Rows(0)("Usertype") = "admin" Then
                frm_search.Panal_records.Enabled = True
                frm_search.Panel_tool.Enabled = True
            Else
                frm_search.Panal_records.Enabled = True
                frm_search.Panel_tool.Enabled = False


            End If
            frm_search.Show()
            Me.Hide()

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            sql = "select *  from slusers_table where UserName='" & txt_namestaff.Text & "' AND UserPassword='" & txt_passstaff.Text & "'"
            Dim dts As DataTable = cmd_executeToDataTable()

            '  adfrm1_order.lbl_user.Text = dts.Rows(0)("UserName")อย่างงี้อย่างที่ 1 ถ้ามีแอดค่าถ้าหลายค่าตามด้วย with เลย
            With frm_search
                .lbl_login_name.Text = dts.Rows(0)("name")
                .lbl_staffID.Text = dts.Rows(0)("staff_ID")
                .lbl_contactlogin.Text = dts.Rows(0)("contact_number")
                .lbl_logintime.Text = Date.Now

            End With
            txt_passstaff.Clear()
            txt_passstaff.Clear()
            txt_passstaff.Select()

        End If

        '   End If
    End Sub

    Private Sub chk_remenber_CheckedChanged(sender As Object, e As EventArgs) Handles chk_remenber.CheckedChanged
        If chk_remenber.Checked = True Then
            My.Settings.username = txt_namestaff.Text
        Else
            My.Settings.username = ""
        End If
        My.Settings.Save()

    End Sub
End Class