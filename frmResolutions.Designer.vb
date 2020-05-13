<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResolutions
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
        Me.components = New System.ComponentModel.Container()
        Dim Full_nameLabel As System.Windows.Forms.Label
        Dim Bgy_CaptainLabel As System.Windows.Forms.Label
        Dim Res_IDLabel As System.Windows.Forms.Label
        Dim Date_IssuedLabel As System.Windows.Forms.Label
        Dim Year__Series_Label As System.Windows.Forms.Label
        Dim NoLabel As System.Windows.Forms.Label
        Dim ExplanatoryLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResolutions))
        Dim Res_IDLabel1 As System.Windows.Forms.Label
        Me.DataSet = New RecordBgySystem.DataSet()
        Me.TblResolutionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblResolutionTableAdapter = New RecordBgySystem.DataSetTableAdapters.tblResolutionTableAdapter()
        Me.TableAdapterManager = New RecordBgySystem.DataSetTableAdapters.TableAdapterManager()
        Me.TblSecretaryTableAdapter = New RecordBgySystem.DataSetTableAdapters.tblSecretaryTableAdapter()
        Me.TblResolutionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblResolutionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblSecretaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Full_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Bgy_CaptainTextBox = New System.Windows.Forms.TextBox()
        Me.TblResolutionDataGridView = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalRes = New System.Windows.Forms.Label()
        Me.btnCancelEdit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.Res_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Date_IssuedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Year__Series_TextBox = New System.Windows.Forms.TextBox()
        Me.NoTextBox = New System.Windows.Forms.TextBox()
        Me.ExplanatoryTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Res_IDTextBox1 = New System.Windows.Forms.TextBox()
        Full_nameLabel = New System.Windows.Forms.Label()
        Bgy_CaptainLabel = New System.Windows.Forms.Label()
        Res_IDLabel = New System.Windows.Forms.Label()
        Date_IssuedLabel = New System.Windows.Forms.Label()
        Year__Series_Label = New System.Windows.Forms.Label()
        NoLabel = New System.Windows.Forms.Label()
        ExplanatoryLabel = New System.Windows.Forms.Label()
        Res_IDLabel1 = New System.Windows.Forms.Label()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblResolutionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblResolutionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblResolutionBindingNavigator.SuspendLayout()
        CType(Me.TblSecretaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblResolutionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Full_nameLabel
        '
        Full_nameLabel.AutoSize = True
        Full_nameLabel.Location = New System.Drawing.Point(17, 30)
        Full_nameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Full_nameLabel.Name = "Full_nameLabel"
        Full_nameLabel.Size = New System.Drawing.Size(88, 15)
        Full_nameLabel.TabIndex = 3
        Full_nameLabel.Text = "Brgy. Secretary:"
        '
        'Bgy_CaptainLabel
        '
        Bgy_CaptainLabel.AutoSize = True
        Bgy_CaptainLabel.Location = New System.Drawing.Point(31, 66)
        Bgy_CaptainLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Bgy_CaptainLabel.Name = "Bgy_CaptainLabel"
        Bgy_CaptainLabel.Size = New System.Drawing.Size(74, 15)
        Bgy_CaptainLabel.TabIndex = 5
        Bgy_CaptainLabel.Text = "Bgy Captain:"
        '
        'Res_IDLabel
        '
        Res_IDLabel.AutoSize = True
        Res_IDLabel.Location = New System.Drawing.Point(680, 94)
        Res_IDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Res_IDLabel.Name = "Res_IDLabel"
        Res_IDLabel.Size = New System.Drawing.Size(43, 13)
        Res_IDLabel.TabIndex = 73
        Res_IDLabel.Text = "Res ID:"
        '
        'Date_IssuedLabel
        '
        Date_IssuedLabel.AutoSize = True
        Date_IssuedLabel.Location = New System.Drawing.Point(15, 25)
        Date_IssuedLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Date_IssuedLabel.Name = "Date_IssuedLabel"
        Date_IssuedLabel.Size = New System.Drawing.Size(70, 15)
        Date_IssuedLabel.TabIndex = 74
        Date_IssuedLabel.Text = "Date Issued:"
        '
        'Year__Series_Label
        '
        Year__Series_Label.AutoSize = True
        Year__Series_Label.Location = New System.Drawing.Point(213, 55)
        Year__Series_Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Year__Series_Label.Name = "Year__Series_Label"
        Year__Series_Label.Size = New System.Drawing.Size(73, 15)
        Year__Series_Label.TabIndex = 75
        Year__Series_Label.Text = "Year (Series):"
        '
        'NoLabel
        '
        NoLabel.AutoSize = True
        NoLabel.Location = New System.Drawing.Point(364, 55)
        NoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        NoLabel.Name = "NoLabel"
        NoLabel.Size = New System.Drawing.Size(26, 15)
        NoLabel.TabIndex = 76
        NoLabel.Text = "No:"
        '
        'ExplanatoryLabel
        '
        ExplanatoryLabel.AutoSize = True
        ExplanatoryLabel.Location = New System.Drawing.Point(184, 89)
        ExplanatoryLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ExplanatoryLabel.Name = "ExplanatoryLabel"
        ExplanatoryLabel.Size = New System.Drawing.Size(94, 15)
        ExplanatoryLabel.TabIndex = 77
        ExplanatoryLabel.Text = "-- Explanatory --"
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblResolutionBindingSource
        '
        Me.TblResolutionBindingSource.DataMember = "tblResolution"
        Me.TblResolutionBindingSource.DataSource = Me.DataSet
        '
        'TblResolutionTableAdapter
        '
        Me.TblResolutionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblCertificatesTableAdapter = Nothing
        Me.TableAdapterManager.tblClearanceTableAdapter = Nothing
        Me.TableAdapterManager.tblRbiTableAdapter = Nothing
        Me.TableAdapterManager.tblResolutionTableAdapter = Me.TblResolutionTableAdapter
        Me.TableAdapterManager.tblSecretaryTableAdapter = Me.TblSecretaryTableAdapter
        Me.TableAdapterManager.UpdateOrder = RecordBgySystem.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblSecretaryTableAdapter
        '
        Me.TblSecretaryTableAdapter.ClearBeforeFill = True
        '
        'TblResolutionBindingNavigator
        '
        Me.TblResolutionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblResolutionBindingNavigator.BindingSource = Me.TblResolutionBindingSource
        Me.TblResolutionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblResolutionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblResolutionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblResolutionBindingNavigatorSaveItem})
        Me.TblResolutionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblResolutionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblResolutionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblResolutionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblResolutionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblResolutionBindingNavigator.Name = "TblResolutionBindingNavigator"
        Me.TblResolutionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblResolutionBindingNavigator.Size = New System.Drawing.Size(1001, 25)
        Me.TblResolutionBindingNavigator.TabIndex = 0
        Me.TblResolutionBindingNavigator.Text = "BindingNavigator1"
        Me.TblResolutionBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(38, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TblResolutionBindingNavigatorSaveItem
        '
        Me.TblResolutionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblResolutionBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblResolutionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblResolutionBindingNavigatorSaveItem.Name = "TblResolutionBindingNavigatorSaveItem"
        Me.TblResolutionBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblResolutionBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblSecretaryBindingSource
        '
        Me.TblSecretaryBindingSource.DataMember = "tblSecretary"
        Me.TblSecretaryBindingSource.DataSource = Me.DataSet
        '
        'Full_nameTextBox
        '
        Me.Full_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSecretaryBindingSource, "Full name", True))
        Me.Full_nameTextBox.Location = New System.Drawing.Point(109, 26)
        Me.Full_nameTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Full_nameTextBox.Name = "Full_nameTextBox"
        Me.Full_nameTextBox.ReadOnly = True
        Me.Full_nameTextBox.Size = New System.Drawing.Size(331, 23)
        Me.Full_nameTextBox.TabIndex = 4
        '
        'Bgy_CaptainTextBox
        '
        Me.Bgy_CaptainTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSecretaryBindingSource, "Bgy Captain", True))
        Me.Bgy_CaptainTextBox.Location = New System.Drawing.Point(109, 63)
        Me.Bgy_CaptainTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Bgy_CaptainTextBox.Name = "Bgy_CaptainTextBox"
        Me.Bgy_CaptainTextBox.ReadOnly = True
        Me.Bgy_CaptainTextBox.Size = New System.Drawing.Size(331, 23)
        Me.Bgy_CaptainTextBox.TabIndex = 6
        '
        'TblResolutionDataGridView
        '
        Me.TblResolutionDataGridView.AutoGenerateColumns = False
        Me.TblResolutionDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TblResolutionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblResolutionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.TblResolutionDataGridView.DataSource = Me.TblResolutionBindingSource
        Me.TblResolutionDataGridView.Location = New System.Drawing.Point(16, 47)
        Me.TblResolutionDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TblResolutionDataGridView.Name = "TblResolutionDataGridView"
        Me.TblResolutionDataGridView.ReadOnly = True
        Me.TblResolutionDataGridView.RowTemplate.Height = 24
        Me.TblResolutionDataGridView.Size = New System.Drawing.Size(572, 495)
        Me.TblResolutionDataGridView.TabIndex = 6
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 545)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Total :"
        '
        'lblTotalRes
        '
        Me.lblTotalRes.AutoSize = True
        Me.lblTotalRes.Location = New System.Drawing.Point(56, 545)
        Me.lblTotalRes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalRes.Name = "lblTotalRes"
        Me.lblTotalRes.Size = New System.Drawing.Size(39, 15)
        Me.lblTotalRes.TabIndex = 7
        Me.lblTotalRes.Text = "Total :"
        '
        'btnCancelEdit
        '
        Me.btnCancelEdit.Enabled = False
        Me.btnCancelEdit.Location = New System.Drawing.Point(317, 18)
        Me.btnCancelEdit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCancelEdit.Name = "btnCancelEdit"
        Me.btnCancelEdit.Size = New System.Drawing.Size(100, 32)
        Me.btnCancelEdit.TabIndex = 70
        Me.btnCancelEdit.Text = "Cancel Edit"
        Me.btnCancelEdit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Location = New System.Drawing.Point(109, 18)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 32)
        Me.btnCancel.TabIndex = 68
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(525, 18)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 32)
        Me.btnSave.TabIndex = 69
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(421, 18)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 32)
        Me.btnDelete.TabIndex = 66
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(213, 18)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(100, 32)
        Me.btnEdit.TabIndex = 67
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(5, 18)
        Me.btnAddNew.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(100, 32)
        Me.btnAddNew.TabIndex = 65
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(1027, 706)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(76, 32)
        Me.Button4.TabIndex = 73
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(294, 17)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(64, 26)
        Me.btnNext.TabIndex = 72
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(226, 17)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(64, 26)
        Me.btnPrevious.TabIndex = 71
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'Res_IDTextBox
        '
        Me.Res_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblResolutionBindingSource, "Res ID", True))
        Me.Res_IDTextBox.Location = New System.Drawing.Point(724, 90)
        Me.Res_IDTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Res_IDTextBox.Name = "Res_IDTextBox"
        Me.Res_IDTextBox.Size = New System.Drawing.Size(76, 20)
        Me.Res_IDTextBox.TabIndex = 74
        '
        'Date_IssuedDateTimePicker
        '
        Me.Date_IssuedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblResolutionBindingSource, "Date Issued", True))
        Me.Date_IssuedDateTimePicker.Enabled = False
        Me.Date_IssuedDateTimePicker.Location = New System.Drawing.Point(96, 21)
        Me.Date_IssuedDateTimePicker.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Date_IssuedDateTimePicker.Name = "Date_IssuedDateTimePicker"
        Me.Date_IssuedDateTimePicker.Size = New System.Drawing.Size(343, 23)
        Me.Date_IssuedDateTimePicker.TabIndex = 75
        '
        'Year__Series_TextBox
        '
        Me.Year__Series_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblResolutionBindingSource, "Year (Series)", True))
        Me.Year__Series_TextBox.Location = New System.Drawing.Point(290, 52)
        Me.Year__Series_TextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Year__Series_TextBox.Name = "Year__Series_TextBox"
        Me.Year__Series_TextBox.ReadOnly = True
        Me.Year__Series_TextBox.Size = New System.Drawing.Size(73, 23)
        Me.Year__Series_TextBox.TabIndex = 76
        '
        'NoTextBox
        '
        Me.NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblResolutionBindingSource, "No", True))
        Me.NoTextBox.Location = New System.Drawing.Point(394, 52)
        Me.NoTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NoTextBox.Name = "NoTextBox"
        Me.NoTextBox.ReadOnly = True
        Me.NoTextBox.Size = New System.Drawing.Size(45, 23)
        Me.NoTextBox.TabIndex = 77
        '
        'ExplanatoryTextBox
        '
        Me.ExplanatoryTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ExplanatoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblResolutionBindingSource, "Explanatory", True))
        Me.ExplanatoryTextBox.Location = New System.Drawing.Point(18, 109)
        Me.ExplanatoryTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ExplanatoryTextBox.Multiline = True
        Me.ExplanatoryTextBox.Name = "ExplanatoryTextBox"
        Me.ExplanatoryTextBox.ReadOnly = True
        Me.ExplanatoryTextBox.Size = New System.Drawing.Size(421, 327)
        Me.ExplanatoryTextBox.TabIndex = 78
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCancelEdit)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnAddNew)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1082, 58)
        Me.GroupBox1.TabIndex = 79
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(403, 36)
        Me.Label7.TabIndex = 96
        Me.Label7.Text = "Barangay Resolution Tracking"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnNext)
        Me.GroupBox2.Controls.Add(Me.btnPrevious)
        Me.GroupBox2.Controls.Add(Me.TblResolutionDataGridView)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblTotalRes)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(498, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(605, 574)
        Me.GroupBox2.TabIndex = 97
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resolution Lists"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Res_IDLabel1)
        Me.GroupBox3.Controls.Add(ExplanatoryLabel)
        Me.GroupBox3.Controls.Add(Me.Res_IDTextBox1)
        Me.GroupBox3.Controls.Add(Me.ExplanatoryTextBox)
        Me.GroupBox3.Controls.Add(NoLabel)
        Me.GroupBox3.Controls.Add(Me.NoTextBox)
        Me.GroupBox3.Controls.Add(Year__Series_Label)
        Me.GroupBox3.Controls.Add(Me.Year__Series_TextBox)
        Me.GroupBox3.Controls.Add(Date_IssuedLabel)
        Me.GroupBox3.Controls.Add(Me.Date_IssuedDateTimePicker)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(22, 117)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(458, 453)
        Me.GroupBox3.TabIndex = 98
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Informations"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Bgy_CaptainLabel)
        Me.GroupBox4.Controls.Add(Me.Bgy_CaptainTextBox)
        Me.GroupBox4.Controls.Add(Full_nameLabel)
        Me.GroupBox4.Controls.Add(Me.Full_nameTextBox)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(21, 576)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(459, 110)
        Me.GroupBox4.TabIndex = 99
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Signatories"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Res ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Res ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Date Issued"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Date Issued"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Year (Series)"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Year (Series)"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "No"
        Me.DataGridViewTextBoxColumn5.HeaderText = "No"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Explanatory"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Explanatory"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Res_IDLabel1
        '
        Res_IDLabel1.AutoSize = True
        Res_IDLabel1.Location = New System.Drawing.Point(43, 55)
        Res_IDLabel1.Name = "Res_IDLabel1"
        Res_IDLabel1.Size = New System.Drawing.Size(42, 15)
        Res_IDLabel1.TabIndex = 99
        Res_IDLabel1.Text = "Res ID:"
        '
        'Res_IDTextBox1
        '
        Me.Res_IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblResolutionBindingSource, "Res ID", True))
        Me.Res_IDTextBox1.Location = New System.Drawing.Point(96, 53)
        Me.Res_IDTextBox1.Name = "Res_IDTextBox1"
        Me.Res_IDTextBox1.Size = New System.Drawing.Size(112, 23)
        Me.Res_IDTextBox1.TabIndex = 100
        '
        'frmResolutions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1154, 749)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Res_IDLabel)
        Me.Controls.Add(Me.Res_IDTextBox)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TblResolutionBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmResolutions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barangay Resolutions"
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblResolutionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblResolutionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblResolutionBindingNavigator.ResumeLayout(False)
        Me.TblResolutionBindingNavigator.PerformLayout()
        CType(Me.TblSecretaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblResolutionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSet As RecordBgySystem.DataSet
    Friend WithEvents TblResolutionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblResolutionTableAdapter As RecordBgySystem.DataSetTableAdapters.tblResolutionTableAdapter
    Friend WithEvents TableAdapterManager As RecordBgySystem.DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblResolutionBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TblResolutionBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblSecretaryTableAdapter As RecordBgySystem.DataSetTableAdapters.tblSecretaryTableAdapter
    Friend WithEvents TblSecretaryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Full_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Bgy_CaptainTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TblResolutionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotalRes As System.Windows.Forms.Label
    Friend WithEvents btnCancelEdit As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents Res_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_IssuedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Year__Series_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExplanatoryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Res_IDTextBox1 As System.Windows.Forms.TextBox
End Class
