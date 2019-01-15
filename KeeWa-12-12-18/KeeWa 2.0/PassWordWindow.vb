Public Class PassWordWindow
    Dim IdentificationOK As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TB_MDP.Text = My.Settings.PassWord And TB_User.Text = My.Settings.Login Then
            IdentificationOK = True
            Main.Enabled = True
            Me.Visible = False
        Else
            LB_Error.Visible = True
        End If
    End Sub

    Private Sub PassWordWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Closing
        If Not IdentificationOK Then
            Main.Close()
        End If
    End Sub

    Private Sub PassWordWindow_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.Show()
        Main.Enabled = False
    End Sub
End Class