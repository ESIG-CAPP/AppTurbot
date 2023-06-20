<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGestionTicket
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGestionTicket))
        Me.APP_TicketDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APP_TicketBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDD_TurbotDataSet = New App.BDD_TurbotDataSet()
        Me.APP_TicketTableAdapter = New App.BDD_TurbotDataSetTableAdapters.APP_TicketTableAdapter()
        Me.TableAdapterManager = New App.BDD_TurbotDataSetTableAdapters.TableAdapterManager()
        Me.btnRevenirAccueil = New System.Windows.Forms.Button()
        CType(Me.APP_TicketDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_TicketBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDD_TurbotDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'APP_TicketDataGridView
        '
        Me.APP_TicketDataGridView.AllowUserToAddRows = False
        Me.APP_TicketDataGridView.AutoGenerateColumns = False
        Me.APP_TicketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.APP_TicketDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.APP_TicketDataGridView.DataSource = Me.APP_TicketBindingSource
        Me.APP_TicketDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.APP_TicketDataGridView.Name = "APP_TicketDataGridView"
        Me.APP_TicketDataGridView.Size = New System.Drawing.Size(545, 291)
        Me.APP_TicketDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TicketID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "TicketID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TicketUtilisateurID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TicketUtilisateurID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TicketDateCreation"
        Me.DataGridViewTextBoxColumn3.HeaderText = "TicketDateCreation"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TicketDateFinition"
        Me.DataGridViewTextBoxColumn4.HeaderText = "TicketDateFinition"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TicketStatut"
        Me.DataGridViewTextBoxColumn5.HeaderText = "TicketStatut"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'APP_TicketBindingSource
        '
        Me.APP_TicketBindingSource.DataMember = "APP_Ticket"
        Me.APP_TicketBindingSource.DataSource = Me.BDD_TurbotDataSet
        '
        'BDD_TurbotDataSet
        '
        Me.BDD_TurbotDataSet.DataSetName = "BDD_TurbotDataSet"
        Me.BDD_TurbotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'APP_TicketTableAdapter
        '
        Me.APP_TicketTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.APP_AdminRdvTableAdapter = Nothing
        Me.TableAdapterManager.APP_AdresseRdvTableAdapter = Nothing
        Me.TableAdapterManager.APP_AdresseTableAdapter = Nothing
        Me.TableAdapterManager.APP_CategorieProduitTableAdapter = Nothing
        Me.TableAdapterManager.APP_ClientRdvTableAdapter = Nothing
        Me.TableAdapterManager.APP_CommandeTableAdapter = Nothing
        Me.TableAdapterManager.APP_CommandeUtilisateurTableAdapter = Nothing
        Me.TableAdapterManager.APP_LigneCommandeTableAdapter = Nothing
        Me.TableAdapterManager.APP_MessageTableAdapter = Nothing
        Me.TableAdapterManager.APP_ProduitTableAdapter = Nothing
        Me.TableAdapterManager.APP_RdvTableAdapter = Nothing
        Me.TableAdapterManager.APP_SupportTicketTableAdapter = Nothing
        Me.TableAdapterManager.APP_TicketTableAdapter = Me.APP_TicketTableAdapter
        Me.TableAdapterManager.APP_TokenTableAdapter = Nothing
        Me.TableAdapterManager.APP_TypeRdvTableAdapter = Nothing
        Me.TableAdapterManager.APP_UtilisateurAdminTableAdapter = Nothing
        Me.TableAdapterManager.APP_UtilisateurClientTableAdapter = Nothing
        Me.TableAdapterManager.APP_UtilisateurSupportTableAdapter = Nothing
        Me.TableAdapterManager.APP_UtilisateurTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = App.BDD_TurbotDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnRevenirAccueil
        '
        Me.btnRevenirAccueil.Location = New System.Drawing.Point(419, 334)
        Me.btnRevenirAccueil.Name = "btnRevenirAccueil"
        Me.btnRevenirAccueil.Size = New System.Drawing.Size(138, 38)
        Me.btnRevenirAccueil.TabIndex = 5
        Me.btnRevenirAccueil.Text = "Revenir à l'accueil"
        Me.btnRevenirAccueil.UseVisualStyleBackColor = True
        '
        'FrmGestionTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(579, 384)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRevenirAccueil)
        Me.Controls.Add(Me.APP_TicketDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmGestionTicket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion des tickets"
        CType(Me.APP_TicketDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_TicketBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDD_TurbotDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BDD_TurbotDataSet As BDD_TurbotDataSet
    Friend WithEvents APP_TicketBindingSource As BindingSource
    Friend WithEvents APP_TicketTableAdapter As BDD_TurbotDataSetTableAdapters.APP_TicketTableAdapter
    Friend WithEvents TableAdapterManager As BDD_TurbotDataSetTableAdapters.TableAdapterManager
    Friend WithEvents APP_TicketDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents btnRevenirAccueil As Button
End Class
