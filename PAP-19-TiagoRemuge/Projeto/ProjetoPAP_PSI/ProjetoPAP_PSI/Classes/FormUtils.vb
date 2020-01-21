Public Class FormUtils
    Public Shared Sub formatDataGrid(dgv As DataGridView)
        Dim i As Integer = 0
        For Each r In dgv.Rows
            If i Mod 2 = 0 Then
                r.DefaultCellStyle.BackColor = Color.LightBlue
            Else
                r.DefaultCellStyle.BackColor = Color.LightGray
            End If
            i = i + 1
        Next
    End Sub

    Public Shared Sub form_center(f1 As System.Windows.Forms.Form)

        Dim x As Integer
        Dim y As Integer
        Dim r As Rectangle

        If Not f1.Parent Is Nothing Then
            r = f1.Parent.ClientRectangle
            x = r.Width - f1.Width + f1.Parent.Left
            y = r.Height - f1.Height + f1.Parent.Top
        Else
            r = Screen.PrimaryScreen.WorkingArea
            x = r.Width - f1.Width
            y = r.Height - f1.Height
        End If

        x = CInt(x / 2)
        y = CInt(y / 2)

        f1.StartPosition = FormStartPosition.Manual
        f1.Location = New Point(x, y)
    End Sub

    Public Shared Sub form_Resize(fe As Form)
        fe.Size = New System.Drawing.Size(1024, 768)
    End Sub

    Public Shared Sub FormatForm(f As Form)
        f.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    End Sub

End Class
