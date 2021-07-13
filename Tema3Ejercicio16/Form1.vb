Public Class Form1

    Dim rows, columns As Integer
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub

    Private Sub CreateMatrix(dataGridView As DataGridView)
        dataGridView.RowCount = rows
        dataGridView.ColumnCount = columns
        dataGridView.RowHeadersWidth = 70

        For i = 0 To columns - 1
            dataGridView.Columns(i).HeaderText = i + 1
            dataGridView.Columns(i).Width = 40
        Next

        For j = 0 To rows - 1
            dataGridView.Rows(j).HeaderCell.Value = (j + 1).ToString
        Next
    End Sub

    Private Sub Plus()

        If DataGridView1.RowCount = 0 Then
            MessageBox.Show("Debe crear las matrices primero, asgignado el número de filas y columnas", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            Dim result As Integer

            For i = 0 To columns - 1
                For j = 0 To rows - 1
                    result = Val(DataGridView1.Rows(j).Cells(i).Value) + Val(DataGridView2.Rows(j).Cells(i).Value)
                    DataGridView3.Rows(j).Cells(i).Value = result
                Next
            Next
        End If
    End Sub


    Private Sub ButtonPlus_Click(sender As Object, e As EventArgs) Handles ButtonPlus.Click
        Plus()
    End Sub

    Private Sub ButtonCreate_Click(sender As Object, e As EventArgs) Handles ButtonCreate.Click
        rows = Val(TextBoxRows.Text)
        columns = Val(TextBoxColumns.Text)

        CreateMatrix(DataGridView1)
        CreateMatrix(DataGridView2)
        CreateMatrix(DataGridView3)

    End Sub
End Class
