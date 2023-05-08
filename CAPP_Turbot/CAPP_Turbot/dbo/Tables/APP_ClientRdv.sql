-- -----------------------------------------------------------------------------
--       TABLE : APP_ClientRdv
-- -----------------------------------------------------------------------------

CREATE TABLE APP_ClientRdv (
    UtilisateurID NUMERIC(4),
    RdvID NUMERIC(4),   
    CONSTRAINT PK_ClientRdv PRIMARY KEY (UtilisateurID, RdvID),
    CONSTRAINT FK_ClientRdv_UtilisateurClient FOREIGN KEY (UtilisateurID) REFERENCES APP_UtilisateurClient (UtilisateurID),
    CONSTRAINT FK_ClientRdv_Rdv FOREIGN KEY (RdvID) REFERENCES APP_Rdv (RdvID)
);