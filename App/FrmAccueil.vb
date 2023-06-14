Public Class FrmAccueil
    Public Property UserID As Integer

    Private Sub FrmAccueil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_UtilisateurTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Utilisateur)
        ' Affichage du message de bienvenue avec le nom et le prénom
        Dim FrmConnexion As FrmConnexion = DirectCast(Application.OpenForms("FrmConnexion"), FrmConnexion)
        Dim userID As Integer = FrmConnexion.UserID
        Dim UserType As String = APP_UtilisateurTableAdapter.rqtGetUserType(userID)

        If UserType = "admin" Then
            Hide()
            FrmAdminAccueil.Show()
        ElseIf UserType = "support" Then
            Hide()
            FrmSupportAccueil.Show()
        Else
            Hide()
            FrmClientAccueil.Show()
        End If
    End Sub

    Private Sub APP_UtilisateurBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TableAdapterManager.UpdateAll(Me.BDD_TurbotDataSet)
    End Sub

End Class
