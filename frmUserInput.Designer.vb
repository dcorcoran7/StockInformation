<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserInput
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
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTicker = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmployees = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMarketCap = New System.Windows.Forms.TextBox()
        Me.lblDatabase = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Company"
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(122, 29)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(136, 26)
        Me.txtCompany.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ticker"
        '
        'txtTicker
        '
        Me.txtTicker.Location = New System.Drawing.Point(122, 69)
        Me.txtTicker.Name = "txtTicker"
        Me.txtTicker.Size = New System.Drawing.Size(136, 26)
        Me.txtTicker.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Employees"
        '
        'txtEmployees
        '
        Me.txtEmployees.Location = New System.Drawing.Point(123, 148)
        Me.txtEmployees.Name = "txtEmployees"
        Me.txtEmployees.Size = New System.Drawing.Size(136, 26)
        Me.txtEmployees.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Market cap"
        '
        'txtMarketCap
        '
        Me.txtMarketCap.Location = New System.Drawing.Point(122, 106)
        Me.txtMarketCap.Name = "txtMarketCap"
        Me.txtMarketCap.Size = New System.Drawing.Size(136, 26)
        Me.txtMarketCap.TabIndex = 5
        '
        'lblDatabase
        '
        Me.lblDatabase.BackColor = System.Drawing.Color.White
        Me.lblDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDatabase.Enabled = False
        Me.lblDatabase.Location = New System.Drawing.Point(332, 29)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(402, 225)
        Me.lblDatabase.TabIndex = 13
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(122, 291)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(136, 43)
        Me.btnEnter.TabIndex = 9
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(651, 291)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(84, 43)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(264, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "billion"
        '
        'frmUserInput
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(778, 351)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblDatabase)
        Me.Controls.Add(Me.txtMarketCap)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEmployees)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTicker)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmUserInput"
        Me.Text = "User Input"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCompany As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTicker As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmployees As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMarketCap As TextBox
    Friend WithEvents lblDatabase As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label7 As Label
End Class
