Public Class Appointment
    Private _appointmentId As Integer
    Private _patientId As Integer
    Private _doctorId As Integer
    Private _appointmentDate As DateTime
    Private _appointmentStatus As String

    Public Sub New()
    End Sub

    Public Sub New(appointmentId As Integer, patientId As Integer, doctorId As Integer, appointmentDate As DateTime, appointmentStatus As String)
        _appointmentId = appointmentId
        _patientId = patientId
        _doctorId = doctorId
        _appointmentDate = appointmentDate
        _appointmentStatus = appointmentStatus
    End Sub

    Public Property AppointmentId As Integer
        Get
            Return _appointmentId
        End Get
        Set(value As Integer)
            _appointmentId = value
        End Set
    End Property

    Public Property PatientId As Integer
        Get
            Return _patientId
        End Get
        Set(value As Integer)
            _patientId = value
        End Set
    End Property

    Public Property DoctorId As Integer
        Get
            Return _doctorId
        End Get
        Set(value As Integer)
            _doctorId = value
        End Set
    End Property

    Public Property AppointmentDate As DateTime
        Get
            Return _appointmentDate
        End Get
        Set(value As DateTime)
            _appointmentDate = value
        End Set
    End Property

    Public Property AppointmentStatus As String
        Get
            Return _appointmentStatus
        End Get
        Set(value As String)
            _appointmentStatus = value
        End Set
    End Property
End Class
