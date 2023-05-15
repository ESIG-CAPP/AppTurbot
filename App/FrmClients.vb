Public Class FrmClients
    Private Sub APP_UtilisateurBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles APP_UtilisateurBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.APP_UtilisateurBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDD_TurbotDataSet)

    End Sub

    Private Sub FrmClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_CommandeUtilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_CommandeUtilisateurTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_CommandeUtilisateur)
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Adresse'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_AdresseTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Adresse)
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_UtilisateurTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Utilisateur)

    End Sub

    Private Sub btnFermer_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
        Dispose()
    End Sub
End Class