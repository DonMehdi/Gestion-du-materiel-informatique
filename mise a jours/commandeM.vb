Imports System.Data
Imports System.Data.SqlClient

Public Class commandeM 'classe de function qu on peut utiliser de n importe quel emlacement
    Public Shared Sub ajouter(ByVal C As commandes)
        Dim req As String = "insert into marcheBC values(" & C.N_mar_BC & ",'" & C.exercice & "','" & C.observation & "','" & C.montant & "'," & C.code_fournisseur & ",'" & C.typebudget & "','" & C.rubrique & "','" & C.nature_de_credit & "','" & C.objectif_depense & "','" & C.nature_prestation & "'," & C.ligne & "," & C.paragraphe & "," & C.chapitre & ",'" & C.region & "')"
        connexion.executer(req)
    End Sub
    Public Shared Sub supprimer(ByVal code As Integer)
        Dim req As String = " delete  from marcheBC where N_mar_BC=" & code
        connexion.executer(req)
    End Sub
    Public Shared Sub modifier(ByVal c As commandes)
        Dim req As String = "update marcheBC set  exercice='" & c.exercice & "'  ,observation='" & c.observation & "',montant='" & c.montant & "',code_fournisseur=" & c.code_fournisseur & ",typebudget='" & c.typebudget & "',rubrique='" & c.rubrique & "',nature_de_credit='" & c.nature_de_credit & "',objectif_depense='" & c.objectif_depense & "',nature_prestation='" & c.nature_prestation & "',ligne=" & c.ligne & ",paragraphe=" & c.paragraphe & ",chapitre=" & c.chapitre & ",region='" & c.region & "' where N_mar_BC=" & c.N_mar_BC
        connexion.executer(req)
    End Sub
    Public Shared Function rechercher(ByVal condition As String) As DataTable
        Dim req As String = "select * from marcheBC where " & condition

        Dim dtr As SqlDataReader = connexion.extract(req)
        Dim dt As New DataTable
        dt.Load(dtr) 'Remplit un DataTable avec des valeurs issues d'une source de données à l'aide du IDataReader(dtr) fourni. Si DataTable contient déjà des lignes, les données entrantes à partir de la source de données sont fusionnées avec les lignes existantes.
        'Pris en charge par le .NET Compact Framework.
        Return dt

        ' Dim Connexion As New SqlConnection("Data Source=localhost;Initial Catalog=SDZ;User Id=sa;Password=********;")
        ' cette ligne sitduzer
        '  Try
        'Connexion.Open()
        '
        'Dim Requete As String = "SELECT * from Musiques"
        'Dim Commande As New SqlCommand(Requete, Connexion)
        'Dim Adaptateur As New SqlDataAdapter(Commande)
        'Dim MonDataSet As New DataSet
        'Try
        'Adaptateur.Fill(MonDataSet, "Musiques")

        'Liaison avec le DataGrid

        'Catch ex As Exception
        'Console.WriteLine(ex.Message)
        'End Try

        'Catch ex As Exception
        'Console.WriteLine(ex.Message)
        'End Try
    End Function
End Class