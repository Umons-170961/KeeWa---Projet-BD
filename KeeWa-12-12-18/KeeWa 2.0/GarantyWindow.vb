'Le LBL_Modif permet de savoir si on part de 0 pour créer un objet (disabled) ou si on à déja une base (enabled)
Public Class GarantyWindow
    Public idObject As Integer
    Public WarrantyDataSet As DataSet
    Public idWarranty As Integer
    Public NewObject As Boolean = True
    Public CreatingWarranty As Boolean = False
    Public WarrantyNumber As Integer = 0

    Private Sub GarantyWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarrantyNumber = 0
        If NewObject Then
            Main.execute("INSERT INTO Objet (Name, Num, Price) VALUES ('temp','temp', 0)")
            Dim ObjetDataSet As DataSet = Main.GetInfo("SELECT TOP 1 idObject FROM Objet ORDER BY idObject DESC ", "idObject")
            idObject = ObjetDataSet.Tables(0).Rows(0)("idObject")
            loading() 'Ne pas déplaer
            ChangeStateWarrantyWindows(False, False)
        ElseIf Main.idObjectUsing <> 0 Then
            idObject = Main.idObjectUsing
            loading() 'Ne pas déplkacer
            ChangeStateWarrantyWindows(True, True)
            Filling()
        Else
            MsgBox("Pas d'objet sélectionné")
            Me.Close()
        End If
    End Sub

    Private Sub GarantyWindow_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        If CreatingWarranty Then
            Dim DeleteDataSet As DataSet = Main.GetInfo("SELECT idWarranty FROM Warranty WHERE Name = 'temp'", "Delete")
            If Not IsNothing(DeleteDataSet) Then
                For i As Integer = 0 To DeleteDataSet.Tables(0).Rows.Count - 1
                    Main.execute("DELETE FROM Object_Warranty WHERE idObject = " & idObject & "AND idWarranty = " & DeleteDataSet.Tables(0).Rows(i)("idWarranty"))
                    Main.execute("DELETE FROM Warranty WHERE Name = 'temp' AND idWarranty = " & DeleteDataSet.Tables(0).Rows(i)("idWarranty"))
                Next
            End If
        End If
        If NewObject Then
            Main.execute("DELETE FROM Objet WHERE Name = 'temp' AND idObject = " & idObject)
        End If
    End Sub


    Private Sub LB_Prop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Prop.SelectedIndexChanged
        If LB_Prop.SelectedItem.ToString.Equals("Ajouter un Département") Then
            DepartementWindow.CB_Modif.Enabled = False
            DepartementWindow.LBL_Modif.Enabled = False
            DepartementWindow.Show()
        End If
    End Sub
    Private Sub LB_Util_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Util.SelectedIndexChanged
        If LB_Util.SelectedItem.ToString.Equals("Ajouter une Personne") Then
            PersonWindow.CB_Modif.Enabled = False
            PersonWindow.LBL_Modif.Enabled = False
            PersonWindow.Show()
        End If
    End Sub
    Private Sub LB_Tags_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Tags.SelectedIndexChanged
        If LB_Tags.SelectedItem.ToString.Equals("Ajouter un Tag") Then
            TagWindow.CB_Modif.Enabled = False
            TagWindow.LBL_Modif.Enabled = False
            TagWindow.Show()
        End If
    End Sub
    Private Sub BT_Type_Click(sender As Object, e As EventArgs) Handles BT_Type.Click
        TypeWindow.CB_Modif.Enabled = False
        TypeWindow.LBL_Modif.Enabled = False
        TypeWindow.Show()
    End Sub
    Private Sub BT_Marque_Click(sender As Object, e As EventArgs) Handles BT_Marque.Click
        CompanyWindow.CB_Modif.Enabled = False
        CompanyWindow.LBL_Modif.Enabled = False
        CompanyWindow.Show()
    End Sub
    Private Sub BT_Magasin_Click(sender As Object, e As EventArgs) Handles BT_Magasin.Click
        StoreWindow.CB_Modif.Enabled = False
        StoreWindow.LBL_Modif.Enabled = False
        StoreWindow.Show()
    End Sub

    Private Sub AjouterPersonneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterPersonneToolStripMenuItem.Click
        PersonWindow.CB_Modif.Enabled = False
        PersonWindow.LBL_Modif.Enabled = False
        PersonWindow.Show()
    End Sub
    Private Sub AjouterMagasinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterMagasinToolStripMenuItem.Click
        StoreWindow.CB_Modif.Enabled = False
        StoreWindow.LBL_Modif.Enabled = False
        StoreWindow.Show()
    End Sub
    Private Sub AjouterMarqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterMarqueToolStripMenuItem.Click
        CompanyWindow.CB_Modif.Enabled = False
        CompanyWindow.LBL_Modif.Enabled = False
        CompanyWindow.Show()
    End Sub
    Private Sub AjouterTypeDobjetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterTypeDobjetToolStripMenuItem.Click
        TypeWindow.CB_Modif.Enabled = False
        TypeWindow.LBL_Modif.Enabled = False
        TypeWindow.Show()
    End Sub
    Private Sub AjouterTagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterTagToolStripMenuItem.Click
        TagWindow.CB_Modif.Enabled = False
        TagWindow.LBL_Modif.Enabled = False
        TagWindow.Show()
    End Sub

    Private Sub ModifierPersonneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierPersonneToolStripMenuItem.Click
        PersonWindow.CB_Modif.Enabled = True
        PersonWindow.LBL_Modif.Enabled = True
        PersonWindow.Show()
    End Sub
    Private Sub ModifierMagasinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierMagasinToolStripMenuItem.Click
        StoreWindow.CB_Modif.Enabled = True
        StoreWindow.LBL_Modif.Enabled = True
        StoreWindow.Show()
    End Sub
    Private Sub ModifierMarqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierMarqueToolStripMenuItem.Click
        CompanyWindow.CB_Modif.Enabled = True
        CompanyWindow.LBL_Modif.Enabled = True
        CompanyWindow.Show()
    End Sub
    Private Sub ModifierTypeDobjetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierTypeDobjetToolStripMenuItem.Click
        TypeWindow.CB_Modif.Enabled = True
        TypeWindow.LBL_Modif.Enabled = True
        TypeWindow.Show()
    End Sub
    Private Sub ModifierTagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierTagToolStripMenuItem.Click
        TagWindow.CB_Modif.Enabled = True
        TagWindow.LBL_Modif.Enabled = True
        TagWindow.Show()
    End Sub


    Private Sub BT_Supp_Click(sender As Object, e As EventArgs) Handles BT_Supp.Click
        If Not NewObject Then
            Dim WarrantyDataSet As DataSet = Main.GetInfo("SELECT idWarranty FROM Object_Warranty WHERE idObject = " & idObject, "idWarranty")
            If Not IsNothing(WarrantyDataSet) Then
                For i As Integer = 0 To WarrantyDataSet.Tables(0).Rows.Count - 1
                    Main.execute("DELETE FROM Object_Warranty WHERE idObject =" & idObject & "AND idWarranty = " & WarrantyDataSet.Tables(0).Rows(i)("idWarranty"))
                    Main.execute("DELETE FROM Warranty WHERE idWarranty =" & WarrantyDataSet.Tables(0).Rows(i)("idWarranty"))
                Next
            End If
            Main.execute("DELETE FROM Using WHERE idObject =" & idObject)
            Main.execute("DELETE FROM Object_Warranty WHERE idObject =" & idObject)
            Main.execute("DELETE FROM Object_Tag WHERE idObject =" & idObject)
            Main.execute("DELETE FROM Object WHERE idObject =" & idObject)
        Else
            'vider les element remplis
        End If
    End Sub
    Private Sub BT_Sauvegarder_Click(sender As Object, e As EventArgs) Handles BT_Sauvegarder.Click
        'Update the Object
        Main.execute("UPDATE Objet SET Name = '" & TB_Nom.Text & "', Num = '" & TB_Numéro.Text & "', Price = " & TB_Prix.Text & ", Type = '" & CB_Type.SelectedItem.ToString & "', Brand = '" & CB_Marque.SelectedItem.ToString & "', Owner = '" & LB_Prop.SelectedItem.ToString & "' WHERE idObject = " & idObject)
        'Update the shop
        Dim ShopDataSet As DataSet = Main.GetInfo("SELECT idShop FROM (SELECT [Name] & ' - ' & [City] as FullName, idShop FROM Shop) WHERE FullName = '" & CB_Magasin.SelectedItem.ToString & "'", "idShop")
        Dim idShop As Integer = ShopDataSet.Tables(0).Rows(0)("idShop")
        Main.execute("UPDATE Objet SET idShop = " & idShop & " WHERE idObject = " & idObject)
        'Add new Warranty in Object_Warranty
        Main.execute("DELETE FROM Object_Warranty WHERE idObject =" & idObject)
        If Not IsNothing(WarrantyDataSet) Then
            For i As Integer = 0 To WarrantyDataSet.Tables(0).Rows.Count - 1
                Main.execute("INSERT INTO Object_Warranty (idObject, idWarranty) VALUES (" & idObject & ", " & Integer.Parse(WarrantyDataSet.Tables(0).Rows(i)("Warranty.idWarranty")) & ")")
            Next
        End If
        'Add new Tags
        Main.execute("DELETE FROM Object_Tag WHERE idObject =" & idObject)
        If LB_Tags.SelectedItems.Count <> 0 Then
            For i As Integer = 0 To LB_Tags.SelectedItems.Count - 1
                Main.execute("INSERT INTO Object_Tag (idObject, NameTag) VALUES (" & idObject & ", '" & LB_Tags.SelectedItems(i).ToString & "')")
            Next
        End If
        'Add new Users
        Main.execute("DELETE FROM [Using] WHERE idObject =" & idObject)
        If LB_Util.SelectedItems.Count <> 0 Then
            For i As Integer = 0 To LB_Util.SelectedItems.Count - 1
                Dim UserDataSet As DataSet = Main.GetInfo("SELECT idUser FROM (SELECT  FirstName & ' ' & Name AS FullName, idUser FROM Person) WHERE FullName = '" & LB_Util.SelectedItems(i) & "'", "idUser")
                Dim idUser As Integer = UserDataSet.Tables(0).Rows(0)("idUser")
                Main.execute("INSERT INTO [Using] (idObject, idUser) VALUES (" & idObject & ", " & idUser & ")")
            Next
        End If
        NewObject = False
        loading()
    End Sub


    Sub Filling()
        Dim ObjectDataSet As DataSet = Main.GetInfo("SELECT * FROM Objet WHERE idObject = " & idObject, "Objet")
        TB_Nom.Text = ObjectDataSet.Tables(0).Rows(0)("Name")
        TB_Numéro.Text = ObjectDataSet.Tables(0).Rows(0)("Num")
        TB_Prix.Text = ObjectDataSet.Tables(0).Rows(0)("Price")
        CB_Type.SelectedItem = ObjectDataSet.Tables(0).Rows(0)("Type")
        CB_Marque.SelectedItem = ObjectDataSet.Tables(0).Rows(0)("Brand")
        LB_Prop.SelectedItem = ObjectDataSet.Tables(0).Rows(0)("Owner")

        Dim TagDataSet As DataSet = Main.GetInfo("SELECT NameTag FROM Object_Tag WHERE idObject =" & idObject, "Tags")
        If Not IsNothing(TagDataSet) Then
            For i As Integer = 0 To TagDataSet.Tables(0).Rows.Count - 1
                LB_Tags.SelectedItem = TagDataSet.Tables(0).Rows(i)("NameTag")
            Next
        End If

        Dim UserDataSet As DataSet = Main.GetInfo("SELECT FirstName & ' ' & Name AS FullName FROM ([Using] INNER JOIN Person ON [Using].idUser = Person.idUser) WHERE idObject =" & idObject, "User")
        If Not IsNothing(UserDataSet) Then
            For i As Integer = 0 To UserDataSet.Tables(0).Rows.Count - 1
                LB_Util.SelectedItem = UserDataSet.Tables(0).Rows(i)("FullName")
            Next
        End If

        Dim ShopDataSet As DataSet = Main.GetInfo("SELECT Name & ' - ' & City AS FullName FROM Shop WHERE idShop =" & ObjectDataSet.Tables(0).Rows(0)("idShop"), "Shop")
        CB_Magasin.SelectedItem = ShopDataSet.Tables(0).Rows(0)("FullName")

    End Sub



    Private Sub BT_AjoutImage_Click(sender As Object, e As EventArgs) Handles BT_AjoutImage.Click
        GarantyImage.Show()
    End Sub

    'bug dans le cas d'une suppression ou il existe plus d'un élément
    Private Sub BuT_GarSupp_Click(sender As Object, e As EventArgs) Handles BT_GarSupp.Click
        If CreatingWarranty Then
            ChangeStateWarrantyWindows(True, False)
            CreatingWarranty = False
        Else
            If Not IsNothing(WarrantyDataSet) Then
                For i As Integer = 0 To WarrantyDataSet.Tables(0).Rows.Count - 1
                    If CB_NomGarantie.SelectedItem.ToString.Equals(WarrantyDataSet.Tables(0).Rows(i)("Name").ToString()) Then
                        Main.execute("DELETE FROM Object_Warranty WHERE idWarranty = " & Integer.Parse(WarrantyDataSet.Tables(0).Rows(i)("Warranty.idWarranty")))
                        Main.execute("DELETE FROM Warranty WHERE idWarranty = " & Integer.Parse(WarrantyDataSet.Tables(0).Rows(i)("Warranty.idWarranty")))
                        WarrantyNumber -= 1
                    End If
                Next
            End If
        End If
        loadingWarrenty()
    End Sub
    Private Sub BT_GarSauv_Click(sender As Object, e As EventArgs) Handles BT_GarSauv.Click
        Main.execute("UPDATE Warranty SET Name = '" & TB_GarNom.Text() & "', Begining = '" & MC_Date.SelectionStart.ToString() & "', Duration = " & NUD_Mois.Value() & ", Prolonged = '" & CB_Prolong.Checked & "', Prolongeable = '" & CB_Prolongeable.Checked & "' WHERE idWarranty =" & idWarranty)
        ChangeStateWarrantyWindows(True, False)
        loadingWarrenty()
        CreatingWarranty = False
        BT_GarAdd.Enabled = True
    End Sub
    Private Sub BT_GarAdd_Click(sender As Object, e As EventArgs) Handles BT_GarAdd.Click
        WarrantyNumber += 1
        CreatingWarranty = True
        Main.execute("INSERT INTO Warranty (Name) VALUES ('temp')")
        Dim WarrantyDataSet As DataSet = Main.GetInfo("SELECT TOP 1 idWarranty FROM Warranty ORDER BY idWarranty DESC ", "idObject")
        idWarranty = WarrantyDataSet.Tables(0).Rows(0)("idWarranty")
        Main.execute("INSERT INTO Object_Warranty (idObject, idWarranty) VALUES (" & idObject & "," & idWarranty & ")")
        ChangeStateWarrantyWindows(False, True)
        CB_NomGarantie.Items.Clear()
        TB_GarNom.Text = ""
        MC_Date.SetDate(MC_Date.TodayDate)
        NUD_Mois.Value = 0
        CB_Prolong.Checked = False
        CB_Prolongeable.Checked = False
        BT_GarAdd.Enabled = False
    End Sub

    Private Sub CB_NomGarantie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_NomGarantie.SelectedIndexChanged
        ChangeStateWarrantyWindows(True, True)
        If Not IsNothing(WarrantyDataSet) Then
            For i As Integer = 0 To WarrantyDataSet.Tables(0).Rows.Count - 1
                If CB_NomGarantie.SelectedItem.ToString.Equals(WarrantyDataSet.Tables(0).Rows(i)("Name").ToString()) Then
                    TB_GarNom.Text = WarrantyDataSet.Tables(0).Rows(i)("Name").ToString
                    MC_Date.SelectionStart = WarrantyDataSet.Tables(0).Rows(i)("Begining").ToString
                    MC_Date.SelectionEnd = WarrantyDataSet.Tables(0).Rows(i)("Begining").ToString
                    NUD_Mois.Value = WarrantyDataSet.Tables(0).Rows(i)("Duration").ToString
                    CB_Prolongeable.Checked = WarrantyDataSet.Tables(0).Rows(i)("Prolongeable")
                    CB_Prolong.Checked = WarrantyDataSet.Tables(0).Rows(i)("Prolonged")
                    idWarranty = WarrantyDataSet.Tables(0).Rows(i)("Warranty.idWarranty")
                End If
            Next
        End If
    End Sub

    Sub ChangeStateWarrantyWindows(CB As Boolean, Info As Boolean)
        CB_NomGarantie.Enabled = CB
        LBL_NomGarantie.Enabled = CB
        BT_AjoutImage.Enabled = Info
        BT_GarSauv.Enabled = Info
        BT_GarSupp.Enabled = Info
        GB_Date.Enabled = Info
        CB_Prolong.Enabled = Info
        CB_Prolongeable.Enabled = Info
        NUD_Mois.Enabled = Info
        TB_GarNom.Enabled = Info
        LBL_Durée.Enabled = Info
        LBL_Mois.Enabled = Info
        LBL_NomGar.Enabled = Info
    End Sub



    Sub loading()
        Main.Remplissage("SELECT Name FROM Type", "Name", CB_Type)
        Main.Remplissage("SELECT [Name] & ' - ' & [City] As FullName FROM Shop", "FullName", CB_Magasin)
        Main.Remplissage("SELECT Name FROM Brand", "Name", CB_Marque)

        Main.Remplissage("SELECT [FirstName] & ' ' & [Name] AS FullName FROM Person", "FullName", LB_Util)
        LB_Util.Items.Add("Ajouter une Personne")
        Main.Remplissage("SELECT Name FROM Department", "Name", LB_Prop)
        LB_Prop.Items.Add("Ajouter un Département")
        Main.Remplissage("SELECT Name FROM Tag", "Name", LB_Tags)
        LB_Tags.Items.Add("Ajouter un Tag")
        loadingWarrenty()
    End Sub

    Sub loadingWarrenty()
        CB_NomGarantie.Items.Clear()
        TB_GarNom.Text = ""
        MC_Date.SetDate(MC_Date.TodayDate)
        NUD_Mois.Value = 0
        CB_Prolong.Checked = False
        CB_Prolongeable.Checked = False
        'If Not NewObject Then
        Main.Remplissage("SELECT Name FROM Warranty INNER JOIN Object_Warranty ON Warranty.idWarranty = Object_Warranty.idWarranty WHERE idObject = " & idObject, "Name", CB_NomGarantie)
        WarrantyDataSet = Main.GetInfo("SELECT *, Warranty.idWarranty FROM Warranty INNER JOIN Object_Warranty ON Warranty.idWarranty = Object_Warranty.idWarranty WHERE idObject = " & idObject, "Warranty")
        If Not IsNothing(WarrantyDataSet) Then
            WarrantyNumber = WarrantyDataSet.Tables(0).Rows.Count
        Else
            WarrantyNumber = 0
        End If
        'ElseIf WarrantyNumber > 0 Then
        '    Main.Remplissage("SELECT TOP " & WarrantyNumber & " Name FROM Warranty ORDER BY idWarranty DESC", "Name", CB_NomGarantie)
        '    WarrantyDataSet = Main.GetInfo("SELECT TOP " & WarrantyNumber & " * FROM Warranty ORDER BY idWarranty DESC", "Warranty")
        'End If
        If CB_NomGarantie.Items.Count <> 0 Then
            CB_NomGarantie.SelectedIndex = 0
        End If
    End Sub
End Class