Public Class FrmAccueil
    Public Property UserID As Integer

    Private Sub FrmAccueil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Dans la méthode FrmAccueil_Load

        Dim dateDuJour As Date = Date.Now
        ' Afficher la date et l'heure de la connexion dans le label
        lblLogConnexion.Text = "Dernière connexion : " & dateDuJour.ToString("dd/MM/yyyy HH:mm:ss")

        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_UtilisateurTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Utilisateur)
        ' Affichage du message de bienvenue avec le nom et le prénom
        Dim FrmConnexion As FrmConnexion = DirectCast(Application.OpenForms("FrmConnexion"), FrmConnexion)
        Dim userID As Integer = FrmConnexion.UserID
        lblNameSurname.Text = APP_UtilisateurTableAdapter.rqtGetUserNom(userID) & " " & APP_UtilisateurTableAdapter.rqtGetUserPrenom(userID)
        Dim UserType As String = APP_UtilisateurTableAdapter.rqtGetUserType(userID)

        'If UserType = "admin" Then
        '    gbAdmin.Enabled = True
        '    gbSupport.Enabled = True
        '    gbClient.Enabled = True
        'ElseIf UserType = "support" Then
        '    gbSupport.Enabled = True
        '    gbAdmin.Enabled = False
        'End If
    End Sub

    Private Sub APP_UtilisateurBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TableAdapterManager.UpdateAll(Me.BDD_TurbotDataSet)
    End Sub

    ' Fonction permettant de vérifier s'il est "admin" ou "support" pour accéder à des options
    Public Function FncCheckUserType(userType As String) As Boolean
        Return userType = "admin" OrElse userType = "support"
    End Function

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
        Me.Hide()
        FrmTicket.Show()
    End Sub
    Private Sub btnCommandes_Click(sender As Object, e As EventArgs) Handles btnCommandes.Click
        Me.Hide()
        FrmCommandes.Show()
    End Sub

    Private Sub gbSupport_Enter(sender As Object, e As EventArgs) Handles gbSupport.Enter
        Dim FrmConnexion As FrmConnexion = DirectCast(Application.OpenForms("FrmConnexion"), FrmConnexion)
        Dim userID As Integer = FrmConnexion.UserID
        Dim userType As String = APP_UtilisateurTableAdapter.rqtGetUserType(userID)

        If Not FncCheckUserType(userType) Then
            MsgBox("Vous n'avez pas accès car vous n'êtes pas autorisé !")
            Return
        End If
    End Sub

    Private Sub btnManageTickets_Click(sender As Object, e As EventArgs) Handles btnManageTickets.Click
        Dim FrmConnexion As FrmConnexion = DirectCast(Application.OpenForms("FrmConnexion"), FrmConnexion)
        Dim userID As Integer = FrmConnexion.UserID
        Dim userType As String = APP_UtilisateurTableAdapter.rqtGetUserType(userID)

        If Not FncCheckUserType(userType) Then
            MsgBox("Vous n'avez pas accès car vous n'êtes pas autorisé !")
        Else
            Me.Hide()
            FrmGestionTicket.Show()
        End If
    End Sub

    Private Sub btnManageProduct_Click(sender As Object, e As EventArgs) Handles btnManageProduct.Click
        Dim FrmConnexion As FrmConnexion = DirectCast(Application.OpenForms("FrmConnexion"), FrmConnexion)
        Dim userID As Integer = FrmConnexion.UserID
        Dim userType As String = APP_UtilisateurTableAdapter.rqtGetUserType(userID)

        If Not FncCheckUserType(userType) Then
            MsgBox("Vous n'avez pas accès car vous n'êtes pas autorisé !")
        Else
            Me.Hide()
            FrmProduits.Show()
        End If
    End Sub

    Private Sub btnManageOrders_Click(sender As Object, e As EventArgs) Handles btnManageOrders.Click
        Dim FrmConnexion As FrmConnexion = DirectCast(Application.OpenForms("FrmConnexion"), FrmConnexion)
        Dim userID As Integer = FrmConnexion.UserID
        Dim userType As String = APP_UtilisateurTableAdapter.rqtGetUserType(userID)

        If Not FncCheckUserType(userType) Then
            MsgBox("Vous n'avez pas accès car vous n'êtes pas autorisé !")
            Return
        End If

    End Sub

    Private Sub btnManageUsers_Click(sender As Object, e As EventArgs) Handles btnManageUsers.Click
        Dim FrmConnexion As FrmConnexion = DirectCast(Application.OpenForms("FrmConnexion"), FrmConnexion)
        Dim userID As Integer = FrmConnexion.UserID
        Dim userType As String = APP_UtilisateurTableAdapter.rqtGetUserType(userID)

        If Not FncCheckUserType(userType) Then
            MsgBox("Vous n'avez pas accès car vous n'êtes pas autorisé !")
            Return
        End If
    End Sub

    Private Sub lblNom_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblPrenom_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblNameSurname_Click(sender As Object, e As EventArgs) Handles lblNameSurname.Click

    End Sub

    Private Sub lblLogConnexion_Click(sender As Object, e As EventArgs) Handles lblLogConnexion.Click

    End Sub
End Class
