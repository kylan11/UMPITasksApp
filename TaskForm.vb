Public Class TaskForm
    Public Property TaskName As String
    Public Property DueDate As Date
    Public Property Priority As String

    Private Sub TaskForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize ComboBox items
        ComboBoxPriority.Items.AddRange(New String() {"Low", "Medium", "High"})
        ComboBoxPriority.SelectedIndex = 0

        ' Set initial values if editing an existing task
        TextBoxTaskName.Text = TaskName

        ' Ensure DueDate is within the valid range
        If DueDate < DateTimePickerDueDate.MinDate OrElse DueDate > DateTimePickerDueDate.MaxDate Then
            DateTimePickerDueDate.Value = DateTime.Now
        Else
            DateTimePickerDueDate.Value = DueDate
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validate input
        If String.IsNullOrWhiteSpace(TextBoxTaskName.Text) Then
            MessageBox.Show("Task name cannot be empty.", "Validation Error")
            Return
        End If

        ' Set properties
        TaskName = TextBoxTaskName.Text
        DueDate = DateTimePickerDueDate.Value
        Priority = ComboBoxPriority.SelectedItem.ToString()

        ' Close form with OK result
        DialogResult = DialogResult.OK
        Close()
    End Sub
End Class
