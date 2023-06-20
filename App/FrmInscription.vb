Imports System.Data.SqlClient

Public Class FrmInscription
    Public Property UserID As Integer

    Private Function CheckedTypeUser()
        If rbSelectAdmin.Checked Then
            Return "admin"
        ElseIf rbSelectSupport.Checked Then
            Return "support"
        ElseIf rbSelectClient.Checked Then
            Return "client"
        End If
    End Function

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim MyCon As New SqlConnection(My.Settings.BDD_TurbotConnectionString)
        Dim cmd As New SqlCommand()
        cmd.Connection = MyCon

        Try
            ' Cryptage du mot de passe
            Dim hashedPassword = BCrypt.HashPassword(efPasswordRegister.Text)

            ' Dim UserID As Integer = APP_UtilisateurTableAdapter.rqtNmbUtilisateur() + 1

            cmd.CommandText = "INSERT INTO APP_Utilisateur (UtilisateurID, UtilisateurNom, UtilisateurPrenom, UtilisateurEmail, UtilisateurSexe, UtilisateurPassword, UtilisateurType)
                               VALUES (@UtilisateurNom, @UtilisateurPrenom, @UtilisateurEmail, @UtilisateurSexe, @UtilisateurPassword, @UtilisateurType)"

            cmd.Parameters.AddWithValue("@UtilisateurID", UserID)
            cmd.Parameters.AddWithValue("@UtilisateurNom", efNameRegister.Text)
            cmd.Parameters.AddWithValue("@UtilisateurPrenom", efSurnameRegister.Text)
            cmd.Parameters.AddWithValue("@UtilisateurEmail", efEmailRegister.Text)
            cmd.Parameters.AddWithValue("@UtilisateurSexe", efSexeRegister.Text)
            cmd.Parameters.AddWithValue("@UtilisateurPassword", hashedPassword)
            cmd.Parameters.AddWithValue("@UtilisateurType", CheckedTypeUser())

            MyCon.Open()
            cmd.ExecuteNonQuery()
            MyCon.Close()
            MsgBox("L'insription a été effectuée avec succès !", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Erreur : " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub FrmInscription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_UtilisateurTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Utilisateur)
    End Sub
End Class