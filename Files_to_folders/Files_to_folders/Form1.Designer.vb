<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me._path = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me._by_data = New System.Windows.Forms.CheckBox()
        Me._by_type = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me._exception = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me._Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._CreationTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._LastAccessTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._LastWriteTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me._folders = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        '_path
        '
        Me._path.Location = New System.Drawing.Point(12, 12)
        Me._path.Name = "_path"
        Me._path.Size = New System.Drawing.Size(360, 20)
        Me._path.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(378, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Chose folder"
        Me.Button1.UseVisualStyleBackColor = True
        '
        '_by_data
        '
        Me._by_data.AutoSize = True
        Me._by_data.Checked = True
        Me._by_data.CheckState = System.Windows.Forms.CheckState.Checked
        Me._by_data.Location = New System.Drawing.Point(12, 62)
        Me._by_data.Name = "_by_data"
        Me._by_data.Size = New System.Drawing.Size(129, 17)
        Me._by_data.TabIndex = 2
        Me._by_data.Text = "create folders for date"
        Me._by_data.UseVisualStyleBackColor = True
        '
        '_by_type
        '
        Me._by_type.AutoSize = True
        Me._by_type.Checked = True
        Me._by_type.CheckState = System.Windows.Forms.CheckState.Checked
        Me._by_type.Location = New System.Drawing.Point(11, 85)
        Me._by_type.Name = "_by_type"
        Me._by_type.Size = New System.Drawing.Size(149, 17)
        Me._by_type.TabIndex = 3
        Me._by_type.Text = "create folders for file types"
        Me._by_type.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(378, 74)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Go ahead!"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(103, 17)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.Text = "LastAccessTime"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Checked = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 64)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(93, 17)
        Me.RadioButton3.TabIndex = 6
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "LastWriteTime"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Location = New System.Drawing.Point(160, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(113, 99)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chose date from"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(87, 17)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.Text = "CreationTime"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        '_exception
        '
        Me._exception.Location = New System.Drawing.Point(87, 143)
        Me._exception.Name = "_exception"
        Me._exception.Size = New System.Drawing.Size(375, 20)
        Me._exception.TabIndex = 9
        Me._exception.Text = "*.ini;*.db;*.thm"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Exceptions"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me._Name, Me._CreationTime, Me._LastAccessTime, Me._LastWriteTime})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 178)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(450, 374)
        Me.DataGridView1.TabIndex = 11
        '
        '_Name
        '
        Me._Name.HeaderText = "Name"
        Me._Name.Name = "_Name"
        Me._Name.ReadOnly = True
        '
        '_CreationTime
        '
        Me._CreationTime.HeaderText = "Creation"
        Me._CreationTime.Name = "_CreationTime"
        Me._CreationTime.ReadOnly = True
        '
        '_LastAccessTime
        '
        Me._LastAccessTime.HeaderText = "LastAccessTime"
        Me._LastAccessTime.Name = "_LastAccessTime"
        Me._LastAccessTime.ReadOnly = True
        '
        '_LastWriteTime
        '
        Me._LastWriteTime.HeaderText = "LastWriteTime"
        Me._LastWriteTime.Name = "_LastWriteTime"
        Me._LastWriteTime.ReadOnly = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(378, 40)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "View list"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton6)
        Me.GroupBox2.Controls.Add(Me.RadioButton5)
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Location = New System.Drawing.Point(279, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(93, 98)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Date format"
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(7, 69)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(60, 17)
        Me.RadioButton6.TabIndex = 2
        Me.RadioButton6.Text = "YY.MM"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(7, 46)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(79, 17)
        Me.RadioButton5.TabIndex = 1
        Me.RadioButton5.Text = "DD.MM.YY"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Checked = True
        Me.RadioButton4.Location = New System.Drawing.Point(7, 22)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(79, 17)
        Me.RadioButton4.TabIndex = 0
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "YY.MM.DD"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        '_folders
        '
        Me._folders.AutoSize = True
        Me._folders.Checked = True
        Me._folders.CheckState = System.Windows.Forms.CheckState.Checked
        Me._folders.Location = New System.Drawing.Point(12, 39)
        Me._folders.Name = "_folders"
        Me._folders.Size = New System.Drawing.Size(120, 17)
        Me._folders.TabIndex = 14
        Me._folders.Text = "search in subfolders"
        Me._folders.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 564)
        Me.Controls.Add(Me._folders)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me._exception)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me._by_type)
        Me.Controls.Add(Me._by_data)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me._path)
        Me.Name = "Form1"
        Me.Text = "File to Folders"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents _path As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents _by_data As System.Windows.Forms.CheckBox
    Friend WithEvents _by_type As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DirectorySearcher1 As System.DirectoryServices.DirectorySearcher
    Friend WithEvents _exception As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog2 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents _Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents _CreationTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents _LastAccessTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents _LastWriteTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents _folders As System.Windows.Forms.CheckBox

End Class
