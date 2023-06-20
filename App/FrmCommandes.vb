Imports System.Data.SqlClient

Public Class FrmCommandes

    Public Property UserID As Integer
    Private Sub APP_CommandeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.APP_CommandeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDD_TurbotDataSet)

    End Sub

    Private Sub FrmCommandes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_UtilisateurClient'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_UtilisateurClientTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_UtilisateurClient)
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_CommandeUtilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_CommandeUtilisateurTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_CommandeUtilisateur)
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Commande'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_CommandeTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Commande)

        efCommandeID.Text = APP_CommandeTableAdapter.rqtNmbCommande() + 1




    End Sub

    Private Sub btnaccueil_Click(sender As Object, e As EventArgs) Handles btnaccueil.Click
        FrmAdminAccueil.Dispose()
    End Sub

    Private Function IsOrderDataValid() As Boolean
        ' Verify that CustomerID is present.  
        If UtilisateurIDTextBox.Text = "" Then
            MessageBox.Show("Entrez un client")
            Return False

        ElseIf APP_UtilisateurClientTableAdapter.rqtUserClientCheck(UtilisateurIDTextBox.Text) = 0 Then
            MessageBox.Show("Entrez un client existant")
            Return False

        ElseIf dtpCommandeDateLimite.Value < dtpCommandeDate.Value Then
            MessageBox.Show("La date limite ne peut pas être antérieur à la date de commande")
            Return False

        ElseIf lbEtatCommande.SelectedIndex = -1 Then
            MessageBox.Show("Selectionnez un état de commande")
            Return False

        ElseIf lbMoyenPaiement.SelectedIndex = -1 Then
            MessageBox.Show("Selectionnez un moyen de paiement")
            Return False

        Else
            Return True
        End If
    End Function

    Private Sub btnPasserCommande_Click(sender As Object, e As EventArgs) Handles btnPasserCommande.Click
        Try
            If IsOrderDataValid() Then
                APP_CommandeTableAdapter.rqtInsertCommande(efCommandeID.Text, dtpCommandeDate.Value, lbEtatCommande.SelectedValue, lbMoyenPaiement.SelectedValue, dtpCommandeDateLimite.Value)
                MessageBox.Show("Votre commande a été passée !")
                ClearForm()
            End If
        Catch ex As Exception
            MsgBox("Erreur " & ex.Message, MsgBoxStyle.Critical, "Attention !")
        End Try
    End Sub

    Private Sub ClearForm()
        UtilisateurIDTextBox.Clear()
        dtpCommandeDate.Value = DateTime.Now
        dtpCommandeDateLimite.Value = DateTime.Now
        efCommandeID.Text = APP_CommandeTableAdapter.rqtNmbCommande() + 1
        lbEtatCommande.ClearSelected()
        lbMoyenPaiement.ClearSelected()
    End Sub

End Class