Imports System.IO

Public Class frm_note
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim m As MsgBoxResult
    Dim t As String
    Dim currenttime As String
    Dim messagetime As String

    Private Sub frm_note_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim m1 As MsgBoxResult
        t = MonthCalendar1.SelectionRange.Start.Month.ToString & MonthCalendar1.SelectionRange.Start.Day.ToString

        If Date.Today = MonthCalendar1.TodayDate And File.Exists(t & ".txt") = True Then
            m1 = MsgBox(" !!! คุณมีนัดโทรหาลูกค้าวันนี้ ว่าได้รับของหรือยัง ไปดูสิว่าใคร !!! ", MsgBoxStyle.YesNo)
            If m1 = MsgBoxResult.Yes Then
                MonthCalendar1.Enabled = False
                MonthCalendar1.Hide()
                txt_appoint.Enabled = True
                txt_appoint.Show()
                btnadd.Enabled = True
                btnadd.Show()
                btn_back.Enabled = True
                btn_back.Show()
                txt_appoint.Text = File.ReadAllText(t & ".txt")

            End If
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Me.SendToBack()
        TextBox1.Text = My.Settings.TextSave
        TextBox2.Text = My.Settings.TextSave2
        TextBox4.Text = My.Settings.TextSave3
        TextBox5.Text = My.Settings.TextSave4
        TextBox6.Text = My.Settings.TextSave5
        TextBox7.Text = My.Settings.TextSave6
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            My.Settings.TextSave = TextBox1.Text
        End If
    End Sub
    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            My.Settings.TextSave2 = TextBox2.Text
        End If
    End Sub
    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then
            My.Settings.TextSave3 = TextBox4.Text
        End If
    End Sub

    Private Sub TextBox5_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox5.KeyDown
        If e.KeyCode = Keys.Enter Then
            My.Settings.TextSave4 = TextBox5.Text
        End If
    End Sub
    Private Sub TextBox6_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox6.KeyDown
        If e.KeyCode = Keys.Enter Then
            My.Settings.TextSave5 = TextBox6.Text
        End If
    End Sub
    Private Sub TextBox7_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox7.KeyDown
        If e.KeyCode = Keys.Enter Then
            My.Settings.TextSave6 = TextBox7.Text
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ColorDialog1.ShowDialog()
        TextBox1.ForeColor = Me.ColorDialog1.Color
    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        t = MonthCalendar1.SelectionRange.Start.Month.ToString & MonthCalendar1.SelectionRange.Start.Day.ToString
        Try
            If File.Exists(t & ".txt") = True Then               
                MonthCalendar1.Enabled = False
                MonthCalendar1.Hide()
                txt_appoint.Enabled = True
                txt_appoint.Show()
                btnadd.Enabled = True
                btnadd.Show()
                btn_back.Enabled = True
                btn_back.Show()
                txt_appoint.Text = File.ReadAllText(t & ".txt")

            Else
                m = MsgBox("ดีมากเข้าทำการนัดหมายโทรหาลูกค้า", MsgBoxStyle.YesNo)
                If m = MsgBoxResult.Yes Then
                    MonthCalendar1.Enabled = False
                    MonthCalendar1.Hide()
                    txt_appoint.Enabled = True
                    txt_appoint.Show()
                    txt_appoint.Text = ""
                    btnadd.Enabled = True
                    btnadd.Show()
                    btn_back.Enabled = True
                    btn_back.Show()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        txt_appoint.Enabled = False
        txt_appoint.Hide()
        btnadd.Enabled = False
        btnadd.Hide()
        btn_back.Enabled = False
        btn_back.Hide()
        MonthCalendar1.Enabled = True
        MonthCalendar1.Show()
    End Sub

    Private Sub Btn_close_Click(sender As Object, e As EventArgs) Handles Btn_close.Click
        Me.Close()

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If txt_appoint.Text = "" Then
            If File.Exists(t & ".txt") = True Then
                File.Delete(t & ".txt")
            End If
        End If
        If txt_appoint.Text.Length > 0 Then
            File.WriteAllText(t & ".txt", txt_appoint.Text)
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '  currenttime = TimeOfDay.ToString("hh:mm:ss tt")
        ' lbl_timealam.Text = currenttime
        lbl_timealam.Text = TimeOfDay.ToString("hh:mm")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        messagetime = txt_maskbox.Text + ""
        lbl_timeset.Text = "จะระเบิดตัวเองในเวลา: " + messagetime

        '  If currenttime = messagetime Then
        If lbl_timealam.Text = messagetime Then
            Timer2.Stop()
            MsgBox(txt_messageboxtimer.Text)
            btn_start.Enabled = True
            btn_stop.Enabled = False
            lbl_timeset.Text = ""
        End If

    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        Timer2.Start()
        btn_start.Enabled = False
        btn_stop.Enabled = True
    End Sub

    Private Sub btn_stop_Click(sender As Object, e As EventArgs) Handles btn_stop.Click
        Timer2.Stop()
        btn_start.Enabled = True
        btn_stop.Enabled = False
        lbl_timeset.Text = ""
    End Sub

    Private Sub btn_noti_Click(sender As Object, e As EventArgs) Handles btn_noti.Click
        NotifyIcon1.Visible = True
        Me.Hide()
        NotifyIcon1.ShowBalloonTip(3000)

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        NotifyIcon1.Visible = False
    End Sub

   
End Class