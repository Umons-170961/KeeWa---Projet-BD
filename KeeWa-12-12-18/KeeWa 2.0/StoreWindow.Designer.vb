<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StoreWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StoreWindow))
        Me.GB_Utilisateur = New System.Windows.Forms.GroupBox()
        Me.TB_Téléphone = New System.Windows.Forms.TextBox()
        Me.TB_Nom = New System.Windows.Forms.TextBox()
        Me.Numéro = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BT_Sauv = New System.Windows.Forms.Button()
        Me.BT_Supp = New System.Windows.Forms.Button()
        Me.TB_Email = New System.Windows.Forms.TextBox()
        Me.TB_Rue = New System.Windows.Forms.TextBox()
        Me.TB_Numéro = New System.Windows.Forms.TextBox()
        Me.TB_CP = New System.Windows.Forms.TextBox()
        Me.TB_Ville = New System.Windows.Forms.TextBox()
        Me.TB_Site = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBL_UtilLien = New System.Windows.Forms.Label()
        Me.LBL_UtilTitre = New System.Windows.Forms.Label()
        Me.LBL_UtilNom = New System.Windows.Forms.Label()
        Me.LBL_Modif = New System.Windows.Forms.Label()
        Me.CB_Modif = New System.Windows.Forms.ComboBox()
        Me.GB_Utilisateur.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_Utilisateur
        '
        Me.GB_Utilisateur.Controls.Add(Me.TB_Téléphone)
        Me.GB_Utilisateur.Controls.Add(Me.TB_Nom)
        Me.GB_Utilisateur.Controls.Add(Me.Numéro)
        Me.GB_Utilisateur.Controls.Add(Me.Label4)
        Me.GB_Utilisateur.Controls.Add(Me.BT_Sauv)
        Me.GB_Utilisateur.Controls.Add(Me.BT_Supp)
        Me.GB_Utilisateur.Controls.Add(Me.TB_Email)
        Me.GB_Utilisateur.Controls.Add(Me.TB_Rue)
        Me.GB_Utilisateur.Controls.Add(Me.TB_Numéro)
        Me.GB_Utilisateur.Controls.Add(Me.TB_CP)
        Me.GB_Utilisateur.Controls.Add(Me.TB_Ville)
        Me.GB_Utilisateur.Controls.Add(Me.TB_Site)
        Me.GB_Utilisateur.Controls.Add(Me.Label3)
        Me.GB_Utilisateur.Controls.Add(Me.Label2)
        Me.GB_Utilisateur.Controls.Add(Me.Label1)
        Me.GB_Utilisateur.Controls.Add(Me.LBL_UtilLien)
        Me.GB_Utilisateur.Controls.Add(Me.LBL_UtilTitre)
        Me.GB_Utilisateur.Controls.Add(Me.LBL_UtilNom)
        Me.GB_Utilisateur.Location = New System.Drawing.Point(21, 52)
        Me.GB_Utilisateur.Margin = New System.Windows.Forms.Padding(12)
        Me.GB_Utilisateur.Name = "GB_Utilisateur"
        Me.GB_Utilisateur.Padding = New System.Windows.Forms.Padding(12)
        Me.GB_Utilisateur.Size = New System.Drawing.Size(603, 399)
        Me.GB_Utilisateur.TabIndex = 7
        Me.GB_Utilisateur.TabStop = False
        Me.GB_Utilisateur.Text = "Magasin"
        '
        'TB_Téléphone
        '
        Me.TB_Téléphone.Location = New System.Drawing.Point(212, 282)
        Me.TB_Téléphone.Name = "TB_Téléphone"
        Me.TB_Téléphone.Size = New System.Drawing.Size(380, 30)
        Me.TB_Téléphone.TabIndex = 8
        '
        'TB_Nom
        '
        Me.TB_Nom.Location = New System.Drawing.Point(212, 37)
        Me.TB_Nom.Name = "TB_Nom"
        Me.TB_Nom.Size = New System.Drawing.Size(380, 30)
        Me.TB_Nom.TabIndex = 1
        '
        'Numéro
        '
        Me.Numéro.AutoSize = True
        Me.Numéro.Location = New System.Drawing.Point(24, 110)
        Me.Numéro.Name = "Numéro"
        Me.Numéro.Size = New System.Drawing.Size(81, 25)
        Me.Numéro.TabIndex = 24
        Me.Numéro.Text = "Numéro"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 25)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Ville"
        '
        'BT_Sauv
        '
        Me.BT_Sauv.Location = New System.Drawing.Point(322, 321)
        Me.BT_Sauv.Margin = New System.Windows.Forms.Padding(6)
        Me.BT_Sauv.Name = "BT_Sauv"
        Me.BT_Sauv.Size = New System.Drawing.Size(270, 57)
        Me.BT_Sauv.TabIndex = 9
        Me.BT_Sauv.Text = "Sauvegarder"
        Me.BT_Sauv.UseVisualStyleBackColor = True
        '
        'BT_Supp
        '
        Me.BT_Supp.Location = New System.Drawing.Point(29, 321)
        Me.BT_Supp.Margin = New System.Windows.Forms.Padding(6)
        Me.BT_Supp.Name = "BT_Supp"
        Me.BT_Supp.Size = New System.Drawing.Size(270, 57)
        Me.BT_Supp.TabIndex = 10
        Me.BT_Supp.Text = "Supprimer"
        Me.BT_Supp.UseVisualStyleBackColor = True
        '
        'TB_Email
        '
        Me.TB_Email.Location = New System.Drawing.Point(212, 247)
        Me.TB_Email.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_Email.Name = "TB_Email"
        Me.TB_Email.Size = New System.Drawing.Size(380, 30)
        Me.TB_Email.TabIndex = 7
        '
        'TB_Rue
        '
        Me.TB_Rue.Location = New System.Drawing.Point(212, 72)
        Me.TB_Rue.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_Rue.Name = "TB_Rue"
        Me.TB_Rue.Size = New System.Drawing.Size(380, 30)
        Me.TB_Rue.TabIndex = 2
        '
        'TB_Numéro
        '
        Me.TB_Numéro.Location = New System.Drawing.Point(212, 107)
        Me.TB_Numéro.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_Numéro.Name = "TB_Numéro"
        Me.TB_Numéro.Size = New System.Drawing.Size(380, 30)
        Me.TB_Numéro.TabIndex = 3
        '
        'TB_CP
        '
        Me.TB_CP.Location = New System.Drawing.Point(212, 142)
        Me.TB_CP.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_CP.Name = "TB_CP"
        Me.TB_CP.Size = New System.Drawing.Size(380, 30)
        Me.TB_CP.TabIndex = 4
        '
        'TB_Ville
        '
        Me.TB_Ville.Location = New System.Drawing.Point(212, 177)
        Me.TB_Ville.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_Ville.Name = "TB_Ville"
        Me.TB_Ville.Size = New System.Drawing.Size(380, 30)
        Me.TB_Ville.TabIndex = 5
        '
        'TB_Site
        '
        Me.TB_Site.Location = New System.Drawing.Point(212, 212)
        Me.TB_Site.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_Site.Name = "TB_Site"
        Me.TB_Site.Size = New System.Drawing.Size(380, 30)
        Me.TB_Site.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 285)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Téléphone :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 250)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Email de contact :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Rue :"
        '
        'LBL_UtilLien
        '
        Me.LBL_UtilLien.AutoSize = True
        Me.LBL_UtilLien.Location = New System.Drawing.Point(24, 215)
        Me.LBL_UtilLien.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.LBL_UtilLien.Name = "LBL_UtilLien"
        Me.LBL_UtilLien.Size = New System.Drawing.Size(126, 25)
        Me.LBL_UtilLien.TabIndex = 11
        Me.LBL_UtilLien.Text = "Site internet :"
        '
        'LBL_UtilTitre
        '
        Me.LBL_UtilTitre.AutoSize = True
        Me.LBL_UtilTitre.Location = New System.Drawing.Point(24, 145)
        Me.LBL_UtilTitre.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.LBL_UtilTitre.Name = "LBL_UtilTitre"
        Me.LBL_UtilTitre.Size = New System.Drawing.Size(133, 25)
        Me.LBL_UtilTitre.TabIndex = 8
        Me.LBL_UtilTitre.Text = "Code postal : "
        '
        'LBL_UtilNom
        '
        Me.LBL_UtilNom.AutoSize = True
        Me.LBL_UtilNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LBL_UtilNom.Location = New System.Drawing.Point(24, 40)
        Me.LBL_UtilNom.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.LBL_UtilNom.Name = "LBL_UtilNom"
        Me.LBL_UtilNom.Size = New System.Drawing.Size(64, 25)
        Me.LBL_UtilNom.TabIndex = 7
        Me.LBL_UtilNom.Text = "Nom :"
        '
        'LBL_Modif
        '
        Me.LBL_Modif.AutoSize = True
        Me.LBL_Modif.Enabled = False
        Me.LBL_Modif.Location = New System.Drawing.Point(24, 15)
        Me.LBL_Modif.Name = "LBL_Modif"
        Me.LBL_Modif.Size = New System.Drawing.Size(187, 25)
        Me.LBL_Modif.TabIndex = 14
        Me.LBL_Modif.Text = "Magasin à modifier :"
        '
        'CB_Modif
        '
        Me.CB_Modif.Enabled = False
        Me.CB_Modif.FormattingEnabled = True
        Me.CB_Modif.Location = New System.Drawing.Point(233, 12)
        Me.CB_Modif.Name = "CB_Modif"
        Me.CB_Modif.Size = New System.Drawing.Size(380, 33)
        Me.CB_Modif.TabIndex = 15
        Me.CB_Modif.TabStop = False
        '
        'StoreWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 466)
        Me.Controls.Add(Me.LBL_Modif)
        Me.Controls.Add(Me.CB_Modif)
        Me.Controls.Add(Me.GB_Utilisateur)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StoreWindow"
        Me.Text = "Magasin"
        Me.GB_Utilisateur.ResumeLayout(False)
        Me.GB_Utilisateur.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GB_Utilisateur As GroupBox
    Friend WithEvents TB_Téléphone As TextBox
    Friend WithEvents TB_Nom As TextBox
    Friend WithEvents Numéro As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BT_Sauv As Button
    Friend WithEvents BT_Supp As Button
    Friend WithEvents TB_Email As TextBox
    Friend WithEvents TB_Rue As TextBox
    Friend WithEvents TB_Numéro As TextBox
    Friend WithEvents TB_CP As TextBox
    Friend WithEvents TB_Ville As TextBox
    Friend WithEvents TB_Site As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LBL_UtilLien As Label
    Friend WithEvents LBL_UtilTitre As Label
    Friend WithEvents LBL_UtilNom As Label
    Friend WithEvents LBL_Modif As Label
    Friend WithEvents CB_Modif As ComboBox
End Class
