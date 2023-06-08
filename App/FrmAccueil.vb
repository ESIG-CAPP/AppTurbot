Public Class FrmAccueil
    Public Property UserID As Integer

    Private Sub FrmAccueil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Dans la méthode FrmAccueil_Load
        lblNom.TextAlign = ContentAlignment.MiddleLeft
        lblPrenom.TextAlign = ContentAlignment.MiddleLeft

        Dim dateDuJour As Date = Date.Now
        ' Afficher la date et l'heure de la connexion dans le label
        lblLogConnexion.Text = "Dernière connexion : " & dateDuJour.ToString("dd/MM/yyyy HH:mm:ss")

        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_UtilisateurTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Utilisateur)
        ' Affichage du message de bienvenue avec le nom et le prénom
        Dim FrmConnexion As FrmConnexion = DirectCast(Application.OpenForms("FrmConnexion"), FrmConnexion)
        Dim userID As Integer = FrmConnexion.UserID
        lblNom.Text = APP_UtilisateurTableAdapter.rqtGetUserNom(userID)
        lblPrenom.Text = APP_UtilisateurTableAdapter.rqtGetUserPrenom(userID)
        Dim UserType As String = APP_UtilisateurTableAdapter.rqtGetUserType(userID)
        If UserType = "admin" Then
            gbAdmin.Visible = True
            gbSupport.Visible = True
        ElseIf UserType = "support" Then
            gbSupport.Visible = True
        End If
    End Sub

    Private Sub APP_UtilisateurBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TableAdapterManager.UpdateAll(Me.BDD_TurbotDataSet)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Fermer le formulaire actuel (FrmAccueil)
        Me.Hide()
        ' Réinitialiser les valeurs ou effectuer d'autres opérations de déconnexion si nécessaire
        ' Par exemple, vous pouvez réinitialiser les champs de saisie de l'utilisateur
        FrmConnexion.efEmail.Text = ""
        FrmConnexion.efPassword.Text = ""
        FrmConnexion.efEmail.Select()

        'Afficher le formulaire de démarrage
        FrmConnexion.Show()
    End Sub


    Private Sub btnCompte_Click(sender As Object, e As EventArgs) Handles btnCompte.Click
        Dim FrmCompte As New FrmCompte()
        FrmCompte.UserID = UserID
        FrmCompte.Show()
        Me.Hide()
    End Sub

    Private Sub btnTickets_Click(sender As Object, e As EventArgs) Handles btnTickets.Click
        FrmTicket.Show()
    End Sub
End Class
