Public Class nature_services

    Private _cdenatserv As Integer

    Private _servicesfr As String

    Private _servicesar As String
    Public Sub New()

    End Sub
    Public Sub New(ByVal c As Integer, ByVal f As String, ByVal a As String)
        _cdenatserv = c
        _servicesfr = f
        _servicesar = a

    End Sub

    Public Property servicesar() As String
        Get
            Return _servicesar
        End Get
        Set(ByVal value As String)
            _servicesar = value
        End Set
    End Property

    Public Property servicesfr() As String
        Get
            Return _servicesfr
        End Get
        Set(ByVal value As String)
            _servicesfr = value
        End Set
    End Property

    Public Property cdenatserv() As Integer
        Get
            Return _cdenatserv
        End Get
        Set(ByVal value As Integer)
            _cdenatserv = value
        End Set
    End Property


End Class
