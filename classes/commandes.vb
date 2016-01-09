Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Public Class commandes
    Public N_mar_BC As Integer
    Public exercice As String
    Public observation As String
    Public montant As Double
    Public code_fournisseur As Integer
    Public typebudget As String
    Public nature_de_credit As String
    Public objectif_depense As String
    Public nature_prestation As String
    Public ligne As Integer
    Public paragraphe As Integer
    Public chapitre As Integer
    Public region As String
    Public rubrique As String
    Public Sub New()

    End Sub
    Public Sub New(ByVal N_mar_BC As Integer, ByVal exercice As String, ByVal observation As String, ByVal montant As Double, ByVal code_fournisseur As Integer, ByVal typebudget As String, ByVal rubrique As String, ByVal nature_de_credit As String, ByVal objectif_depense As String, ByVal nature_prestation As String, ByVal ligne As Integer, ByVal paragraphe As Integer, ByVal chapitre As Integer, ByVal region As String)
        _N_mar_BC = N_mar_BC
        _exercice = exercice
        _observation = observation
        _montant = montant
        _code_fournisseur = code_fournisseur
        _typebudget = typebudget
        _rubrique = rubrique
        _nature_de_credit = nature_de_credit
        _objectif_depense = objectif_depense
        _nature_prestation = nature_prestation
        _ligne = ligne
        _paragraphe = paragraphe
        _chapitre = chapitre
        _region = region
    End Sub

    Public Property _N_mar_BC() As Integer
        Get
            Return N_mar_BC
        End Get
        Set(ByVal value As Integer)
            N_mar_BC = value
        End Set
    End Property
    Public Property _code_fournisseur() As Integer
        Get
            Return code_fournisseur
        End Get
        Set(ByVal value As Integer)
            code_fournisseur = value
        End Set
    End Property
    Public Property _ligne() As Integer
        Get
            Return ligne
        End Get
        Set(ByVal value As Integer)
            ligne = value
        End Set
    End Property
    Public Property _paragraphe() As Integer
        Get
            Return paragraphe
        End Get
        Set(ByVal value As Integer)
            paragraphe = value
        End Set
    End Property
    Public Property _chapitre() As Integer
        Get
            Return chapitre
        End Get
        Set(ByVal value As Integer)
            chapitre = value
        End Set
    End Property
    Public Property _exercice() As String
        Get
            Return exercice
        End Get
        Set(ByVal value As String)
            exercice = value
        End Set
    End Property
    Public Property _observation() As String
        Get
            Return observation
        End Get
        Set(ByVal value As String)
            observation = value
        End Set
    End Property
    Public Property _montant() As Double
        Get
            Return montant
        End Get
        Set(ByVal value As Double)
            montant = value
        End Set
    End Property
    Public Property _typebudget() As String
        Get
            Return typebudget
        End Get
        Set(ByVal value As String)
            typebudget = value
        End Set
    End Property
    Public Property _rubrique() As String
        Get
            Return rubrique
        End Get
        Set(ByVal value As String)
            rubrique = value
        End Set
    End Property
    Public Property _nature_de_credit() As String
        Get
            Return nature_de_credit
        End Get
        Set(ByVal value As String)
            nature_de_credit = value
        End Set
    End Property
    Public Property _objectif_depense() As String
        Get
            Return objectif_depense
        End Get
        Set(ByVal value As String)
            objectif_depense = value
        End Set
    End Property
    Public Property _nature_prestation() As String
        Get
            Return nature_prestation
        End Get
        Set(ByVal value As String)
            nature_prestation = value
        End Set
    End Property
    Public Property _region() As String
        Get
            Return region
        End Get
        Set(ByVal value As String)
            region = value
        End Set
    End Property


End Class
