<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inutilr
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TB_Type = New System.Windows.Forms.TextBox()
        Me.TB_Prix = New System.Windows.Forms.TextBox()
        Me.TB_Numéro = New System.Windows.Forms.TextBox()
        Me.TB_Nom = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.B_Modifier = New System.Windows.Forms.Button()
        Me.B_Sauvegarder = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TB_Type)
        Me.GroupBox1.Controls.Add(Me.TB_Prix)
        Me.GroupBox1.Controls.Add(Me.TB_Numéro)
        Me.GroupBox1.Controls.Add(Me.TB_Nom)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 202)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Objet"
        '
        'TB_Type
        '
        Me.TB_Type.Location = New System.Drawing.Point(188, 160)
        Me.TB_Type.Name = "TB_Type"
        Me.TB_Type.ReadOnly = True
        Me.TB_Type.Size = New System.Drawing.Size(135, 38)
        Me.TB_Type.TabIndex = 10
        Me.TB_Type.Text = "Bouf"
        '
        'TB_Prix
        '
        Me.TB_Prix.Location = New System.Drawing.Point(188, 120)
        Me.TB_Prix.Name = "TB_Prix"
        Me.TB_Prix.ReadOnly = True
        Me.TB_Prix.Size = New System.Drawing.Size(135, 38)
        Me.TB_Prix.TabIndex = 9
        Me.TB_Prix.Text = "500$"
        '
        'TB_Numéro
        '
        Me.TB_Numéro.Location = New System.Drawing.Point(188, 80)
        Me.TB_Numéro.Name = "TB_Numéro"
        Me.TB_Numéro.ReadOnly = True
        Me.TB_Numéro.Size = New System.Drawing.Size(135, 38)
        Me.TB_Numéro.TabIndex = 8
        Me.TB_Numéro.Text = "-"
        '
        'TB_Nom
        '
        Me.TB_Nom.Location = New System.Drawing.Point(188, 40)
        Me.TB_Nom.Name = "TB_Nom"
        Me.TB_Nom.ReadOnly = True
        Me.TB_Nom.Size = New System.Drawing.Size(135, 38)
        Me.TB_Nom.TabIndex = 7
        Me.TB_Nom.Text = "Biscuit"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label21.Location = New System.Drawing.Point(6, 160)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(176, 31)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "Type d'objet :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label3.Location = New System.Drawing.Point(6, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Prix :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(6, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numéro :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom :"
        '
        'B_Modifier
        '
        Me.B_Modifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.B_Modifier.Location = New System.Drawing.Point(12, 232)
        Me.B_Modifier.Name = "B_Modifier"
        Me.B_Modifier.Size = New System.Drawing.Size(122, 49)
        Me.B_Modifier.TabIndex = 2
        Me.B_Modifier.Text = "Modifier"
        Me.B_Modifier.UseVisualStyleBackColor = True
        '
        'B_Sauvegarder
        '
        Me.B_Sauvegarder.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.B_Sauvegarder.Location = New System.Drawing.Point(152, 232)
        Me.B_Sauvegarder.Name = "B_Sauvegarder"
        Me.B_Sauvegarder.Size = New System.Drawing.Size(183, 49)
        Me.B_Sauvegarder.TabIndex = 3
        Me.B_Sauvegarder.Text = "Sauvegarder"
        Me.B_Sauvegarder.UseVisualStyleBackColor = True
        '
        'ObjectWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 291)
        Me.Controls.Add(Me.B_Sauvegarder)
        Me.Controls.Add(Me.B_Modifier)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ObjectWindow"
        Me.Text = "ObjectWindow"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents B_Modifier As Button
    Friend WithEvents B_Sauvegarder As Button
    Friend WithEvents TB_Type As TextBox
    Friend WithEvents TB_Prix As TextBox
    Friend WithEvents TB_Numéro As TextBox
    Friend WithEvents TB_Nom As TextBox
End Class
