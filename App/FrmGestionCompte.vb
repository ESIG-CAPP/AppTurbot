Public Class FrmGestionCompte
    Public Property Icone As Icon
    Private Sub FrmGestionCompte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_UtilisateurTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Utilisateur)
        ' Vérifier si une icône a été transmise depuis FrmCompte
        If Icone IsNot Nothing Then
            Me.Icon = Icone
        End If
    End Sub

    Private Sub APP_UtilisateurBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TableAdapterManager.UpdateAll(Me.BDD_TurbotDataSet)

    End Sub

    Private Sub btnUpdatePassword_Click(sender As Object, e As EventArgs) Handles btnUpdatePassword.Click
        If efCurrentPassword.Text = APP_UtilisateurTableAdapter.rqtGetPassword(efCurrentPassword.Text) Then

        End If



        'If efEmail.Text = "" Or efPassword.Text = "" Then
        '    MessageBox.Show("Veuillez saisir vos informations de connexion!")
        'Else
        '    If rqtCheckMail = 1 Then
        '        Dim rqtPassword As String = APP_UtilisateurTableAdapter.rqtGetPassword(efEmail.Text)
        '        Dim CheckPassword As Boolean = BCrypt.CheckPassword(efPassword.Text, rqtPassword)
        '        If CheckPassword Then
        '            UserID = APP_UtilisateurTableAdapter.rqtGetUserID(efEmail.Text)
        '            Dim FrmAccueil As New FrmAccueil()
        '            FrmAccueil.UserID = UserID
        '            Dim dateDuJour As Date = Date.Now
        '            LogActivity("L'utilisateur " & efEmail.Text & " s'est connecté à " & dateDuJour.ToString("dd/MM/yyyy HH:mm:ss"))
        '            FrmAccueil.Show()
        '            Me.Hide()
        '        Else
        '            MsgBox("Votre mot de passe est incorrect", MsgBoxStyle.Exclamation, "Attention !")
        '            efPassword.Select()
        '        End If
        '    Else
        '        MsgBox("L'adresse mail est invalide !", MsgBoxStyle.Exclamation, "Attention !")
        '        efEmail.Select()
        '    End If
        'End If
    End Sub

    Private Sub efNewPassword_TextChanged(sender As Object, e As EventArgs) Handles efNewPassword.TextChanged

    End Sub

    Private Sub efCurrentPassword_TextChanged(sender As Object, e As EventArgs) Handles efCurrentPassword.TextChanged

    End Sub
End Class
