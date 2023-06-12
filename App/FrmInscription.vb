Imports System.Data.SqlClient

Public Class FrmInscription


    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim MyCon As New SqlConnection(My.Settings.BDD_TurbotConnectionString)
        Dim cmd As New SqlCommand()
        cmd.Connection = MyCon

        Try
            If rbSelectClient.Checked Then
                gbInfoPersonal.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub gbSelectType_Enter(sender As Object, e As EventArgs) Handles gbSelectType.Enter

    End Sub

    Private Sub rbSelectSupport_CheckedChanged(sender As Object, e As EventArgs) Handles rbSelectSupport.CheckedChanged

    End Sub

    Private Sub rbSelectClient_CheckedChanged(sender As Object, e As EventArgs) Handles rbSelectClient.CheckedChanged

    End Sub

    Private Sub rbSelectAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles rbSelectAdmin.CheckedChanged

    End Sub
End Class