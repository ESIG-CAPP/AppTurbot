﻿Public Class FrmSupportAccueil
    Private Sub FrmSupportAccueil_Load(sender As Object, e As EventArgs) Handles Me.Load
        TrUpdateLog.Interval = 1000 ' Définit l'intervalle de la minuterie à 1 minute (60000 millisecondes)
        TrUpdateLog.Start() ' Démarre la minuterie

        Dim FrmConnxion As New FrmConnexion()
        Dim userID As Integer = FrmConnexion.UserID

        lblNameSurname.Text = APP_UtilisateurTableAdapter.rqtGetUserNom(userID) & " " & APP_UtilisateurTableAdapter.rqtGetUserPrenom(userID)
        lblShowEmail.Text = APP_UtilisateurTableAdapter.rqtGetUserEmail(userID)

        lblShowName.Text = APP_UtilisateurTableAdapter.rqtGetUserNom(userID)
        lblShowSurname.Text = APP_UtilisateurTableAdapter.rqtGetUserPrenom(userID)
    End Sub

    Private Sub TrUpdateLog_Tick(sender As Object, e As EventArgs) Handles TrUpdateLog.Tick
        Dim dateDuJour As Date = Date.Now
        lblTime.Text = "Il est " & dateDuJour.ToString("HH:mm:ss")
    End Sub
    Private Sub btnModifyEmail_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmGestionCompte.Show()
        FrmGestionCompte.gbSettingsPassword.Enabled = False
        FrmGestionCompte.gbSettingsPassword.Visible = True
        FrmGestionCompte.gbSettingsEmail.Visible = True
        FrmGestionCompte.gbSettingsEmail.Enabled = True
    End Sub

    Private Sub btnModifyPassword_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmGestionCompte.Show()
        FrmGestionCompte.gbSettingsEmail.Enabled = False
        FrmGestionCompte.gbSettingsEmail.Visible = True
        FrmGestionCompte.gbSettingsPassword.Visible = True
        FrmGestionCompte.gbSettingsPassword.Enabled = True
    End Sub
    Private Sub btnModifyDelete_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmGestionCompte.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        FrmConnexion.efEmail.Text = ""
        FrmConnexion.efPassword.Text = ""
        FrmConnexion.efEmail.Select()

        'Afficher le formulaire de démarrage
        FrmConnexion.Show()
        Me.Hide()
    End Sub

    Private Sub btnManageTickets_Click(sender As Object, e As EventArgs) Handles btnManageTickets.Click
        FrmGestionTicket.Show()
    End Sub

    Private Sub btnModifyEmail_Click_1(sender As Object, e As EventArgs) Handles btnModifyEmail.Click
        Me.Hide()
        FrmGestionCompte.Show()
    End Sub

    Private Sub btnModifyPassword_Click_1(sender As Object, e As EventArgs) Handles btnModifyPassword.Click
        Me.Hide()
        FrmGestionCompte.Show()
    End Sub
End Class