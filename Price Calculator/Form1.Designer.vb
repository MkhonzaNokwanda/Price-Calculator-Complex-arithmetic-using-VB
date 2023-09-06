<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnPriceForCustomer = New System.Windows.Forms.Button()
        Me.lblPricePerUnit = New System.Windows.Forms.Label()
        Me.txtPricePerUnit = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPriceForCustomer
        '
        Me.btnPriceForCustomer.Location = New System.Drawing.Point(172, 253)
        Me.btnPriceForCustomer.Name = "btnPriceForCustomer"
        Me.btnPriceForCustomer.Size = New System.Drawing.Size(259, 78)
        Me.btnPriceForCustomer.TabIndex = 0
        Me.btnPriceForCustomer.Text = "Price for Customer"
        Me.btnPriceForCustomer.UseVisualStyleBackColor = True
        '
        'lblPricePerUnit
        '
        Me.lblPricePerUnit.AutoSize = True
        Me.lblPricePerUnit.Location = New System.Drawing.Point(168, 76)
        Me.lblPricePerUnit.Name = "lblPricePerUnit"
        Me.lblPricePerUnit.Size = New System.Drawing.Size(105, 20)
        Me.lblPricePerUnit.TabIndex = 1
        Me.lblPricePerUnit.Text = "Price Per Unit"
        '
        'txtPricePerUnit
        '
        Me.txtPricePerUnit.Location = New System.Drawing.Point(317, 76)
        Me.txtPricePerUnit.Name = "txtPricePerUnit"
        Me.txtPricePerUnit.Size = New System.Drawing.Size(100, 26)
        Me.txtPricePerUnit.TabIndex = 2
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(317, 139)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 26)
        Me.txtQuantity.TabIndex = 3
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(168, 139)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(68, 20)
        Me.lblQuantity.TabIndex = 4
        Me.lblQuantity.Text = "Quantity"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(317, 21)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(100, 26)
        Me.txtCustomerName.TabIndex = 5
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(168, 21)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(138, 20)
        Me.lblCustomerName.TabIndex = 6
        Me.lblCustomerName.Text = "Customer""s Name"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtPricePerUnit)
        Me.Controls.Add(Me.lblPricePerUnit)
        Me.Controls.Add(Me.btnPriceForCustomer)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPriceForCustomer As Button
    Friend WithEvents lblPricePerUnit As Label
    Friend WithEvents txtPricePerUnit As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents lblCustomerName As Label
End Class
