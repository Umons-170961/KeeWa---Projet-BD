Public Class Paramètres
    Private Sub Paramètres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TB_Login.Text = My.Settings.Login
        CB_Langue.SelectedText = My.Settings.Langue.ToString
    End Sub

    Private Sub BT_Sauv_Click(sender As Object, e As EventArgs) Handles BT_Sauv.Click
        My.Settings.Login = TB_Login.Text
        My.Settings.Langue = CB_Langue.SelectedText
        My.Settings.Save()

        If TB_OldPW.Text = "" And TB_NewPW.Text = "" Then
            Me.Close()
        ElseIf My.Settings.PassWord = TB_OldPW.Text Then
            If TB_NewPW.Text.Length < 9 Then
                Dim result As DialogResult = MessageBox.Show("Le mot de passe contient moins de 8 caractères. Voulez vous enregistrer?", "Mot de passe non sécurisé", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                '6 = OK
                If (result = 6) Then
                    My.Settings.PassWord = TB_NewPW.Text
                    My.Settings.Save()
                    Me.Close()
                End If
            End If

        Else
            TB_OldPW.Text = "Error in Password"
        End If
    End Sub
End Class