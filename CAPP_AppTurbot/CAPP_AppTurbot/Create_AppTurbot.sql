-- -----------------------------------------------------------------------------
--      Projet : AppTurbot
--      Auteur : Andrea, Loic
--      Date de dernière modification : 31/03/2023
-- -----------------------------------------------------------------------------

-- -----------------------------------------------------------------------------
--       TABLE : APP_Adresse
-- -----------------------------------------------------------------------------

CREATE TABLE APP_Adresse (
    AdresseID NUMERIC(4) 
    CONSTRAINT PK_Adresse PRIMARY KEY,
    AdresseRue VARCHAR(50) 
    CONSTRAINT NN_AdresseRue NOT NULL,
    AdresseCP NUMERIC(6) 
    CONSTRAINT NN_AdresseCP NOT NULL
    CONSTRAINT CK_AdresseCP CHECK (LEN(AdresseCP) BETWEEN 4 AND 5), -- #1
    AdresseVille VARCHAR(30) 
    CONSTRAINT NN_AdresseVille NOT NULL,
    AdressePays VARCHAR(20) 
    CONSTRAINT NN_AdressePays NOT NULL
);
GO;

-- -----------------------------------------------------------------------------
--       TABLE : APP_Utilisateur
-- -----------------------------------------------------------------------------

CREATE TABLE APP_Utilisateur (
    UtilisateurID NUMERIC(4) 
    CONSTRAINT PK_Utilisateur PRIMARY KEY,
    AdresseID NUMERIC(4) 
    CONSTRAINT FK_Utilisateur_Adresse REFERENCES APP_Adresse (AdresseID),
    UtilisateurNom VARCHAR(50) 
    CONSTRAINT CK_UtilisateurNom CHECK(UtilisateurNom = UPPER(UtilisateurNom)) -- #2
    CONSTRAINT NN_UtilisateurNom NOT NULL,
    UtilisateurPrenom VARCHAR(50) 
    CONSTRAINT NN_UtilisateurPrenom NOT NULL,
    UtilisateurEmail VARCHAR(130)
    CONSTRAINT CK_UtilisateurEmail CHECK(UtilisateurEmail LIKE ('%@%.%') AND UtilisateurEmail = LOWER(UtilisateurEmail)) -- #3
    CONSTRAINT NN_UtilisateurEmail NOT NULL
    CONSTRAINT UQ_UtilisateurEmail UNIQUE,
    UtilisateurSexe VARCHAR(30)
    CONSTRAINT CK_UtilisateurSexe CHECK (UtilisateurSexe LIKE 'Masculin' OR UtilisateurSexe LIKE 'Féminin' OR UtilisateurSexe LIKE 'Autre'), -- #4
    UtilisateurTel VARCHAR(17)
    CONSTRAINT CK_UtilisateurTel CHECK(UtilisateurTel LIKE('+41.__.___.__.__') OR UtilisateurTel LIKE ('+33._.__.__.__.__')), -- #5
    UtilisateurPassword VARCHAR(128) 
    CONSTRAINT NN_UtilisateurPassword NOT NULL,
    UtilisateurType VARCHAR(20) 
    CONSTRAINT NN_UtilisateurType NOT NULL
);
GO;
-- -----------------------------------------------------------------------------
--       TABLE : APP_UtilisateurSupport
-- -----------------------------------------------------------------------------

CREATE TABLE APP_UtilisateurSupport (
    UtilisateurID NUMERIC(4)
    CONSTRAINT PK_UtilisateurSupport PRIMARY KEY,
    SupportStatut VARCHAR(20)
    CONSTRAINT NN_SupportStatut NOT NULL
    CONSTRAINT CK_SupportStatut CHECK (SupportStatut IN ('Actif', 'Inactif')), -- #6
    SupportLangue VARCHAR(20)
    CONSTRAINT NN_SupportLangue NOT NULL,
    SupportDateArrivee DATE
    CONSTRAINT NN_SupportDateArrivee NOT NULL,
    CONSTRAINT FK_US_Utilisateur FOREIGN KEY (UtilisateurID) REFERENCES APP_Utilisateur (UtilisateurID)
);

