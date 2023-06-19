Imports System.Data.SqlClient

Public Class FrmCommandes

    Public Property UserID As Integer
    Private Sub APP_CommandeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.APP_CommandeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDD_TurbotDataSet)

    End Sub

    Private Sub FrmCommandes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_CommandeUtilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_CommandeUtilisateurTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_CommandeUtilisateur)
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Commande'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_CommandeTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Commande)


    End Sub

    Private Sub btnaccueil_Click(sender As Object, e As EventArgs) Handles btnaccueil.Click
        FrmAdminAccueil.Dispose()
    End Sub

    Private Function IsOrderDataValid() As Boolean
        ' Verify that CustomerID is present.  
        If UtilisateurIDTextBox.Text <> APP_CommandeUtilisateurTableAdapter.rqtcheckUserID(UserID) Then
            MessageBox.Show("Entrez un client existant")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnPasserCommande_Click(sender As Object, e As EventArgs) Handles btnPasserCommande.Click
        Try
            If IsOrderDataValid() Then
                Dim MyCon As New SqlConnection(My.Settings.BDD_TurbotConnectionString)
                Dim cmd As New SqlCommand()
                cmd.Connection = MyCon
                cmd.CommandText = "INSERT INTO APP_CommandeUtilisateur (CommandeID,CommandeDate,CommandeEtat,CommandeMoyenPaiement,CommandeDateLimite) VALUES (@CommandeID,@CommandeDate, @CommandeEtat, @CommandeMoyenPaiement, @CommandeDateLimite)"
                cmd.Parameters.AddWithValue("@CommandeID", efCommandeID.Text)
                cmd.Parameters.AddWithValue("@CommandeDate", dtpCommandeDate.Value)
                cmd.Parameters.AddWithValue("@CommandeEtat", lbEtatCommande.SelectedValue)
                cmd.Parameters.AddWithValue("@CommandeMoyenPaiement", lbMoyenPaiement.SelectedValue)
                cmd.Parameters.AddWithValue("@CommandeDateLimite", dtpCommandeDateLimite.Value)
            End If
        Catch ex As Exception
            MsgBox("Update excepted ", MsgBoxStyle.Critical, "Attention !")
        End Try
    End Sub

    Private Sub ClearForm()
        UtilisateurIDTextBox.Clear()
        dtpCommandeDate.Value = DateTime.Now
        dtpCommandeDateLimite.Value = DateTime.Now
        efCommandeID.Clear()
        lbEtatCommande.ClearSelected()
        lbMoyenPaiement.ClearSelected()
    End Sub
End Class