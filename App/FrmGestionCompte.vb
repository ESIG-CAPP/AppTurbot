Imports System.Data.SqlClient

Public Class FrmGestionCompte

    'Création d'une connexion manuel pour accéder aux donneés de la base de données
    Dim MyCon As New SqlConnection(My.Settings.BDD_TurbotConnectionString)

    Public Property UserID As Integer

    Private Sub FrmGestionCompte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_UtilisateurTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Utilisateur)
        Dim userID As Integer = FrmConnexion.UserID
        lblCurrentEmail.Text = APP_UtilisateurTableAdapter.rqtGetUserEmail(userID)

    End Sub

    Private Sub APP_UtilisateurBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TableAdapterManager.UpdateAll(Me.BDD_TurbotDataSet)
    End Sub

    Private Sub btnGoCompte_Click(sender As Object, e As EventArgs) Handles btnGoCompte.Click
        Me.Hide()
        FrmCompte.Show()
    End Sub

    Private Sub btnUpdateEmail_Click(sender As Object, e As EventArgs) Handles btnUpdateEmail.Click
        'On crée un variable permettant de stocker des nouvelles commandes SQL
        Dim cmd As New SqlCommand()
        cmd.Connection = MyCon

        Try
            If lblCurrentEmail.Text = efNewEmail.Text Then
                MsgBox("L'adresse e-mail est la même ! Veuillez en choisir une autre.", MsgBoxStyle.Exclamation, "Mise à jour impossible de l'adresse email")
                efNewEmail.Text = ""
                efNewEmail.Select()
            Else
                cmd.CommandText = "UPDATE APP_Utilisateur SET UtilisateurEmail = @newEmail WHERE UtilisateurEmail = @currentEmail"
                cmd.Parameters.AddWithValue("@newEmail", efNewEmail.Text)
                cmd.Parameters.AddWithValue("@currentEmail", lblCurrentEmail.Text)
            End If
            MyCon.Open()
            cmd.ExecuteNonQuery()
            MyCon.Close()
            MsgBox("L'e-mail a été mis à jour !", MsgBoxStyle.Information, "Mise à jour réussie")
            lblCurrentEmail.Text = efNewEmail.Text
        Catch ex As Exception
            MsgBox("Le champ ne peut pas être vide", MsgBoxStyle.Critical, "Attention !")
            MyCon.Close()
        End Try
    End Sub

    Private Sub btnUpdatePassword_Click(sender As Object, e As EventArgs) Handles btnUpdatePassword.Click
        Dim cmd As New SqlCommand()
        cmd.Connection = MyCon

        Try
            If efCurrentPassword.Text = efNewPassword.Text Then
                MsgBox("Le mot de passe est le même ! Veuillez en choisir un autre.", MsgBoxStyle.Exclamation, "Mise à jour impossible du mot de passe")
                efNewPassword.Text = ""
                efNewPassword.Select()
            Else
                Dim newPassword As String = BCrypt.HashPassword(efNewPassword.Text)

                cmd.CommandText = "UPDATE App_Utilisateur SET UtilisateurPassword = @newPassword WHERE UtilisateurEmail = @currentEmail"
                cmd.Parameters.AddWithValue("@newPassword", newPassword)
                cmd.Parameters.AddWithValue("@currentEmail", lblCurrentEmail.Text)

                MyCon.Open()
                cmd.ExecuteNonQuery()
                MyCon.Close()
                MsgBox("Le mot de passe a été mis à jour !", MsgBoxStyle.Information, "Mise à jour réussie")
            End If
        Catch ex As Exception
            MsgBox("Le champ ne peut pas être vide", MsgBoxStyle.Critical, "Attention !")
            MyCon.Close()
        End Try
    End Sub

    Private Sub btnUpdateAccount_Click(sender As Object, e As EventArgs) Handles btnUpdateAccount.Click
        Dim cmd As New SqlCommand()
        cmd.Connection = MyCon

        Try
            If efNewName.Text = APP_UtilisateurTableAdapter.rqtGetUserNom(UserID) Or efNewSurname.Text = APP_UtilisateurTableAdapter.rqtGetUserPrenom(UserID) Then
                MsgBox("Le nom ou le prénom sont le même. Merci d'en choisir un autre.", MsgBoxStyle.Exclamation, "Mise à jour impossible du nom")
            Else
                cmd.CommandText = "UPDATE App_Utilisateur SET UtilisateurNom = @newName, UtilisateurPrenom = @newSurname WHERE UtilisateurEmail = @currentEmail"
                cmd.Parameters.AddWithValue("@newName", efNewName.Text)
                cmd.Parameters.AddWithValue("@newSurname", efNewSurname.Text)
                cmd.Parameters.AddWithValue("@currentEmail", lblCurrentEmail.Text)

                MyCon.Open()
                cmd.ExecuteNonQuery()
                MyCon.Close()
                MsgBox("Vos données ont été mis à jour !", MsgBoxStyle.Information, "Mise à jour réussie")

                efNewName.Text = FrmCompte.lblShowName.Text
                efNewSurname.Text = FrmCompte.lblShowSurname.Text

                efNewName.Text = ""
                efNewSurname.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Erreur" & ex.Message)
        End Try
    End Sub

    Private Sub gbSettingsEmail_Enter(sender As Object, e As EventArgs) Handles gbSettingsEmail.Enter

    End Sub

    Private Sub gbSettingsPassword_Enter(sender As Object, e As EventArgs) Handles gbSettingsPassword.Enter

    End Sub

    Private Sub efNewName_TextChanged(sender As Object, e As EventArgs) Handles efNewName.TextChanged

    End Sub
End Class
