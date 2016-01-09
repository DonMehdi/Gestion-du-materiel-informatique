Imports System.Data.SqlClient
Public Class natservicseM
    Public Shared Sub ajouter(ByVal nt As nature_services)
        Dim req As String = "insert into natservice values(" & nt.cdenatserv & ",'" & nt.servicesfr & "','" & nt.servicesar & "')"
        connexion.executer(req)
    End Sub

    Public Shared Sub supprimer(ByVal code As Integer)
        Dim req As String = "delete from natservice where cdenatserv=" & code
        connexion.executer(req)
    End Sub
    Public Shared Sub modifier(ByVal nt As nature_services)
        Dim req As String = "update natservice set  servicesfr='" & nt.servicesfr & "'  ,servicesar='" & nt.servicesar & "' where cdenatserv=" & nt.cdenatserv
        connexion.executer(req)
    End Sub
    Public Shared Function rechercher(ByVal condition As String) As DataTable
        Dim req As String = "select * from natservice where " & condition

        Dim dtr As SqlDataReader = connexion.extract(req)
        Dim dt As New DataTable
        dt.Load(dtr)
        Return dt
    End Function

End Class
