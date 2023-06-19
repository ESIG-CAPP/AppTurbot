Imports System.Data.SqlClient

Public Class FrmInscription
    Public Property UserID As Integer

    Public Function FncCheckUserType(userType As String) As Boolean
        If userType = "admin" Then
            FrmAdminAccueil.Show()
        ElseIf userType = "support" Then
            FrmSupportAccueil.Show()
        Else
            FrmClientAccueil.Show()
        End If
    End Function

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim MyCon As New SqlConnection(My.Settings.BDD_TurbotConnectionString)
        Dim cmd As New SqlCommand()
        cmd.Connection = MyCon

        Try
            If FncCheckUserType(APP_UtilisateurTableAdapter.rqtGetUserType(UserID)) = "client" Then
                rbSelectAdmin.Enabled = False
                MsgBox("Accès refusé. Vous ne diposez pas des priviligès nécessaires.", MsgBoxStyle.Exclamation, "Attention !")
            ElseIf FncCheckUserType(APP_UtilisateurTableAdapter.rqtGetUserType(UserID)) = "support" Then
                rbSelectAdmin.Enabled = False
                MsgBox("Accès refusé. Vous ne diposez pas des priviligès nécessaires.", MsgBoxStyle.Exclamation, "Attention !")
            Else
                rbSelectAdmin.Enabled = True
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub FrmInscription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BDD_TurbotDataSet.APP_Utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.APP_UtilisateurTableAdapter.Fill(Me.BDD_TurbotDataSet.APP_Utilisateur)

    End Sub
End Class