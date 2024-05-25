Imports MySql.Data.MySqlClient
Imports System.IO

Module DBHandler

    Dim connectionConfig As String = "server=localhost; user=root; password=root; database=db_clinicreservation;"
    Dim connection As New MySqlConnection(connectionConfig)

    'test connection
    Public Sub testConnection()
        Try
            connection.Open()
            MsgBox("Connected")
            connection.Close()
        Catch ex As MySqlException When ex.Number = 1049
            MsgBox("Database does not exist. Creating...")
            InitializeDatabase()
        Catch ex As Exception
            MsgBox("Failed to connect. Error: " & ex.Message)
        End Try
    End Sub

    'add patient
    Public Sub AddPatient(patient As Patient)
        Try
            Using connection As New MySqlConnection(connectionConfig)
                connection.Open()

                Using command As New MySqlCommand("INSERT INTO tbl_patients (patient_firstName, patient_lastName, patient_middleInitial, patient_age, patient_gender, patient_dateOfBirth, patient_civilStatus, patient_address, patient_contactNumber) VALUES (@FirstName, @LastName, @MiddleInitial, @Age, @Gender, @DateOfBirth, @CivilStatus, @Address, @ContactNumber)", connection)
                    command.Parameters.AddWithValue("@FirstName", patient.FirstName)
                    command.Parameters.AddWithValue("@LastName", patient.LastName)
                    command.Parameters.AddWithValue("@MiddleInitial", patient.MiddleInitial)
                    command.Parameters.AddWithValue("@Age", patient.Age)
                    command.Parameters.AddWithValue("@Gender", patient.Gender)
                    command.Parameters.AddWithValue("@DateOfBirth", patient.DateOfBirth)
                    command.Parameters.AddWithValue("@CivilStatus", patient.CivilStatus)
                    command.Parameters.AddWithValue("@Address", patient.Address)
                    command.Parameters.AddWithValue("@ContactNumber", patient.ContactNumber)

                    command.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Patient added successfully")

        Catch ex As Exception
            ' Log the error message somewhere
            MsgBox("Failed to add patient. Error: " & ex.Message)
        End Try
    End Sub

    'get all patients
    Public Function GetAllPatients() As DataTable
        Dim patient_table As New DataTable

        Try
            Using connection As New MySqlConnection(connectionConfig)
                connection.Open()

                Using command As New MySqlCommand("SELECT * FROM tbl_patients", connection)
                    Using adapter As New MySqlDataAdapter(command)
                        adapter.Fill(patient_table)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Log the error message somewhere
            MsgBox("Failed to get patients. Error: " & ex.Message)
        End Try

        Return patient_table
    End Function

    'get patient by id
    Public Function GetPatientById(patientId As Integer) As DataTable
        Dim patientTable As New DataTable

        Try
            Using connection As New MySqlConnection(connectionConfig)
                connection.Open()

                Using command As New MySqlCommand("SELECT * FROM tbl_patients WHERE patient_id = @PatientId", connection)
                    command.Parameters.AddWithValue("@PatientId", patientId)

                    Using adapter As New MySqlDataAdapter(command)
                        adapter.Fill(patientTable)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Log the error message somewhere
            MsgBox("Failed to get patient. Error: " & ex.Message)
        End Try

        Return patientTable
    End Function

    'update patient
    Public Sub UpdatePatient(patient As Patient)
        Try
            Using connection As New MySqlConnection(connectionConfig)
                connection.Open()

                Using command As New MySqlCommand("UPDATE tbl_patients SET patient_firstName = @FirstName, patient_lastName = @LastName, patient_middleInitial = @MiddleInitial, patient_age = @Age, patient_gender = @Gender, patient_dateOfBirth = @DateOfBirth, patient_civilStatus = @CivilStatus, patient_address = @Address, patient_contactNumber = @ContactNumber WHERE patient_id = @PatientId", connection)
                    command.Parameters.AddWithValue("@FirstName", patient.FirstName)
                    command.Parameters.AddWithValue("@LastName", patient.LastName)
                    command.Parameters.AddWithValue("@MiddleInitial", patient.MiddleInitial)
                    command.Parameters.AddWithValue("@Age", patient.Age)
                    command.Parameters.AddWithValue("@Gender", patient.Gender)
                    command.Parameters.AddWithValue("@DateOfBirth", patient.DateOfBirth)
                    command.Parameters.AddWithValue("@CivilStatus", patient.CivilStatus)
                    command.Parameters.AddWithValue("@Address", patient.Address)
                    command.Parameters.AddWithValue("@ContactNumber", patient.ContactNumber)
                    command.Parameters.AddWithValue("@PatientId", patient.PatientId)

                    command.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Patient updated successfully")

        Catch ex As Exception
            ' Log the error message somewhere
            MsgBox("Failed to update patient. Error: " & ex.Message)
        End Try
    End Sub

    'delete patient
    Public Sub DeletePatient(patientId As Integer)
        Try
            Using connection As New MySqlConnection(connectionConfig)
                connection.Open()

                Using command As New MySqlCommand("DELETE FROM tbl_patients WHERE patient_id = @PatientId", connection)
                    command.Parameters.AddWithValue("@PatientId", patientId)

                    command.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Patient deleted successfully")

        Catch ex As Exception
            ' Log the error message somewhere
            MsgBox("Failed to delete patient. Error: " & ex.Message)
        End Try
    End Sub

    'check if patient exists
    Public Function DoesPatientExist(patientId As Integer) As Boolean
        Dim exists As Boolean = False

        Try
            Using connection As New MySqlConnection(connectionConfig)
                connection.Open()

                Using command As New MySqlCommand("SELECT COUNT(*) FROM tbl_patients WHERE patient_id = @PatientId", connection)
                    command.Parameters.AddWithValue("@PatientId", patientId)

                    exists = Integer.Parse(command.ExecuteScalar().ToString()) > 0
                End Using
            End Using

        Catch ex As Exception
            ' Log the error message somewhere
            MsgBox("Failed to check patient. Error: " & ex.Message)
        End Try

        Return exists
    End Function

    'add doctor
    Public Sub AddDoctor(doctor As Doctor)
        Try
            Using connection As New MySqlConnection(connectionConfig)
                connection.Open()

                Using command As New MySqlCommand("INSERT INTO tbl_doctors (doctor_firstName, doctor_lastName, doctor_middleInitial, doctor_age, doctor_gender, doctor_dateOfBirth, doctor_civilStatus, doctor_address, doctor_contactNumber) VALUES (@FirstName, @LastName, @MiddleInitial, @Age, @Gender, @DateOfBirth, @CivilStatus, @Address, @ContactNumber)", connection)
                    command.Parameters.AddWithValue("@FirstName", doctor.FirstName)
                    command.Parameters.AddWithValue("@LastName", doctor.LastName)
                    command.Parameters.AddWithValue("@MiddleInitial", doctor.MiddleInitial)
                    command.Parameters.AddWithValue("@Age", doctor.Age)
                    command.Parameters.AddWithValue("@Gender", doctor.Gender)
                    command.Parameters.AddWithValue("@DateOfBirth", doctor.DateOfBirth)
                    command.Parameters.AddWithValue("@CivilStatus", doctor.CivilStatus)
                    command.Parameters.AddWithValue("@Address", doctor.Address)
                    command.Parameters.AddWithValue("@ContactNumber", doctor.ContactNumber)

                    command.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Doctor added successfully")

        Catch ex As Exception
            ' Log the error message somewhere
            MsgBox("Failed to add doctor. Error: " & ex.Message)
        End Try
    End Sub

    'get all doctors
    Public Function GetAllDoctors() As DataTable
        Dim doctor_table As New DataTable

        Try
            Using connection As New MySqlConnection(connectionConfig)
                connection.Open()

                Using command As New MySqlCommand("SELECT * FROM tbl_doctors", connection)
                    Using adapter As New MySqlDataAdapter(command)
                        adapter.Fill(doctor_table)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Log the error message somewhere
            MsgBox("Failed to get doctors. Error: " & ex.Message)
        End Try

        Return doctor_table
    End Function

    'get doctor by id
    Public Function GetDoctorById(doctorId As Integer) As DataTable
        Dim doctorTable As New DataTable

        Try
            Using connection As New MySqlConnection(connectionConfig)
                connection.Open()

                Using command As New MySqlCommand("SELECT * FROM tbl_doctors WHERE doctor_id = @DoctorId", connection)
                    command.Parameters.AddWithValue("@DoctorId", doctorId)

                    Using adapter As New MySqlDataAdapter(command)
                        adapter.Fill(doctorTable)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Log the error message somewhere
            MsgBox("Failed to get doctor. Error: " & ex.Message)
        End Try

        Return doctorTable
    End Function

    'update doctor
    Public Sub UpdateDoctor(doctor As Doctor)
        Try
            Using connection As New MySqlConnection(connectionConfig)
                connection.Open()

                Using command As New MySqlCommand("UPDATE tbl_doctors SET doctor_firstName = @FirstName, doctor_lastName = @LastName, doctor_middleInitial = @MiddleInitial, doctor_age = @Age, doctor_gender = @Gender, doctor_dateOfBirth = @DateOfBirth, doctor_civilStatus = @CivilStatus, doctor_address = @Address, doctor_contactNumber = @ContactNumber WHERE doctor_id = @DoctorId", connection)
                    command.Parameters.AddWithValue("@FirstName", doctor.FirstName)
                    command.Parameters.AddWithValue("@LastName", doctor.LastName)
                    command.Parameters.AddWithValue("@MiddleInitial", doctor.MiddleInitial)
                    command.Parameters.AddWithValue("@Age", doctor.Age)
                    command.Parameters.AddWithValue("@Gender", doctor.Gender)
                    command.Parameters.AddWithValue("@DateOfBirth", doctor.DateOfBirth)
                    command.Parameters.AddWithValue("@CivilStatus", doctor.CivilStatus)
                    command.Parameters.AddWithValue("@Address", doctor.Address)
                    command.Parameters.AddWithValue("@ContactNumber", doctor.ContactNumber)
                    command.Parameters.AddWithValue("@DoctorId", doctor.DoctorId)

                    command.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Doctor updated successfully")

        Catch ex As Exception
            ' Log the error message somewhere
            MsgBox("Failed to update doctor. Error: " & ex.Message)
        End Try
    End Sub

    'delete doctor
    Public Sub DeleteDoctor(doctorId As Integer)
        Try
            Using connection As New MySqlConnection(connectionConfig)
                connection.Open()

                Using command As New MySqlCommand("DELETE FROM tbl_doctors WHERE doctor_id = @DoctorId", connection)
                    command.Parameters.AddWithValue("@DoctorId", doctorId)

                    command.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Doctor deleted successfully")

        Catch ex As Exception
            ' Log the error message somewhere
            MsgBox("Failed to delete doctor. Error: " & ex.Message)
        End Try
    End Sub

    'check if doctor exists
    Public Function DoesDoctorExist(doctorId As Integer) As Boolean
        Dim exists As Boolean = False

        Try
            Using connection As New MySqlConnection(connectionConfig)
                connection.Open()

                Using command As New MySqlCommand("SELECT COUNT(*) FROM tbl_doctors WHERE doctor_id = @DoctorId", connection)
                    command.Parameters.AddWithValue("@DoctorId", doctorId)

                    exists = Integer.Parse(command.ExecuteScalar().ToString()) > 0
                End Using
            End Using

        Catch ex As Exception
            ' Log the error message somewhere
            MsgBox("Failed to check doctor. Error: " & ex.Message)
        End Try

        Return exists
    End Function

    'add appointment
    Public Sub AddAppointment(appointment As Appointment)
        Try
            Using connection As New MySqlConnection(connectionConfig)
                connection.Open()

                Using command As New MySqlCommand("INSERT INTO tbl_appointments (appointment_id, patient_id, doctor_id, appointment_date, appointment_status) VALUES (@AppointmentId, @PatientId, @DoctorId, @AppointmentDate, @AppointmentStatus)", connection)
                    command.Parameters.AddWithValue("@AppointmentId", appointment.AppointmentId)
                    command.Parameters.AddWithValue("@PatientId", appointment.PatientId)
                    command.Parameters.AddWithValue("@DoctorId", appointment.DoctorId)
                    command.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate)
                    command.Parameters.AddWithValue("@AppointmentStatus", appointment.AppointmentStatus)

                    command.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Appointment added successfully")

        Catch ex As Exception
            ' Log the error message somewhere
            MsgBox("Failed to add appointment. Error: " & ex.Message)
        End Try
    End Sub

    'get all appointments
    Public Function GetAllAppointments() As DataTable
        Dim appointmentTable As New DataTable

        Try
            Using connection As New MySqlConnection(connectionConfig)
                connection.Open()

                Using command As New MySqlCommand("SELECT * FROM tbl_appointments", connection)
                    Using adapter As New MySqlDataAdapter(command)
                        adapter.Fill(appointmentTable)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Log the error message somewhere
            MsgBox("Failed to get appointments. Error: " & ex.Message)
        End Try

        Return appointmentTable
    End Function

    'get appointment by id
    Public Function GetAppointmentById(appointmentId As Integer) As DataTable
        Dim appointmentTable As New DataTable

        Try
            Using connection As New MySqlConnection(connectionConfig)
                connection.Open()

                Using command As New MySqlCommand("SELECT * FROM tbl_appointments WHERE appointment_id = @AppointmentId", connection)
                    command.Parameters.AddWithValue("@AppointmentId", appointmentId)

                    Using adapter As New MySqlDataAdapter(command)
                        adapter.Fill(appointmentTable)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Log the error message somewhere
            MsgBox("Failed to get appointment. Error: " & ex.Message)
        End Try

        Return appointmentTable
    End Function

    'update appointment
    Public Sub UpdateAppointment(appointment As Appointment)
        Try
            Using connection As New MySqlConnection(connectionConfig)
                connection.Open()

                Using command As New MySqlCommand("UPDATE tbl_appointments SET patient_id = @PatientId, doctor_id = @DoctorId, appointment_date = @AppointmentDate, appointment_status = @AppointmentStatus WHERE appointment_id = @AppointmentId", connection)
                    command.Parameters.AddWithValue("@AppointmentId", appointment.AppointmentId)
                    command.Parameters.AddWithValue("@PatientId", appointment.PatientId)
                    command.Parameters.AddWithValue("@DoctorId", appointment.DoctorId)
                    command.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate)
                    command.Parameters.AddWithValue("@AppointmentStatus", appointment.AppointmentStatus)

                    command.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Appointment updated successfully")

        Catch ex As Exception
            ' Log the error message somewhere
            MsgBox("Failed to update appointment. Error: " & ex.Message)
        End Try
    End Sub

    'delete appointment
    Public Sub DeleteAppointment(appointmentId As Integer)
        Try
            Using connection As New MySqlConnection(connectionConfig)
                connection.Open()

                Using command As New MySqlCommand("DELETE FROM tbl_appointments WHERE appointment_id = @AppointmentId", connection)
                    command.Parameters.AddWithValue("@AppointmentId", appointmentId)

                    command.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Appointment deleted successfully")

        Catch ex As Exception
            ' Log the error message somewhere
            MsgBox("Failed to delete appointment. Error: " & ex.Message)
        End Try
    End Sub

    'check if appointment exists
    Public Function DoesAppointmentExist(appointmentId As Integer) As Boolean
        Dim exists As Boolean = False

        Try
            Using connection As New MySqlConnection(connectionConfig)
                connection.Open()

                Using command As New MySqlCommand("SELECT COUNT(*) FROM tbl_appointments WHERE appointment_id = @AppointmentId", connection)
                    command.Parameters.AddWithValue("@AppointmentId", appointmentId)

                    exists = Integer.Parse(command.ExecuteScalar().ToString()) > 0
                End Using
            End Using

        Catch ex As Exception
            ' Log the error message somewhere
            MsgBox("Failed to check appointment. Error: " & ex.Message)
        End Try

        Return exists
    End Function

    Private Sub InitializeDatabase()
        Try
            ' Create a new connection without the database name
            Dim initConnectionConfig As String = "server=localhost; user=root; password=root;"
            Using initConnection As New MySqlConnection(initConnectionConfig)
                initConnection.Open()

                ' Read the SQL script file
                Dim filePath As String = "../../../initDB.sql"
                Dim sqlScript As String = File.ReadAllText(filePath)

                ' Execute the SQL script
                Using command As New MySqlCommand(sqlScript, initConnection)
                    command.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Database initialized successfully")
        Catch ex As Exception
            MsgBox("Failed to initialize database. Error: " & ex.Message)
        End Try
    End Sub

End Module