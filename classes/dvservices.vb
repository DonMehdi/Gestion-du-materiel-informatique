Imports System.Data
Imports System.Data.SqlClient
Public Class dvservices
    Public _cdedivserv As Integer
    Public _cdenatserv As Integer
    Public _divservfr As String
    Public _divservar As String
    Public _divservcourt As String
    Public _divservabar As String
    Public _divservabfr As String
    Public Sub New()

    End Sub
    Public Sub New(ByVal cd As Integer, ByVal cn As Integer, ByVal df As String, ByVal da As String, ByVal dc As String, ByVal daa As String, ByVal daf As String)
        _cdedivserv = cd
        _cdenatserv = cn
        _divservfr = df
        _divservar = da
        _divservcourt = dc
        _divservabar = daa
        _divservabfr = daf

    End Sub

    Public Property divservabfr() As String
        Get
            Return _divservabfr
        End Get
        Set(ByVal value As String)
            _divservabfr = value
        End Set
    End Property

    Public Property divservabar() As String
        Get
            Return _divservabar
        End Get
        Set(ByVal value As String)
            _divservabar = value
        End Set
    End Property

    Public Property divsrevcourt() As String
        Get
            Return _divservcourt
        End Get
        Set(ByVal value As String)
            _divservcourt = value
        End Set
    End Property




    Public Property divservar() As String
        Get
            Return _divservar
        End Get
        Set(ByVal value As String)
            _divservar = value
        End Set
    End Property

    Public Property divservfr() As String
        Get
            Return _divservfr
        End Get
        Set(ByVal value As String)
            _divservfr = value
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

    Public Property cdedivserv() As Integer
        Get
            Return _cdedivserv
        End Get
        Set(ByVal value As Integer)
            _cdedivserv = value
        End Set
    End Property

End Class


