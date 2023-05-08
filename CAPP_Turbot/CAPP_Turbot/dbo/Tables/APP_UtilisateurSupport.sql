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