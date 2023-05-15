/*
Script de déploiement pour CAPP_Turbot

Ce code a été généré par un outil.
La modification de ce fichier peut provoquer un comportement incorrect et sera perdue si
le code est régénéré.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "CAPP_Turbot"
:setvar DefaultFilePrefix "CAPP_Turbot"
:setvar DefaultDataPath "C:\Users\LOIC.AGST\AppData\Local\Microsoft\VisualStudio\SSDT\CAPP_Turbot"
:setvar DefaultLogPath "C:\Users\LOIC.AGST\AppData\Local\Microsoft\VisualStudio\SSDT\CAPP_Turbot"

GO
:on error exit
GO
/*
Détectez le mode SQLCMD et désactivez l'exécution du script si le mode SQLCMD n'est pas pris en charge.
Pour réactiver le script une fois le mode SQLCMD activé, exécutez ce qui suit :
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'Le mode SQLCMD doit être activé de manière à pouvoir exécuter ce script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                CURSOR_DEFAULT LOCAL 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET PAGE_VERIFY NONE,
                DISABLE_BROKER 
            WITH ROLLBACK IMMEDIATE;
    END


GO
ALTER DATABASE [$(DatabaseName)]
    SET TARGET_RECOVERY_TIME = 0 SECONDS 
    WITH ROLLBACK IMMEDIATE;


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE (CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 367)) 
            WITH ROLLBACK IMMEDIATE;
    END


GO
PRINT N'Création de Table [dbo].[APP_AdminRdv]...';


GO
CREATE TABLE [dbo].[APP_AdminRdv] (
    [UtilisateurID] NUMERIC (4) NOT NULL,
    [RdvID]         NUMERIC (4) NOT NULL,
    CONSTRAINT [PK_AdminRdv] PRIMARY KEY CLUSTERED ([UtilisateurID] ASC, [RdvID] ASC)
);


GO
PRINT N'Création de Table [dbo].[APP_Adresse]...';


GO
CREATE TABLE [dbo].[APP_Adresse] (
    [AdresseID]    NUMERIC (4)  NOT NULL,
    [AdresseRue]   VARCHAR (50) NOT NULL,
    [AdresseCP]    NUMERIC (6)  NOT NULL,
    [AdresseVille] VARCHAR (30) NOT NULL,
    [AdressePays]  VARCHAR (20) NOT NULL,
    CONSTRAINT [PK_Adresse] PRIMARY KEY CLUSTERED ([AdresseID] ASC)
);


GO
PRINT N'Création de Table [dbo].[APP_AdresseRdv]...';


GO
CREATE TABLE [dbo].[APP_AdresseRdv] (
    [AdresseID] NUMERIC (4) NOT NULL,
    [RdvID]     NUMERIC (4) NOT NULL,
    CONSTRAINT [PK_AdresseRdv] PRIMARY KEY CLUSTERED ([AdresseID] ASC, [RdvID] ASC)
);


GO
PRINT N'Création de Table [dbo].[APP_CategorieProduit]...';


GO
CREATE TABLE [dbo].[APP_CategorieProduit] (
    [CategorieProduitID]          NUMERIC (4)   NOT NULL,
    [CategorieProduitNom]         VARCHAR (30)  NOT NULL,
    [CategorieProduitDescription] VARCHAR (128) NOT NULL,
    [CategorieProduitImage]       VARCHAR (255) NULL,
    CONSTRAINT [PK_CategorieProduit] PRIMARY KEY CLUSTERED ([CategorieProduitID] ASC),
    CONSTRAINT [UQ_CategorieProduitNom] UNIQUE NONCLUSTERED ([CategorieProduitNom] ASC)
);


GO
PRINT N'Création de Table [dbo].[APP_ClientRdv]...';


GO
CREATE TABLE [dbo].[APP_ClientRdv] (
    [UtilisateurID] NUMERIC (4) NOT NULL,
    [RdvID]         NUMERIC (4) NOT NULL,
    CONSTRAINT [PK_ClientRdv] PRIMARY KEY CLUSTERED ([UtilisateurID] ASC, [RdvID] ASC)
);


GO
PRINT N'Création de Table [dbo].[APP_Commande]...';


GO
CREATE TABLE [dbo].[APP_Commande] (
    [CommandeID]                 NUMERIC (4)  NOT NULL,
    [CommandeDate]               DATE         NOT NULL,
    [CommandeEtat]               VARCHAR (30) NOT NULL,
    [CommandeMethodePaiement]    VARCHAR (30) NOT NULL,
    [CommandeDateLimitePaiement] DATE         NOT NULL,
    CONSTRAINT [PK_Commande] PRIMARY KEY CLUSTERED ([CommandeID] ASC)
);


GO
PRINT N'Création de Table [dbo].[APP_CommandeUtilisateur]...';


GO
CREATE TABLE [dbo].[APP_CommandeUtilisateur] (
    [UtilisateurID] NUMERIC (4) NOT NULL,
    [CommandeID]    NUMERIC (4) NOT NULL,
    CONSTRAINT [PK_CommandeUtilisateur] PRIMARY KEY CLUSTERED ([UtilisateurID] ASC, [CommandeID] ASC)
);


GO
PRINT N'Création de Table [dbo].[APP_LigneCommande]...';


GO
CREATE TABLE [dbo].[APP_LigneCommande] (
    [CommandeID]            NUMERIC (4) NOT NULL,
    [ProduitID]             NUMERIC (4) NOT NULL,
    [LigneCommandeQuantite] NUMERIC (2) NOT NULL,
    CONSTRAINT [PK_LigneCommande] PRIMARY KEY CLUSTERED ([CommandeID] ASC, [ProduitID] ASC)
);


GO
PRINT N'Création de Table [dbo].[APP_Message]...';


GO
CREATE TABLE [dbo].[APP_Message] (
    [MessageID]      NUMERIC (4)   NOT NULL,
    [TicketID]       NUMERIC (4)   NULL,
    [UtilisateurID]  NUMERIC (4)   NULL,
    [MessageContenu] VARCHAR (300) NOT NULL,
    CONSTRAINT [PK_Message] PRIMARY KEY CLUSTERED ([MessageID] ASC)
);


GO
PRINT N'Création de Table [dbo].[APP_Produit]...';


GO
CREATE TABLE [dbo].[APP_Produit] (
    [ProduitID]          NUMERIC (4)    NOT NULL,
    [ProduitID_REMPLACE] NUMERIC (4)    NULL,
    [CategorieProduitID] NUMERIC (4)    NULL,
    [ProduitNom]         VARCHAR (60)   NOT NULL,
    [ProduitDescription] VARCHAR (200)  NOT NULL,
    [ProduitPrix]        NUMERIC (6, 2) NOT NULL,
    [ProduitStock]       NUMERIC (4)    NULL,
    [ProduitImage]       VARCHAR (255)  NULL,
    CONSTRAINT [PK_Produit] PRIMARY KEY CLUSTERED ([ProduitID] ASC),
    CONSTRAINT [UQ_ProduitNom] UNIQUE NONCLUSTERED ([ProduitNom] ASC)
);


GO
PRINT N'Création de Table [dbo].[APP_Rdv]...';


GO
CREATE TABLE [dbo].[APP_Rdv] (
    [RdvID]       NUMERIC (4) NOT NULL,
    [Rdv_TypeRdv] NUMERIC (4) NULL,
    [RdvDate]     DATE        NOT NULL,
    [RdvHeure]    DATE        NOT NULL,
    CONSTRAINT [PK_Rdv] PRIMARY KEY CLUSTERED ([RdvID] ASC)
);


GO
PRINT N'Création de Table [dbo].[APP_SupportTicket]...';


GO
CREATE TABLE [dbo].[APP_SupportTicket] (
    [UtilisateurID] NUMERIC (4) NOT NULL,
    [TicketID]      NUMERIC (4) NOT NULL,
    CONSTRAINT [PK_SupportTicket] PRIMARY KEY CLUSTERED ([UtilisateurID] ASC, [TicketID] ASC)
);


GO
PRINT N'Création de Table [dbo].[APP_Ticket]...';


GO
CREATE TABLE [dbo].[APP_Ticket] (
    [TicketID]            NUMERIC (4)  NOT NULL,
    [TicketUtilisateurID] NUMERIC (4)  NULL,
    [TicketDateCreation]  DATE         NOT NULL,
    [TicketDateFinition]  DATE         NULL,
    [TicketStatut]        VARCHAR (20) NOT NULL,
    CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED ([TicketID] ASC)
);


GO
PRINT N'Création de Table [dbo].[APP_Token]...';


GO
CREATE TABLE [dbo].[APP_Token] (
    [TokenID]             CHAR (4)      NOT NULL,
    [TokenUtilisateurID]  NUMERIC (4)   NULL,
    [TokenDateExpiration] DATE          NOT NULL,
    [TokenCode]           VARCHAR (255) NOT NULL,
    CONSTRAINT [PK_Token] PRIMARY KEY CLUSTERED ([TokenID] ASC),
    CONSTRAINT [UQ_TokenCode] UNIQUE NONCLUSTERED ([TokenCode] ASC),
    CONSTRAINT [UQ_TokenDateExpiration] UNIQUE NONCLUSTERED ([TokenDateExpiration] ASC)
);


GO
PRINT N'Création de Table [dbo].[APP_TypeRdv]...';


GO
CREATE TABLE [dbo].[APP_TypeRdv] (
    [APP_TypeRdv] NUMERIC (4)  NOT NULL,
    [TypeRdvNom]  VARCHAR (30) NOT NULL,
    CONSTRAINT [PK_TypeRdv] PRIMARY KEY CLUSTERED ([APP_TypeRdv] ASC),
    CONSTRAINT [UQ_TypeRdvNom] UNIQUE NONCLUSTERED ([TypeRdvNom] ASC)
);


GO
PRINT N'Création de Table [dbo].[APP_Utilisateur]...';


GO
CREATE TABLE [dbo].[APP_Utilisateur] (
    [UtilisateurID]       NUMERIC (4)   NOT NULL,
    [AdresseID]           NUMERIC (4)   NULL,
    [UtilisateurNom]      VARCHAR (50)  NOT NULL,
    [UtilisateurPrenom]   VARCHAR (50)  NOT NULL,
    [UtilisateurEmail]    VARCHAR (130) NOT NULL,
    [UtilisateurSexe]     VARCHAR (30)  NULL,
    [UtilisateurTel]      VARCHAR (17)  NULL,
    [UtilisateurPassword] VARCHAR (128) NOT NULL,
    [UtilisateurType]     VARCHAR (20)  NOT NULL,
    CONSTRAINT [PK_Utilisateur] PRIMARY KEY CLUSTERED ([UtilisateurID] ASC),
    CONSTRAINT [UQ_UtilisateurEmail] UNIQUE NONCLUSTERED ([UtilisateurEmail] ASC)
);


GO
PRINT N'Création de Table [dbo].[APP_UtilisateurAdmin]...';


GO
CREATE TABLE [dbo].[APP_UtilisateurAdmin] (
    [UtilisateurID] NUMERIC (4) NOT NULL,
    CONSTRAINT [PK_UtilisateurAdmin] PRIMARY KEY CLUSTERED ([UtilisateurID] ASC)
);


GO
PRINT N'Création de Table [dbo].[APP_UtilisateurClient]...';


GO
CREATE TABLE [dbo].[APP_UtilisateurClient] (
    [UtilisateurID] NUMERIC (4) NOT NULL,
    CONSTRAINT [PK_UtilisateurClient] PRIMARY KEY CLUSTERED ([UtilisateurID] ASC)
);


GO
PRINT N'Création de Table [dbo].[APP_UtilisateurSupport]...';


GO
CREATE TABLE [dbo].[APP_UtilisateurSupport] (
    [UtilisateurID]      NUMERIC (4)  NOT NULL,
    [SupportStatut]      VARCHAR (20) NOT NULL,
    [SupportLangue]      VARCHAR (20) NOT NULL,
    [SupportDateArrivee] DATE         NOT NULL,
    CONSTRAINT [PK_UtilisateurSupport] PRIMARY KEY CLUSTERED ([UtilisateurID] ASC)
);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_AdminRdv_UtilisateurAdmin]...';


GO
ALTER TABLE [dbo].[APP_AdminRdv] WITH NOCHECK
    ADD CONSTRAINT [FK_AdminRdv_UtilisateurAdmin] FOREIGN KEY ([UtilisateurID]) REFERENCES [dbo].[APP_UtilisateurAdmin] ([UtilisateurID]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_AdminRdv_Rdv]...';


GO
ALTER TABLE [dbo].[APP_AdminRdv] WITH NOCHECK
    ADD CONSTRAINT [FK_AdminRdv_Rdv] FOREIGN KEY ([RdvID]) REFERENCES [dbo].[APP_Rdv] ([RdvID]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_AdresseRdv_Adresse]...';


GO
ALTER TABLE [dbo].[APP_AdresseRdv] WITH NOCHECK
    ADD CONSTRAINT [FK_AdresseRdv_Adresse] FOREIGN KEY ([AdresseID]) REFERENCES [dbo].[APP_Adresse] ([AdresseID]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_AdresseRdv_RENDEZVOU]...';


GO
ALTER TABLE [dbo].[APP_AdresseRdv] WITH NOCHECK
    ADD CONSTRAINT [FK_AdresseRdv_RENDEZVOU] FOREIGN KEY ([RdvID]) REFERENCES [dbo].[APP_Rdv] ([RdvID]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_ClientRdv_UtilisateurClient]...';


GO
ALTER TABLE [dbo].[APP_ClientRdv] WITH NOCHECK
    ADD CONSTRAINT [FK_ClientRdv_UtilisateurClient] FOREIGN KEY ([UtilisateurID]) REFERENCES [dbo].[APP_UtilisateurClient] ([UtilisateurID]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_ClientRdv_Rdv]...';


GO
ALTER TABLE [dbo].[APP_ClientRdv] WITH NOCHECK
    ADD CONSTRAINT [FK_ClientRdv_Rdv] FOREIGN KEY ([RdvID]) REFERENCES [dbo].[APP_Rdv] ([RdvID]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_CU_Utilisateur]...';


GO
ALTER TABLE [dbo].[APP_CommandeUtilisateur] WITH NOCHECK
    ADD CONSTRAINT [FK_CU_Utilisateur] FOREIGN KEY ([UtilisateurID]) REFERENCES [dbo].[APP_Utilisateur] ([UtilisateurID]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_CU_Commande]...';


GO
ALTER TABLE [dbo].[APP_CommandeUtilisateur] WITH NOCHECK
    ADD CONSTRAINT [FK_CU_Commande] FOREIGN KEY ([CommandeID]) REFERENCES [dbo].[APP_Commande] ([CommandeID]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_LigneCommande_Commande]...';


GO
ALTER TABLE [dbo].[APP_LigneCommande] WITH NOCHECK
    ADD CONSTRAINT [FK_LigneCommande_Commande] FOREIGN KEY ([CommandeID]) REFERENCES [dbo].[APP_Commande] ([CommandeID]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_LigneCommande_Produit]...';


GO
ALTER TABLE [dbo].[APP_LigneCommande] WITH NOCHECK
    ADD CONSTRAINT [FK_LigneCommande_Produit] FOREIGN KEY ([ProduitID]) REFERENCES [dbo].[APP_Produit] ([ProduitID]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_Message_Ticket]...';


GO
ALTER TABLE [dbo].[APP_Message] WITH NOCHECK
    ADD CONSTRAINT [FK_Message_Ticket] FOREIGN KEY ([TicketID]) REFERENCES [dbo].[APP_Ticket] ([TicketID]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_Message_Utilisateur]...';


GO
ALTER TABLE [dbo].[APP_Message] WITH NOCHECK
    ADD CONSTRAINT [FK_Message_Utilisateur] FOREIGN KEY ([UtilisateurID]) REFERENCES [dbo].[APP_Utilisateur] ([UtilisateurID]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_Produit_Produit]...';


GO
ALTER TABLE [dbo].[APP_Produit] WITH NOCHECK
    ADD CONSTRAINT [FK_Produit_Produit] FOREIGN KEY ([ProduitID_REMPLACE]) REFERENCES [dbo].[APP_Produit] ([ProduitID]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_Produit_CategorieProduit]...';


GO
ALTER TABLE [dbo].[APP_Produit] WITH NOCHECK
    ADD CONSTRAINT [FK_Produit_CategorieProduit] FOREIGN KEY ([CategorieProduitID]) REFERENCES [dbo].[APP_CategorieProduit] ([CategorieProduitID]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_Rdv_TypeRdv]...';


GO
ALTER TABLE [dbo].[APP_Rdv] WITH NOCHECK
    ADD CONSTRAINT [FK_Rdv_TypeRdv] FOREIGN KEY ([Rdv_TypeRdv]) REFERENCES [dbo].[APP_TypeRdv] ([APP_TypeRdv]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_ST_UtilisateurSupport]...';


GO
ALTER TABLE [dbo].[APP_SupportTicket] WITH NOCHECK
    ADD CONSTRAINT [FK_ST_UtilisateurSupport] FOREIGN KEY ([UtilisateurID]) REFERENCES [dbo].[APP_UtilisateurSupport] ([UtilisateurID]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_SupportTicket_Ticket]...';


GO
ALTER TABLE [dbo].[APP_SupportTicket] WITH NOCHECK
    ADD CONSTRAINT [FK_SupportTicket_Ticket] FOREIGN KEY ([TicketID]) REFERENCES [dbo].[APP_Ticket] ([TicketID]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_Ticket_UtilisateurClient]...';


GO
ALTER TABLE [dbo].[APP_Ticket] WITH NOCHECK
    ADD CONSTRAINT [FK_Ticket_UtilisateurClient] FOREIGN KEY ([TicketUtilisateurID]) REFERENCES [dbo].[APP_UtilisateurClient] ([UtilisateurID]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_Token_Utilisateur]...';


GO
ALTER TABLE [dbo].[APP_Token] WITH NOCHECK
    ADD CONSTRAINT [FK_Token_Utilisateur] FOREIGN KEY ([TokenUtilisateurID]) REFERENCES [dbo].[APP_Utilisateur] ([UtilisateurID]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_Utilisateur_Adresse]...';


GO
ALTER TABLE [dbo].[APP_Utilisateur] WITH NOCHECK
    ADD CONSTRAINT [FK_Utilisateur_Adresse] FOREIGN KEY ([AdresseID]) REFERENCES [dbo].[APP_Adresse] ([AdresseID]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_UA_Utilisateur]...';


GO
ALTER TABLE [dbo].[APP_UtilisateurAdmin] WITH NOCHECK
    ADD CONSTRAINT [FK_UA_Utilisateur] FOREIGN KEY ([UtilisateurID]) REFERENCES [dbo].[APP_Utilisateur] ([UtilisateurID]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_UC_Utilisateur]...';


GO
ALTER TABLE [dbo].[APP_UtilisateurClient] WITH NOCHECK
    ADD CONSTRAINT [FK_UC_Utilisateur] FOREIGN KEY ([UtilisateurID]) REFERENCES [dbo].[APP_Utilisateur] ([UtilisateurID]);


GO
PRINT N'Création de Clé étrangère [dbo].[FK_US_Utilisateur]...';


GO
ALTER TABLE [dbo].[APP_UtilisateurSupport] WITH NOCHECK
    ADD CONSTRAINT [FK_US_Utilisateur] FOREIGN KEY ([UtilisateurID]) REFERENCES [dbo].[APP_Utilisateur] ([UtilisateurID]);


GO
PRINT N'Création de Contrainte de validation [dbo].[CK_AdresseCP]...';


GO
ALTER TABLE [dbo].[APP_Adresse] WITH NOCHECK
    ADD CONSTRAINT [CK_AdresseCP] CHECK (LEN(AdresseCP) BETWEEN 4 AND 5);


GO
PRINT N'Création de Contrainte de validation [dbo].[CK_CategorieProduitDescription]...';


GO
ALTER TABLE [dbo].[APP_CategorieProduit] WITH NOCHECK
    ADD CONSTRAINT [CK_CategorieProduitDescription] CHECK (LEN(CategorieProduitDescription) <= 128);


GO
PRINT N'Création de Contrainte de validation [dbo].[CK_CommandeEtat]...';


GO
ALTER TABLE [dbo].[APP_Commande] WITH NOCHECK
    ADD CONSTRAINT [CK_CommandeEtat] CHECK (CommandeEtat IN ('en attente', 'en cours de traitement', 'terminée'));


GO
PRINT N'Création de Contrainte de validation [dbo].[CK_ProduitPrix]...';


GO
ALTER TABLE [dbo].[APP_Produit] WITH NOCHECK
    ADD CONSTRAINT [CK_ProduitPrix] CHECK (ProduitPrix > 0);


GO
PRINT N'Création de Contrainte de validation [dbo].[CK_ProduitStock]...';


GO
ALTER TABLE [dbo].[APP_Produit] WITH NOCHECK
    ADD CONSTRAINT [CK_ProduitStock] CHECK (ProduitStock >= 0);


GO
PRINT N'Création de Contrainte de validation [dbo].[CK_TicketStatut]...';


GO
ALTER TABLE [dbo].[APP_Ticket] WITH NOCHECK
    ADD CONSTRAINT [CK_TicketStatut] CHECK (TicketStatut IN ('Ouvert', 'Fermé', 'En attente', 'Annulé'));


GO
PRINT N'Création de Contrainte de validation [dbo].[CK_TicketDate]...';


GO
ALTER TABLE [dbo].[APP_Ticket] WITH NOCHECK
    ADD CONSTRAINT [CK_TicketDate] CHECK (TicketDateCreation <= TicketDateFinition OR TicketDateFinition IS NULL);


GO
PRINT N'Création de Contrainte de validation [dbo].[CK_UtilisateurNom]...';


GO
ALTER TABLE [dbo].[APP_Utilisateur] WITH NOCHECK
    ADD CONSTRAINT [CK_UtilisateurNom] CHECK (UtilisateurNom = UPPER(UtilisateurNom));


GO
PRINT N'Création de Contrainte de validation [dbo].[CK_UtilisateurEmail]...';


GO
ALTER TABLE [dbo].[APP_Utilisateur] WITH NOCHECK
    ADD CONSTRAINT [CK_UtilisateurEmail] CHECK (UtilisateurEmail LIKE ('%@%.%') AND UtilisateurEmail = LOWER(UtilisateurEmail));


GO
PRINT N'Création de Contrainte de validation [dbo].[CK_UtilisateurSexe]...';


GO
ALTER TABLE [dbo].[APP_Utilisateur] WITH NOCHECK
    ADD CONSTRAINT [CK_UtilisateurSexe] CHECK (UtilisateurSexe LIKE 'Masculin' OR UtilisateurSexe LIKE 'Féminin' OR UtilisateurSexe LIKE 'Autre');


GO
PRINT N'Création de Contrainte de validation [dbo].[CK_UtilisateurTel]...';


GO
ALTER TABLE [dbo].[APP_Utilisateur] WITH NOCHECK
    ADD CONSTRAINT [CK_UtilisateurTel] CHECK (UtilisateurTel LIKE('+41.__.___.__.__') OR UtilisateurTel LIKE ('+33._.__.__.__.__'));


GO
PRINT N'Création de Contrainte de validation [dbo].[CK_SupportStatut]...';


GO
ALTER TABLE [dbo].[APP_UtilisateurSupport] WITH NOCHECK
    ADD CONSTRAINT [CK_SupportStatut] CHECK (SupportStatut IN ('Actif', 'Inactif'));


GO
PRINT N'Vérification de données existantes par rapport aux nouvelles contraintes';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[APP_AdminRdv] WITH CHECK CHECK CONSTRAINT [FK_AdminRdv_UtilisateurAdmin];

ALTER TABLE [dbo].[APP_AdminRdv] WITH CHECK CHECK CONSTRAINT [FK_AdminRdv_Rdv];

ALTER TABLE [dbo].[APP_AdresseRdv] WITH CHECK CHECK CONSTRAINT [FK_AdresseRdv_Adresse];

ALTER TABLE [dbo].[APP_AdresseRdv] WITH CHECK CHECK CONSTRAINT [FK_AdresseRdv_RENDEZVOU];

ALTER TABLE [dbo].[APP_ClientRdv] WITH CHECK CHECK CONSTRAINT [FK_ClientRdv_UtilisateurClient];

ALTER TABLE [dbo].[APP_ClientRdv] WITH CHECK CHECK CONSTRAINT [FK_ClientRdv_Rdv];

ALTER TABLE [dbo].[APP_CommandeUtilisateur] WITH CHECK CHECK CONSTRAINT [FK_CU_Utilisateur];

ALTER TABLE [dbo].[APP_CommandeUtilisateur] WITH CHECK CHECK CONSTRAINT [FK_CU_Commande];

ALTER TABLE [dbo].[APP_LigneCommande] WITH CHECK CHECK CONSTRAINT [FK_LigneCommande_Commande];

ALTER TABLE [dbo].[APP_LigneCommande] WITH CHECK CHECK CONSTRAINT [FK_LigneCommande_Produit];

ALTER TABLE [dbo].[APP_Message] WITH CHECK CHECK CONSTRAINT [FK_Message_Ticket];

ALTER TABLE [dbo].[APP_Message] WITH CHECK CHECK CONSTRAINT [FK_Message_Utilisateur];

ALTER TABLE [dbo].[APP_Produit] WITH CHECK CHECK CONSTRAINT [FK_Produit_Produit];

ALTER TABLE [dbo].[APP_Produit] WITH CHECK CHECK CONSTRAINT [FK_Produit_CategorieProduit];

ALTER TABLE [dbo].[APP_Rdv] WITH CHECK CHECK CONSTRAINT [FK_Rdv_TypeRdv];

ALTER TABLE [dbo].[APP_SupportTicket] WITH CHECK CHECK CONSTRAINT [FK_ST_UtilisateurSupport];

ALTER TABLE [dbo].[APP_SupportTicket] WITH CHECK CHECK CONSTRAINT [FK_SupportTicket_Ticket];

ALTER TABLE [dbo].[APP_Ticket] WITH CHECK CHECK CONSTRAINT [FK_Ticket_UtilisateurClient];

ALTER TABLE [dbo].[APP_Token] WITH CHECK CHECK CONSTRAINT [FK_Token_Utilisateur];

ALTER TABLE [dbo].[APP_Utilisateur] WITH CHECK CHECK CONSTRAINT [FK_Utilisateur_Adresse];

ALTER TABLE [dbo].[APP_UtilisateurAdmin] WITH CHECK CHECK CONSTRAINT [FK_UA_Utilisateur];

ALTER TABLE [dbo].[APP_UtilisateurClient] WITH CHECK CHECK CONSTRAINT [FK_UC_Utilisateur];

ALTER TABLE [dbo].[APP_UtilisateurSupport] WITH CHECK CHECK CONSTRAINT [FK_US_Utilisateur];

ALTER TABLE [dbo].[APP_Adresse] WITH CHECK CHECK CONSTRAINT [CK_AdresseCP];

ALTER TABLE [dbo].[APP_CategorieProduit] WITH CHECK CHECK CONSTRAINT [CK_CategorieProduitDescription];

ALTER TABLE [dbo].[APP_Commande] WITH CHECK CHECK CONSTRAINT [CK_CommandeEtat];

ALTER TABLE [dbo].[APP_Produit] WITH CHECK CHECK CONSTRAINT [CK_ProduitPrix];

ALTER TABLE [dbo].[APP_Produit] WITH CHECK CHECK CONSTRAINT [CK_ProduitStock];

ALTER TABLE [dbo].[APP_Ticket] WITH CHECK CHECK CONSTRAINT [CK_TicketStatut];

ALTER TABLE [dbo].[APP_Ticket] WITH CHECK CHECK CONSTRAINT [CK_TicketDate];

ALTER TABLE [dbo].[APP_Utilisateur] WITH CHECK CHECK CONSTRAINT [CK_UtilisateurNom];

ALTER TABLE [dbo].[APP_Utilisateur] WITH CHECK CHECK CONSTRAINT [CK_UtilisateurEmail];

ALTER TABLE [dbo].[APP_Utilisateur] WITH CHECK CHECK CONSTRAINT [CK_UtilisateurSexe];

ALTER TABLE [dbo].[APP_Utilisateur] WITH CHECK CHECK CONSTRAINT [CK_UtilisateurTel];

ALTER TABLE [dbo].[APP_UtilisateurSupport] WITH CHECK CHECK CONSTRAINT [CK_SupportStatut];


GO
PRINT N'Mise à jour terminée.';


GO
