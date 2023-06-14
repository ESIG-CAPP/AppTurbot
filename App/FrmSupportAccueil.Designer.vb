<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSupportAccueil
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
        Me.TableAdapterManager = New App.BDD_TurbotDataSetTableAdapters.TableAdapterManager()
        Me.APP_UtilisateurTableAdapter = New App.BDD_TurbotDataSetTableAdapters.APP_UtilisateurTableAdapter()
        Me.BDD_TurbotDataSet = New App.BDD_TurbotDataSet()
        Me.lblShowEmail = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.Label()
        Me.lblShowSurname = New System.Windows.Forms.Label()
        Me.lblShowName = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblNameSurname = New System.Windows.Forms.Label()
        Me.lblBienvenue = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbSupport = New System.Windows.Forms.GroupBox()
        Me.btnManageTickets = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnModifyDelete = New System.Windows.Forms.Button()
        Me.btnModifyPassword = New System.Windows.Forms.Button()
        Me.btnModifyEmail = New System.Windows.Forms.Button()
        Me.TrUpdateLog = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        CType(Me.BDD_TurbotDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbSupport.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        'APP_UtilisateurTableAdapter
        '
        Me.APP_UtilisateurTableAdapter.ClearBeforeFill = True
        '
        'BDD_TurbotDataSet
        '
        Me.BDD_TurbotDataSet.DataSetName = "BDD_TurbotDataSet"
        Me.BDD_TurbotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblShowEmail
        '
        Me.lblShowEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblShowEmail.AutoSize = True
        Me.lblShowEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblShowEmail.Location = New System.Drawing.Point(149, 77)
        Me.lblShowEmail.Name = "lblShowEmail"
        Me.lblShowEmail.Size = New System.Drawing.Size(14, 15)
        Me.lblShowEmail.TabIndex = 5
        Me.lblShowEmail.Text = "?"
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Email.Location = New System.Drawing.Point(6, 77)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(85, 15)
        Me.Email.TabIndex = 4
        Me.Email.Text = "Adresse email"
        '
        'lblShowSurname
        '
        Me.lblShowSurname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblShowSurname.AutoSize = True
        Me.lblShowSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblShowSurname.Location = New System.Drawing.Point(149, 51)
        Me.lblShowSurname.Name = "lblShowSurname"
        Me.lblShowSurname.Size = New System.Drawing.Size(14, 15)
        Me.lblShowSurname.TabIndex = 3
        Me.lblShowSurname.Text = "?"
        '
        'lblShowName
        '
        Me.lblShowName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblShowName.AutoSize = True
        Me.lblShowName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblShowName.Location = New System.Drawing.Point(149, 25)
        Me.lblShowName.Name = "lblShowName"
        Me.lblShowName.Size = New System.Drawing.Size(14, 15)
        Me.lblShowName.TabIndex = 2
        Me.lblShowName.Text = "?"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblSurname.Location = New System.Drawing.Point(6, 51)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(51, 15)
        Me.lblSurname.TabIndex = 1
        Me.lblSurname.Text = "Prénom"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblName.Location = New System.Drawing.Point(6, 25)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(34, 15)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Nom"
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnLogout.ForeColor = System.Drawing.Color.Black
        Me.btnLogout.Location = New System.Drawing.Point(722, 376)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(145, 48)
        Me.btnLogout.TabIndex = 27
        Me.btnLogout.Text = "Se déconnecter"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'lblNameSurname
        '
        Me.lblNameSurname.AutoSize = True
        Me.lblNameSurname.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblNameSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblNameSurname.ForeColor = System.Drawing.Color.White
        Me.lblNameSurname.Location = New System.Drawing.Point(130, 54)
        Me.lblNameSurname.Name = "lblNameSurname"
        Me.lblNameSurname.Size = New System.Drawing.Size(20, 24)
        Me.lblNameSurname.TabIndex = 26
        Me.lblNameSurname.Text = "?"
        '
        'lblBienvenue
        '
        Me.lblBienvenue.AutoSize = True
        Me.lblBienvenue.BackColor = System.Drawing.Color.Transparent
        Me.lblBienvenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblBienvenue.ForeColor = System.Drawing.Color.White
        Me.lblBienvenue.Location = New System.Drawing.Point(9, 54)
        Me.lblBienvenue.Name = "lblBienvenue"
        Me.lblBienvenue.Size = New System.Drawing.Size(106, 24)
        Me.lblBienvenue.TabIndex = 25
        Me.lblBienvenue.Text = "Bienvenue,"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblShowEmail)
        Me.GroupBox1.Controls.Add(Me.Email)
        Me.GroupBox1.Controls.Add(Me.lblShowSurname)
        Me.GroupBox1.Controls.Add(Me.lblShowName)
        Me.GroupBox1.Controls.Add(Me.lblSurname)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(527, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 112)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informations pratiques"
        '
        'gbSupport
        '
        Me.gbSupport.BackColor = System.Drawing.Color.Transparent
        Me.gbSupport.Controls.Add(Me.btnManageTickets)
        Me.gbSupport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.gbSupport.ForeColor = System.Drawing.Color.White
        Me.gbSupport.Location = New System.Drawing.Point(12, 247)
        Me.gbSupport.Name = "gbSupport"
        Me.gbSupport.Size = New System.Drawing.Size(262, 180)
        Me.gbSupport.TabIndex = 31
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnModifyDelete)
        Me.GroupBox2.Controls.Add(Me.btnModifyPassword)
        Me.GroupBox2.Controls.Add(Me.btnModifyEmail)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(300, 247)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(267, 180)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Paramètres du compte"
        '
        'btnModifyDelete
        '
        Me.btnModifyDelete.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModifyDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnModifyDelete.ForeColor = System.Drawing.Color.Black
        Me.btnModifyDelete.Location = New System.Drawing.Point(10, 122)
        Me.btnModifyDelete.Name = "btnModifyDelete"
        Me.btnModifyDelete.Size = New System.Drawing.Size(249, 45)
        Me.btnModifyDelete.TabIndex = 8
        Me.btnModifyDelete.Text = "Supprimer mon compte"
        Me.btnModifyDelete.UseVisualStyleBackColor = True
        '
        'btnModifyPassword
        '
        Me.btnModifyPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModifyPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnModifyPassword.ForeColor = System.Drawing.Color.Black
        Me.btnModifyPassword.Location = New System.Drawing.Point(10, 71)
        Me.btnModifyPassword.Name = "btnModifyPassword"
        Me.btnModifyPassword.Size = New System.Drawing.Size(249, 45)
        Me.btnModifyPassword.TabIndex = 7
        Me.btnModifyPassword.Text = "Modifier le mot de passe"
        Me.btnModifyPassword.UseVisualStyleBackColor = True
        '
        'btnModifyEmail
        '
        Me.btnModifyEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModifyEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnModifyEmail.ForeColor = System.Drawing.Color.Black
        Me.btnModifyEmail.Location = New System.Drawing.Point(10, 20)
        Me.btnModifyEmail.Name = "btnModifyEmail"
        Me.btnModifyEmail.Size = New System.Drawing.Size(249, 45)
        Me.btnModifyEmail.TabIndex = 6
        Me.btnModifyEmail.Text = "Modifier l'email"
        Me.btnModifyEmail.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(9, 12)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(16, 17)
        Me.lblTime.TabIndex = 35
        Me.lblTime.Text = "?"
        '
        'FrmSupportAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(879, 439)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbSupport)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lblNameSurname)
        Me.Controls.Add(Me.lblBienvenue)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmSupportAccueil"
        Me.Text = "FrmSupportAccueil"
        CType(Me.BDD_TurbotDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbSupport.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableAdapterManager As BDD_TurbotDataSetTableAdapters.TableAdapterManager
    Friend WithEvents APP_UtilisateurTableAdapter As BDD_TurbotDataSetTableAdapters.APP_UtilisateurTableAdapter
    Friend WithEvents BDD_TurbotDataSet As BDD_TurbotDataSet
    Friend WithEvents lblShowEmail As Label
    Friend WithEvents Email As Label
    Friend WithEvents lblShowSurname As Label
    Friend WithEvents lblShowName As Label
    Friend WithEvents lblSurname As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblNameSurname As Label
    Friend WithEvents lblBienvenue As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gbSupport As GroupBox
    Friend WithEvents btnManageTickets As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnModifyDelete As Button
    Friend WithEvents btnModifyPassword As Button
    Friend WithEvents btnModifyEmail As Button
    Friend WithEvents TrUpdateLog As Timer
    Friend WithEvents lblTime As Label
End Class
