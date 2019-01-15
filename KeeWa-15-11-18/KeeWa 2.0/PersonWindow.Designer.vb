<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonWindow
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
        Me.BT_Sauv = New System.Windows.Forms.Button()
        Me.BT_Supp = New System.Windows.Forms.Button()
        Me.TB_Téléphone = New System.Windows.Forms.TextBox()
        Me.TB_Nom = New System.Windows.Forms.TextBox()
        Me.TB_Prénom = New System.Windows.Forms.TextBox()
        Me.TB_Titre = New System.Windows.Forms.TextBox()
        Me.TB_Lien = New System.Windows.Forms.TextBox()
        Me.TB_Email = New System.Windows.Forms.TextBox()
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
        Me.GB_Utilisateur.Controls.Add(Me.BT_Sauv)
        Me.GB_Utilisateur.Controls.Add(Me.BT_Supp)
        Me.GB_Utilisateur.Controls.Add(Me.TB_Téléphone)
        Me.GB_Utilisateur.Controls.Add(Me.TB_Nom)
        Me.GB_Utilisateur.Controls.Add(Me.TB_Prénom)
        Me.GB_Utilisateur.Controls.Add(Me.TB_Titre)
        Me.GB_Utilisateur.Controls.Add(Me.TB_Lien)
        Me.GB_Utilisateur.Controls.Add(Me.TB_Email)
        Me.GB_Utilisateur.Controls.Add(Me.Label3)
        Me.GB_Utilisateur.Controls.Add(Me.Label2)
        Me.GB_Utilisateur.Controls.Add(Me.Label1)
        Me.GB_Utilisateur.Controls.Add(Me.LBL_UtilLien)
        Me.GB_Utilisateur.Controls.Add(Me.LBL_UtilTitre)
        Me.GB_Utilisateur.Controls.Add(Me.LBL_UtilNom)
        Me.GB_Utilisateur.Location = New System.Drawing.Point(15, 52)
        Me.GB_Utilisateur.Margin = New System.Windows.Forms.Padding(6)
        Me.GB_Utilisateur.Name = "GB_Utilisateur"
        Me.GB_Utilisateur.Padding = New System.Windows.Forms.Padding(6)
        Me.GB_Utilisateur.Size = New System.Drawing.Size(435, 290)
        Me.GB_Utilisateur.TabIndex = 6
        Me.GB_Utilisateur.TabStop = False
        Me.GB_Utilisateur.Text = "Personne"
        '
        'BT_Sauv
        '
        Me.BT_Sauv.Location = New System.Drawing.Point(226, 238)
        Me.BT_Sauv.Name = "BT_Sauv"
        Me.BT_Sauv.Size = New System.Drawing.Size(200, 43)
        Me.BT_Sauv.TabIndex = 8
        Me.BT_Sauv.Text = "Sauvegarder"
        Me.BT_Sauv.UseVisualStyleBackColor = True
        '
        'BT_Supp
        '
        Me.BT_Supp.Location = New System.Drawing.Point(9, 238)
        Me.BT_Supp.Name = "BT_Supp"
        Me.BT_Supp.Size = New System.Drawing.Size(200, 43)
        Me.BT_Supp.TabIndex = 9
        Me.BT_Supp.Text = "Supprimer"
        Me.BT_Supp.UseVisualStyleBackColor = True
        '
        'TB_Téléphone
        '
        Me.TB_Téléphone.Location = New System.Drawing.Point(181, 202)
        Me.TB_Téléphone.Name = "TB_Téléphone"
        Me.TB_Téléphone.Size = New System.Drawing.Size(245, 30)
        Me.TB_Téléphone.TabIndex = 7
        '
        'TB_Nom
        '
        Me.TB_Nom.Location = New System.Drawing.Point(181, 27)
        Me.TB_Nom.Name = "TB_Nom"
        Me.TB_Nom.Size = New System.Drawing.Size(245, 30)
        Me.TB_Nom.TabIndex = 2
        '
        'TB_Prénom
        '
        Me.TB_Prénom.Location = New System.Drawing.Point(181, 61)
        Me.TB_Prénom.Name = "TB_Prénom"
        Me.TB_Prénom.Size = New System.Drawing.Size(245, 30)
        Me.TB_Prénom.TabIndex = 3
        '
        'TB_Titre
        '
        Me.TB_Titre.Location = New System.Drawing.Point(181, 97)
        Me.TB_Titre.Name = "TB_Titre"
        Me.TB_Titre.Size = New System.Drawing.Size(245, 30)
        Me.TB_Titre.TabIndex = 4
        '
        'TB_Lien
        '
        Me.TB_Lien.Location = New System.Drawing.Point(181, 132)
        Me.TB_Lien.Name = "TB_Lien"
        Me.TB_Lien.Size = New System.Drawing.Size(245, 30)
        Me.TB_Lien.TabIndex = 5
        '
        'TB_Email
        '
        Me.TB_Email.Location = New System.Drawing.Point(181, 167)
        Me.TB_Email.Name = "TB_Email"
        Me.TB_Email.Size = New System.Drawing.Size(245, 30)
        Me.TB_Email.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Téléphone :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Email :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Prénom :"
        '
        'LBL_UtilLien
        '
        Me.LBL_UtilLien.AutoSize = True
        Me.LBL_UtilLien.Location = New System.Drawing.Point(12, 135)
        Me.LBL_UtilLien.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LBL_UtilLien.Name = "LBL_UtilLien"
        Me.LBL_UtilLien.Size = New System.Drawing.Size(154, 25)
        Me.LBL_UtilLien.TabIndex = 11
        Me.LBL_UtilLien.Text = "Lien avec objet :"
        '
        'LBL_UtilTitre
        '
        Me.LBL_UtilTitre.AutoSize = True
        Me.LBL_UtilTitre.Location = New System.Drawing.Point(12, 100)
        Me.LBL_UtilTitre.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LBL_UtilTitre.Name = "LBL_UtilTitre"
        Me.LBL_UtilTitre.Size = New System.Drawing.Size(67, 25)
        Me.LBL_UtilTitre.TabIndex = 8
        Me.LBL_UtilTitre.Text = "Titre : "
        '
        'LBL_UtilNom
        '
        Me.LBL_UtilNom.AutoSize = True
        Me.LBL_UtilNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LBL_UtilNom.Location = New System.Drawing.Point(12, 30)
        Me.LBL_UtilNom.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LBL_UtilNom.Name = "LBL_UtilNom"
        Me.LBL_UtilNom.Size = New System.Drawing.Size(64, 25)
        Me.LBL_UtilNom.TabIndex = 7
        Me.LBL_UtilNom.Text = "Nom :"
        '
        'LBL_Modif
        '
        Me.LBL_Modif.AutoSize = True
        Me.LBL_Modif.Enabled = False
        Me.LBL_Modif.Location = New System.Drawing.Point(19, 21)
        Me.LBL_Modif.Name = "LBL_Modif"
        Me.LBL_Modif.Size = New System.Drawing.Size(196, 25)
        Me.LBL_Modif.TabIndex = 12
        Me.LBL_Modif.Text = "Personne à modifier :"
        '
        'CB_Modif
        '
        Me.CB_Modif.FormattingEnabled = True
        Me.CB_Modif.Location = New System.Drawing.Point(221, 18)
        Me.CB_Modif.Name = "CB_Modif"
        Me.CB_Modif.Size = New System.Drawing.Size(220, 33)
        Me.CB_Modif.TabIndex = 1
        '
        'PersonWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 357)
        Me.Controls.Add(Me.LBL_Modif)
        Me.Controls.Add(Me.CB_Modif)
        Me.Controls.Add(Me.GB_Utilisateur)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PersonWindow"
        Me.Text = "PersonWindow"
        Me.GB_Utilisateur.ResumeLayout(False)
        Me.GB_Utilisateur.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GB_Utilisateur As GroupBox
    Friend WithEvents LBL_UtilLien As Label
    Friend WithEvents LBL_UtilTitre As Label
    Friend WithEvents LBL_UtilNom As Label
    Friend WithEvents BT_Sauv As Button
    Friend WithEvents BT_Supp As Button
    Friend WithEvents TB_Téléphone As TextBox
    Friend WithEvents TB_Nom As TextBox
    Friend WithEvents TB_Prénom As TextBox
    Friend WithEvents TB_Titre As TextBox
    Friend WithEvents TB_Lien As TextBox
    Friend WithEvents TB_Email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LBL_Modif As Label
    Friend WithEvents CB_Modif As ComboBox
End Class
