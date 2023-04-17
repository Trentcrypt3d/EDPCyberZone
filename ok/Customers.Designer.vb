<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customers
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
        Me.CustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.CustomerName})
        Me.DataGridView1.Location = New System.Drawing.Point(153, 57)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(544, 194)
        Me.DataGridView1.TabIndex = 5
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnEdit.Location = New System.Drawing.Point(361, 300)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(135, 23)
        Me.BtnEdit.TabIndex = 9
        Me.BtnEdit.Text = "Edit A Customer"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnDelete.Location = New System.Drawing.Point(562, 300)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(135, 23)
        Me.BtnDelete.TabIndex = 8
        Me.BtnDelete.Text = "Delete A Customer"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnAdd.Location = New System.Drawing.Point(153, 300)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(135, 23)
        Me.BtnAdd.TabIndex = 7
        Me.BtnAdd.Text = "Add A New Customer"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(29, 57)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(75, 23)
        Me.BtnBack.TabIndex = 6
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'CustomerName
        '
        Me.CustomerName.HeaderText = "Customer Name"
        Me.CustomerName.Name = "CustomerName"
        '
        'Customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnBack)
        Me.Name = "Customers"
        Me.Text = "Customer Page"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents CustomerName As DataGridViewTextBoxColumn
End Class
