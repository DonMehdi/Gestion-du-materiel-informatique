Public Class inventaires

    Private _num As Integer

    Private _datea As String

    Private _historique As String

    Private _exercice As String

    Private _num_article As Integer

    Private _num_commande As Integer

    Private _cdedivserv As Integer

    Private _n_fact As Integer

    Private _n_bl As Integer

    Private _motirradiation As String

    Private _dateradiation As String
    Public Sub New()

    End Sub
    Public Sub New(ByVal ni As Integer, ByVal da As String, ByVal h As String, ByVal e As String, ByVal na As Integer, ByVal nc As Integer, ByVal cd As Integer, ByVal nf As Integer, ByVal nb As Integer, ByVal mr As String, ByVal dm As String)
        _num = ni
        _datea = da
        _historique = h
        _exercice = e
        _num_article = na
        _num_commande = nc
        _cdedivserv = cd
        _n_fact = nf
        _n_bl = nb
        _motirradiation = mr
        _dateradiation = dm
    End Sub
    Public Property dateradiation() As Date
        Get
            Return _dateradiation
        End Get
        Set(ByVal value As Date)
            _dateradiation = value
        End Set
    End Property

    Public Property motirradiation() As String
        Get
            Return _motirradiation
        End Get
        Set(ByVal value As String)
            _motirradiation = value
        End Set
    End Property

    Public Property n_bl() As Integer
        Get
            Return _n_bl
        End Get
        Set(ByVal value As Integer)
            _n_bl = value
        End Set
    End Property

    Public Property n_fact() As Integer
        Get
            Return _n_fact
        End Get
        Set(ByVal value As Integer)
            _n_fact = value
        End Set
    End Property

    Public Property cdedivserv() As Integer
        Get
            Return _cdedivserv
        End Get
        Set(ByVal value As Integer)
            _cdedivserv = value
        End Set
    End Property


    Public Property num_commande() As Integer
        Get
            Return _num_commande
        End Get
        Set(ByVal value As Integer)
            _num_commande = value
        End Set
    End Property


    Public Property num_article() As Integer
        Get
            Return _num_article
        End Get
        Set(ByVal value As Integer)
            _num_article = value
        End Set
    End Property


    Public Property exercice() As String
        Get
            Return _exercice
        End Get
        Set(ByVal value As String)
            _exercice = value
        End Set
    End Property

    Public Property historique() As String
        Get
            Return _historique
        End Get
        Set(ByVal value As String)
            _historique = value
        End Set
    End Property


    Public Property datea() As Date
        Get
            Return _datea
        End Get
        Set(ByVal value As Date)
            _datea = value
        End Set
    End Property

    Public Property num() As Integer
        Get
            Return _num
        End Get
        Set(ByVal value As Integer)
            _num = value
        End Set
    End Property
End Class