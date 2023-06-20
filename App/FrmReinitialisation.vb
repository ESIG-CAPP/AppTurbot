Imports System.Text
Imports System.Data.SqlClient

Public Class FrmReinitialisation
    Private Sub FrmReinitialisation_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_UtilisateurTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Utilisateur)

    End Sub

    Function GenerateRandomPassword() As String
        Dim r As New Random()
        Dim passwordLength As Integer = r.Next(15, 33)
        Dim chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim password As New StringBuilder()

        For i As Integer = 1 To passwordLength
            Dim randomIndex As Integer = r.Next(0, chars.Length)
            password.Append(chars(randomIndex))
        Next

        Return password.ToString()
    End Function

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim MyCon As New SqlConnection(My.Settings.BDD_TurbotConnectionString)
        Dim cmd As New SqlCommand()
        cmd.Connection = MyCon

        Try
            Dim usersExist As Double
            If Double.TryParse(APP_UtilisateurTableAdapter.rqtCheckIfUserExist(efEmail.Text), usersExist) Then
                MsgBox("Mail correct !")
                Dim newPassword As String = "password1234"

                ' Cryptage du nouveau mot de passe
                Dim hashedPassword As String = BCrypt.HashPassword(newPassword)

                ' Mise à jour du mot de passe dans la base de données avec une commande UPDATE
                cmd.CommandText = "UPDATE APP_Utilisateur SET UtilisateurPassword = @newPassword WHERE UtilisateurEmail = @currentEmail"
                cmd.Parameters.AddWithValue("@newPassword", hashedPassword)
                cmd.Parameters.AddWithValue("@currentEmail", efEmail.Text)

                ' Ouverture de la connexion
                MyCon.Open()

                ' Exécuter la commande pour mettre à jour la base de données
                cmd.ExecuteNonQuery()

                ' Fermeture de la connexion
                MyCon.Close()

                MsgBox("Le mot de passe a été réinitialisé avec succès.")
            Else
                MsgBox("Mail erroné ! Veuillez saisir un mail correct")
                efEmail.Text = ""
                efEmail.Select()
            End If
        Catch ex As Exception
            MsgBox("Une erreur s'est produite lors de la réinitialisation du mot de passe : " & ex.Message, MsgBoxStyle.Critical, "Attention !")
        End Try

    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Me.Hide()
        FrmConnexion.Show()
    End Sub
End Class