<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageAppointmentsForm
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
        Me.txtAppointmentId = New System.Windows.Forms.NumericUpDown()
        Me.dgvAppointmentList = New System.Windows.Forms.DataGridView()
        Me.txtPatientMiddleInitial = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbAppointmentStatus = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpAppointmentDate = New System.Windows.Forms.DateTimePicker()
        Me.txtDoctorId = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDoctorIdSearch = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDoctorMiddleInitial = New System.Windows.Forms.TextBox()
        Me.txtDoctorLastName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDoctorFirstName = New System.Windows.Forms.TextBox()
        Me.txtPatientId = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnPatientIdSearch = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPatientLastName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPatientFirstName = New System.Windows.Forms.TextBox()
        Me.btnAppointmentIdSearch = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        CType(Me.txtAppointmentId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAppointmentList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtDoctorId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPatientId, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAppointmentId
        '
        Me.txtAppointmentId.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAppointmentId.Location = New System.Drawing.Point(310, 51)
        Me.txtAppointmentId.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.txtAppointmentId.Name = "txtAppointmentId"
        Me.txtAppointmentId.Size = New System.Drawing.Size(117, 39)
        Me.txtAppointmentId.TabIndex = 83
        '
        'dgvAppointmentList
        '
        Me.dgvAppointmentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAppointmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAppointmentList.Location = New System.Drawing.Point(54, 772)
        Me.dgvAppointmentList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvAppointmentList.Name = "dgvAppointmentList"
        Me.dgvAppointmentList.ReadOnly = True
        Me.dgvAppointmentList.RowHeadersWidth = 62
        Me.dgvAppointmentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAppointmentList.Size = New System.Drawing.Size(924, 282)
        Me.dgvAppointmentList.TabIndex = 82
        '
        'txtPatientMiddleInitial
        '
        Me.txtPatientMiddleInitial.Enabled = False
        Me.txtPatientMiddleInitial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientMiddleInitial.Location = New System.Drawing.Point(855, 153)
        Me.txtPatientMiddleInitial.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPatientMiddleInitial.Name = "txtPatientMiddleInitial"
        Me.txtPatientMiddleInitial.Size = New System.Drawing.Size(192, 40)
        Me.txtPatientMiddleInitial.TabIndex = 75
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.cbAppointmentStatus)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dtpAppointmentDate)
        Me.GroupBox1.Controls.Add(Me.txtDoctorId)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnDoctorIdSearch)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtDoctorMiddleInitial)
        Me.GroupBox1.Controls.Add(Me.txtDoctorLastName)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtDoctorFirstName)
        Me.GroupBox1.Controls.Add(Me.txtPatientId)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btnPatientIdSearch)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPatientMiddleInitial)
        Me.GroupBox1.Controls.Add(Me.txtPatientLastName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPatientFirstName)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(54, 118)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1090, 635)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Appointment Information"
        '
        'cbAppointmentStatus
        '
        Me.cbAppointmentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAppointmentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAppointmentStatus.FormattingEnabled = True
        Me.cbAppointmentStatus.Items.AddRange(New Object() {"Scheduled", "Completed", "Cancelled"})
        Me.cbAppointmentStatus.Location = New System.Drawing.Point(445, 531)
        Me.cbAppointmentStatus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbAppointmentStatus.Name = "cbAppointmentStatus"
        Me.cbAppointmentStatus.Size = New System.Drawing.Size(396, 41)
        Me.cbAppointmentStatus.TabIndex = 84
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(439, 480)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(268, 33)
        Me.Label10.TabIndex = 99
        Me.Label10.Text = "Appointment Status"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(36, 480)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(247, 33)
        Me.Label9.TabIndex = 97
        Me.Label9.Text = "Appointment Date"
        '
        'dtpAppointmentDate
        '
        Me.dtpAppointmentDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAppointmentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAppointmentDate.Location = New System.Drawing.Point(42, 533)
        Me.dtpAppointmentDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpAppointmentDate.Name = "dtpAppointmentDate"
        Me.dtpAppointmentDate.Size = New System.Drawing.Size(392, 35)
        Me.dtpAppointmentDate.TabIndex = 96
        '
        'txtDoctorId
        '
        Me.txtDoctorId.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctorId.Location = New System.Drawing.Point(202, 247)
        Me.txtDoctorId.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.txtDoctorId.Name = "txtDoctorId"
        Me.txtDoctorId.Size = New System.Drawing.Size(99, 39)
        Me.txtDoctorId.TabIndex = 95
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(849, 303)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 33)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Middle Initial"
        '
        'btnDoctorIdSearch
        '
        Me.btnDoctorIdSearch.Location = New System.Drawing.Point(312, 247)
        Me.btnDoctorIdSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDoctorIdSearch.Name = "btnDoctorIdSearch"
        Me.btnDoctorIdSearch.Size = New System.Drawing.Size(122, 43)
        Me.btnDoctorIdSearch.TabIndex = 94
        Me.btnDoctorIdSearch.Text = "Search"
        Me.btnDoctorIdSearch.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 308)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 33)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "First Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 251)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 35)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Doctor ID"
        '
        'txtDoctorMiddleInitial
        '
        Me.txtDoctorMiddleInitial.Enabled = False
        Me.txtDoctorMiddleInitial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctorMiddleInitial.Location = New System.Drawing.Point(855, 350)
        Me.txtDoctorMiddleInitial.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDoctorMiddleInitial.Name = "txtDoctorMiddleInitial"
        Me.txtDoctorMiddleInitial.Size = New System.Drawing.Size(192, 40)
        Me.txtDoctorMiddleInitial.TabIndex = 92
        '
        'txtDoctorLastName
        '
        Me.txtDoctorLastName.Enabled = False
        Me.txtDoctorLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctorLastName.Location = New System.Drawing.Point(445, 350)
        Me.txtDoctorLastName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDoctorLastName.Name = "txtDoctorLastName"
        Me.txtDoctorLastName.Size = New System.Drawing.Size(396, 40)
        Me.txtDoctorLastName.TabIndex = 88
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(439, 308)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 33)
        Me.Label8.TabIndex = 89
        Me.Label8.Text = "Last Name"
        '
        'txtDoctorFirstName
        '
        Me.txtDoctorFirstName.Enabled = False
        Me.txtDoctorFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctorFirstName.Location = New System.Drawing.Point(42, 350)
        Me.txtDoctorFirstName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDoctorFirstName.Name = "txtDoctorFirstName"
        Me.txtDoctorFirstName.Size = New System.Drawing.Size(392, 40)
        Me.txtDoctorFirstName.TabIndex = 87
        '
        'txtPatientId
        '
        Me.txtPatientId.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientId.Location = New System.Drawing.Point(202, 50)
        Me.txtPatientId.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.txtPatientId.Name = "txtPatientId"
        Me.txtPatientId.Size = New System.Drawing.Size(99, 39)
        Me.txtPatientId.TabIndex = 86
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(849, 106)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(178, 33)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Middle Initial"
        '
        'btnPatientIdSearch
        '
        Me.btnPatientIdSearch.Location = New System.Drawing.Point(312, 50)
        Me.btnPatientIdSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPatientIdSearch.Name = "btnPatientIdSearch"
        Me.btnPatientIdSearch.Size = New System.Drawing.Size(122, 43)
        Me.btnPatientIdSearch.TabIndex = 85
        Me.btnPatientIdSearch.Text = "Search"
        Me.btnPatientIdSearch.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 111)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 33)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 54)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 35)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Patient ID"
        '
        'txtPatientLastName
        '
        Me.txtPatientLastName.Enabled = False
        Me.txtPatientLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientLastName.Location = New System.Drawing.Point(445, 153)
        Me.txtPatientLastName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPatientLastName.Name = "txtPatientLastName"
        Me.txtPatientLastName.Size = New System.Drawing.Size(396, 40)
        Me.txtPatientLastName.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(439, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 33)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Last Name"
        '
        'txtPatientFirstName
        '
        Me.txtPatientFirstName.Enabled = False
        Me.txtPatientFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientFirstName.Location = New System.Drawing.Point(42, 153)
        Me.txtPatientFirstName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPatientFirstName.Name = "txtPatientFirstName"
        Me.txtPatientFirstName.Size = New System.Drawing.Size(392, 40)
        Me.txtPatientFirstName.TabIndex = 32
        '
        'btnAppointmentIdSearch
        '
        Me.btnAppointmentIdSearch.Location = New System.Drawing.Point(448, 51)
        Me.btnAppointmentIdSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAppointmentIdSearch.Name = "btnAppointmentIdSearch"
        Me.btnAppointmentIdSearch.Size = New System.Drawing.Size(134, 43)
        Me.btnAppointmentIdSearch.TabIndex = 78
        Me.btnAppointmentIdSearch.Text = "Search"
        Me.btnAppointmentIdSearch.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.AllowDrop = True
        Me.btnHome.Location = New System.Drawing.Point(1003, 38)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(141, 52)
        Me.btnHome.TabIndex = 77
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(1003, 844)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(141, 57)
        Me.btnSave.TabIndex = 76
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 35)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Appointment ID"
        '
        'btnAddNew
        '
        Me.btnAddNew.AutoSize = True
        Me.btnAddNew.Location = New System.Drawing.Point(1003, 772)
        Me.btnAddNew.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(141, 57)
        Me.btnAddNew.TabIndex = 73
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(1003, 997)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(141, 57)
        Me.btnDelete.TabIndex = 80
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(1003, 922)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(141, 54)
        Me.btnUpdate.TabIndex = 79
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'ManageAppointmentsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ClinicReservationManagementSystem.My.Resources.Resources.Blue_Modern_Medical_Promotion_Video__1_
        Me.ClientSize = New System.Drawing.Size(1192, 1068)
        Me.Controls.Add(Me.txtAppointmentId)
        Me.Controls.Add(Me.dgvAppointmentList)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAppointmentIdSearch)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1214, 1124)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1214, 1124)
        Me.Name = "ManageAppointmentsForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Appointments"
        CType(Me.txtAppointmentId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAppointmentList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtDoctorId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPatientId, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAppointmentId As NumericUpDown
    Friend WithEvents dgvAppointmentList As DataGridView
    Friend WithEvents txtPatientMiddleInitial As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPatientLastName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPatientFirstName As TextBox
    Friend WithEvents btnAppointmentIdSearch As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtDoctorId As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents btnDoctorIdSearch As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDoctorMiddleInitial As TextBox
    Friend WithEvents txtDoctorLastName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDoctorFirstName As TextBox
    Friend WithEvents txtPatientId As NumericUpDown
    Friend WithEvents btnPatientIdSearch As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpAppointmentDate As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents cbAppointmentStatus As ComboBox
End Class
