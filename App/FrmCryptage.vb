Public Class FrmCryptage
    Private Sub APP_UtilisateurBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles APP_UtilisateurBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.APP_UtilisateurBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDD_TurbotDataSet)

    End Sub

    Private Sub crypterMDP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_UtilisateurTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Utilisateur)



    End Sub

    Private Sub APP_UtilisateurDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles APP_UtilisateurDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Nbligne As Integer = APP_UtilisateurDataGridView.Rows.Count - 2
        For colonne As Integer = 0 To Nbligne
            Dim value As String = APP_UtilisateurDataGridView.Item(1, colonne).Value.ToString()
            Dim hashedValue As String = BCrypt.HashPassword(value)
            APP_UtilisateurDataGridView.Item(1, colonne).Value = hashedValue
        Next
    End Sub
End Class