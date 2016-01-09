Imports System.Data.SqlClient
Public Class divserviceM


    Public Shared Sub ajouter(ByVal ds As dvservices)
        Dim req As String = "insert into division_services values(" & ds.cdedivserv & "," & ds.cdenatserv & ",'" & ds.divservfr & "','" & ds.divservar & "','" & ds.divsrevcourt & "','" & ds.divservabar & "','" & ds.divservabfr & "')"
        connexion.executer(req)
    End Sub

    Public Shared Sub supprimer(ByVal code As Integer)
        Dim req As String = "delete from division_services where cdedivserv=" & code
        connexion.executer(req)
    End Sub
    Public Shared Sub modifier(ByVal ds As dvservices)
        Dim req As String = "update division_services set  cdenatserv='" & ds.cdenatserv & "'  ,divservfr='" & ds.divservfr & "',divservar='" & ds.divservar & "',divservcourt='" & ds.divsrevcourt & "',divservabar='" & ds.divservabar & "',divservabfr='" & ds.divservabfr & "' where cdedivserv=" & ds.cdedivserv
        connexion.executer(req)
    End Sub
    Public Shared Function rechercher(ByVal condition As String) As DataTable
        Dim req As String = "select * from division_services where " & condition

        Dim dtr As SqlDataReader = connexion.extract(req)
        Dim dt As New DataTable
        dt.Load(dtr)
        Return dt
    End Function



End Class
