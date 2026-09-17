<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDashboard
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
        Panel1 = New Panel()
        btnLogout = New Button()
        btnQRCode = New Button()
        btnRewards = New Button()
        btnSettings = New Button()
        btnReports = New Button()
        btnCustomers = New Button()
        btnDashboard = New Button()
        dgvCustomers = New DataGridView()
        colCustomerID = New DataGridViewTextBoxColumn()
        colName = New DataGridViewTextBoxColumn()
        colMobile = New DataGridViewTextBoxColumn()
        colEmail = New DataGridViewTextBoxColumn()
        colJoinDate = New DataGridViewTextBoxColumn()
        colPoints = New DataGridViewTextBoxColumn()
        colVisits = New DataGridViewTextBoxColumn()
        colTotalSpend = New DataGridViewTextBoxColumn()
        colLastvisit = New DataGridViewTextBoxColumn()
        colReward = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        CType(dgvCustomers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(btnQRCode)
        Panel1.Controls.Add(btnRewards)
        Panel1.Controls.Add(btnSettings)
        Panel1.Controls.Add(btnReports)
        Panel1.Controls.Add(btnCustomers)
        Panel1.Controls.Add(btnDashboard)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(143, 637)
        Panel1.TabIndex = 0
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(33, 315)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(75, 23)
        btnLogout.TabIndex = 6
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnQRCode
        ' 
        btnQRCode.Location = New Point(33, 270)
        btnQRCode.Name = "btnQRCode"
        btnQRCode.Size = New Size(75, 23)
        btnQRCode.TabIndex = 5
        btnQRCode.Text = "QR Code"
        btnQRCode.UseVisualStyleBackColor = True
        ' 
        ' btnRewards
        ' 
        btnRewards.Location = New Point(33, 227)
        btnRewards.Name = "btnRewards"
        btnRewards.Size = New Size(75, 23)
        btnRewards.TabIndex = 4
        btnRewards.Text = "Rewards"
        btnRewards.UseVisualStyleBackColor = True
        ' 
        ' btnSettings
        ' 
        btnSettings.Location = New Point(33, 184)
        btnSettings.Name = "btnSettings"
        btnSettings.Size = New Size(75, 23)
        btnSettings.TabIndex = 3
        btnSettings.Text = "Settings"
        btnSettings.UseVisualStyleBackColor = True
        ' 
        ' btnReports
        ' 
        btnReports.Location = New Point(33, 142)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(75, 23)
        btnReports.TabIndex = 2
        btnReports.Text = "Reports"
        btnReports.UseVisualStyleBackColor = True
        ' 
        ' btnCustomers
        ' 
        btnCustomers.Location = New Point(33, 101)
        btnCustomers.Name = "btnCustomers"
        btnCustomers.Size = New Size(75, 23)
        btnCustomers.TabIndex = 1
        btnCustomers.Text = "Customers"
        btnCustomers.UseVisualStyleBackColor = True
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Location = New Point(33, 62)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(75, 23)
        btnDashboard.TabIndex = 0
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = True
        ' 
        ' dgvCustomers
        ' 
        dgvCustomers.AllowUserToAddRows = False
        dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCustomers.Columns.AddRange(New DataGridViewColumn() {colCustomerID, colName, colMobile, colEmail, colJoinDate, colPoints, colVisits, colTotalSpend, colLastvisit, colReward, colStatus})
        dgvCustomers.Location = New Point(187, 149)
        dgvCustomers.Name = "dgvCustomers"
        dgvCustomers.ReadOnly = True
        dgvCustomers.Size = New Size(850, 500)
        dgvCustomers.TabIndex = 1
        ' 
        ' colCustomerID
        ' 
        colCustomerID.HeaderText = "CustomerID"
        colCustomerID.Name = "colCustomerID"
        colCustomerID.ReadOnly = True
        ' 
        ' colName
        ' 
        colName.HeaderText = "Full Name"
        colName.Name = "colName"
        colName.ReadOnly = True
        ' 
        ' colMobile
        ' 
        colMobile.HeaderText = "Mobile"
        colMobile.Name = "colMobile"
        colMobile.ReadOnly = True
        ' 
        ' colEmail
        ' 
        colEmail.HeaderText = "Email"
        colEmail.Name = "colEmail"
        colEmail.ReadOnly = True
        ' 
        ' colJoinDate
        ' 
        colJoinDate.HeaderText = "Join Date"
        colJoinDate.Name = "colJoinDate"
        colJoinDate.ReadOnly = True
        ' 
        ' colPoints
        ' 
        colPoints.HeaderText = "Points"
        colPoints.Name = "colPoints"
        colPoints.ReadOnly = True
        ' 
        ' colVisits
        ' 
        colVisits.HeaderText = "Visits"
        colVisits.Name = "colVisits"
        colVisits.ReadOnly = True
        ' 
        ' colTotalSpend
        ' 
        colTotalSpend.HeaderText = "Total Spend"
        colTotalSpend.Name = "colTotalSpend"
        colTotalSpend.ReadOnly = True
        ' 
        ' colLastvisit
        ' 
        colLastvisit.HeaderText = "Last Visit"
        colLastvisit.Name = "colLastvisit"
        colLastvisit.ReadOnly = True
        ' 
        ' colReward
        ' 
        colReward.HeaderText = "Reward"
        colReward.Name = "colReward"
        colReward.ReadOnly = True
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        ' 
        ' FrmDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1184, 661)
        Controls.Add(dgvCustomers)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmDashboard"
        Text = "Al Noor Loyalty - Dashboard"
        Panel1.ResumeLayout(False)
        CType(dgvCustomers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnQRCode As Button
    Friend WithEvents btnRewards As Button
    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents colCustomerID As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colMobile As DataGridViewTextBoxColumn
    Friend WithEvents colEmail As DataGridViewTextBoxColumn
    Friend WithEvents colJoinDate As DataGridViewTextBoxColumn
    Friend WithEvents colPoints As DataGridViewTextBoxColumn
    Friend WithEvents colVisits As DataGridViewTextBoxColumn
    Friend WithEvents colTotalSpend As DataGridViewTextBoxColumn
    Friend WithEvents colLastvisit As DataGridViewTextBoxColumn
    Friend WithEvents colReward As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
End Class