-- -----------------------------------------------------------------------------
--       TABLE : APP_CategorieProduit
-- -----------------------------------------------------------------------------
GO;
CREATE TABLE APP_CategorieProduit (
    CategorieProduitID NUMERIC(4)
    CONSTRAINT PK_CategorieProduit PRIMARY KEY,
    CategorieProduitNom VARCHAR(30)
    CONSTRAINT NN_CategorieProduitNom NOT NULL
    CONSTRAINT UQ_CategorieProduitNom UNIQUE,
    CategorieProduitDescription VARCHAR(128)
    CONSTRAINT NN_CategorieProduitDescription NOT NULL
    CONSTRAINT CK_CategorieProduitDescription CHECK (LEN(CategorieProduitDescription) <= 128),
    CategorieProduitImage VARCHAR(30) NULL
);
GO;
-- -----------------------------------------------------------------------------
--       TABLE : APP_Commande
-- -----------------------------------------------------------------------------

CREATE TABLE APP_Commande (
    CommandeID NUMERIC(4)  
    CONSTRAINT PK_Commande PRIMARY KEY,
    CommandeDate DATE
    CONSTRAINT NN_CommandeDate NOT NULL,
    CommandeEtat VARCHAR(30)
    CONSTRAINT NN_CommandeEtat NOT NULL
    CONSTRAINT CK_CommandeEtat CHECK (CommandeEtat IN ('en attente', 'en cours de traitement', 'terminée')),
    CommandeMethodePaiement VARCHAR(30)
    CONSTRAINT NN_CommandeMethodePaiement NOT NULL,
    CommandeDateLimitePaiement DATE
    CONSTRAINT NN_CommandeDateLimitePaiement NOT NULL
);
GO;
-- -----------------------------------------------------------------------------
--       TABLE : APP_UtilisateurClient
-- -----------------------------------------------------------------------------

CREATE TABLE APP_UtilisateurClient (
    UtilisateurID NUMERIC(4)
    CONSTRAINT PK_UtilisateurClient PRIMARY KEY,
    CONSTRAINT FK_UC_Utilisateur FOREIGN KEY (UtilisateurID) REFERENCES APP_Utilisateur (UtilisateurID)
);

-- -----------------------------------------------------------------------------
--       TABLE : APP_TypeRdv
-- -----------------------------------------------------------------------------
GO;
CREATE TABLE APP_TypeRdv (
    APP_TypeRdv NUMERIC(4)
    CONSTRAINT PK_TypeRdv PRIMARY KEY,
    TypeRdvNom VARCHAR(30)
    CONSTRAINT NN_TypeRdvNom NOT NULL
    CONSTRAINT UQ_TypeRdvNom UNIQUE
);

-- -----------------------------------------------------------------------------
--       TABLE : APP_Ticket
-- -----------------------------------------------------------------------------
GO;
CREATE TABLE APP_Ticket (
    TicketID NUMERIC(4)
    CONSTRAINT PK_Ticket PRIMARY KEY,
    TicketUtilisateurID NUMERIC(4),
    TicketDateCreation DATE
    CONSTRAINT NN_TicketDateCreation NOT NULL,
    TicketDateFinition DATE NULL,
    TicketStatut VARCHAR(20)
    CONSTRAINT NN_TicketStatut NOT NULL
    CONSTRAINT CK_TicketStatut CHECK (TicketStatut IN ('Ouvert', 'Fermé', 'En attente', 'Annulé')),
    CONSTRAINT CK_TicketDate CHECK (TicketDateCreation <= TicketDateFinition OR TicketDateFinition IS NULL),
    CONSTRAINT FK_Ticket_UtilisateurClient FOREIGN KEY (TicketUtilisateurID) REFERENCES APP_UtilisateurClient (UtilisateurID)
);

