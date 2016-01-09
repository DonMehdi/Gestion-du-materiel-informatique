Public Class typebudgets

    Private _num As Integer
    Private _typebudget As String
    Private _typee As String
    Private _budget As String
    Public Sub New()

    End Sub
    Public Sub New(ByVal n As Integer, ByVal tp As String, ByVal t As String, ByVal b As String)
        _num = n
        _typebudget = tp
        _typee = t
        _budget = b
    End Sub
    Public Property budget() As String
        Get
            Return _budget
        End Get
        Set(ByVal value As String)
            _budget = value
        End Set
    End Property

    Public Property typee() As String
        Get
            Return _typee
        End Get
        Set(ByVal value As String)
            _typee = value
        End Set
    End Property

    Public Property typebuget() As String
        Get
            Return _typebudget
        End Get
        Set(ByVal value As String)
            _typebudget = value
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
