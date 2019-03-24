<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimpleAlgorithmsForm
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
        Me.ButtonMin = New System.Windows.Forms.Button()
        Me.ButtonMax = New System.Windows.Forms.Button()
        Me.ButtonSortDescending = New System.Windows.Forms.Button()
        Me.ButtonSortAscending = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonInit = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonMin
        '
        Me.ButtonMin.Location = New System.Drawing.Point(137, 12)
        Me.ButtonMin.Name = "ButtonMin"
        Me.ButtonMin.Size = New System.Drawing.Size(111, 43)
        Me.ButtonMin.TabIndex = 0
        Me.ButtonMin.Text = "Finding the minimum value"
        Me.ButtonMin.UseVisualStyleBackColor = True
        '
        'ButtonMax
        '
        Me.ButtonMax.Location = New System.Drawing.Point(254, 12)
        Me.ButtonMax.Name = "ButtonMax"
        Me.ButtonMax.Size = New System.Drawing.Size(111, 43)
        Me.ButtonMax.TabIndex = 1
        Me.ButtonMax.Text = "Finding the maximum value"
        Me.ButtonMax.UseVisualStyleBackColor = True
        '
        'ButtonSortDescending
        '
        Me.ButtonSortDescending.Location = New System.Drawing.Point(371, 13)
        Me.ButtonSortDescending.Name = "ButtonSortDescending"
        Me.ButtonSortDescending.Size = New System.Drawing.Size(111, 43)
        Me.ButtonSortDescending.TabIndex = 2
        Me.ButtonSortDescending.Text = "Sort descending"
        Me.ButtonSortDescending.UseVisualStyleBackColor = True
        '
        'ButtonSortAscending
        '
        Me.ButtonSortAscending.Location = New System.Drawing.Point(488, 12)
        Me.ButtonSortAscending.Name = "ButtonSortAscending"
        Me.ButtonSortAscending.Size = New System.Drawing.Size(111, 43)
        Me.ButtonSortAscending.TabIndex = 3
        Me.ButtonSortAscending.Text = "Sort Ascending"
        Me.ButtonSortAscending.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 62)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(587, 376)
        Me.DataGridView1.TabIndex = 4
        '
        'ButtonInit
        '
        Me.ButtonInit.Location = New System.Drawing.Point(12, 13)
        Me.ButtonInit.Name = "ButtonInit"
        Me.ButtonInit.Size = New System.Drawing.Size(119, 42)
        Me.ButtonInit.TabIndex = 5
        Me.ButtonInit.Text = "Init"
        Me.ButtonInit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.ButtonInit.UseVisualStyleBackColor = True
        '
        'SimpleAlgorithmsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 450)
        Me.Controls.Add(Me.ButtonInit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonSortAscending)
        Me.Controls.Add(Me.ButtonSortDescending)
        Me.Controls.Add(Me.ButtonMax)
        Me.Controls.Add(Me.ButtonMin)
        Me.Name = "SimpleAlgorithmsForm"
        Me.Text = "SimpleAlgorithmsForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonMin As Button
    Friend WithEvents ButtonMax As Button
    Friend WithEvents ButtonSortDescending As Button
    Friend WithEvents ButtonSortAscending As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonInit As Button
End Class
