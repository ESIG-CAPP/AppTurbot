-- -----------------------------------------------------------------------------
--       TABLE : APP_UtilisateurAdmin
-- -----------------------------------------------------------------------------

CREATE TABLE APP_UtilisateurAdmin (
    UtilisateurID NUMERIC(4)
    CONSTRAINT PK_UtilisateurAdmin PRIMARY KEY,
    CONSTRAINT FK_UA_Utilisateur FOREIGN KEY (UtilisateurID) REFERENCES APP_Utilisateur (UtilisateurID)
);