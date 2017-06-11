Public Class help

    Private Sub LinkLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinkLabel1.Click
        Try
            System.Diagnostics.Process.Start("https://github.com/lunaevans/cryptr")
        Catch
            'Code to handle the error.
        End Try
    End Sub
End Class