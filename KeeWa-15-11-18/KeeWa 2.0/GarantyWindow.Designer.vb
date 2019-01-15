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
        Me.GB_Utilisateur = New System.Windows.Forms.GroupBox()
        Me.LB_Util = New System.Windows.Forms.ListBox()
        Me.GB_Garantie = New System.Windows.Forms.GroupBox()
        Me.TB_NomGarantie = New System.Windows.Forms.TextBox()
        Me.CB_Prolong = New System.Windows.Forms.CheckBox()
        Me.GB_Date = New System.Windows.Forms.GroupBox()
        Me.MC_Date = New System.Windows.Forms.MonthCalendar()
        Me.Label17 = New System.Windows.Forms.Label()
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
        Me.BT_AjoutImage = New System.Windows.Forms.Button()
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
        Me.GB_Utilisateur.SuspendLayout()
        Me.GB_Garantie.SuspendLayout()
        Me.GB_Date.SuspendLayout()
        Me.GB_Objet.SuspendLayout()
        Me.GB_Prop.SuspendLayout()
        Me.GB_Tags.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_Utilisateur
        '
        Me.GB_Utilisateur.Controls.Add(Me.LB_Util)
        Me.GB_Utilisateur.Location = New System.Drawing.Point(212, 333)
        Me.GB_Utilisateur.Margin = New System.Windows.Forms.Padding(6)
        Me.GB_Utilisateur.Name = "GB_Utilisateur"
        Me.GB_Utilisateur.Padding = New System.Windows.Forms.Padding(6)
        Me.GB_Utilisateur.Size = New System.Drawing.Size(206, 268)
        Me.GB_Utilisateur.TabIndex = 5
        Me.GB_Utilisateur.TabStop = False
        Me.GB_Utilisateur.Text = "Utilisateurs"
        '
        'LB_Util
        '
        Me.LB_Util.FormattingEnabled = True
        Me.LB_Util.ItemHeight = 25
        Me.LB_Util.Items.AddRange(New Object() {"Ajouter un personne", "Tom", "Jean", "Yve", "Loic", "Sven", "Owen", "Steve", "Jean", "Phil", "Gui", "Aume", "Diégo", "Victor", "Elle"})
        Me.LB_Util.Location = New System.Drawing.Point(9, 28)
        Me.LB_Util.Name = "LB_Util"
        Me.LB_Util.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.LB_Util.Size = New System.Drawing.Size(188, 229)
        Me.LB_Util.TabIndex = 12
        '
        'GB_Garantie
        '
        Me.GB_Garantie.Controls.Add(Me.TB_NomGarantie)
        Me.GB_Garantie.Controls.Add(Me.CB_Prolong)
        Me.GB_Garantie.Controls.Add(Me.GB_Date)
        Me.GB_Garantie.Controls.Add(Me.Label17)
        Me.GB_Garantie.Location = New System.Drawing.Point(434, 27)
        Me.GB_Garantie.Margin = New System.Windows.Forms.Padding(6)
        Me.GB_Garantie.Name = "GB_Garantie"
        Me.GB_Garantie.Padding = New System.Windows.Forms.Padding(6)
        Me.GB_Garantie.Size = New System.Drawing.Size(422, 322)
        Me.GB_Garantie.TabIndex = 3
        Me.GB_Garantie.TabStop = False
        Me.GB_Garantie.Text = "Garantie"
        '
        'TB_NomGarantie
        '
        Me.TB_NomGarantie.Location = New System.Drawing.Point(211, 35)
        Me.TB_NomGarantie.Name = "TB_NomGarantie"
        Me.TB_NomGarantie.Size = New System.Drawing.Size(202, 30)
        Me.TB_NomGarantie.TabIndex = 7
        '
        'CB_Prolong
        '
        Me.CB_Prolong.AutoSize = True
        Me.CB_Prolong.Location = New System.Drawing.Point(17, 71)
        Me.CB_Prolong.Name = "CB_Prolong"
        Me.CB_Prolong.Size = New System.Drawing.Size(197, 29)
        Me.CB_Prolong.TabIndex = 8
        Me.CB_Prolong.Text = "Garantie prolongée"
        Me.CB_Prolong.UseVisualStyleBackColor = True
        '
        'GB_Date
        '
        Me.GB_Date.Controls.Add(Me.MC_Date)
        Me.GB_Date.Location = New System.Drawing.Point(92, 106)
        Me.GB_Date.Name = "GB_Date"
        Me.GB_Date.Size = New System.Drawing.Size(251, 206)
        Me.GB_Date.TabIndex = 15
        Me.GB_Date.TabStop = False
        Me.GB_Date.Text = "Date d'achat"
        '
        'MC_Date
        '
        Me.MC_Date.Location = New System.Drawing.Point(12, 33)
        Me.MC_Date.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.MC_Date.MinDate = New Date(1970, 1, 1, 0, 0, 0, 0)
        Me.MC_Date.Name = "MC_Date"
        Me.MC_Date.TabIndex = 9
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 38)
        Me.Label17.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(190, 25)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Nom de la Garantie :"
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
        Me.CB_Type.FormattingEnabled = True
        Me.CB_Type.Location = New System.Drawing.Point(180, 151)
        Me.CB_Type.Name = "CB_Type"
        Me.CB_Type.Size = New System.Drawing.Size(182, 33)
        Me.CB_Type.TabIndex = 4
        '
        'CB_Marque
        '
        Me.CB_Marque.FormattingEnabled = True
        Me.CB_Marque.Location = New System.Drawing.Point(180, 194)
        Me.CB_Marque.Name = "CB_Marque"
        Me.CB_Marque.Size = New System.Drawing.Size(182, 33)
        Me.CB_Marque.TabIndex = 5
        '
        'CB_Magasin
        '
        Me.CB_Magasin.FormattingEnabled = True
        Me.CB_Magasin.Location = New System.Drawing.Point(180, 236)
        Me.CB_Magasin.Name = "CB_Magasin"
        Me.CB_Magasin.Size = New System.Drawing.Size(182, 33)
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
        Me.GB_Prop.Size = New System.Drawing.Size(201, 268)
        Me.GB_Prop.TabIndex = 6
        Me.GB_Prop.TabStop = False
        Me.GB_Prop.Text = "Propriétaire"
        '
        'LB_Prop
        '
        Me.LB_Prop.FormattingEnabled = True
        Me.LB_Prop.ItemHeight = 25
        Me.LB_Prop.Items.AddRange(New Object() {"Ajouter une personne", "Tom", "Jean", "Yve", "Loic", "Sven", "Owen"})
        Me.LB_Prop.Location = New System.Drawing.Point(6, 29)
        Me.LB_Prop.Name = "LB_Prop"
        Me.LB_Prop.Size = New System.Drawing.Size(188, 229)
        Me.LB_Prop.TabIndex = 11
        '
        'GB_Tags
        '
        Me.GB_Tags.Controls.Add(Me.LB_Tags)
        Me.GB_Tags.Location = New System.Drawing.Point(427, 358)
        Me.GB_Tags.Name = "GB_Tags"
        Me.GB_Tags.Size = New System.Drawing.Size(200, 243)
        Me.GB_Tags.TabIndex = 11
        Me.GB_Tags.TabStop = False
        Me.GB_Tags.Text = "Tags"
        '
        'LB_Tags
        '
        Me.LB_Tags.FormattingEnabled = True
        Me.LB_Tags.ItemHeight = 25
        Me.LB_Tags.Items.AddRange(New Object() {"Ajouter un Tag", "Chanmre", "Cher", "Rouge", "Télé", "Jardin"})
        Me.LB_Tags.Location = New System.Drawing.Point(6, 29)
        Me.LB_Tags.Name = "LB_Tags"
        Me.LB_Tags.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.LB_Tags.Size = New System.Drawing.Size(188, 204)
        Me.LB_Tags.TabIndex = 13
        '
        'BT_Sauvegarder
        '
        Me.BT_Sauvegarder.Location = New System.Drawing.Point(661, 502)
        Me.BT_Sauvegarder.Name = "BT_Sauvegarder"
        Me.BT_Sauvegarder.Size = New System.Drawing.Size(177, 44)
        Me.BT_Sauvegarder.TabIndex = 15
        Me.BT_Sauvegarder.Text = "Sauvegarder"
        Me.BT_Sauvegarder.UseVisualStyleBackColor = True
        '
        'BT_AjoutImage
        '
        Me.BT_AjoutImage.Location = New System.Drawing.Point(661, 434)
        Me.BT_AjoutImage.Name = "BT_AjoutImage"
        Me.BT_AjoutImage.Size = New System.Drawing.Size(177, 38)
        Me.BT_AjoutImage.TabIndex = 14
        Me.BT_AjoutImage.Text = "Ajout Image"
        Me.BT_AjoutImage.UseVisualStyleBackColor = True
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
        Me.MenuStrip1.Size = New System.Drawing.Size(880, 28)
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
        Me.ModiferToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.ModiferToolStripMenuItem.Text = "Modifer"
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
        'GarantyWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 611)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.BT_AjoutImage)
        Me.Controls.Add(Me.BT_Sauvegarder)
        Me.Controls.Add(Me.GB_Tags)
        Me.Controls.Add(Me.GB_Prop)
        Me.Controls.Add(Me.GB_Utilisateur)
        Me.Controls.Add(Me.GB_Objet)
        Me.Controls.Add(Me.GB_Garantie)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.Name = "GarantyWindow"
        Me.Text = "GarantyWindow"
        Me.GB_Utilisateur.ResumeLayout(False)
        Me.GB_Garantie.ResumeLayout(False)
        Me.GB_Garantie.PerformLayout()
        Me.GB_Date.ResumeLayout(False)
        Me.GB_Objet.ResumeLayout(False)
        Me.GB_Objet.PerformLayout()
        Me.GB_Prop.ResumeLayout(False)
        Me.GB_Tags.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GB_Utilisateur As GroupBox
    Friend WithEvents GB_Garantie As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents GB_Objet As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MC_Date As MonthCalendar
    Friend WithEvents LB_Util As ListBox
    Friend WithEvents GB_Prop As GroupBox
    Friend WithEvents LB_Prop As ListBox
    Friend WithEvents GB_Date As GroupBox
    Friend WithEvents CB_Prolong As CheckBox
    Friend WithEvents TB_NomGarantie As TextBox
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
End Class
