Public Class FrmGestionTicket
    Private Sub APP_TicketBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.APP_TicketBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDD_TurbotDataSet)

    End Sub

    Private Sub FrmGestionTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Ticket'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_TicketTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Ticket)

    End Sub

    Private Sub APP_TicketDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles APP_TicketDataGridView.CellClick
        Dim TicketID As Integer = APP_TicketDataGridView.Rows(e.RowIndex).Cells(0).Value
        FrmTicket.TicketIDValue = TicketID
        FrmTicket.Show()
    End Sub

    Private Sub btnRevenirAccueil_Click(sender As Object, e As EventArgs) Handles btnRevenirAccueil.Click
        Me.Hide()
        FrmSupportAccueil.Show()
    End Sub
End Class