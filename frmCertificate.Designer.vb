<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCertificate
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
        Dim PhotoLabel As System.Windows.Forms.Label
        Dim SubjectLabel As System.Windows.Forms.Label
        Dim Receipt_YearLabel As System.Windows.Forms.Label
        Dim OR_NoLabel As System.Windows.Forms.Label
        Dim Dates_IssuedLabel As System.Windows.Forms.Label
        Dim Full_DetailLabel As System.Windows.Forms.Label
        Dim Full_nameLabel As System.Windows.Forms.Label
        Dim Bgy_CaptainLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCertificate))
        Dim SubjectLabel1 As System.Windows.Forms.Label
        Dim Receipt_YearLabel1 As System.Windows.Forms.Label
        Dim OR_NoLabel1 As System.Windows.Forms.Label
        Dim Dates_IssuedLabel1 As System.Windows.Forms.Label
        Dim SecretaryLabel As System.Windows.Forms.Label
        Dim RBI_IDLabel As System.Windows.Forms.Label
        Dim Full_DetailLabel1 As System.Windows.Forms.Label
        Dim Cerf_IDLabel As System.Windows.Forms.Label
        Me.DataSet = New RecordBgySystem.DataSet()
        Me.TblRbiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblRbiTableAdapter = New RecordBgySystem.DataSetTableAdapters.tblRbiTableAdapter()
        Me.TableAdapterManager = New RecordBgySystem.DataSetTableAdapters.TableAdapterManager()
        Me.TblRbiBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TblRbiBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblCertificatesTableAdapter = New RecordBgySystem.DataSetTableAdapters.tblCertificatesTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PhotoTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.tbMN = New System.Windows.Forms.TextBox()
        Me.tbFN = New System.Windows.Forms.TextBox()
        Me.tbLN = New System.Windows.Forms.TextBox()
        Me.SubjectComboBox = New System.Windows.Forms.ComboBox()
        Me.Receipt_YearTextBox = New System.Windows.Forms.TextBox()
        Me.OR_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Dates_IssuedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Full_DetailTextBox = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.TblSecretaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSecretaryTableAdapter = New RecordBgySystem.DataSetTableAdapters.tblSecretaryTableAdapter()
        Me.TblRbiDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TblCertificatesDataGridView = New System.Windows.Forms.DataGridView()
        Me.Full_nameTextBox = New System.Windows.Forms.TextBox()
        Me.TblClearanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblClearanceTableAdapter = New RecordBgySystem.DataSetTableAdapters.tblClearanceTableAdapter()
        Me.Bgy_CaptainTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotalRbi = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotalCerf = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnCancelEdit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TblCertificatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Receipt_YearTextBox1 = New System.Windows.Forms.TextBox()
        Me.OR_NoTextBox1 = New System.Windows.Forms.TextBox()
        Me.Dates_IssuedDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SecretaryTextBox = New System.Windows.Forms.TextBox()
        Me.RBI_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Full_DetailTextBox1 = New System.Windows.Forms.TextBox()
        Me.Cerf_IDTextBox = New System.Windows.Forms.TextBox()
        PhotoLabel = New System.Windows.Forms.Label()
        SubjectLabel = New System.Windows.Forms.Label()
        Receipt_YearLabel = New System.Windows.Forms.Label()
        OR_NoLabel = New System.Windows.Forms.Label()
        Dates_IssuedLabel = New System.Windows.Forms.Label()
        Full_DetailLabel = New System.Windows.Forms.Label()
        Full_nameLabel = New System.Windows.Forms.Label()
        Bgy_CaptainLabel = New System.Windows.Forms.Label()
        SubjectLabel1 = New System.Windows.Forms.Label()
        Receipt_YearLabel1 = New System.Windows.Forms.Label()
        OR_NoLabel1 = New System.Windows.Forms.Label()
        Dates_IssuedLabel1 = New System.Windows.Forms.Label()
        SecretaryLabel = New System.Windows.Forms.Label()
        RBI_IDLabel = New System.Windows.Forms.Label()
        Full_DetailLabel1 = New System.Windows.Forms.Label()
        Cerf_IDLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRbiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRbiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblRbiBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSecretaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRbiDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCertificatesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblClearanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.TblCertificatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PhotoLabel
        '
        PhotoLabel.AutoSize = True
        PhotoLabel.Location = New System.Drawing.Point(1312, 144)
        PhotoLabel.Name = "PhotoLabel"
        PhotoLabel.Size = New System.Drawing.Size(49, 17)
        PhotoLabel.TabIndex = 73
        PhotoLabel.Text = "Photo:"
        '
        'SubjectLabel
        '
        SubjectLabel.AutoSize = True
        SubjectLabel.Location = New System.Drawing.Point(36, 37)
        SubjectLabel.Name = "SubjectLabel"
        SubjectLabel.Size = New System.Drawing.Size(61, 20)
        SubjectLabel.TabIndex = 75
        SubjectLabel.Text = "Subject:"
        AddHandler SubjectLabel.Click, AddressOf Me.SubjectLabel_Click
        '
        'Receipt_YearLabel
        '
        Receipt_YearLabel.AutoSize = True
        Receipt_YearLabel.Location = New System.Drawing.Point(59, 74)
        Receipt_YearLabel.Name = "Receipt_YearLabel"
        Receipt_YearLabel.Size = New System.Drawing.Size(40, 20)
        Receipt_YearLabel.TabIndex = 76
        Receipt_YearLabel.Text = "Year:"
        AddHandler Receipt_YearLabel.Click, AddressOf Me.Receipt_YearLabel_Click
        '
        'OR_NoLabel
        '
        OR_NoLabel.AutoSize = True
        OR_NoLabel.Location = New System.Drawing.Point(41, 111)
        OR_NoLabel.Name = "OR_NoLabel"
        OR_NoLabel.Size = New System.Drawing.Size(56, 20)
        OR_NoLabel.TabIndex = 77
        OR_NoLabel.Text = "OR No:"
        AddHandler OR_NoLabel.Click, AddressOf Me.OR_NoLabel_Click
        '
        'Dates_IssuedLabel
        '
        Dates_IssuedLabel.AutoSize = True
        Dates_IssuedLabel.Location = New System.Drawing.Point(3, 148)
        Dates_IssuedLabel.Name = "Dates_IssuedLabel"
        Dates_IssuedLabel.Size = New System.Drawing.Size(95, 20)
        Dates_IssuedLabel.TabIndex = 78
        Dates_IssuedLabel.Text = "Dates Issued:"
        AddHandler Dates_IssuedLabel.Click, AddressOf Me.Dates_IssuedLabel_Click
        '
        'Full_DetailLabel
        '
        Full_DetailLabel.AutoSize = True
        Full_DetailLabel.Location = New System.Drawing.Point(164, 193)
        Full_DetailLabel.Name = "Full_DetailLabel"
        Full_DetailLabel.Size = New System.Drawing.Size(114, 20)
        Full_DetailLabel.TabIndex = 79
        Full_DetailLabel.Text = "-- Full Details --"
        AddHandler Full_DetailLabel.Click, AddressOf Me.Full_DetailLabel_Click
        '
        'Full_nameLabel
        '
        Full_nameLabel.AutoSize = True
        Full_nameLabel.Location = New System.Drawing.Point(23, 31)
        Full_nameLabel.Name = "Full_nameLabel"
        Full_nameLabel.Size = New System.Drawing.Size(110, 20)
        Full_nameLabel.TabIndex = 82
        Full_nameLabel.Text = "Brgy. Secretary:"
        '
        'Bgy_CaptainLabel
        '
        Bgy_CaptainLabel.AutoSize = True
        Bgy_CaptainLabel.Location = New System.Drawing.Point(23, 70)
        Bgy_CaptainLabel.Name = "Bgy_CaptainLabel"
        Bgy_CaptainLabel.Size = New System.Drawing.Size(95, 20)
        Bgy_CaptainLabel.TabIndex = 83
        Bgy_CaptainLabel.Text = "Bgy. Captain:"
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblRbiBindingSource
        '
        Me.TblRbiBindingSource.DataMember = "tblRbi"
        Me.TblRbiBindingSource.DataSource = Me.DataSet
        '
        'TblRbiTableAdapter
        '
        Me.TblRbiTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblCertificatesTableAdapter = Nothing
        Me.TableAdapterManager.tblClearanceTableAdapter = Nothing
        Me.TableAdapterManager.tblCountersTableAdapter = Nothing
        Me.TableAdapterManager.tblRbiTableAdapter = Me.TblRbiTableAdapter
        Me.TableAdapterManager.tblResolutionTableAdapter = Nothing
        Me.TableAdapterManager.tblSecretaryTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = RecordBgySystem.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblRbiBindingNavigator
        '
        Me.TblRbiBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblRbiBindingNavigator.BindingSource = Me.TblRbiBindingSource
        Me.TblRbiBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblRbiBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblRbiBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblRbiBindingNavigatorSaveItem})
        Me.TblRbiBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblRbiBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblRbiBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblRbiBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblRbiBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblRbiBindingNavigator.Name = "TblRbiBindingNavigator"
        Me.TblRbiBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblRbiBindingNavigator.Size = New System.Drawing.Size(1348, 31)
        Me.TblRbiBindingNavigator.TabIndex = 0
        Me.TblRbiBindingNavigator.Text = "BindingNavigator1"
        Me.TblRbiBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(49, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'TblRbiBindingNavigatorSaveItem
        '
        Me.TblRbiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblRbiBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblRbiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblRbiBindingNavigatorSaveItem.Name = "TblRbiBindingNavigatorSaveItem"
        Me.TblRbiBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 28)
        Me.TblRbiBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblCertificatesTableAdapter
        '
        Me.TblCertificatesTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1292, 81)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(193, 158)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 75
        Me.PictureBox1.TabStop = False
        '
        'PhotoTextBox
        '
        Me.PhotoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRbiBindingSource, "Photo", True))
        Me.PhotoTextBox.Location = New System.Drawing.Point(1316, 140)
        Me.PhotoTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PhotoTextBox.Name = "PhotoTextBox"
        Me.PhotoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PhotoTextBox.TabIndex = 74
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(1292, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(51, 50, 51, 50)
        Me.Label4.Size = New System.Drawing.Size(193, 158)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "PHOTO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NOT " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AVAILABLE"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(315, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 23)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Middle Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 23)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 23)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Last Name"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(576, 47)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 34)
        Me.Button3.TabIndex = 68
        Me.Button3.Text = "CLEAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(465, 47)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(101, 34)
        Me.btnSearch.TabIndex = 67
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'tbMN
        '
        Me.tbMN.Location = New System.Drawing.Point(317, 49)
        Me.tbMN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbMN.Name = "tbMN"
        Me.tbMN.Size = New System.Drawing.Size(135, 29)
        Me.tbMN.TabIndex = 64
        '
        'tbFN
        '
        Me.tbFN.Location = New System.Drawing.Point(165, 49)
        Me.tbFN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbFN.Name = "tbFN"
        Me.tbFN.Size = New System.Drawing.Size(135, 29)
        Me.tbFN.TabIndex = 65
        '
        'tbLN
        '
        Me.tbLN.Location = New System.Drawing.Point(12, 49)
        Me.tbLN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbLN.Name = "tbLN"
        Me.tbLN.Size = New System.Drawing.Size(135, 29)
        Me.tbLN.TabIndex = 66
        '
        'SubjectComboBox
        '
        Me.SubjectComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCertificatesBindingSource, "Subject", True))
        Me.SubjectComboBox.Enabled = False
        Me.SubjectComboBox.FormattingEnabled = True
        Me.SubjectComboBox.Location = New System.Drawing.Point(109, 33)
        Me.SubjectComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SubjectComboBox.Name = "SubjectComboBox"
        Me.SubjectComboBox.Size = New System.Drawing.Size(329, 28)
        Me.SubjectComboBox.TabIndex = 76
        '
        'Receipt_YearTextBox
        '
        Me.Receipt_YearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCertificatesBindingSource, "Receipt Year", True))
        Me.Receipt_YearTextBox.Location = New System.Drawing.Point(109, 69)
        Me.Receipt_YearTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Receipt_YearTextBox.Name = "Receipt_YearTextBox"
        Me.Receipt_YearTextBox.ReadOnly = True
        Me.Receipt_YearTextBox.Size = New System.Drawing.Size(329, 27)
        Me.Receipt_YearTextBox.TabIndex = 77
        '
        'OR_NoTextBox
        '
        Me.OR_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCertificatesBindingSource, "OR No", True))
        Me.OR_NoTextBox.Location = New System.Drawing.Point(109, 106)
        Me.OR_NoTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OR_NoTextBox.Name = "OR_NoTextBox"
        Me.OR_NoTextBox.ReadOnly = True
        Me.OR_NoTextBox.Size = New System.Drawing.Size(329, 27)
        Me.OR_NoTextBox.TabIndex = 78
        '
        'Dates_IssuedDateTimePicker
        '
        Me.Dates_IssuedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblCertificatesBindingSource, "Dates Issued", True))
        Me.Dates_IssuedDateTimePicker.Enabled = False
        Me.Dates_IssuedDateTimePicker.Location = New System.Drawing.Point(109, 144)
        Me.Dates_IssuedDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Dates_IssuedDateTimePicker.Name = "Dates_IssuedDateTimePicker"
        Me.Dates_IssuedDateTimePicker.Size = New System.Drawing.Size(329, 27)
        Me.Dates_IssuedDateTimePicker.TabIndex = 79
        '
        'Full_DetailTextBox
        '
        Me.Full_DetailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCertificatesBindingSource, "Full Detail", True))
        Me.Full_DetailTextBox.Location = New System.Drawing.Point(13, 225)
        Me.Full_DetailTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Full_DetailTextBox.Multiline = True
        Me.Full_DetailTextBox.Name = "Full_DetailTextBox"
        Me.Full_DetailTextBox.Size = New System.Drawing.Size(423, 258)
        Me.Full_DetailTextBox.TabIndex = 80
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(1420, 876)
        Me.Button10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(85, 32)
        Me.Button10.TabIndex = 81
        Me.Button10.Text = "Close"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'TblSecretaryBindingSource
        '
        Me.TblSecretaryBindingSource.DataMember = "tblSecretary"
        Me.TblSecretaryBindingSource.DataSource = Me.DataSet
        '
        'TblSecretaryTableAdapter
        '
        Me.TblSecretaryTableAdapter.ClearBeforeFill = True
        '
        'TblRbiDataGridView
        '
        Me.TblRbiDataGridView.AutoGenerateColumns = False
        Me.TblRbiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblRbiDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewCheckBoxColumn1})
        Me.TblRbiDataGridView.DataSource = Me.TblRbiBindingSource
        Me.TblRbiDataGridView.Location = New System.Drawing.Point(21, 25)
        Me.TblRbiDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TblRbiDataGridView.Name = "TblRbiDataGridView"
        Me.TblRbiDataGridView.ReadOnly = True
        Me.TblRbiDataGridView.RowTemplate.Height = 24
        Me.TblRbiDataGridView.Size = New System.Drawing.Size(969, 238)
        Me.TblRbiDataGridView.TabIndex = 82
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "RBI ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "RBI ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Last Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "First Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Middle Name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Middle Name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Nick Name"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Nick Name"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Birth Date"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Birth Date"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Age"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Civil Status"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Civil Status"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Sex"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Sex"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Religion"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Religion"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Birth Place"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Birth Place"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Purok"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Purok"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Status of Residency"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Status of Residency"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Date of Residency"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Date of Residency"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Any blotter record?"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Any blotter record?"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'TblCertificatesDataGridView
        '
        Me.TblCertificatesDataGridView.AutoGenerateColumns = False
        Me.TblCertificatesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblCertificatesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22})
        Me.TblCertificatesDataGridView.DataSource = Me.TblCertificatesBindingSource
        Me.TblCertificatesDataGridView.Location = New System.Drawing.Point(21, 49)
        Me.TblCertificatesDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TblCertificatesDataGridView.Name = "TblCertificatesDataGridView"
        Me.TblCertificatesDataGridView.ReadOnly = True
        Me.TblCertificatesDataGridView.RowTemplate.Height = 24
        Me.TblCertificatesDataGridView.Size = New System.Drawing.Size(968, 241)
        Me.TblCertificatesDataGridView.TabIndex = 82
        '
        'Full_nameTextBox
        '
        Me.Full_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSecretaryBindingSource, "Full name", True))
        Me.Full_nameTextBox.Location = New System.Drawing.Point(145, 26)
        Me.Full_nameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Full_nameTextBox.Name = "Full_nameTextBox"
        Me.Full_nameTextBox.Size = New System.Drawing.Size(293, 27)
        Me.Full_nameTextBox.TabIndex = 83
        '
        'TblClearanceBindingSource
        '
        Me.TblClearanceBindingSource.DataMember = "tblClearance"
        Me.TblClearanceBindingSource.DataSource = Me.DataSet
        '
        'TblClearanceTableAdapter
        '
        Me.TblClearanceTableAdapter.ClearBeforeFill = True
        '
        'Bgy_CaptainTextBox
        '
        Me.Bgy_CaptainTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSecretaryBindingSource, "Bgy Captain", True))
        Me.Bgy_CaptainTextBox.Location = New System.Drawing.Point(145, 65)
        Me.Bgy_CaptainTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Bgy_CaptainTextBox.Name = "Bgy_CaptainTextBox"
        Me.Bgy_CaptainTextBox.Size = New System.Drawing.Size(293, 27)
        Me.Bgy_CaptainTextBox.TabIndex = 84
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Total :"
        '
        'lblTotalRbi
        '
        Me.lblTotalRbi.AutoSize = True
        Me.lblTotalRbi.Location = New System.Drawing.Point(95, 313)
        Me.lblTotalRbi.Name = "lblTotalRbi"
        Me.lblTotalRbi.Size = New System.Drawing.Size(56, 20)
        Me.lblTotalRbi.TabIndex = 85
        Me.lblTotalRbi.Text = "Total :"
        '
        'Timer1
        '
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 20)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Total :"
        '
        'lblTotalCerf
        '
        Me.lblTotalCerf.AutoSize = True
        Me.lblTotalCerf.Location = New System.Drawing.Point(75, 298)
        Me.lblTotalCerf.Name = "lblTotalCerf"
        Me.lblTotalCerf.Size = New System.Drawing.Size(56, 20)
        Me.lblTotalCerf.TabIndex = 85
        Me.lblTotalCerf.Text = "Total :"
        '
        'Timer2
        '
        '
        'btnCancelEdit
        '
        Me.btnCancelEdit.Enabled = False
        Me.btnCancelEdit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelEdit.Location = New System.Drawing.Point(425, 20)
        Me.btnCancelEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancelEdit.Name = "btnCancelEdit"
        Me.btnCancelEdit.Size = New System.Drawing.Size(133, 39)
        Me.btnCancelEdit.TabIndex = 91
        Me.btnCancelEdit.Text = "Cancel Edit"
        Me.btnCancelEdit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(151, 20)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(133, 39)
        Me.btnCancel.TabIndex = 89
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(700, 20)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(133, 39)
        Me.btnSave.TabIndex = 90
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(563, 20)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(133, 39)
        Me.btnDelete.TabIndex = 87
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(289, 20)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(133, 39)
        Me.btnEdit.TabIndex = 88
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.Location = New System.Drawing.Point(12, 20)
        Me.btnAddNew.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(133, 39)
        Me.btnAddNew.TabIndex = 86
        Me.btnAddNew.Text = "ADD NEW"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(539, 12)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(85, 32)
        Me.btnNext.TabIndex = 93
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(448, 12)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(85, 32)
        Me.btnPrevious.TabIndex = 92
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.tbMN)
        Me.GroupBox1.Controls.Add(Me.tbFN)
        Me.GroupBox1.Controls.Add(Me.tbLN)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(31, 140)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1255, 100)
        Me.GroupBox1.TabIndex = 94
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 26)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(570, 42)
        Me.Label7.TabIndex = 95
        Me.Label7.Text = "Barangay Certification Tracking"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCancelEdit)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.btnEdit)
        Me.GroupBox2.Controls.Add(Me.btnAddNew)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 74)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1255, 71)
        Me.GroupBox2.TabIndex = 96
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTotalRbi)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TblRbiDataGridView)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(496, 245)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(1009, 288)
        Me.GroupBox3.TabIndex = 97
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Masterlist"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblTotalCerf)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.TblCertificatesDataGridView)
        Me.GroupBox4.Controls.Add(Me.btnNext)
        Me.GroupBox4.Controls.Add(Me.btnPrevious)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(496, 540)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(1009, 325)
        Me.GroupBox4.TabIndex = 98
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Transactions List"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Bgy_CaptainLabel)
        Me.GroupBox5.Controls.Add(Me.Bgy_CaptainTextBox)
        Me.GroupBox5.Controls.Add(Full_nameLabel)
        Me.GroupBox5.Controls.Add(Me.Full_nameTextBox)
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(31, 752)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(453, 113)
        Me.GroupBox5.TabIndex = 99
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Signatories"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Full_DetailLabel)
        Me.GroupBox6.Controls.Add(Me.Full_DetailTextBox)
        Me.GroupBox6.Controls.Add(Dates_IssuedLabel)
        Me.GroupBox6.Controls.Add(Me.Dates_IssuedDateTimePicker)
        Me.GroupBox6.Controls.Add(OR_NoLabel)
        Me.GroupBox6.Controls.Add(Me.OR_NoTextBox)
        Me.GroupBox6.Controls.Add(Receipt_YearLabel)
        Me.GroupBox6.Controls.Add(Me.Receipt_YearTextBox)
        Me.GroupBox6.Controls.Add(SubjectLabel)
        Me.GroupBox6.Controls.Add(Me.SubjectComboBox)
        Me.GroupBox6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(31, 244)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Size = New System.Drawing.Size(453, 497)
        Me.GroupBox6.TabIndex = 100
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Informations"
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsReturn = True
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCertificatesBindingSource, "Cerf ID", True))
        Me.TextBox1.Location = New System.Drawing.Point(517, 876)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 101
        '
        'TblCertificatesBindingSource
        '
        Me.TblCertificatesBindingSource.DataMember = "tblRbitblCertificates"
        Me.TblCertificatesBindingSource.DataSource = Me.TblRbiBindingSource
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Subject"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Subject"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Receipt Year"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Receipt Year"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "OR No"
        Me.DataGridViewTextBoxColumn18.HeaderText = "OR No"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Dates Issued"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Dates Issued"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Secretary"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Secretary"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "RBI ID"
        Me.DataGridViewTextBoxColumn21.HeaderText = "RBI ID"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Full Detail"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Full Detail"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'SubjectLabel1
        '
        SubjectLabel1.AutoSize = True
        SubjectLabel1.Location = New System.Drawing.Point(1581, 189)
        SubjectLabel1.Name = "SubjectLabel1"
        SubjectLabel1.Size = New System.Drawing.Size(59, 17)
        SubjectLabel1.TabIndex = 101
        SubjectLabel1.Text = "Subject:"
        '
        'SubjectComboBox1
        '
        Me.SubjectComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCertificatesBindingSource, "Subject", True))
        Me.SubjectComboBox1.FormattingEnabled = True
        Me.SubjectComboBox1.Location = New System.Drawing.Point(1681, 186)
        Me.SubjectComboBox1.Name = "SubjectComboBox1"
        Me.SubjectComboBox1.Size = New System.Drawing.Size(200, 24)
        Me.SubjectComboBox1.TabIndex = 102
        '
        'Receipt_YearLabel1
        '
        Receipt_YearLabel1.AutoSize = True
        Receipt_YearLabel1.Location = New System.Drawing.Point(1581, 220)
        Receipt_YearLabel1.Name = "Receipt_YearLabel1"
        Receipt_YearLabel1.Size = New System.Drawing.Size(94, 17)
        Receipt_YearLabel1.TabIndex = 103
        Receipt_YearLabel1.Text = "Receipt Year:"
        '
        'Receipt_YearTextBox1
        '
        Me.Receipt_YearTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCertificatesBindingSource, "Receipt Year", True))
        Me.Receipt_YearTextBox1.Location = New System.Drawing.Point(1681, 217)
        Me.Receipt_YearTextBox1.Name = "Receipt_YearTextBox1"
        Me.Receipt_YearTextBox1.Size = New System.Drawing.Size(200, 22)
        Me.Receipt_YearTextBox1.TabIndex = 104
        '
        'OR_NoLabel1
        '
        OR_NoLabel1.AutoSize = True
        OR_NoLabel1.Location = New System.Drawing.Point(1581, 248)
        OR_NoLabel1.Name = "OR_NoLabel1"
        OR_NoLabel1.Size = New System.Drawing.Size(55, 17)
        OR_NoLabel1.TabIndex = 105
        OR_NoLabel1.Text = "OR No:"
        '
        'OR_NoTextBox1
        '
        Me.OR_NoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCertificatesBindingSource, "OR No", True))
        Me.OR_NoTextBox1.Location = New System.Drawing.Point(1681, 245)
        Me.OR_NoTextBox1.Name = "OR_NoTextBox1"
        Me.OR_NoTextBox1.Size = New System.Drawing.Size(200, 22)
        Me.OR_NoTextBox1.TabIndex = 106
        '
        'Dates_IssuedLabel1
        '
        Dates_IssuedLabel1.AutoSize = True
        Dates_IssuedLabel1.Location = New System.Drawing.Point(1581, 277)
        Dates_IssuedLabel1.Name = "Dates_IssuedLabel1"
        Dates_IssuedLabel1.Size = New System.Drawing.Size(94, 17)
        Dates_IssuedLabel1.TabIndex = 107
        Dates_IssuedLabel1.Text = "Dates Issued:"
        '
        'Dates_IssuedDateTimePicker1
        '
        Me.Dates_IssuedDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblCertificatesBindingSource, "Dates Issued", True))
        Me.Dates_IssuedDateTimePicker1.Location = New System.Drawing.Point(1681, 273)
        Me.Dates_IssuedDateTimePicker1.Name = "Dates_IssuedDateTimePicker1"
        Me.Dates_IssuedDateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.Dates_IssuedDateTimePicker1.TabIndex = 108
        '
        'SecretaryLabel
        '
        SecretaryLabel.AutoSize = True
        SecretaryLabel.Location = New System.Drawing.Point(1581, 304)
        SecretaryLabel.Name = "SecretaryLabel"
        SecretaryLabel.Size = New System.Drawing.Size(73, 17)
        SecretaryLabel.TabIndex = 109
        SecretaryLabel.Text = "Secretary:"
        '
        'SecretaryTextBox
        '
        Me.SecretaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCertificatesBindingSource, "Secretary", True))
        Me.SecretaryTextBox.Location = New System.Drawing.Point(1681, 301)
        Me.SecretaryTextBox.Name = "SecretaryTextBox"
        Me.SecretaryTextBox.Size = New System.Drawing.Size(200, 22)
        Me.SecretaryTextBox.TabIndex = 110
        '
        'RBI_IDLabel
        '
        RBI_IDLabel.AutoSize = True
        RBI_IDLabel.Location = New System.Drawing.Point(1581, 332)
        RBI_IDLabel.Name = "RBI_IDLabel"
        RBI_IDLabel.Size = New System.Drawing.Size(51, 17)
        RBI_IDLabel.TabIndex = 111
        RBI_IDLabel.Text = "RBI ID:"
        '
        'RBI_IDTextBox
        '
        Me.RBI_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCertificatesBindingSource, "RBI ID", True))
        Me.RBI_IDTextBox.Location = New System.Drawing.Point(1681, 329)
        Me.RBI_IDTextBox.Name = "RBI_IDTextBox"
        Me.RBI_IDTextBox.Size = New System.Drawing.Size(200, 22)
        Me.RBI_IDTextBox.TabIndex = 112
        '
        'Full_DetailLabel1
        '
        Full_DetailLabel1.AutoSize = True
        Full_DetailLabel1.Location = New System.Drawing.Point(1581, 360)
        Full_DetailLabel1.Name = "Full_DetailLabel1"
        Full_DetailLabel1.Size = New System.Drawing.Size(74, 17)
        Full_DetailLabel1.TabIndex = 113
        Full_DetailLabel1.Text = "Full Detail:"
        '
        'Full_DetailTextBox1
        '
        Me.Full_DetailTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCertificatesBindingSource, "Full Detail", True))
        Me.Full_DetailTextBox1.Location = New System.Drawing.Point(1681, 357)
        Me.Full_DetailTextBox1.Name = "Full_DetailTextBox1"
        Me.Full_DetailTextBox1.Size = New System.Drawing.Size(200, 22)
        Me.Full_DetailTextBox1.TabIndex = 114
        '
        'Cerf_IDLabel
        '
        Cerf_IDLabel.AutoSize = True
        Cerf_IDLabel.Location = New System.Drawing.Point(1581, 388)
        Cerf_IDLabel.Name = "Cerf_IDLabel"
        Cerf_IDLabel.Size = New System.Drawing.Size(55, 17)
        Cerf_IDLabel.TabIndex = 115
        Cerf_IDLabel.Text = "Cerf ID:"
        '
        'Cerf_IDTextBox
        '
        Me.Cerf_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCertificatesBindingSource, "Cerf ID", True))
        Me.Cerf_IDTextBox.Location = New System.Drawing.Point(1681, 385)
        Me.Cerf_IDTextBox.Name = "Cerf_IDTextBox"
        Me.Cerf_IDTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Cerf_IDTextBox.TabIndex = 116
        '
        'frmCertificate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1936, 949)
        Me.Controls.Add(SubjectLabel1)
        Me.Controls.Add(Me.SubjectComboBox1)
        Me.Controls.Add(Receipt_YearLabel1)
        Me.Controls.Add(Me.Receipt_YearTextBox1)
        Me.Controls.Add(OR_NoLabel1)
        Me.Controls.Add(Me.OR_NoTextBox1)
        Me.Controls.Add(Dates_IssuedLabel1)
        Me.Controls.Add(Me.Dates_IssuedDateTimePicker1)
        Me.Controls.Add(SecretaryLabel)
        Me.Controls.Add(Me.SecretaryTextBox)
        Me.Controls.Add(RBI_IDLabel)
        Me.Controls.Add(Me.RBI_IDTextBox)
        Me.Controls.Add(Full_DetailLabel1)
        Me.Controls.Add(Me.Full_DetailTextBox1)
        Me.Controls.Add(Cerf_IDLabel)
        Me.Controls.Add(Me.Cerf_IDTextBox)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(PhotoLabel)
        Me.Controls.Add(Me.PhotoTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TblRbiBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCertificate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barangay Certification Tracking"
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRbiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRbiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblRbiBindingNavigator.ResumeLayout(False)
        Me.TblRbiBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSecretaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRbiDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCertificatesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblClearanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.TblCertificatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSet As RecordBgySystem.DataSet
    Friend WithEvents TblRbiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblRbiTableAdapter As RecordBgySystem.DataSetTableAdapters.tblRbiTableAdapter
    Friend WithEvents TableAdapterManager As RecordBgySystem.DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblRbiBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblRbiBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblCertificatesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblCertificatesTableAdapter As RecordBgySystem.DataSetTableAdapters.tblCertificatesTableAdapter
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PhotoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents tbMN As System.Windows.Forms.TextBox
    Friend WithEvents tbFN As System.Windows.Forms.TextBox
    Friend WithEvents tbLN As System.Windows.Forms.TextBox
    Friend WithEvents SubjectComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Receipt_YearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OR_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Dates_IssuedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Full_DetailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents TblSecretaryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblSecretaryTableAdapter As RecordBgySystem.DataSetTableAdapters.tblSecretaryTableAdapter
    Friend WithEvents TblRbiDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TblCertificatesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Full_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TblClearanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblClearanceTableAdapter As RecordBgySystem.DataSetTableAdapters.tblClearanceTableAdapter
    Friend WithEvents Bgy_CaptainTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTotalRbi As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblTotalCerf As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents btnCancelEdit As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SubjectComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Receipt_YearTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents OR_NoTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Dates_IssuedDateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents SecretaryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RBI_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Full_DetailTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Cerf_IDTextBox As System.Windows.Forms.TextBox
End Class
