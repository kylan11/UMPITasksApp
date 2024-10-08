﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set ListView properties
        ListView1.View = View.Details
        ListView1.CheckBoxes = True

        ' Check if columns are already added
        If ListView1.Columns.Count = 0 Then
            ListView1.Columns.Add("Task", 200)
            ListView1.Columns.Add("Due Date", 150)
            ListView1.Columns.Add("Priority", 100)
        End If

        LoadTasks()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Using taskForm As New TaskForm()
            If taskForm.ShowDialog() = DialogResult.OK Then
                Dim item As New ListViewItem(taskForm.TaskName)
                item.SubItems.Add(taskForm.DueDate.ToShortDateString())
                item.SubItems.Add(taskForm.Priority)
                ListView1.Items.Add(item)
                SaveTasks()
            End If
        End Using
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If ListView1.CheckedItems.Count = 1 Then
            Dim selectedItem As ListViewItem = ListView1.CheckedItems(0)
            Using taskForm As New TaskForm()
                taskForm.TaskName = selectedItem.Text
                taskForm.DueDate = Date.Parse(selectedItem.SubItems(1).Text)
                taskForm.Priority = selectedItem.SubItems(2).Text

                If taskForm.ShowDialog() = DialogResult.OK Then
                    selectedItem.Text = taskForm.TaskName
                    selectedItem.SubItems(1).Text = taskForm.DueDate.ToShortDateString()
                    selectedItem.SubItems(2).Text = taskForm.Priority
                    selectedItem.Checked = False
                    SaveTasks()
                End If
            End Using
        ElseIf ListView1.CheckedItems.Count = 0 Then
            MessageBox.Show("Please select one task to edit.", "Edit Task")
        Else
            MessageBox.Show("Please select only one task to edit.", "Edit Task")
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim checkedItems = ListView1.CheckedItems
        If checkedItems.Count > 0 Then
            For Each item As ListViewItem In checkedItems
                ListView1.Items.Remove(item)
            Next
            SaveTasks()
        Else
            MessageBox.Show("Please select at least one task to remove.", "Remove Task")
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchTerm As String = InputBox("Enter task to search for:", "Search Task")
        If String.IsNullOrWhiteSpace(searchTerm) Then Exit Sub

        For Each item As ListViewItem In ListView1.Items
            If item.Text.ToLower().Contains(searchTerm.ToLower()) Then
                item.BackColor = Color.Yellow
            Else
                item.BackColor = Color.White
            End If
        Next
    End Sub

    Private Sub btnSortByName_Click(sender As Object, e As EventArgs) Handles btnSortByName.Click
        ListView1.ListViewItemSorter = New ListViewItemComparer(0)
    End Sub

    Private Sub btnSortByDate_Click(sender As Object, e As EventArgs) Handles btnSortByDate.Click
        ListView1.ListViewItemSorter = New ListViewItemComparer(1)
    End Sub

    Private Sub btnMarkCompleted_Click(sender As Object, e As EventArgs) Handles btnMarkCompleted.Click
        For Each item As ListViewItem In ListView1.CheckedItems
            item.Font = New Font(item.Font, FontStyle.Strikeout)
            item.Checked = False
        Next
        SaveTasks()
    End Sub

    Private Sub SaveTasks()
        Dim tasks As New List(Of String)
        For Each item As ListViewItem In ListView1.Items
            tasks.Add($"{item.Text}|{item.SubItems(1).Text}|{item.SubItems(2).Text}|{item.Font.Style}")
        Next
        System.IO.File.WriteAllLines("tasks.txt", tasks)
    End Sub

    Private Sub LoadTasks()
        If System.IO.File.Exists("tasks.txt") Then
            Dim tasks As String() = System.IO.File.ReadAllLines("tasks.txt")
            For Each task As String In tasks
                Dim parts As String() = task.Split("|"c)
                Dim item As New ListViewItem(parts(0))
                item.SubItems.Add(parts(1))
                item.SubItems.Add(parts(2))
                If parts.Length > 3 AndAlso parts(3) = FontStyle.Strikeout.ToString() Then
                    item.Font = New Font(item.Font, FontStyle.Strikeout)
                End If
                ListView1.Items.Add(item)
            Next
        End If
    End Sub
End Class

Public Class ListViewItemComparer
    Implements IComparer

    Private col As Integer

    Public Sub New(column As Integer)
        col = column
    End Sub

    Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
        Return String.Compare(CType(x, ListViewItem).SubItems(col).Text, CType(y, ListViewItem).SubItems(col).Text)
    End Function
End Class
