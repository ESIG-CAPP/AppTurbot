-- -----------------------------------------------------------------------------
--       TABLE : APP_UtilisateurClient
-- -----------------------------------------------------------------------------

CREATE TABLE APP_UtilisateurClient (
    UtilisateurID NUMERIC(4)
    CONSTRAINT PK_UtilisateurClient PRIMARY KEY,
    CONSTRAINT FK_UC_Utilisateur FOREIGN KEY (UtilisateurID) REFERENCES APP_Utilisateur (UtilisateurID)
);