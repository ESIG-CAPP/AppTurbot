Public Class FrmTicket
    Public Property TicketIDValue As Integer
    Private Sub FrmTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_UtilisateurTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Utilisateur)
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Message'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_MessageTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Message)
        Dim userID As Integer = FrmConnexion.UserID
        Dim typeUser As String = APP_UtilisateurTableAdapter.rqtGetUserType(userID)
        APP_MessageBindingSource.Filter = "TicketID = '" & TicketIDValue & "'"
        If typeUser = "support" Then
            btnRevenirAccueil.Text = "Revenir à la gestion des tickets"
        Else
            btnRevenirAccueil.Text = "Revenir à mes tickets"
        End If
    End Sub

    Private Sub APP_MessageBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.APP_MessageBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDD_TurbotDataSet)

    End Sub

    Private Sub btnRevenirAccueil_Click(sender As Object, e As EventArgs) Handles btnRevenirAccueil.Click
        Me.Dispose()
    End Sub
End Class