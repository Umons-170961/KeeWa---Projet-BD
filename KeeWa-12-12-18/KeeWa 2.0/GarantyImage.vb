Public Class GarantyImage
    Private Sub GarantyImage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim PathDataSet As DataSet = Main.GetInfo("SELECT ScanTicket FROM Warranty WHERE idWarranty =" & GarantyWindow.idWarranty, "Warranty")
        If PathDataSet.Tables(0).Rows(0)("ScanTicket") <> "n/r" Then
            PB_Image.ImageLocation = PathDataSet.Tables(0).Rows(0)("ScanTicket")
        End If
    End Sub

    Private Sub BT_Sauv_Click(sender As Object, e As EventArgs) Handles BT_Sauv.Click
        Me.Close()
    End Sub

    Private Sub BT_Supp_Click(sender As Object, e As EventArgs) Handles BT_Supp.Click
        Dim PathDataSet As DataSet = Main.GetInfo("SELECT ScanTicket FROM Warranty WHERE idWarranty =" & GarantyWindow.idWarranty, "Warranty")
        If Not IsNothing(PathDataSet) Then
            My.Computer.FileSystem.DeleteFile(PathDataSet.Tables(0).Rows(0)("ScanTicket"))
        End If
        PB_Image.ImageLocation = ""
    End Sub

    ''' <summary>
    ''' Open window to choose the file to copy
    ''' </summary>
    Private Sub BT_AjoutImage_Click(sender As Object, e As EventArgs) Handles BT_AjoutImage.Click
        OFP_Image.ShowDialog()
    End Sub

    ''' <summary>
    ''' Oncy you clicked on OK it copies the file to the new loaction and rename it.
    ''' </summary>
    Private Sub OFP_Image_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OFP_Image.FileOk
        Dim PathDataSet As DataSet = Main.GetInfo("SELECT ScanTicket FROM Warranty WHERE idWarranty =" & GarantyWindow.idWarranty, "Warranty")
        If PathDataSet.Tables(0).Rows(0)("ScanTicket") <> "n/r" Then
            My.Computer.FileSystem.DeleteFile(PathDataSet.Tables(0).Rows(0)("ScanTicket"))
        End If
        Dim FileName As String = "C:\Users\Nathan K\Desktop\KeWa\" & GarantyWindow.idObject & "-" & GarantyWindow.idWarranty & "-" & OFP_Image.SafeFileName
        My.Computer.FileSystem.CopyFile(OFP_Image.FileName, FileName,
                Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
        PB_Image.ImageLocation = FileName
        Main.execute("UPDATE Warranty SET ScanTicket ='" & FileName & "' WHERE idWarranty =" & GarantyWindow.idWarranty)
    End Sub
End Class