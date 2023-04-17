<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orders
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.OrderID, Me.ProductID, Me.Quantity})
        Me.DataGridView1.Location = New System.Drawing.Point(145, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(544, 194)
        Me.DataGridView1.TabIndex = 10
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnEdit.Location = New System.Drawing.Point(353, 302)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(135, 23)
        Me.BtnEdit.TabIndex = 14
        Me.BtnEdit.Text = "Update An Order"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnDelete.Location = New System.Drawing.Point(554, 302)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(135, 23)
        Me.BtnDelete.TabIndex = 13
        Me.BtnDelete.Text = "Delete An Order"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnAdd.Location = New System.Drawing.Point(145, 302)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(135, 23)
        Me.BtnAdd.TabIndex = 12
        Me.BtnAdd.Text = "Add A New Order"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(21, 59)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(75, 23)
        Me.BtnBack.TabIndex = 11
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'OrderID
        '
        Me.OrderID.HeaderText = "OrderID"
        Me.OrderID.Name = "OrderID"
        '
        'ProductID
        '
        Me.ProductID.HeaderText = "Product ID"
        Me.ProductID.Name = "ProductID"
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        '
        'Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 421)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnBack)
        Me.Name = "Orders"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents OrderID As DataGridViewTextBoxColumn
    Friend WithEvents ProductID As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnBack As Button
End Class
