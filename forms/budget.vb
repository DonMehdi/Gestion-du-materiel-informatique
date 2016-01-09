Imports System.Data
Imports System.Data.SqlClient
Public Class budget
    Public Sub vider()
        txt_num_budget.Clear()
        Ttypebuget.Clear()
        ttype.Clear()
        tbudget.Clear()
    End Sub
    Public Sub verification()
        If txt_num_budget.Text = "" Then
            ErrorProvider1.SetError(txt_num_budget, "entrez le numero de budget")
        Else
            ErrorProvider1.SetError(txt_num_budget, Nothing)
        End If
        If Ttypebuget.Text = "" Then
            ErrorProvider1.SetError(Ttypebuget, "entrez le type budget")
        Else
            ErrorProvider1.SetError(Ttypebuget, Nothing)
        End If
        If ttype.Text = "" Then
            ErrorProvider1.SetError(ttype, "entrez le type ")
        Else
            ErrorProvider1.SetError(ttype, Nothing)
        End If
        If tbudget.Text = "" Then
            ErrorProvider1.SetError(tbudget, "entrez le  budget")
        Else
            ErrorProvider1.SetError(tbudget, Nothing)
        End If
    End Sub
    Private Sub ActualiserGrid()
        dgv1.DataSource = budgetM.rechercher("1=1")
    End Sub
    Private Sub trechercher_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles trechercher.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un numero ¡¡¡¡")
        End If
    End Sub
    Private Sub trechercher_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trechercher.TextChanged
        Dim condition As String = "1=1"
        If trechercher.Text <> "" Then
            condition = "num=" & trechercher.Text
        Else
            condition = "1=1"
        End If
        dgv1.DataSource = budgetM.rechercher(condition)
    End Sub

    Private Sub Tnbudget_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un numero ¡¡¡¡")
        End If
    End Sub

    Private Sub Ttypebuget_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Ttypebuget.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub

    Private Sub ttype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ttype.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub

    Private Sub tbudget_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbudget.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub

    ' Private Sub btn_parcouri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '.ShowDialog()
    'TextBox1.Text = OpenFileDialog1.FileName
    'End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label5.Left += 1
        If Label5.Location.X = 1234 Then
            Label5.Top = 10
            Label5.Left = 0
        End If
    End Sub
    Private Sub Bmodifier_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bmodifier.Click
        Try
            If MsgBox("vouler vous vraiment modifier", 1 + 32, "confirmation") = MsgBoxResult.Ok Then
                verification()
                If txt_num_budget.Text = "" Or Ttypebuget.Text = "" Or ttype.Text = "" Or tbudget.Text = "" Then
                    MsgBox("veuillez remplire tout les champs")
                Else
                    Dim bd As New typebudgets(CInt(txt_num_budget.Text), Ttypebuget.Text, ttype.Text, tbudget.Text)
                    budgetM.modifier(bd)
                    vider()
                    My_Message_Boxe.Label_Ajouter.Visible = False
                    My_Message_Boxe.label_Modifier.Visible = True
                    My_Message_Boxe.Label1.Visible = False
                    My_Message_Boxe.Picture_ajouter.Visible = False
                    My_Message_Boxe.Picture_modifier.Visible = True
                    My_Message_Boxe.Picture_supp.Visible = False
                    My_Message_Boxe.Show()
                    'MsgBox("modification avec succés", 0 + 48, "mise à jours")
                    ActualiserGrid()
                    txt_num_budget.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Bajouter_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bajouter.Click
        Try
            If MsgBox("vouler vous vraiment ajouter", 1 + 32, "confirmation") = MsgBoxResult.Ok Then
                verification()
                If txt_num_budget.Text = "" Or Ttypebuget.Text = "" Or ttype.Text = "" Or tbudget.Text = "" Then
                    MsgBox("veuillez remplire tout les champs")
                Else
                    Dim bd As New typebudgets(CInt(txt_num_budget.Text), Ttypebuget.Text, ttype.Text, tbudget.Text)
                    budgetM.ajouter(bd)
                    vider()
                    My_Message_Boxe.Label_Ajouter.Visible = True
                    My_Message_Boxe.label_Modifier.Visible = False
                    My_Message_Boxe.Label1.Visible = False
                    My_Message_Boxe.Picture_ajouter.Visible = True
                    My_Message_Boxe.Picture_modifier.Visible = False
                    My_Message_Boxe.Picture_supp.Visible = False
                    'MsgBox("ajout avec succés", 0 + 64, "mise à jours")
                    My_Message_Boxe.Show()
                    ActualiserGrid()
                    txt_num_budget.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Bsupprimer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsupprimer.Click
        Try
            If MsgBox("vouler vous vraiment suprimer", 1 + 32, "confirmation") = MsgBoxResult.Ok Then
                budgetM.supprimer(CInt(txt_num_budget.Text))
                vider()
                My_Message_Boxe.Label_Ajouter.Visible = False
                My_Message_Boxe.label_Modifier.Visible = False
                My_Message_Boxe.Label1.Visible = True
                My_Message_Boxe.Picture_ajouter.Visible = False
                My_Message_Boxe.Picture_modifier.Visible = False
                My_Message_Boxe.Picture_supp.Visible = True
                My_Message_Boxe.Show()
                'MsgBox("superssion avec succés", 0 + 64, "mise à jours")
                ActualiserGrid()
                txt_num_budget.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_annuler_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_annuler.Click
        vider()
        txt_num_budget.Focus()
    End Sub

    Private Sub budget_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class