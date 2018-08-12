<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_crytalview
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
        Me.crytal = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crytal
        '
        Me.crytal.ActiveViewIndex = -1
        Me.crytal.AutoSize = True
        Me.crytal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crytal.Cursor = System.Windows.Forms.Cursors.Default
        Me.crytal.Location = New System.Drawing.Point(0, -1)
        Me.crytal.Name = "crytal"
        Me.crytal.Size = New System.Drawing.Size(895, 1000)
        Me.crytal.TabIndex = 1
        Me.crytal.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frm_crytalview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 999)
        Me.Controls.Add(Me.crytal)
        Me.Name = "frm_crytalview"
        Me.Text = "frm_crytalview"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents crytal As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
