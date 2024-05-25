Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        testConnection()
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ManagePatientsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManagePatientsToolStripMenuItem.Click
        Dim managePatientForm As New ManagePatientsForm
        managePatientForm.ShowDialog()
    End Sub

    Private Sub ManageDoctorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageDoctorsToolStripMenuItem.Click
        Dim manageDoctorsForm As New ManageDoctorsForm
        manageDoctorsForm.ShowDialog()
    End Sub
    Private Sub ManageAppointmentsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ManageAppointmentsToolStripMenuItem1.Click
        Dim manageAppointmentsForm As New ManageAppointmentsForm
        manageAppointmentsForm.ShowDialog()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        MessageBox.Show("Created by: Wacks Sanchez")
    End Sub
End Class
