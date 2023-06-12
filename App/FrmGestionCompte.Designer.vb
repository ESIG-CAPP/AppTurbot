<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGestionCompte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGestionCompte))
        Me.gbSettingsEmail = New System.Windows.Forms.GroupBox()
        Me.btnUpdateEmail = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.efNewEmail = New System.Windows.Forms.TextBox()
        Me.lblCurrentEmail = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BDD_TurbotDataSet = New App.BDD_TurbotDataSet()
        Me.APP_UtilisateurTableAdapter = New App.BDD_TurbotDataSetTableAdapters.APP_UtilisateurTableAdapter()
        Me.TableAdapterManager = New App.BDD_TurbotDataSetTableAdapters.TableAdapterManager()
        Me.gbSettingsPassword = New System.Windows.Forms.GroupBox()
        Me.btnUpdatePassword = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.efCurrentPassword = New System.Windows.Forms.TextBox()
        Me.efNewPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnGoCompte = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnUpdateAccount = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.efNewSurname = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.efNewName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbSettingsEmail.SuspendLayout()
        CType(Me.BDD_TurbotDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSettingsPassword.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbSettingsEmail
        '
        Me.gbSettingsEmail.BackColor = System.Drawing.Color.Transparent
        Me.gbSettingsEmail.Controls.Add(Me.btnUpdateEmail)
        Me.gbSettingsEmail.Controls.Add(Me.TextBox6)
        Me.gbSettingsEmail.Controls.Add(Me.efNewEmail)
        Me.gbSettingsEmail.Controls.Add(Me.lblCurrentEmail)
        Me.gbSettingsEmail.Controls.Add(Me.Label2)
        Me.gbSettingsEmail.Controls.Add(Me.Label1)
        Me.gbSettingsEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.gbSettingsEmail.ForeColor = System.Drawing.Color.White
        Me.gbSettingsEmail.Location = New System.Drawing.Point(776, 12)
        Me.gbSettingsEmail.Name = "gbSettingsEmail"
        Me.gbSettingsEmail.Size = New System.Drawing.Size(384, 192)
        Me.gbSettingsEmail.TabIndex = 0
        Me.gbSettingsEmail.TabStop = False
        Me.gbSettingsEmail.Text = "Adresse mail"
        '
        'btnUpdateEmail
        '
        Me.btnUpdateEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnUpdateEmail.ForeColor = System.Drawing.Color.Black
        Me.btnUpdateEmail.Location = New System.Drawing.Point(197, 151)
        Me.btnUpdateEmail.Name = "btnUpdateEmail"
        Me.btnUpdateEmail.Size = New System.Drawing.Size(179, 35)
        Me.btnUpdateEmail.TabIndex = 1
        Me.btnUpdateEmail.Text = "Mettre à jour l'adresse mail"
        Me.btnUpdateEmail.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(149, 84)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(227, 1)
        Me.TextBox6.TabIndex = 7
        '
        'efNewEmail
        '
        Me.efNewEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.efNewEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.efNewEmail.ForeColor = System.Drawing.Color.White
        Me.efNewEmail.Location = New System.Drawing.Point(149, 66)
        Me.efNewEmail.Name = "efNewEmail"
        Me.efNewEmail.Size = New System.Drawing.Size(227, 17)
        Me.efNewEmail.TabIndex = 0
        '
        'lblCurrentEmail
        '
        Me.lblCurrentEmail.AutoSize = True
        Me.lblCurrentEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblCurrentEmail.Location = New System.Drawing.Point(146, 31)
        Me.lblCurrentEmail.Name = "lblCurrentEmail"
        Me.lblCurrentEmail.Size = New System.Drawing.Size(16, 18)
        Me.lblCurrentEmail.TabIndex = 2
        Me.lblCurrentEmail.Text = "?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(6, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Adresse email nouvelle"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(16, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Adresse mail actuelle"
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
        'gbSettingsPassword
        '
        Me.gbSettingsPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbSettingsPassword.BackColor = System.Drawing.Color.Transparent
        Me.gbSettingsPassword.Controls.Add(Me.btnUpdatePassword)
        Me.gbSettingsPassword.Controls.Add(Me.TextBox5)
        Me.gbSettingsPassword.Controls.Add(Me.TextBox4)
        Me.gbSettingsPassword.Controls.Add(Me.efCurrentPassword)
        Me.gbSettingsPassword.Controls.Add(Me.efNewPassword)
        Me.gbSettingsPassword.Controls.Add(Me.Label5)
        Me.gbSettingsPassword.Controls.Add(Me.Label6)
        Me.gbSettingsPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.gbSettingsPassword.ForeColor = System.Drawing.Color.White
        Me.gbSettingsPassword.Location = New System.Drawing.Point(390, 12)
        Me.gbSettingsPassword.Name = "gbSettingsPassword"
        Me.gbSettingsPassword.Size = New System.Drawing.Size(380, 192)
        Me.gbSettingsPassword.TabIndex = 1
        Me.gbSettingsPassword.TabStop = False
        Me.gbSettingsPassword.Text = "Mot de passe"
        '
        'btnUpdatePassword
        '
        Me.btnUpdatePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnUpdatePassword.ForeColor = System.Drawing.Color.Black
        Me.btnUpdatePassword.Location = New System.Drawing.Point(192, 151)
        Me.btnUpdatePassword.Name = "btnUpdatePassword"
        Me.btnUpdatePassword.Size = New System.Drawing.Size(179, 35)
        Me.btnUpdatePassword.TabIndex = 2
        Me.btnUpdatePassword.Text = "Mettre à jour le mot de passe"
        Me.btnUpdatePassword.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(144, 46)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(227, 1)
        Me.TextBox5.TabIndex = 6
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(144, 82)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(227, 1)
        Me.TextBox4.TabIndex = 5
        '
        'efCurrentPassword
        '
        Me.efCurrentPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.efCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.efCurrentPassword.ForeColor = System.Drawing.Color.White
        Me.efCurrentPassword.Location = New System.Drawing.Point(144, 27)
        Me.efCurrentPassword.Name = "efCurrentPassword"
        Me.efCurrentPassword.Size = New System.Drawing.Size(227, 17)
        Me.efCurrentPassword.TabIndex = 0
        '
        'efNewPassword
        '
        Me.efNewPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.efNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.efNewPassword.ForeColor = System.Drawing.Color.White
        Me.efNewPassword.Location = New System.Drawing.Point(144, 63)
        Me.efNewPassword.Name = "efNewPassword"
        Me.efNewPassword.Size = New System.Drawing.Size(227, 17)
        Me.efNewPassword.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(7, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Nouveau mot de passe"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(23, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Mot de passe actuel"
        '
        'btnGoCompte
        '
        Me.btnGoCompte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnGoCompte.ForeColor = System.Drawing.Color.Black
        Me.btnGoCompte.Location = New System.Drawing.Point(975, 423)
        Me.btnGoCompte.Name = "btnGoCompte"
        Me.btnGoCompte.Size = New System.Drawing.Size(182, 35)
        Me.btnGoCompte.TabIndex = 8
        Me.btnGoCompte.Text = "Enregistrer les modifications"
        Me.btnGoCompte.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnUpdateAccount)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.efNewSurname)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.efNewName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 192)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informations personnelles"
        '
        'btnUpdateAccount
        '
        Me.btnUpdateAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnUpdateAccount.ForeColor = System.Drawing.Color.Black
        Me.btnUpdateAccount.Location = New System.Drawing.Point(177, 151)
        Me.btnUpdateAccount.Name = "btnUpdateAccount"
        Me.btnUpdateAccount.Size = New System.Drawing.Size(179, 35)
        Me.btnUpdateAccount.TabIndex = 7
        Me.btnUpdateAccount.Text = "Mettre à jour le compte"
        Me.btnUpdateAccount.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(129, 82)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(227, 1)
        Me.TextBox3.TabIndex = 9
        '
        'efNewSurname
        '
        Me.efNewSurname.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.efNewSurname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.efNewSurname.ForeColor = System.Drawing.Color.White
        Me.efNewSurname.Location = New System.Drawing.Point(129, 63)
        Me.efNewSurname.Name = "efNewSurname"
        Me.efNewSurname.Size = New System.Drawing.Size(227, 17)
        Me.efNewSurname.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(129, 48)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(227, 1)
        Me.TextBox1.TabIndex = 7
        '
        'efNewName
        '
        Me.efNewName.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.efNewName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.efNewName.ForeColor = System.Drawing.Color.White
        Me.efNewName.Location = New System.Drawing.Point(129, 29)
        Me.efNewName.Name = "efNewName"
        Me.efNewName.Size = New System.Drawing.Size(227, 17)
        Me.efNewName.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(72, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Prénom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(89, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nom"
        '
        'FrmGestionCompte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1169, 470)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnGoCompte)
        Me.Controls.Add(Me.gbSettingsPassword)
        Me.Controls.Add(Me.gbSettingsEmail)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmGestionCompte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmGestionCompte"
        Me.gbSettingsEmail.ResumeLayout(False)
        Me.gbSettingsEmail.PerformLayout()
        CType(Me.BDD_TurbotDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSettingsPassword.ResumeLayout(False)
        Me.gbSettingsPassword.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbSettingsEmail As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BDD_TurbotDataSet As BDD_TurbotDataSet
    Friend WithEvents APP_UtilisateurTableAdapter As BDD_TurbotDataSetTableAdapters.APP_UtilisateurTableAdapter
    Friend WithEvents TableAdapterManager As BDD_TurbotDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblCurrentEmail As Label
    Friend WithEvents efNewEmail As TextBox
    Friend WithEvents gbSettingsPassword As GroupBox
    Friend WithEvents efNewPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents efCurrentPassword As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents btnUpdateEmail As Button
    Friend WithEvents btnUpdatePassword As Button
    Friend WithEvents btnGoCompte As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents efNewName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents efNewSurname As TextBox
    Friend WithEvents btnUpdateAccount As Button
End Class
