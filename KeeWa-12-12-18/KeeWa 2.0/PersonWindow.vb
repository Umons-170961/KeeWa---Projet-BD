Imports System.Data.OleDb

Public Class PersonWindow
    ''' <summary>
    ''' This function launches itself at opening the opening of the PersonWindow. It loades the boxes
    ''' </summary>
    Private Sub PersonWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loading()
    End Sub

    ''' <summary>
    ''' It suppress an element that is choosen
    ''' </summary>
    Private Sub BT_Supp_Click(sender As Object, e As EventArgs) Handles BT_Supp.Click
        Main.execute("DELETE FROM Person WHERE idUser = (SELECT idUser FROM (SELECT [FirstName] & ' ' & [Name] AS FullName, idUser FROM Person) WHERE FullName='" & CB_Modif.SelectedItem.ToString() & "')")
        loading()
    End Sub

    ''' <summary>
    ''' If it is a new element it insert it in the database otherwise it will make an update
    ''' </summary>
    Private Sub BT_Sauv_Click(sender As Object, e As EventArgs) Handles BT_Sauv.Click
        If CB_Modif.Enabled = False Then
            Main.execute("INSERT INTO Person (Name, FirstName, Job, Email, Phone) VALUES ('" & TB_Nom.Text() & "','" & TB_Prénom.Text() & "','" & TB_Titre.Text() & "','" & TB_Email.Text() & "','" & TB_Téléphone.Text() & "')")
            If GarantyWindow.Visible() Then
                GarantyWindow.loading()
            End If
            Me.Close()
        Else
            Main.execute("UPDATE Person SET Name = '" & TB_Nom.Text() & "', FirstName = '" & TB_Prénom.Text() & "', Job = '" & TB_Titre.Text() & "', Email = '" & TB_Email.Text() & "', Phone = '" & TB_Téléphone.Text() & "' WHERE idUser = (SELECT idUser FROM (SELECT [FirstName] & ' ' & [Name] AS FullName, idUser FROM Person) WHERE FullName='" & CB_Modif.SelectedItem.ToString & "')")
            loading()
        End If
    End Sub

    ''' <summary>
    ''' If the text in the CB_Modif correspond to an element in the DB it will fill the infos of the page with it
    ''' </summary>
    Private Sub CB_Modif_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Modif.SelectedIndexChanged
        If CB_Modif.Items.Contains(CB_Modif.SelectedItem()) Then
            BT_Sauv.Enabled = True
            BT_Supp.Enabled = True
            Dim ObjetDataSet As DataSet = Main.GetInfo("SELECT * FROM Person WHERE idUser = (SELECT idUser FROM (SELECT [FirstName] & ' ' & [Name] AS FullName, idUser FROM Person) WHERE FullName='" & CB_Modif.SelectedItem.ToString() & "')", "Person")
            TB_Nom.DataBindings.Clear()
            TB_Prénom.DataBindings.Clear()
            TB_Email.DataBindings.Clear()
            TB_Titre.DataBindings.Clear()
            TB_Téléphone.DataBindings.Clear()
            TB_Nom.DataBindings.Add("Text", ObjetDataSet, "Person.Name")
            TB_Prénom.DataBindings.Add("Text", ObjetDataSet, "Person.FirstName")
            TB_Titre.DataBindings.Add("Text", ObjetDataSet, "Person.Job")
            TB_Téléphone.DataBindings.Add("Text", ObjetDataSet, "Person.Phone")
            TB_Email.DataBindings.Add("Text", ObjetDataSet, "Person.Email")
        Else
            BT_Sauv.Enabled = False
            BT_Supp.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' This function empties the boxes, refresh the CB_list (list of Person) and disables the 2 buttons if necessary
    ''' otherwise it enables the two buttons (Suppression and save)
    ''' </summary>
    Sub loading()
        If LBL_Modif.Enabled Then
            BT_Sauv.Enabled = False
            BT_Supp.Enabled = False
            CB_Modif.Items.Clear()
            TB_Email.Text() = ""
            TB_Nom.Text() = ""
            TB_Prénom.Text() = ""
            TB_Titre.Text() = ""
            TB_Téléphone.Text() = ""
            Main.Remplissage("SELECT [FirstName] & ' ' & [Name] AS FullName FROM Person", "FullName", CB_Modif)
        Else
            BT_Supp.Enabled = True
            BT_Sauv.Enabled = True
        End If
    End Sub
End Class