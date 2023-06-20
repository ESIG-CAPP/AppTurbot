Imports System.IO

Public Class FrmConnexion

    Public Property UserID As Integer

    Private Sub FrmConnexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_UtilisateurTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Utilisateur)
    End Sub

    Public Function FncCheckUserType(userType As String) As Boolean
        If userType = "admin" Then
            FrmAdminAccueil.Show()
        ElseIf userType = "support" Then
            FrmSupportAccueil.Show()
        Else
            FrmClientAccueil.Show()
        End If
    End Function


    ' Fonction LogActivity
    Private Sub LogActivity(message As String)
        ' Définir le chemin complet du fichier de journal
        Dim projectFolder As String = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName
        Dim fileName As String = Path.Combine(projectFolder, "logs.txt")
    End Sub

    Private Sub btnConnexion_Click(sender As Object, e As EventArgs) Handles btnConnexion.Click

        ' Récupération de l'existance de l'utilisateur à partir d'une requête sur le mail
        Dim rqtCheckMail As String = APP_UtilisateurTableAdapter.rqtCheckIfUserExist(efEmail.Text)
        If efEmail.Text = "" Or efPassword.Text = "" Then
            MessageBox.Show("Veuillez saisir vos informations de connexion!")
        Else
            ' Comparaison du mot de passe et récupération des données pour autoriser ou non l'accès
            If rqtCheckMail = 1 Then
                Dim rqtPassword As String = APP_UtilisateurTableAdapter.rqtGetPassword(efEmail.Text)
                Dim CheckPassword As Boolean = BCrypt.CheckPassword(efPassword.Text, rqtPassword)
                If CheckPassword Then
                    UserID = APP_UtilisateurTableAdapter.rqtGetUserID(efEmail.Text)

                    ' Variable permettant de stocker la date actuelle
                    Dim dateDuJour As Date = Date.Now
                    ' Affichage dans le fichier "logs.txt" l'activité de connexion de l'utilisateur
                    LogActivity("L'utilisateur " & efEmail.Text & " s'est connecté à " & dateDuJour.ToString("dd/MM/yyyy HH:mm:ss")) ' -> formattage de la donnée pour afficher la date et l'heure
                    FncCheckUserType(APP_UtilisateurTableAdapter.rqtGetUserType(UserID))
                    Me.Hide()
                Else

                    ' L'erreur vient quand la comparaison de le mot de passe est faux
                    MsgBox("Votre mot de passe est incorrect", MsgBoxStyle.Exclamation, "Attention !")
                    efPassword.Text = ""
                    efPassword.Select()
                End If
            Else
                ' L'erreur vient quand la comparaison de l'adresse mail est fausse
                MsgBox("L'adresse mail est invalide !", MsgBoxStyle.Exclamation, "Attention !")
                efEmail.Text = ""
                efEmail.Select()
            End If
        End If
    End Sub

    Private Sub cbShowPasswordLogin_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPassword.CheckedChanged
        If cbShowPassword.Checked = True Then
            efPassword.PasswordChar = ""
        Else
            efPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub APP_UtilisateurBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TableAdapterManager.UpdateAll(Me.BDD_TurbotDataSet)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub lkNewClient_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkNewClient.LinkClicked
        Me.Hide()
        FrmReinitialisation.Show()
    End Sub

    Private Sub lkResetPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkResetPassword.LinkClicked

    End Sub
End Class