<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TypeWindow
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
        Me.RTB_Description = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TB_Nom = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BT_Sauv = New System.Windows.Forms.Button()
        Me.BT_Supp = New System.Windows.Forms.Button()
        Me.LBL_Modif = New System.Windows.Forms.Label()
        Me.CB_Modif = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RTB_Description
        '
        Me.RTB_Description.Location = New System.Drawing.Point(6, 29)
        Me.RTB_Description.Name = "RTB_Description"
        Me.RTB_Description.Size = New System.Drawing.Size(267, 224)
        Me.RTB_Description.TabIndex = 2
        Me.RTB_Description.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TB_Nom)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 329)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type d'objet"
        '
        'TB_Nom
        '
        Me.TB_Nom.Location = New System.Drawing.Point(116, 33)
        Me.TB_Nom.Name = "TB_Nom"
        Me.TB_Nom.Size = New System.Drawing.Size(169, 30)
        Me.TB_Nom.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RTB_Description)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(279, 259)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom :"
        '
        'BT_Sauv
        '
        Me.BT_Sauv.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BT_Sauv.Location = New System.Drawing.Point(167, 385)
        Me.BT_Sauv.Name = "BT_Sauv"
        Me.BT_Sauv.Size = New System.Drawing.Size(140, 33)
        Me.BT_Sauv.TabIndex = 3
        Me.BT_Sauv.Text = "Sauvegarder"
        Me.BT_Sauv.UseVisualStyleBackColor = True
        '
        'BT_Supp
        '
        Me.BT_Supp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BT_Supp.Location = New System.Drawing.Point(12, 385)
        Me.BT_Supp.Name = "BT_Supp"
        Me.BT_Supp.Size = New System.Drawing.Size(140, 33)
        Me.BT_Supp.TabIndex = 4
        Me.BT_Supp.Text = "Supprimer"
        Me.BT_Supp.UseVisualStyleBackColor = True
        '
        'LBL_Modif
        '
        Me.LBL_Modif.AutoSize = True
        Me.LBL_Modif.Enabled = False
        Me.LBL_Modif.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LBL_Modif.Location = New System.Drawing.Point(18, 14)
        Me.LBL_Modif.Name = "LBL_Modif"
        Me.LBL_Modif.Size = New System.Drawing.Size(157, 25)
        Me.LBL_Modif.TabIndex = 14
        Me.LBL_Modif.Text = "Type à modifier :"
        '
        'CB_Modif
        '
        Me.CB_Modif.Enabled = False
        Me.CB_Modif.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.CB_Modif.FormattingEnabled = True
        Me.CB_Modif.Location = New System.Drawing.Point(181, 11)
        Me.CB_Modif.Name = "CB_Modif"
        Me.CB_Modif.Size = New System.Drawing.Size(122, 33)
        Me.CB_Modif.TabIndex = 13
        '
        'TypeWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 428)
        Me.Controls.Add(Me.LBL_Modif)
        Me.Controls.Add(Me.CB_Modif)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BT_Sauv)
        Me.Controls.Add(Me.BT_Supp)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TypeWindow"
        Me.Text = "TypeWindow"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RTB_Description As RichTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TB_Nom As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BT_Sauv As Button
    Friend WithEvents BT_Supp As Button
    Friend WithEvents LBL_Modif As Label
    Friend WithEvents CB_Modif As ComboBox
End Class
