Imports System.Data.OleDb

Public Class StoreWindow

    Private Sub StoreWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loading()
    End Sub


    Private Sub BT_Supp_Click(sender As Object, e As EventArgs) Handles BT_Supp.Click
        Main.execute("DELETE FROM Shop WHERE idShop = (SELECT idShop FROM (SELECT [Name] & ' - ' & [City] AS FullName, idShop FROM Shop) WHERE FullName='" & CB_Modif.SelectedItem.ToString() & "')")
        loading()
    End Sub


    Private Sub BT_Sauv_Click(sender As Object, e As EventArgs) Handles BT_Sauv.Click
        Dim Phone, RoadNumber, CP As Integer
        Phone = TB_Téléphone.Text()
        CP = TB_CP.Text()
        RoadNumber = TB_Numéro.Text()
        If CB_Modif.Enabled = False Then
            Main.execute("INSERT INTO Shop (Road, Name, Email, Website, Phone, CP, City, RoadNumber) VALUES ('" & TB_Rue.Text() & "','" & TB_Nom.Text() & "','" & TB_Email.Text() & "','" & TB_Site.Text() & "','" & Phone & "','" & CP & "','" & TB_Ville.Text() & "','" & RoadNumber & "')")
            If GarantyWindow.Visible() Then
                GarantyWindow.loading()
            End If
            Me.Close()
        Else
            Main.execute("UPDATE Shop SET Name = '" & TB_Nom.Text() & "', Road = '" & TB_Rue.Text() & "', Email = '" & TB_Email.Text() & "', Website = '" & TB_Site.Text() & "', Phone = '" & Phone & "', CP = '" & CP & "', City = '" & TB_Ville.Text() & "', RoadNumber = '" & RoadNumber & "' WHERE idShop = (SELECT idShop FROM (SELECT [Name] & ' - ' & [City] AS FullName, idShop FROM Shop) WHERE FullName='" & CB_Modif.SelectedItem.ToString() & "')")
            loading()
        End If
    End Sub


    Private Sub CB_Modif_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Modif.SelectedIndexChanged
        If CB_Modif.Items.Contains(CB_Modif.SelectedItem()) Then
            BT_Sauv.Enabled = True
            BT_Supp.Enabled = True
            Dim ObjetDataSet As DataSet = Main.GetInfo("SELECT * FROM Shop WHERE idShop = (SELECT idShop FROM (SELECT [Name] & ' - ' & [City] AS FullName, idShop FROM Shop) WHERE FullName='" & CB_Modif.SelectedItem.ToString() & "')", "Shop")
            TB_Nom.DataBindings.Clear()
            TB_Ville.DataBindings.Clear()
            TB_Email.DataBindings.Clear()
            TB_CP.DataBindings.Clear()
            TB_Téléphone.DataBindings.Clear()
            TB_Site.DataBindings.Clear()
            TB_Rue.DataBindings.Clear()
            TB_Numéro.DataBindings.Clear()
            TB_Nom.DataBindings.Add("Text", ObjetDataSet, "Shop.Name")
            TB_Ville.DataBindings.Add("Text", ObjetDataSet, "Shop.City")
            TB_Email.DataBindings.Add("Text", ObjetDataSet, "Shop.Email")
            TB_Téléphone.DataBindings.Add("Text", ObjetDataSet, "Shop.Phone")
            TB_CP.DataBindings.Add("Text", ObjetDataSet, "Shop.CP")
            TB_Site.DataBindings.Add("Text", ObjetDataSet, "Shop.Website")
            TB_Rue.DataBindings.Add("Text", ObjetDataSet, "Shop.Road")
            TB_Numéro.DataBindings.Add("Text", ObjetDataSet, "Shop.RoadNumber")
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
            TB_Email.Text() = ""
            TB_Nom.Text() = ""
            TB_CP.Text() = ""
            TB_Numéro.Text() = ""
            TB_Rue.Text() = ""
            TB_Site.Text() = ""
            TB_Ville.Text() = ""
            TB_Téléphone.Text() = ""
            Main.Remplissage("SELECT [Name] & ' - ' & [City] AS FullName FROM Shop", "FullName", CB_Modif)
        Else
            BT_Supp.Enabled = True
            BT_Sauv.Enabled = True
        End If
    End Sub
End Class