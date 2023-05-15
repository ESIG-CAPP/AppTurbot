Public Class FrmConnexion

    Private Sub FrmConnexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_UtilisateurTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Utilisateur)

    End Sub

    Private Sub btnConnexion_Click(sender As Object, e As EventArgs) Handles btnConnexion.Click
        Dim rqtCheckMail As String = APP_UtilisateurTableAdapter.rqtCheckIfUserExist(efEmail.Text)
        If rqtCheckMail = 1 Then
            Dim rqtPassword As String = APP_UtilisateurTableAdapter.rqtGetPassword(efEmail.Text)
            Dim CheckPassword As Boolean = BCrypt.CheckPassword(efMDP.Text, rqtPassword)
            If CheckPassword Then
                FrmAcceuil.ShowDialog()
            Else
                lblErreur.Text = "Mot de passe incorrect"
            End If
        Else
            lblErreur.Text = "Aucun compte n'existe avec cette adresse email"
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

End Class