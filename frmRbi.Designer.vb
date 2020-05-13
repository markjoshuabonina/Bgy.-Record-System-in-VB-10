<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRbi
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
        Dim RBI_IDLabel As System.Windows.Forms.Label
        Dim PhotoLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Middle_NameLabel As System.Windows.Forms.Label
        Dim Nick_NameLabel As System.Windows.Forms.Label
        Dim Birth_DateLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim Birth_PlaceLabel As System.Windows.Forms.Label
        Dim Date_of_ResidencyLabel As System.Windows.Forms.Label
        Dim SexLabel As System.Windows.Forms.Label
        Dim PurokLabel As System.Windows.Forms.Label
        Dim Status_of_ResidencyLabel As System.Windows.Forms.Label
        Dim Civil_StatusLabel As System.Windows.Forms.Label
        Dim ReligionLabel As System.Windows.Forms.Label
        Dim ForIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRbi))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TblRbiBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.TblRbiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New RecordBgySystem.DataSet()
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
        Me.RBI_IDTextBox = New System.Windows.Forms.TextBox()
        Me.PhotoTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Middle_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Nick_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Birth_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.Birth_PlaceTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_ResidencyDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.tbLN = New System.Windows.Forms.TextBox()
        Me.tbFN = New System.Windows.Forms.TextBox()
        Me.tbMN = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SexComboBox = New System.Windows.Forms.ComboBox()
        Me.PurokComboBox = New System.Windows.Forms.ComboBox()
        Me.Status_of_ResidencyComboBox = New System.Windows.Forms.ComboBox()
        Me.Civil_StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.tbSearchFirstName = New System.Windows.Forms.TextBox()
        Me.tbSearchMiddleName = New System.Windows.Forms.TextBox()
        Me.Last_NameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Last_NameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.TestToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TestToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FNToolStrip = New System.Windows.Forms.ToolStrip()
        Me.First_NameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.First_NameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FNToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.LN_FNToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Last_NameToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Last_NameToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.First_NameToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.First_NameToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.LN_FNToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.LN_MNToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Last_NameToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Last_NameToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.Middle_NameToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Middle_NameToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.LN_MNToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FN_MNToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Middle_NameToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Middle_NameToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.First_NameToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.First_NameToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.FN_MNToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ALLToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Last_NameToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.Last_NameToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox()
        Me.First_NameToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.First_NameToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox()
        Me.Middle_NameToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.Middle_NameToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox()
        Me.ALLToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.MNToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Middle_NameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Middle_NameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.MNToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ReligionComboBox = New System.Windows.Forms.ComboBox()
        Me.TblRbiTableAdapter = New RecordBgySystem.DataSetTableAdapters.tblRbiTableAdapter()
        Me.TableAdapterManager = New RecordBgySystem.DataSetTableAdapters.TableAdapterManager()
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
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotalRbi = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnCancelEdit = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.TblCountersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCountersTableAdapter = New RecordBgySystem.DataSetTableAdapters.tblCountersTableAdapter()
        Me.ForIDTextBox = New System.Windows.Forms.TextBox()
        Me.TblCountersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LNandFNToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Last_NameToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.Last_NameToolStripTextBox4 = New System.Windows.Forms.ToolStripTextBox()
        Me.First_NameToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.First_NameToolStripTextBox4 = New System.Windows.Forms.ToolStripTextBox()
        Me.LNandFNToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.LNandMNToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Last_NameToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.Last_NameToolStripTextBox5 = New System.Windows.Forms.ToolStripTextBox()
        Me.Middle_NameToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.Middle_NameToolStripTextBox4 = New System.Windows.Forms.ToolStripTextBox()
        Me.LNandMNToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FNandMNToolStrip = New System.Windows.Forms.ToolStrip()
        Me.First_NameToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.First_NameToolStripTextBox5 = New System.Windows.Forms.ToolStripTextBox()
        Me.Middle_NameToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.Middle_NameToolStripTextBox5 = New System.Windows.Forms.ToolStripTextBox()
        Me.FNandMNToolStripButton = New System.Windows.Forms.ToolStripButton()
        RBI_IDLabel = New System.Windows.Forms.Label()
        PhotoLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Middle_NameLabel = New System.Windows.Forms.Label()
        Nick_NameLabel = New System.Windows.Forms.Label()
        Birth_DateLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        Birth_PlaceLabel = New System.Windows.Forms.Label()
        Date_of_ResidencyLabel = New System.Windows.Forms.Label()
        SexLabel = New System.Windows.Forms.Label()
        PurokLabel = New System.Windows.Forms.Label()
        Status_of_ResidencyLabel = New System.Windows.Forms.Label()
        Civil_StatusLabel = New System.Windows.Forms.Label()
        ReligionLabel = New System.Windows.Forms.Label()
        ForIDLabel = New System.Windows.Forms.Label()
        CType(Me.TblRbiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblRbiBindingNavigator.SuspendLayout()
        CType(Me.TblRbiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TestToolStrip.SuspendLayout()
        Me.FNToolStrip.SuspendLayout()
        Me.LN_FNToolStrip.SuspendLayout()
        Me.LN_MNToolStrip.SuspendLayout()
        Me.FN_MNToolStrip.SuspendLayout()
        Me.ALLToolStrip.SuspendLayout()
        Me.MNToolStrip.SuspendLayout()
        CType(Me.TblRbiDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.TblCountersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCountersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LNandFNToolStrip.SuspendLayout()
        Me.LNandMNToolStrip.SuspendLayout()
        Me.FNandMNToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'RBI_IDLabel
        '
        RBI_IDLabel.AutoSize = True
        RBI_IDLabel.Location = New System.Drawing.Point(8, 32)
        RBI_IDLabel.Name = "RBI_IDLabel"
        RBI_IDLabel.Size = New System.Drawing.Size(53, 20)
        RBI_IDLabel.TabIndex = 2
        RBI_IDLabel.Text = "RBI ID:"
        '
        'PhotoLabel
        '
        PhotoLabel.AutoSize = True
        PhotoLabel.Location = New System.Drawing.Point(80, 98)
        PhotoLabel.Name = "PhotoLabel"
        PhotoLabel.Size = New System.Drawing.Size(60, 23)
        PhotoLabel.TabIndex = 4
        PhotoLabel.Text = "Photo:"
        PhotoLabel.Visible = False
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(4, 32)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(82, 20)
        Last_NameLabel.TabIndex = 6
        Last_NameLabel.Text = "Last Name:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(5, 65)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(83, 20)
        First_NameLabel.TabIndex = 8
        First_NameLabel.Text = "First Name:"
        '
        'Middle_NameLabel
        '
        Middle_NameLabel.AutoSize = True
        Middle_NameLabel.Location = New System.Drawing.Point(5, 97)
        Middle_NameLabel.Name = "Middle_NameLabel"
        Middle_NameLabel.Size = New System.Drawing.Size(103, 20)
        Middle_NameLabel.TabIndex = 10
        Middle_NameLabel.Text = "Middle Name:"
        '
        'Nick_NameLabel
        '
        Nick_NameLabel.AutoSize = True
        Nick_NameLabel.Location = New System.Drawing.Point(5, 129)
        Nick_NameLabel.Name = "Nick_NameLabel"
        Nick_NameLabel.Size = New System.Drawing.Size(85, 20)
        Nick_NameLabel.TabIndex = 12
        Nick_NameLabel.Text = "Nick Name:"
        '
        'Birth_DateLabel
        '
        Birth_DateLabel.AutoSize = True
        Birth_DateLabel.Location = New System.Drawing.Point(217, 128)
        Birth_DateLabel.Name = "Birth_DateLabel"
        Birth_DateLabel.Size = New System.Drawing.Size(79, 20)
        Birth_DateLabel.TabIndex = 14
        Birth_DateLabel.Text = "Birth Date:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(460, 162)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(39, 20)
        AgeLabel.TabIndex = 16
        AgeLabel.Text = "Age:"
        '
        'Birth_PlaceLabel
        '
        Birth_PlaceLabel.AutoSize = True
        Birth_PlaceLabel.Location = New System.Drawing.Point(309, 198)
        Birth_PlaceLabel.Name = "Birth_PlaceLabel"
        Birth_PlaceLabel.Size = New System.Drawing.Size(82, 20)
        Birth_PlaceLabel.TabIndex = 24
        Birth_PlaceLabel.Text = "Birth Place:"
        '
        'Date_of_ResidencyLabel
        '
        Date_of_ResidencyLabel.AutoSize = True
        Date_of_ResidencyLabel.Location = New System.Drawing.Point(7, 100)
        Date_of_ResidencyLabel.Name = "Date_of_ResidencyLabel"
        Date_of_ResidencyLabel.Size = New System.Drawing.Size(150, 23)
        Date_of_ResidencyLabel.TabIndex = 30
        Date_of_ResidencyLabel.Text = "Date of Residency:"
        '
        'SexLabel
        '
        SexLabel.AutoSize = True
        SexLabel.Location = New System.Drawing.Point(307, 162)
        SexLabel.Name = "SexLabel"
        SexLabel.Size = New System.Drawing.Size(35, 20)
        SexLabel.TabIndex = 48
        SexLabel.Text = "Sex:"
        '
        'PurokLabel
        '
        PurokLabel.AutoSize = True
        PurokLabel.Location = New System.Drawing.Point(5, 28)
        PurokLabel.Name = "PurokLabel"
        PurokLabel.Size = New System.Drawing.Size(58, 23)
        PurokLabel.TabIndex = 50
        PurokLabel.Text = "Purok:"
        '
        'Status_of_ResidencyLabel
        '
        Status_of_ResidencyLabel.AutoSize = True
        Status_of_ResidencyLabel.Location = New System.Drawing.Point(5, 62)
        Status_of_ResidencyLabel.Name = "Status_of_ResidencyLabel"
        Status_of_ResidencyLabel.Size = New System.Drawing.Size(160, 23)
        Status_of_ResidencyLabel.TabIndex = 51
        Status_of_ResidencyLabel.Text = "Status of Residency:"
        '
        'Civil_StatusLabel
        '
        Civil_StatusLabel.AutoSize = True
        Civil_StatusLabel.Location = New System.Drawing.Point(21, 164)
        Civil_StatusLabel.Name = "Civil_StatusLabel"
        Civil_StatusLabel.Size = New System.Drawing.Size(84, 20)
        Civil_StatusLabel.TabIndex = 52
        Civil_StatusLabel.Text = "Civil Status:"
        '
        'ReligionLabel
        '
        ReligionLabel.AutoSize = True
        ReligionLabel.Location = New System.Drawing.Point(44, 198)
        ReligionLabel.Name = "ReligionLabel"
        ReligionLabel.Size = New System.Drawing.Size(67, 20)
        ReligionLabel.TabIndex = 61
        ReligionLabel.Text = "Religion:"
        AddHandler ReligionLabel.Click, AddressOf Me.ReligionLabel_Click
        '
        'ForIDLabel
        '
        ForIDLabel.AutoSize = True
        ForIDLabel.Location = New System.Drawing.Point(734, 6)
        ForIDLabel.Name = "ForIDLabel"
        ForIDLabel.Size = New System.Drawing.Size(50, 17)
        ForIDLabel.TabIndex = 73
        ForIDLabel.Text = "For ID:"
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
        'TblRbiBindingSource
        '
        Me.TblRbiBindingSource.DataMember = "tblRbi"
        Me.TblRbiBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'RBI_IDTextBox
        '
        Me.RBI_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRbiBindingSource, "RBI ID", True))
        Me.RBI_IDTextBox.Location = New System.Drawing.Point(119, 26)
        Me.RBI_IDTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RBI_IDTextBox.Name = "RBI_IDTextBox"
        Me.RBI_IDTextBox.ReadOnly = True
        Me.RBI_IDTextBox.Size = New System.Drawing.Size(465, 27)
        Me.RBI_IDTextBox.TabIndex = 3
        '
        'PhotoTextBox
        '
        Me.PhotoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRbiBindingSource, "Photo", True))
        Me.PhotoTextBox.Location = New System.Drawing.Point(1128, 21)
        Me.PhotoTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PhotoTextBox.Name = "PhotoTextBox"
        Me.PhotoTextBox.Size = New System.Drawing.Size(200, 22)
        Me.PhotoTextBox.TabIndex = 5
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRbiBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(119, 27)
        Me.Last_NameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.ReadOnly = True
        Me.Last_NameTextBox.Size = New System.Drawing.Size(465, 27)
        Me.Last_NameTextBox.TabIndex = 7
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRbiBindingSource, "First Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(119, 59)
        Me.First_NameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.ReadOnly = True
        Me.First_NameTextBox.Size = New System.Drawing.Size(465, 27)
        Me.First_NameTextBox.TabIndex = 9
        '
        'Middle_NameTextBox
        '
        Me.Middle_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRbiBindingSource, "Middle Name", True))
        Me.Middle_NameTextBox.Location = New System.Drawing.Point(119, 92)
        Me.Middle_NameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Middle_NameTextBox.Name = "Middle_NameTextBox"
        Me.Middle_NameTextBox.ReadOnly = True
        Me.Middle_NameTextBox.Size = New System.Drawing.Size(465, 27)
        Me.Middle_NameTextBox.TabIndex = 11
        '
        'Nick_NameTextBox
        '
        Me.Nick_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRbiBindingSource, "Nick Name", True))
        Me.Nick_NameTextBox.Location = New System.Drawing.Point(119, 124)
        Me.Nick_NameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Nick_NameTextBox.Name = "Nick_NameTextBox"
        Me.Nick_NameTextBox.ReadOnly = True
        Me.Nick_NameTextBox.Size = New System.Drawing.Size(92, 27)
        Me.Nick_NameTextBox.TabIndex = 13
        '
        'Birth_DateDateTimePicker
        '
        Me.Birth_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblRbiBindingSource, "Birth Date", True))
        Me.Birth_DateDateTimePicker.Enabled = False
        Me.Birth_DateDateTimePicker.Location = New System.Drawing.Point(305, 124)
        Me.Birth_DateDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Birth_DateDateTimePicker.Name = "Birth_DateDateTimePicker"
        Me.Birth_DateDateTimePicker.Size = New System.Drawing.Size(279, 27)
        Me.Birth_DateDateTimePicker.TabIndex = 15
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRbiBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(507, 159)
        Me.AgeTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.ReadOnly = True
        Me.AgeTextBox.Size = New System.Drawing.Size(77, 27)
        Me.AgeTextBox.TabIndex = 17
        '
        'Birth_PlaceTextBox
        '
        Me.Birth_PlaceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRbiBindingSource, "Birth Place", True))
        Me.Birth_PlaceTextBox.Location = New System.Drawing.Point(421, 194)
        Me.Birth_PlaceTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Birth_PlaceTextBox.Name = "Birth_PlaceTextBox"
        Me.Birth_PlaceTextBox.ReadOnly = True
        Me.Birth_PlaceTextBox.Size = New System.Drawing.Size(163, 27)
        Me.Birth_PlaceTextBox.TabIndex = 25
        '
        'Date_of_ResidencyDateTimePicker
        '
        Me.Date_of_ResidencyDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblRbiBindingSource, "Date of Residency", True))
        Me.Date_of_ResidencyDateTimePicker.Enabled = False
        Me.Date_of_ResidencyDateTimePicker.Location = New System.Drawing.Point(183, 95)
        Me.Date_of_ResidencyDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Date_of_ResidencyDateTimePicker.Name = "Date_of_ResidencyDateTimePicker"
        Me.Date_of_ResidencyDateTimePicker.Size = New System.Drawing.Size(304, 29)
        Me.Date_of_ResidencyDateTimePicker.TabIndex = 31
        '
        'btnAddNew
        '
        Me.btnAddNew.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.Location = New System.Drawing.Point(16, 22)
        Me.btnAddNew.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(133, 39)
        Me.btnAddNew.TabIndex = 32
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(293, 22)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(133, 39)
        Me.btnEdit.TabIndex = 33
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(571, 22)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(133, 39)
        Me.btnDelete.TabIndex = 33
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(709, 22)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(133, 39)
        Me.btnSave.TabIndex = 33
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(155, 22)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(133, 39)
        Me.btnCancel.TabIndex = 33
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(619, 332)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(85, 32)
        Me.btnPrevious.TabIndex = 34
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(708, 332)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(85, 32)
        Me.btnNext.TabIndex = 35
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'tbLN
        '
        Me.tbLN.Location = New System.Drawing.Point(43, 53)
        Me.tbLN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbLN.Name = "tbLN"
        Me.tbLN.Size = New System.Drawing.Size(135, 29)
        Me.tbLN.TabIndex = 36
        '
        'tbFN
        '
        Me.tbFN.Location = New System.Drawing.Point(184, 53)
        Me.tbFN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbFN.Name = "tbFN"
        Me.tbFN.Size = New System.Drawing.Size(135, 29)
        Me.tbFN.TabIndex = 36
        '
        'tbMN
        '
        Me.tbMN.Location = New System.Drawing.Point(324, 53)
        Me.tbMN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbMN.Name = "tbMN"
        Me.tbMN.Size = New System.Drawing.Size(135, 29)
        Me.tbMN.TabIndex = 36
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(153, 102)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(101, 34)
        Me.btnSearch.TabIndex = 37
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(257, 102)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 34)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "CLEAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 23)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(180, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 23)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(320, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 23)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Middle Name"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(17, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(51, 50, 51, 50)
        Me.Label4.Size = New System.Drawing.Size(255, 200)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "PHOTO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NOT " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AVAILABLE"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 32)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(255, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'btnBrowse
        '
        Me.btnBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.Column
        Me.btnBrowse.Enabled = False
        Me.btnBrowse.Location = New System.Drawing.Point(103, 254)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(103, 41)
        Me.btnBrowse.TabIndex = 42
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SexComboBox
        '
        Me.SexComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRbiBindingSource, "Sex", True))
        Me.SexComboBox.Enabled = False
        Me.SexComboBox.FormattingEnabled = True
        Me.SexComboBox.Items.AddRange(New Object() {"", "Male", "Female"})
        Me.SexComboBox.Location = New System.Drawing.Point(348, 159)
        Me.SexComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SexComboBox.Name = "SexComboBox"
        Me.SexComboBox.Size = New System.Drawing.Size(105, 28)
        Me.SexComboBox.TabIndex = 49
        '
        'PurokComboBox
        '
        Me.PurokComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRbiBindingSource, "Purok", True))
        Me.PurokComboBox.Enabled = False
        Me.PurokComboBox.FormattingEnabled = True
        Me.PurokComboBox.Items.AddRange(New Object() {"", "1", "2", "3", "4", "5", "6"})
        Me.PurokComboBox.Location = New System.Drawing.Point(183, 20)
        Me.PurokComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PurokComboBox.Name = "PurokComboBox"
        Me.PurokComboBox.Size = New System.Drawing.Size(304, 29)
        Me.PurokComboBox.TabIndex = 51
        '
        'Status_of_ResidencyComboBox
        '
        Me.Status_of_ResidencyComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRbiBindingSource, "Status of Residency", True))
        Me.Status_of_ResidencyComboBox.Enabled = False
        Me.Status_of_ResidencyComboBox.FormattingEnabled = True
        Me.Status_of_ResidencyComboBox.Items.AddRange(New Object() {"", "Permanent", "Renting", "Squatting"})
        Me.Status_of_ResidencyComboBox.Location = New System.Drawing.Point(183, 57)
        Me.Status_of_ResidencyComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Status_of_ResidencyComboBox.Name = "Status_of_ResidencyComboBox"
        Me.Status_of_ResidencyComboBox.Size = New System.Drawing.Size(304, 29)
        Me.Status_of_ResidencyComboBox.TabIndex = 52
        '
        'Civil_StatusComboBox
        '
        Me.Civil_StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRbiBindingSource, "Civil Status", True))
        Me.Civil_StatusComboBox.Enabled = False
        Me.Civil_StatusComboBox.FormattingEnabled = True
        Me.Civil_StatusComboBox.Items.AddRange(New Object() {"", "Single", "Married", "Widowed"})
        Me.Civil_StatusComboBox.Location = New System.Drawing.Point(119, 159)
        Me.Civil_StatusComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Civil_StatusComboBox.Name = "Civil_StatusComboBox"
        Me.Civil_StatusComboBox.Size = New System.Drawing.Size(180, 28)
        Me.Civil_StatusComboBox.TabIndex = 53
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(1409, 850)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 32)
        Me.Button4.TabIndex = 38
        Me.Button4.Text = "CLOSE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'tbSearchFirstName
        '
        Me.tbSearchFirstName.Location = New System.Drawing.Point(892, 64)
        Me.tbSearchFirstName.Name = "tbSearchFirstName"
        Me.tbSearchFirstName.Size = New System.Drawing.Size(100, 22)
        Me.tbSearchFirstName.TabIndex = 36
        '
        'tbSearchMiddleName
        '
        Me.tbSearchMiddleName.Location = New System.Drawing.Point(1023, 64)
        Me.tbSearchMiddleName.Name = "tbSearchMiddleName"
        Me.tbSearchMiddleName.Size = New System.Drawing.Size(100, 22)
        Me.tbSearchMiddleName.TabIndex = 36
        '
        'Last_NameToolStripLabel
        '
        Me.Last_NameToolStripLabel.Name = "Last_NameToolStripLabel"
        Me.Last_NameToolStripLabel.Size = New System.Drawing.Size(84, 24)
        Me.Last_NameToolStripLabel.Text = "Last_Name:"
        '
        'Last_NameToolStripTextBox
        '
        Me.Last_NameToolStripTextBox.Name = "Last_NameToolStripTextBox"
        Me.Last_NameToolStripTextBox.Size = New System.Drawing.Size(100, 27)
        '
        'TestToolStripButton
        '
        Me.TestToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TestToolStripButton.Name = "TestToolStripButton"
        Me.TestToolStripButton.Size = New System.Drawing.Size(37, 24)
        Me.TestToolStripButton.Text = "test"
        '
        'TestToolStrip
        '
        Me.TestToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Last_NameToolStripLabel, Me.Last_NameToolStripTextBox, Me.TestToolStripButton})
        Me.TestToolStrip.Location = New System.Drawing.Point(0, 27)
        Me.TestToolStrip.Name = "TestToolStrip"
        Me.TestToolStrip.Size = New System.Drawing.Size(1656, 27)
        Me.TestToolStrip.TabIndex = 54
        Me.TestToolStrip.Text = "TestToolStrip"
        Me.TestToolStrip.Visible = False
        '
        'FNToolStrip
        '
        Me.FNToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.FNToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.First_NameToolStripLabel, Me.First_NameToolStripTextBox, Me.FNToolStripButton})
        Me.FNToolStrip.Location = New System.Drawing.Point(0, 27)
        Me.FNToolStrip.Name = "FNToolStrip"
        Me.FNToolStrip.Size = New System.Drawing.Size(1656, 27)
        Me.FNToolStrip.TabIndex = 55
        Me.FNToolStrip.Text = "FNToolStrip"
        Me.FNToolStrip.Visible = False
        '
        'First_NameToolStripLabel
        '
        Me.First_NameToolStripLabel.Name = "First_NameToolStripLabel"
        Me.First_NameToolStripLabel.Size = New System.Drawing.Size(85, 24)
        Me.First_NameToolStripLabel.Text = "First_Name:"
        '
        'First_NameToolStripTextBox
        '
        Me.First_NameToolStripTextBox.Name = "First_NameToolStripTextBox"
        Me.First_NameToolStripTextBox.Size = New System.Drawing.Size(100, 27)
        '
        'FNToolStripButton
        '
        Me.FNToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FNToolStripButton.Name = "FNToolStripButton"
        Me.FNToolStripButton.Size = New System.Drawing.Size(31, 24)
        Me.FNToolStripButton.Text = "FN"
        '
        'LN_FNToolStrip
        '
        Me.LN_FNToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Last_NameToolStripLabel1, Me.Last_NameToolStripTextBox1, Me.First_NameToolStripLabel1, Me.First_NameToolStripTextBox1, Me.LN_FNToolStripButton})
        Me.LN_FNToolStrip.Location = New System.Drawing.Point(0, 27)
        Me.LN_FNToolStrip.Name = "LN_FNToolStrip"
        Me.LN_FNToolStrip.Size = New System.Drawing.Size(1656, 27)
        Me.LN_FNToolStrip.TabIndex = 57
        Me.LN_FNToolStrip.Text = "LN_FNToolStrip"
        Me.LN_FNToolStrip.Visible = False
        '
        'Last_NameToolStripLabel1
        '
        Me.Last_NameToolStripLabel1.Name = "Last_NameToolStripLabel1"
        Me.Last_NameToolStripLabel1.Size = New System.Drawing.Size(84, 24)
        Me.Last_NameToolStripLabel1.Text = "Last_Name:"
        '
        'Last_NameToolStripTextBox1
        '
        Me.Last_NameToolStripTextBox1.Name = "Last_NameToolStripTextBox1"
        Me.Last_NameToolStripTextBox1.Size = New System.Drawing.Size(100, 27)
        '
        'First_NameToolStripLabel1
        '
        Me.First_NameToolStripLabel1.Name = "First_NameToolStripLabel1"
        Me.First_NameToolStripLabel1.Size = New System.Drawing.Size(85, 24)
        Me.First_NameToolStripLabel1.Text = "First_Name:"
        '
        'First_NameToolStripTextBox1
        '
        Me.First_NameToolStripTextBox1.Name = "First_NameToolStripTextBox1"
        Me.First_NameToolStripTextBox1.Size = New System.Drawing.Size(100, 27)
        '
        'LN_FNToolStripButton
        '
        Me.LN_FNToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.LN_FNToolStripButton.Name = "LN_FNToolStripButton"
        Me.LN_FNToolStripButton.Size = New System.Drawing.Size(55, 24)
        Me.LN_FNToolStripButton.Text = "LN_FN"
        '
        'LN_MNToolStrip
        '
        Me.LN_MNToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Last_NameToolStripLabel2, Me.Last_NameToolStripTextBox2, Me.Middle_NameToolStripLabel1, Me.Middle_NameToolStripTextBox1, Me.LN_MNToolStripButton})
        Me.LN_MNToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.LN_MNToolStrip.Name = "LN_MNToolStrip"
        Me.LN_MNToolStrip.Size = New System.Drawing.Size(1516, 27)
        Me.LN_MNToolStrip.TabIndex = 58
        Me.LN_MNToolStrip.Text = "LN_MNToolStrip"
        Me.LN_MNToolStrip.Visible = False
        '
        'Last_NameToolStripLabel2
        '
        Me.Last_NameToolStripLabel2.Name = "Last_NameToolStripLabel2"
        Me.Last_NameToolStripLabel2.Size = New System.Drawing.Size(84, 24)
        Me.Last_NameToolStripLabel2.Text = "Last_Name:"
        '
        'Last_NameToolStripTextBox2
        '
        Me.Last_NameToolStripTextBox2.Name = "Last_NameToolStripTextBox2"
        Me.Last_NameToolStripTextBox2.Size = New System.Drawing.Size(100, 27)
        '
        'Middle_NameToolStripLabel1
        '
        Me.Middle_NameToolStripLabel1.Name = "Middle_NameToolStripLabel1"
        Me.Middle_NameToolStripLabel1.Size = New System.Drawing.Size(105, 24)
        Me.Middle_NameToolStripLabel1.Text = "Middle_Name:"
        '
        'Middle_NameToolStripTextBox1
        '
        Me.Middle_NameToolStripTextBox1.Name = "Middle_NameToolStripTextBox1"
        Me.Middle_NameToolStripTextBox1.Size = New System.Drawing.Size(100, 27)
        '
        'LN_MNToolStripButton
        '
        Me.LN_MNToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.LN_MNToolStripButton.Name = "LN_MNToolStripButton"
        Me.LN_MNToolStripButton.Size = New System.Drawing.Size(61, 24)
        Me.LN_MNToolStripButton.Text = "LN_MN"
        '
        'FN_MNToolStrip
        '
        Me.FN_MNToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Middle_NameToolStripLabel2, Me.Middle_NameToolStripTextBox2, Me.First_NameToolStripLabel2, Me.First_NameToolStripTextBox2, Me.FN_MNToolStripButton})
        Me.FN_MNToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FN_MNToolStrip.Name = "FN_MNToolStrip"
        Me.FN_MNToolStrip.Size = New System.Drawing.Size(1516, 27)
        Me.FN_MNToolStrip.TabIndex = 59
        Me.FN_MNToolStrip.Text = "FN_MNToolStrip"
        Me.FN_MNToolStrip.Visible = False
        '
        'Middle_NameToolStripLabel2
        '
        Me.Middle_NameToolStripLabel2.Name = "Middle_NameToolStripLabel2"
        Me.Middle_NameToolStripLabel2.Size = New System.Drawing.Size(105, 24)
        Me.Middle_NameToolStripLabel2.Text = "Middle_Name:"
        '
        'Middle_NameToolStripTextBox2
        '
        Me.Middle_NameToolStripTextBox2.Name = "Middle_NameToolStripTextBox2"
        Me.Middle_NameToolStripTextBox2.Size = New System.Drawing.Size(100, 27)
        '
        'First_NameToolStripLabel2
        '
        Me.First_NameToolStripLabel2.Name = "First_NameToolStripLabel2"
        Me.First_NameToolStripLabel2.Size = New System.Drawing.Size(85, 24)
        Me.First_NameToolStripLabel2.Text = "First_Name:"
        '
        'First_NameToolStripTextBox2
        '
        Me.First_NameToolStripTextBox2.Name = "First_NameToolStripTextBox2"
        Me.First_NameToolStripTextBox2.Size = New System.Drawing.Size(100, 27)
        '
        'FN_MNToolStripButton
        '
        Me.FN_MNToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FN_MNToolStripButton.Name = "FN_MNToolStripButton"
        Me.FN_MNToolStripButton.Size = New System.Drawing.Size(61, 24)
        Me.FN_MNToolStripButton.Text = "FN_MN"
        '
        'ALLToolStrip
        '
        Me.ALLToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Last_NameToolStripLabel3, Me.Last_NameToolStripTextBox3, Me.First_NameToolStripLabel3, Me.First_NameToolStripTextBox3, Me.Middle_NameToolStripLabel3, Me.Middle_NameToolStripTextBox3, Me.ALLToolStripButton})
        Me.ALLToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ALLToolStrip.Name = "ALLToolStrip"
        Me.ALLToolStrip.Size = New System.Drawing.Size(1516, 27)
        Me.ALLToolStrip.TabIndex = 60
        Me.ALLToolStrip.Text = "ALLToolStrip"
        Me.ALLToolStrip.Visible = False
        '
        'Last_NameToolStripLabel3
        '
        Me.Last_NameToolStripLabel3.Name = "Last_NameToolStripLabel3"
        Me.Last_NameToolStripLabel3.Size = New System.Drawing.Size(84, 24)
        Me.Last_NameToolStripLabel3.Text = "Last_Name:"
        '
        'Last_NameToolStripTextBox3
        '
        Me.Last_NameToolStripTextBox3.Name = "Last_NameToolStripTextBox3"
        Me.Last_NameToolStripTextBox3.Size = New System.Drawing.Size(100, 27)
        '
        'First_NameToolStripLabel3
        '
        Me.First_NameToolStripLabel3.Name = "First_NameToolStripLabel3"
        Me.First_NameToolStripLabel3.Size = New System.Drawing.Size(85, 24)
        Me.First_NameToolStripLabel3.Text = "First_Name:"
        '
        'First_NameToolStripTextBox3
        '
        Me.First_NameToolStripTextBox3.Name = "First_NameToolStripTextBox3"
        Me.First_NameToolStripTextBox3.Size = New System.Drawing.Size(100, 27)
        '
        'Middle_NameToolStripLabel3
        '
        Me.Middle_NameToolStripLabel3.Name = "Middle_NameToolStripLabel3"
        Me.Middle_NameToolStripLabel3.Size = New System.Drawing.Size(105, 24)
        Me.Middle_NameToolStripLabel3.Text = "Middle_Name:"
        '
        'Middle_NameToolStripTextBox3
        '
        Me.Middle_NameToolStripTextBox3.Name = "Middle_NameToolStripTextBox3"
        Me.Middle_NameToolStripTextBox3.Size = New System.Drawing.Size(100, 27)
        '
        'ALLToolStripButton
        '
        Me.ALLToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ALLToolStripButton.Name = "ALLToolStripButton"
        Me.ALLToolStripButton.Size = New System.Drawing.Size(37, 24)
        Me.ALLToolStripButton.Text = "ALL"
        '
        'MNToolStrip
        '
        Me.MNToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Middle_NameToolStripLabel, Me.Middle_NameToolStripTextBox, Me.MNToolStripButton})
        Me.MNToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.MNToolStrip.Name = "MNToolStrip"
        Me.MNToolStrip.Size = New System.Drawing.Size(1516, 27)
        Me.MNToolStrip.TabIndex = 61
        Me.MNToolStrip.Text = "MNToolStrip"
        Me.MNToolStrip.Visible = False
        '
        'Middle_NameToolStripLabel
        '
        Me.Middle_NameToolStripLabel.Name = "Middle_NameToolStripLabel"
        Me.Middle_NameToolStripLabel.Size = New System.Drawing.Size(105, 24)
        Me.Middle_NameToolStripLabel.Text = "Middle_Name:"
        '
        'Middle_NameToolStripTextBox
        '
        Me.Middle_NameToolStripTextBox.Name = "Middle_NameToolStripTextBox"
        Me.Middle_NameToolStripTextBox.Size = New System.Drawing.Size(100, 27)
        '
        'MNToolStripButton
        '
        Me.MNToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.MNToolStripButton.Name = "MNToolStripButton"
        Me.MNToolStripButton.Size = New System.Drawing.Size(37, 24)
        Me.MNToolStripButton.Text = "MN"
        '
        'ReligionComboBox
        '
        Me.ReligionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRbiBindingSource, "Religion", True))
        Me.ReligionComboBox.Enabled = False
        Me.ReligionComboBox.FormattingEnabled = True
        Me.ReligionComboBox.Items.AddRange(New Object() {"", "Bible Baptist Church", "Church of Christ", "Catholic", "Iglesia Ni Cristo", "Islam", "Roman Catholic", "Buddhist", "Born Again", "Others"})
        Me.ReligionComboBox.Location = New System.Drawing.Point(119, 193)
        Me.ReligionComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ReligionComboBox.Name = "ReligionComboBox"
        Me.ReligionComboBox.Size = New System.Drawing.Size(184, 28)
        Me.ReligionComboBox.TabIndex = 62
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
        'TblRbiDataGridView
        '
        Me.TblRbiDataGridView.AutoGenerateColumns = False
        Me.TblRbiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblRbiDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn15})
        Me.TblRbiDataGridView.DataSource = Me.TblRbiBindingSource
        Me.TblRbiDataGridView.Location = New System.Drawing.Point(23, 27)
        Me.TblRbiDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TblRbiDataGridView.Name = "TblRbiDataGridView"
        Me.TblRbiDataGridView.ReadOnly = True
        Me.TblRbiDataGridView.RowTemplate.Height = 24
        Me.TblRbiDataGridView.Size = New System.Drawing.Size(1425, 299)
        Me.TblRbiDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "RBI ID"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "RBI ID"
        Me.DataGridViewTextBoxColumn1.MaxInputLength = 3000
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DataGridViewTextBoxColumn1.Width = 59
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
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Date of Residency"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Date of Residency"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 332)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 20)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Total :"
        '
        'lblTotalRbi
        '
        Me.lblTotalRbi.AutoSize = True
        Me.lblTotalRbi.Location = New System.Drawing.Point(96, 332)
        Me.lblTotalRbi.Name = "lblTotalRbi"
        Me.lblTotalRbi.Size = New System.Drawing.Size(52, 20)
        Me.lblTotalRbi.TabIndex = 63
        Me.lblTotalRbi.Text = "Total :"
        '
        'Timer1
        '
        '
        'btnCancelEdit
        '
        Me.btnCancelEdit.Enabled = False
        Me.btnCancelEdit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelEdit.Location = New System.Drawing.Point(432, 22)
        Me.btnCancelEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancelEdit.Name = "btnCancelEdit"
        Me.btnCancelEdit.Size = New System.Drawing.Size(133, 39)
        Me.btnCancelEdit.TabIndex = 64
        Me.btnCancelEdit.Text = "Cancel Edit"
        Me.btnCancelEdit.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 14)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(573, 42)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Record of Barangay Inhabitants"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCancelEdit)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.PhotoTextBox)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnAddNew)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 62)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1471, 76)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(RBI_IDLabel)
        Me.GroupBox2.Controls.Add(Me.RBI_IDTextBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(24, 140)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(619, 69)
        Me.GroupBox2.TabIndex = 67
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "(1) ID"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(ReligionLabel)
        Me.GroupBox3.Controls.Add(Me.ReligionComboBox)
        Me.GroupBox3.Controls.Add(Civil_StatusLabel)
        Me.GroupBox3.Controls.Add(Me.Civil_StatusComboBox)
        Me.GroupBox3.Controls.Add(SexLabel)
        Me.GroupBox3.Controls.Add(Last_NameLabel)
        Me.GroupBox3.Controls.Add(Me.Last_NameTextBox)
        Me.GroupBox3.Controls.Add(Me.SexComboBox)
        Me.GroupBox3.Controls.Add(First_NameLabel)
        Me.GroupBox3.Controls.Add(Me.First_NameTextBox)
        Me.GroupBox3.Controls.Add(Middle_NameLabel)
        Me.GroupBox3.Controls.Add(Me.Middle_NameTextBox)
        Me.GroupBox3.Controls.Add(Nick_NameLabel)
        Me.GroupBox3.Controls.Add(Me.Nick_NameTextBox)
        Me.GroupBox3.Controls.Add(Birth_DateLabel)
        Me.GroupBox3.Controls.Add(Me.Birth_DateDateTimePicker)
        Me.GroupBox3.Controls.Add(AgeLabel)
        Me.GroupBox3.Controls.Add(Me.AgeTextBox)
        Me.GroupBox3.Controls.Add(Birth_PlaceLabel)
        Me.GroupBox3.Controls.Add(Me.Birth_PlaceTextBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(24, 218)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(619, 244)
        Me.GroupBox3.TabIndex = 68
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "(2) Basic Information"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Status_of_ResidencyLabel)
        Me.GroupBox4.Controls.Add(Me.Status_of_ResidencyComboBox)
        Me.GroupBox4.Controls.Add(PurokLabel)
        Me.GroupBox4.Controls.Add(Me.PurokComboBox)
        Me.GroupBox4.Controls.Add(Date_of_ResidencyLabel)
        Me.GroupBox4.Controls.Add(Me.Date_of_ResidencyDateTimePicker)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(653, 139)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(515, 134)
        Me.GroupBox4.TabIndex = 69
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "(3) Address"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Button3)
        Me.GroupBox5.Controls.Add(Me.btnSearch)
        Me.GroupBox5.Controls.Add(Me.tbMN)
        Me.GroupBox5.Controls.Add(Me.tbFN)
        Me.GroupBox5.Controls.Add(Me.tbLN)
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(653, 281)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(515, 181)
        Me.GroupBox5.TabIndex = 70
        Me.GroupBox5.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnBrowse)
        Me.GroupBox6.Controls.Add(Me.PictureBox1)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(PhotoLabel)
        Me.GroupBox6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(1176, 140)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Size = New System.Drawing.Size(319, 321)
        Me.GroupBox6.TabIndex = 71
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "(4) Picture"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.lblTotalRbi)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.btnNext)
        Me.GroupBox7.Controls.Add(Me.btnPrevious)
        Me.GroupBox7.Controls.Add(Me.TblRbiDataGridView)
        Me.GroupBox7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(24, 470)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox7.Size = New System.Drawing.Size(1471, 384)
        Me.GroupBox7.TabIndex = 72
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Masterlist"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(935, 23)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(51, 17)
        Me.lblCount.TabIndex = 73
        Me.lblCount.Text = "Label7"
        '
        'TblCountersBindingSource
        '
        Me.TblCountersBindingSource.DataMember = "tblCounters"
        Me.TblCountersBindingSource.DataSource = Me.DataSet
        '
        'TblCountersTableAdapter
        '
        Me.TblCountersTableAdapter.ClearBeforeFill = True
        '
        'ForIDTextBox
        '
        Me.ForIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCountersBindingSource, "ForID", True))
        Me.ForIDTextBox.Location = New System.Drawing.Point(793, 6)
        Me.ForIDTextBox.Name = "ForIDTextBox"
        Me.ForIDTextBox.ReadOnly = True
        Me.ForIDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ForIDTextBox.TabIndex = 74
        '
        'TblCountersDataGridView
        '
        Me.TblCountersDataGridView.AutoGenerateColumns = False
        Me.TblCountersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblCountersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.TblCountersDataGridView.DataSource = Me.TblCountersBindingSource
        Me.TblCountersDataGridView.Location = New System.Drawing.Point(1012, -19)
        Me.TblCountersDataGridView.Name = "TblCountersDataGridView"
        Me.TblCountersDataGridView.RowTemplate.Height = 24
        Me.TblCountersDataGridView.Size = New System.Drawing.Size(100, 85)
        Me.TblCountersDataGridView.TabIndex = 74
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ForID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ForID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'LNandFNToolStrip
        '
        Me.LNandFNToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Last_NameToolStripLabel4, Me.Last_NameToolStripTextBox4, Me.First_NameToolStripLabel4, Me.First_NameToolStripTextBox4, Me.LNandFNToolStripButton})
        Me.LNandFNToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.LNandFNToolStrip.Name = "LNandFNToolStrip"
        Me.LNandFNToolStrip.Size = New System.Drawing.Size(1516, 27)
        Me.LNandFNToolStrip.TabIndex = 75
        Me.LNandFNToolStrip.Text = "LNandFNToolStrip"
        Me.LNandFNToolStrip.Visible = False
        '
        'Last_NameToolStripLabel4
        '
        Me.Last_NameToolStripLabel4.Name = "Last_NameToolStripLabel4"
        Me.Last_NameToolStripLabel4.Size = New System.Drawing.Size(84, 24)
        Me.Last_NameToolStripLabel4.Text = "Last_Name:"
        '
        'Last_NameToolStripTextBox4
        '
        Me.Last_NameToolStripTextBox4.Name = "Last_NameToolStripTextBox4"
        Me.Last_NameToolStripTextBox4.Size = New System.Drawing.Size(100, 27)
        '
        'First_NameToolStripLabel4
        '
        Me.First_NameToolStripLabel4.Name = "First_NameToolStripLabel4"
        Me.First_NameToolStripLabel4.Size = New System.Drawing.Size(85, 24)
        Me.First_NameToolStripLabel4.Text = "First_Name:"
        '
        'First_NameToolStripTextBox4
        '
        Me.First_NameToolStripTextBox4.Name = "First_NameToolStripTextBox4"
        Me.First_NameToolStripTextBox4.Size = New System.Drawing.Size(100, 27)
        '
        'LNandFNToolStripButton
        '
        Me.LNandFNToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.LNandFNToolStripButton.Name = "LNandFNToolStripButton"
        Me.LNandFNToolStripButton.Size = New System.Drawing.Size(74, 24)
        Me.LNandFNToolStripButton.Text = "LNandFN"
        '
        'LNandMNToolStrip
        '
        Me.LNandMNToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Last_NameToolStripLabel5, Me.Last_NameToolStripTextBox5, Me.Middle_NameToolStripLabel4, Me.Middle_NameToolStripTextBox4, Me.LNandMNToolStripButton})
        Me.LNandMNToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.LNandMNToolStrip.Name = "LNandMNToolStrip"
        Me.LNandMNToolStrip.Size = New System.Drawing.Size(1516, 27)
        Me.LNandMNToolStrip.TabIndex = 76
        Me.LNandMNToolStrip.Text = "LNandMNToolStrip"
        Me.LNandMNToolStrip.Visible = False
        '
        'Last_NameToolStripLabel5
        '
        Me.Last_NameToolStripLabel5.Name = "Last_NameToolStripLabel5"
        Me.Last_NameToolStripLabel5.Size = New System.Drawing.Size(84, 24)
        Me.Last_NameToolStripLabel5.Text = "Last_Name:"
        '
        'Last_NameToolStripTextBox5
        '
        Me.Last_NameToolStripTextBox5.Name = "Last_NameToolStripTextBox5"
        Me.Last_NameToolStripTextBox5.Size = New System.Drawing.Size(100, 27)
        '
        'Middle_NameToolStripLabel4
        '
        Me.Middle_NameToolStripLabel4.Name = "Middle_NameToolStripLabel4"
        Me.Middle_NameToolStripLabel4.Size = New System.Drawing.Size(105, 24)
        Me.Middle_NameToolStripLabel4.Text = "Middle_Name:"
        '
        'Middle_NameToolStripTextBox4
        '
        Me.Middle_NameToolStripTextBox4.Name = "Middle_NameToolStripTextBox4"
        Me.Middle_NameToolStripTextBox4.Size = New System.Drawing.Size(100, 27)
        '
        'LNandMNToolStripButton
        '
        Me.LNandMNToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.LNandMNToolStripButton.Name = "LNandMNToolStripButton"
        Me.LNandMNToolStripButton.Size = New System.Drawing.Size(80, 24)
        Me.LNandMNToolStripButton.Text = "LNandMN"
        '
        'FNandMNToolStrip
        '
        Me.FNandMNToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.First_NameToolStripLabel5, Me.First_NameToolStripTextBox5, Me.Middle_NameToolStripLabel5, Me.Middle_NameToolStripTextBox5, Me.FNandMNToolStripButton})
        Me.FNandMNToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FNandMNToolStrip.Name = "FNandMNToolStrip"
        Me.FNandMNToolStrip.Size = New System.Drawing.Size(1516, 27)
        Me.FNandMNToolStrip.TabIndex = 77
        Me.FNandMNToolStrip.Text = "FNandMNToolStrip"
        Me.FNandMNToolStrip.Visible = False
        '
        'First_NameToolStripLabel5
        '
        Me.First_NameToolStripLabel5.Name = "First_NameToolStripLabel5"
        Me.First_NameToolStripLabel5.Size = New System.Drawing.Size(85, 24)
        Me.First_NameToolStripLabel5.Text = "First_Name:"
        '
        'First_NameToolStripTextBox5
        '
        Me.First_NameToolStripTextBox5.Name = "First_NameToolStripTextBox5"
        Me.First_NameToolStripTextBox5.Size = New System.Drawing.Size(100, 27)
        '
        'Middle_NameToolStripLabel5
        '
        Me.Middle_NameToolStripLabel5.Name = "Middle_NameToolStripLabel5"
        Me.Middle_NameToolStripLabel5.Size = New System.Drawing.Size(105, 24)
        Me.Middle_NameToolStripLabel5.Text = "Middle_Name:"
        '
        'Middle_NameToolStripTextBox5
        '
        Me.Middle_NameToolStripTextBox5.Name = "Middle_NameToolStripTextBox5"
        Me.Middle_NameToolStripTextBox5.Size = New System.Drawing.Size(100, 27)
        '
        'FNandMNToolStripButton
        '
        Me.FNandMNToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FNandMNToolStripButton.Name = "FNandMNToolStripButton"
        Me.FNandMNToolStripButton.Size = New System.Drawing.Size(80, 24)
        Me.FNandMNToolStripButton.Text = "FNandMN"
        '
        'frmRbi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1516, 902)
        Me.Controls.Add(Me.LNandFNToolStrip)
        Me.Controls.Add(Me.LNandMNToolStrip)
        Me.Controls.Add(Me.FNandMNToolStrip)
        Me.Controls.Add(Me.TblCountersDataGridView)
        Me.Controls.Add(ForIDLabel)
        Me.Controls.Add(Me.ForIDTextBox)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TestToolStrip)
        Me.Controls.Add(Me.FNToolStrip)
        Me.Controls.Add(Me.LN_FNToolStrip)
        Me.Controls.Add(Me.LN_MNToolStrip)
        Me.Controls.Add(Me.FN_MNToolStrip)
        Me.Controls.Add(Me.ALLToolStrip)
        Me.Controls.Add(Me.MNToolStrip)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TblRbiBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRbi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Record of Barangay Inhabitants"
        CType(Me.TblRbiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblRbiBindingNavigator.ResumeLayout(False)
        Me.TblRbiBindingNavigator.PerformLayout()
        CType(Me.TblRbiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TestToolStrip.ResumeLayout(False)
        Me.TestToolStrip.PerformLayout()
        Me.FNToolStrip.ResumeLayout(False)
        Me.FNToolStrip.PerformLayout()
        Me.LN_FNToolStrip.ResumeLayout(False)
        Me.LN_FNToolStrip.PerformLayout()
        Me.LN_MNToolStrip.ResumeLayout(False)
        Me.LN_MNToolStrip.PerformLayout()
        Me.FN_MNToolStrip.ResumeLayout(False)
        Me.FN_MNToolStrip.PerformLayout()
        Me.ALLToolStrip.ResumeLayout(False)
        Me.ALLToolStrip.PerformLayout()
        Me.MNToolStrip.ResumeLayout(False)
        Me.MNToolStrip.PerformLayout()
        CType(Me.TblRbiDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.TblCountersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCountersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LNandFNToolStrip.ResumeLayout(False)
        Me.LNandFNToolStrip.PerformLayout()
        Me.LNandMNToolStrip.ResumeLayout(False)
        Me.LNandMNToolStrip.PerformLayout()
        Me.FNandMNToolStrip.ResumeLayout(False)
        Me.FNandMNToolStrip.PerformLayout()
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
    Friend WithEvents RBI_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhotoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Middle_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nick_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Birth_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Birth_PlaceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_of_ResidencyDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents tbLN As System.Windows.Forms.TextBox
    Friend WithEvents tbFN As System.Windows.Forms.TextBox
    Friend WithEvents tbMN As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SexComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PurokComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Status_of_ResidencyComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Civil_StatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents tbSearchFirstName As System.Windows.Forms.TextBox
    Friend WithEvents tbSearchMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents Last_NameToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Last_NameToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents TestToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents TestToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FNToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents First_NameToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents First_NameToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FNToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents LN_FNToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Last_NameToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Last_NameToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents First_NameToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents First_NameToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents LN_FNToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents LN_MNToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Last_NameToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Last_NameToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Middle_NameToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Middle_NameToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents LN_MNToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FN_MNToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Middle_NameToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Middle_NameToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents First_NameToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents First_NameToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FN_MNToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ALLToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Last_NameToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Last_NameToolStripTextBox3 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents First_NameToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents First_NameToolStripTextBox3 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Middle_NameToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Middle_NameToolStripTextBox3 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ALLToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents MNToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Middle_NameToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Middle_NameToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents MNToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ReligionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TblRbiDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTotalRbi As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnCancelEdit As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
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
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents TblCountersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblCountersTableAdapter As RecordBgySystem.DataSetTableAdapters.tblCountersTableAdapter
    Friend WithEvents ForIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TblCountersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LNandFNToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Last_NameToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Last_NameToolStripTextBox4 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents First_NameToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents First_NameToolStripTextBox4 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents LNandFNToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents LNandMNToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Last_NameToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Last_NameToolStripTextBox5 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Middle_NameToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Middle_NameToolStripTextBox4 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents LNandMNToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FNandMNToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents First_NameToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents First_NameToolStripTextBox5 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Middle_NameToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Middle_NameToolStripTextBox5 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FNandMNToolStripButton As System.Windows.Forms.ToolStripButton
End Class
