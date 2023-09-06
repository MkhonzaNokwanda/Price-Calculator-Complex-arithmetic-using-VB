Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPriceForCustomer.Click
        'Delare Variables
        Dim strCustomerName As String
        Dim dPricePerUnit As Decimal
        Dim iQuantity As Integer
        Dim dTotalAmount As Decimal

        strCustomerName = txtCustomerName.Text
        dPricePerUnit = txtPricePerUnit.Text
        iQuantity = txtQuantity.Text
        dTotalAmount = dPricePerUnit * iQuantity

        'Print the Total Cost of the product
        MessageBox.Show(strCustomerName & " " & "your total is" & " " & "R" & dTotalAmount)
    End Sub

    Private Sub lblQuantity_Click(sender As Object, e As EventArgs) Handles lblQuantity.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerName.TextChanged

    End Sub

    Private Sub txtPricePerUnit_TextChanged(sender As Object, e As EventArgs) Handles txtPricePerUnit.TextChanged

    End Sub
End Class
