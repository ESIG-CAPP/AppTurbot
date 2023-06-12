<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInscription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInscription))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.gbInfoPersonal = New System.Windows.Forms.GroupBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.efConfirmationRegister = New System.Windows.Forms.TextBox()
        Me.efPasswordRegister = New System.Windows.Forms.TextBox()
        Me.efSexeRegister = New System.Windows.Forms.TextBox()
        Me.efTelRegister = New System.Windows.Forms.TextBox()
        Me.efEmailRegister = New System.Windows.Forms.TextBox()
        Me.efSurnameRegister = New System.Windows.Forms.TextBox()
        Me.lblConfirmationPasswordTitle = New System.Windows.Forms.Label()
        Me.lblPasswordTitle = New System.Windows.Forms.Label()
        Me.lblSexTitle = New System.Windows.Forms.Label()
        Me.lblTelTitle = New System.Windows.Forms.Label()
        Me.lblEmailTitle = New System.Windows.Forms.Label()
        Me.efNameRegister = New System.Windows.Forms.TextBox()
        Me.lblSurnameTitle = New System.Windows.Forms.Label()
        Me.lblNameTitle = New System.Windows.Forms.Label()
        Me.rbSelectClient = New System.Windows.Forms.RadioButton()
        Me.rbSelectSupport = New System.Windows.Forms.RadioButton()
        Me.rbSelectAdmin = New System.Windows.Forms.RadioButton()
        Me.gbSelectType = New System.Windows.Forms.GroupBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.gbInfoPersonal.SuspendLayout()
        Me.gbSelectType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(389, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(205, 24)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Inscription d'un compte"
        '
        'gbInfoPersonal
        '
        Me.gbInfoPersonal.Controls.Add(Me.btnRegister)
        Me.gbInfoPersonal.Controls.Add(Me.TextBox8)
        Me.gbInfoPersonal.Controls.Add(Me.TextBox7)
        Me.gbInfoPersonal.Controls.Add(Me.TextBox6)
        Me.gbInfoPersonal.Controls.Add(Me.TextBox5)
        Me.gbInfoPersonal.Controls.Add(Me.TextBox3)
        Me.gbInfoPersonal.Controls.Add(Me.TextBox2)
        Me.gbInfoPersonal.Controls.Add(Me.TextBox1)
        Me.gbInfoPersonal.Controls.Add(Me.efConfirmationRegister)
        Me.gbInfoPersonal.Controls.Add(Me.efPasswordRegister)
        Me.gbInfoPersonal.Controls.Add(Me.efSexeRegister)
        Me.gbInfoPersonal.Controls.Add(Me.efTelRegister)
        Me.gbInfoPersonal.Controls.Add(Me.efEmailRegister)
        Me.gbInfoPersonal.Controls.Add(Me.efSurnameRegister)
        Me.gbInfoPersonal.Controls.Add(Me.lblConfirmationPasswordTitle)
        Me.gbInfoPersonal.Controls.Add(Me.lblPasswordTitle)
        Me.gbInfoPersonal.Controls.Add(Me.lblSexTitle)
        Me.gbInfoPersonal.Controls.Add(Me.lblTelTitle)
        Me.gbInfoPersonal.Controls.Add(Me.lblEmailTitle)
        Me.gbInfoPersonal.Controls.Add(Me.efNameRegister)
        Me.gbInfoPersonal.Controls.Add(Me.lblSurnameTitle)
        Me.gbInfoPersonal.Controls.Add(Me.lblNameTitle)
        Me.gbInfoPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.gbInfoPersonal.ForeColor = System.Drawing.Color.White
        Me.gbInfoPersonal.Location = New System.Drawing.Point(322, 62)
        Me.gbInfoPersonal.Name = "gbInfoPersonal"
        Me.gbInfoPersonal.Size = New System.Drawing.Size(578, 454)
        Me.gbInfoPersonal.TabIndex = 1
        Me.gbInfoPersonal.TabStop = False
        Me.gbInfoPersonal.Text = "Informations personnelles"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(318, 46)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(232, 1)
        Me.TextBox8.TabIndex = 23
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(318, 72)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(232, 1)
        Me.TextBox7.TabIndex = 22
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(318, 137)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(232, 1)
        Me.TextBox6.TabIndex = 21
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(318, 166)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(232, 1)
        Me.TextBox5.TabIndex = 20
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(318, 245)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(232, 1)
        Me.TextBox3.TabIndex = 19
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(318, 192)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(232, 1)
        Me.TextBox2.TabIndex = 16
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(318, 276)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(232, 1)
        Me.TextBox1.TabIndex = 14
        '
        'efConfirmationRegister
        '
        Me.efConfirmationRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.efConfirmationRegister.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.efConfirmationRegister.Location = New System.Drawing.Point(318, 256)
        Me.efConfirmationRegister.Name = "efConfirmationRegister"
        Me.efConfirmationRegister.Size = New System.Drawing.Size(232, 17)
        Me.efConfirmationRegister.TabIndex = 13
        '
        'efPasswordRegister
        '
        Me.efPasswordRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.efPasswordRegister.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.efPasswordRegister.Location = New System.Drawing.Point(318, 226)
        Me.efPasswordRegister.Name = "efPasswordRegister"
        Me.efPasswordRegister.Size = New System.Drawing.Size(232, 17)
        Me.efPasswordRegister.TabIndex = 12
        '
        'efSexeRegister
        '
        Me.efSexeRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.efSexeRegister.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.efSexeRegister.Location = New System.Drawing.Point(318, 174)
        Me.efSexeRegister.Name = "efSexeRegister"
        Me.efSexeRegister.Size = New System.Drawing.Size(232, 17)
        Me.efSexeRegister.TabIndex = 11
        '
        'efTelRegister
        '
        Me.efTelRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.efTelRegister.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.efTelRegister.Location = New System.Drawing.Point(318, 147)
        Me.efTelRegister.Name = "efTelRegister"
        Me.efTelRegister.Size = New System.Drawing.Size(232, 17)
        Me.efTelRegister.TabIndex = 10
        '
        'efEmailRegister
        '
        Me.efEmailRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.efEmailRegister.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.efEmailRegister.Location = New System.Drawing.Point(318, 118)
        Me.efEmailRegister.Name = "efEmailRegister"
        Me.efEmailRegister.Size = New System.Drawing.Size(232, 17)
        Me.efEmailRegister.TabIndex = 9
        '
        'efSurnameRegister
        '
        Me.efSurnameRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.efSurnameRegister.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.efSurnameRegister.Location = New System.Drawing.Point(318, 53)
        Me.efSurnameRegister.Name = "efSurnameRegister"
        Me.efSurnameRegister.Size = New System.Drawing.Size(232, 17)
        Me.efSurnameRegister.TabIndex = 8
        '
        'lblConfirmationPasswordTitle
        '
        Me.lblConfirmationPasswordTitle.AutoSize = True
        Me.lblConfirmationPasswordTitle.Location = New System.Drawing.Point(24, 260)
        Me.lblConfirmationPasswordTitle.Name = "lblConfirmationPasswordTitle"
        Me.lblConfirmationPasswordTitle.Size = New System.Drawing.Size(207, 18)
        Me.lblConfirmationPasswordTitle.TabIndex = 7
        Me.lblConfirmationPasswordTitle.Text = "Confirmation du mot de passe"
        '
        'lblPasswordTitle
        '
        Me.lblPasswordTitle.AutoSize = True
        Me.lblPasswordTitle.Location = New System.Drawing.Point(24, 229)
        Me.lblPasswordTitle.Name = "lblPasswordTitle"
        Me.lblPasswordTitle.Size = New System.Drawing.Size(98, 18)
        Me.lblPasswordTitle.TabIndex = 6
        Me.lblPasswordTitle.Text = "Mot de passe"
        '
        'lblSexTitle
        '
        Me.lblSexTitle.AutoSize = True
        Me.lblSexTitle.Location = New System.Drawing.Point(24, 173)
        Me.lblSexTitle.Name = "lblSexTitle"
        Me.lblSexTitle.Size = New System.Drawing.Size(41, 18)
        Me.lblSexTitle.TabIndex = 5
        Me.lblSexTitle.Text = "Sexe"
        '
        'lblTelTitle
        '
        Me.lblTelTitle.AutoSize = True
        Me.lblTelTitle.Location = New System.Drawing.Point(24, 147)
        Me.lblTelTitle.Name = "lblTelTitle"
        Me.lblTelTitle.Size = New System.Drawing.Size(77, 18)
        Me.lblTelTitle.TabIndex = 4
        Me.lblTelTitle.Text = "Téléphone"
        '
        'lblEmailTitle
        '
        Me.lblEmailTitle.AutoSize = True
        Me.lblEmailTitle.Location = New System.Drawing.Point(24, 119)
        Me.lblEmailTitle.Name = "lblEmailTitle"
        Me.lblEmailTitle.Size = New System.Drawing.Size(45, 18)
        Me.lblEmailTitle.TabIndex = 3
        Me.lblEmailTitle.Text = "Email"
        '
        'efNameRegister
        '
        Me.efNameRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.efNameRegister.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.efNameRegister.Location = New System.Drawing.Point(318, 27)
        Me.efNameRegister.Name = "efNameRegister"
        Me.efNameRegister.Size = New System.Drawing.Size(232, 17)
        Me.efNameRegister.TabIndex = 2
        '
        'lblSurnameTitle
        '
        Me.lblSurnameTitle.AutoSize = True
        Me.lblSurnameTitle.Location = New System.Drawing.Point(24, 55)
        Me.lblSurnameTitle.Name = "lblSurnameTitle"
        Me.lblSurnameTitle.Size = New System.Drawing.Size(61, 18)
        Me.lblSurnameTitle.TabIndex = 1
        Me.lblSurnameTitle.Text = "Prénom"
        '
        'lblNameTitle
        '
        Me.lblNameTitle.AutoSize = True
        Me.lblNameTitle.Location = New System.Drawing.Point(24, 29)
        Me.lblNameTitle.Name = "lblNameTitle"
        Me.lblNameTitle.Size = New System.Drawing.Size(41, 18)
        Me.lblNameTitle.TabIndex = 0
        Me.lblNameTitle.Text = "Nom"
        '
        'rbSelectClient
        '
        Me.rbSelectClient.AutoSize = True
        Me.rbSelectClient.Location = New System.Drawing.Point(50, 34)
        Me.rbSelectClient.Name = "rbSelectClient"
        Me.rbSelectClient.Size = New System.Drawing.Size(61, 21)
        Me.rbSelectClient.TabIndex = 3
        Me.rbSelectClient.TabStop = True
        Me.rbSelectClient.Text = "Client"
        Me.rbSelectClient.UseVisualStyleBackColor = True
        '
        'rbSelectSupport
        '
        Me.rbSelectSupport.AutoSize = True
        Me.rbSelectSupport.Location = New System.Drawing.Point(50, 57)
        Me.rbSelectSupport.Name = "rbSelectSupport"
        Me.rbSelectSupport.Size = New System.Drawing.Size(76, 21)
        Me.rbSelectSupport.TabIndex = 4
        Me.rbSelectSupport.TabStop = True
        Me.rbSelectSupport.Text = "Support"
        Me.rbSelectSupport.UseVisualStyleBackColor = True
        '
        'rbSelectAdmin
        '
        Me.rbSelectAdmin.AutoSize = True
        Me.rbSelectAdmin.Location = New System.Drawing.Point(50, 80)
        Me.rbSelectAdmin.Name = "rbSelectAdmin"
        Me.rbSelectAdmin.Size = New System.Drawing.Size(117, 21)
        Me.rbSelectAdmin.TabIndex = 5
        Me.rbSelectAdmin.TabStop = True
        Me.rbSelectAdmin.Text = "Administrateur"
        Me.rbSelectAdmin.UseVisualStyleBackColor = True
        '
        'gbSelectType
        '
        Me.gbSelectType.Controls.Add(Me.rbSelectAdmin)
        Me.gbSelectType.Controls.Add(Me.rbSelectSupport)
        Me.gbSelectType.Controls.Add(Me.rbSelectClient)
        Me.gbSelectType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.gbSelectType.ForeColor = System.Drawing.Color.White
        Me.gbSelectType.Location = New System.Drawing.Point(76, 199)
        Me.gbSelectType.Name = "gbSelectType"
        Me.gbSelectType.Size = New System.Drawing.Size(190, 119)
        Me.gbSelectType.TabIndex = 6
        Me.gbSelectType.TabStop = False
        Me.gbSelectType.Text = "Choix du compte"
        '
        'btnRegister
        '
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnRegister.ForeColor = System.Drawing.Color.Black
        Me.btnRegister.Location = New System.Drawing.Point(225, 416)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(128, 32)
        Me.btnRegister.TabIndex = 7
        Me.btnRegister.Text = "S'inscrire"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'FrmInscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(912, 635)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbSelectType)
        Me.Controls.Add(Me.gbInfoPersonal)
        Me.Controls.Add(Me.lblTitle)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmInscription"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inscription"
        Me.gbInfoPersonal.ResumeLayout(False)
        Me.gbInfoPersonal.PerformLayout()
        Me.gbSelectType.ResumeLayout(False)
        Me.gbSelectType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents gbInfoPersonal As GroupBox
    Friend WithEvents rbSelectClient As RadioButton
    Friend WithEvents rbSelectSupport As RadioButton
    Friend WithEvents rbSelectAdmin As RadioButton
    Friend WithEvents gbSelectType As GroupBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents lblSurnameTitle As Label
    Friend WithEvents lblNameTitle As Label
    Friend WithEvents lblPasswordTitle As Label
    Friend WithEvents lblSexTitle As Label
    Friend WithEvents lblTelTitle As Label
    Friend WithEvents lblEmailTitle As Label
    Friend WithEvents efNameRegister As TextBox
    Friend WithEvents efConfirmationRegister As TextBox
    Friend WithEvents efPasswordRegister As TextBox
    Friend WithEvents efSexeRegister As TextBox
    Friend WithEvents efTelRegister As TextBox
    Friend WithEvents efEmailRegister As TextBox
    Friend WithEvents efSurnameRegister As TextBox
    Friend WithEvents lblConfirmationPasswordTitle As Label
    Private WithEvents TextBox2 As TextBox
    Private WithEvents TextBox1 As TextBox
    Private WithEvents TextBox3 As TextBox
    Private WithEvents TextBox8 As TextBox
    Private WithEvents TextBox7 As TextBox
    Private WithEvents TextBox6 As TextBox
    Private WithEvents TextBox5 As TextBox
End Class