-- -----------------------------------------------------------------------------
--       TABLE : APP_Produit
-- -----------------------------------------------------------------------------
GO;
CREATE TABLE APP_Produit (
    ProduitID NUMERIC(4)
    CONSTRAINT PK_Produit PRIMARY KEY,
    ProduitID_REMPLACE NUMERIC(4)  NULL,
    CategorieProduitID NUMERIC(4),
    ProduitNom VARCHAR(60)
    CONSTRAINT NN_ProduitNom NOT NULL
    CONSTRAINT UQ_ProduitNom UNIQUE,
    ProduitDescription VARCHAR(200)
    CONSTRAINT NN_ProduitDescription NOT NULL,
    ProduitPrix NUMERIC(6,2)
    CONSTRAINT NN_ProduitPrix NOT NULL
    CONSTRAINT CK_ProduitPrix CHECK (ProduitPrix > 0),
    ProduitStock NUMERIC(4)  NULL
    CONSTRAINT CK_ProduitStock CHECK (ProduitStock >= 0),
    ProduitImage VARCHAR(30) NULL,
    CONSTRAINT FK_Produit_Produit FOREIGN KEY (ProduitID_REMPLACE) REFERENCES APP_Produit (ProduitID),
    CONSTRAINT FK_Produit_CategorieProduit FOREIGN KEY (CategorieProduitID) REFERENCES APP_CategorieProduit (CategorieProduitID)
);

-- -----------------------------------------------------------------------------
--       TABLE : APP_Message
-- -----------------------------------------------------------------------------
GO;
CREATE TABLE APP_Message (
    MessageID NUMERIC(4)
    CONSTRAINT PK_Message PRIMARY KEY,
    TicketID NUMERIC(4),
    UtilisateurID NUMERIC(4),
    MessageContenu VARCHAR(300)
    CONSTRAINT NN_MessageContenu NOT NULL,
    CONSTRAINT FK_Message_Ticket FOREIGN KEY (TicketID) REFERENCES APP_Ticket (TicketID),
    CONSTRAINT FK_Message_Utilisateur FOREIGN KEY (UtilisateurID) REFERENCES APP_Utilisateur (UtilisateurID)
);

-- -----------------------------------------------------------------------------
--       TABLE : APP_UtilisateurAdmin
-- -----------------------------------------------------------------------------
GO;
CREATE TABLE APP_UtilisateurAdmin (
    UtilisateurID NUMERIC(4)
    CONSTRAINT PK_UtilisateurAdmin PRIMARY KEY,
    CONSTRAINT FK_UA_Utilisateur FOREIGN KEY (UtilisateurID) REFERENCES APP_Utilisateur (UtilisateurID)
);

-- -----------------------------------------------------------------------------
--       TABLE : APP_Token
-- -----------------------------------------------------------------------------
GO;

CREATE TABLE APP_Token (
    TokenID CHAR(4)
    CONSTRAINT PK_Token PRIMARY KEY,
    TokenUtilisateurID NUMERIC(4),
    TokenDateExpiration DATE
    CONSTRAINT NN_TokenDateExpiration NOT NULL
    CONSTRAINT UQ_TokenDateExpiration UNIQUE,
    TokenCode VARCHAR(255)
    CONSTRAINT NN_TokenCode NOT NULL
    CONSTRAINT UQ_TokenCode UNIQUE,
    CONSTRAINT FK_Token_Utilisateur FOREIGN KEY (TokenUtilisateurID) REFERENCES APP_Utilisateur (UtilisateurID)
);


-- -----------------------------------------------------------------------------
--       TABLE : APP_Rdv
-- -----------------------------------------------------------------------------
GO;
CREATE TABLE APP_Rdv (
    RdvID NUMERIC(4)
    CONSTRAINT PK_Rdv PRIMARY KEY,
    Rdv_TypeRdv NUMERIC(4),
    RdvDate DATE
    CONSTRAINT NN_RdvDate NOT NULL,
    RdvHeure DATE
    CONSTRAINT NN_RdvHeure NOT NULL,
    CONSTRAINT FK_Rdv_TypeRdv FOREIGN KEY (Rdv_TypeRdv) REFERENCES APP_TypeRdv (APP_TypeRdv)
);


