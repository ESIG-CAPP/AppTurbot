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
        Dim checkefMail As String = APP_UtilisateurTableAdapter.rqtCheckIfUserExist(efEmail.Text)
        Dim MyCon As New SqlConnection(My.Settings.BDD_TurbotConnectionString)
        Dim cmd As New SqlCommand()
        cmd.Connection = MyCon

        Try
            If checkefMail = True Then
                MsgBox("L'email saisi existe bien !")
                Dim newPassword As String = "password1234"
                MsgBox("Nouveau mot de passe : " & newPassword)
                cmd.CommandText = "INSERT INTO (UtilisateurPassword) VALUES (@newPassword)"
                cmd.Parameters.AddWithValue("@newPassword", newPassword)
            Else

                MsgBox("L'email saisi n'existe pas !")
                efEmail.Text = ""
                efEmail.Select()

            End If
        Catch ex As Exception
            MsgBox("Update excepted ", MsgBoxStyle.Critical, "Attention !")
        End Try

    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Application.Exit()
    End Sub
End Class