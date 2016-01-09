Imports System.Windows.Forms
Imports System.Drawing.Drawing2D

Public Class My_Message_Boxe
    Dim p, p1 As Point
    Dim j As Integer
    Dim g As New GraphicsPath
    Dim r As Rectangle

#Region "Animation Message boxe"
    Private Sub type_message_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        r = New Rectangle(0, 0, 0, 0)
        g.AddRectangle(r)
        Me.Region = New Region(r)
        p = New Point(My.Computer.Screen.Bounds.Size.Width - (Me.Width + 15), My.Computer.Screen.Bounds.Size.Height - Me.Height - 45)
        p1 = New Point(0, Me.Height)
        Me.Location = p
        Me.cadre.Location = p1
        Me.depart.Start()
        Me.depart.Interval = 1
        Me.mileu.Interval = 150
        Me.fin.Interval = 20
        'If muet = False Then
        '    If File.Exists(Application.StartupPath & "\sound\Chime_Mac.wav") Then
        '        My.Computer.Audio.Play(Application.StartupPath & "\sound\Chime_Mac.wav")
        '    End If
        'End If
    End Sub
    Private Sub depart_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles depart.Tick
        Me.cadre.Location = p1
        r = New Rectangle(0, p1.Y, Me.cadre.Width, Me.Height)
        g.AddRectangle(r)
        Me.Region = New Region(r)
        If p1.Y <= 0 Then
            Me.depart.Stop()
            Me.mileu.Start()

        End If
        p1.Y -= 5
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Picture_supp.Click
        Me.Close()
    End Sub

    Private Sub mileu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mileu.Tick
        'If Me.TopMost Then
        '    Me.TopMost = False
        'End If
        If j = 10 Then
            Me.mileu.Stop()
            Me.fin.Start()

        End If
        j += 1
    End Sub

    Private Sub fin_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fin.Tick
        Me.cadre.Location = p1
        r = New Rectangle(0, p1.Y, Me.cadre.Width, Me.Height)
        g.AddRectangle(r)
        Me.Region = New Region(r)
        If p1.Y >= Me.Height Then
            Me.fin.Stop()
            Me.Close()
        End If
        p1.Y += 5
    End Sub

    Private Sub cadre_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles cadre.Paint
        Dim brush As New LinearGradientBrush(New RectangleF(1.0F, 0, Me.Width, Me.Height - 20), Color.Black, Color.LightGray, LinearGradientMode.BackwardDiagonal)
        e.Graphics.FillRectangle(brush, New RectangleF(1.0F, 0, Me.Width, Me.Height))
    End Sub
    Protected Friend Sub imageChanged(ByVal serial As Int16)
        If serial = 1 Or serial = 2 Then
            Me.PictureBox3.Image = Me.ImageList1.Images(0)
        End If
        If serial = 3 Then
            Me.PictureBox3.Image = Me.ImageList1.Images(1)
        End If
        If serial = 4 Or serial = 5 Then
            Me.PictureBox3.Image = Me.ImageList1.Images(2)
        End If
        If serial = 6 Then
            Me.PictureBox3.Image = Me.ImageList1.Images(3)
        End If
        If serial = 7 Then
            Me.PictureBox3.Image = Me.ImageList1.Images(4)
        End If
        If serial = 8 Or serial = 9 Then
            Me.PictureBox3.Image = Me.ImageList1.Images(5)
        End If
        If serial = 10 Then
            Me.PictureBox3.Image = Me.ImageList1.Images(6)
        End If
        If serial = 11 Or serial = 12 Then
            Me.PictureBox3.Image = Me.ImageList1.Images(7)
        End If
        If serial = 13 Or serial = 14 Then
            Me.PictureBox3.Image = Me.ImageList1.Images(8)
        End If
        If serial = 15 Then
            Me.PictureBox3.Image = Me.ImageList1.Images(9)
        End If
        If serial = 16 Then
            Me.PictureBox3.Image = Me.ImageList1.Images(10)
        End If
        If serial = 17 Then
            Me.PictureBox3.Image = Me.ImageList1.Images(11)
        End If
        If serial = 18 Then
            Me.PictureBox3.Image = Me.ImageList1.Images(12)
        End If
    End Sub
    Friend Sub visibleBox(ByVal message As String, ByVal serial As Int16)
        Me.Visible = True
        Me.label_Modifier.Text = message
        Me.imageChanged(serial)
    End Sub

#End Region  '***************** Animation Message boxe***********

    Private Sub My_Message_Boxe_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Picture_ajouter.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub label_Modifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles label_Modifier.Click

    End Sub
End Class