Public Class frmLab0





    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        'ค่าจ้าง = ชั่วโมงการทำงาน* อัตรค่าจ้างต่อชั่วโมง
        'ชั่วโมงการทำงาน => txtHour.Text
        'อัตราค่าจ้างต่อชั่วโมง => txtPayRate.Text
        'ค่าจ้าง => lblTotal.Text
        lblTotal.Text = Val(txtHour.Text) * Val(txtPayRate.Text)
        lblTax.Text = Val(lblTotal.Text) * 3 / 100



    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'ค่าจ้าง =ชั่วโมงการทำงาน * อัตราค่าจ้างต่อชั่วโมง
        Dim hour As Integer
        Dim payRate, total, tax As Double


        hour = Val(txtHour.Text)
        payRate = Val(txtPayRate.Text)




    End Sub
End Class