-- -----------------------------------------------------------------------------
--       TABLE : APP_ClientRdv
-- -----------------------------------------------------------------------------
GO;
CREATE TABLE APP_ClientRdv (
    UtilisateurID NUMERIC(4),
    RdvID NUMERIC(4),   
    CONSTRAINT PK_ClientRdv PRIMARY KEY (UtilisateurID, RdvID),
    CONSTRAINT FK_ClientRdv_UtilisateurClient FOREIGN KEY (UtilisateurID) REFERENCES APP_UtilisateurClient (UtilisateurID),
    CONSTRAINT FK_ClientRdv_Rdv FOREIGN KEY (RdvID) REFERENCES APP_Rdv (RdvID)
);


-- -----------------------------------------------------------------------------
--       TABLE : APP_CommandeUtilisateur
-- -----------------------------------------------------------------------------
GO;
CREATE TABLE APP_CommandeUtilisateur (
    UtilisateurID NUMERIC(4),
    CommandeID NUMERIC(4),   
    CONSTRAINT PK_CommandeUtilisateur PRIMARY KEY (UtilisateurID, CommandeID),
    CONSTRAINT FK_CU_Utilisateur FOREIGN KEY (UtilisateurID) REFERENCES APP_Utilisateur (UtilisateurID),
    CONSTRAINT FK_CU_Commande FOREIGN KEY (CommandeID) REFERENCES APP_Commande (CommandeID)
);

-- -----------------------------------------------------------------------------
--       TABLE : APP_LigneCommande
-- -----------------------------------------------------------------------------
GO;

CREATE TABLE APP_LigneCommande (
    CommandeID NUMERIC(4),
    ProduitID NUMERIC(4),
    LigneCommandeQuantite NUMERIC(2)
    CONSTRAINT NN_LigneCommandeQuantite NOT NULL,   
    CONSTRAINT PK_LigneCommande PRIMARY KEY (CommandeID, ProduitID),
    CONSTRAINT FK_LigneCommande_Commande FOREIGN KEY (CommandeID) REFERENCES APP_Commande (CommandeID),
    CONSTRAINT FK_LigneCommande_Produit FOREIGN KEY (ProduitID) REFERENCES APP_Produit (ProduitID)
);

-- -----------------------------------------------------------------------------
--       TABLE : APP_AdresseRdv
-- -----------------------------------------------------------------------------
GO;

CREATE TABLE APP_AdresseRdv (
    AdresseID NUMERIC(4),
    RdvID NUMERIC(4),   
    CONSTRAINT PK_AdresseRdv PRIMARY KEY (AdresseID, RdvID),
    CONSTRAINT FK_AdresseRdv_Adresse FOREIGN KEY (AdresseID) REFERENCES APP_Adresse (AdresseID),
    CONSTRAINT FK_AdresseRdv_RENDEZVOU FOREIGN KEY (RdvID) REFERENCES APP_Rdv (RdvID)
);


-- -----------------------------------------------------------------------------
--       TABLE : APP_SupportTicket
-- -----------------------------------------------------------------------------
GO;

CREATE TABLE APP_SupportTicket (
    UtilisateurID NUMERIC(4),
    TicketID NUMERIC(4),   
    CONSTRAINT PK_SupportTicket PRIMARY KEY (UtilisateurID, TicketID),
    CONSTRAINT FK_ST_UtilisateurSupport FOREIGN KEY (UtilisateurID) REFERENCES APP_UtilisateurSupport (UtilisateurID),
    CONSTRAINT FK_SupportTicket_Ticket FOREIGN KEY (TicketID) REFERENCES APP_Ticket (TicketID)
);

-- -----------------------------------------------------------------------------
--       TABLE : APP_AdminRdv
-- -----------------------------------------------------------------------------
GO;

CREATE TABLE APP_AdminRdv (
    UtilisateurID NUMERIC(4),
    RdvID NUMERIC(4),   
    CONSTRAINT PK_AdminRdv PRIMARY KEY (UtilisateurID, RdvID),
    CONSTRAINT FK_AdminRdv_UtilisateurAdmin FOREIGN KEY (UtilisateurID) REFERENCES APP_UtilisateurAdmin (UtilisateurID),
    CONSTRAINT FK_AdminRdv_Rdv FOREIGN KEY (RdvID) REFERENCES APP_Rdv (RdvID)
);

-- -----------------------------------------------------------------------------
--                FIN DE GENERATION
-- -----------------------------------------------------------------------------
