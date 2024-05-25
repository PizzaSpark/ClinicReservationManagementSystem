Public Class Patient

    Private _patientId As Integer
    Private _firstName As String
    Private _lastName As String
    Private _middleInitial As String
    Private _age As Integer
    Private _gender As String
    Private _dateOfBirth As DateTime
    Private _civilStatus As String
    Private _address As String
    Private _contactNumber As String

    Public Sub New()
    End Sub

    Public Sub New(patientId As Integer, firstName As String, lastName As String, middleInitial As String, age As Integer, gender As String, dateOfBirth As DateTime, civilStatus As String, address As String, contactNumber As String)
        _patientId = patientId
        _firstName = firstName
        _lastName = lastName
        _middleInitial = middleInitial
        _age = age
        _gender = gender
        _dateOfBirth = dateOfBirth
        _civilStatus = civilStatus
        _address = address
        _contactNumber = contactNumber
    End Sub

    Public Property PatientId As Integer
        Get
            Return _patientId
        End Get
        Set(value As Integer)
            _patientId = value
        End Set
    End Property

    Public Property FirstName As String
        Get
            Return _firstName
        End Get
        Set(value As String)
            _firstName = value
        End Set
    End Property

    Public Property LastName As String
        Get
            Return _lastName
        End Get
        Set(value As String)
            _lastName = value
        End Set
    End Property

    Public Property MiddleInitial As String
        Get
            Return _middleInitial
        End Get
        Set(value As String)
            _middleInitial = value
        End Set
    End Property

    Public Property Age As Integer
        Get
            Return _age
        End Get
        Set(value As Integer)
            _age = value
        End Set
    End Property

    Public Property Gender As String
        Get
            Return _gender
        End Get
        Set(value As String)
            _gender = value
        End Set
    End Property

    Public Property DateOfBirth As DateTime
        Get
            Return _dateOfBirth
        End Get
        Set(value As DateTime)
            _dateOfBirth = value
        End Set
    End Property

    Public Property CivilStatus As String
        Get
            Return _civilStatus
        End Get
        Set(value As String)
            _civilStatus = value
        End Set
    End Property

    Public Property Address As String
        Get
            Return _address
        End Get
        Set(value As String)
            _address = value
        End Set
    End Property

    Public Property ContactNumber As String
        Get
            Return _contactNumber
        End Get
        Set(value As String)
            _contactNumber = value
        End Set
    End Property

End Class
