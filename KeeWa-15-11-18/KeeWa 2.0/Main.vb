Imports System.Data
Imports System.Data.OleDb

Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Calvul des x prochaines garanties à expirer puis afficher la 1ere en changernt
        ''en gros ici on récupère le nom sur lequel on à cliqué et on rennome en conséquence tous les truc suivants :
        'LBL_GarDateFin.Text = ""
        'd.Text = ""
        'PB_GarProgression.Value = 50 'calcul du pourcentage...
        'LBL_MagAddresse.Text = ""
        'LBL_Magasin.Text = ""
        'LBL_MagEmail.Text = ""
        'LBL_MagNom.Text = ""
        'LBL_MagSite.Text = ""
        'LBL_MagTel.Text = ""
        'LBL_MarNom.Text = ""
        'LBL_MagSite.Text = ""
        'LBL_MagTel.Text = ""
        'LBL_MarNom.Text = ""
        'LBL_MarQual.Text = ""
        'LBL_Marque.Text = ""
        'LBL_MarSite.Text = ""
        'LBL_MarTel.Text = ""
        'LBL_ObNom.Text = ""
        'LBL_ObNuméro.Text = ""
        'LBL_ObNuméro.Text = ""
        'LBL_ObPrix.Text = ""
        'LBL_ObType.Text = ""
        'LBL_Tag1.Text = ""
        'LBL_Tag2.Text = ""
        'LBL_Tag3.Text = ""
        'LBL_Tag4.Text = ""
        'CB_UtilListe.Text = "" 'Texte a créer attention au passage à la ligne...
        ''ici on sélectione le reste pour le proprio
        'LBL_UtilLien.Text = ""
        'LBL_UtilMail.Text = ""
        'LBL_UtilNom.Text = ""
        'LBL_UtilTel.Text = ""
        'LBL_UtilTitre.Text = ""


        Dim ObjetConnection As OleDbConnection 'Déclaration Objet Connexion
        Dim strConn As String  'String contenant la Requête de connection
        strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Nathan K\Desktop\Y.accdb"
        ObjetConnection = New OleDbConnection
        ObjetConnection.ConnectionString = strConn 'Donner à la propriété 					ConnectionString les paramètres de connexion
        ObjetConnection.InitializeLifetimeService()
        ObjetConnection.Open()      'Ouvrir la connexion
        If ObjetConnection.State = 1 Then
            ToolStripStatusLabel1.Text = "Base de données connectée"
        End If
        ObjetConnection.Close()
    End Sub

    Private Sub BT_Effacer_Recherche_Click(sender As Object, e As EventArgs) Handles BT_Effacer_Recherche.Click
        TB_RMagasin.Text = ""
        TB_RMarque.Text = ""
        TB_RNom.Text = ""
        TB_RType.Text = ""
        CB_RTags.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BT_ModiferGarantie.Click
        GarantyWindow.Show()

        GarantyWindow.TB_Nom.Text = LBL_ObNom.Text
        GarantyWindow.TB_Numéro.Text = LBL_ObNuméro.Text
        GarantyWindow.TB_Prix.Text = LBL_ObPrix.Text
        GarantyWindow.CB_Type.SelectedItem = LBL_ObType.Text
        GarantyWindow.CB_Magasin.SelectedItem = LBL_MagNom.Text
        GarantyWindow.CB_Marque.SelectedItem = LBL_MarNom.Text
        GarantyWindow.TB_NomGarantie.Text = LBL_GarNomGar.Text
        If LBL_GarProlonge.Text = "oui" Then GarantyWindow.CB_Prolong.Checked = True Else GarantyWindow.CB_Prolong.Checked = False
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BT_NewGarantie.Click
        GarantyWindow.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_UtilListe.SelectedIndexChanged
        'changer les élément suivants en fonction de la sélection :
        LBL_UtilLien.Text = ""
        LBL_UtilMail.Text = ""
        LBL_UtilNom.Text = ""
        LBL_UtilTel.Text = ""
        LBL_UtilTitre.Text = ""
    End Sub


    Private Sub LB_Affichage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Affichage.SelectedIndexChanged
        LB_Affichage.SelectedIndex.ToString()
        'en gros ici on récupère le nom sur lequel on à cliqué et on rennome en conséquence tous les truc suivants :
        LBL_GarDateFin.Text = ""
        d.Text = ""
        PB_GarProgression.Value = 50 'calcul du pourcentage...
        LBL_MagAddresse.Text = ""
        LBL_Magasin.Text = ""
        LBL_MagEmail.Text = ""
        LBL_MagNom.Text = ""
        LBL_MagSite.Text = ""
        LBL_MagTel.Text = ""
        LBL_MarNom.Text = ""
        LBL_MagSite.Text = ""
        LBL_MagTel.Text = ""
        LBL_MarNom.Text = ""
        LBL_MarQual.Text = ""
        LBL_Marque.Text = ""
        LBL_MarSite.Text = ""
        LBL_MarTel.Text = ""
        LBL_ObNom.Text = ""
        LBL_ObNuméro.Text = ""
        LBL_ObNuméro.Text = ""
        LBL_ObPrix.Text = ""
        LBL_ObType.Text = ""
        LBL_Tag1.Text = ""
        LBL_Tag2.Text = ""
        LBL_Tag3.Text = ""
        LBL_Tag4.Text = ""
        CB_UtilListe.Text = "" 'Texte a créer attention au passage à la ligne...
        'ici on sélectione le reste pour le proprio
        LBL_UtilLien.Text = ""
        LBL_UtilMail.Text = ""
        LBL_UtilNom.Text = ""
        LBL_UtilTel.Text = ""
        LBL_UtilTitre.Text = ""
    End Sub

    Private Sub BT_Recherche_Click(sender As Object, e As EventArgs) Handles BT_Recherche.Click
        'effectuer le recherche en fonction de :
        TB_RMagasin.ToString()
        TB_RMarque.ToString()
        TB_RNom.ToString()
        TB_RType.ToString()
    End Sub







    Private Sub AjouterGarantieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterGarantieToolStripMenuItem.Click
        GarantyWindow.Show()
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

