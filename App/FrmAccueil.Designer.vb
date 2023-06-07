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
        Me.btnTickets = New System.Windows.Forms.Button()
        Me.btnCommandes = New System.Windows.Forms.Button()
        Me.btnCompte = New System.Windows.Forms.Button()
        Me.lblBienvenue = New System.Windows.Forms.Label()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.BDD_TurbotDataSet = New App.BDD_TurbotDataSet()
        Me.APP_UtilisateurTableAdapter = New App.BDD_TurbotDataSetTableAdapters.APP_UtilisateurTableAdapter()
        Me.TableAdapterManager = New App.BDD_TurbotDataSetTableAdapters.TableAdapterManager()
        CType(Me.BDD_TurbotDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTickets
        '
        Me.btnTickets.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnTickets.ForeColor = System.Drawing.Color.Black
        Me.btnTickets.Location = New System.Drawing.Point(12, 227)
        Me.btnTickets.Name = "btnTickets"
        Me.btnTickets.Size = New System.Drawing.Size(169, 45)
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
        Me.btnCommandes.Location = New System.Drawing.Point(12, 176)
        Me.btnCommandes.Name = "btnCommandes"
        Me.btnCommandes.Size = New System.Drawing.Size(169, 45)
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
        Me.btnCompte.Location = New System.Drawing.Point(12, 125)
        Me.btnCompte.Name = "btnCompte"
        Me.btnCompte.Size = New System.Drawing.Size(169, 45)
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
        Me.lblBienvenue.Location = New System.Drawing.Point(417, 34)
        Me.lblBienvenue.Name = "lblBienvenue"
        Me.lblBienvenue.Size = New System.Drawing.Size(20, 24)
        Me.lblBienvenue.TabIndex = 0
        Me.lblBienvenue.Text = "?"
        '
        'btnQuitter
        '
        Me.btnQuitter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnQuitter.ForeColor = System.Drawing.Color.Black
        Me.btnQuitter.Location = New System.Drawing.Point(999, 550)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(169, 45)
        Me.btnQuitter.TabIndex = 3
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.BackColor = System.Drawing.Color.Transparent
        Me.lblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblNom.ForeColor = System.Drawing.Color.White
        Me.lblNom.Location = New System.Drawing.Point(576, 291)
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
        Me.lblPrenom.Location = New System.Drawing.Point(602, 291)
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
        'FrmAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.App.My.Resources.Resources._13386029_5193211
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1180, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblPrenom)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.btnTickets)
        Me.Controls.Add(Me.lblBienvenue)
        Me.Controls.Add(Me.btnCommandes)
        Me.Controls.Add(Me.btnCompte)
        Me.Controls.Add(Me.btnQuitter)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmAccueil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "<"
        CType(Me.BDD_TurbotDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCommandes As Button
    Friend WithEvents btnCompte As Button
    Friend WithEvents btnTickets As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents lblBienvenue As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents lblPrenom As Label
    Friend WithEvents BDD_TurbotDataSet As BDD_TurbotDataSet
    Friend WithEvents APP_UtilisateurTableAdapter As BDD_TurbotDataSetTableAdapters.APP_UtilisateurTableAdapter
    Friend WithEvents TableAdapterManager As BDD_TurbotDataSetTableAdapters.TableAdapterManager
End Class
