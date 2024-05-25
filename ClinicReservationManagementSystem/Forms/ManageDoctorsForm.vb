Public Class ManageDoctorsForm
    Dim doctor_table As DataTable

    Private Sub ManageDoctorsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDoctorId.Controls(0).Visible = False
        txtAge.Controls(0).Visible = False
        txtContactNumber.Controls(0).Visible = False
        DisplayAllDoctors()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
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
        txtDoctorId.Value = 0
        txtFirstName.Clear()
        txtLastName.Clear()
        txtMiddleInitial.Clear()
        txtAge.Value = 0
        cbGender.SelectedIndex = -1
        dtpDateOfBirth.Value = DateTime.Now
        cbCivilStatus.SelectedIndex = -1
        txtAddress.Clear()
        txtContactNumber.Value = 0
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            'add new doctor
            Dim doctor As New Doctor
            doctor.FirstName = txtFirstName.Text
            doctor.LastName = txtLastName.Text
            doctor.MiddleInitial = txtMiddleInitial.Text
            doctor.Age = Integer.Parse(txtAge.Text)
            doctor.Gender = cbGender.Text
            doctor.DateOfBirth = DateTime.Parse(dtpDateOfBirth.Text)
            doctor.CivilStatus = cbCivilStatus.Text
            doctor.Address = txtAddress.Text
            doctor.ContactNumber = txtContactNumber.Text

            AddDoctor(doctor)
            DisplayAllDoctors()
        Catch ex As Exception
            MsgBox("Failed to add doctor. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            'update doctor
            Dim doctor As New Doctor
            doctor.DoctorId = Integer.Parse(txtDoctorId.Text)
            doctor.FirstName = txtFirstName.Text
            doctor.LastName = txtLastName.Text
            doctor.MiddleInitial = txtMiddleInitial.Text
            doctor.Age = Integer.Parse(txtAge.Text)
            doctor.Gender = cbGender.Text
            doctor.DateOfBirth = DateTime.Parse(dtpDateOfBirth.Text)
            doctor.CivilStatus = cbCivilStatus.Text
            doctor.Address = txtAddress.Text
            doctor.ContactNumber = txtContactNumber.Text

            ' Check if DoctorId exists
            If Not DoesDoctorExist(doctor.DoctorId) Then
                MsgBox("Doctor ID does not exist.")
                Return
            End If

            UpdateDoctor(doctor)
            DisplayAllDoctors()
        Catch ex As Exception
            MsgBox("Failed to update doctor. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            'delete doctor
            Dim doctorId As Integer = Integer.Parse(txtDoctorId.Text)

            ' Check if DoctorId exists
            If Not DoesDoctorExist(doctorId) Then
                MsgBox("Doctor ID does not exist.")
                Return
            End If

            DeleteDoctor(doctorId)
            DisplayAllDoctors()
        Catch ex As Exception
            MsgBox("Failed to delete doctor. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvDoctorList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDoctorList.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvDoctorList.Rows(e.RowIndex)

                txtDoctorId.Text = row.Cells("doctor_id").Value.ToString()
                txtFirstName.Text = row.Cells("doctor_firstName").Value.ToString()
                txtLastName.Text = row.Cells("doctor_lastName").Value.ToString()
                txtMiddleInitial.Text = row.Cells("doctor_middleInitial").Value.ToString()
                txtAge.Text = row.Cells("doctor_age").Value.ToString()
                cbGender.Text = row.Cells("doctor_gender").Value.ToString()
                dtpDateOfBirth.Value = DateTime.Parse(row.Cells("doctor_dateOfBirth").Value.ToString())
                cbCivilStatus.Text = row.Cells("doctor_civilStatus").Value.ToString()
                txtAddress.Text = row.Cells("doctor_address").Value.ToString()
                txtContactNumber.Text = row.Cells("doctor_contactNumber").Value.ToString()
            End If
        Catch ex As Exception
            MsgBox("Failed to load doctor details. Error: " & ex.Message)
        End Try
    End Sub

    Public Sub DisplayAllDoctors()
        Try
            Dim doctorTable As DataTable = GetAllDoctors()

            dgvDoctorList.DataSource = doctorTable

        Catch ex As Exception
            MsgBox("Failed to display doctors. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub FillDoctorDetails(doctorId As Integer)
        Dim doctorTable As DataTable = GetDoctorById(doctorId)

        If doctorTable.Rows.Count > 0 Then
            Dim row As DataRow = doctorTable.Rows(0)

            txtDoctorId.Value = Integer.Parse(row("doctor_id").ToString())
            txtFirstName.Text = row("doctor_firstName").ToString()
            txtLastName.Text = row("doctor_lastName").ToString()
            txtMiddleInitial.Text = row("doctor_middleInitial").ToString()
            txtAge.Value = Integer.Parse(row("doctor_age").ToString())
            cbGender.Text = row("doctor_gender").ToString()
            dtpDateOfBirth.Value = DateTime.Parse(row("doctor_dateOfBirth").ToString())
            cbCivilStatus.Text = row("doctor_civilStatus").ToString()
            txtAddress.Text = row("doctor_address").ToString()
            txtContactNumber.Value = row("doctor_contactNumber").ToString()
        End If
    End Sub
End Class