Public Class frmLab2

    
    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim vistra, Computer, sum As Long
        vistra = txtSalesVistra.Text * 5 / 100
        Computer = txtSalesComputer.Text * 10 / 100
        sum = Val(txtSalesVistra.Text) + Val(txtSalesComputer.Text)
        lblsum.Text = sum
        lblcom.Text = vistra + Computer

    End Sub
End Class