Imports System.Data
Imports System.Data.SqlClient
Public Class détail_commandes
    Public num_article As Integer
    Public Pu As Double
    Public designation As String
    Public qte As Integer
    Public remarques As String
    Public ref_produit As Integer
    Public num_commande As Integer
    Public exercice As String
    Public Sub New()

    End Sub
    Public Sub New(ByVal na As Integer, ByVal p As Double, ByVal d As String, ByVal q As Integer, ByVal r As String, ByVal rp As Integer, ByVal nc As Integer, ByVal e As String)
        num_article = na
        Pu = p
        designation = d
        qte = q
        remarques = r
        ref_produit = rp
        num_commande = nc
        exercice = e


    End Sub
    Public Property _exercice() As String
        Get
            Return exercice
        End Get
        Set(ByVal value As String)
            exercice = value
        End Set
    End Property

    Public Property _num_commande() As Integer
        Get
            Return num_commande
        End Get
        Set(ByVal value As Integer)
            num_commande = value
        End Set
    End Property
    Public Property _ref_produit() As Integer
        Get
            Return ref_produit
        End Get
        Set(ByVal value As Integer)
            ref_produit = value
        End Set
    End Property

    Public Property _remarques() As String
        Get
            Return remarques
        End Get
        Set(ByVal value As String)
            remarques = value
        End Set
    End Property


    Public Property _qte() As Integer
        Get
            Return qte
        End Get
        Set(ByVal value As Integer)
            qte = value
        End Set
    End Property

    Public Property _designation() As String
        Get
            Return designation
        End Get
        Set(ByVal value As String)
            designation = value
        End Set
    End Property


    Public Property _Pu() As Double
        Get
            Return Pu
        End Get
        Set(ByVal value As Double)
            Pu = value
        End Set
    End Property
    Public Property _num_article() As Integer
        Get
            Return num_article
        End Get
        Set(ByVal value As Integer)
            num_article = value
        End Set
    End Property

End Class
