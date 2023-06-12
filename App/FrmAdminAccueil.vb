Public Class FrmAdminAccueil
    Private Sub FrmAdminAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TrUpdateLog.Interval = 60000 ' Définit l'intervalle de la minuterie à 1 minute (60000 millisecondes)
        TrUpdateLog.Start() ' Démarre la minuterie
    End Sub

    Private Sub TrUpdateLog_Tick(sender As Object, e As EventArgs) Handles TrUpdateLog.Tick
        Dim dateDuJour As Date = Date.Now
        lblLogConnexion.Text = "Dernière connexion : " & dateDuJour.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub
End Class