Public Class FrmProduits
    Private Sub APP_ProduitBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles APP_ProduitBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.APP_ProduitBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDD_TurbotDataSet)

    End Sub

    Private Sub FrmProduits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Produit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_ProduitTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Produit)

    End Sub
End Class