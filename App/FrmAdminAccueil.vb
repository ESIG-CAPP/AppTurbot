Public Class FrmAdminAccueil
    Private Sub FrmAdminAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_UtilisateurTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Utilisateur)
        TrUpdateLog.Interval = 1000 ' Définit l'intervalle de la minuterie à 1 minute (60000 millisecondes)
        TrUpdateLog.Start() ' Démarre la minuterie

        Dim FrmConnxion As New FrmConnexion()
        Dim userID As Integer = FrmConnexion.UserID

        lblShowEmail.Text = APP_UtilisateurTableAdapter.rqtGetUserEmail(userID)
        lblNameSurname.Text = APP_UtilisateurTableAdapter.rqtGetUserNom(userID) & " " & APP_UtilisateurTableAdapter.rqtGetUserPrenom(userID)

        lblShowName.Text = APP_UtilisateurTableAdapter.rqtGetUserNom(userID)
        lblShowSurname.Text = APP_UtilisateurTableAdapter.rqtGetUserPrenom(userID)
    End Sub

    Private Sub TrUpdateLog_Tick(sender As Object, e As EventArgs) Handles TrUpdateLog.Tick
        Dim dateDuJour As Date = Date.Now
        lblTime.Text = "Il est " & dateDuJour.ToString("HH:mm:ss")
    End Sub

    Private Sub APP_UtilisateurBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.APP_UtilisateurBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDD_TurbotDataSet)
    End Sub

    Private Sub btnManageUsers_Click(sender As Object, e As EventArgs) Handles btnManageUsers.Click
        Me.Hide()
        FrmUtilisateurs.Show()
    End Sub

    Private Sub btnManageProduct_Click(sender As Object, e As EventArgs) Handles btnManageProduct.Click
        Me.Hide()
        FrmProduits.Show()
    End Sub

    Private Sub btnManageOrders_Click(sender As Object, e As EventArgs) Handles btnManageOrders.Click
        Me.Hide()
        FrmCommandes.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        FrmConnexion.efEmail.Text = ""
        FrmConnexion.efPassword.Text = ""
        FrmConnexion.efEmail.Select()
        FrmConnexion.Show()
        Me.Hide()
    End Sub

    Private Sub btnModifyEmail_Click(sender As Object, e As EventArgs) Handles btnModifyEmail.Click
        Me.Hide()
        FrmGestionCompte.Show()
    End Sub

    Private Sub btnModifyPassword_Click(sender As Object, e As EventArgs) Handles btnModifyPassword.Click
        Me.Hide()
        FrmGestionCompte.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmGestionCompte.Show()
    End Sub
End Class