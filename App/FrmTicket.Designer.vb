<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTicket
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BDD_TurbotDataSet = New App.BDD_TurbotDataSet()
        Me.APP_MessageTableAdapter = New App.BDD_TurbotDataSetTableAdapters.APP_MessageTableAdapter()
        Me.APP_UtilisateurTableAdapter = New App.BDD_TurbotDataSetTableAdapters.APP_UtilisateurTableAdapter()
        Me.btnRevenirAccueil = New System.Windows.Forms.Button()
        Me.APP_MessageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New App.BDD_TurbotDataSetTableAdapters.TableAdapterManager()
        Me.APP_UtilisateurBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NomPrenom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APP_MessageDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BDD_TurbotDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_MessageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_UtilisateurBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_MessageDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BDD_TurbotDataSet
        '
        Me.BDD_TurbotDataSet.DataSetName = "BDD_TurbotDataSet"
        Me.BDD_TurbotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'APP_MessageTableAdapter
        '
        Me.APP_MessageTableAdapter.ClearBeforeFill = True
        '
        'APP_UtilisateurTableAdapter
        '
        Me.APP_UtilisateurTableAdapter.ClearBeforeFill = True
        '
        'btnRevenirAccueil
        '
        Me.btnRevenirAccueil.Location = New System.Drawing.Point(482, 398)
        Me.btnRevenirAccueil.Name = "btnRevenirAccueil"
        Me.btnRevenirAccueil.Size = New System.Drawing.Size(175, 37)
        Me.btnRevenirAccueil.TabIndex = 6
        Me.btnRevenirAccueil.Text = "Revenir à la gestion des tickets"
        Me.btnRevenirAccueil.UseVisualStyleBackColor = True
        '
        'APP_MessageBindingSource
        '
        Me.APP_MessageBindingSource.DataMember = "APP_Message"
        Me.APP_MessageBindingSource.DataSource = Me.BDD_TurbotDataSet
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
        Me.TableAdapterManager.APP_TicketTableAdapter = Nothing
        Me.TableAdapterManager.APP_TokenTableAdapter = Nothing
        Me.TableAdapterManager.APP_TypeRdvTableAdapter = Nothing
        Me.TableAdapterManager.APP_UtilisateurAdminTableAdapter = Nothing
        Me.TableAdapterManager.APP_UtilisateurClientTableAdapter = Nothing
        Me.TableAdapterManager.APP_UtilisateurSupportTableAdapter = Nothing
        Me.TableAdapterManager.APP_UtilisateurTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = App.BDD_TurbotDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'APP_UtilisateurBindingSource
        '
        Me.APP_UtilisateurBindingSource.DataMember = "APP_Utilisateur"
        Me.APP_UtilisateurBindingSource.DataSource = Me.BDD_TurbotDataSet
        '
        'NomPrenom
        '
        Me.NomPrenom.DataPropertyName = "NomPrenom"
        Me.NomPrenom.HeaderText = "Utilisateur"
        Me.NomPrenom.Name = "NomPrenom"
        Me.NomPrenom.ReadOnly = True
        '
        'APP_MessageDataGridView
        '
        Me.APP_MessageDataGridView.AllowUserToAddRows = False
        Me.APP_MessageDataGridView.AutoGenerateColumns = False
        Me.APP_MessageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.APP_MessageDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomPrenom, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.APP_MessageDataGridView.DataSource = Me.APP_MessageBindingSource
        Me.APP_MessageDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.APP_MessageDataGridView.Name = "APP_MessageDataGridView"
        Me.APP_MessageDataGridView.Size = New System.Drawing.Size(645, 364)
        Me.APP_MessageDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MessageContenu"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Message"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 500
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MessageID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "MessageID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TicketID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TicketID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "UtilisateurID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "UtilisateurID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'FrmTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(673, 453)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRevenirAccueil)
        Me.Controls.Add(Me.APP_MessageDataGridView)
        Me.Name = "FrmTicket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tickets"
        CType(Me.BDD_TurbotDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_MessageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_UtilisateurBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_MessageDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BDD_TurbotDataSet As BDD_TurbotDataSet
    Friend WithEvents APP_MessageBindingSource As BindingSource
    Friend WithEvents APP_MessageTableAdapter As BDD_TurbotDataSetTableAdapters.APP_MessageTableAdapter
    Friend WithEvents TableAdapterManager As BDD_TurbotDataSetTableAdapters.TableAdapterManager
    Friend WithEvents APP_UtilisateurBindingSource As BindingSource
    Friend WithEvents APP_UtilisateurTableAdapter As BDD_TurbotDataSetTableAdapters.APP_UtilisateurTableAdapter
    Friend WithEvents btnRevenirAccueil As Button
    Friend WithEvents NomPrenom As DataGridViewTextBoxColumn
    Friend WithEvents APP_MessageDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
