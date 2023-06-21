Imports System.Data.SqlClient

Public Class FrmUtilisateurs
    Private Sub APP_UtilisateurBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.APP_UtilisateurBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDD_TurbotDataSet)

    End Sub

    Private Sub FrmUtilisateurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_UtilisateurSupport'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_UtilisateurSupportTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_UtilisateurSupport)
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_UtilisateurAdmin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_UtilisateurAdminTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_UtilisateurAdmin)
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_UtilisateurClient'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_UtilisateurClientTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_UtilisateurClient)
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Adresse'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_AdresseTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Adresse)
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_UtilisateurTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Utilisateur)


        tbSumUsers.Text = APP_UtilisateurDataGridView.Rows.Count
        tbSumClient.Text = APP_UtilisateurClientDataGridView.Rows.Count
        tbSumAdmin.Text = APP_UtilisateurAdminDataGridView.Rows.Count
        tbSumSupport.Text = APP_UtilisateurSupportDataGridView.Rows.Count
    End Sub

    Private Sub rbFilterAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles rbFilterAdmin.CheckedChanged
        rbFilterSupport.Checked = False
        rbFilterClient.Checked = False

        APP_UtilisateurBindingSource.Filter = "UtilisateurType = 'admin'"
    End Sub

    Private Sub rbFilterClient_CheckedChanged(sender As Object, e As EventArgs) Handles rbFilterClient.CheckedChanged
        rbFilterSupport.Checked = False
        rbFilterAdmin.Checked = False

        APP_UtilisateurBindingSource.Filter = "UtilisateurType = 'client'"
    End Sub

    Private Sub rbFilterSupport_CheckedChanged(sender As Object, e As EventArgs) Handles rbFilterSupport.CheckedChanged
        rbFilterAdmin.Checked = False
        rbFilterClient.Checked = False

        APP_UtilisateurBindingSource.Filter = "UtilisateurType = 'support'"
    End Sub

    Private Sub btnResetFilter_Click(sender As Object, e As EventArgs) Handles btnResetFilter.Click
        rbFilterAdmin.Checked = False
        rbFilterClient.Checked = False
        rbFilterSupport.Checked = False
        APP_UtilisateurBindingSource.Filter = ""
    End Sub

    Private Sub btnRevenirAccueil_Click(sender As Object, e As EventArgs) Handles btnRevenirAccueil.Click
        Me.Hide()
        FrmAdminAccueil.Show()
    End Sub
End Class