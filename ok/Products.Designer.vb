<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Products
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.DataViewDiagram = New System.Windows.Forms.DataGridView()
        Me.BtnAddProduct = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataViewDiagram, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(12, 40)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(75, 23)
        Me.BtnBack.TabIndex = 0
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'DataViewDiagram
        '
        Me.DataViewDiagram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataViewDiagram.Location = New System.Drawing.Point(140, 40)
        Me.DataViewDiagram.Name = "DataViewDiagram"
        Me.DataViewDiagram.RowTemplate.Height = 25
        Me.DataViewDiagram.Size = New System.Drawing.Size(544, 194)
        Me.DataViewDiagram.TabIndex = 1
        '
        'BtnAddProduct
        '
        Me.BtnAddProduct.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnAddProduct.Location = New System.Drawing.Point(229, 272)
        Me.BtnAddProduct.Name = "BtnAddProduct"
        Me.BtnAddProduct.Size = New System.Drawing.Size(142, 23)
        Me.BtnAddProduct.TabIndex = 2
        Me.BtnAddProduct.Text = "Import"
        Me.BtnAddProduct.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Location = New System.Drawing.Point(475, 272)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Upload"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 421)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnAddProduct)
        Me.Controls.Add(Me.DataViewDiagram)
        Me.Controls.Add(Me.BtnBack)
        Me.Name = "Products"
        Me.Text = "Product Page"
        CType(Me.DataViewDiagram, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnBack As Button
    Friend WithEvents DataViewDiagram As DataGridView
    Friend WithEvents BtnAddProduct As Button
    Friend WithEvents Button1 As Button
End Class
