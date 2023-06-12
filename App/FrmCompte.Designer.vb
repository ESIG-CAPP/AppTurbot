<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCompte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCompte))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblShowEmail = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.Label()
        Me.lblShowSurname = New System.Windows.Forms.Label()
        Me.lblShowName = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.BDD_TurbotDataSet = New App.BDD_TurbotDataSet()
        Me.APP_UtilisateurTableAdapter = New App.BDD_TurbotDataSetTableAdapters.APP_UtilisateurTableAdapter()
        Me.btnGoHome = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New App.BDD_TurbotDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnModifyDelete = New System.Windows.Forms.Button()
        Me.btnModifyPassword = New System.Windows.Forms.Button()
        Me.btnModifyEmail = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BDD_TurbotDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblShowEmail)
        Me.GroupBox1.Controls.Add(Me.Email)
        Me.GroupBox1.Controls.Add(Me.lblShowSurname)
        Me.GroupBox1.Controls.Add(Me.lblShowName)
        Me.GroupBox1.Controls.Add(Me.lblSurname)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 112)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informations pratiques"
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
        'BDD_TurbotDataSet
        '
        Me.BDD_TurbotDataSet.DataSetName = "BDD_TurbotDataSet"
        Me.BDD_TurbotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'APP_UtilisateurTableAdapter
        '
        Me.APP_UtilisateurTableAdapter.ClearBeforeFill = True
        '
        'btnGoHome
        '
        Me.btnGoHome.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGoHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnGoHome.ForeColor = System.Drawing.Color.Black
        Me.btnGoHome.Location = New System.Drawing.Point(979, 493)
        Me.btnGoHome.Name = "btnGoHome"
        Me.btnGoHome.Size = New System.Drawing.Size(145, 48)
        Me.btnGoHome.TabIndex = 4
        Me.btnGoHome.Text = "Se déconnecter"
        Me.btnGoHome.UseVisualStyleBackColor = True
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnModifyDelete)
        Me.GroupBox2.Controls.Add(Me.btnModifyPassword)
        Me.GroupBox2.Controls.Add(Me.btnModifyEmail)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 354)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(226, 187)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Paramètres du compte"
        '
        'btnModifyDelete
        '
        Me.btnModifyDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnModifyDelete.ForeColor = System.Drawing.Color.Black
        Me.btnModifyDelete.Location = New System.Drawing.Point(10, 129)
        Me.btnModifyDelete.Name = "btnModifyDelete"
        Me.btnModifyDelete.Size = New System.Drawing.Size(208, 48)
        Me.btnModifyDelete.TabIndex = 8
        Me.btnModifyDelete.Text = "Supprimer mon compte"
        Me.btnModifyDelete.UseVisualStyleBackColor = True
        '
        'btnModifyPassword
        '
        Me.btnModifyPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnModifyPassword.ForeColor = System.Drawing.Color.Black
        Me.btnModifyPassword.Location = New System.Drawing.Point(10, 75)
        Me.btnModifyPassword.Name = "btnModifyPassword"
        Me.btnModifyPassword.Size = New System.Drawing.Size(208, 48)
        Me.btnModifyPassword.TabIndex = 7
        Me.btnModifyPassword.Text = "Modifier le mot de passe"
        Me.btnModifyPassword.UseVisualStyleBackColor = True
        '
        'btnModifyEmail
        '
        Me.btnModifyEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnModifyEmail.ForeColor = System.Drawing.Color.Black
        Me.btnModifyEmail.Location = New System.Drawing.Point(10, 19)
        Me.btnModifyEmail.Name = "btnModifyEmail"
        Me.btnModifyEmail.Size = New System.Drawing.Size(208, 48)
        Me.btnModifyEmail.TabIndex = 6
        Me.btnModifyEmail.Text = "Modifier l'email"
        Me.btnModifyEmail.UseVisualStyleBackColor = True
        '
        'FrmCompte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1136, 553)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnGoHome)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCompte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCompte"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BDD_TurbotDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblSurname As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblShowSurname As Label
    Friend WithEvents lblShowName As Label
    Friend WithEvents BDD_TurbotDataSet As BDD_TurbotDataSet
    Friend WithEvents APP_UtilisateurBindingSource As BindingSource
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
    Friend WithEvents btnGoHome As Button
    Friend WithEvents lblShowEmail As Label
    Friend WithEvents Email As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnModifyEmail As Button
    Friend WithEvents btnModifyDelete As Button
    Friend WithEvents btnModifyPassword As Button
End Class
