Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set ListView properties
        ListView1.View = View.Details
        ListView1.Columns.Add("Task", 200)
        ListView1.Columns.Add("Due Date", 150)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim task As String = InputBox("Enter new task:", "Add Task")
        If String.IsNullOrWhiteSpace(task) Then Exit Sub

        Dim dueDateString As String = InputBox("Enter due date (MM/dd/yyyy):", "Add Due Date")
        Dim dueDate As Date
        If Not Date.TryParse(dueDateString, dueDate) Then
            MessageBox.Show("Invalid date format. Please enter date in MM/dd/yyyy format.", "Invalid Date")
            Exit Sub
        End If

        Dim item As New ListViewItem(task)
        item.SubItems.Add(dueDate.ToShortDateString())
        ListView1.Items.Add(item)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If ListView1.SelectedItems.Count > 0 Then
            ListView1.Items.Remove(ListView1.SelectedItems(0))
        Else
            MessageBox.Show("Please select a task to remove.", "Remove Task")
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            Dim task As String = selectedItem.Text
            Dim dueDateString As String = selectedItem.SubItems(1).Text

            Dim newTask As String = InputBox("Edit task:", "Edit Task", task)
            If String.IsNullOrWhiteSpace(newTask) Then Exit Sub

            Dim newDueDateString As String = InputBox("Edit due date (MM/dd/yyyy):", "Edit Due Date", dueDateString)
            Dim newDueDate As Date
            If Not Date.TryParse(newDueDateString, newDueDate) Then
                MessageBox.Show("Invalid date format. Please enter date in MM/dd/yyyy format.", "Invalid Date")
                Exit Sub
            End If

            selectedItem.Text = newTask
            selectedItem.SubItems(1).Text = newDueDate.ToShortDateString()
        Else
            MessageBox.Show("Please select a task to edit.", "Edit Task")
        End If
    End Sub
End Class
