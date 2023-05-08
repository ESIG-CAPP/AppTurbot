-- -----------------------------------------------------------------------------
--       TABLE : APP_AdresseRdv
-- -----------------------------------------------------------------------------

CREATE TABLE APP_AdresseRdv (
    AdresseID NUMERIC(4),
    RdvID NUMERIC(4),   
    CONSTRAINT PK_AdresseRdv PRIMARY KEY (AdresseID, RdvID),
    CONSTRAINT FK_AdresseRdv_Adresse FOREIGN KEY (AdresseID) REFERENCES APP_Adresse (AdresseID),
    CONSTRAINT FK_AdresseRdv_RENDEZVOU FOREIGN KEY (RdvID) REFERENCES APP_Rdv (RdvID)
);