
Public Class frmVentas
    Dim n As Integer
    Dim precio As Double
    Dim cantidad As Double
    Private Sub btdBuscar_Click(sender As Object, e As EventArgs) Handles btdBuscar.Click
        frmDetalleVentas.Show()
    End Sub
    Private Sub btnBuscar2_Click(sender As Object, e As EventArgs) Handles btnBuscar2.Click
        frmDetalleVentas.Show()
    End Sub

    Private Sub btdEliminar_Click(sender As Object, e As EventArgs) Handles btdEliminar.Click
        Try
            n = dgvResultado.CurrentRow.Index
        Catch ex As Exception
            n = 0
        End Try
        If dgvResultado.Rows.Count <> 0 Then
            dgvResultado.Rows.RemoveAt(n)
        End If
    End Sub
    Public Sub ColorTabla(ByVal dgv As DataGridView)
        Try
            With dgv
                .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                .AlternatingRowsDefaultCellStyle.BackColor = Color.White
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            End With
        Catch ex As Exception

        End Try
    End Sub
    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorTabla(dgvResultado)
        dgvResultado.Columns(8).Visible = False
        dgvResultado.Columns(7).Visible = False
    End Sub
    Private Sub dgvResultado_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvResultado.RowsAdded
        If dgvResultado.Rows.Count <> 0 Then
            Dim total As Double
            Dim row As DataGridViewRow = CType(dgvResultado.Rows(e.RowIndex), DataGridViewRow)
            Try
                precio = row.Cells("Precio_U").Value
                cantidad = row.Cells("Cant").Value
                row.Cells("total").Value = precio * cantidad
            Catch ex As Exception
            End Try
            Try
                For i As Integer = 0 To dgvResultado.Rows.Count - 1
                    total = total + CDbl(dgvResultado.Item("total".ToLower, i).Value)
                Next
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

            lblTotal.Text = Format(total, "S/ #,##0.00")
        Else
            lblTotal.Text = "S/ 0.00"
        End If
    End Sub

    Private Sub dgvResultado_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResultado.CellValueChanged
        If dgvResultado.Rows.Count <> 0 Then
            Dim row As DataGridViewRow = CType(dgvResultado.Rows(e.RowIndex), DataGridViewRow)
            Dim total As Double
            Try
                precio = row.Cells("Precio_U").Value
                cantidad = row.Cells("Cant").Value
                row.Cells("total").Value = precio * cantidad
            Catch ex As Exception
            End Try
            Try
                For i As Integer = 0 To dgvResultado.Rows.Count - 1
                    total = total + CDbl(dgvResultado.Item("total".ToLower, i).Value)
                Next
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
            lblTotal.Text = Format(total, "S/ #,##0.00")
        End If
    End Sub

    Private Sub dgvResultado_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvResultado.RowsRemoved
        Dim total As Double
        If dgvResultado.Rows.Count <> 0 Then
            Try
                For i As Integer = 0 To dgvResultado.Rows.Count - 1
                    total = total + CDbl(dgvResultado.Item("total".ToLower, i).Value)
                Next
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
            lblTotal.Text = Format(total, "S/ #,##0.00")
        Else
            lblTotal.Text = "S/ 0.00"
            PictureBox1.Image = Nothing
        End If
    End Sub

    Private Sub dgvResultado_SelectionChanged(sender As Object, e As EventArgs) Handles dgvResultado.SelectionChanged
        Try
            n = dgvResultado.CurrentRow.Index
        Catch ex As Exception
            n = 0
        End Try
        If dgvResultado.Rows.Count > 0 Then
            PictureBox1.Image = dgvResultado.CurrentRow.Cells(7).Value
        End If
    End Sub

    Private Sub txtCliente_Click(sender As Object, e As EventArgs) Handles txtCliente.Click
        frmDetalleClientes.Show()
    End Sub
End Class