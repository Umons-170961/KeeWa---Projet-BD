Imports System.Data.OleDb

Public Class Main
    Public idObjectUsing As Integer = 0


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loading()
        ToolStripStatusLabel1.Text = "Base de donées Connectée"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_UtilListe.SelectedIndexChanged
        Dim UserDataSet As DataSet = GetInfo("SELECT * FROM (SELECT *, FirstName & ' ' & Name AS FullName FROM Person) WHERE FullName ='" & CB_UtilListe.SelectedItem.ToString() & "'", "Person")
        If Not IsNothing(UserDataSet) Then
            LBL_UtilNom.Text = UserDataSet.Tables(0).Rows(0)("FullName")
            LBL_UtilTel.Text = UserDataSet.Tables(0).Rows(0)("Phone")
            LBL_UtilTitre.Text = UserDataSet.Tables(0).Rows(0)("Job")
            LBL_UtilMail.Text = UserDataSet.Tables(0).Rows(0)("Email")
        End If
    End Sub


    Private Sub LB_Affichage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Affichage.SelectedIndexChanged
        If LB_Affichage.SelectedIndex > -1 Then
            Dim ObjectDataSet As DataSet = GetInfo("SELECT Objet.idObject FROM (SELECT Objet.Name & ' (' & DATEADD('m', Warranty.Duration, Warranty.Begining) & ')' AS FullName, objet.idObject FROM ((Objet INNER JOIN Object_Warranty ON Objet.idObject = Object_Warranty.idObject) INNER JOIN Warranty ON Object_Warranty.idWarranty = Warranty.idWarranty)) WHERE FullName = '" & LB_Affichage.SelectedItem.ToString & "'", "Object")
            If Not IsNothing(ObjectDataSet) Then
                Filling(ObjectDataSet.Tables(0).Rows(0)("idObject"))
            Else
                idObjectUsing = 0
            End If
        End If
    End Sub


    Private Sub BT_Recherche_Click(sender As Object, e As EventArgs) Handles BT_Recherche.Click
        Dim notEmpty As Boolean = False
        Dim search, searchLike As String
        search = "SELECT Objet.Name & ' (' & DATEADD('m', Warranty.Duration, Warranty.Begining) & ')' AS FullName FROM (Objet INNER JOIN Object_Warranty ON Objet.idObject = Object_Warranty.idObject) INNER JOIN Warranty ON Object_Warranty.idWarranty = Warranty.idWarranty WHERE 1 "
        searchLike = search
        If TB_RNom.Text <> "" Then
            search += "AND Objet.Name ='" & TB_RNom.Text & "'"
            searchLike += "AND Objet.Name LIKE '%" & TB_RNom.Text & "%'"
            notEmpty = True
        End If
        If TB_Numéro.Text <> "" Then
            search += "AND Num = " & TB_Numéro.Text
            searchLike += "AND Num LIKE '%" & TB_Numéro.Text & "%'"
            notEmpty = True
        End If
        'If TB_RMagasin.Text <> "" Then
        '    search += ""
        '    searchLike += ""
        '    notEmpty = True
        'End If
        If Not IsNothing(CB_RMar.SelectedItem) Then
            search += "AND Brand = '" & CB_RMar.SelectedItem.ToString & "'"
            searchLike += "AND Brand ='" & CB_RMar.SelectedItem.ToString & "'"
            notEmpty = True
        End If
        If Not IsNothing(CB_RType.SelectedItem) Then
            search += "AND Type = '" & CB_RType.SelectedItem.ToString & "'"
            searchLike += "AND Type = '" & CB_RType.SelectedItem.ToString & "'"
            MsgBox(CB_RType.SelectedItem.ToString)
            notEmpty = True
        End If
        If Not IsNothing(CB_RTags.SelectedItem) Then
            search += "AND Tag = '" & CB_RTags.SelectedItem.ToString & "'"
            searchLike += "AND Tag = '" & CB_RTags.SelectedItem.ToString & "'"
            notEmpty = True
        End If
        LB_Affichage.Items.Clear()

        If notEmpty Then
            Dim ObjectDataSet As DataSet = GetInfo(search, "Object")
            Dim ObjectLikeDataSet As DataSet = GetInfo(searchLike, "Object")
            If Not IsNothing(ObjectDataSet) Then
                For i As Integer = 0 To ObjectDataSet.Tables(0).Rows.Count - 1
                    LB_Affichage.Items.Add(ObjectDataSet.Tables(0).Rows(i)("FullName"))
                Next
            ElseIf Not IsNothing(ObjectLikeDataSet) Then
                For i As Integer = 0 To ObjectLikeDataSet.Tables(0).Rows.Count - 1
                    LB_Affichage.Items.Add(ObjectLikeDataSet.Tables(0).Rows(i)("FullName"))
                Next
            End If
        Else
            MsgBox("Nothing was Found")
        End If
    End Sub

    Private Sub BT_Effacer_Recherche_Click(sender As Object, e As EventArgs) Handles BT_Effacer_Recherche.Click
        CB_RMag.SelectedIndex = -1
        CB_RMar.SelectedIndex = -1
        TB_RNom.Text = ""
        CB_RType.SelectedIndex = -1
        CB_RTags.SelectedIndex = -1
        TB_Numéro.Text = ""
        loading()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BT_ModiferGarantie.Click
        GarantyWindow.NewObject = False
        GarantyWindow.Show()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BT_NewGarantie.Click
        GarantyWindow.NewObject = True
        GarantyWindow.Show()
    End Sub

    Private Sub AjouterGarantieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterGarantieToolStripMenuItem.Click
        GarantyWindow.NewObject = True
        GarantyWindow.Show()
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
    Private Sub AjouterDépartementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterDépartementToolStripMenuItem.Click
        DepartementWindow.CB_Modif.Enabled = False
        DepartementWindow.LBL_Modif.Enabled = False
        DepartementWindow.Show()
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
    Private Sub ModifierDépartementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierDépartementToolStripMenuItem.Click
        DepartementWindow.CB_Modif.Enabled = True
        DepartementWindow.LBL_Modif.Enabled = True
        DepartementWindow.Show()
    End Sub

    Sub execute(strSql As String)
        Dim Connection As OleDbConnection 'Déclaration Objet Connexion
        Dim strConn As String  'String contenant la Requête de connection
        strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Nathan K\Desktop\KeeWa\DataBase.accdb"
        Connection = New OleDbConnection
        Connection.ConnectionString = strConn 'Donner à la propriété 					ConnectionString les paramètres de connexion
        Connection.InitializeLifetimeService()
        Try
            Connection.Open()
            Dim Query As New OleDbCommand(strSql, Connection) ' Déclaration Objet Commande 
            Query.ExecuteNonQuery()
            Connection.Close()
        Catch ex As Exception
            MsgBox("Can't Open Connection" & vbCrLf & strSql & vbCrLf & ex.Message)
        End Try
    End Sub

    Function GetInfo(strSql As String, Name As String) As DataSet
        Dim ObjetConnection As OleDbConnection 'Déclaration Objet Connexion
        Dim strConn As String  'String contenant la Requête de connection
        strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Nathan K\Desktop\KeeWa\DataBase.accdb"
        ObjetConnection = New OleDbConnection
        ObjetConnection.ConnectionString = strConn 'Donner à la propriété 					ConnectionString les paramètres de connexion
        ObjetConnection.InitializeLifetimeService()
        Try
            ObjetConnection.Open()
            Dim ObjetCommand As OleDbCommand ' Déclaration Objet Commande 
            Dim ObjetDataAdapter As OleDbDataAdapter 'Déclaration Objet DataAdapter
            Dim ObjetDataSet As New DataSet 'Déclaration de l’Objet DataSet
            ObjetCommand = New OleDbCommand(strSql) 'Instancier un objet Commande
            ObjetDataAdapter = New OleDbDataAdapter(ObjetCommand) 'Instancier un objet Adapter
            ObjetCommand.Connection() = ObjetConnection 'initialiser l'objet Command
            ObjetDataAdapter.Fill(ObjetDataSet, Name) 'Avec l'aide de la propriété Fill
            ObjetConnection.Close()
            If ObjetDataSet.Tables(0).Rows.Count = 0 Then
                Return Nothing
            Else
                Return ObjetDataSet
            End If
        Catch ex As Exception
            MsgBox("ERROR in GetInfo()" & vbCrLf & strSql & vbCrLf & ex.Message)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' This function fills a ComboList or RichTextBox with element from a database
    ''' </summary>
    ''' <param name="strSql">Command used to get the element</param>
    ''' <param name="Type">Name of the element we want use to fill (has to be the same name as in the SQL command)</param>
    ''' <param name="Where">Object (RichTextBox or Combobox) where we want tu place our infos</param>
    Sub Remplissage(strSql As String, Type As String, Where As Object)
        Dim ObjectDataSet As DataSet = GetInfo(strSql, Type)
        Where.Items.Clear()
        If Not IsNothing(ObjectDataSet) Then
            For i As Integer = 0 To ObjectDataSet.Tables(0).Rows.Count - 1
                Where.Items.Add(ObjectDataSet.Tables(0).Rows(i)(Type))
            Next
        End If
    End Sub



    ''' <summary>
    ''' This function loads the page by adding the TOP10 and filling the first element
    ''' </summary>
    Sub loading()
        LB_Affichage.ResetText()
        Remplissage("SELECT TOP 10 Objet.Name & ' (' & DATEADD('m', Warranty.Duration, Warranty.Begining) & ')' AS FullName FROM (Objet INNER JOIN Object_Warranty ON Objet.idObject = Object_Warranty.idObject) INNER JOIN Warranty ON Object_Warranty.idWarranty = Warranty.idWarranty WHERE  DATEADD('m', Warranty.Duration, Warranty.Begining) > DATE()  ORDER BY  DATEADD('m', Warranty.Duration, Warranty.Begining) ASC", "FullName", LB_Affichage)
        If LB_Affichage.Items.Count <> 0 Then
            LB_Affichage.SetSelected(0, True)
        End If
        Dim ObjetDataSet As DataSet = GetInfo("SELECT TOP 1 Objet.idObject AS idObject FROM (Objet INNER JOIN Object_Warranty ON Objet.idObject = Object_Warranty.idObject) INNER JOIN Warranty ON Object_Warranty.idWarranty = Warranty.idWarranty WHERE  DATEADD('m', Warranty.Duration, Warranty.Begining) > DATE()  ORDER BY  DATEADD('m', Warranty.Duration, Warranty.Begining) ASC", "idObject")
        If Not IsNothing(ObjetDataSet) Then
            Filling(ObjetDataSet.Tables(0).Rows(0)("idObject"))
        Else
            idObjectUsing = 0
        End If

        Remplissage("SELECT Name & ' - ' & City AS FullName FROM Shop", "FullName", CB_RMag)
        Remplissage("SELECT Name FROM Brand", "Name", CB_RMar)
        Remplissage("SELECT Name FROM Type", "Name", CB_RType)
        Remplissage("SELECT Name FROM Tag", "Name", CB_RTags)
    End Sub


    Sub Filling(idObject As Integer)
        Dim ObjectDataSet As DataSet = GetInfo("SELECT * FROM Objet WHERE idObject = " & idObject & "", "Object")
        If Not IsNothing(ObjectDataSet) Then
            LBL_ObNom.Text = ObjectDataSet.Tables(0).Rows(0)("Name")
            LBL_ObNuméro.Text = ObjectDataSet.Tables(0).Rows(0)("Num")
            LBL_ObPrix.Text = ObjectDataSet.Tables(0).Rows(0)("Price") & "€"
            LBL_ObType.Text = ObjectDataSet.Tables(0).Rows(0)("Type")
        End If

        Dim StoreDataSet As DataSet = GetInfo("SELECT Name, Email, Website, Phone, Road & ' ' & RoadNumber & chr(10) & CP & ' ' & City AS Adresse FROM Shop WHERE idShop = " & ObjectDataSet.Tables(0).Rows(0)("idShop") & "", "Shop")
        If Not IsNothing(StoreDataSet) Then
            LBL_MagNom.Text = StoreDataSet.Tables(0).Rows(0)("Name")
            LBL_MagEmail.Text = StoreDataSet.Tables(0).Rows(0)("Email")
            LBL_MagSite.Text = StoreDataSet.Tables(0).Rows(0)("Website")
            LBL_MagTel.Text = "0" & StoreDataSet.Tables(0).Rows(0)("Phone")
            LBL_MagAddresse.Text = StoreDataSet.Tables(0).Rows(0)("Adresse")
        End If

        Dim CompanyDataSet As DataSet = GetInfo("SELECT * FROM Brand WHERE Name = '" & ObjectDataSet.Tables(0).Rows(0)("Brand") & "'", "Brand")
        If Not IsNothing(CompanyDataSet) Then
            LBL_MarNom.Text = CompanyDataSet.Tables(0).Rows(0)("Name")
            LBL_MarSite.Text = CompanyDataSet.Tables(0).Rows(0)("Website")
            LBL_MarQual.Text = "Qualité service : " & CompanyDataSet.Tables(0).Rows(0)("Valuation") & "/5"
            LBL_MarTel.Text = "0" & CompanyDataSet.Tables(0).Rows(0)("Phone")
        End If

        Dim DepartementDataSet As DataSet = GetInfo("SELECT * FROM Department WHERE Name = '" & ObjectDataSet.Tables(0).Rows(0)("Owner") & "'", "Department")
        If Not IsNothing(DepartementDataSet) Then
            LBL_DepNom.Text = DepartementDataSet.Tables(0).Rows(0)("Name")
            LBL_DepMail.Text = DepartementDataSet.Tables(0).Rows(0)("Email")
            LBL_DepTel.Text = "0" & DepartementDataSet.Tables(0).Rows(0)("Phone")
        End If
        DepartementDataSet = GetInfo("SELECT FirstName & ' ' &  Name AS FullName FROM Person WHERE idUser = (SELECT idUser FROM Contact WHERE NameDepartment = '" & DepartementDataSet.Tables(0).Rows(0)("Name") & "')", "FullName")
        If Not IsNothing(DepartementDataSet) Then
            LBL_DepPerCon.Text = DepartementDataSet.Tables(0).Rows(0)("FullName")
        End If

        Remplissage("SELECT Name FROM Tag, Object_Tag WHERE Tag.Name=Object_Tag.NameTag AND idObject =" & idObject, "Name", LB_Tags)

        Dim WarrantyDataSet As DataSet = GetInfo("SELECT Name, Prolongeable, Begining, Prolonged, DATEADD('m', Duration, Begining) AS Ending FROM (Warranty INNER JOIN Object_Warranty ON Object_Warranty.idWarranty = Warranty.idWarranty) WHERE idObject = " & idObject, "Warranty")
        If Not IsNothing(WarrantyDataSet) Then
            LBL_GarNomGar.Text = WarrantyDataSet.Tables(0).Rows(0)("Name")
            If WarrantyDataSet.Tables(0).Rows(0)("Prolongeable").Equals("True") Then
                LBL_GarProlonge.Text = "OUI"
            Else
                LBL_GarProlonge.Text = "NON"
            End If
            If WarrantyDataSet.Tables(0).Rows(0)("Prolonged").Equals("True") Then
                LBL_GarProlongé.Text = "OUI"
            Else
                LBL_GarProlongé.Text = "NON"
            End If
            LBL_GarDateFin.Text = WarrantyDataSet.Tables(0).Rows(0)("Ending")
            PB_GarProgression.Maximum = WarrantyDataSet.Tables(0).Rows(0)("Ending").Subtract(WarrantyDataSet.Tables(0).Rows(0)("Begining")).days
            If Today.Subtract(WarrantyDataSet.Tables(0).Rows(0)("Begining")).days < 0 Then
                PB_GarProgression.Value = 0
            Else
                PB_GarProgression.Value = Today.Subtract(WarrantyDataSet.Tables(0).Rows(0)("Begining")).days
            End If
            If WarrantyDataSet.Tables(0).Rows(0)("Ending").Subtract(Today).days < 15 Then
                ChangeProgBarColor(PB_GarProgression, ProgressBarColor.Red)
            ElseIf WarrantyDataSet.Tables(0).Rows(0)("Ending").Subtract(Today).days < 30 Then
                ChangeProgBarColor(PB_GarProgression, ProgressBarColor.Yellow)
            Else
                ChangeProgBarColor(PB_GarProgression, ProgressBarColor.Green)
            End If
        End If

        Remplissage("SELECT [FirstName] & ' ' & [Name] AS [FullName] FROM [Person], [Using] WHERE [Using].[idUser] = [Person].[idUser] AND [idObject] = " & idObject, "FullName", CB_UtilListe)
        If CB_UtilListe.Items.Count <> 0 Then
            CB_UtilListe.SelectedIndex = 0
        End If
        idObjectUsing = idObject
    End Sub


    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Enum ProgressBarColor
        Green = &H1
        Red = &H2
        Yellow = &H3
    End Enum
    Private Shared Sub ChangeProgBarColor(ByVal ProgressBar_name As Windows.Forms.ProgressBar, ByVal ProgressBar_Color As ProgressBarColor)
        SendMessage(ProgressBar_name.Handle, &H410, ProgressBar_Color, 0)
    End Sub


    Private Sub LBL_MagSite_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LBL_MagSite.LinkClicked
        Dim webAddress As String = LBL_MagSite.Text
        Process.Start(webAddress)
    End Sub

    Private Sub LBL_MarSite_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LBL_MarSite.LinkClicked
        Dim webAddress As String = LBL_MarSite.Text
        Process.Start(webAddress)
    End Sub

    Private Sub LBL_MagEmail_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LBL_MagEmail.LinkClicked
        Dim Outl As Object
        Outl = CreateObject("Outlook.Application")
        If Outl IsNot Nothing Then
            Dim omsg As Object
            omsg = Outl.CreateItem(0) '=Outlook.OlItemType.olMailItem'
            omsg.To = LBL_MagEmail.Text
            omsg.subject = LB_Affichage.SelectedItem.ToString
            omsg.Display(True) 'will display message to user
        End If
    End Sub

    Private Sub LBL_UtilMail_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LBL_UtilMail.LinkClicked
        Dim Outl As Object
        Outl = CreateObject("Outlook.Application")
        If Outl IsNot Nothing Then
            Dim omsg As Object
            omsg = Outl.CreateItem(0) '=Outlook.OlItemType.olMailItem'
            omsg.To = LBL_UtilMail.Text
            omsg.subject = LB_Affichage.SelectedItem.ToString
            omsg.Display(True) 'will display message to user
        End If
    End Sub

    Private Sub LBL_DepMail_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LBL_DepMail.LinkClicked
        Dim Outl As Object
        Outl = CreateObject("Outlook.Application")
        If Outl IsNot Nothing Then
            Dim omsg As Object
            omsg = Outl.CreateItem(0) '=Outlook.OlItemType.olMailItem'
            omsg.To = LBL_DepMail.Text
            omsg.subject = LB_Affichage.SelectedItem.ToString
            omsg.Display(True) 'will display message to user
        End If
    End Sub

    Private Sub ParamètresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParamètresToolStripMenuItem.Click
        Paramètres.Show()
    End Sub

    Private Sub AccéderAuxImagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccéderAuxImagesToolStripMenuItem.Click
        Process.Start("explorer.exe", "C:\Users\Nathan K\Desktop\")
    End Sub

    Private Sub AccéderÀLaBaseDeDonnéesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccéderÀLaBaseDeDonnéesToolStripMenuItem.Click
        Process.Start("explorer.exe", "C:\Users\Nathan K\Desktop\")
    End Sub
End Class