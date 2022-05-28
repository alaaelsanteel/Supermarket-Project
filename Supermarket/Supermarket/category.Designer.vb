<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class category
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CategoryDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.EDITButton = New System.Windows.Forms.Button()
        Me.CLEARButton = New System.Windows.Forms.Button()
        Me.DELETEButton = New System.Windows.Forms.Button()
        Me.ADDButton = New System.Windows.Forms.Button()
        Me.CatDesc = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.CatName = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.CatId = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.CategoryDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.CategoryDGV)
        Me.Panel1.Controls.Add(Me.EDITButton)
        Me.Panel1.Controls.Add(Me.CLEARButton)
        Me.Panel1.Controls.Add(Me.DELETEButton)
        Me.Panel1.Controls.Add(Me.ADDButton)
        Me.Panel1.Controls.Add(Me.CatDesc)
        Me.Panel1.Controls.Add(Me.CatName)
        Me.Panel1.Controls.Add(Me.CatId)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(103, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(937, 654)
        Me.Panel1.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label6.Font = New System.Drawing.Font("Myanmar Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(912, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 27)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "X"
        '
        'CategoryDGV
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.CategoryDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.CategoryDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CategoryDGV.BackgroundColor = System.Drawing.Color.White
        Me.CategoryDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CategoryDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.CategoryDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CategoryDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.CategoryDGV.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CategoryDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.CategoryDGV.EnableHeadersVisualStyles = False
        Me.CategoryDGV.GridColor = System.Drawing.Color.LightSteelBlue
        Me.CategoryDGV.Location = New System.Drawing.Point(48, 288)
        Me.CategoryDGV.Name = "CategoryDGV"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CategoryDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.CategoryDGV.RowHeadersVisible = False
        Me.CategoryDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CategoryDGV.Size = New System.Drawing.Size(842, 356)
        Me.CategoryDGV.TabIndex = 15
        Me.CategoryDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.CategoryDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.CategoryDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.CategoryDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.CategoryDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.CategoryDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.CategoryDGV.ThemeStyle.GridColor = System.Drawing.Color.LightSteelBlue
        Me.CategoryDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CategoryDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.CategoryDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.CategoryDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.CategoryDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.CategoryDGV.ThemeStyle.HeaderStyle.Height = 30
        Me.CategoryDGV.ThemeStyle.ReadOnly = False
        Me.CategoryDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.CategoryDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.CategoryDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.CategoryDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.CategoryDGV.ThemeStyle.RowsStyle.Height = 22
        Me.CategoryDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CategoryDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'EDITButton
        '
        Me.EDITButton.BackColor = System.Drawing.Color.Navy
        Me.EDITButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EDITButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EDITButton.ForeColor = System.Drawing.Color.White
        Me.EDITButton.Location = New System.Drawing.Point(301, 223)
        Me.EDITButton.Name = "EDITButton"
        Me.EDITButton.Size = New System.Drawing.Size(80, 31)
        Me.EDITButton.TabIndex = 14
        Me.EDITButton.Text = "EDIT"
        Me.EDITButton.UseVisualStyleBackColor = False
        '
        'CLEARButton
        '
        Me.CLEARButton.BackColor = System.Drawing.Color.Navy
        Me.CLEARButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CLEARButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLEARButton.ForeColor = System.Drawing.Color.White
        Me.CLEARButton.Location = New System.Drawing.Point(543, 223)
        Me.CLEARButton.Name = "CLEARButton"
        Me.CLEARButton.Size = New System.Drawing.Size(80, 31)
        Me.CLEARButton.TabIndex = 13
        Me.CLEARButton.Text = "CLEAR"
        Me.CLEARButton.UseVisualStyleBackColor = False
        '
        'DELETEButton
        '
        Me.DELETEButton.BackColor = System.Drawing.Color.Navy
        Me.DELETEButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DELETEButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DELETEButton.ForeColor = System.Drawing.Color.White
        Me.DELETEButton.Location = New System.Drawing.Point(428, 223)
        Me.DELETEButton.Name = "DELETEButton"
        Me.DELETEButton.Size = New System.Drawing.Size(80, 31)
        Me.DELETEButton.TabIndex = 12
        Me.DELETEButton.Text = "DELETE"
        Me.DELETEButton.UseVisualStyleBackColor = False
        '
        'ADDButton
        '
        Me.ADDButton.BackColor = System.Drawing.Color.Navy
        Me.ADDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ADDButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADDButton.ForeColor = System.Drawing.Color.White
        Me.ADDButton.Location = New System.Drawing.Point(178, 223)
        Me.ADDButton.Name = "ADDButton"
        Me.ADDButton.Size = New System.Drawing.Size(80, 31)
        Me.ADDButton.TabIndex = 11
        Me.ADDButton.Text = "ADD"
        Me.ADDButton.UseVisualStyleBackColor = False
        '
        'CatDesc
        '
        Me.CatDesc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CatDesc.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.CatDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CatDesc.HintForeColor = System.Drawing.Color.Empty
        Me.CatDesc.HintText = ""
        Me.CatDesc.isPassword = False
        Me.CatDesc.LineFocusedColor = System.Drawing.Color.Blue
        Me.CatDesc.LineIdleColor = System.Drawing.Color.Navy
        Me.CatDesc.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.CatDesc.LineThickness = 3
        Me.CatDesc.Location = New System.Drawing.Point(648, 113)
        Me.CatDesc.Margin = New System.Windows.Forms.Padding(4)
        Me.CatDesc.Name = "CatDesc"
        Me.CatDesc.Size = New System.Drawing.Size(148, 21)
        Me.CatDesc.TabIndex = 9
        Me.CatDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'CatName
        '
        Me.CatName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CatName.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.CatName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CatName.HintForeColor = System.Drawing.Color.Empty
        Me.CatName.HintText = ""
        Me.CatName.isPassword = False
        Me.CatName.LineFocusedColor = System.Drawing.Color.Blue
        Me.CatName.LineIdleColor = System.Drawing.Color.Navy
        Me.CatName.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.CatName.LineThickness = 3
        Me.CatName.Location = New System.Drawing.Point(360, 113)
        Me.CatName.Margin = New System.Windows.Forms.Padding(4)
        Me.CatName.Name = "CatName"
        Me.CatName.Size = New System.Drawing.Size(148, 21)
        Me.CatName.TabIndex = 8
        Me.CatName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'CatId
        '
        Me.CatId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CatId.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.CatId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CatId.HintForeColor = System.Drawing.Color.Empty
        Me.CatId.HintText = ""
        Me.CatId.isPassword = False
        Me.CatId.LineFocusedColor = System.Drawing.Color.Blue
        Me.CatId.LineIdleColor = System.Drawing.Color.Navy
        Me.CatId.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.CatId.LineThickness = 3
        Me.CatId.Location = New System.Drawing.Point(110, 113)
        Me.CatId.Margin = New System.Windows.Forms.Padding(4)
        Me.CatId.Name = "CatId"
        Me.CatId.Size = New System.Drawing.Size(148, 21)
        Me.CatId.TabIndex = 7
        Me.CatId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label5.Font = New System.Drawing.Font("Myanmar Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(296, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 27)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label4.Font = New System.Drawing.Font("Myanmar Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(531, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 27)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "DESCRIBTION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label2.Font = New System.Drawing.Font("Myanmar Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(273, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 43)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "MANAGE CATEGOREY"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label1.Font = New System.Drawing.Font("Myanmar Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(75, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID"
        '
        'category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(1042, 659)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "category"
        Me.Text = "category"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CategoryDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents CategoryDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents EDITButton As Button
    Friend WithEvents CLEARButton As Button
    Friend WithEvents DELETEButton As Button
    Friend WithEvents ADDButton As Button
    Friend WithEvents CatDesc As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents CatName As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents CatId As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
