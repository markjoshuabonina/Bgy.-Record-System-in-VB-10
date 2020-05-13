<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSecretary
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
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Middle_NameLabel As System.Windows.Forms.Label
        Dim Date_ElectedLabel As System.Windows.Forms.Label
        Dim Bgy_CaptainLabel As System.Windows.Forms.Label
        Dim Full_nameLabel As System.Windows.Forms.Label
        Dim Secretary_IDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSecretary))
        Me.DataSet = New RecordBgySystem.DataSet()
        Me.TblSecretaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSecretaryTableAdapter = New RecordBgySystem.DataSetTableAdapters.tblSecretaryTableAdapter()
        Me.TableAdapterManager = New RecordBgySystem.DataSetTableAdapters.TableAdapterManager()
        Me.TblSecretaryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TblSecretaryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Middle_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Date_ElectedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Bgy_CaptainTextBox = New System.Windows.Forms.TextBox()
        Me.Full_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Secretary_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Last_NameLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Middle_NameLabel = New System.Windows.Forms.Label()
        Date_ElectedLabel = New System.Windows.Forms.Label()
        Bgy_CaptainLabel = New System.Windows.Forms.Label()
        Full_nameLabel = New System.Windows.Forms.Label()
        Secretary_IDLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSecretaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSecretaryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblSecretaryBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(20, 60)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(95, 23)
        Last_NameLabel.TabIndex = 2
        Last_NameLabel.Text = "Last Name:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(19, 94)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(96, 23)
        First_NameLabel.TabIndex = 4
        First_NameLabel.Text = "First Name:"
        '
        'Middle_NameLabel
        '
        Middle_NameLabel.AutoSize = True
        Middle_NameLabel.Location = New System.Drawing.Point(-4, 129)
        Middle_NameLabel.Name = "Middle_NameLabel"
        Middle_NameLabel.Size = New System.Drawing.Size(117, 23)
        Middle_NameLabel.TabIndex = 6
        Middle_NameLabel.Text = "Middle Name:"
        '
        'Date_ElectedLabel
        '
        Date_ElectedLabel.AutoSize = True
        Date_ElectedLabel.Location = New System.Drawing.Point(4, 200)
        Date_ElectedLabel.Name = "Date_ElectedLabel"
        Date_ElectedLabel.Size = New System.Drawing.Size(110, 23)
        Date_ElectedLabel.TabIndex = 8
        Date_ElectedLabel.Text = "Date Elected:"
        '
        'Bgy_CaptainLabel
        '
        Bgy_CaptainLabel.AutoSize = True
        Bgy_CaptainLabel.Location = New System.Drawing.Point(8, 237)
        Bgy_CaptainLabel.Name = "Bgy_CaptainLabel"
        Bgy_CaptainLabel.Size = New System.Drawing.Size(106, 23)
        Bgy_CaptainLabel.TabIndex = 10
        Bgy_CaptainLabel.Text = "Bgy Captain:"
        '
        'Full_nameLabel
        '
        Full_nameLabel.AutoSize = True
        Full_nameLabel.Location = New System.Drawing.Point(28, 166)
        Full_nameLabel.Name = "Full_nameLabel"
        Full_nameLabel.Size = New System.Drawing.Size(88, 23)
        Full_nameLabel.TabIndex = 12
        Full_nameLabel.Text = "Full name:"
        '
        'Secretary_IDLabel
        '
        Secretary_IDLabel.AutoSize = True
        Secretary_IDLabel.Location = New System.Drawing.Point(9, 26)
        Secretary_IDLabel.Name = "Secretary_IDLabel"
        Secretary_IDLabel.Size = New System.Drawing.Size(106, 23)
        Secretary_IDLabel.TabIndex = 17
        Secretary_IDLabel.Text = "Secretary ID:"
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblCertificatesTableAdapter = Nothing
        Me.TableAdapterManager.tblClearanceTableAdapter = Nothing
        Me.TableAdapterManager.tblCountersTableAdapter = Nothing
        Me.TableAdapterManager.tblRbiTableAdapter = Nothing
        Me.TableAdapterManager.tblResolutionTableAdapter = Nothing
        Me.TableAdapterManager.tblSecretaryTableAdapter = Me.TblSecretaryTableAdapter
        Me.TableAdapterManager.UpdateOrder = RecordBgySystem.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblSecretaryBindingNavigator
        '
        Me.TblSecretaryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblSecretaryBindingNavigator.BindingSource = Me.TblSecretaryBindingSource
        Me.TblSecretaryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblSecretaryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblSecretaryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblSecretaryBindingNavigatorSaveItem})
        Me.TblSecretaryBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblSecretaryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblSecretaryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblSecretaryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblSecretaryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblSecretaryBindingNavigator.Name = "TblSecretaryBindingNavigator"
        Me.TblSecretaryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblSecretaryBindingNavigator.Size = New System.Drawing.Size(664, 31)
        Me.TblSecretaryBindingNavigator.TabIndex = 0
        Me.TblSecretaryBindingNavigator.Text = "BindingNavigator1"
        Me.TblSecretaryBindingNavigator.Visible = False
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
        'TblSecretaryBindingNavigatorSaveItem
        '
        Me.TblSecretaryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblSecretaryBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblSecretaryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblSecretaryBindingNavigatorSaveItem.Name = "TblSecretaryBindingNavigatorSaveItem"
        Me.TblSecretaryBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 28)
        Me.TblSecretaryBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSecretaryBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(148, 59)
        Me.Last_NameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(352, 29)
        Me.Last_NameTextBox.TabIndex = 3
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSecretaryBindingSource, "First Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(148, 94)
        Me.First_NameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(352, 29)
        Me.First_NameTextBox.TabIndex = 5
        '
        'Middle_NameTextBox
        '
        Me.Middle_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSecretaryBindingSource, "Middle Name", True))
        Me.Middle_NameTextBox.Location = New System.Drawing.Point(148, 129)
        Me.Middle_NameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Middle_NameTextBox.Name = "Middle_NameTextBox"
        Me.Middle_NameTextBox.Size = New System.Drawing.Size(352, 29)
        Me.Middle_NameTextBox.TabIndex = 7
        '
        'Date_ElectedDateTimePicker
        '
        Me.Date_ElectedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblSecretaryBindingSource, "Date Elected", True))
        Me.Date_ElectedDateTimePicker.Location = New System.Drawing.Point(148, 201)
        Me.Date_ElectedDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Date_ElectedDateTimePicker.Name = "Date_ElectedDateTimePicker"
        Me.Date_ElectedDateTimePicker.Size = New System.Drawing.Size(352, 29)
        Me.Date_ElectedDateTimePicker.TabIndex = 9
        '
        'Bgy_CaptainTextBox
        '
        Me.Bgy_CaptainTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSecretaryBindingSource, "Bgy Captain", True))
        Me.Bgy_CaptainTextBox.Location = New System.Drawing.Point(148, 236)
        Me.Bgy_CaptainTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Bgy_CaptainTextBox.Name = "Bgy_CaptainTextBox"
        Me.Bgy_CaptainTextBox.Size = New System.Drawing.Size(352, 29)
        Me.Bgy_CaptainTextBox.TabIndex = 11
        '
        'Full_nameTextBox
        '
        Me.Full_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSecretaryBindingSource, "Full name", True))
        Me.Full_nameTextBox.Location = New System.Drawing.Point(148, 165)
        Me.Full_nameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Full_nameTextBox.Name = "Full_nameTextBox"
        Me.Full_nameTextBox.Size = New System.Drawing.Size(352, 29)
        Me.Full_nameTextBox.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(285, 427)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 32)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(187, 287)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 32)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Change"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(281, 287)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 32)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Secretary_IDTextBox
        '
        Me.Secretary_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSecretaryBindingSource, "Secretary ID", True))
        Me.Secretary_IDTextBox.Location = New System.Drawing.Point(148, 25)
        Me.Secretary_IDTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Secretary_IDTextBox.Name = "Secretary_IDTextBox"
        Me.Secretary_IDTextBox.Size = New System.Drawing.Size(352, 29)
        Me.Secretary_IDTextBox.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(219, 22)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(216, 42)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Signatories"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Secretary_IDLabel)
        Me.GroupBox1.Controls.Add(Me.Secretary_IDTextBox)
        Me.GroupBox1.Controls.Add(Full_nameLabel)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Full_nameTextBox)
        Me.GroupBox1.Controls.Add(Bgy_CaptainLabel)
        Me.GroupBox1.Controls.Add(Me.Bgy_CaptainTextBox)
        Me.GroupBox1.Controls.Add(Date_ElectedLabel)
        Me.GroupBox1.Controls.Add(Me.Date_ElectedDateTimePicker)
        Me.GroupBox1.Controls.Add(Middle_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Middle_NameTextBox)
        Me.GroupBox1.Controls.Add(First_NameLabel)
        Me.GroupBox1.Controls.Add(Me.First_NameTextBox)
        Me.GroupBox1.Controls.Add(Last_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Last_NameTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(63, 70)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(541, 351)
        Me.GroupBox1.TabIndex = 98
        Me.GroupBox1.TabStop = False
        '
        'frmSecretary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 485)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TblSecretaryBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSecretary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Signatories"
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSecretaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSecretaryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblSecretaryBindingNavigator.ResumeLayout(False)
        Me.TblSecretaryBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSet As RecordBgySystem.DataSet
    Friend WithEvents TblSecretaryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblSecretaryTableAdapter As RecordBgySystem.DataSetTableAdapters.tblSecretaryTableAdapter
    Friend WithEvents TableAdapterManager As RecordBgySystem.DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblSecretaryBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblSecretaryBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Middle_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_ElectedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Bgy_CaptainTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Full_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Secretary_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
