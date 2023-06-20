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
        efTOTALUtilisateur.Text = APP_UtilisateurDataGridView.Rows.Count
        efNmbClient.Text = APP_UtilisateurClientDataGridView.Rows.Count
        efNmbAdmin.Text = APP_UtilisateurAdminDataGridView.Rows.Count
        efNmbSupport.Text = APP_UtilisateurSupportDataGridView.Rows.Count


    End Sub



End Class