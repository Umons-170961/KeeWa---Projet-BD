<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Paramètres
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TB_NewPW = New System.Windows.Forms.TextBox()
        Me.TB_OldPW = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_Login = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CB_Langue = New System.Windows.Forms.ComboBox()
        Me.BT_Sauv = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(19, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ancien mot de passe :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TB_NewPW)
        Me.GroupBox1.Controls.Add(Me.TB_OldPW)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 119)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Changer Mot de Passe"
        '
        'TB_NewPW
        '
        Me.TB_NewPW.Location = New System.Drawing.Point(10, 85)
        Me.TB_NewPW.Name = "TB_NewPW"
        Me.TB_NewPW.Size = New System.Drawing.Size(221, 23)
        Me.TB_NewPW.TabIndex = 4
        '
        'TB_OldPW
        '
        Me.TB_OldPW.Location = New System.Drawing.Point(10, 39)
        Me.TB_OldPW.Name = "TB_OldPW"
        Me.TB_OldPW.Size = New System.Drawing.Size(221, 23)
        Me.TB_OldPW.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nouveau mot de passe :"
        '
        'TB_Login
        '
        Me.TB_Login.Location = New System.Drawing.Point(89, 12)
        Me.TB_Login.Name = "TB_Login"
        Me.TB_Login.Size = New System.Drawing.Size(154, 23)
        Me.TB_Login.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Langue :"
        '
        'CB_Langue
        '
        Me.CB_Langue.FormattingEnabled = True
        Me.CB_Langue.Items.AddRange(New Object() {"Francais"})
        Me.CB_Langue.Location = New System.Drawing.Point(89, 41)
        Me.CB_Langue.Name = "CB_Langue"
        Me.CB_Langue.Size = New System.Drawing.Size(154, 24)
        Me.CB_Langue.TabIndex = 5
        '
        'BT_Sauv
        '
        Me.BT_Sauv.Location = New System.Drawing.Point(71, 198)
        Me.BT_Sauv.Name = "BT_Sauv"
        Me.BT_Sauv.Size = New System.Drawing.Size(113, 34)
        Me.BT_Sauv.TabIndex = 6
        Me.BT_Sauv.Text = "Sauvegarder"
        Me.BT_Sauv.UseVisualStyleBackColor = True
        '
        'Paramètres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 244)
        Me.Controls.Add(Me.BT_Sauv)
        Me.Controls.Add(Me.CB_Langue)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TB_Login)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Paramètres"
        Me.Text = "Paramètres"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_NewPW As TextBox
    Friend WithEvents TB_OldPW As TextBox
    Friend WithEvents TB_Login As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CB_Langue As ComboBox
    Friend WithEvents BT_Sauv As Button
End Class
