Public Class ManageAppointmentsForm
    Private Sub ManageAppointmentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAppointmentId.Controls(0).Visible = False
        txtPatientId.Controls(0).Visible = False
        txtDoctorId.Controls(0).Visible = False
        DisplayAllAppointments()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
    End Sub

    Private Sub btnAppointmentIdSearch_Click(sender As Object, e As EventArgs) Handles btnAppointmentIdSearch.Click
        Try
            Dim appointmentId As Integer = Integer.Parse(txtAppointmentId.Text)
            txtPatientId.Value = 0
            txtDoctorId.Value = 0
            ' Check if AppointmentId exists
            If Not DoesAppointmentExist(appointmentId) Then
                MsgBox("Appointment ID does not exist.")
                Return
            End If

            FillAppointmentDetails(appointmentId)
            Dim patientId As Integer = Integer.Parse(txtPatientId.Text)
            FillPatientDetails(patientId)
            Dim doctorId As Integer = Integer.Parse(txtDoctorId.Text)
            FillDoctorDetails(doctorId)
        Catch ex As Exception
            MsgBox("Failed to search appointment. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnPatientIdSearch_Click(sender As Object, e As EventArgs) Handles btnPatientIdSearch.Click
        Try
            Dim patientId As Integer = Integer.Parse(txtPatientId.Text)

            ' Check if PatientId exists
            If Not DoesPatientExist(patientId) Then
                MsgBox("Patient ID does not exist.")
                Return
            End If

            FillPatientDetails(patientId)
        Catch ex As Exception
            MsgBox("Failed to search patient. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDoctorIdSearch_Click(sender As Object, e As EventArgs) Handles btnDoctorIdSearch.Click
        Try
            Dim doctorId As Integer = Integer.Parse(txtDoctorId.Text)

            ' Check if DoctorId exists
            If Not DoesDoctorExist(doctorId) Then
                MsgBox("Doctor ID does not exist.")
                Return
            End If

            FillDoctorDetails(doctorId)
        Catch ex As Exception
            MsgBox("Failed to search doctor. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        txtAppointmentId.Value = 0
        txtPatientId.Value = 0
        txtDoctorId.Value = 0
        dtpAppointmentDate.Value = DateTime.Now
        cbAppointmentStatus.SelectedIndex = -1

        txtPatientFirstName.Clear()
        txtPatientLastName.Clear()
        txtPatientMiddleInitial.Clear()

        txtDoctorFirstName.Clear()
        txtDoctorLastName.Clear()
        txtDoctorMiddleInitial.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            'add new appointment
            Dim appointment As New Appointment
            appointment.PatientId = Integer.Parse(txtPatientId.Text)
            appointment.DoctorId = Integer.Parse(txtDoctorId.Text)
            appointment.AppointmentDate = dtpAppointmentDate.Value
            appointment.AppointmentStatus = cbAppointmentStatus.Text

            ' Check if PatientId exists
            If Not DoesPatientExist(appointment.PatientId) Then
                MsgBox("Patient ID does not exist.")
                Return
            End If

            ' Check if DoctorId exists
            If Not DoesDoctorExist(appointment.DoctorId) Then
                MsgBox("Doctor ID does not exist.")
                Return
            End If

            AddAppointment(appointment)
            DisplayAllAppointments()
        Catch ex As Exception
            MsgBox("Failed to add appointment. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            'update appointment
            Dim appointment As New Appointment
            appointment.AppointmentId = Integer.Parse(txtAppointmentId.Text)
            appointment.PatientId = Integer.Parse(txtPatientId.Text)
            appointment.DoctorId = Integer.Parse(txtDoctorId.Text)
            appointment.AppointmentDate = dtpAppointmentDate.Value
            appointment.AppointmentStatus = cbAppointmentStatus.Text

            ' Check if AppointmentId exists
            If Not DoesAppointmentExist(appointment.AppointmentId) Then
                MsgBox("Appointment ID does not exist.")
                Return
            End If

            ' Check if PatientId exists
            If Not DoesPatientExist(appointment.PatientId) Then
                MsgBox("Patient ID does not exist.")
                Return
            End If

            ' Check if DoctorId exists
            If Not DoesDoctorExist(appointment.DoctorId) Then
                MsgBox("Doctor ID does not exist.")
                Return
            End If

            UpdateAppointment(appointment)
            DisplayAllAppointments()
        Catch ex As Exception
            MsgBox("Failed to update appointment. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            'delete appointment
            Dim appointmentId As Integer = Integer.Parse(txtAppointmentId.Text)

            ' Check if AppointmentId exists
            If Not DoesAppointmentExist(appointmentId) Then
                MsgBox("Appointment ID does not exist.")
                Return
            End If

            DeleteAppointment(appointmentId)
            DisplayAllAppointments()
        Catch ex As Exception
            MsgBox("Failed to delete appointment. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvAppointmentList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAppointmentList.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvAppointmentList.Rows(e.RowIndex)

                txtAppointmentId.Value = Integer.Parse(row.Cells("appointment_id").Value.ToString())
                txtPatientId.Value = Integer.Parse(row.Cells("patient_id").Value.ToString())
                txtDoctorId.Value = Integer.Parse(row.Cells("doctor_id").Value.ToString())
                dtpAppointmentDate.Value = DateTime.Parse(row.Cells("appointment_date").Value.ToString())
                cbAppointmentStatus.Text = row.Cells("appointment_status").Value.ToString()
            End If

            Dim patientId As Integer = Integer.Parse(txtPatientId.Text)
            FillPatientDetails(patientId)
            Dim doctorId As Integer = Integer.Parse(txtDoctorId.Text)
            FillDoctorDetails(doctorId)
        Catch ex As Exception
            MsgBox("Failed to load appointment details. Error: " & ex.Message)
        End Try
    End Sub

    Public Sub DisplayAllAppointments()
        Try
            Dim appointmentTable As DataTable = GetAllAppointments()

            dgvAppointmentList.DataSource = appointmentTable

        Catch ex As Exception
            MsgBox("Failed to display appointments. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub FillPatientDetails(patientId As Integer)
        Dim patientTable As DataTable = GetPatientById(patientId)

        If patientTable.Rows.Count > 0 Then
            Dim row As DataRow = patientTable.Rows(0)

            txtPatientId.Value = Integer.Parse(row("patient_id").ToString())
            txtPatientFirstName.Text = row("patient_firstName").ToString()
            txtPatientLastName.Text = row("patient_lastName").ToString()
            txtPatientMiddleInitial.Text = row("patient_middleInitial").ToString()
        End If
    End Sub

    Private Sub FillDoctorDetails(doctorId As Integer)
        Dim doctorTable As DataTable = GetDoctorById(doctorId)

        If doctorTable.Rows.Count > 0 Then
            Dim row As DataRow = doctorTable.Rows(0)

            txtDoctorId.Value = Integer.Parse(row("doctor_id").ToString())
            txtDoctorFirstName.Text = row("doctor_firstName").ToString()
            txtDoctorLastName.Text = row("doctor_lastName").ToString()
            txtDoctorMiddleInitial.Text = row("doctor_middleInitial").ToString()
        End If
    End Sub

    Private Sub FillAppointmentDetails(appointmentId As Integer)
        Dim appointmentTable As DataTable = GetAppointmentById(appointmentId)

        If appointmentTable.Rows.Count > 0 Then
            Dim row As DataRow = appointmentTable.Rows(0)

            txtAppointmentId.Value = Integer.Parse(row("appointment_id").ToString())
            txtPatientId.Value = Integer.Parse(row("patient_id").ToString())
            txtDoctorId.Value = Integer.Parse(row("doctor_id").ToString())
            dtpAppointmentDate.Value = DateTime.Parse(row("appointment_date").ToString())
            cbAppointmentStatus.Text = row("appointment_status").ToString()
        End If
    End Sub
End Class