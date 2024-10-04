<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    ' Form overrides dispose to clean up component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    ' Required by the Windows Form Designer.
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer.
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.columnHeaderTask = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeaderDueDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeaderTask, Me.columnHeaderDueDate})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(360, 200)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'columnHeaderTask
        '
        Me.columnHeaderTask.Text = "Task"
        Me.columnHeaderTask.Width = 200
        '
        'columnHeaderDueDate
        '
        Me.columnHeaderDueDate.Text = "Due Date"
        Me.columnHeaderDueDate.Width = 150
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 218)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(110, 31)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add Task"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(262, 218)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(110, 31)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "Remove Task"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(137, 218)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(110, 31)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Edit Task"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 261)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Form1"
        Me.Text = "UMPI Tasks App"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents columnHeaderTask As System.Windows.Forms.ColumnHeader
    Friend WithEvents columnHeaderDueDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
End Class
