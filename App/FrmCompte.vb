Public Class FrmCompte
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

    Private Sub btnGoHome_Click(sender As Object, e As EventArgs) Handles btnGoHome.Click
        Me.Hide()
        FrmAccueil.Show()
    End Sub

    Private Sub btnModifyEmail_Click(sender As Object, e As EventArgs) Handles btnModifyEmail.Click
        Me.Hide()
        FrmGestionCompte.Show()
        FrmGestionCompte.gbSettingsPassword.Enabled = False
        FrmGestionCompte.gbSettingsPassword.Visible = True
        FrmGestionCompte.gbSettingsEmail.Visible = True
        FrmGestionCompte.gbSettingsEmail.Enabled = True
    End Sub

    Private Sub btnModifyPassword_Click(sender As Object, e As EventArgs) Handles btnModifyPassword.Click
        Me.Hide()
        FrmGestionCompte.Show()
        FrmGestionCompte.gbSettingsEmail.Enabled = False
        FrmGestionCompte.gbSettingsEmail.Visible = True
        FrmGestionCompte.gbSettingsPassword.Visible = True
        FrmGestionCompte.gbSettingsPassword.Enabled = True
    End Sub

    Private Sub lblShowName_Click(sender As Object, e As EventArgs) Handles lblShowName.Click

    End Sub

    Private Sub lblShowSurname_Click(sender As Object, e As EventArgs) Handles lblShowSurname.Click

    End Sub
End Class
