Public Class prod

    Private _ref_produit As Integer

    Private _catégorie As String

    Private _produit As String
    Public Sub New()

    End Sub
    Public Sub New(ByVal r As Integer, ByVal c As String, ByVal p As String)
        _ref_produit = r
        _catégorie = c
        _produit = p

    End Sub
    Public Property produit() As String
        Get
            Return _produit
        End Get
        Set(ByVal value As String)
            _produit = value
        End Set
    End Property

    Public Property catégorie() As String
        Get
            Return _catégorie
        End Get
        Set(ByVal value As String)
            _catégorie = value
        End Set
    End Property

    Public Property ref_produit() As Integer
        Get
            Return _ref_produit
        End Get
        Set(ByVal value As Integer)
            _ref_produit = value
        End Set
    End Property


End Class
