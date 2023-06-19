Partial Class BDD_TurbotDataSet
    Partial Public Class APP_CommandeUtilisateurDataTable
        Private Sub APP_CommandeUtilisateurDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging

        End Sub

    End Class

    Partial Public Class APP_CommandeDataTable
        Private Sub APP_CommandeDataTable_APP_CommandeRowChanging(sender As Object, e As APP_CommandeRowChangeEvent) Handles Me.APP_CommandeRowChanging

        End Sub

    End Class

    Partial Public Class APP_UtilisateurDataTable
        Private Sub APP_UtilisateurDataTable_APP_UtilisateurRowChanging(sender As Object, e As APP_UtilisateurRowChangeEvent) Handles Me.APP_UtilisateurRowChanging

        End Sub

    End Class
End Class

Namespace BDD_TurbotDataSetTableAdapters
    Partial Public Class APP_CommandeUtilisateurTableAdapter
    End Class

    Partial Public Class APP_UtilisateurTableAdapter
    End Class
End Namespace
