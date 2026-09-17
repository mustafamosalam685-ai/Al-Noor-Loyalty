<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQRCode
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
        picQRCode = New PictureBox()
        lblCustomerName = New Label()
        lblCustomerID = New Label()
        btnClose = New Button()
        CType(picQRCode, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picQRCode
        ' 
        picQRCode.Location = New Point(283, 44)
        picQRCode.Name = "picQRCode"
        picQRCode.Size = New Size(305, 277)
        picQRCode.TabIndex = 0
        picQRCode.TabStop = False
        ' 
        ' lblCustomerName
        ' 
        lblCustomerName.AutoSize = True
        lblCustomerName.Location = New Point(666, 100)
        lblCustomerName.Name = "lblCustomerName"
        lblCustomerName.Size = New Size(94, 15)
        lblCustomerName.TabIndex = 1
        lblCustomerName.Text = "Customer Name"
        ' 
        ' lblCustomerID
        ' 
        lblCustomerID.AutoSize = True
        lblCustomerID.Location = New Point(681, 138)
        lblCustomerID.Name = "lblCustomerID"
        lblCustomerID.Size = New Size(73, 15)
        lblCustomerID.TabIndex = 2
        lblCustomerID.Text = "Customer ID"
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(674, 174)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 23)
        btnClose.TabIndex = 3
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' FrmQRCode
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnClose)
        Controls.Add(lblCustomerID)
        Controls.Add(lblCustomerName)
        Controls.Add(picQRCode)
        Name = "FrmQRCode"
        Text = "FrmQRCode"
        CType(picQRCode, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picQRCode As PictureBox
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents btnClose As Button
End Class
