Imports System.Data
Imports System.Data.SqlClient

Public Class inventaireM
    Public Shared Sub ajouter(ByVal inv As inventaires)
        Dim req As String = "insert into inventaire values(" & inv.num & ",convert(date,'" & inv.datea & "',105),'" & inv.historique & "','" & inv.exercice & "'," & inv.num_article & "," & inv.num_commande & "," & inv.cdedivserv & ",'" & inv.n_fact & "','" & inv.n_bl & "','" & inv.motirradiation & "',convert(date,'" & inv.dateradiation & "',105))"
        connexion.executer(req)
    End Sub
    Public Shared Sub supprimer(ByVal code As Integer)
        Dim req As String = "delete from inventaire where num_invantaire=" & code
        connexion.executer(req)
    End Sub
    Public Shared Sub modifier(ByVal inv As inventaires)
        Dim req As String = "update inventaire set  date_infectation='" & inv.datea & "'  ,historique='" & inv.historique & "',exercice='" & inv.exercice & "',num_article=" & inv.num_article & ",n_mar_BC=" & inv.num_commande & ",cdedivserv=" & inv.cdedivserv & ",n_fact='" & inv.n_fact & "',n_bl='" & inv.n_bl & "',motirradiation='" & inv.motirradiation & "',dateradiation='" & inv.dateradiation & "'  where num_invantaire=" & inv.num
        connexion.executer(req)
    End Sub
    Public Shared Function rechercher(ByVal condition As String) As DataTable
        Dim req As String = "select * from inventaire where " & condition

        Dim dtr As SqlDataReader = connexion.extract(req)
        Dim dt As New DataTable
        dt.Load(dtr)
        Return dt
    End Function

End Class
