<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GarantyWindow
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GarantyWindow))
        Me.GB_Utilisateur = New System.Windows.Forms.GroupBox()
        Me.LB_Util = New System.Windows.Forms.ListBox()
        Me.GB_Garantie = New System.Windows.Forms.GroupBox()
        Me.TB_GarNom = New System.Windows.Forms.TextBox()
        Me.LBL_NomGar = New System.Windows.Forms.Label()
        Me.BT_GarSupp = New System.Windows.Forms.Button()
        Me.BT_GarSauv = New System.Windows.Forms.Button()
        Me.BT_AjoutImage = New System.Windows.Forms.Button()
        Me.LBL_Mois = New System.Windows.Forms.Label()
        Me.NUD_Mois = New System.Windows.Forms.NumericUpDown()
        Me.CB_Prolongeable = New System.Windows.Forms.CheckBox()
        Me.LBL_Durée = New System.Windows.Forms.Label()
        Me.CB_NomGarantie = New System.Windows.Forms.ComboBox()
        Me.BT_GarAdd = New System.Windows.Forms.Button()
        Me.CB_Prolong = New System.Windows.Forms.CheckBox()
        Me.GB_Date = New System.Windows.Forms.GroupBox()
        Me.MC_Date = New System.Windows.Forms.MonthCalendar()
        Me.LBL_NomGarantie = New System.Windows.Forms.Label()
        Me.GB_Objet = New System.Windows.Forms.GroupBox()
        Me.BT_Magasin = New System.Windows.Forms.Button()
        Me.BT_Marque = New System.Windows.Forms.Button()
        Me.BT_Type = New System.Windows.Forms.Button()
        Me.TB_Nom = New System.Windows.Forms.TextBox()
        Me.TB_Numéro = New System.Windows.Forms.TextBox()
        Me.TB_Prix = New System.Windows.Forms.TextBox()
        Me.CB_Type = New System.Windows.Forms.ComboBox()
        Me.CB_Marque = New System.Windows.Forms.ComboBox()
        Me.CB_Magasin = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GB_Prop = New System.Windows.Forms.GroupBox()
        Me.LB_Prop = New System.Windows.Forms.ListBox()
        Me.GB_Tags = New System.Windows.Forms.GroupBox()
        Me.LB_Tags = New System.Windows.Forms.ListBox()
        Me.BT_Sauvegarder = New System.Windows.Forms.Button()
        Me.OFP_Image = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AjouterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.BT_Supp = New System.Windows.Forms.Button()
        Me.DataBaseDataSet = New KeeWa.DataBaseDataSet()
        Me.DataBaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GB_Utilisateur.SuspendLayout()
        Me.GB_Garantie.SuspendLayout()
        CType(Me.NUD_Mois, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Date.SuspendLayout()
        Me.GB_Objet.SuspendLayout()
        Me.GB_Prop.SuspendLayout()
        Me.GB_Tags.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataBaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB_Utilisateur
        '
        Me.GB_Utilisateur.Controls.Add(Me.LB_Util)
        Me.GB_Utilisateur.Location = New System.Drawing.Point(244, 333)
        Me.GB_Utilisateur.Margin = New System.Windows.Forms.Padding(6)
        Me.GB_Utilisateur.Name = "GB_Utilisateur"
        Me.GB_Utilisateur.Padding = New System.Windows.Forms.Padding(6)
        Me.GB_Utilisateur.Size = New System.Drawing.Size(221, 268)
        Me.GB_Utilisateur.TabIndex = 5
        Me.GB_Utilisateur.TabStop = False
        Me.GB_Utilisateur.Text = "Utilisateurs"
        '
        'LB_Util
        '
        Me.LB_Util.FormattingEnabled = True
        Me.LB_Util.ItemHeight = 25
        Me.LB_Util.Location = New System.Drawing.Point(9, 28)
        Me.LB_Util.Name = "LB_Util"
        Me.LB_Util.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.LB_Util.Size = New System.Drawing.Size(203, 229)
        Me.LB_Util.Sorted = True
        Me.LB_Util.TabIndex = 10
        '
        'GB_Garantie
        '
        Me.GB_Garantie.Controls.Add(Me.TB_GarNom)
        Me.GB_Garantie.Controls.Add(Me.LBL_NomGar)
        Me.GB_Garantie.Controls.Add(Me.BT_GarSupp)
        Me.GB_Garantie.Controls.Add(Me.BT_GarSauv)
        Me.GB_Garantie.Controls.Add(Me.BT_AjoutImage)
        Me.GB_Garantie.Controls.Add(Me.LBL_Mois)
        Me.GB_Garantie.Controls.Add(Me.NUD_Mois)
        Me.GB_Garantie.Controls.Add(Me.CB_Prolongeable)
        Me.GB_Garantie.Controls.Add(Me.LBL_Durée)
        Me.GB_Garantie.Controls.Add(Me.CB_NomGarantie)
        Me.GB_Garantie.Controls.Add(Me.BT_GarAdd)
        Me.GB_Garantie.Controls.Add(Me.CB_Prolong)
        Me.GB_Garantie.Controls.Add(Me.GB_Date)
        Me.GB_Garantie.Controls.Add(Me.LBL_NomGarantie)
        Me.GB_Garantie.Location = New System.Drawing.Point(434, 27)
        Me.GB_Garantie.Margin = New System.Windows.Forms.Padding(6)
        Me.GB_Garantie.Name = "GB_Garantie"
        Me.GB_Garantie.Padding = New System.Windows.Forms.Padding(6)
        Me.GB_Garantie.Size = New System.Drawing.Size(500, 315)
        Me.GB_Garantie.TabIndex = 3
        Me.GB_Garantie.TabStop = False
        Me.GB_Garantie.Text = "Garanties"
        '
        'TB_GarNom
        '
        Me.TB_GarNom.Location = New System.Drawing.Point(82, 79)
        Me.TB_GarNom.Name = "TB_GarNom"
        Me.TB_GarNom.Size = New System.Drawing.Size(174, 30)
        Me.TB_GarNom.TabIndex = 28
        '
        'LBL_NomGar
        '
        Me.LBL_NomGar.AutoSize = True
        Me.LBL_NomGar.Location = New System.Drawing.Point(12, 79)
        Me.LBL_NomGar.Name = "LBL_NomGar"
        Me.LBL_NomGar.Size = New System.Drawing.Size(64, 25)
        Me.LBL_NomGar.TabIndex = 27
        Me.LBL_NomGar.Text = "Nom :"
        '
        'BT_GarSupp
        '
        Me.BT_GarSupp.Location = New System.Drawing.Point(274, 259)
        Me.BT_GarSupp.Name = "BT_GarSupp"
        Me.BT_GarSupp.Size = New System.Drawing.Size(217, 38)
        Me.BT_GarSupp.TabIndex = 26
        Me.BT_GarSupp.Text = "Supprimer"
        Me.BT_GarSupp.UseVisualStyleBackColor = True
        '
        'BT_GarSauv
        '
        Me.BT_GarSauv.Location = New System.Drawing.Point(274, 215)
        Me.BT_GarSauv.Name = "BT_GarSauv"
        Me.BT_GarSauv.Size = New System.Drawing.Size(217, 38)
        Me.BT_GarSauv.TabIndex = 25
        Me.BT_GarSauv.Text = "Sauvegarder"
        Me.BT_GarSauv.UseVisualStyleBackColor = True
        '
        'BT_AjoutImage
        '
        Me.BT_AjoutImage.Location = New System.Drawing.Point(274, 171)
        Me.BT_AjoutImage.Name = "BT_AjoutImage"
        Me.BT_AjoutImage.Size = New System.Drawing.Size(215, 38)
        Me.BT_AjoutImage.TabIndex = 14
        Me.BT_AjoutImage.Text = "Ajout/Changer Image"
        Me.BT_AjoutImage.UseVisualStyleBackColor = True
        '
        'LBL_Mois
        '
        Me.LBL_Mois.AutoSize = True
        Me.LBL_Mois.Location = New System.Drawing.Point(419, 139)
        Me.LBL_Mois.Name = "LBL_Mois"
        Me.LBL_Mois.Size = New System.Drawing.Size(53, 25)
        Me.LBL_Mois.TabIndex = 24
        Me.LBL_Mois.Text = "mois"
        '
        'NUD_Mois
        '
        Me.NUD_Mois.Location = New System.Drawing.Point(357, 137)
        Me.NUD_Mois.Name = "NUD_Mois"
        Me.NUD_Mois.Size = New System.Drawing.Size(56, 30)
        Me.NUD_Mois.TabIndex = 23
        '
        'CB_Prolongeable
        '
        Me.CB_Prolongeable.AutoSize = True
        Me.CB_Prolongeable.Location = New System.Drawing.Point(274, 107)
        Me.CB_Prolongeable.Name = "CB_Prolongeable"
        Me.CB_Prolongeable.Size = New System.Drawing.Size(223, 29)
        Me.CB_Prolongeable.TabIndex = 22
        Me.CB_Prolongeable.Text = "Garantie prolongeable"
        Me.CB_Prolongeable.UseVisualStyleBackColor = True
        '
        'LBL_Durée
        '
        Me.LBL_Durée.AutoSize = True
        Me.LBL_Durée.Location = New System.Drawing.Point(275, 139)
        Me.LBL_Durée.Name = "LBL_Durée"
        Me.LBL_Durée.Size = New System.Drawing.Size(76, 25)
        Me.LBL_Durée.TabIndex = 21
        Me.LBL_Durée.Text = "Durée :"
        '
        'CB_NomGarantie
        '
        Me.CB_NomGarantie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_NomGarantie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_NomGarantie.FormattingEnabled = True
        Me.CB_NomGarantie.Location = New System.Drawing.Point(208, 35)
        Me.CB_NomGarantie.Name = "CB_NomGarantie"
        Me.CB_NomGarantie.Size = New System.Drawing.Size(245, 33)
        Me.CB_NomGarantie.TabIndex = 7
        '
        'BT_GarAdd
        '
        Me.BT_GarAdd.Location = New System.Drawing.Point(459, 38)
        Me.BT_GarAdd.Name = "BT_GarAdd"
        Me.BT_GarAdd.Size = New System.Drawing.Size(30, 30)
        Me.BT_GarAdd.TabIndex = 8
        Me.BT_GarAdd.TabStop = False
        Me.BT_GarAdd.Text = "+"
        Me.BT_GarAdd.UseVisualStyleBackColor = True
        '
        'CB_Prolong
        '
        Me.CB_Prolong.AutoSize = True
        Me.CB_Prolong.Location = New System.Drawing.Point(274, 75)
        Me.CB_Prolong.Name = "CB_Prolong"
        Me.CB_Prolong.Size = New System.Drawing.Size(197, 29)
        Me.CB_Prolong.TabIndex = 8
        Me.CB_Prolong.Text = "Garantie prolongée"
        Me.CB_Prolong.UseVisualStyleBackColor = True
        '
        'GB_Date
        '
        Me.GB_Date.Controls.Add(Me.MC_Date)
        Me.GB_Date.Location = New System.Drawing.Point(17, 115)
        Me.GB_Date.Name = "GB_Date"
        Me.GB_Date.Size = New System.Drawing.Size(251, 198)
        Me.GB_Date.TabIndex = 15
        Me.GB_Date.TabStop = False
        Me.GB_Date.Text = "Date de début de garantie"
        '
        'MC_Date
        '
        Me.MC_Date.Location = New System.Drawing.Point(12, 24)
        Me.MC_Date.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.MC_Date.MinDate = New Date(1970, 1, 1, 0, 0, 0, 0)
        Me.MC_Date.Name = "MC_Date"
        Me.MC_Date.TabIndex = 9
        '
        'LBL_NomGarantie
        '
        Me.LBL_NomGarantie.AutoSize = True
        Me.LBL_NomGarantie.Location = New System.Drawing.Point(12, 38)
        Me.LBL_NomGarantie.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LBL_NomGarantie.Name = "LBL_NomGarantie"
        Me.LBL_NomGarantie.Size = New System.Drawing.Size(187, 25)
        Me.LBL_NomGarantie.TabIndex = 0
        Me.LBL_NomGarantie.Text = "Garantie à Modifier :"
        '
        'GB_Objet
        '
        Me.GB_Objet.Controls.Add(Me.BT_Magasin)
        Me.GB_Objet.Controls.Add(Me.BT_Marque)
        Me.GB_Objet.Controls.Add(Me.BT_Type)
        Me.GB_Objet.Controls.Add(Me.TB_Nom)
        Me.GB_Objet.Controls.Add(Me.TB_Numéro)
        Me.GB_Objet.Controls.Add(Me.TB_Prix)
        Me.GB_Objet.Controls.Add(Me.CB_Type)
        Me.GB_Objet.Controls.Add(Me.CB_Marque)
        Me.GB_Objet.Controls.Add(Me.CB_Magasin)
        Me.GB_Objet.Controls.Add(Me.Label5)
        Me.GB_Objet.Controls.Add(Me.Label4)
        Me.GB_Objet.Controls.Add(Me.Label21)
        Me.GB_Objet.Controls.Add(Me.Label3)
        Me.GB_Objet.Controls.Add(Me.Label2)
        Me.GB_Objet.Controls.Add(Me.Label1)
        Me.GB_Objet.Location = New System.Drawing.Point(10, 25)
        Me.GB_Objet.Margin = New System.Windows.Forms.Padding(1)
        Me.GB_Objet.Name = "GB_Objet"
        Me.GB_Objet.Padding = New System.Windows.Forms.Padding(6)
        Me.GB_Objet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GB_Objet.Size = New System.Drawing.Size(407, 299)
        Me.GB_Objet.TabIndex = 0
        Me.GB_Objet.TabStop = False
        Me.GB_Objet.Text = "Objet"
        '
        'BT_Magasin
        '
        Me.BT_Magasin.Location = New System.Drawing.Point(368, 241)
        Me.BT_Magasin.Name = "BT_Magasin"
        Me.BT_Magasin.Size = New System.Drawing.Size(30, 30)
        Me.BT_Magasin.TabIndex = 18
        Me.BT_Magasin.TabStop = False
        Me.BT_Magasin.Text = "+"
        Me.BT_Magasin.UseVisualStyleBackColor = True
        '
        'BT_Marque
        '
        Me.BT_Marque.Location = New System.Drawing.Point(368, 197)
        Me.BT_Marque.Name = "BT_Marque"
        Me.BT_Marque.Size = New System.Drawing.Size(30, 30)
        Me.BT_Marque.TabIndex = 17
        Me.BT_Marque.TabStop = False
        Me.BT_Marque.Text = "+"
        Me.BT_Marque.UseVisualStyleBackColor = True
        '
        'BT_Type
        '
        Me.BT_Type.Location = New System.Drawing.Point(368, 154)
        Me.BT_Type.Name = "BT_Type"
        Me.BT_Type.Size = New System.Drawing.Size(30, 30)
        Me.BT_Type.TabIndex = 0
        Me.BT_Type.TabStop = False
        Me.BT_Type.Text = "+"
        Me.BT_Type.UseVisualStyleBackColor = True
        '
        'TB_Nom
        '
        Me.TB_Nom.Location = New System.Drawing.Point(180, 35)
        Me.TB_Nom.Name = "TB_Nom"
        Me.TB_Nom.Size = New System.Drawing.Size(218, 30)
        Me.TB_Nom.TabIndex = 1
        '
        'TB_Numéro
        '
        Me.TB_Numéro.Location = New System.Drawing.Point(180, 74)
        Me.TB_Numéro.Name = "TB_Numéro"
        Me.TB_Numéro.Size = New System.Drawing.Size(218, 30)
        Me.TB_Numéro.TabIndex = 2
        '
        'TB_Prix
        '
        Me.TB_Prix.Location = New System.Drawing.Point(180, 112)
        Me.TB_Prix.Name = "TB_Prix"
        Me.TB_Prix.Size = New System.Drawing.Size(218, 30)
        Me.TB_Prix.TabIndex = 3
        '
        'CB_Type
        '
        Me.CB_Type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_Type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_Type.FormattingEnabled = True
        Me.CB_Type.Location = New System.Drawing.Point(180, 151)
        Me.CB_Type.Name = "CB_Type"
        Me.CB_Type.Size = New System.Drawing.Size(182, 33)
        Me.CB_Type.Sorted = True
        Me.CB_Type.TabIndex = 4
        '
        'CB_Marque
        '
        Me.CB_Marque.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_Marque.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_Marque.FormattingEnabled = True
        Me.CB_Marque.Location = New System.Drawing.Point(180, 194)
        Me.CB_Marque.Name = "CB_Marque"
        Me.CB_Marque.Size = New System.Drawing.Size(182, 33)
        Me.CB_Marque.Sorted = True
        Me.CB_Marque.TabIndex = 5
        '
        'CB_Magasin
        '
        Me.CB_Magasin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_Magasin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_Magasin.DropDownWidth = 186
        Me.CB_Magasin.FormattingEnabled = True
        Me.CB_Magasin.Location = New System.Drawing.Point(180, 236)
        Me.CB_Magasin.Name = "CB_Magasin"
        Me.CB_Magasin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CB_Magasin.Size = New System.Drawing.Size(182, 33)
        Me.CB_Magasin.Sorted = True
        Me.CB_Magasin.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 244)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Magasin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 197)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Marque"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(12, 154)
        Me.Label21.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(130, 25)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "Type d'objet :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 115)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Prix :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numéro :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom :"
        '
        'GB_Prop
        '
        Me.GB_Prop.Controls.Add(Me.LB_Prop)
        Me.GB_Prop.Location = New System.Drawing.Point(11, 333)
        Me.GB_Prop.Name = "GB_Prop"
        Me.GB_Prop.Size = New System.Drawing.Size(231, 268)
        Me.GB_Prop.TabIndex = 6
        Me.GB_Prop.TabStop = False
        Me.GB_Prop.Text = "Propriétaire"
        '
        'LB_Prop
        '
        Me.LB_Prop.FormattingEnabled = True
        Me.LB_Prop.ItemHeight = 25
        Me.LB_Prop.Location = New System.Drawing.Point(6, 29)
        Me.LB_Prop.Name = "LB_Prop"
        Me.LB_Prop.Size = New System.Drawing.Size(218, 229)
        Me.LB_Prop.Sorted = True
        Me.LB_Prop.TabIndex = 9
        '
        'GB_Tags
        '
        Me.GB_Tags.Controls.Add(Me.LB_Tags)
        Me.GB_Tags.Location = New System.Drawing.Point(474, 351)
        Me.GB_Tags.Name = "GB_Tags"
        Me.GB_Tags.Size = New System.Drawing.Size(200, 240)
        Me.GB_Tags.TabIndex = 11
        Me.GB_Tags.TabStop = False
        Me.GB_Tags.Text = "Tags"
        '
        'LB_Tags
        '
        Me.LB_Tags.FormattingEnabled = True
        Me.LB_Tags.ItemHeight = 25
        Me.LB_Tags.Location = New System.Drawing.Point(6, 29)
        Me.LB_Tags.Name = "LB_Tags"
        Me.LB_Tags.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.LB_Tags.Size = New System.Drawing.Size(188, 204)
        Me.LB_Tags.Sorted = True
        Me.LB_Tags.TabIndex = 11
        '
        'BT_Sauvegarder
        '
        Me.BT_Sauvegarder.Location = New System.Drawing.Point(728, 479)
        Me.BT_Sauvegarder.Name = "BT_Sauvegarder"
        Me.BT_Sauvegarder.Size = New System.Drawing.Size(177, 44)
        Me.BT_Sauvegarder.TabIndex = 13
        Me.BT_Sauvegarder.Text = "Sauvegarder"
        Me.BT_Sauvegarder.UseVisualStyleBackColor = True
        '
        'OFP_Image
        '
        Me.OFP_Image.AddExtension = False
        Me.OFP_Image.FileName = "OpenFileDialog1"
        Me.OFP_Image.Title = "Ajout d'image"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterToolStripMenuItem, Me.ModiferToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(943, 28)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AjouterToolStripMenuItem
        '
        Me.AjouterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterPersonneToolStripMenuItem, Me.AjouterMagasinToolStripMenuItem, Me.AjouterMarqueToolStripMenuItem, Me.AjouterTypeDobjetToolStripMenuItem, Me.AjouterTagToolStripMenuItem})
        Me.AjouterToolStripMenuItem.Name = "AjouterToolStripMenuItem"
        Me.AjouterToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.AjouterToolStripMenuItem.Text = "Ajouter"
        '
        'AjouterPersonneToolStripMenuItem
        '
        Me.AjouterPersonneToolStripMenuItem.Name = "AjouterPersonneToolStripMenuItem"
        Me.AjouterPersonneToolStripMenuItem.Size = New System.Drawing.Size(213, 24)
        Me.AjouterPersonneToolStripMenuItem.Text = "Ajouter Personne"
        '
        'AjouterMagasinToolStripMenuItem
        '
        Me.AjouterMagasinToolStripMenuItem.Name = "AjouterMagasinToolStripMenuItem"
        Me.AjouterMagasinToolStripMenuItem.Size = New System.Drawing.Size(213, 24)
        Me.AjouterMagasinToolStripMenuItem.Text = "Ajouter Magasin"
        '
        'AjouterMarqueToolStripMenuItem
        '
        Me.AjouterMarqueToolStripMenuItem.Name = "AjouterMarqueToolStripMenuItem"
        Me.AjouterMarqueToolStripMenuItem.Size = New System.Drawing.Size(213, 24)
        Me.AjouterMarqueToolStripMenuItem.Text = "Ajouter Marque"
        '
        'AjouterTypeDobjetToolStripMenuItem
        '
        Me.AjouterTypeDobjetToolStripMenuItem.Name = "AjouterTypeDobjetToolStripMenuItem"
        Me.AjouterTypeDobjetToolStripMenuItem.Size = New System.Drawing.Size(213, 24)
        Me.AjouterTypeDobjetToolStripMenuItem.Text = "Ajouter Type d'objet"
        '
        'AjouterTagToolStripMenuItem
        '
        Me.AjouterTagToolStripMenuItem.Name = "AjouterTagToolStripMenuItem"
        Me.AjouterTagToolStripMenuItem.Size = New System.Drawing.Size(213, 24)
        Me.AjouterTagToolStripMenuItem.Text = "Ajouter Tag"
        '
        'ModiferToolStripMenuItem
        '
        Me.ModiferToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModifierPersonneToolStripMenuItem, Me.ModifierMagasinToolStripMenuItem, Me.ModifierMarqueToolStripMenuItem, Me.ModifierTypeDobjetToolStripMenuItem, Me.ModifierTagToolStripMenuItem})
        Me.ModiferToolStripMenuItem.Name = "ModiferToolStripMenuItem"
        Me.ModiferToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.ModiferToolStripMenuItem.Text = "Modifier"
        '
        'ModifierPersonneToolStripMenuItem
        '
        Me.ModifierPersonneToolStripMenuItem.Name = "ModifierPersonneToolStripMenuItem"
        Me.ModifierPersonneToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.ModifierPersonneToolStripMenuItem.Text = "Modifier Personne"
        '
        'ModifierMagasinToolStripMenuItem
        '
        Me.ModifierMagasinToolStripMenuItem.Name = "ModifierMagasinToolStripMenuItem"
        Me.ModifierMagasinToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.ModifierMagasinToolStripMenuItem.Text = "Modifier Magasin"
        '
        'ModifierMarqueToolStripMenuItem
        '
        Me.ModifierMarqueToolStripMenuItem.Name = "ModifierMarqueToolStripMenuItem"
        Me.ModifierMarqueToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.ModifierMarqueToolStripMenuItem.Text = "Modifier Marque"
        '
        'ModifierTypeDobjetToolStripMenuItem
        '
        Me.ModifierTypeDobjetToolStripMenuItem.Name = "ModifierTypeDobjetToolStripMenuItem"
        Me.ModifierTypeDobjetToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.ModifierTypeDobjetToolStripMenuItem.Text = "Modifier Type d'objet"
        '
        'ModifierTagToolStripMenuItem
        '
        Me.ModifierTagToolStripMenuItem.Name = "ModifierTagToolStripMenuItem"
        Me.ModifierTagToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.ModifierTagToolStripMenuItem.Text = "Modifier Tag"
        '
        'BT_Supp
        '
        Me.BT_Supp.Location = New System.Drawing.Point(729, 410)
        Me.BT_Supp.Name = "BT_Supp"
        Me.BT_Supp.Size = New System.Drawing.Size(177, 44)
        Me.BT_Supp.TabIndex = 12
        Me.BT_Supp.Text = "Supprimer"
        Me.BT_Supp.UseVisualStyleBackColor = True
        '
        'DataBaseDataSet
        '
        Me.DataBaseDataSet.DataSetName = "DataBaseDataSet"
        Me.DataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataBaseDataSetBindingSource
        '
        Me.DataBaseDataSetBindingSource.DataSource = Me.DataBaseDataSet
        Me.DataBaseDataSetBindingSource.Position = 0
        '
        'GarantyWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 611)
        Me.Controls.Add(Me.GB_Garantie)
        Me.Controls.Add(Me.BT_Supp)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.BT_Sauvegarder)
        Me.Controls.Add(Me.GB_Tags)
        Me.Controls.Add(Me.GB_Prop)
        Me.Controls.Add(Me.GB_Utilisateur)
        Me.Controls.Add(Me.GB_Objet)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.Name = "GarantyWindow"
        Me.Text = "Garantie"
        Me.GB_Utilisateur.ResumeLayout(False)
        Me.GB_Garantie.ResumeLayout(False)
        Me.GB_Garantie.PerformLayout()
        CType(Me.NUD_Mois, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Date.ResumeLayout(False)
        Me.GB_Objet.ResumeLayout(False)
        Me.GB_Objet.PerformLayout()
        Me.GB_Prop.ResumeLayout(False)
        Me.GB_Tags.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataBaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GB_Utilisateur As GroupBox
    Friend WithEvents GB_Garantie As GroupBox
    Friend WithEvents LBL_NomGarantie As Label
    Friend WithEvents GB_Objet As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MC_Date As MonthCalendar
    Friend WithEvents LB_Util As ListBox
    Friend WithEvents GB_Prop As GroupBox
    Friend WithEvents LB_Prop As ListBox
    Friend WithEvents GB_Date As GroupBox
    Friend WithEvents CB_Prolong As CheckBox
    Friend WithEvents BT_Magasin As Button
    Friend WithEvents BT_Marque As Button
    Friend WithEvents BT_Type As Button
    Friend WithEvents TB_Nom As TextBox
    Friend WithEvents TB_Numéro As TextBox
    Friend WithEvents TB_Prix As TextBox
    Friend WithEvents CB_Type As ComboBox
    Friend WithEvents CB_Marque As ComboBox
    Friend WithEvents CB_Magasin As ComboBox
    Friend WithEvents GB_Tags As GroupBox
    Friend WithEvents LB_Tags As ListBox
    Friend WithEvents BT_Sauvegarder As Button
    Friend WithEvents BT_AjoutImage As Button
    Friend WithEvents OFP_Image As OpenFileDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AjouterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterPersonneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterMagasinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterMarqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterTypeDobjetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterTagToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModiferToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifierPersonneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifierMagasinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifierMarqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifierTypeDobjetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifierTagToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CB_Prolongeable As CheckBox
    Friend WithEvents LBL_Durée As Label
    Friend WithEvents CB_NomGarantie As ComboBox
    Friend WithEvents BT_GarAdd As Button
    Friend WithEvents LBL_Mois As Label
    Friend WithEvents NUD_Mois As NumericUpDown
    Protected WithEvents Label1 As Label
    Friend WithEvents BT_GarSupp As Button
    Friend WithEvents BT_GarSauv As Button
    Friend WithEvents LBL_NomGar As Label
    Friend WithEvents TB_GarNom As TextBox
    Friend WithEvents BT_Supp As Button
    Friend WithEvents DataBaseDataSetBindingSource As BindingSource
    Friend WithEvents DataBaseDataSet As DataBaseDataSet
End Class
