Public Class fournisseurs


    Private _code_fournisseur As Integer

    Private _fournisseur As String

    Private _fournisseurabr As String

    Private _activite As String

    Private _type_societe As String

    Private _tel As String

    Private _GSM As String

    Private _fax As String

    Private _interlocuteur As String

    Private _patente As String

    Private _adresse As String

    Private _code_postale As String

    Private _ville As String

    Private _banque As String

    Private _agence As String

    Private _rip As String

    Private _e_mail As String

    Public Sub New()

    End Sub
    Public Sub New(ByVal code As Integer, ByVal fourni As String, ByVal fourniabr As String, ByVal act As String, ByVal tste As String, ByVal t As String, ByVal g As String, ByVal f As String, ByVal i As String, ByVal p As String, ByVal c As String, ByVal ad As String, ByVal v As String, ByVal b As String, ByVal a As String, ByVal r As String, ByVal e As String)
        _code_fournisseur = code
        _fournisseur = fourni
        _fournisseurabr = fourniabr
        _activite = act
        _type_societe = tste
        _tel = t
        _GSM = g
        _fax = f
        _interlocuteur = i
        _patente = p
        _adresse = ad
        _code_postale = c
        _ville = v
        _banque = b
        _agence = a
        _rip = r
        _e_mail = e










    End Sub




    Public Property e_mail() As String
        Get
            Return _e_mail
        End Get
        Set(ByVal value As String)
            _e_mail = value
        End Set
    End Property

    Public Property rip() As String
        Get
            Return _rip
        End Get
        Set(ByVal value As String)
            _rip = value
        End Set
    End Property

    Public Property agence() As String
        Get
            Return _agence
        End Get
        Set(ByVal value As String)
            _agence = value
        End Set
    End Property



    Public Property banque() As String
        Get
            Return _banque
        End Get
        Set(ByVal value As String)
            _banque = value
        End Set
    End Property

    Public Property ville() As String
        Get
            Return _ville
        End Get
        Set(ByVal value As String)
            _ville = value
        End Set
    End Property

    Public Property code_postale() As String
        Get
            Return _code_postale
        End Get
        Set(ByVal value As String)
            _code_postale = value
        End Set
    End Property

    Public Property adresse() As String
        Get
            Return _adresse
        End Get
        Set(ByVal value As String)
            _adresse = value
        End Set
    End Property



    Public Property patente() As String
        Get
            Return _patente
        End Get
        Set(ByVal value As String)
            _patente = value
        End Set
    End Property


    Public Property interlocuteur() As String
        Get
            Return _interlocuteur
        End Get
        Set(ByVal value As String)
            _interlocuteur = value
        End Set
    End Property

    Public Property fax() As String
        Get
            Return _fax
        End Get
        Set(ByVal value As String)
            _fax = value
        End Set
    End Property

    Public Property GSM() As String
        Get
            Return _GSM
        End Get
        Set(ByVal value As String)
            _GSM = value
        End Set
    End Property

    Public Property tel() As String
        Get
            Return _tel
        End Get
        Set(ByVal value As String)
            _tel = value
        End Set
    End Property

    Public Property type_societe() As String
        Get
            Return _type_societe
        End Get
        Set(ByVal value As String)
            _type_societe = value
        End Set
    End Property


    Public Property activite() As String
        Get
            Return _activite
        End Get
        Set(ByVal value As String)
            _activite = value
        End Set
    End Property

    Public Property fournisseurabr() As String
        Get
            Return _fournisseurabr
        End Get
        Set(ByVal value As String)
            _fournisseurabr = value
        End Set
    End Property

    Public Property fournisseur() As String
        Get
            Return _fournisseur
        End Get
        Set(ByVal value As String)
            _fournisseur = value
        End Set
    End Property

    Public Property code_fournisseur() As Integer
        Get
            Return _code_fournisseur
        End Get
        Set(ByVal value As Integer)
            _code_fournisseur = value
        End Set
    End Property


End Class
