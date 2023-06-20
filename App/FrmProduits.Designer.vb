<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProduits
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
        Dim CategorieProduitNomLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.APP_CategorieProduitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDD_TurbotDataSet = New App.BDD_TurbotDataSet()
        Me.txtNmbProduits = New System.Windows.Forms.TextBox()
        Me.lblNmbProduits = New System.Windows.Forms.Label()
        Me.btnAfficherTout = New System.Windows.Forms.Button()
        Me.APP_ProduitDataGridView = New System.Windows.Forms.DataGridView()
        Me.ProduitIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categorie_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProduitIDREMPLACEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategorieProduitIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProduitNomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProduitDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProduitPrixDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProduitStockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProduitImageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategorienomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APP_ProduitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.APP_ProduitTableAdapter = New App.BDD_TurbotDataSetTableAdapters.APP_ProduitTableAdapter()
        Me.TableAdapterManager = New App.BDD_TurbotDataSetTableAdapters.TableAdapterManager()
        Me.APP_CategorieProduitTableAdapter = New App.BDD_TurbotDataSetTableAdapters.APP_CategorieProduitTableAdapter()
        Me.btnGoHome = New System.Windows.Forms.Button()
        Me.ApP_LigneCommandeTableAdapter1 = New App.BDD_TurbotDataSetTableAdapters.APP_LigneCommandeTableAdapter()
        CategorieProduitNomLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.APP_CategorieProduitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDD_TurbotDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_ProduitDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_ProduitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CategorieProduitNomLabel
        '
        CategorieProduitNomLabel.AutoSize = True
        CategorieProduitNomLabel.Location = New System.Drawing.Point(9, 38)
        CategorieProduitNomLabel.Name = "CategorieProduitNomLabel"
        CategorieProduitNomLabel.Size = New System.Drawing.Size(101, 13)
        CategorieProduitNomLabel.TabIndex = 1
        CategorieProduitNomLabel.Text = "Liste des catégories"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnGoHome)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.txtNmbProduits)
        Me.GroupBox1.Controls.Add(Me.lblNmbProduits)
        Me.GroupBox1.Controls.Add(CategorieProduitNomLabel)
        Me.GroupBox1.Controls.Add(Me.btnAfficherTout)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 284)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(645, 292)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informations des produits"
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.APP_CategorieProduitBindingSource
        Me.ListBox1.DisplayMember = "CategorieProduitNom"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 64)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(146, 147)
        Me.ListBox1.TabIndex = 5
        Me.ListBox1.ValueMember = "CategorieProduitNom"
        '
        'APP_CategorieProduitBindingSource
        '
        Me.APP_CategorieProduitBindingSource.DataMember = "APP_CategorieProduit"
        Me.APP_CategorieProduitBindingSource.DataSource = Me.BDD_TurbotDataSet
        '
        'BDD_TurbotDataSet
        '
        Me.BDD_TurbotDataSet.DataSetName = "BDD_TurbotDataSet"
        Me.BDD_TurbotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtNmbProduits
        '
        Me.txtNmbProduits.Location = New System.Drawing.Point(262, 64)
        Me.txtNmbProduits.Name = "txtNmbProduits"
        Me.txtNmbProduits.Size = New System.Drawing.Size(146, 20)
        Me.txtNmbProduits.TabIndex = 4
        '
        'lblNmbProduits
        '
        Me.lblNmbProduits.AutoSize = True
        Me.lblNmbProduits.Location = New System.Drawing.Point(259, 38)
        Me.lblNmbProduits.Name = "lblNmbProduits"
        Me.lblNmbProduits.Size = New System.Drawing.Size(108, 13)
        Me.lblNmbProduits.TabIndex = 3
        Me.lblNmbProduits.Text = "Nombre de produits : "
        '
        'btnAfficherTout
        '
        Me.btnAfficherTout.ForeColor = System.Drawing.Color.Black
        Me.btnAfficherTout.Location = New System.Drawing.Point(262, 107)
        Me.btnAfficherTout.Name = "btnAfficherTout"
        Me.btnAfficherTout.Size = New System.Drawing.Size(146, 23)
        Me.btnAfficherTout.TabIndex = 0
        Me.btnAfficherTout.Text = "Afficher tout"
        Me.btnAfficherTout.UseVisualStyleBackColor = True
        '
        'APP_ProduitDataGridView
        '
        Me.APP_ProduitDataGridView.AllowUserToAddRows = False
        Me.APP_ProduitDataGridView.AllowUserToDeleteRows = False
        Me.APP_ProduitDataGridView.AutoGenerateColumns = False
        Me.APP_ProduitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.APP_ProduitDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProduitIDDataGridViewTextBoxColumn, Me.Categorie_nom, Me.ProduitIDREMPLACEDataGridViewTextBoxColumn, Me.CategorieProduitIDDataGridViewTextBoxColumn, Me.ProduitNomDataGridViewTextBoxColumn, Me.ProduitDescriptionDataGridViewTextBoxColumn, Me.ProduitPrixDataGridViewTextBoxColumn, Me.ProduitStockDataGridViewTextBoxColumn, Me.ProduitImageDataGridViewTextBoxColumn, Me.CategorienomDataGridViewTextBoxColumn})
        Me.APP_ProduitDataGridView.DataSource = Me.APP_ProduitBindingSource
        Me.APP_ProduitDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.APP_ProduitDataGridView.Name = "APP_ProduitDataGridView"
        Me.APP_ProduitDataGridView.ReadOnly = True
        Me.APP_ProduitDataGridView.Size = New System.Drawing.Size(645, 230)
        Me.APP_ProduitDataGridView.TabIndex = 2
        '
        'ProduitIDDataGridViewTextBoxColumn
        '
        Me.ProduitIDDataGridViewTextBoxColumn.DataPropertyName = "ProduitID"
        Me.ProduitIDDataGridViewTextBoxColumn.HeaderText = "ProduitID"
        Me.ProduitIDDataGridViewTextBoxColumn.Name = "ProduitIDDataGridViewTextBoxColumn"
        Me.ProduitIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Categorie_nom
        '
        Me.Categorie_nom.DataPropertyName = "Categorie_nom"
        Me.Categorie_nom.HeaderText = "Categorie_nom"
        Me.Categorie_nom.Name = "Categorie_nom"
        Me.Categorie_nom.ReadOnly = True
        '
        'ProduitIDREMPLACEDataGridViewTextBoxColumn
        '
        Me.ProduitIDREMPLACEDataGridViewTextBoxColumn.DataPropertyName = "ProduitID_REMPLACE"
        Me.ProduitIDREMPLACEDataGridViewTextBoxColumn.HeaderText = "ProduitID_REMPLACE"
        Me.ProduitIDREMPLACEDataGridViewTextBoxColumn.Name = "ProduitIDREMPLACEDataGridViewTextBoxColumn"
        Me.ProduitIDREMPLACEDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProduitIDREMPLACEDataGridViewTextBoxColumn.Visible = False
        '
        'CategorieProduitIDDataGridViewTextBoxColumn
        '
        Me.CategorieProduitIDDataGridViewTextBoxColumn.DataPropertyName = "CategorieProduitID"
        Me.CategorieProduitIDDataGridViewTextBoxColumn.HeaderText = "CategorieProduitID"
        Me.CategorieProduitIDDataGridViewTextBoxColumn.Name = "CategorieProduitIDDataGridViewTextBoxColumn"
        Me.CategorieProduitIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategorieProduitIDDataGridViewTextBoxColumn.Visible = False
        '
        'ProduitNomDataGridViewTextBoxColumn
        '
        Me.ProduitNomDataGridViewTextBoxColumn.DataPropertyName = "ProduitNom"
        Me.ProduitNomDataGridViewTextBoxColumn.HeaderText = "ProduitNom"
        Me.ProduitNomDataGridViewTextBoxColumn.Name = "ProduitNomDataGridViewTextBoxColumn"
        Me.ProduitNomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProduitDescriptionDataGridViewTextBoxColumn
        '
        Me.ProduitDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProduitDescription"
        Me.ProduitDescriptionDataGridViewTextBoxColumn.HeaderText = "ProduitDescription"
        Me.ProduitDescriptionDataGridViewTextBoxColumn.Name = "ProduitDescriptionDataGridViewTextBoxColumn"
        Me.ProduitDescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProduitPrixDataGridViewTextBoxColumn
        '
        Me.ProduitPrixDataGridViewTextBoxColumn.DataPropertyName = "ProduitPrix"
        Me.ProduitPrixDataGridViewTextBoxColumn.HeaderText = "ProduitPrix"
        Me.ProduitPrixDataGridViewTextBoxColumn.Name = "ProduitPrixDataGridViewTextBoxColumn"
        Me.ProduitPrixDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProduitStockDataGridViewTextBoxColumn
        '
        Me.ProduitStockDataGridViewTextBoxColumn.DataPropertyName = "ProduitStock"
        Me.ProduitStockDataGridViewTextBoxColumn.HeaderText = "ProduitStock"
        Me.ProduitStockDataGridViewTextBoxColumn.Name = "ProduitStockDataGridViewTextBoxColumn"
        Me.ProduitStockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProduitImageDataGridViewTextBoxColumn
        '
        Me.ProduitImageDataGridViewTextBoxColumn.DataPropertyName = "ProduitImage"
        Me.ProduitImageDataGridViewTextBoxColumn.HeaderText = "ProduitImage"
        Me.ProduitImageDataGridViewTextBoxColumn.Name = "ProduitImageDataGridViewTextBoxColumn"
        Me.ProduitImageDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProduitImageDataGridViewTextBoxColumn.Visible = False
        '
        'CategorienomDataGridViewTextBoxColumn
        '
        Me.CategorienomDataGridViewTextBoxColumn.DataPropertyName = "Categorie_nom"
        Me.CategorienomDataGridViewTextBoxColumn.HeaderText = "Categorie_nom"
        Me.CategorienomDataGridViewTextBoxColumn.Name = "CategorienomDataGridViewTextBoxColumn"
        Me.CategorienomDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategorienomDataGridViewTextBoxColumn.Visible = False
        '
        'APP_ProduitBindingSource
        '
        Me.APP_ProduitBindingSource.DataMember = "APP_Produit"
        Me.APP_ProduitBindingSource.DataSource = Me.BDD_TurbotDataSet
        Me.APP_ProduitBindingSource.Filter = ""
        '
        'APP_ProduitTableAdapter
        '
        Me.APP_ProduitTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.APP_ProduitTableAdapter = Me.APP_ProduitTableAdapter
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
        'APP_CategorieProduitTableAdapter
        '
        Me.APP_CategorieProduitTableAdapter.ClearBeforeFill = True
        '
        'btnGoHome
        '
        Me.btnGoHome.ForeColor = System.Drawing.Color.Black
        Me.btnGoHome.Location = New System.Drawing.Point(499, 246)
        Me.btnGoHome.Name = "btnGoHome"
        Me.btnGoHome.Size = New System.Drawing.Size(140, 40)
        Me.btnGoHome.TabIndex = 3
        Me.btnGoHome.Text = "Revenir à l'accueil"
        Me.btnGoHome.UseVisualStyleBackColor = True
        '
        'ApP_LigneCommandeTableAdapter1
        '
        Me.ApP_LigneCommandeTableAdapter1.ClearBeforeFill = True
        '
        'FrmProduits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(673, 588)
        Me.ControlBox = False
        Me.Controls.Add(Me.APP_ProduitDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmProduits"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste des produits"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.APP_CategorieProduitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDD_TurbotDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_ProduitDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_ProduitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BDD_TurbotDataSet As BDD_TurbotDataSet
    Friend WithEvents APP_ProduitBindingSource As BindingSource
    Friend WithEvents APP_ProduitTableAdapter As BDD_TurbotDataSetTableAdapters.APP_ProduitTableAdapter
    Friend WithEvents TableAdapterManager As BDD_TurbotDataSetTableAdapters.TableAdapterManager
    Friend WithEvents APP_ProduitDataGridView As DataGridView
    Friend WithEvents APP_CategorieProduitBindingSource As BindingSource
    Friend WithEvents APP_CategorieProduitTableAdapter As BDD_TurbotDataSetTableAdapters.APP_CategorieProduitTableAdapter
    Friend WithEvents btnAfficherTout As Button
    Friend WithEvents txtNmbProduits As TextBox
    Friend WithEvents lblNmbProduits As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnGoHome As Button
    Friend WithEvents ApP_LigneCommandeTableAdapter1 As BDD_TurbotDataSetTableAdapters.APP_LigneCommandeTableAdapter
    Friend WithEvents ProduitIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Categorie_nom As DataGridViewTextBoxColumn
    Friend WithEvents ProduitIDREMPLACEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategorieProduitIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProduitNomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProduitDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProduitPrixDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProduitStockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProduitImageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategorienomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
