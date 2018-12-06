Public Class frmLab1

   
    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        lblIncomes.Text = Val(txtSalary.Text) * 12
        lblTax.Text = lblIncomes.Text * 5 / 100
        lblNet.Text = lblIncomes.Text - lblTax.Text
    End Sub
End Class