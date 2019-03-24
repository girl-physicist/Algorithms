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
        Me.ButtonSimpleAlgorithms = New System.Windows.Forms.Button()
        Me.ButtonZenoAlgorithm = New System.Windows.Forms.Button()
        Me.ButtonEuclideanAlgorithm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonSimpleAlgorithms
        '
        Me.ButtonSimpleAlgorithms.Location = New System.Drawing.Point(12, 72)
        Me.ButtonSimpleAlgorithms.Name = "ButtonSimpleAlgorithms"
        Me.ButtonSimpleAlgorithms.Size = New System.Drawing.Size(215, 23)
        Me.ButtonSimpleAlgorithms.TabIndex = 5
        Me.ButtonSimpleAlgorithms.Text = "SimpleAlgorithms"
        Me.ButtonSimpleAlgorithms.UseVisualStyleBackColor = True
        '
        'ButtonZenoAlgorithm
        '
        Me.ButtonZenoAlgorithm.Location = New System.Drawing.Point(12, 42)
        Me.ButtonZenoAlgorithm.Name = "ButtonZenoAlgorithm"
        Me.ButtonZenoAlgorithm.Size = New System.Drawing.Size(215, 23)
        Me.ButtonZenoAlgorithm.TabIndex = 4
        Me.ButtonZenoAlgorithm.Text = "ZenoAlgorithm"
        Me.ButtonZenoAlgorithm.UseVisualStyleBackColor = True
        '
        'ButtonEuclideanAlgorithm
        '
        Me.ButtonEuclideanAlgorithm.Location = New System.Drawing.Point(12, 12)
        Me.ButtonEuclideanAlgorithm.Name = "ButtonEuclideanAlgorithm"
        Me.ButtonEuclideanAlgorithm.Size = New System.Drawing.Size(215, 23)
        Me.ButtonEuclideanAlgorithm.TabIndex = 3
        Me.ButtonEuclideanAlgorithm.Text = "EuclideanAlgorithm"
        Me.ButtonEuclideanAlgorithm.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 109)
        Me.Controls.Add(Me.ButtonSimpleAlgorithms)
        Me.Controls.Add(Me.ButtonZenoAlgorithm)
        Me.Controls.Add(Me.ButtonEuclideanAlgorithm)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonSimpleAlgorithms As Button
    Friend WithEvents ButtonZenoAlgorithm As Button
    Friend WithEvents ButtonEuclideanAlgorithm As Button
End Class
