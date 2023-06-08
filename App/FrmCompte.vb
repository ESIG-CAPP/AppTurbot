Public Class FrmCompte

    Public Property Icone As Icon
    Public Property UserID As Integer

    Private Sub FrmCompte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_UtilisateurTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Utilisateur)
        Dim FrmConnxion As New FrmConnexion()
        Dim userID As Integer = FrmConnexion.UserID
        lblShowName.Text = APP_UtilisateurTableAdapter.rqtGetUserNom(userID)
        lblShowSurname.Text = APP_UtilisateurTableAdapter.rqtGetUserPrenom(userID)
        lblShowEmail.Text = APP_UtilisateurTableAdapter.rqtGetUserEmail(userID)
        lblShowName.TextAlign = ContentAlignment.MiddleRight
        lblShowSurname.TextAlign = ContentAlignment.MiddleRight
    End Sub

    Private Sub APP_UtilisateurBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.APP_UtilisateurBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDD_TurbotDataSet)

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        FrmConnexion.Show()
        FrmConnexion.efEmail.Text = ""
        FrmConnexion.efPassword.Text = ""
    End Sub

End Class
