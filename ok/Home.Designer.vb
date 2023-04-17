<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomePage))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BttnLogout = New System.Windows.Forms.Button()
        Me.btnCategories = New System.Windows.Forms.Button()
        Me.BtnProduct = New System.Windows.Forms.Button()
        Me.BtnCustomer = New System.Windows.Forms.Button()
        Me.BtnOrders = New System.Windows.Forms.Button()
        Me.BtnAccounts = New System.Windows.Forms.Button()
        Me.btnBackup = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(222, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(602, 74)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BttnLogout
        '
        Me.BttnLogout.Location = New System.Drawing.Point(929, 403)
        Me.BttnLogout.Name = "BttnLogout"
        Me.BttnLogout.Size = New System.Drawing.Size(82, 27)
        Me.BttnLogout.TabIndex = 1
        Me.BttnLogout.Text = "Logout"
        Me.BttnLogout.UseVisualStyleBackColor = True
        '
        'btnCategories
        '
        Me.btnCategories.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCategories.Location = New System.Drawing.Point(137, 274)
        Me.btnCategories.Name = "btnCategories"
        Me.btnCategories.Size = New System.Drawing.Size(121, 48)
        Me.btnCategories.TabIndex = 2
        Me.btnCategories.Text = "Categories"
        Me.btnCategories.UseVisualStyleBackColor = False
        '
        'BtnProduct
        '
        Me.BtnProduct.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnProduct.Location = New System.Drawing.Point(298, 274)
        Me.BtnProduct.Name = "BtnProduct"
        Me.BtnProduct.Size = New System.Drawing.Size(121, 48)
        Me.BtnProduct.TabIndex = 3
        Me.BtnProduct.Text = "Products"
        Me.BtnProduct.UseVisualStyleBackColor = False
        '
        'BtnCustomer
        '
        Me.BtnCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnCustomer.Location = New System.Drawing.Point(463, 274)
        Me.BtnCustomer.Name = "BtnCustomer"
        Me.BtnCustomer.Size = New System.Drawing.Size(121, 48)
        Me.BtnCustomer.TabIndex = 4
        Me.BtnCustomer.Text = "Customers"
        Me.BtnCustomer.UseVisualStyleBackColor = False
        '
        'BtnOrders
        '
        Me.BtnOrders.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnOrders.Location = New System.Drawing.Point(628, 274)
        Me.BtnOrders.Name = "BtnOrders"
        Me.BtnOrders.Size = New System.Drawing.Size(121, 48)
        Me.BtnOrders.TabIndex = 5
        Me.BtnOrders.Text = "Orders"
        Me.BtnOrders.UseVisualStyleBackColor = False
        '
        'BtnAccounts
        '
        Me.BtnAccounts.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnAccounts.Location = New System.Drawing.Point(791, 274)
        Me.BtnAccounts.Name = "BtnAccounts"
        Me.BtnAccounts.Size = New System.Drawing.Size(121, 48)
        Me.BtnAccounts.TabIndex = 6
        Me.BtnAccounts.Text = "Accounts"
        Me.BtnAccounts.UseVisualStyleBackColor = False
        '
        'btnBackup
        '
        Me.btnBackup.Location = New System.Drawing.Point(61, 389)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(121, 23)
        Me.btnBackup.TabIndex = 7
        Me.btnBackup.Text = "Backup Database"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 442)
        Me.Controls.Add(Me.btnBackup)
        Me.Controls.Add(Me.BtnAccounts)
        Me.Controls.Add(Me.BtnOrders)
        Me.Controls.Add(Me.BtnCustomer)
        Me.Controls.Add(Me.BtnProduct)
        Me.Controls.Add(Me.btnCategories)
        Me.Controls.Add(Me.BttnLogout)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "HomePage"
        Me.Text = "Home Page"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BttnLogout As Button
    Friend WithEvents btnCategories As Button
    Friend WithEvents BtnProduct As Button
    Friend WithEvents BtnCustomer As Button
    Friend WithEvents BtnOrders As Button
    Friend WithEvents BtnAccounts As Button
    Friend WithEvents btnBackup As Button
End Class
