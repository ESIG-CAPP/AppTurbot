<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmClients
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
        Dim UtilisateurNomLabel As System.Windows.Forms.Label
        Dim UtilisateurPrenomLabel As System.Windows.Forms.Label
        Dim UtilisateurEmailLabel As System.Windows.Forms.Label
        Dim AdresseRueULabel As System.Windows.Forms.Label
        Dim AdresseCPULabel As System.Windows.Forms.Label
        Dim AdresseVilleULabel As System.Windows.Forms.Label
        Dim AdressePaysULabel As System.Windows.Forms.Label
        Dim NmbCommandeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmClients))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NmbCommandeTextBox = New System.Windows.Forms.TextBox()
        Me.APP_UtilisateurBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDD_TurbotDataSet = New App.BDD_TurbotDataSet()
        Me.AdressePaysUTextBox = New System.Windows.Forms.TextBox()
        Me.AdresseVilleUTextBox = New System.Windows.Forms.TextBox()
        Me.AdresseCPUTextBox = New System.Windows.Forms.TextBox()
        Me.AdresseRueUTextBox = New System.Windows.Forms.TextBox()
        Me.UtilisateurEmailTextBox = New System.Windows.Forms.TextBox()
        Me.UtilisateurPrenomTextBox = New System.Windows.Forms.TextBox()
        Me.UtilisateurNomTextBox = New System.Windows.Forms.TextBox()
        Me.APP_UtilisateurListBox = New System.Windows.Forms.ListBox()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.APP_UtilisateurTableAdapter = New App.BDD_TurbotDataSetTableAdapters.APP_UtilisateurTableAdapter()
        Me.TableAdapterManager = New App.BDD_TurbotDataSetTableAdapters.TableAdapterManager()
        Me.APP_UtilisateurBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.APP_UtilisateurBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.APP_AdresseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.APP_AdresseTableAdapter = New App.BDD_TurbotDataSetTableAdapters.APP_AdresseTableAdapter()
        Me.APP_CommandeUtilisateurBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.APP_CommandeUtilisateurTableAdapter = New App.BDD_TurbotDataSetTableAdapters.APP_CommandeUtilisateurTableAdapter()
        Me.APP_CommandeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.APP_CommandeTableAdapter = New App.BDD_TurbotDataSetTableAdapters.APP_CommandeTableAdapter()
        UtilisateurNomLabel = New System.Windows.Forms.Label()
        UtilisateurPrenomLabel = New System.Windows.Forms.Label()
        UtilisateurEmailLabel = New System.Windows.Forms.Label()
        AdresseRueULabel = New System.Windows.Forms.Label()
        AdresseCPULabel = New System.Windows.Forms.Label()
        AdresseVilleULabel = New System.Windows.Forms.Label()
        AdressePaysULabel = New System.Windows.Forms.Label()
        NmbCommandeLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.APP_UtilisateurBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDD_TurbotDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_UtilisateurBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.APP_UtilisateurBindingNavigator.SuspendLayout()
        CType(Me.APP_AdresseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_CommandeUtilisateurBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_CommandeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UtilisateurNomLabel
        '
        UtilisateurNomLabel.AutoSize = True
        UtilisateurNomLabel.Location = New System.Drawing.Point(333, 32)
        UtilisateurNomLabel.Name = "UtilisateurNomLabel"
        UtilisateurNomLabel.Size = New System.Drawing.Size(32, 13)
        UtilisateurNomLabel.TabIndex = 1
        UtilisateurNomLabel.Text = "Nom:"
        '
        'UtilisateurPrenomLabel
        '
        UtilisateurPrenomLabel.AutoSize = True
        UtilisateurPrenomLabel.Location = New System.Drawing.Point(333, 71)
        UtilisateurPrenomLabel.Name = "UtilisateurPrenomLabel"
        UtilisateurPrenomLabel.Size = New System.Drawing.Size(46, 13)
        UtilisateurPrenomLabel.TabIndex = 3
        UtilisateurPrenomLabel.Text = "Prenom:"
        '
        'UtilisateurEmailLabel
        '
        UtilisateurEmailLabel.AutoSize = True
        UtilisateurEmailLabel.Location = New System.Drawing.Point(333, 111)
        UtilisateurEmailLabel.Name = "UtilisateurEmailLabel"
        UtilisateurEmailLabel.Size = New System.Drawing.Size(35, 13)
        UtilisateurEmailLabel.TabIndex = 5
        UtilisateurEmailLabel.Text = "Email:"
        '
        'AdresseRueULabel
        '
        AdresseRueULabel.AutoSize = True
        AdresseRueULabel.Location = New System.Drawing.Point(333, 140)
        AdresseRueULabel.Name = "AdresseRueULabel"
        AdresseRueULabel.Size = New System.Drawing.Size(74, 13)
        AdresseRueULabel.TabIndex = 7
        AdresseRueULabel.Text = "Adresse Rue :"
        '
        'AdresseCPULabel
        '
        AdresseCPULabel.AutoSize = True
        AdresseCPULabel.Location = New System.Drawing.Point(333, 167)
        AdresseCPULabel.Name = "AdresseCPULabel"
        AdresseCPULabel.Size = New System.Drawing.Size(65, 13)
        AdresseCPULabel.TabIndex = 9
        AdresseCPULabel.Text = "Adresse CP:"
        '
        'AdresseVilleULabel
        '
        AdresseVilleULabel.AutoSize = True
        AdresseVilleULabel.Location = New System.Drawing.Point(334, 213)
        AdresseVilleULabel.Name = "AdresseVilleULabel"
        AdresseVilleULabel.Size = New System.Drawing.Size(73, 13)
        AdresseVilleULabel.TabIndex = 11
        AdresseVilleULabel.Text = "Adresse Ville :"
        '
        'AdressePaysULabel
        '
        AdressePaysULabel.AutoSize = True
        AdressePaysULabel.Location = New System.Drawing.Point(333, 243)
        AdressePaysULabel.Name = "AdressePaysULabel"
        AdressePaysULabel.Size = New System.Drawing.Size(77, 13)
        AdressePaysULabel.TabIndex = 13
        AdressePaysULabel.Text = "Adresse Pays :"
        '
        'NmbCommandeLabel
        '
        NmbCommandeLabel.AutoSize = True
        NmbCommandeLabel.Location = New System.Drawing.Point(333, 275)
        NmbCommandeLabel.Name = "NmbCommandeLabel"
        NmbCommandeLabel.Size = New System.Drawing.Size(88, 13)
        NmbCommandeLabel.TabIndex = 15
        NmbCommandeLabel.Text = "Nmb Commande:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(NmbCommandeLabel)
        Me.GroupBox1.Controls.Add(Me.NmbCommandeTextBox)
        Me.GroupBox1.Controls.Add(AdressePaysULabel)
        Me.GroupBox1.Controls.Add(Me.AdressePaysUTextBox)
        Me.GroupBox1.Controls.Add(AdresseVilleULabel)
        Me.GroupBox1.Controls.Add(Me.AdresseVilleUTextBox)
        Me.GroupBox1.Controls.Add(AdresseCPULabel)
        Me.GroupBox1.Controls.Add(Me.AdresseCPUTextBox)
        Me.GroupBox1.Controls.Add(AdresseRueULabel)
        Me.GroupBox1.Controls.Add(Me.AdresseRueUTextBox)
        Me.GroupBox1.Controls.Add(UtilisateurEmailLabel)
        Me.GroupBox1.Controls.Add(Me.UtilisateurEmailTextBox)
        Me.GroupBox1.Controls.Add(UtilisateurPrenomLabel)
        Me.GroupBox1.Controls.Add(Me.UtilisateurPrenomTextBox)
        Me.GroupBox1.Controls.Add(UtilisateurNomLabel)
        Me.GroupBox1.Controls.Add(Me.UtilisateurNomTextBox)
        Me.GroupBox1.Controls.Add(Me.APP_UtilisateurListBox)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(687, 334)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clients"
        '
        'NmbCommandeTextBox
        '
        Me.NmbCommandeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.APP_UtilisateurBindingSource1, "NmbCommande", True))
        Me.NmbCommandeTextBox.Location = New System.Drawing.Point(432, 272)
        Me.NmbCommandeTextBox.Name = "NmbCommandeTextBox"
        Me.NmbCommandeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NmbCommandeTextBox.TabIndex = 16
        '
        'APP_UtilisateurBindingSource1
        '
        Me.APP_UtilisateurBindingSource1.DataMember = "APP_Utilisateur"
        Me.APP_UtilisateurBindingSource1.DataSource = Me.BDD_TurbotDataSet
        Me.APP_UtilisateurBindingSource1.Filter = "UtilisateurType = 'Client'"
        '
        'BDD_TurbotDataSet
        '
        Me.BDD_TurbotDataSet.DataSetName = "BDD_TurbotDataSet"
        Me.BDD_TurbotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdressePaysUTextBox
        '
        Me.AdressePaysUTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.APP_UtilisateurBindingSource1, "AdressePaysU", True))
        Me.AdressePaysUTextBox.Location = New System.Drawing.Point(432, 240)
        Me.AdressePaysUTextBox.Name = "AdressePaysUTextBox"
        Me.AdressePaysUTextBox.Size = New System.Drawing.Size(148, 20)
        Me.AdressePaysUTextBox.TabIndex = 14
        '
        'AdresseVilleUTextBox
        '
        Me.AdresseVilleUTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.APP_UtilisateurBindingSource1, "AdresseVilleU", True))
        Me.AdresseVilleUTextBox.Location = New System.Drawing.Point(431, 210)
        Me.AdresseVilleUTextBox.Name = "AdresseVilleUTextBox"
        Me.AdresseVilleUTextBox.Size = New System.Drawing.Size(148, 20)
        Me.AdresseVilleUTextBox.TabIndex = 12
        '
        'AdresseCPUTextBox
        '
        Me.AdresseCPUTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.APP_UtilisateurBindingSource1, "AdresseCPU", True))
        Me.AdresseCPUTextBox.Location = New System.Drawing.Point(423, 164)
        Me.AdresseCPUTextBox.Name = "AdresseCPUTextBox"
        Me.AdresseCPUTextBox.Size = New System.Drawing.Size(177, 20)
        Me.AdresseCPUTextBox.TabIndex = 10
        '
        'AdresseRueUTextBox
        '
        Me.AdresseRueUTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.APP_UtilisateurBindingSource1, "AdresseRueU", True))
        Me.AdresseRueUTextBox.Location = New System.Drawing.Point(423, 133)
        Me.AdresseRueUTextBox.Name = "AdresseRueUTextBox"
        Me.AdresseRueUTextBox.Size = New System.Drawing.Size(148, 20)
        Me.AdresseRueUTextBox.TabIndex = 8
        '
        'UtilisateurEmailTextBox
        '
        Me.UtilisateurEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.APP_UtilisateurBindingSource1, "UtilisateurEmail", True))
        Me.UtilisateurEmailTextBox.Location = New System.Drawing.Point(423, 104)
        Me.UtilisateurEmailTextBox.Name = "UtilisateurEmailTextBox"
        Me.UtilisateurEmailTextBox.Size = New System.Drawing.Size(148, 20)
        Me.UtilisateurEmailTextBox.TabIndex = 6
        '
        'UtilisateurPrenomTextBox
        '
        Me.UtilisateurPrenomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.APP_UtilisateurBindingSource1, "UtilisateurPrenom", True))
        Me.UtilisateurPrenomTextBox.Location = New System.Drawing.Point(423, 64)
        Me.UtilisateurPrenomTextBox.Name = "UtilisateurPrenomTextBox"
        Me.UtilisateurPrenomTextBox.Size = New System.Drawing.Size(148, 20)
        Me.UtilisateurPrenomTextBox.TabIndex = 4
        '
        'UtilisateurNomTextBox
        '
        Me.UtilisateurNomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.APP_UtilisateurBindingSource1, "UtilisateurNom", True))
        Me.UtilisateurNomTextBox.Location = New System.Drawing.Point(423, 25)
        Me.UtilisateurNomTextBox.Name = "UtilisateurNomTextBox"
        Me.UtilisateurNomTextBox.Size = New System.Drawing.Size(148, 20)
        Me.UtilisateurNomTextBox.TabIndex = 2
        '
        'APP_UtilisateurListBox
        '
        Me.APP_UtilisateurListBox.DataSource = Me.APP_UtilisateurBindingSource1
        Me.APP_UtilisateurListBox.DisplayMember = "NomPrenom"
        Me.APP_UtilisateurListBox.FormattingEnabled = True
        Me.APP_UtilisateurListBox.Location = New System.Drawing.Point(17, 36)
        Me.APP_UtilisateurListBox.Name = "APP_UtilisateurListBox"
        Me.APP_UtilisateurListBox.Size = New System.Drawing.Size(263, 225)
        Me.APP_UtilisateurListBox.TabIndex = 0
        Me.APP_UtilisateurListBox.ValueMember = "UtilisateurID"
        '
        'btnFermer
        '
        Me.btnFermer.Location = New System.Drawing.Point(624, 402)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(131, 32)
        Me.btnFermer.TabIndex = 1
        Me.btnFermer.Text = "Revenir à l'accueil"
        Me.btnFermer.UseVisualStyleBackColor = True
        '
        'APP_UtilisateurTableAdapter
        '
        Me.APP_UtilisateurTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.APP_UtilisateurTableAdapter = Me.APP_UtilisateurTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = App.BDD_TurbotDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'APP_UtilisateurBindingNavigator
        '
        Me.APP_UtilisateurBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.APP_UtilisateurBindingNavigator.BindingSource = Me.APP_UtilisateurBindingSource1
        Me.APP_UtilisateurBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.APP_UtilisateurBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.APP_UtilisateurBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.APP_UtilisateurBindingNavigatorSaveItem})
        Me.APP_UtilisateurBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.APP_UtilisateurBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.APP_UtilisateurBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.APP_UtilisateurBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.APP_UtilisateurBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.APP_UtilisateurBindingNavigator.Name = "APP_UtilisateurBindingNavigator"
        Me.APP_UtilisateurBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.APP_UtilisateurBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.APP_UtilisateurBindingNavigator.TabIndex = 2
        Me.APP_UtilisateurBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Ajouter nouveau"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Nombre total d'éléments"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Supprimer"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Placer en premier"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Position actuelle"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Déplacer vers le bas"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Placer en dernier"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'APP_UtilisateurBindingNavigatorSaveItem
        '
        Me.APP_UtilisateurBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.APP_UtilisateurBindingNavigatorSaveItem.Image = CType(resources.GetObject("APP_UtilisateurBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.APP_UtilisateurBindingNavigatorSaveItem.Name = "APP_UtilisateurBindingNavigatorSaveItem"
        Me.APP_UtilisateurBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.APP_UtilisateurBindingNavigatorSaveItem.Text = "Enregistrer les données"
        '
        'APP_AdresseBindingSource
        '
        Me.APP_AdresseBindingSource.DataMember = "APP_Adresse"
        Me.APP_AdresseBindingSource.DataSource = Me.BDD_TurbotDataSet
        '
        'APP_AdresseTableAdapter
        '
        Me.APP_AdresseTableAdapter.ClearBeforeFill = True
        '
        'APP_CommandeUtilisateurBindingSource
        '
        Me.APP_CommandeUtilisateurBindingSource.DataMember = "APP_CommandeUtilisateur"
        Me.APP_CommandeUtilisateurBindingSource.DataSource = Me.BDD_TurbotDataSet
        '
        'APP_CommandeUtilisateurTableAdapter
        '
        Me.APP_CommandeUtilisateurTableAdapter.ClearBeforeFill = True
        '
        'APP_CommandeBindingSource
        '
        Me.APP_CommandeBindingSource.DataMember = "APP_Commande"
        Me.APP_CommandeBindingSource.DataSource = Me.BDD_TurbotDataSet
        '
        'APP_CommandeTableAdapter
        '
        Me.APP_CommandeTableAdapter.ClearBeforeFill = True
        '
        'FrmClients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 470)
        Me.Controls.Add(Me.APP_UtilisateurBindingNavigator)
        Me.Controls.Add(Me.btnFermer)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmClients"
        Me.Text = "FrmClients"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.APP_UtilisateurBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDD_TurbotDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_UtilisateurBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.APP_UtilisateurBindingNavigator.ResumeLayout(False)
        Me.APP_UtilisateurBindingNavigator.PerformLayout()
        CType(Me.APP_AdresseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_CommandeUtilisateurBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_CommandeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnFermer As Button
    Friend WithEvents BDD_TurbotDataSet As BDD_TurbotDataSet
    Friend WithEvents APP_UtilisateurTableAdapter As BDD_TurbotDataSetTableAdapters.APP_UtilisateurTableAdapter
    Friend WithEvents TableAdapterManager As BDD_TurbotDataSetTableAdapters.TableAdapterManager
    Friend WithEvents APP_UtilisateurBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents APP_UtilisateurBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents APP_UtilisateurListBox As ListBox
    Friend WithEvents APP_UtilisateurBindingSource1 As BindingSource
    Friend WithEvents UtilisateurPrenomTextBox As TextBox
    Friend WithEvents UtilisateurNomTextBox As TextBox
    Friend WithEvents UtilisateurEmailTextBox As TextBox
    Friend WithEvents AdresseCPUTextBox As TextBox
    Friend WithEvents AdresseRueUTextBox As TextBox
    Friend WithEvents APP_AdresseBindingSource As BindingSource
    Friend WithEvents APP_AdresseTableAdapter As BDD_TurbotDataSetTableAdapters.APP_AdresseTableAdapter
    Friend WithEvents AdressePaysUTextBox As TextBox
    Friend WithEvents AdresseVilleUTextBox As TextBox
    Friend WithEvents APP_CommandeUtilisateurBindingSource As BindingSource
    Friend WithEvents APP_CommandeUtilisateurTableAdapter As BDD_TurbotDataSetTableAdapters.APP_CommandeUtilisateurTableAdapter
    Friend WithEvents APP_CommandeBindingSource As BindingSource
    Friend WithEvents APP_CommandeTableAdapter As BDD_TurbotDataSetTableAdapters.APP_CommandeTableAdapter
    Friend WithEvents NmbCommandeTextBox As TextBox
End Class
