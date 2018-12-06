<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab2
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSalesVistra = New System.Windows.Forms.TextBox()
        Me.txtSalesComputer = New System.Windows.Forms.TextBox()
        Me.lblsum = New System.Windows.Forms.Label()
        Me.lblcom = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ยอดขาย Vistra Gluta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ยอดขาย Computer Toshiba Extra520x"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(88, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "ยอดขายรวม"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(88, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "ค่าคอมมิชชั่นรวม"
        '
        'txtSalesVistra
        '
        Me.txtSalesVistra.Location = New System.Drawing.Point(327, 56)
        Me.txtSalesVistra.Name = "txtSalesVistra"
        Me.txtSalesVistra.Size = New System.Drawing.Size(100, 20)
        Me.txtSalesVistra.TabIndex = 2
        '
        'txtSalesComputer
        '
        Me.txtSalesComputer.Location = New System.Drawing.Point(327, 91)
        Me.txtSalesComputer.Name = "txtSalesComputer"
        Me.txtSalesComputer.Size = New System.Drawing.Size(100, 20)
        Me.txtSalesComputer.TabIndex = 2
        '
        'lblsum
        '
        Me.lblsum.BackColor = System.Drawing.Color.OrangeRed
        Me.lblsum.Location = New System.Drawing.Point(327, 124)
        Me.lblsum.Name = "lblsum"
        Me.lblsum.Size = New System.Drawing.Size(100, 23)
        Me.lblsum.TabIndex = 3
        Me.lblsum.Text = " "
        '
        'lblcom
        '
        Me.lblcom.BackColor = System.Drawing.Color.OrangeRed
        Me.lblcom.Location = New System.Drawing.Point(327, 157)
        Me.lblcom.Name = "lblcom"
        Me.lblcom.Size = New System.Drawing.Size(100, 23)
        Me.lblcom.TabIndex = 3
        Me.lblcom.Text = " "
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(316, 233)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "คำนวณ"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmLab2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 419)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblcom)
        Me.Controls.Add(Me.lblsum)
        Me.Controls.Add(Me.txtSalesComputer)
        Me.Controls.Add(Me.txtSalesVistra)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab2"
        Me.Text = "frmLab2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSalesVistra As System.Windows.Forms.TextBox
    Friend WithEvents txtSalesComputer As System.Windows.Forms.TextBox
    Friend WithEvents lblsum As System.Windows.Forms.Label
    Friend WithEvents lblcom As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
End Class
