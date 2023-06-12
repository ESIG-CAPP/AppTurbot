<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAccueil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAccueil))
        Me.btnTickets = New System.Windows.Forms.Button()
        Me.btnCommandes = New System.Windows.Forms.Button()
        Me.btnCompte = New System.Windows.Forms.Button()
        Me.lblBienvenue = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.BDD_TurbotDataSet = New App.BDD_TurbotDataSet()
        Me.APP_UtilisateurTableAdapter = New App.BDD_TurbotDataSetTableAdapters.APP_UtilisateurTableAdapter()
        Me.TableAdapterManager = New App.BDD_TurbotDataSetTableAdapters.TableAdapterManager()
        Me.gbClient = New System.Windows.Forms.GroupBox()
        Me.gbAdmin = New System.Windows.Forms.GroupBox()
        Me.btnManageOrders = New System.Windows.Forms.Button()
        Me.btnManageUsers = New System.Windows.Forms.Button()
        Me.btnManageProduct = New System.Windows.Forms.Button()
        Me.gbSupport = New System.Windows.Forms.GroupBox()
        Me.btnManageTickets = New System.Windows.Forms.Button()
        Me.lblLogConnexion = New System.Windows.Forms.Label()
        CType(Me.BDD_TurbotDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbClient.SuspendLayout()
        Me.gbAdmin.SuspendLayout()
        Me.gbSupport.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTickets
        '
        Me.btnTickets.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnTickets.ForeColor = System.Drawing.Color.Black
        Me.btnTickets.Location = New System.Drawing.Point(7, 122)
        Me.btnTickets.Name = "btnTickets"
        Me.btnTickets.Size = New System.Drawing.Size(247, 45)
        Me.btnTickets.TabIndex = 2
        Me.btnTickets.Text = "Voir mes tickets"
        Me.btnTickets.UseVisualStyleBackColor = True
        '
        'btnCommandes
        '
        Me.btnCommandes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCommandes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnCommandes.ForeColor = System.Drawing.Color.Black
        Me.btnCommandes.Location = New System.Drawing.Point(7, 71)
        Me.btnCommandes.Name = "btnCommandes"
        Me.btnCommandes.Size = New System.Drawing.Size(247, 45)
        Me.btnCommandes.TabIndex = 1
        Me.btnCommandes.Text = "Voir mes commandes"
        Me.btnCommandes.UseVisualStyleBackColor = True
        '
        'btnCompte
        '
        Me.btnCompte.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCompte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnCompte.ForeColor = System.Drawing.Color.Black
        Me.btnCompte.Location = New System.Drawing.Point(7, 20)
        Me.btnCompte.Name = "btnCompte"
        Me.btnCompte.Size = New System.Drawing.Size(247, 45)
        Me.btnCompte.TabIndex = 0
        Me.btnCompte.Text = "Voir mon compte"
        Me.btnCompte.UseVisualStyleBackColor = True
        '
        'lblBienvenue
        '
        Me.lblBienvenue.AutoSize = True
        Me.lblBienvenue.BackColor = System.Drawing.Color.Transparent
        Me.lblBienvenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblBienvenue.ForeColor = System.Drawing.Color.White
        Me.lblBienvenue.Location = New System.Drawing.Point(345, 21)
        Me.lblBienvenue.Name = "lblBienvenue"
        Me.lblBienvenue.Size = New System.Drawing.Size(106, 24)
        Me.lblBienvenue.TabIndex = 0
        Me.lblBienvenue.Text = "Bienvenue,"
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnLogout.ForeColor = System.Drawing.Color.Black
        Me.btnLogout.Location = New System.Drawing.Point(399, 394)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(145, 48)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "Se déconnecter"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.BackColor = System.Drawing.Color.Transparent
        Me.lblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblNom.ForeColor = System.Drawing.Color.White
        Me.lblNom.Location = New System.Drawing.Point(457, 21)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(20, 24)
        Me.lblNom.TabIndex = 4
        Me.lblNom.Text = "?"
        '
        'lblPrenom
        '
        Me.lblPrenom.AutoSize = True
        Me.lblPrenom.BackColor = System.Drawing.Color.Transparent
        Me.lblPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblPrenom.ForeColor = System.Drawing.Color.White
        Me.lblPrenom.Location = New System.Drawing.Point(524, 21)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(20, 24)
        Me.lblPrenom.TabIndex = 5
        Me.lblPrenom.Text = "?"
        '
        'BDD_TurbotDataSet
        '
        Me.BDD_TurbotDataSet.DataSetName = "BDD_TurbotDataSet"
        Me.BDD_TurbotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'gbClient
        '
        Me.gbClient.BackColor = System.Drawing.Color.Transparent
        Me.gbClient.Controls.Add(Me.btnCompte)
        Me.gbClient.Controls.Add(Me.btnCommandes)
        Me.gbClient.Controls.Add(Me.btnTickets)
        Me.gbClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.gbClient.ForeColor = System.Drawing.Color.White
        Me.gbClient.Location = New System.Drawing.Point(12, 130)
        Me.gbClient.Name = "gbClient"
        Me.gbClient.Size = New System.Drawing.Size(262, 180)
        Me.gbClient.TabIndex = 6
        Me.gbClient.TabStop = False
        Me.gbClient.Text = "Espace client"
        '
        'gbAdmin
        '
        Me.gbAdmin.BackColor = System.Drawing.Color.Transparent
        Me.gbAdmin.Controls.Add(Me.btnManageOrders)
        Me.gbAdmin.Controls.Add(Me.btnManageUsers)
        Me.gbAdmin.Controls.Add(Me.btnManageProduct)
        Me.gbAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.gbAdmin.ForeColor = System.Drawing.Color.White
        Me.gbAdmin.Location = New System.Drawing.Point(341, 130)
        Me.gbAdmin.Name = "gbAdmin"
        Me.gbAdmin.Size = New System.Drawing.Size(262, 180)
        Me.gbAdmin.TabIndex = 7
        Me.gbAdmin.TabStop = False
        Me.gbAdmin.Text = "Espace administrateur"
        '
        'btnManageOrders
        '
        Me.btnManageOrders.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManageOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnManageOrders.ForeColor = System.Drawing.Color.Black
        Me.btnManageOrders.Location = New System.Drawing.Point(8, 122)
        Me.btnManageOrders.Name = "btnManageOrders"
        Me.btnManageOrders.Size = New System.Drawing.Size(247, 45)
        Me.btnManageOrders.TabIndex = 2
        Me.btnManageOrders.Text = "Gestion des commandes"
        Me.btnManageOrders.UseVisualStyleBackColor = True
        '
        'btnManageUsers
        '
        Me.btnManageUsers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManageUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnManageUsers.ForeColor = System.Drawing.Color.Black
        Me.btnManageUsers.Location = New System.Drawing.Point(8, 71)
        Me.btnManageUsers.Name = "btnManageUsers"
        Me.btnManageUsers.Size = New System.Drawing.Size(247, 45)
        Me.btnManageUsers.TabIndex = 1
        Me.btnManageUsers.Text = "Gestion des utilisateurs"
        Me.btnManageUsers.UseVisualStyleBackColor = True
        '
        'btnManageProduct
        '
        Me.btnManageProduct.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManageProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnManageProduct.ForeColor = System.Drawing.Color.Black
        Me.btnManageProduct.Location = New System.Drawing.Point(7, 20)
        Me.btnManageProduct.Name = "btnManageProduct"
        Me.btnManageProduct.Size = New System.Drawing.Size(247, 45)
        Me.btnManageProduct.TabIndex = 0
        Me.btnManageProduct.Text = "Gestion des produits"
        Me.btnManageProduct.UseVisualStyleBackColor = True
        '
        'gbSupport
        '
        Me.gbSupport.BackColor = System.Drawing.Color.Transparent
        Me.gbSupport.Controls.Add(Me.btnManageTickets)
        Me.gbSupport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.gbSupport.ForeColor = System.Drawing.Color.White
        Me.gbSupport.Location = New System.Drawing.Point(660, 130)
        Me.gbSupport.Name = "gbSupport"
        Me.gbSupport.Size = New System.Drawing.Size(262, 180)
        Me.gbSupport.TabIndex = 8
        Me.gbSupport.TabStop = False
        Me.gbSupport.Text = "Esapce support"
        '
        'btnManageTickets
        '
        Me.btnManageTickets.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManageTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnManageTickets.ForeColor = System.Drawing.Color.Black
        Me.btnManageTickets.Location = New System.Drawing.Point(7, 20)
        Me.btnManageTickets.Name = "btnManageTickets"
        Me.btnManageTickets.Size = New System.Drawing.Size(247, 45)
        Me.btnManageTickets.TabIndex = 0
        Me.btnManageTickets.Text = "Gestion des tickets"
        Me.btnManageTickets.UseVisualStyleBackColor = True
        '
        'lblLogConnexion
        '
        Me.lblLogConnexion.AutoSize = True
        Me.lblLogConnexion.BackColor = System.Drawing.Color.Transparent
        Me.lblLogConnexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblLogConnexion.ForeColor = System.Drawing.Color.White
        Me.lblLogConnexion.Location = New System.Drawing.Point(658, 427)
        Me.lblLogConnexion.Name = "lblLogConnexion"
        Me.lblLogConnexion.Size = New System.Drawing.Size(14, 15)
        Me.lblLogConnexion.TabIndex = 9
        Me.lblLogConnexion.Text = "?"
        '
        'FrmAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.App.My.Resources.Resources._3d_technology_geometric_black_background_53876_97124
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(934, 489)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblLogConnexion)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblPrenom)
        Me.Controls.Add(Me.gbSupport)
        Me.Controls.Add(Me.lblBienvenue)
        Me.Controls.Add(Me.gbAdmin)
        Me.Controls.Add(Me.gbClient)
        Me.Controls.Add(Me.btnLogout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmAccueil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accueil"
        CType(Me.BDD_TurbotDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbClient.ResumeLayout(False)
        Me.gbAdmin.ResumeLayout(False)
        Me.gbSupport.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCommandes As Button
    Friend WithEvents btnCompte As Button
    Friend WithEvents btnTickets As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblBienvenue As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents lblPrenom As Label
    Friend WithEvents BDD_TurbotDataSet As BDD_TurbotDataSet
    Friend WithEvents APP_UtilisateurTableAdapter As BDD_TurbotDataSetTableAdapters.APP_UtilisateurTableAdapter
    Friend WithEvents TableAdapterManager As BDD_TurbotDataSetTableAdapters.TableAdapterManager
    Friend WithEvents gbClient As GroupBox
    Friend WithEvents gbAdmin As GroupBox
    Friend WithEvents btnManageProduct As Button
    Friend WithEvents gbSupport As GroupBox
    Friend WithEvents btnManageTickets As Button
    Friend WithEvents btnManageOrders As Button
    Friend WithEvents btnManageUsers As Button
    Friend WithEvents lblLogConnexion As Label
End Class
