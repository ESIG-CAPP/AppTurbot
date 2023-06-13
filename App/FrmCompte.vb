Public Class FrmCompte
    Public Property UserID As Integer

    Private Sub FrmCompte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_UtilisateurTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Utilisateur)

    End Sub

    Private Sub APP_UtilisateurBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.APP_UtilisateurBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDD_TurbotDataSet)

    End Sub

    Private Sub btnGoHome_Click(sender As Object, e As EventArgs) Handles btnGoHome.Click
        Me.Hide()
        FrmAccueil.Show()
    End Sub

    Private Sub lblShowName_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblShowSurname_Click(sender As Object, e As EventArgs)

    End Sub
End Class
