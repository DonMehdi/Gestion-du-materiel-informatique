Imports System.Data.SqlClient
Public Class connexion
    Private Shared con As New SqlConnection("Data Source=localhost;Initial Catalog=g_materiel;User Id=sa;Password=m;")

    Public Shared Sub executer(ByVal req As String)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand(req, con)
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Public Shared Function extract(ByVal req As String) As SqlDataReader
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim cmd As New SqlCommand(req, con)
        Dim dtr As SqlDataReader = cmd.ExecuteReader

        Return dtr 'il prepare le dtreader 3la 7ssab la requette

        con.Close()
    End Function





End Class
