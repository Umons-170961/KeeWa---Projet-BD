Imports System.Data.OleDb

Public Class CompanyWindow
    Private Sub CompanyWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loading()
    End Sub


    Private Sub BT_Supp_Click(sender As Object, e As EventArgs) Handles BT_Supp.Click
        Main.execute("DELETE FROM Brand WHERE Name = '" & CB_Modif.SelectedItem.ToString() & "'
")
        loading()
    End Sub


    Private Sub BT_Sauv_Click(sender As Object, e As EventArgs) Handles BT_Sauv.Click
        Dim Evaluation As Integer
        Evaluation = NUD_Qualité.Text()
        If CB_Modif.Enabled = False Then
            Main.execute("INSERT INTO Brand (Name, Website, Valuation, Phone) VALUES ('" & TB_Nom.Text() & "','" & TB_Site.Text() & "','" & Evaluation & "','" & TB_Téléphone.Text() & "')")
            If GarantyWindow.Visible() Then
                GarantyWindow.loading()
            End If
            Me.Close()
        Else
            Main.execute("UPDATE Brand SET Name = '" & TB_Nom.Text() & "', Website = '" & TB_Site.Text() & "', Valuation = '" & Evaluation & "', Phone = '" & TB_Téléphone.Text() & "' WHERE Name = '" & CB_Modif.SelectedItem.ToString() & "'")
            loading()
        End If
    End Sub


    Private Sub CB_Modif_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Modif.SelectedIndexChanged
        If CB_Modif.Items.Contains(CB_Modif.SelectedItem()) Then
            BT_Sauv.Enabled = True
            BT_Supp.Enabled = True
            Dim ObjetDataSet As DataSet = Main.GetInfo("SELECT * FROM Brand WHERE Name ='" & CB_Modif.SelectedItem.ToString() & "'", "Brand")
            TB_Nom.DataBindings.Clear()
            TB_Téléphone.DataBindings.Clear()
            TB_Site.DataBindings.Clear()
            NUD_Qualité.DataBindings.Clear()
            TB_Nom.DataBindings.Add("Text", ObjetDataSet, "Brand.Name")
            TB_Téléphone.DataBindings.Add("Text", ObjetDataSet, "Brand.Phone")
            TB_Site.DataBindings.Add("Text", ObjetDataSet, "Brand.Website")
            NUD_Qualité.DataBindings.Add("Text", ObjetDataSet, "Brand.Valuation")
        Else
            BT_Sauv.Enabled = False
            BT_Supp.Enabled = False
        End If
    End Sub


    Sub loading()
        If LBL_Modif.Enabled Then
            BT_Sauv.Enabled = False
            BT_Supp.Enabled = False
            CB_Modif.Items.Clear()
            TB_Nom.Text() = ""
            TB_Site.Text() = ""
            TB_Téléphone.Text() = ""
            NUD_Qualité.Value() = 0
            Main.Remplissage("SELECT Name FROM Brand", "Name", CB_Modif)
        Else
            BT_Supp.Enabled = True
            BT_Sauv.Enabled = True
        End If
    End Sub
End Class