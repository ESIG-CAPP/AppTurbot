<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdminAccueil
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
        Me.lblNameSurname = New System.Windows.Forms.Label()
        Me.lblLogConnexion = New System.Windows.Forms.Label()
        Me.lblBienvenue = New System.Windows.Forms.Label()
        Me.gbAdmin = New System.Windows.Forms.GroupBox()
        Me.btnManageOrders = New System.Windows.Forms.Button()
        Me.btnManageUsers = New System.Windows.Forms.Button()
        Me.btnManageProduct = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.TrUpdateLog = New System.Windows.Forms.Timer(Me.components)
        Me.gbAdmin.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNameSurname
        '
        Me.lblNameSurname.AutoSize = True
        Me.lblNameSurname.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblNameSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblNameSurname.ForeColor = System.Drawing.Color.White
        Me.lblNameSurname.Location = New System.Drawing.Point(345, 29)
        Me.lblNameSurname.Name = "lblNameSurname"
        Me.lblNameSurname.Size = New System.Drawing.Size(20, 24)
        Me.lblNameSurname.TabIndex = 17
        Me.lblNameSurname.Text = "?"
        '
        'lblLogConnexion
        '
        Me.lblLogConnexion.AutoSize = True
        Me.lblLogConnexion.BackColor = System.Drawing.Color.Transparent
        Me.lblLogConnexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblLogConnexion.ForeColor = System.Drawing.Color.White
        Me.lblLogConnexion.Location = New System.Drawing.Point(776, 423)
        Me.lblLogConnexion.Name = "lblLogConnexion"
        Me.lblLogConnexion.Size = New System.Drawing.Size(14, 15)
        Me.lblLogConnexion.TabIndex = 16
        Me.lblLogConnexion.Text = "?"
        '
        'lblBienvenue
        '
        Me.lblBienvenue.AutoSize = True
        Me.lblBienvenue.BackColor = System.Drawing.Color.Transparent
        Me.lblBienvenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblBienvenue.ForeColor = System.Drawing.Color.White
        Me.lblBienvenue.Location = New System.Drawing.Point(233, 29)
        Me.lblBienvenue.Name = "lblBienvenue"
        Me.lblBienvenue.Size = New System.Drawing.Size(106, 24)
        Me.lblBienvenue.TabIndex = 11
        Me.lblBienvenue.Text = "Bienvenue,"
        '
        'gbAdmin
        '
        Me.gbAdmin.BackColor = System.Drawing.Color.Transparent
        Me.gbAdmin.Controls.Add(Me.btnManageOrders)
        Me.gbAdmin.Controls.Add(Me.btnManageUsers)
        Me.gbAdmin.Controls.Add(Me.btnManageProduct)
        Me.gbAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.gbAdmin.ForeColor = System.Drawing.Color.White
        Me.gbAdmin.Location = New System.Drawing.Point(15, 123)
        Me.gbAdmin.Name = "gbAdmin"
        Me.gbAdmin.Size = New System.Drawing.Size(262, 180)
        Me.gbAdmin.TabIndex = 14
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
        'btnLogout
        '
        Me.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnLogout.ForeColor = System.Drawing.Color.Black
        Me.btnLogout.Location = New System.Drawing.Point(15, 390)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(145, 48)
        Me.btnLogout.TabIndex = 12
        Me.btnLogout.Text = "Se déconnecter"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'FrmAdminAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1030, 450)
        Me.Controls.Add(Me.lblNameSurname)
        Me.Controls.Add(Me.lblLogConnexion)
        Me.Controls.Add(Me.lblBienvenue)
        Me.Controls.Add(Me.gbAdmin)
        Me.Controls.Add(Me.btnLogout)
        Me.Name = "FrmAdminAccueil"
        Me.Text = "FrmAdminAccueil"
        Me.gbAdmin.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNameSurname As Label
    Friend WithEvents lblLogConnexion As Label
    Friend WithEvents lblBienvenue As Label
    Friend WithEvents gbAdmin As GroupBox
    Friend WithEvents btnManageOrders As Button
    Friend WithEvents btnManageUsers As Button
    Friend WithEvents btnManageProduct As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents TrUpdateLog As Timer
End Class
