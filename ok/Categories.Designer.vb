<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categories
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
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Name})
        Me.DataGridView1.Location = New System.Drawing.Point(150, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(544, 194)
        Me.DataGridView1.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'Name
        '
        Me.Name.HeaderText = "Name"
        Me.Name.Name = "Name"
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(26, 48)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(75, 23)
        Me.BtnBack.TabIndex = 1
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Location = New System.Drawing.Point(150, 291)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Add A New Category"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnDelete.Location = New System.Drawing.Point(559, 291)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(135, 23)
        Me.BtnDelete.TabIndex = 3
        Me.BtnDelete.Text = "Delete A Category"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnUpdate.Location = New System.Drawing.Point(358, 291)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(135, 23)
        Me.BtnUpdate.TabIndex = 4
        Me.BtnUpdate.Text = "Update A Category"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'Categories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 421)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.DataGridView1)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Name As DataGridViewTextBoxColumn
    Friend WithEvents BtnBack As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
End Class
