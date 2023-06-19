<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReinitialisation
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
        Me.gbResetPassword = New System.Windows.Forms.GroupBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.efEmail = New System.Windows.Forms.TextBox()
        Me.lblResetEmailTitle = New System.Windows.Forms.Label()
        Me.BDD_TurbotDataSet = New App.BDD_TurbotDataSet()
        Me.APP_UtilisateurTableAdapter = New App.BDD_TurbotDataSetTableAdapters.APP_UtilisateurTableAdapter()
        Me.TableAdapterManager = New App.BDD_TurbotDataSetTableAdapters.TableAdapterManager()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.gbResetPassword.SuspendLayout()
        CType(Me.BDD_TurbotDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbResetPassword
        '
        Me.gbResetPassword.Controls.Add(Me.btnReset)
        Me.gbResetPassword.Controls.Add(Me.TextBox2)
        Me.gbResetPassword.Controls.Add(Me.efEmail)
        Me.gbResetPassword.Controls.Add(Me.lblResetEmailTitle)
        Me.gbResetPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.gbResetPassword.ForeColor = System.Drawing.Color.White
        Me.gbResetPassword.Location = New System.Drawing.Point(85, 34)
        Me.gbResetPassword.Name = "gbResetPassword"
        Me.gbResetPassword.Size = New System.Drawing.Size(736, 183)
        Me.gbResetPassword.TabIndex = 0
        Me.gbResetPassword.TabStop = False
        Me.gbResetPassword.Text = "Réinitialisation du mot de passe"
        '
        'btnReset
        '
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.Location = New System.Drawing.Point(268, 114)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(234, 28)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Réinitialiser le mot de passe"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(258, 86)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(273, 1)
        Me.TextBox2.TabIndex = 2
        '
        'efEmail
        '
        Me.efEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.efEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.efEmail.ForeColor = System.Drawing.Color.White
        Me.efEmail.Location = New System.Drawing.Point(258, 67)
        Me.efEmail.Name = "efEmail"
        Me.efEmail.Size = New System.Drawing.Size(273, 16)
        Me.efEmail.TabIndex = 1
        '
        'lblResetEmailTitle
        '
        Me.lblResetEmailTitle.AutoSize = True
        Me.lblResetEmailTitle.Location = New System.Drawing.Point(141, 67)
        Me.lblResetEmailTitle.Name = "lblResetEmailTitle"
        Me.lblResetEmailTitle.Size = New System.Drawing.Size(97, 17)
        Me.lblResetEmailTitle.TabIndex = 0
        Me.lblResetEmailTitle.Text = "Adresse email"
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
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(798, 239)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(85, 33)
        Me.btnQuitter.TabIndex = 1
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'FrmReinitialisation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(895, 284)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.gbResetPassword)
        Me.Name = "FrmReinitialisation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmReinitialisation"
        Me.gbResetPassword.ResumeLayout(False)
        Me.gbResetPassword.PerformLayout()
        CType(Me.BDD_TurbotDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbResetPassword As GroupBox
    Friend WithEvents efEmail As TextBox
    Friend WithEvents lblResetEmailTitle As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents BDD_TurbotDataSet As BDD_TurbotDataSet
    Friend WithEvents APP_UtilisateurTableAdapter As BDD_TurbotDataSetTableAdapters.APP_UtilisateurTableAdapter
    Friend WithEvents TableAdapterManager As BDD_TurbotDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnQuitter As Button
End Class
