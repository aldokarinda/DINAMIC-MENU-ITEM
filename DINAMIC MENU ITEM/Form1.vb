Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContextMenuStrip1.Items.Add("Form A")
        ContextMenuStrip1.Items.Add("Form B")
    End Sub

    Private Sub ContextMenuStrip1_Click(sender As Object, e As EventArgs) Handles ContextMenuStrip1.Click

    End Sub

    Private Sub ContextMenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked
        If e.ClickedItem.ToString = "Form A" Then
            FormA.Show()
        ElseIf e.ClickedItem.ToString = "Form B" Then
            FormB.Show
        End If
    End Sub
End Class
