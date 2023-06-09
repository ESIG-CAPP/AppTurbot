Public Class FrmGestionCompte
    Public Property Icone As Icon
    Private Sub FrmGestionCompte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Vérifier si une icône a été transmise depuis FrmCompte
        If Icone IsNot Nothing Then
            Me.Icon = Icone
        End If
    End Sub
End Class
