<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageProfilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManagePatientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageDoctorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageAppointmentsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ManageProfilesToolStripMenuItem, Me.ManageAppointmentsToolStripMenuItem1, Me.AboutUsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1214, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(73, 29)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(141, 34)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ManageProfilesToolStripMenuItem
        '
        Me.ManageProfilesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManagePatientsToolStripMenuItem, Me.ManageDoctorsToolStripMenuItem})
        Me.ManageProfilesToolStripMenuItem.Name = "ManageProfilesToolStripMenuItem"
        Me.ManageProfilesToolStripMenuItem.Size = New System.Drawing.Size(155, 29)
        Me.ManageProfilesToolStripMenuItem.Text = "Manage Profiles"
        '
        'ManagePatientsToolStripMenuItem
        '
        Me.ManagePatientsToolStripMenuItem.Name = "ManagePatientsToolStripMenuItem"
        Me.ManagePatientsToolStripMenuItem.Size = New System.Drawing.Size(246, 34)
        Me.ManagePatientsToolStripMenuItem.Text = "Manage Patients"
        '
        'ManageDoctorsToolStripMenuItem
        '
        Me.ManageDoctorsToolStripMenuItem.Name = "ManageDoctorsToolStripMenuItem"
        Me.ManageDoctorsToolStripMenuItem.Size = New System.Drawing.Size(246, 34)
        Me.ManageDoctorsToolStripMenuItem.Text = "Manage Doctors"
        '
        'ManageAppointmentsToolStripMenuItem1
        '
        Me.ManageAppointmentsToolStripMenuItem1.Name = "ManageAppointmentsToolStripMenuItem1"
        Me.ManageAppointmentsToolStripMenuItem1.Size = New System.Drawing.Size(211, 29)
        Me.ManageAppointmentsToolStripMenuItem1.Text = "Manage Appointments"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(101, 29)
        Me.AboutUsToolStripMenuItem.Text = "About us"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ClinicReservationManagementSystem.My.Resources.Resources.Screenshot_2024_05_25_170245
        Me.PictureBox1.Location = New System.Drawing.Point(27, 308)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(838, 614)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.ClinicReservationManagementSystem.My.Resources.Resources.Blue_Modern_Medical_Promotion_Video
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1214, 934)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ManageProfilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManagePatientsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents ManageDoctorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageAppointmentsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
