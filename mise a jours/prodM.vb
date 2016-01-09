Imports System.Data.SqlClient
Public Class prodM

    Public Shared Sub ajouter(ByVal pr As prod)
        Dim req As String = "insert into produit values(" & pr.ref_produit & ",'" & pr.catégorie & "','" & pr.produit & "')"
        connexion.executer(req)
    End Sub

    Public Shared Sub supprimer(ByVal code As Integer)
        Dim req As String = "delete from produit where ref_produit=" & code
        connexion.executer(req)
    End Sub
    Public Shared Sub modifier(ByVal pr As prod)
        Dim req As String = "update produit set  categorie='" & pr.catégorie & "'  ,produit='" & pr.produit & "' where ref_produit=" & pr.ref_produit
        connexion.executer(req)
    End Sub
    Public Shared Function rechercher(ByVal condition As String) As DataTable
        Dim req As String = "select * from produit where " & condition

        Dim dtr As SqlDataReader = connexion.extract(req)
        Dim dt As New DataTable
        dt.Load(dtr)
        Return dt
    End Function
End Class

