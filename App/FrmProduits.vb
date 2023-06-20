Public Class FrmProduits
    Private Sub APP_ProduitBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.APP_ProduitBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDD_TurbotDataSet)

    End Sub

    Private Sub FrmProduits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_CategorieProduit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_CategorieProduitTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_CategorieProduit)
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Produit'. Vous pouvez la déplacer ou la supprimer selon les besoins.

        Me.APP_ProduitTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Produit)
        Debug.WriteLine(BDD_TurbotDataSet.APP_Produit.Rows.Count)
        txtNmbProduits.Text = APP_ProduitDataGridView.Rows.Count
    End Sub

    Private Sub Categorie_nomTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Categorie_nomLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAfficherTout_Click(sender As Object, e As EventArgs) Handles btnAfficherTout.Click
        APP_ProduitBindingSource.Filter = ""
        txtNmbProduits.Text = APP_ProduitDataGridView.Rows.Count
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex <> -1 Then
            APP_ProduitBindingSource.Filter = "Categorie_nom = '" & ListBox1.SelectedValue & "'"
            txtNmbProduits.Text = APP_ProduitDataGridView.Rows.Count

        End If
    End Sub

    Private Sub btnGoHome_Click(sender As Object, e As EventArgs) Handles btnGoHome.Click
        Me.Hide()
        FrmAdminAccueil.Show()
    End Sub

    Private Sub APP_ProduitDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles APP_ProduitDataGridView.CellClick
        Dim NmbProduits As Integer = ApP_LigneCommandeTableAdapter1.CompterProduit(APP_ProduitDataGridView.Rows(e.RowIndex).Cells(0).Value)
        If NmbProduits <= 0 Then
            MessageBox.Show("Pas encore vendu", APP_ProduitDataGridView.Rows(e.RowIndex).Cells(4).Value.ToString())
        ElseIf NmbProduits = 1 Then
            MessageBox.Show(NmbProduits & " produit vendu", APP_ProduitDataGridView.Rows(e.RowIndex).Cells(4).Value.ToString())
        Else
            MessageBox.Show(NmbProduits & " produits vendus", APP_ProduitDataGridView.Rows(e.RowIndex).Cells(4).Value.ToString())
        End If
    End Sub


End Class