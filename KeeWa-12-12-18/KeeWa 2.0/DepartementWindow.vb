Imports System.Data.OleDb

Public Class DepartementWindow
    ''' <summary>
    ''' This function opens itself at launch of this window and calls the loading function
    ''' </summary>
    Private Sub PersonWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loading()
    End Sub

    ''' <summary>
    ''' This function deletes the element with the selected name in CB_Modif
    ''' </summary>
    Private Sub BT_Supp_Click(sender As Object, e As EventArgs) Handles BT_Supp.Click
        Main.execute("DELETE FROM Contact WHERE NameDepartment = '" & CB_Modif.SelectedItem.ToString & "'")
        Main.execute("DELETE FROM Department WHERE Name ='" & CB_Modif.SelectedItem.ToString() & "'")
        loading()
    End Sub

    ''' <summary>
    ''' It is openened when the user click on the Save button
    ''' This function acts in 2 ways  :
    ''' If CB_Modif is disactevated (were creating a new Department) it will create a new department and link the contact to it
    ''' IF CB_Modif is activated (were modifieng a Department) it will apdaute the department that is selected in CB_Modif and delete and recreate the link with the contact
    ''' </summary>
    Private Sub BT_Sauv_Click(sender As Object, e As EventArgs) Handles BT_Sauv.Click
        If CB_Modif.Enabled = False Then
            Main.execute("INSERT INTO Department (Name, Email, Phone) VALUES ('" & TB_Nom.Text() & "','" & TB_Email.Text() & "','" & TB_Téléphone.Text() & "')")
            Dim UserDataSet As DataSet = Main.GetInfo("SELECT idUser FROM (SELECT [FirstName] & ' ' & [Name] AS FullName, idUser FROM Person) WHERE FullName='" & CB_PersCon.SelectedItem.ToString & "'", "idUser")
            Main.execute("INSERT INTO Contact (idUser, NameDepartment) VALUES (" & UserDataSet.Tables(0).Rows(0)("idUser") & " , '" & TB_Nom.Text & "')")
            If GarantyWindow.Visible() Then
                GarantyWindow.loading()
            End If
            Me.Close()
        Else
            Main.execute("UPDATE Department SET Name = '" & TB_Nom.Text() & "', Email = '" & TB_Email.Text() & "', Phone = '" & TB_Téléphone.Text() & "' WHERE Name = '" & CB_PersCon.SelectedItem.ToString & "'")
            Main.execute("DELETE FROM Contact WHERE NameDepartment = '" & CB_Modif.SelectedItem.ToString & "'")
            Dim UserDataSet As DataSet = Main.GetInfo("SELECT idUser FROM (SELECT [FirstName] & ' ' & [Name] AS FullName, idUser FROM Person) WHERE FullName='" & CB_PersCon.SelectedItem.ToString & "'", "idUser")
            Main.execute("INSERT INTO Contact (idUser, NameDepartment) VALUES (" & UserDataSet.Tables(0).Rows(0)("idUser") & " , '" & TB_Nom.Text & "')")
            loading()
        End If
    End Sub

    ''' <summary>
    ''' This function is called when the user change the selection of CB_Modif. It will fill the empty cases with the infos about the department
    ''' </summary>
    Private Sub CB_Modif_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Modif.SelectedIndexChanged
        If CB_Modif.Items.Contains(CB_Modif.SelectedItem()) Then
            BT_Sauv.Enabled = True
            BT_Supp.Enabled = True
            Dim ObjetDataSet As DataSet = Main.GetInfo("SELECT * FROM Department WHERE Name = '" & CB_Modif.SelectedItem.ToString() & "'", "Department")
            TB_Nom.DataBindings.Clear()
            TB_Email.DataBindings.Clear()
            TB_Téléphone.DataBindings.Clear()
            TB_Nom.DataBindings.Add("Text", ObjetDataSet, "Department.Name")
            TB_Téléphone.DataBindings.Add("Text", ObjetDataSet, "Department.Phone")
            TB_Email.DataBindings.Add("Text", ObjetDataSet, "Department.Email")
            ObjetDataSet = Main.GetInfo("SELECT FirstName & ' ' &  Name AS FullName FROM Person WHERE idUser = (SELECT idUser FROM Contact WHERE NameDepartment = '" & CB_Modif.SelectedItem.ToString() & "')", "FullName")
            If Not IsNothing(ObjetDataSet) Then
                CB_PersCon.SelectedText = ObjetDataSet.Tables(0).Rows(0)("FullName")
            End If

        Else
                BT_Sauv.Enabled = False
            BT_Supp.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' this function is there to initialise everything in function of if we are modifieng or creating a new element
    ''' </summary>
    Sub loading()
        If LBL_Modif.Enabled Then
            BT_Sauv.Enabled = False
            BT_Supp.Enabled = False
            CB_Modif.Items.Clear()
            TB_Email.Text() = ""
            TB_Nom.Text() = ""
            TB_Téléphone.Text() = ""
            Main.Remplissage("SELECT Name FROM Department", "Name", CB_Modif)
        Else
            BT_Supp.Enabled = True
            BT_Sauv.Enabled = True
        End If
        CB_PersCon.Items.Clear()
        Main.Remplissage("SELECT [FirstName] & ' ' & [Name] AS FullName FROM Person", "FullName", CB_PersCon)
    End Sub
End Class