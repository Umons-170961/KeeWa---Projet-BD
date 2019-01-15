Public Class GarantyWindow

    'ouverture fenetre choix de fichier
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BT_AjoutImage.Click
        OFP_Image.ShowDialog()
    End Sub
    'copie du fichier en question (à finir)
    Private Sub OFP_Image_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OFP_Image.FileOk
        My.Computer.FileSystem.CopyFile(OFP_Image.FileName, "C:\Users\Nathan K/Desktop/Trool.accbd",
          Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
          Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
    End Sub


    Private Sub LB_Prop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Prop.SelectedIndexChanged
        If LB_Prop.SelectedItem.Equals("Ajouter une personne") Then
            'Ouverture du créateur de nouvelle personne
        End If
    End Sub
    Private Sub LB_Util_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Util.SelectedIndexChanged
        If LB_Util.SelectedItem.Equals("Ajouter une personne") Then
            'Ouverture du créateur de nouvelle personne
        End If
    End Sub

    Private Sub LB_Tags_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Tags.SelectedIndexChanged
        If LB_Tags.SelectedItem.Equals("Ajouter un Tag") Then
            'Ouverture du créateur de nouveau Tag
        End If
    End Sub

    Private Sub BT_Type_Click(sender As Object, e As EventArgs) Handles BT_Type.Click
        'ouverure création type d'objet
    End Sub

    Private Sub BT_Marque_Click(sender As Object, e As EventArgs) Handles BT_Marque.Click
        'ouverture création Marque
    End Sub

    Private Sub BT_Magasin_Click(sender As Object, e As EventArgs) Handles BT_Magasin.Click
        'ouverure création Magasin
    End Sub





    Private Sub AjouterPersonneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterPersonneToolStripMenuItem.Click
        PersonWindow.Show()
        PersonWindow.CB_Modif.Enabled = False
        PersonWindow.LBL_Modif.Enabled = False
    End Sub

    Private Sub AjouterMagasinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterMagasinToolStripMenuItem.Click
        StoreWindow.Show()
        StoreWindow.CB_Modif.Enabled = False
        StoreWindow.LBL_Modif.Enabled = False
    End Sub

    Private Sub AjouterMarqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterMarqueToolStripMenuItem.Click
        CompanyWindow.Show()
        CompanyWindow.CB_Modif.Enabled = False
        CompanyWindow.LBL_Modif.Enabled = False
    End Sub

    Private Sub AjouterTypeDobjetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterTypeDobjetToolStripMenuItem.Click
        TypeWindow.Show()
        TypeWindow.CB_Modif.Enabled = False
        TypeWindow.LBL_Modif.Enabled = False
    End Sub

    Private Sub AjouterTagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterTagToolStripMenuItem.Click
        TagWindow.Show()
        TagWindow.CB_Modif.Enabled = False
        TagWindow.LBL_Modif.Enabled = False
    End Sub





    Private Sub ModifierPersonneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierPersonneToolStripMenuItem.Click
        PersonWindow.Show()
        PersonWindow.CB_Modif.Enabled = True
        PersonWindow.LBL_Modif.Enabled = True
    End Sub

    Private Sub ModifierMagasinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierMagasinToolStripMenuItem.Click
        StoreWindow.Show()
        StoreWindow.CB_Modif.Enabled = True
        StoreWindow.LBL_Modif.Enabled = True

    End Sub

    Private Sub ModifierMarqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierMarqueToolStripMenuItem.Click
        CompanyWindow.Show()
        CompanyWindow.CB_Modif.Enabled = True
        CompanyWindow.LBL_Modif.Enabled = True

    End Sub

    Private Sub ModifierTypeDobjetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierTypeDobjetToolStripMenuItem.Click
        TypeWindow.Show()
        TypeWindow.CB_Modif.Enabled = True
        TypeWindow.LBL_Modif.Enabled = True

    End Sub

    Private Sub ModifierTagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierTagToolStripMenuItem.Click
        TagWindow.Show()
        TagWindow.CB_Modif.Enabled = True
        TagWindow.LBL_Modif.Enabled = True
    End Sub
End Class

