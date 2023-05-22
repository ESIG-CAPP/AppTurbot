Public Class FrmCommandes
    Private Sub APP_CommandeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.APP_CommandeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDD_TurbotDataSet)

    End Sub

    Private Sub FrmCommandes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Commande'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_CommandeTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Commande)

    End Sub
End Class