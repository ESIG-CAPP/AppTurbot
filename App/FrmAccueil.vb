Public Class FrmAccueil
    Private userID As Integer

    Public Sub New(userID As Integer)
        InitializeComponent()
        Me.userID = userID
    End Sub

    Private Sub FrmAccueil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_UtilisateurTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Utilisateur)
        ' Affichage du message de bienvenue avec le nom et le prénom
        Dim FrmConnexion As New FrmConnexion()
        Dim userID As Integer = FrmConnexion.UserID
        lblNom.Text = APP_UtilisateurTableAdapter.rqtGetUserNom(userID)
        MsgBox(APP_UtilisateurTableAdapter.rqtGetUserNom(userID))
        lblPrenom.Text = APP_UtilisateurTableAdapter.rqtGetUserPrenom(userID)
    End Sub

    Private Sub APP_UtilisateurBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TableAdapterManager.UpdateAll(Me.BDD_TurbotDataSet)

    End Sub
End Class
