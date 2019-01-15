<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GarantyImage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GarantyImage))
        Me.PB_Image = New System.Windows.Forms.PictureBox()
        Me.BT_Sauv = New System.Windows.Forms.Button()
        Me.BT_Supp = New System.Windows.Forms.Button()
        Me.BT_AjoutImage = New System.Windows.Forms.Button()
        Me.OFP_Image = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PB_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PB_Image
        '
        Me.PB_Image.InitialImage = Nothing
        Me.PB_Image.Location = New System.Drawing.Point(12, 12)
        Me.PB_Image.Name = "PB_Image"
        Me.PB_Image.Size = New System.Drawing.Size(500, 500)
        Me.PB_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_Image.TabIndex = 0
        Me.PB_Image.TabStop = False
        '
        'BT_Sauv
        '
        Me.BT_Sauv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BT_Sauv.Location = New System.Drawing.Point(12, 518)
        Me.BT_Sauv.Name = "BT_Sauv"
        Me.BT_Sauv.Size = New System.Drawing.Size(150, 34)
        Me.BT_Sauv.TabIndex = 1
        Me.BT_Sauv.Text = "Sauvegarder"
        Me.BT_Sauv.UseVisualStyleBackColor = True
        '
        'BT_Supp
        '
        Me.BT_Supp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BT_Supp.Location = New System.Drawing.Point(362, 518)
        Me.BT_Supp.Name = "BT_Supp"
        Me.BT_Supp.Size = New System.Drawing.Size(150, 34)
        Me.BT_Supp.TabIndex = 2
        Me.BT_Supp.Text = "Supprimer"
        Me.BT_Supp.UseVisualStyleBackColor = True
        '
        'BT_AjoutImage
        '
        Me.BT_AjoutImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BT_AjoutImage.Location = New System.Drawing.Point(168, 518)
        Me.BT_AjoutImage.Name = "BT_AjoutImage"
        Me.BT_AjoutImage.Size = New System.Drawing.Size(188, 34)
        Me.BT_AjoutImage.TabIndex = 3
        Me.BT_AjoutImage.Text = "Ajouter Image"
        Me.BT_AjoutImage.UseVisualStyleBackColor = True
        '
        'OFP_Image
        '
        Me.OFP_Image.FileName = "Choisis le fichier"
        '
        'GarantyImage
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 564)
        Me.Controls.Add(Me.BT_AjoutImage)
        Me.Controls.Add(Me.BT_Supp)
        Me.Controls.Add(Me.BT_Sauv)
        Me.Controls.Add(Me.PB_Image)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "GarantyImage"
        Me.Text = "GarantyImage"
        CType(Me.PB_Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PB_Image As PictureBox
    Friend WithEvents BT_Sauv As Button
    Friend WithEvents BT_Supp As Button
    Friend WithEvents BT_AjoutImage As Button
    Friend WithEvents OFP_Image As OpenFileDialog
End Class
