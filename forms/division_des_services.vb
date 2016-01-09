Imports System.Data.SqlClient
Public Class Btn_annuler
    Private Sub ActualiserGrid()
        dgv1.DataSource = divserviceM.rechercher("1=1")
    End Sub
    Public Sub vider()
        Tcdedivserv.Clear()
        tdivservfr.Clear()
        tdivservar.Clear()
        tdivservcourt.Clear()
        tdivservabar.Clear()
        tdivservabfr.Clear()
    End Sub
    Public Sub verification()
        If Tcdedivserv.Text = "" Then
            ErrorProvider1.SetError(Tcdedivserv, "entrez le code")
        ElseIf Not IsNumeric(Tcdedivserv.Text) Then
            ErrorProvider1.SetError(Tcdedivserv, "entrez un nombre")
        Else
            ErrorProvider1.SetError(Tcdedivserv, Nothing)
        End If
        If tdivservabar.Text = "" Then
            ErrorProvider1.SetError(tdivservabar, "entrez la divservabar")
        Else
            ErrorProvider1.SetError(tdivservabar, Nothing)
        End If
        If tdivservabfr.Text = "" Then
            ErrorProvider1.SetError(tdivservabfr, "entrez la divservabfr")
        Else
            ErrorProvider1.SetError(tdivservabfr, Nothing)
        End If
        If tdivservar.Text = "" Then
            ErrorProvider1.SetError(tdivservar, "entrez la divservar")
        Else
            ErrorProvider1.SetError(tdivservar, Nothing)
        End If
        If tdivservcourt.Text = "" Then
            ErrorProvider1.SetError(tdivservcourt, "entrez la divservcourt")
        Else
            ErrorProvider1.SetError(tdivservcourt, Nothing)
        End If
        If tdivservfr.Text = "" Then
            ErrorProvider1.SetError(tdivservfr, "entrez la divservfr")
        Else
            ErrorProvider1.SetError(tdivservfr, Nothing)
        End If
    End Sub
    Private Sub bajouter_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bajouter.Click
        Try
            If MsgBox("vouler vous vraiment ajouter", 1 + 32, "confirmation") = MsgBoxResult.Ok Then
                verification()
                If Tcdedivserv.Text = "" Or tdivservabar.Text = "" Or tdivservabfr.Text = "" Or tdivservar.Text = "" Or tdivservcourt.Text = "" Or tdivservfr.Text = "" Then
                    MsgBox("veuillez remplire tout les champs")
                Else
                    Dim ds As New dvservices(CInt(Tcdedivserv.Text), CInt(ccdenatserv.Text), tdivservfr.Text, tdivservar.Text, tdivservcourt.Text, tdivservabar.Text, tdivservabfr.Text)
                    divserviceM.ajouter(ds)
                    vider()
                    My_Message_Boxe.Label_Ajouter.Visible = True
                    My_Message_Boxe.label_Modifier.Visible = False
                    My_Message_Boxe.Label1.Visible = False
                    My_Message_Boxe.Picture_ajouter.Visible = True
                    My_Message_Boxe.Picture_modifier.Visible = False
                    My_Message_Boxe.Picture_supp.Visible = False
                    My_Message_Boxe.Show()
                    ActualiserGrid()
                    Tcdedivserv.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub bmodifier_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bmodifier.Click
        Try
            If MsgBox("vouler vous vraiment modifier", 1 + 32, "confirmation") = MsgBoxResult.Ok Then
                verification()
                If Tcdedivserv.Text = "" Or tdivservabar.Text = "" Or tdivservabfr.Text = "" Or tdivservar.Text = "" Or tdivservcourt.Text = "" Or tdivservfr.Text = "" Then
                    MsgBox("veuillez remplire tout les champs")
                Else
                    Dim ds As New dvservices(CInt(Tcdedivserv.Text), CInt(ccdenatserv.Text), tdivservfr.Text, tdivservar.Text, tdivservcourt.Text, tdivservabar.Text, tdivservabfr.Text)

                    divserviceM.modifier(ds)
                    vider()
                    My_Message_Boxe.Label_Ajouter.Visible = False
                    My_Message_Boxe.label_Modifier.Visible = True
                    My_Message_Boxe.Label1.Visible = False
                    My_Message_Boxe.Picture_ajouter.Visible = False
                    My_Message_Boxe.Picture_modifier.Visible = True
                    My_Message_Boxe.Picture_supp.Visible = False
                    My_Message_Boxe.Show()
                    ActualiserGrid()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
   
    Private Sub bsupprimer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsupprimer.Click
        Try
            If MsgBox("vouler vous vraiment suprimer", 1 + 32, "confirmation") = MsgBoxResult.Ok Then
                divserviceM.supprimer(CInt(Tcdedivserv.Text))
                vider()
                My_Message_Boxe.Label_Ajouter.Visible = False
                My_Message_Boxe.label_Modifier.Visible = False
                My_Message_Boxe.Label1.Visible = True
                My_Message_Boxe.Picture_ajouter.Visible = False
                My_Message_Boxe.Picture_modifier.Visible = False
                My_Message_Boxe.Picture_supp.Visible = True
                My_Message_Boxe.Show()
                ActualiserGrid()
                Tcdedivserv.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub trechercher_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles trechercher.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un numero ¡¡¡¡")
        End If
    End Sub

    Private Sub trechercher_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trechercher.TextChanged
        Dim condition As String = "1=1"

        If trechercher.Text <> "" Then
            condition = "cdedivserv=" & trechercher.Text
        Else
            condition = "1=1"
        End If


        dgv1.DataSource = divserviceM.rechercher(condition)
    End Sub

    Private Sub division_des_services_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualiserGrid()

        Dim req As String = "select * from natservice  "

        Dim dr As SqlDataReader = connexion.extract(req)


        If dr.HasRows Then
            While dr.Read
                ccdenatserv.Items.Add(dr(0))
            End While

        End If
        dr.Close()
    End Sub

    Private Sub Tcdedivserv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tcdedivserv.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un numero ¡¡¡¡")
        End If
    End Sub

    Private Sub tdivservfr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdivservfr.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub

    Private Sub tdivservabfr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdivservabfr.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub

    Private Sub tdivservcourt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdivservcourt.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub

    Private Sub tdivservar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdivservar.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub

    Private Sub tdivservabar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdivservabar.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Left += 1
        If Label1.Location.X = 1234 Then
            Label1.Top = 10
            Label1.Left = 0
        End If
    End Sub
    Private Sub Btn_Vider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Vider.Click
        vider()
        Tcdedivserv.Focus()
    End Sub

  
   
   
    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class