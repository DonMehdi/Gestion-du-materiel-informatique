Imports System.Data.SqlClient
Imports System.Data
Public Class detailM
    Public Shared Sub ajouter(ByVal dc As détail_commandes)
        Dim req As String = "insert into detailmarcheBC values(" & dc.num_article & "," & dc.Pu & ",'" & dc.designation & "'," & dc.qte & ",'" & dc.remarques & "'," & dc.ref_produit & "," & dc.num_commande & ",'" & dc.exercice & "')"
        connexion.executer(req)
    End Sub
    Public Shared Sub supprimer(ByVal code As Integer)
        Dim req As String = "delete from detailmarcheBC where num_article=" & code
        connexion.executer(req)
    End Sub
    Public Shared Sub Modifier(ByVal dc As détail_commandes)
        Dim res As String = "update detailmarcheBC set  Pu=" & dc.Pu & "  ,designation='" & dc.designation & "',qte=" & dc.qte & ",remarques='" & dc.remarques & "',ref_produit=" & dc.ref_produit & ",n_mar_BC=" & dc.num_commande & ", exercice= '" & dc.exercice & "'  where num_article=" & dc.num_article
        connexion.executer(res)
    End Sub
    'Public Shared Function rechercher(ByVal condition As String) As DataTable
    '    Dim req As String = "select * from detailmarcheBC where " & condition
    '    Dim dtr As SqlDataReader = connexion.extract(req)
    '    Dim dt As New DataTable
    '    dt.Load(dtr)
    '    Return dt
    'End Function
    Public Shared Function rechercher(ByVal condition As String) As DataTable
        Dim req As String = "select * from detailmarcheBC where " & condition
        Dim dtr As SqlDataReader = connexion.extract(req)
        Dim dt As New DataTable
        dt.Load(dtr)
        Return dt
    End Function

End Class
