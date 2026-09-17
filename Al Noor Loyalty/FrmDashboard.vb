
Public Class FrmDashboard

    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvCustomers.Rows.Clear()

        dgvCustomers.Rows.Add(
        "C0001",
        "Ahmed Mohamed",
        "0501234567",
        "ahmed@email.com",
        "17/09/2026",
        "6",
        "12",
        "450 AED",
        "17/09/2026",
        "2 Cups",
        "Active"
    )

        dgvCustomers.Rows.Add(
        "C0002",
        "Sara Ali",
        "0559876543",
        "sara@email.com",
        "15/09/2026",
        "3",
        "7",
        "280 AED",
        "16/09/2026",
        "1 Cup",
        "Active"
    )

        dgvCustomers.Rows.Add(
        "C0003",
        "Mohamed Khaled",
        "0525551234",
        "mohamed@email.com",
        "10/09/2026",
        "8",
        "15",
        "620 AED",
        "17/09/2026",
        "FREE DRINK",
        "Reward Ready"
    )

    End Sub

    Private Sub btnQRCode_Click(sender As Object, e As EventArgs) Handles btnQRCode.Click
        If dgvCustomers.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a customer first.",
                            "QR Code",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Return
        End If

        Dim customerId As String =
    dgvCustomers.SelectedRows(0).Cells(0).Value.ToString()

        Dim customerName As String =
    dgvCustomers.SelectedRows(0).Cells(1).Value.ToString()

        Dim qrForm As New FrmQRCode(customerId, customerName)

        qrForm.ShowDialog()
    End Sub
End Class