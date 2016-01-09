Imports System.Data.SqlClient

Public Class fournisseurM
    Public Shared Sub ajouter(ByVal fr As fournisseurs)
        Dim req As String = "insert into fournisseur values(" & fr.code_fournisseur & ",'" & fr.fournisseur & "','" & fr.fournisseurabr & "','" & fr.activite & "','" & fr.type_societe & "','" & fr.tel & "','" & fr.GSM & "','" & fr.fax & "','" & fr.interlocuteur & "','" & fr.patente & "','" & fr.adresse & "','" & fr.code_postale & "','" & fr.ville & "','" & fr.banque & "','" & fr.agence & "','" & fr.rip & "','" & fr.e_mail & "')"
        connexion.executer(req)
    End Sub
    Public Shared Sub supprimer(ByVal code As Integer)
        Dim req As String = "delete from fournisseur where code_fournisseur=" & code
        connexion.executer(req)
    End Sub
    Public Shared Sub modifier(ByVal fr As fournisseurs)
        Dim req As String = "update fournisseur set  fournisseur='" & fr.fournisseur & "'  ,fornisseurabr='" & fr.fournisseurabr & "',acivite='" & fr.activite & "',type_societe='" & fr.type_societe & "',tel='" & fr.tel & "',GSM='" & fr.GSM & "',fax='" & fr.fax & "',interlocuteur='" & fr.interlocuteur & "',patente='" & fr.patente & "',adresse='" & fr.adresse & "',code_postale='" & fr.code_postale & "',ville='" & fr.ville & "',banque='" & fr.banque & "',agence='" & fr.agence & "',Rib='" & fr.rip & "',e_mail='" & fr.e_mail & "' where code_fournisseur=" & fr.code_fournisseur
        connexion.executer(req)
    End Sub

    Public Shared Function rechercher(ByVal condition As String) As DataTable
        Dim req As String = "select * from fournisseur where " & condition

        Dim dtr As SqlDataReader = connexion.extract(req)
        Dim dt As New DataTable
        dt.Load(dtr)
        Return dt
    End Function
End Class
