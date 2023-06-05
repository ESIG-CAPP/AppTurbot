<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProduits
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
        Dim CategorieProduitNomLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.APP_ProduitDataGridView = New System.Windows.Forms.DataGridView()
        Me.Categorie_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APP_ProduitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDD_TurbotDataSet = New App.BDD_TurbotDataSet()
        Me.APP_ProduitTableAdapter = New App.BDD_TurbotDataSetTableAdapters.APP_ProduitTableAdapter()
        Me.TableAdapterManager = New App.BDD_TurbotDataSetTableAdapters.TableAdapterManager()
        Me.APP_CategorieProduitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.APP_CategorieProduitTableAdapter = New App.BDD_TurbotDataSetTableAdapters.APP_CategorieProduitTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.APP_ProduitBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.APP_ProduitBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategorieProduitNomComboBox = New System.Windows.Forms.ComboBox()
        CategorieProduitNomLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.APP_ProduitDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_ProduitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDD_TurbotDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_CategorieProduitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_ProduitBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_ProduitBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(CategorieProduitNomLabel)
        Me.GroupBox1.Controls.Add(Me.CategorieProduitNomComboBox)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 284)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(535, 135)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choix de la catégorie du produit (filtrage)"
        '
        'APP_ProduitDataGridView
        '
        Me.APP_ProduitDataGridView.AutoGenerateColumns = False
        Me.APP_ProduitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.APP_ProduitDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Categorie_nom, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.APP_ProduitDataGridView.DataSource = Me.APP_ProduitBindingSource
        Me.APP_ProduitDataGridView.Location = New System.Drawing.Point(0, 12)
        Me.APP_ProduitDataGridView.Name = "APP_ProduitDataGridView"
        Me.APP_ProduitDataGridView.Size = New System.Drawing.Size(942, 253)
        Me.APP_ProduitDataGridView.TabIndex = 2
        '
        'Categorie_nom
        '
        Me.Categorie_nom.DataPropertyName = "Categorie_nom"
        Me.Categorie_nom.HeaderText = "Categorie_nom"
        Me.Categorie_nom.Name = "Categorie_nom"
        Me.Categorie_nom.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ProduitID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ProduitID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProduitID_REMPLACE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ProduitID_REMPLACE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CategorieProduitID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CategorieProduitID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ProduitNom"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ProduitNom"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ProduitDescription"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ProduitDescription"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ProduitPrix"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ProduitPrix"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ProduitStock"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ProduitStock"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ProduitImage"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ProduitImage"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'APP_ProduitBindingSource
        '
        Me.APP_ProduitBindingSource.DataMember = "APP_Produit"
        Me.APP_ProduitBindingSource.DataSource = Me.BDD_TurbotDataSet
        '
        'BDD_TurbotDataSet
        '
        Me.BDD_TurbotDataSet.DataSetName = "BDD_TurbotDataSet"
        Me.BDD_TurbotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'APP_CategorieProduitBindingSource
        '
        Me.APP_CategorieProduitBindingSource.DataMember = "APP_CategorieProduit"
        Me.APP_CategorieProduitBindingSource.DataSource = Me.BDD_TurbotDataSet
        '
        'APP_CategorieProduitTableAdapter
        '
        Me.APP_CategorieProduitTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(381, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Afficher tout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'APP_ProduitBindingSource1
        '
        Me.APP_ProduitBindingSource1.DataMember = "APP_Produit"
        Me.APP_ProduitBindingSource1.DataSource = Me.BDD_TurbotDataSet
        '
        'APP_ProduitBindingSource2
        '
        Me.APP_ProduitBindingSource2.DataMember = "APP_Produit"
        Me.APP_ProduitBindingSource2.DataSource = Me.BDD_TurbotDataSet
        '
        'CategorieProduitNomLabel
        '
        CategorieProduitNomLabel.AutoSize = True
        CategorieProduitNomLabel.Location = New System.Drawing.Point(41, 75)
        CategorieProduitNomLabel.Name = "CategorieProduitNomLabel"
        CategorieProduitNomLabel.Size = New System.Drawing.Size(116, 13)
        CategorieProduitNomLabel.TabIndex = 1
        CategorieProduitNomLabel.Text = "Categorie Produit Nom:"
        '
        'CategorieProduitNomComboBox
        '
        Me.CategorieProduitNomComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.APP_CategorieProduitBindingSource, "CategorieProduitNom", True))
        Me.CategorieProduitNomComboBox.DataSource = Me.APP_CategorieProduitBindingSource
        Me.CategorieProduitNomComboBox.DisplayMember = "CategorieProduitNom"
        Me.CategorieProduitNomComboBox.FormattingEnabled = True
        Me.CategorieProduitNomComboBox.Location = New System.Drawing.Point(163, 72)
        Me.CategorieProduitNomComboBox.Name = "CategorieProduitNomComboBox"
        Me.CategorieProduitNomComboBox.Size = New System.Drawing.Size(127, 21)
        Me.CategorieProduitNomComboBox.TabIndex = 2
        Me.CategorieProduitNomComboBox.ValueMember = "CategorieProduitNom"
        '
        'FrmProduits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 441)
        Me.Controls.Add(Me.APP_ProduitDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmProduits"
        Me.Text = "FrmProduits"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.APP_ProduitDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_ProduitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDD_TurbotDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_CategorieProduitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_ProduitBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_ProduitBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Categorie_nom As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents APP_ProduitBindingSource1 As BindingSource
    Friend WithEvents APP_ProduitBindingSource2 As BindingSource
    Friend WithEvents CategorieProduitNomComboBox As ComboBox
End Class
