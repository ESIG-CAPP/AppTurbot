<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUtilisateurs
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
        Me.APP_UtilisateurDataGridView = New System.Windows.Forms.DataGridView()
        Me.lbTotalUSER = New System.Windows.Forms.Label()
        Me.lbNmbClient = New System.Windows.Forms.Label()
        Me.lbNmbAdmin = New System.Windows.Forms.Label()
        Me.efTOTALUtilisateur = New System.Windows.Forms.TextBox()
        Me.efNmbClient = New System.Windows.Forms.TextBox()
        Me.efNmbAdmin = New System.Windows.Forms.TextBox()
        Me.lbNmbSupport = New System.Windows.Forms.Label()
        Me.efNmbSupport = New System.Windows.Forms.TextBox()
        Me.APP_UtilisateurClientDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APP_UtilisateurClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDD_TurbotDataSet = New App.BDD_TurbotDataSet()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APP_UtilisateurBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.APP_UtilisateurTableAdapter = New App.BDD_TurbotDataSetTableAdapters.APP_UtilisateurTableAdapter()
        Me.TableAdapterManager = New App.BDD_TurbotDataSetTableAdapters.TableAdapterManager()
        Me.APP_AdresseTableAdapter = New App.BDD_TurbotDataSetTableAdapters.APP_AdresseTableAdapter()
        Me.APP_AdresseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.APP_UtilisateurClientTableAdapter = New App.BDD_TurbotDataSetTableAdapters.APP_UtilisateurClientTableAdapter()
        Me.APP_UtilisateurAdminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.APP_UtilisateurAdminTableAdapter = New App.BDD_TurbotDataSetTableAdapters.APP_UtilisateurAdminTableAdapter()
        Me.APP_UtilisateurAdminDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APP_UtilisateurSupportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.APP_UtilisateurSupportTableAdapter = New App.BDD_TurbotDataSetTableAdapters.APP_UtilisateurSupportTableAdapter()
        Me.APP_UtilisateurSupportDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.APP_UtilisateurDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_UtilisateurClientDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_UtilisateurClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDD_TurbotDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_UtilisateurBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_AdresseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_UtilisateurAdminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_UtilisateurAdminDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_UtilisateurSupportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_UtilisateurSupportDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'APP_UtilisateurDataGridView
        '
        Me.APP_UtilisateurDataGridView.AllowUserToAddRows = False
        Me.APP_UtilisateurDataGridView.AllowUserToDeleteRows = False
        Me.APP_UtilisateurDataGridView.AutoGenerateColumns = False
        Me.APP_UtilisateurDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.APP_UtilisateurDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.APP_UtilisateurDataGridView.DataSource = Me.APP_UtilisateurBindingSource
        Me.APP_UtilisateurDataGridView.Location = New System.Drawing.Point(25, 47)
        Me.APP_UtilisateurDataGridView.Name = "APP_UtilisateurDataGridView"
        Me.APP_UtilisateurDataGridView.ReadOnly = True
        Me.APP_UtilisateurDataGridView.Size = New System.Drawing.Size(1144, 220)
        Me.APP_UtilisateurDataGridView.TabIndex = 1
        '
        'lbTotalUSER
        '
        Me.lbTotalUSER.AutoSize = True
        Me.lbTotalUSER.Location = New System.Drawing.Point(83, 321)
        Me.lbTotalUSER.Name = "lbTotalUSER"
        Me.lbTotalUSER.Size = New System.Drawing.Size(86, 13)
        Me.lbTotalUSER.TabIndex = 2
        Me.lbTotalUSER.Text = "Total d'utilisateur"
        '
        'lbNmbClient
        '
        Me.lbNmbClient.AutoSize = True
        Me.lbNmbClient.Location = New System.Drawing.Point(81, 354)
        Me.lbNmbClient.Name = "lbNmbClient"
        Me.lbNmbClient.Size = New System.Drawing.Size(87, 13)
        Me.lbNmbClient.TabIndex = 3
        Me.lbNmbClient.Text = "Nombre de client"
        '
        'lbNmbAdmin
        '
        Me.lbNmbAdmin.AutoSize = True
        Me.lbNmbAdmin.Location = New System.Drawing.Point(78, 386)
        Me.lbNmbAdmin.Name = "lbNmbAdmin"
        Me.lbNmbAdmin.Size = New System.Drawing.Size(120, 13)
        Me.lbNmbAdmin.TabIndex = 4
        Me.lbNmbAdmin.Text = "Nombre d'administrateur"
        '
        'efTOTALUtilisateur
        '
        Me.efTOTALUtilisateur.Enabled = False
        Me.efTOTALUtilisateur.Location = New System.Drawing.Point(206, 321)
        Me.efTOTALUtilisateur.Name = "efTOTALUtilisateur"
        Me.efTOTALUtilisateur.Size = New System.Drawing.Size(100, 20)
        Me.efTOTALUtilisateur.TabIndex = 8
        '
        'efNmbClient
        '
        Me.efNmbClient.Location = New System.Drawing.Point(206, 351)
        Me.efNmbClient.Name = "efNmbClient"
        Me.efNmbClient.Size = New System.Drawing.Size(100, 20)
        Me.efNmbClient.TabIndex = 9
        '
        'efNmbAdmin
        '
        Me.efNmbAdmin.Location = New System.Drawing.Point(206, 383)
        Me.efNmbAdmin.Name = "efNmbAdmin"
        Me.efNmbAdmin.Size = New System.Drawing.Size(100, 20)
        Me.efNmbAdmin.TabIndex = 10
        '
        'lbNmbSupport
        '
        Me.lbNmbSupport.AutoSize = True
        Me.lbNmbSupport.Location = New System.Drawing.Point(81, 418)
        Me.lbNmbSupport.Name = "lbNmbSupport"
        Me.lbNmbSupport.Size = New System.Drawing.Size(97, 13)
        Me.lbNmbSupport.TabIndex = 19
        Me.lbNmbSupport.Text = "Nombre de support"
        '
        'efNmbSupport
        '
        Me.efNmbSupport.Location = New System.Drawing.Point(206, 410)
        Me.efNmbSupport.Name = "efNmbSupport"
        Me.efNmbSupport.Size = New System.Drawing.Size(100, 20)
        Me.efNmbSupport.TabIndex = 20
        '
        'APP_UtilisateurClientDataGridView
        '
        Me.APP_UtilisateurClientDataGridView.AllowUserToAddRows = False
        Me.APP_UtilisateurClientDataGridView.AutoGenerateColumns = False
        Me.APP_UtilisateurClientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.APP_UtilisateurClientDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16})
        Me.APP_UtilisateurClientDataGridView.DataSource = Me.APP_UtilisateurClientBindingSource
        Me.APP_UtilisateurClientDataGridView.Location = New System.Drawing.Point(1148, 293)
        Me.APP_UtilisateurClientDataGridView.Name = "APP_UtilisateurClientDataGridView"
        Me.APP_UtilisateurClientDataGridView.Size = New System.Drawing.Size(10, 10)
        Me.APP_UtilisateurClientDataGridView.TabIndex = 20
        Me.APP_UtilisateurClientDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "UtilisateurID"
        Me.DataGridViewTextBoxColumn16.HeaderText = "UtilisateurID"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'APP_UtilisateurClientBindingSource
        '
        Me.APP_UtilisateurClientBindingSource.DataMember = "APP_UtilisateurClient"
        Me.APP_UtilisateurClientBindingSource.DataSource = Me.BDD_TurbotDataSet
        '
        'BDD_TurbotDataSet
        '
        Me.BDD_TurbotDataSet.DataSetName = "BDD_TurbotDataSet"
        Me.BDD_TurbotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "UtilisateurID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "UtilisateurID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "AdresseID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "AdresseID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "UtilisateurNom"
        Me.DataGridViewTextBoxColumn3.HeaderText = "UtilisateurNom"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "UtilisateurPrenom"
        Me.DataGridViewTextBoxColumn4.HeaderText = "UtilisateurPrenom"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UtilisateurEmail"
        Me.DataGridViewTextBoxColumn5.HeaderText = "UtilisateurEmail"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "UtilisateurSexe"
        Me.DataGridViewTextBoxColumn6.HeaderText = "UtilisateurSexe"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "UtilisateurTel"
        Me.DataGridViewTextBoxColumn7.HeaderText = "UtilisateurTel"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "UtilisateurPassword"
        Me.DataGridViewTextBoxColumn8.HeaderText = "UtilisateurPassword"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "UtilisateurType"
        Me.DataGridViewTextBoxColumn9.HeaderText = "UtilisateurType"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "NomPrenom"
        Me.DataGridViewTextBoxColumn10.HeaderText = "NomPrenom"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "AdresseRueU"
        Me.DataGridViewTextBoxColumn11.HeaderText = "AdresseRueU"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "AdresseCPU"
        Me.DataGridViewTextBoxColumn12.HeaderText = "AdresseCPU"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "AdresseVilleU"
        Me.DataGridViewTextBoxColumn13.HeaderText = "AdresseVilleU"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "AdressePaysU"
        Me.DataGridViewTextBoxColumn14.HeaderText = "AdressePaysU"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "NmbCommande"
        Me.DataGridViewTextBoxColumn15.HeaderText = "NmbCommande"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'APP_UtilisateurBindingSource
        '
        Me.APP_UtilisateurBindingSource.DataMember = "APP_Utilisateur"
        Me.APP_UtilisateurBindingSource.DataSource = Me.BDD_TurbotDataSet
        '
        'APP_UtilisateurTableAdapter
        '
        Me.APP_UtilisateurTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.APP_AdminRdvTableAdapter = Nothing
        Me.TableAdapterManager.APP_AdresseRdvTableAdapter = Nothing
        Me.TableAdapterManager.APP_AdresseTableAdapter = Me.APP_AdresseTableAdapter
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
        Me.TableAdapterManager.APP_UtilisateurTableAdapter = Me.APP_UtilisateurTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = App.BDD_TurbotDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'APP_AdresseTableAdapter
        '
        Me.APP_AdresseTableAdapter.ClearBeforeFill = True
        '
        'APP_AdresseBindingSource
        '
        Me.APP_AdresseBindingSource.DataMember = "APP_Adresse"
        Me.APP_AdresseBindingSource.DataSource = Me.BDD_TurbotDataSet
        '
        'APP_UtilisateurClientTableAdapter
        '
        Me.APP_UtilisateurClientTableAdapter.ClearBeforeFill = True
        '
        'APP_UtilisateurAdminBindingSource
        '
        Me.APP_UtilisateurAdminBindingSource.DataMember = "APP_UtilisateurAdmin"
        Me.APP_UtilisateurAdminBindingSource.DataSource = Me.BDD_TurbotDataSet
        '
        'APP_UtilisateurAdminTableAdapter
        '
        Me.APP_UtilisateurAdminTableAdapter.ClearBeforeFill = True
        '
        'APP_UtilisateurAdminDataGridView
        '
        Me.APP_UtilisateurAdminDataGridView.AllowUserToAddRows = False
        Me.APP_UtilisateurAdminDataGridView.AutoGenerateColumns = False
        Me.APP_UtilisateurAdminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.APP_UtilisateurAdminDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17})
        Me.APP_UtilisateurAdminDataGridView.DataSource = Me.APP_UtilisateurAdminBindingSource
        Me.APP_UtilisateurAdminDataGridView.Location = New System.Drawing.Point(1112, 293)
        Me.APP_UtilisateurAdminDataGridView.Name = "APP_UtilisateurAdminDataGridView"
        Me.APP_UtilisateurAdminDataGridView.Size = New System.Drawing.Size(10, 10)
        Me.APP_UtilisateurAdminDataGridView.TabIndex = 20
        Me.APP_UtilisateurAdminDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "UtilisateurID"
        Me.DataGridViewTextBoxColumn17.HeaderText = "UtilisateurID"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'APP_UtilisateurSupportBindingSource
        '
        Me.APP_UtilisateurSupportBindingSource.DataMember = "APP_UtilisateurSupport"
        Me.APP_UtilisateurSupportBindingSource.DataSource = Me.BDD_TurbotDataSet
        '
        'APP_UtilisateurSupportTableAdapter
        '
        Me.APP_UtilisateurSupportTableAdapter.ClearBeforeFill = True
        '
        'APP_UtilisateurSupportDataGridView
        '
        Me.APP_UtilisateurSupportDataGridView.AllowUserToAddRows = False
        Me.APP_UtilisateurSupportDataGridView.AutoGenerateColumns = False
        Me.APP_UtilisateurSupportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.APP_UtilisateurSupportDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21})
        Me.APP_UtilisateurSupportDataGridView.DataSource = Me.APP_UtilisateurSupportBindingSource
        Me.APP_UtilisateurSupportDataGridView.Location = New System.Drawing.Point(1148, 321)
        Me.APP_UtilisateurSupportDataGridView.Name = "APP_UtilisateurSupportDataGridView"
        Me.APP_UtilisateurSupportDataGridView.Size = New System.Drawing.Size(10, 10)
        Me.APP_UtilisateurSupportDataGridView.TabIndex = 20
        Me.APP_UtilisateurSupportDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "UtilisateurID"
        Me.DataGridViewTextBoxColumn18.HeaderText = "UtilisateurID"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "SupportStatut"
        Me.DataGridViewTextBoxColumn19.HeaderText = "SupportStatut"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "SupportLangue"
        Me.DataGridViewTextBoxColumn20.HeaderText = "SupportLangue"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "SupportDateArrivee"
        Me.DataGridViewTextBoxColumn21.HeaderText = "SupportDateArrivee"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 483)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Filtre sur le type"
        '
        'FrmUtilisateurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1189, 664)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.APP_UtilisateurSupportDataGridView)
        Me.Controls.Add(Me.APP_UtilisateurAdminDataGridView)
        Me.Controls.Add(Me.APP_UtilisateurClientDataGridView)
        Me.Controls.Add(Me.efNmbSupport)
        Me.Controls.Add(Me.lbNmbSupport)
        Me.Controls.Add(Me.efNmbAdmin)
        Me.Controls.Add(Me.efNmbClient)
        Me.Controls.Add(Me.efTOTALUtilisateur)
        Me.Controls.Add(Me.lbNmbAdmin)
        Me.Controls.Add(Me.lbNmbClient)
        Me.Controls.Add(Me.lbTotalUSER)
        Me.Controls.Add(Me.APP_UtilisateurDataGridView)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmUtilisateurs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmUtilisateurs"
        CType(Me.APP_UtilisateurDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_UtilisateurClientDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_UtilisateurClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDD_TurbotDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_UtilisateurBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_AdresseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_UtilisateurAdminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_UtilisateurAdminDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_UtilisateurSupportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_UtilisateurSupportDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BDD_TurbotDataSet As BDD_TurbotDataSet
    Friend WithEvents APP_UtilisateurBindingSource As BindingSource
    Friend WithEvents APP_UtilisateurTableAdapter As BDD_TurbotDataSetTableAdapters.APP_UtilisateurTableAdapter
    Friend WithEvents TableAdapterManager As BDD_TurbotDataSetTableAdapters.TableAdapterManager
    Friend WithEvents APP_AdresseTableAdapter As BDD_TurbotDataSetTableAdapters.APP_AdresseTableAdapter
    Friend WithEvents APP_UtilisateurDataGridView As DataGridView
    Friend WithEvents APP_AdresseBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents lbTotalUSER As Label
    Friend WithEvents lbNmbClient As Label
    Friend WithEvents lbNmbAdmin As Label
    Friend WithEvents efTOTALUtilisateur As TextBox
    Friend WithEvents efNmbClient As TextBox
    Friend WithEvents efNmbAdmin As TextBox
    Friend WithEvents lbNmbSupport As Label
    Friend WithEvents efNmbSupport As TextBox
    Friend WithEvents APP_UtilisateurClientBindingSource As BindingSource
    Friend WithEvents APP_UtilisateurClientTableAdapter As BDD_TurbotDataSetTableAdapters.APP_UtilisateurClientTableAdapter
    Friend WithEvents APP_UtilisateurClientDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents APP_UtilisateurAdminBindingSource As BindingSource
    Friend WithEvents APP_UtilisateurAdminTableAdapter As BDD_TurbotDataSetTableAdapters.APP_UtilisateurAdminTableAdapter
    Friend WithEvents APP_UtilisateurAdminDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents APP_UtilisateurSupportBindingSource As BindingSource
    Friend WithEvents APP_UtilisateurSupportTableAdapter As BDD_TurbotDataSetTableAdapters.APP_UtilisateurSupportTableAdapter
    Friend WithEvents APP_UtilisateurSupportDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
