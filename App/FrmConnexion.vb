Public Class FrmConnexion

    Private Sub FrmConnexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_UtilisateurTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Utilisateur)

    End Sub

    Private Sub btnConnexion_Click(sender As Object, e As EventArgs) Handles btnConnexion.Click
        Dim rqtCheckMail As String = APP_UtilisateurTableAdapter.rqtCheckIfUserExist(efEmail.Text)
        If efEmail.Text = "" Or efMDP.Text = "" Then
            MessageBox.Show("Veuillez saisir vos informations de connexion!")
        Else
            If rqtCheckMail = 1 Then
                Dim rqtPassword As String = APP_UtilisateurTableAdapter.rqtGetPassword(efEmail.Text)
                Dim CheckPassword As Boolean = BCrypt.CheckPassword(efMDP.Text, rqtPassword)
                If CheckPassword Then
                    FrmAccueil.ShowDialog()
                    Me.Dispose()
                Else
                    MsgBox("Votre mot de passe est incorrect", MsgBoxStyle.Exclamation, "Attention !")
                    efMDP.Select()
                End If
            Else
                MsgBox("L'adresse mail est invalide !", MsgBoxStyle.Exclamation, "Attention !")
                efEmail.Select()
            End If
        End If
    End Sub

    Private Sub cbShowPasswordLogin_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPassword.CheckedChanged
        If cbShowPassword.Checked = True Then
            efMDP.PasswordChar = ""
        Else
            efMDP.PasswordChar = "*"
        End If
    End Sub

    Private Sub APP_UtilisateurBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TableAdapterManager.UpdateAll(Me.BDD_TurbotDataSet)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class