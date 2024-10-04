<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnSortByName = New System.Windows.Forms.Button()
        Me.btnSortByDate = New System.Windows.Forms.Button()
        Me.btnMarkCompleted = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Location = New System.Drawing.Point(12, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(776, 350)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 368)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(93, 368)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(174, 368)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(255, 368)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnSortByName
        '
        Me.btnSortByName.Location = New System.Drawing.Point(336, 368)
        Me.btnSortByName.Name = "btnSortByName"
        Me.btnSortByName.Size = New System.Drawing.Size(75, 23)
        Me.btnSortByName.TabIndex = 5
        Me.btnSortByName.Text = "Sort by Name"
        Me.btnSortByName.UseVisualStyleBackColor = True
        '
        'btnSortByDate
        '
        Me.btnSortByDate.Location = New System.Drawing.Point(417, 368)
        Me.btnSortByDate.Name = "btnSortByDate"
        Me.btnSortByDate.Size = New System.Drawing.Size(75, 23)
        Me.btnSortByDate.TabIndex = 6
        Me.btnSortByDate.Text = "Sort by Date"
        Me.btnSortByDate.UseVisualStyleBackColor = True
        '
        'btnMarkCompleted
        '
        Me.btnMarkCompleted.Location = New System.Drawing.Point(498, 368)
        Me.btnMarkCompleted.Name = "btnMarkCompleted"
        Me.btnMarkCompleted.Size = New System.Drawing.Size(100, 23)
        Me.btnMarkCompleted.TabIndex = 7
        Me.btnMarkCompleted.Text = "Mark Completed"
        Me.btnMarkCompleted.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnMarkCompleted)
        Me.Controls.Add(Me.btnSortByDate)
        Me.Controls.Add(Me.btnSortByName)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Form1"
        Me.Text = "UMPI Tasks App"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnSortByName As System.Windows.Forms.Button
    Friend WithEvents btnSortByDate As System.Windows.Forms.Button
    Friend WithEvents btnMarkCompleted As System.Windows.Forms.Button
End Class
