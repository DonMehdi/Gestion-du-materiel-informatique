Public Class FrmApplication
   
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        FrmAide.Show()
    End Sub

    Private Sub FrmApplication_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("                    BIENVENU" & vbLf & "wa fen", MsgBoxStyle.DefaultButton1, "Bienvenu") 'vblf na9z star
    End Sub

    Private Sub ACTIVER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACTIVER.Click
        connecter.Show()
        Me.Hide()
    End Sub

    Private Sub DESACTIVER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DESACTIVER.Click
        Me.Close()
        'Application.Exit()
    End Sub
End Class