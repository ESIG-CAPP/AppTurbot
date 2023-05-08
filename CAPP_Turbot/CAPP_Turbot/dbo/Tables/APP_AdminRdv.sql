-- -----------------------------------------------------------------------------
--       TABLE : APP_AdminRdv
-- -----------------------------------------------------------------------------

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