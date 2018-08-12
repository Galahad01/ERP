Imports System.Data.SqlClient

Public Class frm_changepass
          Dim cn As New SqlConnection("Data Source=TOMMY;Initial Catalog=TEST;User ID=sa;Password=Norame1808")
    Dim cmd As New SqlCommand
    Dim uname As String
    Dim pass As String
     
    Private Sub frm_changepass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cn.State = ConnectionState.Closed Then cn.Open()

        uname = frm_login.txt_namestaff.Text
        pass = frm_login.txt_passstaff.Text

    End Sub

    Private Sub btn_changpass_Click(sender As Object, e As EventArgs) Handles btn_changpass.Click
        If txt_newpassword.Text = "" Or txt_confirm.Text = "" Then
            MessageBox.Show("เปลี่ยนพาสเวิดเดียวนี้นะจ๊ะ")

        ElseIf (txt_newpassword.Text <> txt_confirm.Text) Then
            MsgBox("new password and confirmation password didn't matched")
        Else
            cmd = New SqlCommand()
            cmd.CommandText = "update slusers_table set Userpassword = '" & txt_confirm.Text & "' where UserName = '" & uname & "'"
            cmd.Connection = cn
            cmd.ExecuteNonQuery()
            MsgBox("password changed")

        End If
    End Sub

    Private Sub SqlabC_ButtonB1_Click(sender As Object, e As EventArgs) Handles SqlabC_ButtonB1.Click
        frm_login.Show()
        Me.Close()
    End Sub
End Class