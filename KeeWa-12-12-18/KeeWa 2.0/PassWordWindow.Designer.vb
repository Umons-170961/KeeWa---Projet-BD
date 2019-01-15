<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PassWordWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PassWordWindow))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_User = New System.Windows.Forms.TextBox()
        Me.TB_MDP = New System.Windows.Forms.TextBox()
        Me.LB_Error = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(75, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Utilisateur :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mot de Passe :"
        '
        'TB_User
        '
        Me.TB_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TB_User.Location = New System.Drawing.Point(120, 6)
        Me.TB_User.Name = "TB_User"
        Me.TB_User.Size = New System.Drawing.Size(100, 23)
        Me.TB_User.TabIndex = 1
        '
        'TB_MDP
        '
        Me.TB_MDP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TB_MDP.Location = New System.Drawing.Point(120, 38)
        Me.TB_MDP.Name = "TB_MDP"
        Me.TB_MDP.Size = New System.Drawing.Size(100, 23)
        Me.TB_MDP.TabIndex = 2
        '
        'LB_Error
        '
        Me.LB_Error.AutoSize = True
        Me.LB_Error.ForeColor = System.Drawing.Color.Maroon
        Me.LB_Error.Location = New System.Drawing.Point(58, 64)
        Me.LB_Error.Name = "LB_Error"
        Me.LB_Error.Size = New System.Drawing.Size(111, 13)
        Me.LB_Error.TabIndex = 5
        Me.LB_Error.Text = "Erreur Authentification"
        Me.LB_Error.Visible = False
        '
        'PassWordWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 111)
        Me.Controls.Add(Me.LB_Error)
        Me.Controls.Add(Me.TB_MDP)
        Me.Controls.Add(Me.TB_User)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PassWordWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_User As TextBox
    Friend WithEvents TB_MDP As TextBox
    Friend WithEvents LB_Error As Label
End Class
