Imports System.Data.SqlClient
Public Class budgetM



    Public Shared Sub ajouter(ByVal bd As typebudgets)
        Dim req As String = "insert into type_budge values(" & bd.num & ",'" & bd.typebuget & "','" & bd.typee & "','" & bd.budget & "')"
        connexion.executer(req)
    End Sub
    Public Shared Sub supprimer(ByVal code As Integer)
        Dim req As String = "delete from type_budge where num=" & code
        connexion.executer(req)
    End Sub
    Public Shared Sub modifier(ByVal bd As typebudgets)
        Dim req As String = "update type_budge set  typebudget='" & bd.typebuget & "'  ,typee='" & bd.typee & "',budget='" & bd.budget & "' where num=" & bd.num
        connexion.executer(req)
    End Sub
    Public Shared Function rechercher(ByVal condition As String) As DataTable
        Dim req As String = "select * from type_budge where " & condition

        Dim dtr As SqlDataReader = connexion.extract(req)
        Dim datb As New DataTable
        datb.Load(dtr)
        Return datb
    End Function
End Class
