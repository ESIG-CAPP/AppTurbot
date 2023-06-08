Imports System.IO

Public Class FrmConnexion

    Public Property UserID As Integer

    Private Sub FrmConnexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_UtilisateurTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Utilisateur)
    End Sub
    Private Sub LogActivity(message As String)
        ' Définir le chemin complet du fichier de journal
        Dim projectFolder As String = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName
        Dim fileName As String = Path.Combine(projectFolder, "logs.txt")
        MsgBox(fileName)
        Try
            ' Écrire le message de journal dans le fichier
            Using writer As New StreamWriter(fileName, True)
                writer.WriteLine(DateTime.Now.ToString() & " - " & message)
            End Using
        Catch ex As Exception
            ' Gérer les erreurs lors de l'écriture du fichier
            MessageBox.Show("Une erreur s'est produite lors de l'enregistrement de l'activité de connexion : " & ex.Message)
        End Try
    End Sub

    Private Sub btnConnexion_Click(sender As Object, e As EventArgs) Handles btnConnexion.Click
        Dim rqtCheckMail As String = APP_UtilisateurTableAdapter.rqtCheckIfUserExist(efEmail.Text)
        If efEmail.Text = "" Or efPassword.Text = "" Then
            MessageBox.Show("Veuillez saisir vos informations de connexion!")
        Else
            If rqtCheckMail = 1 Then
                Dim rqtPassword As String = APP_UtilisateurTableAdapter.rqtGetPassword(efEmail.Text)
                Dim CheckPassword As Boolean = BCrypt.CheckPassword(efPassword.Text, rqtPassword)
                If CheckPassword Then
                    UserID = APP_UtilisateurTableAdapter.rqtGetUserID(efEmail.Text)
                    Dim FrmAccueil As New FrmAccueil()
                    FrmAccueil.UserID = UserID
                    LogActivity("Utilisateur connecté : " & efEmail.Text)
                    FrmAccueil.Show()
                    Me.Hide()

                Else
                    MsgBox("Votre mot de passe est incorrect", MsgBoxStyle.Exclamation, "Attention !")
                    efPassword.Select()
                End If
            Else
                MsgBox("L'adresse mail est invalide !", MsgBoxStyle.Exclamation, "Attention !")
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

    Private Sub efEmail_Enter(sender As Object, e As EventArgs) Handles efEmail.Enter
        If efEmail.Text = "Entrez votre adresse e-mail" Then
            efEmail.Text = ""
            efEmail.ForeColor = Color.Transparent ' Facultatif : vous pouvez modifier la couleur du texte si vous le souhaitez
        End If
    End Sub

    Private Sub efEmail_Leave(sender As Object, e As EventArgs) Handles efEmail.Leave
        If efEmail.Text = "" Then
            efEmail.Text = "Entrez votre adresse e-mail"
            efEmail.ForeColor = Color.White ' Facultatif : vous pouvez restaurer la couleur du texte d'origine si vous avez modifié sa couleur dans l'événement Enter
        End If
    End Sub

End Class