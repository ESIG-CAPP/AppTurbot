<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCommandes
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
        Dim lblCommandeDateLimitePaiement As System.Windows.Forms.Label
        Dim lblCommandeEtat As System.Windows.Forms.Label
        Dim lblCommandeDate As System.Windows.Forms.Label
        Dim lbCommandeID As System.Windows.Forms.Label
        Dim lblCommandeMethodePaiement As System.Windows.Forms.Label
        Dim UtilisateurIDLabel As System.Windows.Forms.Label
        Dim CommandeIDLabel1 As System.Windows.Forms.Label
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnaccueil = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbMoyenPaiement = New System.Windows.Forms.ListBox()
        Me.UtilisateurIDTextBox = New System.Windows.Forms.TextBox()
        Me.lbEtatCommande = New System.Windows.Forms.ListBox()
        Me.dtpCommandeDateLimite = New System.Windows.Forms.DateTimePicker()
        Me.dtpCommandeDate = New System.Windows.Forms.DateTimePicker()
        Me.efCommandeID = New System.Windows.Forms.TextBox()
        Me.btnPasserCommande = New System.Windows.Forms.Button()
        Me.APP_CommandeDataGridView = New System.Windows.Forms.DataGridView()
        Me.APP_CommandeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDD_TurbotDataSet = New App.BDD_TurbotDataSet()
        Me.APP_CommandeUtilisateurBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.APP_CommandeTableAdapter = New App.BDD_TurbotDataSetTableAdapters.APP_CommandeTableAdapter()
        Me.TableAdapterManager = New App.BDD_TurbotDataSetTableAdapters.TableAdapterManager()
        Me.APP_CommandeUtilisateurTableAdapter = New App.BDD_TurbotDataSetTableAdapters.APP_CommandeUtilisateurTableAdapter()
        Me.APP_UtilisateurClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.APP_UtilisateurClientTableAdapter = New App.BDD_TurbotDataSetTableAdapters.APP_UtilisateurClientTableAdapter()
        Me.UtilisateurID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommandeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        lblCommandeDateLimitePaiement = New System.Windows.Forms.Label()
        lblCommandeEtat = New System.Windows.Forms.Label()
        lblCommandeDate = New System.Windows.Forms.Label()
        lbCommandeID = New System.Windows.Forms.Label()
        lblCommandeMethodePaiement = New System.Windows.Forms.Label()
        UtilisateurIDLabel = New System.Windows.Forms.Label()
        CommandeIDLabel1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.APP_CommandeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_CommandeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDD_TurbotDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_CommandeUtilisateurBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_UtilisateurClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCommandeDateLimitePaiement
        '
        lblCommandeDateLimitePaiement.AutoSize = True
        lblCommandeDateLimitePaiement.Location = New System.Drawing.Point(25, 221)
        lblCommandeDateLimitePaiement.Name = "lblCommandeDateLimitePaiement"
        lblCommandeDateLimitePaiement.Size = New System.Drawing.Size(60, 13)
        lblCommandeDateLimitePaiement.TabIndex = 9
        lblCommandeDateLimitePaiement.Text = "Date Limite"
        '
        'lblCommandeEtat
        '
        lblCommandeEtat.AutoSize = True
        lblCommandeEtat.Location = New System.Drawing.Point(25, 165)
        lblCommandeEtat.Name = "lblCommandeEtat"
        lblCommandeEtat.Size = New System.Drawing.Size(107, 13)
        lblCommandeEtat.TabIndex = 10
        lblCommandeEtat.Text = "Etat de la commande"
        '
        'lblCommandeDate
        '
        lblCommandeDate.AutoSize = True
        lblCommandeDate.Location = New System.Drawing.Point(25, 129)
        lblCommandeDate.Name = "lblCommandeDate"
        lblCommandeDate.Size = New System.Drawing.Size(111, 13)
        lblCommandeDate.TabIndex = 11
        lblCommandeDate.Text = "Date de la commande"
        '
        'lbCommandeID
        '
        lbCommandeID.AutoSize = True
        lbCommandeID.Location = New System.Drawing.Point(25, 92)
        lbCommandeID.Name = "lbCommandeID"
        lbCommandeID.Size = New System.Drawing.Size(100, 13)
        lbCommandeID.TabIndex = 12
        lbCommandeID.Text = "N° de la commande"
        '
        'lblCommandeMethodePaiement
        '
        lblCommandeMethodePaiement.AutoSize = True
        lblCommandeMethodePaiement.Location = New System.Drawing.Point(25, 196)
        lblCommandeMethodePaiement.Name = "lblCommandeMethodePaiement"
        lblCommandeMethodePaiement.Size = New System.Drawing.Size(101, 13)
        lblCommandeMethodePaiement.TabIndex = 14
        lblCommandeMethodePaiement.Text = "Moyen de Paiement"
        '
        'UtilisateurIDLabel
        '
        UtilisateurIDLabel.AutoSize = True
        UtilisateurIDLabel.Location = New System.Drawing.Point(25, 57)
        UtilisateurIDLabel.Name = "UtilisateurIDLabel"
        UtilisateurIDLabel.Size = New System.Drawing.Size(70, 13)
        UtilisateurIDLabel.TabIndex = 0
        UtilisateurIDLabel.Text = "Utilisateur ID:"
        '
        'CommandeIDLabel1
        '
        CommandeIDLabel1.AutoSize = True
        CommandeIDLabel1.Location = New System.Drawing.Point(151, 90)
        CommandeIDLabel1.Name = "CommandeIDLabel1"
        CommandeIDLabel1.Size = New System.Drawing.Size(0, 13)
        CommandeIDLabel1.TabIndex = 14
        '
        'btnaccueil
        '
        Me.btnaccueil.Location = New System.Drawing.Point(861, 545)
        Me.btnaccueil.Name = "btnaccueil"
        Me.btnaccueil.Size = New System.Drawing.Size(148, 36)
        Me.btnaccueil.TabIndex = 2
        Me.btnaccueil.Text = "Revenir à l'accueil"
        Me.btnaccueil.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(UtilisateurIDLabel)
        Me.GroupBox1.Controls.Add(Me.lbMoyenPaiement)
        Me.GroupBox1.Controls.Add(Me.UtilisateurIDTextBox)
        Me.GroupBox1.Controls.Add(Me.lbEtatCommande)
        Me.GroupBox1.Controls.Add(Me.dtpCommandeDateLimite)
        Me.GroupBox1.Controls.Add(Me.dtpCommandeDate)
        Me.GroupBox1.Controls.Add(CommandeIDLabel1)
        Me.GroupBox1.Controls.Add(Me.efCommandeID)
        Me.GroupBox1.Controls.Add(lblCommandeMethodePaiement)
        Me.GroupBox1.Controls.Add(Me.btnPasserCommande)
        Me.GroupBox1.Controls.Add(lbCommandeID)
        Me.GroupBox1.Controls.Add(lblCommandeDate)
        Me.GroupBox1.Controls.Add(lblCommandeEtat)
        Me.GroupBox1.Controls.Add(lblCommandeDateLimitePaiement)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 262)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(806, 265)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Créer une commande"
        '
        'lbMoyenPaiement
        '
        Me.lbMoyenPaiement.FormattingEnabled = True
        Me.lbMoyenPaiement.Items.AddRange(New Object() {"PayPal", "carte de créedit", "chèque", "virement bancaire"})
        Me.lbMoyenPaiement.Location = New System.Drawing.Point(171, 196)
        Me.lbMoyenPaiement.Name = "lbMoyenPaiement"
        Me.lbMoyenPaiement.Size = New System.Drawing.Size(200, 17)
        Me.lbMoyenPaiement.TabIndex = 20
        '
        'UtilisateurIDTextBox
        '
        Me.UtilisateurIDTextBox.Location = New System.Drawing.Point(171, 54)
        Me.UtilisateurIDTextBox.Name = "UtilisateurIDTextBox"
        Me.UtilisateurIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UtilisateurIDTextBox.TabIndex = 1
        '
        'lbEtatCommande
        '
        Me.lbEtatCommande.FormattingEnabled = True
        Me.lbEtatCommande.Items.AddRange(New Object() {"terminée", "en attente", "en cours de traitement"})
        Me.lbEtatCommande.Location = New System.Drawing.Point(171, 165)
        Me.lbEtatCommande.Name = "lbEtatCommande"
        Me.lbEtatCommande.Size = New System.Drawing.Size(200, 17)
        Me.lbEtatCommande.TabIndex = 5
        '
        'dtpCommandeDateLimite
        '
        Me.dtpCommandeDateLimite.Location = New System.Drawing.Point(171, 221)
        Me.dtpCommandeDateLimite.Name = "dtpCommandeDateLimite"
        Me.dtpCommandeDateLimite.Size = New System.Drawing.Size(200, 20)
        Me.dtpCommandeDateLimite.TabIndex = 19
        '
        'dtpCommandeDate
        '
        Me.dtpCommandeDate.Location = New System.Drawing.Point(171, 123)
        Me.dtpCommandeDate.Name = "dtpCommandeDate"
        Me.dtpCommandeDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpCommandeDate.TabIndex = 16
        '
        'efCommandeID
        '
        Me.efCommandeID.Enabled = False
        Me.efCommandeID.Location = New System.Drawing.Point(171, 90)
        Me.efCommandeID.Name = "efCommandeID"
        Me.efCommandeID.Size = New System.Drawing.Size(100, 20)
        Me.efCommandeID.TabIndex = 15
        '
        'btnPasserCommande
        '
        Me.btnPasserCommande.Location = New System.Drawing.Point(472, 222)
        Me.btnPasserCommande.Name = "btnPasserCommande"
        Me.btnPasserCommande.Size = New System.Drawing.Size(123, 23)
        Me.btnPasserCommande.TabIndex = 14
        Me.btnPasserCommande.Text = "Passer une commande"
        Me.btnPasserCommande.UseVisualStyleBackColor = True
        '
        'APP_CommandeDataGridView
        '
        Me.APP_CommandeDataGridView.AllowUserToAddRows = False
        Me.APP_CommandeDataGridView.AutoGenerateColumns = False
        Me.APP_CommandeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.APP_CommandeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UtilisateurID, Me.CommandeID, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.APP_CommandeDataGridView.DataSource = Me.APP_CommandeBindingSource
        Me.APP_CommandeDataGridView.Location = New System.Drawing.Point(103, 25)
        Me.APP_CommandeDataGridView.Name = "APP_CommandeDataGridView"
        Me.APP_CommandeDataGridView.Size = New System.Drawing.Size(651, 197)
        Me.APP_CommandeDataGridView.TabIndex = 3
        '
        'APP_CommandeBindingSource
        '
        Me.APP_CommandeBindingSource.DataMember = "APP_Commande"
        Me.APP_CommandeBindingSource.DataSource = Me.BDD_TurbotDataSet
        '
        'BDD_TurbotDataSet
        '
        Me.BDD_TurbotDataSet.DataSetName = "BDD_TurbotDataSet"
        Me.BDD_TurbotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'APP_CommandeUtilisateurBindingSource
        '
        Me.APP_CommandeUtilisateurBindingSource.DataMember = "APP_CommandeUtilisateur"
        Me.APP_CommandeUtilisateurBindingSource.DataSource = Me.BDD_TurbotDataSet
        '
        'APP_CommandeTableAdapter
        '
        Me.APP_CommandeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.APP_AdminRdvTableAdapter = Nothing
        Me.TableAdapterManager.APP_AdresseRdvTableAdapter = Nothing
        Me.TableAdapterManager.APP_AdresseTableAdapter = Nothing
        Me.TableAdapterManager.APP_CategorieProduitTableAdapter = Nothing
        Me.TableAdapterManager.APP_ClientRdvTableAdapter = Nothing
        Me.TableAdapterManager.APP_CommandeTableAdapter = Me.APP_CommandeTableAdapter
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
        Me.TableAdapterManager.UpdateOrder = App.BDD_TurbotDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'APP_CommandeUtilisateurTableAdapter
        '
        Me.APP_CommandeUtilisateurTableAdapter.ClearBeforeFill = True
        '
        'APP_UtilisateurClientBindingSource
        '
        Me.APP_UtilisateurClientBindingSource.DataMember = "APP_UtilisateurClient"
        Me.APP_UtilisateurClientBindingSource.DataSource = Me.BDD_TurbotDataSet
        '
        'APP_UtilisateurClientTableAdapter
        '
        Me.APP_UtilisateurClientTableAdapter.ClearBeforeFill = True
        '
        'UtilisateurID
        '
        Me.UtilisateurID.DataPropertyName = "UtilisateurID"
        Me.UtilisateurID.HeaderText = "UtilisateurID"
        Me.UtilisateurID.Name = "UtilisateurID"
        '
        'CommandeID
        '
        Me.CommandeID.DataPropertyName = "CommandeID"
        Me.CommandeID.HeaderText = "CommandeID"
        Me.CommandeID.Name = "CommandeID"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CommandeDate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CommandeDate"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CommandeEtat"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CommandeEtat"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CommandeMethodePaiement"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CommandeMethodePaiement"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CommandeDateLimitePaiement"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CommandeDateLimitePaiement"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'FrmCommandes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 615)
        Me.Controls.Add(Me.APP_CommandeDataGridView)
        Me.Controls.Add(Me.btnaccueil)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmCommandes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCommandes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.APP_CommandeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_CommandeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDD_TurbotDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_CommandeUtilisateurBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_UtilisateurClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BDD_TurbotDataSet As BDD_TurbotDataSet
    Friend WithEvents APP_CommandeTableAdapter As BDD_TurbotDataSetTableAdapters.APP_CommandeTableAdapter
    Friend WithEvents TableAdapterManager As BDD_TurbotDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnaccueil As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnPasserCommande As Button
    Friend WithEvents APP_CommandeUtilisateurBindingSource As BindingSource
    Friend WithEvents APP_CommandeUtilisateurTableAdapter As BDD_TurbotDataSetTableAdapters.APP_CommandeUtilisateurTableAdapter
    Friend WithEvents UtilisateurIDTextBox As TextBox
    Friend WithEvents dtpCommandeDateLimite As DateTimePicker
    Friend WithEvents dtpCommandeDate As DateTimePicker
    Friend WithEvents efCommandeID As TextBox
    Friend WithEvents lbMoyenPaiement As ListBox
    Friend WithEvents lbEtatCommande As ListBox
    Friend WithEvents APP_UtilisateurClientBindingSource As BindingSource
    Friend WithEvents APP_UtilisateurClientTableAdapter As BDD_TurbotDataSetTableAdapters.APP_UtilisateurClientTableAdapter
    Friend WithEvents APP_CommandeBindingSource As BindingSource
    Friend WithEvents APP_CommandeDataGridView As DataGridView
    Friend WithEvents UtilisateurID As DataGridViewTextBoxColumn
    Friend WithEvents CommandeID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
