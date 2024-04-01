﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDashboard
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
        Me.AdminTabControl = New System.Windows.Forms.TabControl()
        Me.ProductsTab = New System.Windows.Forms.TabPage()
        Me.AdminBody = New System.Windows.Forms.Panel()
        Me.ProductList = New System.Windows.Forms.DataGridView()
        Me.ProductIdColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductEditButton = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ProductDeleteButton = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ProductsAdminSidePanel = New System.Windows.Forms.Panel()
        Me.AddProductButton = New System.Windows.Forms.Button()
        Me.QuantityLabel = New System.Windows.Forms.Label()
        Me.ProductDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.ProductQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.ListProducts = New System.Windows.Forms.Button()
        Me.UpdateProductButton = New System.Windows.Forms.Button()
        Me.ProductPriceTextBox = New System.Windows.Forms.TextBox()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProductsSearchBar = New System.Windows.Forms.Panel()
        Me.ProductsSearchButton = New System.Windows.Forms.Button()
        Me.ProductsSearchInput = New System.Windows.Forms.TextBox()
        Me.StaffTab = New System.Windows.Forms.TabPage()
        Me.StaffList = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffRole = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffEmptyColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffEditButton = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.StaffDeleteButton = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.StaffAdminSidePanel = New System.Windows.Forms.Panel()
        Me.StaffClearButton = New System.Windows.Forms.Button()
        Me.StaffUpdateButton = New System.Windows.Forms.Button()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.RoleLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.StaffRoleComboBox = New System.Windows.Forms.ComboBox()
        Me.StaffEmailTextBox = New System.Windows.Forms.TextBox()
        Me.StaffNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddStaff = New System.Windows.Forms.Button()
        Me.ListStaffButton = New System.Windows.Forms.Button()
        Me.StaffSearchBar = New System.Windows.Forms.Panel()
        Me.StaffSearchButton = New System.Windows.Forms.Button()
        Me.StaffSearchInput = New System.Windows.Forms.TextBox()
        Me.ReportsTab = New System.Windows.Forms.TabPage()
        Me.AdminTabControl.SuspendLayout()
        Me.ProductsTab.SuspendLayout()
        Me.AdminBody.SuspendLayout()
        CType(Me.ProductList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductsAdminSidePanel.SuspendLayout()
        Me.ProductsSearchBar.SuspendLayout()
        Me.StaffTab.SuspendLayout()
        CType(Me.StaffList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StaffAdminSidePanel.SuspendLayout()
        Me.StaffSearchBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'AdminTabControl
        '
        Me.AdminTabControl.Controls.Add(Me.ProductsTab)
        Me.AdminTabControl.Controls.Add(Me.StaffTab)
        Me.AdminTabControl.Controls.Add(Me.ReportsTab)
        Me.AdminTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdminTabControl.Location = New System.Drawing.Point(0, 0)
        Me.AdminTabControl.Margin = New System.Windows.Forms.Padding(2)
        Me.AdminTabControl.Name = "AdminTabControl"
        Me.AdminTabControl.SelectedIndex = 0
        Me.AdminTabControl.Size = New System.Drawing.Size(764, 377)
        Me.AdminTabControl.TabIndex = 0
        '
        'ProductsTab
        '
        Me.ProductsTab.Controls.Add(Me.AdminBody)
        Me.ProductsTab.Controls.Add(Me.ProductsAdminSidePanel)
        Me.ProductsTab.Controls.Add(Me.ProductsSearchBar)
        Me.ProductsTab.Location = New System.Drawing.Point(4, 22)
        Me.ProductsTab.Margin = New System.Windows.Forms.Padding(2)
        Me.ProductsTab.Name = "ProductsTab"
        Me.ProductsTab.Padding = New System.Windows.Forms.Padding(2)
        Me.ProductsTab.Size = New System.Drawing.Size(756, 351)
        Me.ProductsTab.TabIndex = 0
        Me.ProductsTab.Text = "PRODUCTS"
        Me.ProductsTab.UseVisualStyleBackColor = True
        '
        'AdminBody
        '
        Me.AdminBody.Controls.Add(Me.ProductList)
        Me.AdminBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdminBody.Location = New System.Drawing.Point(2, 129)
        Me.AdminBody.Margin = New System.Windows.Forms.Padding(2)
        Me.AdminBody.Name = "AdminBody"
        Me.AdminBody.Size = New System.Drawing.Size(752, 220)
        Me.AdminBody.TabIndex = 3
        '
        'ProductList
        '
        Me.ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIdColumn, Me.NameColumn, Me.PriceColumn, Me.QuantityColumn, Me.DescriptionColumn, Me.empty, Me.ProductEditButton, Me.ProductDeleteButton})
        Me.ProductList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductList.Location = New System.Drawing.Point(0, 0)
        Me.ProductList.Margin = New System.Windows.Forms.Padding(2)
        Me.ProductList.Name = "ProductList"
        Me.ProductList.RowHeadersWidth = 51
        Me.ProductList.RowTemplate.Height = 24
        Me.ProductList.Size = New System.Drawing.Size(752, 220)
        Me.ProductList.TabIndex = 0
        '
        'ProductIdColumn
        '
        Me.ProductIdColumn.Frozen = True
        Me.ProductIdColumn.HeaderText = "Id"
        Me.ProductIdColumn.Name = "ProductIdColumn"
        Me.ProductIdColumn.ReadOnly = True
        Me.ProductIdColumn.Visible = False
        '
        'NameColumn
        '
        Me.NameColumn.Frozen = True
        Me.NameColumn.HeaderText = "Name"
        Me.NameColumn.Name = "NameColumn"
        Me.NameColumn.ReadOnly = True
        '
        'PriceColumn
        '
        Me.PriceColumn.HeaderText = "Price"
        Me.PriceColumn.Name = "PriceColumn"
        Me.PriceColumn.ReadOnly = True
        '
        'QuantityColumn
        '
        Me.QuantityColumn.HeaderText = "Quantity"
        Me.QuantityColumn.Name = "QuantityColumn"
        Me.QuantityColumn.ReadOnly = True
        '
        'DescriptionColumn
        '
        Me.DescriptionColumn.HeaderText = "Description"
        Me.DescriptionColumn.Name = "DescriptionColumn"
        Me.DescriptionColumn.ReadOnly = True
        '
        'empty
        '
        Me.empty.HeaderText = ""
        Me.empty.Name = "empty"
        '
        'ProductEditButton
        '
        Me.ProductEditButton.HeaderText = ""
        Me.ProductEditButton.Name = "ProductEditButton"
        Me.ProductEditButton.Text = "Edit"
        '
        'ProductDeleteButton
        '
        Me.ProductDeleteButton.HeaderText = ""
        Me.ProductDeleteButton.Name = "ProductDeleteButton"
        Me.ProductDeleteButton.Text = "Delete"
        '
        'ProductsAdminSidePanel
        '
        Me.ProductsAdminSidePanel.Controls.Add(Me.AddProductButton)
        Me.ProductsAdminSidePanel.Controls.Add(Me.QuantityLabel)
        Me.ProductsAdminSidePanel.Controls.Add(Me.ProductDescriptionTextBox)
        Me.ProductsAdminSidePanel.Controls.Add(Me.ProductQuantityTextBox)
        Me.ProductsAdminSidePanel.Controls.Add(Me.ListProducts)
        Me.ProductsAdminSidePanel.Controls.Add(Me.UpdateProductButton)
        Me.ProductsAdminSidePanel.Controls.Add(Me.ProductPriceTextBox)
        Me.ProductsAdminSidePanel.Controls.Add(Me.PriceLabel)
        Me.ProductsAdminSidePanel.Controls.Add(Me.Label2)
        Me.ProductsAdminSidePanel.Controls.Add(Me.Label1)
        Me.ProductsAdminSidePanel.Controls.Add(Me.ProductNameTextBox)
        Me.ProductsAdminSidePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProductsAdminSidePanel.Location = New System.Drawing.Point(2, 26)
        Me.ProductsAdminSidePanel.Margin = New System.Windows.Forms.Padding(2)
        Me.ProductsAdminSidePanel.Name = "ProductsAdminSidePanel"
        Me.ProductsAdminSidePanel.Size = New System.Drawing.Size(752, 103)
        Me.ProductsAdminSidePanel.TabIndex = 2
        '
        'AddProductButton
        '
        Me.AddProductButton.Location = New System.Drawing.Point(290, 61)
        Me.AddProductButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AddProductButton.Name = "AddProductButton"
        Me.AddProductButton.Size = New System.Drawing.Size(149, 29)
        Me.AddProductButton.TabIndex = 11
        Me.AddProductButton.Text = "Add Product"
        Me.AddProductButton.UseVisualStyleBackColor = True
        '
        'QuantityLabel
        '
        Me.QuantityLabel.AutoSize = True
        Me.QuantityLabel.Location = New System.Drawing.Point(10, 84)
        Me.QuantityLabel.Name = "QuantityLabel"
        Me.QuantityLabel.Size = New System.Drawing.Size(46, 13)
        Me.QuantityLabel.TabIndex = 10
        Me.QuantityLabel.Text = "Quantity"
        '
        'ProductDescriptionTextBox
        '
        Me.ProductDescriptionTextBox.Location = New System.Drawing.Point(290, 11)
        Me.ProductDescriptionTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ProductDescriptionTextBox.Multiline = True
        Me.ProductDescriptionTextBox.Name = "ProductDescriptionTextBox"
        Me.ProductDescriptionTextBox.Size = New System.Drawing.Size(149, 42)
        Me.ProductDescriptionTextBox.TabIndex = 9
        '
        'ProductQuantityTextBox
        '
        Me.ProductQuantityTextBox.Location = New System.Drawing.Point(60, 77)
        Me.ProductQuantityTextBox.Name = "ProductQuantityTextBox"
        Me.ProductQuantityTextBox.Size = New System.Drawing.Size(149, 20)
        Me.ProductQuantityTextBox.TabIndex = 5
        '
        'ListProducts
        '
        Me.ListProducts.Location = New System.Drawing.Point(455, 61)
        Me.ListProducts.Margin = New System.Windows.Forms.Padding(2)
        Me.ListProducts.Name = "ListProducts"
        Me.ListProducts.Size = New System.Drawing.Size(145, 28)
        Me.ListProducts.TabIndex = 0
        Me.ListProducts.Text = "List of Products"
        Me.ListProducts.UseVisualStyleBackColor = True
        '
        'UpdateProductButton
        '
        Me.UpdateProductButton.Enabled = False
        Me.UpdateProductButton.Location = New System.Drawing.Point(455, 11)
        Me.UpdateProductButton.Margin = New System.Windows.Forms.Padding(2)
        Me.UpdateProductButton.Name = "UpdateProductButton"
        Me.UpdateProductButton.Size = New System.Drawing.Size(145, 29)
        Me.UpdateProductButton.TabIndex = 1
        Me.UpdateProductButton.Text = "Update Product"
        Me.UpdateProductButton.UseVisualStyleBackColor = True
        '
        'ProductPriceTextBox
        '
        Me.ProductPriceTextBox.Location = New System.Drawing.Point(60, 48)
        Me.ProductPriceTextBox.Name = "ProductPriceTextBox"
        Me.ProductPriceTextBox.Size = New System.Drawing.Size(149, 20)
        Me.ProductPriceTextBox.TabIndex = 1
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Location = New System.Drawing.Point(10, 55)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(31, 13)
        Me.PriceLabel.TabIndex = 3
        Me.PriceLabel.Text = "Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(225, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.Location = New System.Drawing.Point(60, 20)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(149, 20)
        Me.ProductNameTextBox.TabIndex = 0
        '
        'ProductsSearchBar
        '
        Me.ProductsSearchBar.Controls.Add(Me.ProductsSearchButton)
        Me.ProductsSearchBar.Controls.Add(Me.ProductsSearchInput)
        Me.ProductsSearchBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProductsSearchBar.Location = New System.Drawing.Point(2, 2)
        Me.ProductsSearchBar.Margin = New System.Windows.Forms.Padding(2)
        Me.ProductsSearchBar.Name = "ProductsSearchBar"
        Me.ProductsSearchBar.Size = New System.Drawing.Size(752, 24)
        Me.ProductsSearchBar.TabIndex = 1
        '
        'ProductsSearchButton
        '
        Me.ProductsSearchButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProductsSearchButton.Location = New System.Drawing.Point(202, 3)
        Me.ProductsSearchButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ProductsSearchButton.Name = "ProductsSearchButton"
        Me.ProductsSearchButton.Size = New System.Drawing.Size(238, 19)
        Me.ProductsSearchButton.TabIndex = 0
        Me.ProductsSearchButton.Text = "SEARCH"
        Me.ProductsSearchButton.UseVisualStyleBackColor = True
        '
        'ProductsSearchInput
        '
        Me.ProductsSearchInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProductsSearchInput.Location = New System.Drawing.Point(5, 4)
        Me.ProductsSearchInput.Margin = New System.Windows.Forms.Padding(2)
        Me.ProductsSearchInput.Name = "ProductsSearchInput"
        Me.ProductsSearchInput.Size = New System.Drawing.Size(323, 20)
        Me.ProductsSearchInput.TabIndex = 0
        '
        'StaffTab
        '
        Me.StaffTab.Controls.Add(Me.StaffList)
        Me.StaffTab.Controls.Add(Me.StaffAdminSidePanel)
        Me.StaffTab.Controls.Add(Me.StaffSearchBar)
        Me.StaffTab.Location = New System.Drawing.Point(4, 22)
        Me.StaffTab.Margin = New System.Windows.Forms.Padding(2)
        Me.StaffTab.Name = "StaffTab"
        Me.StaffTab.Padding = New System.Windows.Forms.Padding(2)
        Me.StaffTab.Size = New System.Drawing.Size(756, 351)
        Me.StaffTab.TabIndex = 1
        Me.StaffTab.Text = "STAFF"
        Me.StaffTab.UseVisualStyleBackColor = True
        '
        'StaffList
        '
        Me.StaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StaffList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.StaffName, Me.StaffEmail, Me.StaffRole, Me.StaffEmptyColumn, Me.StaffEditButton, Me.StaffDeleteButton})
        Me.StaffList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StaffList.Location = New System.Drawing.Point(2, 138)
        Me.StaffList.Margin = New System.Windows.Forms.Padding(2)
        Me.StaffList.Name = "StaffList"
        Me.StaffList.RowHeadersWidth = 51
        Me.StaffList.RowTemplate.Height = 24
        Me.StaffList.Size = New System.Drawing.Size(752, 211)
        Me.StaffList.TabIndex = 3
        '
        'Id
        '
        Me.Id.Frozen = True
        Me.Id.HeaderText = "StaffId"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        '
        'StaffName
        '
        Me.StaffName.Frozen = True
        Me.StaffName.HeaderText = "Name"
        Me.StaffName.Name = "StaffName"
        Me.StaffName.ReadOnly = True
        '
        'StaffEmail
        '
        Me.StaffEmail.Frozen = True
        Me.StaffEmail.HeaderText = "Email"
        Me.StaffEmail.Name = "StaffEmail"
        Me.StaffEmail.ReadOnly = True
        '
        'StaffRole
        '
        Me.StaffRole.Frozen = True
        Me.StaffRole.HeaderText = "Role"
        Me.StaffRole.Name = "StaffRole"
        Me.StaffRole.ReadOnly = True
        '
        'StaffEmptyColumn
        '
        Me.StaffEmptyColumn.Frozen = True
        Me.StaffEmptyColumn.HeaderText = ""
        Me.StaffEmptyColumn.Name = "StaffEmptyColumn"
        '
        'StaffEditButton
        '
        Me.StaffEditButton.HeaderText = ""
        Me.StaffEditButton.Name = "StaffEditButton"
        Me.StaffEditButton.Text = "Edit"
        '
        'StaffDeleteButton
        '
        Me.StaffDeleteButton.HeaderText = ""
        Me.StaffDeleteButton.Name = "StaffDeleteButton"
        Me.StaffDeleteButton.Text = "Delete"
        '
        'StaffAdminSidePanel
        '
        Me.StaffAdminSidePanel.Controls.Add(Me.StaffClearButton)
        Me.StaffAdminSidePanel.Controls.Add(Me.StaffUpdateButton)
        Me.StaffAdminSidePanel.Controls.Add(Me.EmailLabel)
        Me.StaffAdminSidePanel.Controls.Add(Me.RoleLabel)
        Me.StaffAdminSidePanel.Controls.Add(Me.NameLabel)
        Me.StaffAdminSidePanel.Controls.Add(Me.StaffRoleComboBox)
        Me.StaffAdminSidePanel.Controls.Add(Me.StaffEmailTextBox)
        Me.StaffAdminSidePanel.Controls.Add(Me.StaffNameTextBox)
        Me.StaffAdminSidePanel.Controls.Add(Me.AddStaff)
        Me.StaffAdminSidePanel.Controls.Add(Me.ListStaffButton)
        Me.StaffAdminSidePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.StaffAdminSidePanel.Location = New System.Drawing.Point(2, 26)
        Me.StaffAdminSidePanel.Margin = New System.Windows.Forms.Padding(2)
        Me.StaffAdminSidePanel.Name = "StaffAdminSidePanel"
        Me.StaffAdminSidePanel.Size = New System.Drawing.Size(752, 112)
        Me.StaffAdminSidePanel.TabIndex = 5
        '
        'StaffClearButton
        '
        Me.StaffClearButton.Location = New System.Drawing.Point(437, 75)
        Me.StaffClearButton.Name = "StaffClearButton"
        Me.StaffClearButton.Size = New System.Drawing.Size(162, 27)
        Me.StaffClearButton.TabIndex = 9
        Me.StaffClearButton.Text = "Clear"
        Me.StaffClearButton.UseVisualStyleBackColor = True
        '
        'StaffUpdateButton
        '
        Me.StaffUpdateButton.Enabled = False
        Me.StaffUpdateButton.Location = New System.Drawing.Point(258, 75)
        Me.StaffUpdateButton.Name = "StaffUpdateButton"
        Me.StaffUpdateButton.Size = New System.Drawing.Size(162, 27)
        Me.StaffUpdateButton.TabIndex = 8
        Me.StaffUpdateButton.Text = "Update"
        Me.StaffUpdateButton.UseVisualStyleBackColor = True
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(9, 42)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(32, 13)
        Me.EmailLabel.TabIndex = 7
        Me.EmailLabel.Text = "Email"
        '
        'RoleLabel
        '
        Me.RoleLabel.AutoSize = True
        Me.RoleLabel.Location = New System.Drawing.Point(9, 70)
        Me.RoleLabel.Name = "RoleLabel"
        Me.RoleLabel.Size = New System.Drawing.Size(29, 13)
        Me.RoleLabel.TabIndex = 6
        Me.RoleLabel.Text = "Role"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(9, 16)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel.TabIndex = 5
        Me.NameLabel.Text = "Name"
        '
        'StaffRoleComboBox
        '
        Me.StaffRoleComboBox.FormattingEnabled = True
        Me.StaffRoleComboBox.Location = New System.Drawing.Point(77, 62)
        Me.StaffRoleComboBox.Name = "StaffRoleComboBox"
        Me.StaffRoleComboBox.Size = New System.Drawing.Size(147, 21)
        Me.StaffRoleComboBox.TabIndex = 4
        '
        'StaffEmailTextBox
        '
        Me.StaffEmailTextBox.Location = New System.Drawing.Point(77, 35)
        Me.StaffEmailTextBox.Name = "StaffEmailTextBox"
        Me.StaffEmailTextBox.Size = New System.Drawing.Size(147, 20)
        Me.StaffEmailTextBox.TabIndex = 3
        '
        'StaffNameTextBox
        '
        Me.StaffNameTextBox.Location = New System.Drawing.Point(77, 9)
        Me.StaffNameTextBox.Name = "StaffNameTextBox"
        Me.StaffNameTextBox.Size = New System.Drawing.Size(147, 20)
        Me.StaffNameTextBox.TabIndex = 2
        '
        'AddStaff
        '
        Me.AddStaff.Location = New System.Drawing.Point(258, 9)
        Me.AddStaff.Margin = New System.Windows.Forms.Padding(2)
        Me.AddStaff.Name = "AddStaff"
        Me.AddStaff.Size = New System.Drawing.Size(162, 29)
        Me.AddStaff.TabIndex = 1
        Me.AddStaff.Text = "Add Staff"
        Me.AddStaff.UseVisualStyleBackColor = True
        '
        'ListStaffButton
        '
        Me.ListStaffButton.Location = New System.Drawing.Point(258, 42)
        Me.ListStaffButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ListStaffButton.Name = "ListStaffButton"
        Me.ListStaffButton.Size = New System.Drawing.Size(162, 28)
        Me.ListStaffButton.TabIndex = 0
        Me.ListStaffButton.Text = "List of Staff"
        Me.ListStaffButton.UseVisualStyleBackColor = True
        '
        'StaffSearchBar
        '
        Me.StaffSearchBar.Controls.Add(Me.StaffSearchButton)
        Me.StaffSearchBar.Controls.Add(Me.StaffSearchInput)
        Me.StaffSearchBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.StaffSearchBar.Location = New System.Drawing.Point(2, 2)
        Me.StaffSearchBar.Margin = New System.Windows.Forms.Padding(2)
        Me.StaffSearchBar.Name = "StaffSearchBar"
        Me.StaffSearchBar.Size = New System.Drawing.Size(752, 24)
        Me.StaffSearchBar.TabIndex = 4
        '
        'StaffSearchButton
        '
        Me.StaffSearchButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StaffSearchButton.Location = New System.Drawing.Point(333, 2)
        Me.StaffSearchButton.Margin = New System.Windows.Forms.Padding(2)
        Me.StaffSearchButton.Name = "StaffSearchButton"
        Me.StaffSearchButton.Size = New System.Drawing.Size(237, 19)
        Me.StaffSearchButton.TabIndex = 0
        Me.StaffSearchButton.Text = "SEARCH"
        Me.StaffSearchButton.UseVisualStyleBackColor = True
        '
        'StaffSearchInput
        '
        Me.StaffSearchInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StaffSearchInput.Location = New System.Drawing.Point(169, 2)
        Me.StaffSearchInput.Margin = New System.Windows.Forms.Padding(2)
        Me.StaffSearchInput.Name = "StaffSearchInput"
        Me.StaffSearchInput.Size = New System.Drawing.Size(323, 20)
        Me.StaffSearchInput.TabIndex = 0
        '
        'ReportsTab
        '
        Me.ReportsTab.Location = New System.Drawing.Point(4, 22)
        Me.ReportsTab.Margin = New System.Windows.Forms.Padding(2)
        Me.ReportsTab.Name = "ReportsTab"
        Me.ReportsTab.Padding = New System.Windows.Forms.Padding(2)
        Me.ReportsTab.Size = New System.Drawing.Size(756, 351)
        Me.ReportsTab.TabIndex = 2
        Me.ReportsTab.Text = "REPORTS"
        Me.ReportsTab.UseVisualStyleBackColor = True
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 377)
        Me.Controls.Add(Me.AdminTabControl)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AdminDashboard"
        Me.Text = "ADMIN DASHBOARD"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.AdminTabControl.ResumeLayout(False)
        Me.ProductsTab.ResumeLayout(False)
        Me.AdminBody.ResumeLayout(False)
        CType(Me.ProductList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductsAdminSidePanel.ResumeLayout(False)
        Me.ProductsAdminSidePanel.PerformLayout()
        Me.ProductsSearchBar.ResumeLayout(False)
        Me.ProductsSearchBar.PerformLayout()
        Me.StaffTab.ResumeLayout(False)
        CType(Me.StaffList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StaffAdminSidePanel.ResumeLayout(False)
        Me.StaffAdminSidePanel.PerformLayout()
        Me.StaffSearchBar.ResumeLayout(False)
        Me.StaffSearchBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AdminTabControl As TabControl
    Friend WithEvents ProductsTab As TabPage
    Friend WithEvents StaffTab As TabPage
    Friend WithEvents ReportsTab As TabPage
    Friend WithEvents ProductsSearchBar As Panel
    Friend WithEvents ProductsSearchInput As TextBox
    Friend WithEvents ProductsAdminSidePanel As Panel
    Friend WithEvents ProductsSearchButton As Button
    Friend WithEvents StaffList As DataGridView
    Friend WithEvents StaffAdminSidePanel As Panel
    Friend WithEvents AddStaff As Button
    Friend WithEvents ListStaffButton As Button
    Friend WithEvents StaffSearchBar As Panel
    Friend WithEvents StaffSearchButton As Button
    Friend WithEvents StaffSearchInput As TextBox
    Friend WithEvents ListProducts As Button
    Friend WithEvents UpdateProductButton As Button
    Friend WithEvents ProductNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PriceLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AdminBody As Panel
    Friend WithEvents ProductList As DataGridView
    Friend WithEvents ProductPriceTextBox As TextBox
    Friend WithEvents ProductQuantityTextBox As TextBox
    Friend WithEvents QuantityLabel As Label
    Friend WithEvents ProductDescriptionTextBox As TextBox
    Friend WithEvents StaffRoleComboBox As ComboBox
    Friend WithEvents StaffEmailTextBox As TextBox
    Friend WithEvents StaffNameTextBox As TextBox
    Friend WithEvents EmailLabel As Label
    Friend WithEvents RoleLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents StaffUpdateButton As Button
    Friend WithEvents StaffClearButton As Button
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents StaffName As DataGridViewTextBoxColumn
    Friend WithEvents StaffEmail As DataGridViewTextBoxColumn
    Friend WithEvents StaffRole As DataGridViewTextBoxColumn
    Friend WithEvents StaffEmptyColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffEditButton As DataGridViewButtonColumn
    Friend WithEvents StaffDeleteButton As DataGridViewButtonColumn
    Friend WithEvents AddProductButton As Button
    Friend WithEvents ProductIdColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionColumn As DataGridViewTextBoxColumn
    Friend WithEvents empty As DataGridViewTextBoxColumn
    Friend WithEvents ProductEditButton As DataGridViewButtonColumn
    Friend WithEvents ProductDeleteButton As DataGridViewButtonColumn
End Class
