

Partial Public Class Gestão_do_Stock_e_Faturação_de_um_CaféDataSet
    Partial Class FaturaDataTableDataTable

        Private Sub FaturaDataTableDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.EstadoColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
