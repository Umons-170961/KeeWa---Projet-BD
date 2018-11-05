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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AjouterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterGarantieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterMagasinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterTypeDobjetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterMarqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterTagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierGarantieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierMagasinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierTypeDobjetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FichiersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccéderAuDossierDesGarantiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccéderÀLaBaseDeDonnéesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParamètresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GB_Recherche = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BT_Effacer_Recherche = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LBL_Tags = New System.Windows.Forms.Label()
        Me.LBL_Magasin = New System.Windows.Forms.Label()
        Me.BT_Recherche = New System.Windows.Forms.Button()
        Me.LBL_Marque = New System.Windows.Forms.Label()
        Me.LBL_TypeObjet = New System.Windows.Forms.Label()
        Me.LBL_Nom = New System.Windows.Forms.Label()
        Me.LB_Affichage = New System.Windows.Forms.ListBox()
        Me.GB_Fiche = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GB_Recherche.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterToolStripMenuItem, Me.ModifierToolStripMenuItem, Me.FichiersToolStripMenuItem, Me.ParamètresToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AjouterToolStripMenuItem
        '
        Me.AjouterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterGarantieToolStripMenuItem, Me.AjouterMagasinToolStripMenuItem, Me.AjouterTypeDobjetToolStripMenuItem, Me.AjouterMarqueToolStripMenuItem, Me.AjouterTagToolStripMenuItem})
        Me.AjouterToolStripMenuItem.Name = "AjouterToolStripMenuItem"
        Me.AjouterToolStripMenuItem.Size = New System.Drawing.Size(66, 23)
        Me.AjouterToolStripMenuItem.Text = "Ajouter"
        '
        'AjouterGarantieToolStripMenuItem
        '
        Me.AjouterGarantieToolStripMenuItem.Name = "AjouterGarantieToolStripMenuItem"
        Me.AjouterGarantieToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.AjouterGarantieToolStripMenuItem.Text = "Ajouter Garantie"
        '
        'AjouterMagasinToolStripMenuItem
        '
        Me.AjouterMagasinToolStripMenuItem.Name = "AjouterMagasinToolStripMenuItem"
        Me.AjouterMagasinToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.AjouterMagasinToolStripMenuItem.Text = "Ajouter magasin"
        '
        'AjouterTypeDobjetToolStripMenuItem
        '
        Me.AjouterTypeDobjetToolStripMenuItem.Name = "AjouterTypeDobjetToolStripMenuItem"
        Me.AjouterTypeDobjetToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.AjouterTypeDobjetToolStripMenuItem.Text = "Ajouter type d'objet"
        '
        'AjouterMarqueToolStripMenuItem
        '
        Me.AjouterMarqueToolStripMenuItem.Name = "AjouterMarqueToolStripMenuItem"
        Me.AjouterMarqueToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.AjouterMarqueToolStripMenuItem.Text = "Ajouter marque"
        '
        'AjouterTagToolStripMenuItem
        '
        Me.AjouterTagToolStripMenuItem.Name = "AjouterTagToolStripMenuItem"
        Me.AjouterTagToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.AjouterTagToolStripMenuItem.Text = "Ajouter tag"
        '
        'ModifierToolStripMenuItem
        '
        Me.ModifierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModifierGarantieToolStripMenuItem, Me.ModifierMagasinToolStripMenuItem, Me.ModifierTypeDobjetToolStripMenuItem})
        Me.ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem"
        Me.ModifierToolStripMenuItem.Size = New System.Drawing.Size(72, 23)
        Me.ModifierToolStripMenuItem.Text = "Modifier"
        '
        'ModifierGarantieToolStripMenuItem
        '
        Me.ModifierGarantieToolStripMenuItem.Name = "ModifierGarantieToolStripMenuItem"
        Me.ModifierGarantieToolStripMenuItem.Size = New System.Drawing.Size(206, 24)
        Me.ModifierGarantieToolStripMenuItem.Text = "Modifier garantie"
        '
        'ModifierMagasinToolStripMenuItem
        '
        Me.ModifierMagasinToolStripMenuItem.Name = "ModifierMagasinToolStripMenuItem"
        Me.ModifierMagasinToolStripMenuItem.Size = New System.Drawing.Size(206, 24)
        Me.ModifierMagasinToolStripMenuItem.Text = "Modifier Magasin"
        '
        'ModifierTypeDobjetToolStripMenuItem
        '
        Me.ModifierTypeDobjetToolStripMenuItem.Name = "ModifierTypeDobjetToolStripMenuItem"
        Me.ModifierTypeDobjetToolStripMenuItem.Size = New System.Drawing.Size(206, 24)
        Me.ModifierTypeDobjetToolStripMenuItem.Text = "Modifier type d'objet"
        '
        'FichiersToolStripMenuItem
        '
        Me.FichiersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccéderAuDossierDesGarantiesToolStripMenuItem, Me.AccéderÀLaBaseDeDonnéesToolStripMenuItem})
        Me.FichiersToolStripMenuItem.Name = "FichiersToolStripMenuItem"
        Me.FichiersToolStripMenuItem.Size = New System.Drawing.Size(66, 23)
        Me.FichiersToolStripMenuItem.Text = "Fichiers"
        '
        'AccéderAuDossierDesGarantiesToolStripMenuItem
        '
        Me.AccéderAuDossierDesGarantiesToolStripMenuItem.Name = "AccéderAuDossierDesGarantiesToolStripMenuItem"
        Me.AccéderAuDossierDesGarantiesToolStripMenuItem.Size = New System.Drawing.Size(277, 24)
        Me.AccéderAuDossierDesGarantiesToolStripMenuItem.Text = "Accéder au dossier des garanties"
        '
        'AccéderÀLaBaseDeDonnéesToolStripMenuItem
        '
        Me.AccéderÀLaBaseDeDonnéesToolStripMenuItem.Name = "AccéderÀLaBaseDeDonnéesToolStripMenuItem"
        Me.AccéderÀLaBaseDeDonnéesToolStripMenuItem.Size = New System.Drawing.Size(277, 24)
        Me.AccéderÀLaBaseDeDonnéesToolStripMenuItem.Text = "Accéder à la base de données"
        '
        'ParamètresToolStripMenuItem
        '
        Me.ParamètresToolStripMenuItem.Name = "ParamètresToolStripMenuItem"
        Me.ParamètresToolStripMenuItem.Size = New System.Drawing.Size(90, 23)
        Me.ParamètresToolStripMenuItem.Text = "Paramètres"
        '
        'GB_Recherche
        '
        Me.GB_Recherche.Controls.Add(Me.ComboBox1)
        Me.GB_Recherche.Controls.Add(Me.TextBox4)
        Me.GB_Recherche.Controls.Add(Me.TextBox3)
        Me.GB_Recherche.Controls.Add(Me.TextBox2)
        Me.GB_Recherche.Controls.Add(Me.BT_Effacer_Recherche)
        Me.GB_Recherche.Controls.Add(Me.TextBox1)
        Me.GB_Recherche.Controls.Add(Me.LBL_Tags)
        Me.GB_Recherche.Controls.Add(Me.LBL_Magasin)
        Me.GB_Recherche.Controls.Add(Me.BT_Recherche)
        Me.GB_Recherche.Controls.Add(Me.LBL_Marque)
        Me.GB_Recherche.Controls.Add(Me.LBL_TypeObjet)
        Me.GB_Recherche.Controls.Add(Me.LBL_Nom)
        Me.GB_Recherche.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Recherche.Location = New System.Drawing.Point(12, 27)
        Me.GB_Recherche.Name = "GB_Recherche"
        Me.GB_Recherche.Size = New System.Drawing.Size(242, 206)
        Me.GB_Recherche.TabIndex = 1
        Me.GB_Recherche.TabStop = False
        Me.GB_Recherche.Text = "Recherche"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(105, 136)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 12
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(126, 107)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 23)
        Me.TextBox4.TabIndex = 10
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(126, 78)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 23)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(126, 49)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 23)
        Me.TextBox2.TabIndex = 8
        '
        'BT_Effacer_Recherche
        '
        Me.BT_Effacer_Recherche.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Effacer_Recherche.Location = New System.Drawing.Point(10, 166)
        Me.BT_Effacer_Recherche.Name = "BT_Effacer_Recherche"
        Me.BT_Effacer_Recherche.Size = New System.Drawing.Size(100, 30)
        Me.BT_Effacer_Recherche.TabIndex = 3
        Me.BT_Effacer_Recherche.Text = "Effacer"
        Me.BT_Effacer_Recherche.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(126, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 7
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
        Me.BT_Recherche.TabIndex = 4
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
        Me.LB_Affichage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Affichage.FormattingEnabled = True
        Me.LB_Affichage.ItemHeight = 16
        Me.LB_Affichage.Location = New System.Drawing.Point(12, 239)
        Me.LB_Affichage.Name = "LB_Affichage"
        Me.LB_Affichage.Size = New System.Drawing.Size(242, 324)
        Me.LB_Affichage.TabIndex = 2
        '
        'GB_Fiche
        '
        Me.GB_Fiche.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Fiche.Location = New System.Drawing.Point(267, 27)
        Me.GB_Fiche.Name = "GB_Fiche"
        Me.GB_Fiche.Size = New System.Drawing.Size(660, 557)
        Me.GB_Fiche.TabIndex = 3
        Me.GB_Fiche.TabStop = False
        Me.GB_Fiche.Text = "Fiche détaillée"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.GB_Fiche)
        Me.Controls.Add(Me.LB_Affichage)
        Me.Controls.Add(Me.GB_Recherche)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KeeWa"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GB_Recherche.ResumeLayout(False)
        Me.GB_Recherche.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AjouterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FichiersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParamètresToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents AjouterGarantieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterMagasinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccéderAuDossierDesGarantiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccéderÀLaBaseDeDonnéesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents AjouterTypeDobjetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterMarqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterTagToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifierGarantieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifierMagasinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifierTypeDobjetToolStripMenuItem As ToolStripMenuItem
End Class
