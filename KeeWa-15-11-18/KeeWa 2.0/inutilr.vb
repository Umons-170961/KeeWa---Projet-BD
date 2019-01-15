Public Class inutilr
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles B_Modifier.Click
        TB_Nom.ReadOnly = False
        TB_Numéro.ReadOnly = False
        TB_Prix.ReadOnly = False
        TB_Type.ReadOnly = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles B_Sauvegarder.Click
        Main.LBL_ObType.Text = TB_Type.Text
        Main.LBL_ObPrix.Text = TB_Prix.Text
        Main.LBL_ObNom.Text = TB_Nom.Text
        Main.LBL_ObNuméro.Text = TB_Numéro.Text
        Me.Close()
    End Sub

    Private Sub ObjectWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Closed
        Main.Show()
        Main.LBL_ObType.Text = TB_Type.Text
        Main.LBL_ObPrix.Text = TB_Prix.Text
        Main.LBL_ObNom.Text = TB_Nom.Text
        Main.LBL_ObNuméro.Text = TB_Numéro.Text
    End Sub
End Class