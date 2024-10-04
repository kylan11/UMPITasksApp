<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TaskForm
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
        Me.TextBoxTaskName = New System.Windows.Forms.TextBox()
        Me.DateTimePickerDueDate = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxPriority = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxTaskName
        '
        Me.TextBoxTaskName.Location = New System.Drawing.Point(12, 12)
        Me.TextBoxTaskName.Name = "TextBoxTaskName"
        Me.TextBoxTaskName.Size = New System.Drawing.Size(260, 20)
        Me.TextBoxTaskName.TabIndex = 0
        '
        'DateTimePickerDueDate
        '
        Me.DateTimePickerDueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerDueDate.Location = New System.Drawing.Point(12, 38)
        Me.DateTimePickerDueDate.Name = "DateTimePickerDueDate"
        Me.DateTimePickerDueDate.Size = New System.Drawing.Size(260, 20)
        Me.DateTimePickerDueDate.TabIndex = 1
        '
        'ComboBoxPriority
        '
        Me.ComboBoxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPriority.FormattingEnabled = True
        Me.ComboBoxPriority.Location = New System.Drawing.Point(12, 64)
        Me.ComboBoxPriority.Name = "ComboBoxPriority"
        Me.ComboBoxPriority.Size = New System.Drawing.Size(260, 21)
        Me.ComboBoxPriority.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(197, 91)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'TaskForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 126)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.ComboBoxPriority)
        Me.Controls.Add(Me.DateTimePickerDueDate)
        Me.Controls.Add(Me.TextBoxTaskName)
        Me.Name = "TaskForm"
        Me.Text = "TaskForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxTaskName As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePickerDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBoxPriority As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
