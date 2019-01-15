<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.GB_Recherche = New System.Windows.Forms.GroupBox()
        Me.CB_RTags = New System.Windows.Forms.ComboBox()
        Me.TB_RMarque = New System.Windows.Forms.TextBox()
        Me.TB_RMagasin = New System.Windows.Forms.TextBox()
        Me.TB_RType = New System.Windows.Forms.TextBox()
        Me.BT_Effacer_Recherche = New System.Windows.Forms.Button()
        Me.TB_RNom = New System.Windows.Forms.TextBox()
        Me.LBL_Tags = New System.Windows.Forms.Label()
        Me.LBL_Magasin = New System.Windows.Forms.Label()
        Me.BT_Recherche = New System.Windows.Forms.Button()
        Me.LBL_Marque = New System.Windows.Forms.Label()
        Me.LBL_TypeObjet = New System.Windows.Forms.Label()
        Me.LBL_Nom = New System.Windows.Forms.Label()
        Me.LB_Affichage = New System.Windows.Forms.ListBox()
        Me.GB_Fiche = New System.Windows.Forms.GroupBox()
        Me.BT_NewGarantie = New System.Windows.Forms.Button()
        Me.BT_ModiferGarantie = New System.Windows.Forms.Button()
        Me.GB_Utilisateur = New System.Windows.Forms.GroupBox()
        Me.CB_UtilListe = New System.Windows.Forms.ComboBox()
        Me.LBL_UtilLien = New System.Windows.Forms.Label()
        Me.LBL_UtilTel = New System.Windows.Forms.LinkLabel()
        Me.LBL_UtilMail = New System.Windows.Forms.LinkLabel()
        Me.LBL_UtilTitre = New System.Windows.Forms.Label()
        Me.LBL_UtilNom = New System.Windows.Forms.Label()
        Me.GB_Tag = New System.Windows.Forms.GroupBox()
        Me.LBL_Tag4 = New System.Windows.Forms.Label()
        Me.LBL_Tag3 = New System.Windows.Forms.Label()
        Me.LBL_Tag2 = New System.Windows.Forms.Label()
        Me.LBL_Tag1 = New System.Windows.Forms.Label()
        Me.GB_Garantie = New System.Windows.Forms.GroupBox()
        Me.LBL_GarProlonge = New System.Windows.Forms.Label()
        Me.d = New System.Windows.Forms.Label()
        Me.LBL_GarDateFin = New System.Windows.Forms.Label()
        Me.PB_GarProgression = New System.Windows.Forms.ProgressBar()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LBL_GarNomGar = New System.Windows.Forms.Label()
        Me.GB_Magasin = New System.Windows.Forms.GroupBox()
        Me.LBL_MagTel = New System.Windows.Forms.Label()
        Me.LBL_MagEmail = New System.Windows.Forms.LinkLabel()
        Me.LBL_MagSite = New System.Windows.Forms.LinkLabel()
        Me.LBL_MagAddresse = New System.Windows.Forms.Label()
        Me.LBL_MagNom = New System.Windows.Forms.Label()
        Me.GB_Marque = New System.Windows.Forms.GroupBox()
        Me.LBL_MarQual = New System.Windows.Forms.Label()
        Me.LBL_MarTel = New System.Windows.Forms.LinkLabel()
        Me.LBL_MarSite = New System.Windows.Forms.LinkLabel()
        Me.LBL_MarNom = New System.Windows.Forms.Label()
        Me.GB_Objet = New System.Windows.Forms.GroupBox()
        Me.LBL_ObType = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.LBL_ObPrix = New System.Windows.Forms.Label()
        Me.LBL_ObNuméro = New System.Windows.Forms.Label()
        Me.LBL_ObNom = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AjouterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterGarantieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterPersonneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterMagasinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterMarqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterTypeDobjetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterTagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModiferToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierPersonneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierMagasinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierMarqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierTypeDobjetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierTagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FichiersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccéderAuxImagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccéderÀLaBaseDeDonnéesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParamètresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GB_Recherche.SuspendLayout()
        Me.GB_Fiche.SuspendLayout()
        Me.GB_Utilisateur.SuspendLayout()
        Me.GB_Tag.SuspendLayout()
        Me.GB_Garantie.SuspendLayout()
        Me.GB_Magasin.SuspendLayout()
        Me.GB_Marque.SuspendLayout()
        Me.GB_Objet.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_Recherche
        '
        Me.GB_Recherche.AutoSize = True
        Me.GB_Recherche.Controls.Add(Me.CB_RTags)
        Me.GB_Recherche.Controls.Add(Me.TB_RMarque)
        Me.GB_Recherche.Controls.Add(Me.TB_RMagasin)
        Me.GB_Recherche.Controls.Add(Me.TB_RType)
        Me.GB_Recherche.Controls.Add(Me.BT_Effacer_Recherche)
        Me.GB_Recherche.Controls.Add(Me.TB_RNom)
        Me.GB_Recherche.Controls.Add(Me.LBL_Tags)
        Me.GB_Recherche.Controls.Add(Me.LBL_Magasin)
        Me.GB_Recherche.Controls.Add(Me.BT_Recherche)
        Me.GB_Recherche.Controls.Add(Me.LBL_Marque)
        Me.GB_Recherche.Controls.Add(Me.LBL_TypeObjet)
        Me.GB_Recherche.Controls.Add(Me.LBL_Nom)
        Me.GB_Recherche.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Recherche.Location = New System.Drawing.Point(12, 27)
        Me.GB_Recherche.Name = "GB_Recherche"
        Me.GB_Recherche.Size = New System.Drawing.Size(242, 218)
        Me.GB_Recherche.TabIndex = 1
        Me.GB_Recherche.TabStop = False
        Me.GB_Recherche.Text = "Recherche"
        '
        'CB_RTags
        '
        Me.CB_RTags.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CB_RTags.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_RTags.FormattingEnabled = True
        Me.CB_RTags.Location = New System.Drawing.Point(105, 136)
        Me.CB_RTags.Name = "CB_RTags"
        Me.CB_RTags.Size = New System.Drawing.Size(121, 24)
        Me.CB_RTags.TabIndex = 5
        '
        'TB_RMarque
        '
        Me.TB_RMarque.Location = New System.Drawing.Point(126, 107)
        Me.TB_RMarque.Name = "TB_RMarque"
        Me.TB_RMarque.Size = New System.Drawing.Size(100, 23)
        Me.TB_RMarque.TabIndex = 4
        '
        'TB_RMagasin
        '
        Me.TB_RMagasin.Location = New System.Drawing.Point(126, 78)
        Me.TB_RMagasin.Name = "TB_RMagasin"
        Me.TB_RMagasin.Size = New System.Drawing.Size(100, 23)
        Me.TB_RMagasin.TabIndex = 3
        '
        'TB_RType
        '
        Me.TB_RType.Location = New System.Drawing.Point(126, 49)
        Me.TB_RType.Name = "TB_RType"
        Me.TB_RType.Size = New System.Drawing.Size(100, 23)
        Me.TB_RType.TabIndex = 2
        '
        'BT_Effacer_Recherche
        '
        Me.BT_Effacer_Recherche.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Effacer_Recherche.Location = New System.Drawing.Point(10, 166)
        Me.BT_Effacer_Recherche.Name = "BT_Effacer_Recherche"
        Me.BT_Effacer_Recherche.Size = New System.Drawing.Size(100, 30)
        Me.BT_Effacer_Recherche.TabIndex = 7
        Me.BT_Effacer_Recherche.Text = "Effacer"
        Me.BT_Effacer_Recherche.UseVisualStyleBackColor = True
        '
        'TB_RNom
        '
        Me.TB_RNom.Location = New System.Drawing.Point(126, 20)
        Me.TB_RNom.Name = "TB_RNom"
        Me.TB_RNom.Size = New System.Drawing.Size(100, 23)
        Me.TB_RNom.TabIndex = 1
        '
        'LBL_Tags
        '
        Me.LBL_Tags.AutoSize = True
        Me.LBL_Tags.Location = New System.Drawing.Point(7, 139)
        Me.LBL_Tags.Name = "LBL_Tags"
        Me.LBL_Tags.Size = New System.Drawing.Size(40, 17)
        Me.LBL_Tags.TabIndex = 6
        Me.LBL_Tags.Text = "Tags"
        '
        'LBL_Magasin
        '
        Me.LBL_Magasin.AutoSize = True
        Me.LBL_Magasin.Location = New System.Drawing.Point(7, 81)
        Me.LBL_Magasin.Name = "LBL_Magasin"
        Me.LBL_Magasin.Size = New System.Drawing.Size(61, 17)
        Me.LBL_Magasin.TabIndex = 5
        Me.LBL_Magasin.Text = "Magasin"
        '
        'BT_Recherche
        '
        Me.BT_Recherche.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Recherche.Location = New System.Drawing.Point(126, 166)
        Me.BT_Recherche.Name = "BT_Recherche"
        Me.BT_Recherche.Size = New System.Drawing.Size(100, 30)
        Me.BT_Recherche.TabIndex = 6
        Me.BT_Recherche.Text = "Recherche"
        Me.BT_Recherche.UseVisualStyleBackColor = True
        '
        'LBL_Marque
        '
        Me.LBL_Marque.AutoSize = True
        Me.LBL_Marque.Location = New System.Drawing.Point(7, 110)
        Me.LBL_Marque.Name = "LBL_Marque"
        Me.LBL_Marque.Size = New System.Drawing.Size(56, 17)
        Me.LBL_Marque.TabIndex = 2
        Me.LBL_Marque.Text = "Marque"
        '
        'LBL_TypeObjet
        '
        Me.LBL_TypeObjet.AutoSize = True
        Me.LBL_TypeObjet.Location = New System.Drawing.Point(7, 52)
        Me.LBL_TypeObjet.Name = "LBL_TypeObjet"
        Me.LBL_TypeObjet.Size = New System.Drawing.Size(86, 17)
        Me.LBL_TypeObjet.TabIndex = 1
        Me.LBL_TypeObjet.Text = "Type d'objet"
        '
        'LBL_Nom
        '
        Me.LBL_Nom.AutoSize = True
        Me.LBL_Nom.Location = New System.Drawing.Point(7, 23)
        Me.LBL_Nom.Name = "LBL_Nom"
        Me.LBL_Nom.Size = New System.Drawing.Size(37, 17)
        Me.LBL_Nom.TabIndex = 0
        Me.LBL_Nom.Text = "Nom"
        '
        'LB_Affichage
        '
        Me.LB_Affichage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LB_Affichage.FormattingEnabled = True
        Me.LB_Affichage.ItemHeight = 16
        Me.LB_Affichage.Items.AddRange(New Object() {"Ipod (25 Janvier 2019)", "Plumier (30 septembre 2019)", "Cable (14 octobre 2019)", "Surface book (13 décembre 2019)"})
        Me.LB_Affichage.Location = New System.Drawing.Point(12, 239)
        Me.LB_Affichage.Name = "LB_Affichage"
        Me.LB_Affichage.Size = New System.Drawing.Size(242, 212)
        Me.LB_Affichage.TabIndex = 10
        '
        'GB_Fiche
        '
        Me.GB_Fiche.AutoSize = True
        Me.GB_Fiche.Controls.Add(Me.BT_NewGarantie)
        Me.GB_Fiche.Controls.Add(Me.BT_ModiferGarantie)
        Me.GB_Fiche.Controls.Add(Me.GB_Utilisateur)
        Me.GB_Fiche.Controls.Add(Me.GB_Tag)
        Me.GB_Fiche.Controls.Add(Me.GB_Garantie)
        Me.GB_Fiche.Controls.Add(Me.GB_Magasin)
        Me.GB_Fiche.Controls.Add(Me.GB_Marque)
        Me.GB_Fiche.Controls.Add(Me.GB_Objet)
        Me.GB_Fiche.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Fiche.Location = New System.Drawing.Point(267, 27)
        Me.GB_Fiche.Name = "GB_Fiche"
        Me.GB_Fiche.Size = New System.Drawing.Size(659, 446)
        Me.GB_Fiche.TabIndex = 3
        Me.GB_Fiche.TabStop = False
        Me.GB_Fiche.Text = "Fiche détaillée"
        '
        'BT_NewGarantie
        '
        Me.BT_NewGarantie.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.BT_NewGarantie.Location = New System.Drawing.Point(6, 383)
        Me.BT_NewGarantie.Name = "BT_NewGarantie"
        Me.BT_NewGarantie.Size = New System.Drawing.Size(340, 41)
        Me.BT_NewGarantie.TabIndex = 12
        Me.BT_NewGarantie.Text = "Créer nouvelle garantie"
        Me.BT_NewGarantie.UseVisualStyleBackColor = True
        '
        'BT_ModiferGarantie
        '
        Me.BT_ModiferGarantie.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.BT_ModiferGarantie.Location = New System.Drawing.Point(6, 336)
        Me.BT_ModiferGarantie.Name = "BT_ModiferGarantie"
        Me.BT_ModiferGarantie.Size = New System.Drawing.Size(340, 41)
        Me.BT_ModiferGarantie.TabIndex = 11
        Me.BT_ModiferGarantie.Text = "Modifier garantie"
        Me.BT_ModiferGarantie.UseVisualStyleBackColor = True
        '
        'GB_Utilisateur
        '
        Me.GB_Utilisateur.Controls.Add(Me.CB_UtilListe)
        Me.GB_Utilisateur.Controls.Add(Me.LBL_UtilLien)
        Me.GB_Utilisateur.Controls.Add(Me.LBL_UtilTel)
        Me.GB_Utilisateur.Controls.Add(Me.LBL_UtilMail)
        Me.GB_Utilisateur.Controls.Add(Me.LBL_UtilTitre)
        Me.GB_Utilisateur.Controls.Add(Me.LBL_UtilNom)
        Me.GB_Utilisateur.Location = New System.Drawing.Point(6, 139)
        Me.GB_Utilisateur.Name = "GB_Utilisateur"
        Me.GB_Utilisateur.Size = New System.Drawing.Size(340, 188)
        Me.GB_Utilisateur.TabIndex = 5
        Me.GB_Utilisateur.TabStop = False
        Me.GB_Utilisateur.Text = "Utilisateurs"
        '
        'CB_UtilListe
        '
        Me.CB_UtilListe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_UtilListe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_UtilListe.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.CB_UtilListe.FormattingEnabled = True
        Me.CB_UtilListe.Items.AddRange(New Object() {"Tom", "Jean-Paul", "Arthur", "Célestine", "Roberto", "Nathan", "Nicolas", "Loic", "Charles", "Neville", "Xavier", "Stephan"})
        Me.CB_UtilListe.Location = New System.Drawing.Point(9, 22)
        Me.CB_UtilListe.Name = "CB_UtilListe"
        Me.CB_UtilListe.Size = New System.Drawing.Size(325, 39)
        Me.CB_UtilListe.TabIndex = 12
        Me.CB_UtilListe.TabStop = False
        '
        'LBL_UtilLien
        '
        Me.LBL_UtilLien.AutoSize = True
        Me.LBL_UtilLien.Location = New System.Drawing.Point(6, 120)
        Me.LBL_UtilLien.Name = "LBL_UtilLien"
        Me.LBL_UtilLien.Size = New System.Drawing.Size(127, 17)
        Me.LBL_UtilLien.TabIndex = 11
        Me.LBL_UtilLien.Text = "LIEN AVEC OBJET"
        '
        'LBL_UtilTel
        '
        Me.LBL_UtilTel.AutoSize = True
        Me.LBL_UtilTel.Location = New System.Drawing.Point(6, 160)
        Me.LBL_UtilTel.Name = "LBL_UtilTel"
        Me.LBL_UtilTel.Size = New System.Drawing.Size(180, 17)
        Me.LBL_UtilTel.TabIndex = 10
        Me.LBL_UtilTel.TabStop = True
        Me.LBL_UtilTel.Text = "NUMERO DE TELEPHONE"
        '
        'LBL_UtilMail
        '
        Me.LBL_UtilMail.AutoSize = True
        Me.LBL_UtilMail.Location = New System.Drawing.Point(6, 140)
        Me.LBL_UtilMail.Name = "LBL_UtilMail"
        Me.LBL_UtilMail.Size = New System.Drawing.Size(48, 17)
        Me.LBL_UtilMail.TabIndex = 9
        Me.LBL_UtilMail.TabStop = True
        Me.LBL_UtilMail.Text = "EMAIL"
        '
        'LBL_UtilTitre
        '
        Me.LBL_UtilTitre.AutoSize = True
        Me.LBL_UtilTitre.Location = New System.Drawing.Point(3, 100)
        Me.LBL_UtilTitre.Name = "LBL_UtilTitre"
        Me.LBL_UtilTitre.Size = New System.Drawing.Size(48, 17)
        Me.LBL_UtilTitre.TabIndex = 8
        Me.LBL_UtilTitre.Text = "TITRE"
        '
        'LBL_UtilNom
        '
        Me.LBL_UtilNom.AutoSize = True
        Me.LBL_UtilNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LBL_UtilNom.Location = New System.Drawing.Point(4, 70)
        Me.LBL_UtilNom.Name = "LBL_UtilNom"
        Me.LBL_UtilNom.Size = New System.Drawing.Size(162, 25)
        Me.LBL_UtilNom.TabIndex = 7
        Me.LBL_UtilNom.Text = "NOM - PRENOM"
        '
        'GB_Tag
        '
        Me.GB_Tag.Controls.Add(Me.LBL_Tag4)
        Me.GB_Tag.Controls.Add(Me.LBL_Tag3)
        Me.GB_Tag.Controls.Add(Me.LBL_Tag2)
        Me.GB_Tag.Controls.Add(Me.LBL_Tag1)
        Me.GB_Tag.Location = New System.Drawing.Point(212, 26)
        Me.GB_Tag.Name = "GB_Tag"
        Me.GB_Tag.Size = New System.Drawing.Size(134, 104)
        Me.GB_Tag.TabIndex = 4
        Me.GB_Tag.TabStop = False
        Me.GB_Tag.Text = "Tags"
        '
        'LBL_Tag4
        '
        Me.LBL_Tag4.AutoSize = True
        Me.LBL_Tag4.Location = New System.Drawing.Point(6, 80)
        Me.LBL_Tag4.Name = "LBL_Tag4"
        Me.LBL_Tag4.Size = New System.Drawing.Size(59, 17)
        Me.LBL_Tag4.TabIndex = 3
        Me.LBL_Tag4.Text = "Label10"
        '
        'LBL_Tag3
        '
        Me.LBL_Tag3.AutoSize = True
        Me.LBL_Tag3.Location = New System.Drawing.Point(6, 60)
        Me.LBL_Tag3.Name = "LBL_Tag3"
        Me.LBL_Tag3.Size = New System.Drawing.Size(51, 17)
        Me.LBL_Tag3.TabIndex = 2
        Me.LBL_Tag3.Text = "Label9"
        '
        'LBL_Tag2
        '
        Me.LBL_Tag2.AutoSize = True
        Me.LBL_Tag2.Location = New System.Drawing.Point(6, 40)
        Me.LBL_Tag2.Name = "LBL_Tag2"
        Me.LBL_Tag2.Size = New System.Drawing.Size(51, 17)
        Me.LBL_Tag2.TabIndex = 1
        Me.LBL_Tag2.Text = "Label8"
        '
        'LBL_Tag1
        '
        Me.LBL_Tag1.AutoSize = True
        Me.LBL_Tag1.Location = New System.Drawing.Point(6, 20)
        Me.LBL_Tag1.Name = "LBL_Tag1"
        Me.LBL_Tag1.Size = New System.Drawing.Size(51, 17)
        Me.LBL_Tag1.TabIndex = 0
        Me.LBL_Tag1.Text = "Label7"
        '
        'GB_Garantie
        '
        Me.GB_Garantie.Controls.Add(Me.LBL_GarProlonge)
        Me.GB_Garantie.Controls.Add(Me.d)
        Me.GB_Garantie.Controls.Add(Me.LBL_GarDateFin)
        Me.GB_Garantie.Controls.Add(Me.PB_GarProgression)
        Me.GB_Garantie.Controls.Add(Me.Label19)
        Me.GB_Garantie.Controls.Add(Me.Label18)
        Me.GB_Garantie.Controls.Add(Me.LBL_GarNomGar)
        Me.GB_Garantie.Location = New System.Drawing.Point(352, 26)
        Me.GB_Garantie.Name = "GB_Garantie"
        Me.GB_Garantie.Size = New System.Drawing.Size(301, 104)
        Me.GB_Garantie.TabIndex = 3
        Me.GB_Garantie.TabStop = False
        Me.GB_Garantie.Text = "Garantie"
        '
        'LBL_GarProlonge
        '
        Me.LBL_GarProlonge.AutoSize = True
        Me.LBL_GarProlonge.Location = New System.Drawing.Point(104, 80)
        Me.LBL_GarProlonge.Name = "LBL_GarProlonge"
        Me.LBL_GarProlonge.Size = New System.Drawing.Size(51, 17)
        Me.LBL_GarProlonge.TabIndex = 6
        Me.LBL_GarProlonge.Text = "Label4"
        '
        'd
        '
        Me.d.AutoSize = True
        Me.d.Location = New System.Drawing.Point(6, 80)
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(65, 17)
        Me.d.TabIndex = 5
        Me.d.Text = "Prolongé"
        '
        'LBL_GarDateFin
        '
        Me.LBL_GarDateFin.AutoSize = True
        Me.LBL_GarDateFin.Location = New System.Drawing.Point(101, 40)
        Me.LBL_GarDateFin.Name = "LBL_GarDateFin"
        Me.LBL_GarDateFin.Size = New System.Drawing.Size(59, 17)
        Me.LBL_GarDateFin.TabIndex = 4
        Me.LBL_GarDateFin.Text = "Label20"
        '
        'PB_GarProgression
        '
        Me.PB_GarProgression.ForeColor = System.Drawing.Color.HotPink
        Me.PB_GarProgression.Location = New System.Drawing.Point(104, 60)
        Me.PB_GarProgression.Name = "PB_GarProgression"
        Me.PB_GarProgression.Size = New System.Drawing.Size(191, 17)
        Me.PB_GarProgression.TabIndex = 3
        Me.PB_GarProgression.Value = 100
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 60)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(92, 17)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Progression :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 40)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 17)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Date de fin :"
        '
        'LBL_GarNomGar
        '
        Me.LBL_GarNomGar.AutoSize = True
        Me.LBL_GarNomGar.Location = New System.Drawing.Point(6, 20)
        Me.LBL_GarNomGar.Name = "LBL_GarNomGar"
        Me.LBL_GarNomGar.Size = New System.Drawing.Size(137, 17)
        Me.LBL_GarNomGar.TabIndex = 0
        Me.LBL_GarNomGar.Text = "NOM DE GARANTIE"
        '
        'GB_Magasin
        '
        Me.GB_Magasin.Controls.Add(Me.LBL_MagTel)
        Me.GB_Magasin.Controls.Add(Me.LBL_MagEmail)
        Me.GB_Magasin.Controls.Add(Me.LBL_MagSite)
        Me.GB_Magasin.Controls.Add(Me.LBL_MagAddresse)
        Me.GB_Magasin.Controls.Add(Me.LBL_MagNom)
        Me.GB_Magasin.Location = New System.Drawing.Point(352, 139)
        Me.GB_Magasin.Name = "GB_Magasin"
        Me.GB_Magasin.Size = New System.Drawing.Size(301, 165)
        Me.GB_Magasin.TabIndex = 2
        Me.GB_Magasin.TabStop = False
        Me.GB_Magasin.Text = "Magasin"
        '
        'LBL_MagTel
        '
        Me.LBL_MagTel.AutoSize = True
        Me.LBL_MagTel.Location = New System.Drawing.Point(6, 140)
        Me.LBL_MagTel.Name = "LBL_MagTel"
        Me.LBL_MagTel.Size = New System.Drawing.Size(180, 17)
        Me.LBL_MagTel.TabIndex = 4
        Me.LBL_MagTel.Text = "NUMERO DE TELEPHONE"
        '
        'LBL_MagEmail
        '
        Me.LBL_MagEmail.AutoSize = True
        Me.LBL_MagEmail.Location = New System.Drawing.Point(6, 120)
        Me.LBL_MagEmail.Name = "LBL_MagEmail"
        Me.LBL_MagEmail.Size = New System.Drawing.Size(141, 17)
        Me.LBL_MagEmail.TabIndex = 0
        Me.LBL_MagEmail.TabStop = True
        Me.LBL_MagEmail.Text = "EMAIL DE CONTACT"
        '
        'LBL_MagSite
        '
        Me.LBL_MagSite.AutoSize = True
        Me.LBL_MagSite.Location = New System.Drawing.Point(6, 100)
        Me.LBL_MagSite.Name = "LBL_MagSite"
        Me.LBL_MagSite.Size = New System.Drawing.Size(111, 17)
        Me.LBL_MagSite.TabIndex = 0
        Me.LBL_MagSite.TabStop = True
        Me.LBL_MagSite.Text = "SITE INTERNET"
        '
        'LBL_MagAddresse
        '
        Me.LBL_MagAddresse.AutoSize = True
        Me.LBL_MagAddresse.Location = New System.Drawing.Point(6, 50)
        Me.LBL_MagAddresse.Name = "LBL_MagAddresse"
        Me.LBL_MagAddresse.Size = New System.Drawing.Size(177, 68)
        Me.LBL_MagAddresse.TabIndex = 1
        Me.LBL_MagAddresse.Text = "RUE MAGASIN - NUMERO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CODE POSTAL - VILLE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PAYS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LBL_MagNom
        '
        Me.LBL_MagNom.AutoSize = True
        Me.LBL_MagNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LBL_MagNom.Location = New System.Drawing.Point(4, 20)
        Me.LBL_MagNom.Name = "LBL_MagNom"
        Me.LBL_MagNom.Size = New System.Drawing.Size(157, 25)
        Me.LBL_MagNom.TabIndex = 0
        Me.LBL_MagNom.Text = "NOM MAGASIN"
        '
        'GB_Marque
        '
        Me.GB_Marque.Controls.Add(Me.LBL_MarQual)
        Me.GB_Marque.Controls.Add(Me.LBL_MarTel)
        Me.GB_Marque.Controls.Add(Me.LBL_MarSite)
        Me.GB_Marque.Controls.Add(Me.LBL_MarNom)
        Me.GB_Marque.Location = New System.Drawing.Point(352, 310)
        Me.GB_Marque.Name = "GB_Marque"
        Me.GB_Marque.Size = New System.Drawing.Size(301, 114)
        Me.GB_Marque.TabIndex = 1
        Me.GB_Marque.TabStop = False
        Me.GB_Marque.Text = "Marque"
        '
        'LBL_MarQual
        '
        Me.LBL_MarQual.AutoSize = True
        Me.LBL_MarQual.Location = New System.Drawing.Point(6, 90)
        Me.LBL_MarQual.Name = "LBL_MarQual"
        Me.LBL_MarQual.Size = New System.Drawing.Size(134, 17)
        Me.LBL_MarQual.TabIndex = 3
        Me.LBL_MarQual.Text = "Qualité service :  ./5"
        '
        'LBL_MarTel
        '
        Me.LBL_MarTel.AutoSize = True
        Me.LBL_MarTel.Location = New System.Drawing.Point(6, 70)
        Me.LBL_MarTel.Name = "LBL_MarTel"
        Me.LBL_MarTel.Size = New System.Drawing.Size(180, 17)
        Me.LBL_MarTel.TabIndex = 0
        Me.LBL_MarTel.TabStop = True
        Me.LBL_MarTel.Text = "NUMERO DE TELEPHONE"
        '
        'LBL_MarSite
        '
        Me.LBL_MarSite.AutoSize = True
        Me.LBL_MarSite.Location = New System.Drawing.Point(6, 50)
        Me.LBL_MarSite.Name = "LBL_MarSite"
        Me.LBL_MarSite.Size = New System.Drawing.Size(111, 17)
        Me.LBL_MarSite.TabIndex = 0
        Me.LBL_MarSite.TabStop = True
        Me.LBL_MarSite.Text = "SITE INTERNET"
        '
        'LBL_MarNom
        '
        Me.LBL_MarNom.AutoSize = True
        Me.LBL_MarNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LBL_MarNom.Location = New System.Drawing.Point(4, 20)
        Me.LBL_MarNom.Name = "LBL_MarNom"
        Me.LBL_MarNom.Size = New System.Drawing.Size(59, 25)
        Me.LBL_MarNom.TabIndex = 0
        Me.LBL_MarNom.Text = "NOM"
        '
        'GB_Objet
        '
        Me.GB_Objet.Controls.Add(Me.LBL_ObType)
        Me.GB_Objet.Controls.Add(Me.Label21)
        Me.GB_Objet.Controls.Add(Me.LBL_ObPrix)
        Me.GB_Objet.Controls.Add(Me.LBL_ObNuméro)
        Me.GB_Objet.Controls.Add(Me.LBL_ObNom)
        Me.GB_Objet.Controls.Add(Me.Label3)
        Me.GB_Objet.Controls.Add(Me.Label2)
        Me.GB_Objet.Controls.Add(Me.Label1)
        Me.GB_Objet.Location = New System.Drawing.Point(6, 26)
        Me.GB_Objet.Name = "GB_Objet"
        Me.GB_Objet.Size = New System.Drawing.Size(200, 104)
        Me.GB_Objet.TabIndex = 0
        Me.GB_Objet.TabStop = False
        Me.GB_Objet.Text = "Objet"
        '
        'LBL_ObType
        '
        Me.LBL_ObType.AutoSize = True
        Me.LBL_ObType.Location = New System.Drawing.Point(143, 80)
        Me.LBL_ObType.Name = "LBL_ObType"
        Me.LBL_ObType.Size = New System.Drawing.Size(51, 17)
        Me.LBL_ObType.TabIndex = 7
        Me.LBL_ObType.Text = "Label2"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 80)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(94, 17)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "Type d'objet :"
        '
        'LBL_ObPrix
        '
        Me.LBL_ObPrix.AutoSize = True
        Me.LBL_ObPrix.Location = New System.Drawing.Point(143, 60)
        Me.LBL_ObPrix.Name = "LBL_ObPrix"
        Me.LBL_ObPrix.Size = New System.Drawing.Size(51, 17)
        Me.LBL_ObPrix.TabIndex = 5
        Me.LBL_ObPrix.Text = "Label6"
        '
        'LBL_ObNuméro
        '
        Me.LBL_ObNuméro.AutoSize = True
        Me.LBL_ObNuméro.Location = New System.Drawing.Point(143, 40)
        Me.LBL_ObNuméro.Name = "LBL_ObNuméro"
        Me.LBL_ObNuméro.Size = New System.Drawing.Size(51, 17)
        Me.LBL_ObNuméro.TabIndex = 4
        Me.LBL_ObNuméro.Text = "Label5"
        '
        'LBL_ObNom
        '
        Me.LBL_ObNom.AutoSize = True
        Me.LBL_ObNom.Location = New System.Drawing.Point(143, 20)
        Me.LBL_ObNom.Name = "LBL_ObNom"
        Me.LBL_ObNom.Size = New System.Drawing.Size(51, 17)
        Me.LBL_ObNom.TabIndex = 3
        Me.LBL_ObNom.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Prix :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numéro :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom :"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 520)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(936, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(175, 17)
        Me.ToolStripStatusLabel1.Text = "Base de donnée non connectée "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterToolStripMenuItem, Me.ModiferToolStripMenuItem, Me.FichiersToolStripMenuItem, Me.ParamètresToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(936, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AjouterToolStripMenuItem
        '
        Me.AjouterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterGarantieToolStripMenuItem, Me.AjouterPersonneToolStripMenuItem, Me.AjouterMagasinToolStripMenuItem, Me.AjouterMarqueToolStripMenuItem, Me.AjouterTypeDobjetToolStripMenuItem, Me.AjouterTagToolStripMenuItem})
        Me.AjouterToolStripMenuItem.Name = "AjouterToolStripMenuItem"
        Me.AjouterToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.AjouterToolStripMenuItem.Text = "Ajouter"
        '
        'AjouterGarantieToolStripMenuItem
        '
        Me.AjouterGarantieToolStripMenuItem.Name = "AjouterGarantieToolStripMenuItem"
        Me.AjouterGarantieToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AjouterGarantieToolStripMenuItem.Text = "Ajouter Garantie"
        '
        'AjouterPersonneToolStripMenuItem
        '
        Me.AjouterPersonneToolStripMenuItem.Name = "AjouterPersonneToolStripMenuItem"
        Me.AjouterPersonneToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AjouterPersonneToolStripMenuItem.Text = "Ajouter Personne"
        '
        'AjouterMagasinToolStripMenuItem
        '
        Me.AjouterMagasinToolStripMenuItem.Name = "AjouterMagasinToolStripMenuItem"
        Me.AjouterMagasinToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AjouterMagasinToolStripMenuItem.Text = "Ajouter Magasin"
        '
        'AjouterMarqueToolStripMenuItem
        '
        Me.AjouterMarqueToolStripMenuItem.Name = "AjouterMarqueToolStripMenuItem"
        Me.AjouterMarqueToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AjouterMarqueToolStripMenuItem.Text = "Ajouter Marque"
        '
        'AjouterTypeDobjetToolStripMenuItem
        '
        Me.AjouterTypeDobjetToolStripMenuItem.Name = "AjouterTypeDobjetToolStripMenuItem"
        Me.AjouterTypeDobjetToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AjouterTypeDobjetToolStripMenuItem.Text = "Ajouter Type d'objet"
        '
        'AjouterTagToolStripMenuItem
        '
        Me.AjouterTagToolStripMenuItem.Name = "AjouterTagToolStripMenuItem"
        Me.AjouterTagToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AjouterTagToolStripMenuItem.Text = "Ajouter Tag"
        '
        'ModiferToolStripMenuItem
        '
        Me.ModiferToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModifierPersonneToolStripMenuItem, Me.ModifierMagasinToolStripMenuItem, Me.ModifierMarqueToolStripMenuItem, Me.ModifierTypeDobjetToolStripMenuItem, Me.ModifierTagToolStripMenuItem})
        Me.ModiferToolStripMenuItem.Name = "ModiferToolStripMenuItem"
        Me.ModiferToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ModiferToolStripMenuItem.Text = "Modifer"
        '
        'ModifierPersonneToolStripMenuItem
        '
        Me.ModifierPersonneToolStripMenuItem.Name = "ModifierPersonneToolStripMenuItem"
        Me.ModifierPersonneToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ModifierPersonneToolStripMenuItem.Text = "Modifier Personne"
        '
        'ModifierMagasinToolStripMenuItem
        '
        Me.ModifierMagasinToolStripMenuItem.Name = "ModifierMagasinToolStripMenuItem"
        Me.ModifierMagasinToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ModifierMagasinToolStripMenuItem.Text = "Modifier Magasin"
        '
        'ModifierMarqueToolStripMenuItem
        '
        Me.ModifierMarqueToolStripMenuItem.Name = "ModifierMarqueToolStripMenuItem"
        Me.ModifierMarqueToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ModifierMarqueToolStripMenuItem.Text = "Modifier Marque"
        '
        'ModifierTypeDobjetToolStripMenuItem
        '
        Me.ModifierTypeDobjetToolStripMenuItem.Name = "ModifierTypeDobjetToolStripMenuItem"
        Me.ModifierTypeDobjetToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ModifierTypeDobjetToolStripMenuItem.Text = "Modifier Type d'objet"
        '
        'ModifierTagToolStripMenuItem
        '
        Me.ModifierTagToolStripMenuItem.Name = "ModifierTagToolStripMenuItem"
        Me.ModifierTagToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ModifierTagToolStripMenuItem.Text = "Modifier Tag"
        '
        'FichiersToolStripMenuItem
        '
        Me.FichiersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccéderAuxImagesToolStripMenuItem, Me.AccéderÀLaBaseDeDonnéesToolStripMenuItem})
        Me.FichiersToolStripMenuItem.Name = "FichiersToolStripMenuItem"
        Me.FichiersToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.FichiersToolStripMenuItem.Text = "Fichiers"
        '
        'AccéderAuxImagesToolStripMenuItem
        '
        Me.AccéderAuxImagesToolStripMenuItem.Name = "AccéderAuxImagesToolStripMenuItem"
        Me.AccéderAuxImagesToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.AccéderAuxImagesToolStripMenuItem.Text = "Accéder aux Images"
        '
        'AccéderÀLaBaseDeDonnéesToolStripMenuItem
        '
        Me.AccéderÀLaBaseDeDonnéesToolStripMenuItem.Name = "AccéderÀLaBaseDeDonnéesToolStripMenuItem"
        Me.AccéderÀLaBaseDeDonnéesToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.AccéderÀLaBaseDeDonnéesToolStripMenuItem.Text = "Accéder à la base de données"
        '
        'ParamètresToolStripMenuItem
        '
        Me.ParamètresToolStripMenuItem.Name = "ParamètresToolStripMenuItem"
        Me.ParamètresToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.ParamètresToolStripMenuItem.Text = "Paramètres"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(936, 542)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GB_Fiche)
        Me.Controls.Add(Me.LB_Affichage)
        Me.Controls.Add(Me.GB_Recherche)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KeeWa"
        Me.GB_Recherche.ResumeLayout(False)
        Me.GB_Recherche.PerformLayout()
        Me.GB_Fiche.ResumeLayout(False)
        Me.GB_Utilisateur.ResumeLayout(False)
        Me.GB_Utilisateur.PerformLayout()
        Me.GB_Tag.ResumeLayout(False)
        Me.GB_Tag.PerformLayout()
        Me.GB_Garantie.ResumeLayout(False)
        Me.GB_Garantie.PerformLayout()
        Me.GB_Magasin.ResumeLayout(False)
        Me.GB_Magasin.PerformLayout()
        Me.GB_Marque.ResumeLayout(False)
        Me.GB_Marque.PerformLayout()
        Me.GB_Objet.ResumeLayout(False)
        Me.GB_Objet.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GB_Recherche As GroupBox
    Friend WithEvents BT_Recherche As Button
    Friend WithEvents BT_Effacer_Recherche As Button
    Friend WithEvents LBL_Marque As Label
    Friend WithEvents LBL_TypeObjet As Label
    Friend WithEvents LBL_Nom As Label
    Friend WithEvents LBL_Tags As Label
    Friend WithEvents LBL_Magasin As Label
    Friend WithEvents LB_Affichage As ListBox
    Friend WithEvents GB_Fiche As GroupBox
    Friend WithEvents TB_RMarque As TextBox
    Friend WithEvents TB_RMagasin As TextBox
    Friend WithEvents TB_RType As TextBox
    Friend WithEvents TB_RNom As TextBox
    Friend WithEvents CB_RTags As ComboBox
    Friend WithEvents GB_Objet As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GB_Utilisateur As GroupBox
    Friend WithEvents GB_Tag As GroupBox
    Friend WithEvents LBL_Tag4 As Label
    Friend WithEvents LBL_Tag3 As Label
    Friend WithEvents LBL_Tag2 As Label
    Friend WithEvents LBL_Tag1 As Label
    Friend WithEvents GB_Garantie As GroupBox
    Friend WithEvents GB_Magasin As GroupBox
    Friend WithEvents GB_Marque As GroupBox
    Friend WithEvents LBL_ObPrix As Label
    Friend WithEvents LBL_ObNuméro As Label
    Friend WithEvents LBL_ObNom As Label
    Friend WithEvents LBL_MagSite As LinkLabel
    Friend WithEvents LBL_MagAddresse As Label
    Friend WithEvents LBL_MagNom As Label
    Friend WithEvents LBL_GarDateFin As Label
    Friend WithEvents PB_GarProgression As ProgressBar
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents LBL_GarNomGar As Label
    Friend WithEvents LBL_MagTel As Label
    Friend WithEvents LBL_MagEmail As LinkLabel
    Friend WithEvents LBL_MarQual As Label
    Friend WithEvents LBL_MarTel As LinkLabel
    Friend WithEvents LBL_MarSite As LinkLabel
    Friend WithEvents LBL_MarNom As Label
    Friend WithEvents LBL_ObType As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents LBL_UtilLien As Label
    Friend WithEvents LBL_UtilTel As LinkLabel
    Friend WithEvents LBL_UtilMail As LinkLabel
    Friend WithEvents LBL_UtilTitre As Label
    Friend WithEvents LBL_UtilNom As Label
    Friend WithEvents d As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AjouterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FichiersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParamètresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BT_ModiferGarantie As Button
    Friend WithEvents CB_UtilListe As ComboBox
    Friend WithEvents BT_NewGarantie As Button
    Friend WithEvents AjouterGarantieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterPersonneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterMagasinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterMarqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterTypeDobjetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterTagToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccéderAuxImagesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccéderÀLaBaseDeDonnéesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModiferToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifierPersonneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifierMagasinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifierMarqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifierTypeDobjetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifierTagToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LBL_GarProlonge As Label
End Class
