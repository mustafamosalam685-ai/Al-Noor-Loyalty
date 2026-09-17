Imports QRCoder
Imports System.Drawing

Public Class FrmQRCode

    Private customerId As String
    Private customerName As String

    Public Sub New(id As String, name As String)

        InitializeComponent()

        customerId = id
        customerName = name

    End Sub

    Private Sub FrmQRCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' عرض بيانات العميل
        lblCustomerID.Text = "Customer ID: " & customerId
        lblCustomerName.Text = customerName

        ' البيانات التي سيتم تخزينها داخل QR
        Dim qrText As String = "ALNOOR:" & customerId

        ' إنشاء QR Code
        Dim qrGenerator As New QRCodeGenerator()
        Dim qrData = qrGenerator.CreateQrCode(
            qrText,
            QRCodeGenerator.ECCLevel.Q
        )

        Dim qrCode As New QRCode(qrData)

        ' إنشاء صورة QR
        Dim qrImage As Bitmap = qrCode.GetGraphic(10)

        ' عرض QR
        picQRCode.Image = qrImage
        picQRCode.SizeMode = PictureBoxSizeMode.Zoom

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

End Class