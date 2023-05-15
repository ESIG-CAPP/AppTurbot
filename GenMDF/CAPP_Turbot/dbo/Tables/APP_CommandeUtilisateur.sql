-- -----------------------------------------------------------------------------
--       TABLE : APP_CommandeUtilisateur
-- -----------------------------------------------------------------------------

CREATE TABLE APP_CommandeUtilisateur (
    UtilisateurID NUMERIC(4),
    CommandeID NUMERIC(4),   
    CONSTRAINT PK_CommandeUtilisateur PRIMARY KEY (UtilisateurID, CommandeID),
    CONSTRAINT FK_CU_Utilisateur FOREIGN KEY (UtilisateurID) REFERENCES APP_Utilisateur (UtilisateurID),
    CONSTRAINT FK_CU_Commande FOREIGN KEY (CommandeID) REFERENCES APP_Commande (CommandeID)
);