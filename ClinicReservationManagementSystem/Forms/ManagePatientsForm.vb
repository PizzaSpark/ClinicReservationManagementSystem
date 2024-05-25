Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class ManagePatientsForm
    Dim patient_table As DataTable

    Private Sub ManagePatientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPatientId.Controls(0).Visible = False
        txtAge.Controls(0).Visible = False
        txtContactNumber.Controls(0).Visible = False
        DisplayAllPatients()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
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

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        txtPatientId.Value = 0
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
            'add new patient
            Dim patient As New Patient
            patient.FirstName = txtFirstName.Text
            patient.LastName = txtLastName.Text
            patient.MiddleInitial = txtMiddleInitial.Text
            patient.Age = Integer.Parse(txtAge.Text)
            patient.Gender = cbGender.Text
            patient.DateOfBirth = DateTime.Parse(dtpDateOfBirth.Text)
            patient.CivilStatus = cbCivilStatus.Text
            patient.Address = txtAddress.Text
            patient.ContactNumber = txtContactNumber.Text

            AddPatient(patient)
            DisplayAllPatients()
        Catch ex As Exception
            MsgBox("Failed to add patient. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            'update patient
            Dim patient As New Patient
            patient.PatientId = Integer.Parse(txtPatientId.Text)
            patient.FirstName = txtFirstName.Text
            patient.LastName = txtLastName.Text
            patient.MiddleInitial = txtMiddleInitial.Text
            patient.Age = Integer.Parse(txtAge.Text)
            patient.Gender = cbGender.Text
            patient.DateOfBirth = DateTime.Parse(dtpDateOfBirth.Text)
            patient.CivilStatus = cbCivilStatus.Text
            patient.Address = txtAddress.Text
            patient.ContactNumber = txtContactNumber.Text

            ' Check if PatientId exists
            If Not DoesPatientExist(patient.PatientId) Then
                MsgBox("Patient ID does not exist.")
                Return
            End If

            UpdatePatient(patient)
            DisplayAllPatients()
        Catch ex As Exception
            MsgBox("Failed to update patient. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            'delete patient
            Dim patientId As Integer = Integer.Parse(txtPatientId.Text)

            ' Check if PatientId exists
            If Not DoesPatientExist(patientId) Then
                MsgBox("Patient ID does not exist.")
                Return
            End If

            DeletePatient(patientId)
            DisplayAllPatients()
        Catch ex As Exception
            MsgBox("Failed to delete patient. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvPatientList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPatientList.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvPatientList.Rows(e.RowIndex)

                txtPatientId.Text = row.Cells("patient_id").Value.ToString()
                txtFirstName.Text = row.Cells("patient_firstName").Value.ToString()
                txtLastName.Text = row.Cells("patient_lastName").Value.ToString()
                txtMiddleInitial.Text = row.Cells("patient_middleInitial").Value.ToString()
                txtAge.Text = row.Cells("patient_age").Value.ToString()
                cbGender.Text = row.Cells("patient_gender").Value.ToString()
                dtpDateOfBirth.Value = DateTime.Parse(row.Cells("patient_dateOfBirth").Value.ToString())
                cbCivilStatus.Text = row.Cells("patient_civilStatus").Value.ToString()
                txtAddress.Text = row.Cells("patient_address").Value.ToString()
                txtContactNumber.Text = row.Cells("patient_contactNumber").Value.ToString()
            End If
        Catch ex As Exception
            MsgBox("Failed to load patient details. Error: " & ex.Message)
        End Try
    End Sub

    Public Sub DisplayAllPatients()
        Try
            Dim patientTable As DataTable = GetAllPatients()

            dgvPatientList.DataSource = patientTable

        Catch ex As Exception
            MsgBox("Failed to display patients. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub FillPatientDetails(patientId As Integer)
        Dim patientTable As DataTable = GetPatientById(patientId)

        If patientTable.Rows.Count > 0 Then
            Dim row As DataRow = patientTable.Rows(0)

            txtPatientId.Value = Integer.Parse(row("patient_id").ToString())
            txtFirstName.Text = row("patient_firstName").ToString()
            txtLastName.Text = row("patient_lastName").ToString()
            txtMiddleInitial.Text = row("patient_middleInitial").ToString()
            txtAge.Value = Integer.Parse(row("patient_age").ToString())
            cbGender.Text = row("patient_gender").ToString()
            dtpDateOfBirth.Value = DateTime.Parse(row("patient_dateOfBirth").ToString())
            cbCivilStatus.Text = row("patient_civilStatus").ToString()
            txtAddress.Text = row("patient_address").ToString()
            txtContactNumber.Value = row("patient_contactNumber").ToString()
        End If
    End Sub
End Class