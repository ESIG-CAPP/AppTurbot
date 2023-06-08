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
End Class
