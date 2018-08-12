
Public Class frm_search	
    Private Sub Load_frmSelldeil_IntoPanel()
        Pnlmain.Controls.Clear()
        Dim frm_Selldeil As New frm_Selldeil()
        '  frm_Selldeil.Size = Pnlmain.Size
        frm_Selldeil.TopLevel = False
        frm_Selldeil.Parent = Pnlmain
        frm_Selldeil.Show()
    End Sub
    Private Sub Load_frmcustomer_IntoPanal()
        Pnlmain.Controls.Clear()
        Dim frm_Selldeil As New frm_customer()
        '  frm_Selldeil.Size = Pnlmain.Size
        frm_Selldeil.TopLevel = False
        frm_Selldeil.Parent = Pnlmain
        frm_Selldeil.Show()
    End Sub
    Private Sub Load_frmnote_IntoPanal()
        Pnlmain.Controls.Clear()
        Dim frm_Selldeil As New frm_note()
        ' frm_note.Size = Pnlmain.Size
        frm_Selldeil.TopLevel = False
        frm_Selldeil.Parent = Pnlmain
        frm_Selldeil.Show()
    End Sub
    Private Sub Load_frminvertory_IntoPanal()
        Pnlmain.Controls.Clear()
        Dim frm_Selldeil As New frm_invertory()
        ' frm_note.Size = Pnlmain.Size
        frm_Selldeil.TopLevel = False
        frm_Selldeil.Parent = Pnlmain
        frm_Selldeil.Show()
    End Sub
    Private Sub Load_frmstaffparty_IntoPanal()
        Pnlmain.Controls.Clear()
        Dim frm_Selldeil As New frm_staffparty()
        ' frm_Selldeil.Size = Pnlmain.Size
        frm_Selldeil.TopLevel = False
        frm_Selldeil.Parent = Pnlmain
        frm_Selldeil.Show()
    End Sub
    Private Sub Load_adfrm1order_IntoPanal()
        Pnlmain.Controls.Clear()
        Dim frm_Selldeil As New adfrm1_order()
        ' frm_Selldeil.Size = Pnlmain.Size
        frm_Selldeil.TopLevel = False
        frm_Selldeil.Parent = Pnlmain
        frm_Selldeil.Show()
    End Sub
    Private Sub Load_frmsearch_IntoPanal()
        Pnlmain.Controls.Clear()
        Dim frm_Selldeil As New frm_search()
        frm_Selldeil.Size = Pnlmain.Size
        frm_Selldeil.TopLevel = True
        '   frm_Selldeil.Parent = Pnlmain
        Pnlmain.Show()
    End Sub
  
     
    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click
        Shell("C:\WINDOWS\system32\calc")
    End Sub
    Private Sub btnNotepad_Click(sender As Object, e As EventArgs) Handles btnNotepad.Click
        ' Load_frmstaffparty_IntoPanal()
        Load_frmnote_IntoPanal()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub btnBed_Click(sender As Object, e As EventArgs) Handles btn_orderfrm.Click
      
        Load_frmSelldeil_IntoPanel()
    End Sub

    Private Sub frm_search_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'frmMain       '
            ' Me.ClientSize = New System.Drawing.Size(870, 800)
            ' Me.MaximizeBox = False
            '  Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SIEW"


    End Sub
    Private Sub btn_openmainmenu_Click(sender As Object, e As EventArgs) Handles btn_openmainmenu.Click
        Load_frmsearch_IntoPanal()
    End Sub

    Private Sub Btn_openloginClick_Click(sender As Object, e As EventArgs) Handles btn_openlogin.Click

        frm_login.show()

    End Sub


    Private Sub txt_po_Click(sender As Object, e As EventArgs) Handles txt_po.Click
        Load_adfrm1order_IntoPanal()
        ' adfrm1_order.Show()

    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        Load_frmcustomer_IntoPanal()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ' lbldate.Text = Format(Now, "long date")
        lbl_timeofday.Text = TimeOfDay

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        frm_login.Show()
        With frm_login
            .txt_namestaff.Text = ""
            .txt_passstaff.Text = ""

        End With
    End Sub


    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        Load_frmstaffparty_IntoPanal()
    End Sub

   

    Private Sub btn_stock_Click(sender As Object, e As EventArgs) Handles btn_stock.Click
        Load_frminvertory_IntoPanal()
    End Sub

End Class