<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIncomes = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblIncomes = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รายได้ทั้งปี"
        '
        'txtIncomes
        '
        Me.txtIncomes.Location = New System.Drawing.Point(214, 96)
        Me.txtIncomes.Name = "txtIncomes"
        Me.txtIncomes.Size = New System.Drawing.Size(100, 20)
        Me.txtIncomes.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ภาษีที่ต้องชำระ"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Coral
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(211, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "รับข้อมูลเงินเดือน"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "เงินได้คงเหลือ"
        '
        'lblNet
        '
        Me.lblNet.BackColor = System.Drawing.Color.Magenta
        Me.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNet.Location = New System.Drawing.Point(214, 195)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(118, 23)
        Me.lblNet.TabIndex = 5
        Me.lblNet.Text = " "
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(225, 235)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "คำนวณ"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(214, 96)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(118, 20)
        Me.txtSalary.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(95, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "เงินเดือน"
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.Color.Magenta
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTax.Location = New System.Drawing.Point(214, 163)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(118, 23)
        Me.lblTax.TabIndex = 5
        Me.lblTax.Text = "         "
        '
        'lblIncomes
        '
        Me.lblIncomes.BackColor = System.Drawing.Color.Magenta
        Me.lblIncomes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIncomes.Location = New System.Drawing.Point(214, 134)
        Me.lblIncomes.Name = "lblIncomes"
        Me.lblIncomes.Size = New System.Drawing.Size(118, 23)
        Me.lblIncomes.TabIndex = 5
        Me.lblIncomes.Text = " "
        '
        'frmLab1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 410)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblIncomes)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblNet)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.txtIncomes)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab1"
        Me.Text = "frmLab2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIncomes As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblNet As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblIncomes As System.Windows.Forms.Label
End Class
