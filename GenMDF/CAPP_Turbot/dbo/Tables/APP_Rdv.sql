-- -----------------------------------------------------------------------------
--       TABLE : APP_Rdv
-- -----------------------------------------------------------------------------

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