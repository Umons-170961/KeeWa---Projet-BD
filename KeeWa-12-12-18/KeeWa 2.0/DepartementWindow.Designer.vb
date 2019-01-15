<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepartementWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DepartementWindow))
        Me.GB_Utilisateur = New System.Windows.Forms.GroupBox()
        Me.CB_PersCon = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BT_Sauv = New System.Windows.Forms.Button()
        Me.BT_Supp = New System.Windows.Forms.Button()
        Me.TB_Nom = New System.Windows.Forms.TextBox()
        Me.TB_Email = New System.Windows.Forms.TextBox()
        Me.TB_Téléphone = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBL_UtilNom = New System.Windows.Forms.Label()
        Me.LBL_Modif = New System.Windows.Forms.Label()
        Me.CB_Modif = New System.Windows.Forms.ComboBox()
        Me.GB_Utilisateur.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_Utilisateur
        '
        Me.GB_Utilisateur.Controls.Add(Me.CB_PersCon)
        Me.GB_Utilisateur.Controls.Add(Me.Label1)
        Me.GB_Utilisateur.Controls.Add(Me.BT_Sauv)
        Me.GB_Utilisateur.Controls.Add(Me.BT_Supp)
        Me.GB_Utilisateur.Controls.Add(Me.TB_Nom)
        Me.GB_Utilisateur.Controls.Add(Me.TB_Email)
        Me.GB_Utilisateur.Controls.Add(Me.TB_Téléphone)
        Me.GB_Utilisateur.Controls.Add(Me.Label3)
        Me.GB_Utilisateur.Controls.Add(Me.Label2)
        Me.GB_Utilisateur.Controls.Add(Me.LBL_UtilNom)
        Me.GB_Utilisateur.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GB_Utilisateur.Location = New System.Drawing.Point(15, 49)
        Me.GB_Utilisateur.Margin = New System.Windows.Forms.Padding(6)
        Me.GB_Utilisateur.Name = "GB_Utilisateur"
        Me.GB_Utilisateur.Padding = New System.Windows.Forms.Padding(6)
        Me.GB_Utilisateur.Size = New System.Drawing.Size(435, 240)
        Me.GB_Utilisateur.TabIndex = 14
        Me.GB_Utilisateur.TabStop = False
        Me.GB_Utilisateur.Text = "Département"
        '
        'CB_PersCon
        '
        Me.CB_PersCon.FormattingEnabled = True
        Me.CB_PersCon.Location = New System.Drawing.Point(181, 129)
        Me.CB_PersCon.Name = "CB_PersCon"
        Me.CB_PersCon.Size = New System.Drawing.Size(244, 33)
        Me.CB_PersCon.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 25)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Contact :"
        '
        'BT_Sauv
        '
        Me.BT_Sauv.Location = New System.Drawing.Point(226, 183)
        Me.BT_Sauv.Name = "BT_Sauv"
        Me.BT_Sauv.Size = New System.Drawing.Size(200, 43)
        Me.BT_Sauv.TabIndex = 8
        Me.BT_Sauv.Text = "Sauvegarder"
        Me.BT_Sauv.UseVisualStyleBackColor = True
        '
        'BT_Supp
        '
        Me.BT_Supp.Location = New System.Drawing.Point(9, 183)
        Me.BT_Supp.Name = "BT_Supp"
        Me.BT_Supp.Size = New System.Drawing.Size(200, 43)
        Me.BT_Supp.TabIndex = 9
        Me.BT_Supp.Text = "Supprimer"
        Me.BT_Supp.UseVisualStyleBackColor = True
        '
        'TB_Nom
        '
        Me.TB_Nom.Location = New System.Drawing.Point(181, 27)
        Me.TB_Nom.Name = "TB_Nom"
        Me.TB_Nom.Size = New System.Drawing.Size(245, 30)
        Me.TB_Nom.TabIndex = 2
        '
        'TB_Email
        '
        Me.TB_Email.Location = New System.Drawing.Point(181, 61)
        Me.TB_Email.Name = "TB_Email"
        Me.TB_Email.Size = New System.Drawing.Size(245, 30)
        Me.TB_Email.TabIndex = 3
        '
        'TB_Téléphone
        '
        Me.TB_Téléphone.Location = New System.Drawing.Point(181, 95)
        Me.TB_Téléphone.Name = "TB_Téléphone"
        Me.TB_Téléphone.Size = New System.Drawing.Size(245, 30)
        Me.TB_Téléphone.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Téléphone :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Email :"
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
        Me.LBL_Modif.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LBL_Modif.Location = New System.Drawing.Point(19, 18)
        Me.LBL_Modif.Name = "LBL_Modif"
        Me.LBL_Modif.Size = New System.Drawing.Size(224, 25)
        Me.LBL_Modif.TabIndex = 15
        Me.LBL_Modif.Text = "Département à modifier :"
        '
        'CB_Modif
        '
        Me.CB_Modif.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CB_Modif.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_Modif.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.CB_Modif.FormattingEnabled = True
        Me.CB_Modif.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CB_Modif.Location = New System.Drawing.Point(249, 15)
        Me.CB_Modif.Name = "CB_Modif"
        Me.CB_Modif.Size = New System.Drawing.Size(192, 33)
        Me.CB_Modif.Sorted = True
        Me.CB_Modif.TabIndex = 13
        '
        'DepartementWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 297)
        Me.Controls.Add(Me.GB_Utilisateur)
        Me.Controls.Add(Me.LBL_Modif)
        Me.Controls.Add(Me.CB_Modif)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DepartementWindow"
        Me.Text = "Département"
        Me.GB_Utilisateur.ResumeLayout(False)
        Me.GB_Utilisateur.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GB_Utilisateur As GroupBox
    Friend WithEvents BT_Sauv As Button
    Friend WithEvents BT_Supp As Button
    Friend WithEvents TB_Nom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LBL_UtilNom As Label
    Friend WithEvents LBL_Modif As Label
    Friend WithEvents CB_Modif As ComboBox
    Friend WithEvents TB_Email As TextBox
    Friend WithEvents TB_Téléphone As TextBox
    Friend WithEvents CB_PersCon As ComboBox
    Friend WithEvents Label1 As Label
End Class
