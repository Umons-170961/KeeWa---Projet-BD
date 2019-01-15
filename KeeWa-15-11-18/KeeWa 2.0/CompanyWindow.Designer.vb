<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompanyWindow
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
        Me.GB_Utilisateur = New System.Windows.Forms.GroupBox()
        Me.NUD_Qualité = New System.Windows.Forms.NumericUpDown()
        Me.TB_Nom = New System.Windows.Forms.TextBox()
        Me.Numéro = New System.Windows.Forms.Label()
        Me.BT_Sauv = New System.Windows.Forms.Button()
        Me.BT_Supp = New System.Windows.Forms.Button()
        Me.TB_Site = New System.Windows.Forms.TextBox()
        Me.TB_Téléphone = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBL_UtilTitre = New System.Windows.Forms.Label()
        Me.LBL_UtilNom = New System.Windows.Forms.Label()
        Me.CB_Modif = New System.Windows.Forms.ComboBox()
        Me.LBL_Modif = New System.Windows.Forms.Label()
        Me.GB_Utilisateur.SuspendLayout()
        CType(Me.NUD_Qualité, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB_Utilisateur
        '
        Me.GB_Utilisateur.Controls.Add(Me.NUD_Qualité)
        Me.GB_Utilisateur.Controls.Add(Me.TB_Nom)
        Me.GB_Utilisateur.Controls.Add(Me.Numéro)
        Me.GB_Utilisateur.Controls.Add(Me.BT_Sauv)
        Me.GB_Utilisateur.Controls.Add(Me.BT_Supp)
        Me.GB_Utilisateur.Controls.Add(Me.TB_Site)
        Me.GB_Utilisateur.Controls.Add(Me.TB_Téléphone)
        Me.GB_Utilisateur.Controls.Add(Me.Label1)
        Me.GB_Utilisateur.Controls.Add(Me.LBL_UtilTitre)
        Me.GB_Utilisateur.Controls.Add(Me.LBL_UtilNom)
        Me.GB_Utilisateur.Location = New System.Drawing.Point(21, 54)
        Me.GB_Utilisateur.Margin = New System.Windows.Forms.Padding(12)
        Me.GB_Utilisateur.Name = "GB_Utilisateur"
        Me.GB_Utilisateur.Padding = New System.Windows.Forms.Padding(12)
        Me.GB_Utilisateur.Size = New System.Drawing.Size(603, 256)
        Me.GB_Utilisateur.TabIndex = 8
        Me.GB_Utilisateur.TabStop = False
        Me.GB_Utilisateur.Text = "Marque"
        '
        'NUD_Qualité
        '
        Me.NUD_Qualité.Location = New System.Drawing.Point(212, 143)
        Me.NUD_Qualité.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NUD_Qualité.Name = "NUD_Qualité"
        Me.NUD_Qualité.Size = New System.Drawing.Size(120, 30)
        Me.NUD_Qualité.TabIndex = 4
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
        Me.Numéro.Size = New System.Drawing.Size(117, 25)
        Me.Numéro.TabIndex = 24
        Me.Numéro.Text = "Téléphone :"
        '
        'BT_Sauv
        '
        Me.BT_Sauv.Location = New System.Drawing.Point(322, 182)
        Me.BT_Sauv.Margin = New System.Windows.Forms.Padding(6)
        Me.BT_Sauv.Name = "BT_Sauv"
        Me.BT_Sauv.Size = New System.Drawing.Size(270, 57)
        Me.BT_Sauv.TabIndex = 5
        Me.BT_Sauv.Text = "Sauvegarder"
        Me.BT_Sauv.UseVisualStyleBackColor = True
        '
        'BT_Supp
        '
        Me.BT_Supp.Location = New System.Drawing.Point(29, 182)
        Me.BT_Supp.Margin = New System.Windows.Forms.Padding(6)
        Me.BT_Supp.Name = "BT_Supp"
        Me.BT_Supp.Size = New System.Drawing.Size(270, 57)
        Me.BT_Supp.TabIndex = 6
        Me.BT_Supp.Text = "Supprimer"
        Me.BT_Supp.UseVisualStyleBackColor = True
        '
        'TB_Site
        '
        Me.TB_Site.Location = New System.Drawing.Point(212, 72)
        Me.TB_Site.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_Site.Name = "TB_Site"
        Me.TB_Site.Size = New System.Drawing.Size(380, 30)
        Me.TB_Site.TabIndex = 2
        '
        'TB_Téléphone
        '
        Me.TB_Téléphone.Location = New System.Drawing.Point(212, 107)
        Me.TB_Téléphone.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_Téléphone.Name = "TB_Téléphone"
        Me.TB_Téléphone.Size = New System.Drawing.Size(380, 30)
        Me.TB_Téléphone.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Site internet :"
        '
        'LBL_UtilTitre
        '
        Me.LBL_UtilTitre.AutoSize = True
        Me.LBL_UtilTitre.Location = New System.Drawing.Point(24, 145)
        Me.LBL_UtilTitre.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.LBL_UtilTitre.Name = "LBL_UtilTitre"
        Me.LBL_UtilTitre.Size = New System.Drawing.Size(126, 25)
        Me.LBL_UtilTitre.TabIndex = 8
        Me.LBL_UtilTitre.Text = "Qualité (/5) : "
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
        'CB_Modif
        '
        Me.CB_Modif.FormattingEnabled = True
        Me.CB_Modif.Location = New System.Drawing.Point(233, 12)
        Me.CB_Modif.Name = "CB_Modif"
        Me.CB_Modif.Size = New System.Drawing.Size(380, 33)
        Me.CB_Modif.TabIndex = 9
        Me.CB_Modif.TabStop = False
        '
        'LBL_Modif
        '
        Me.LBL_Modif.AutoSize = True
        Me.LBL_Modif.Location = New System.Drawing.Point(29, 17)
        Me.LBL_Modif.Name = "LBL_Modif"
        Me.LBL_Modif.Size = New System.Drawing.Size(179, 25)
        Me.LBL_Modif.TabIndex = 10
        Me.LBL_Modif.Text = "Marque à modifier :"
        '
        'CompanyWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 335)
        Me.Controls.Add(Me.LBL_Modif)
        Me.Controls.Add(Me.CB_Modif)
        Me.Controls.Add(Me.GB_Utilisateur)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CompanyWindow"
        Me.Text = "CompanyWindow"
        Me.GB_Utilisateur.ResumeLayout(False)
        Me.GB_Utilisateur.PerformLayout()
        CType(Me.NUD_Qualité, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GB_Utilisateur As GroupBox
    Friend WithEvents TB_Nom As TextBox
    Friend WithEvents Numéro As Label
    Friend WithEvents BT_Sauv As Button
    Friend WithEvents BT_Supp As Button
    Friend WithEvents TB_Site As TextBox
    Friend WithEvents TB_Téléphone As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LBL_UtilTitre As Label
    Friend WithEvents LBL_UtilNom As Label
    Friend WithEvents NUD_Qualité As NumericUpDown
    Friend WithEvents CB_Modif As ComboBox
    Friend WithEvents LBL_Modif As Label
End Class
