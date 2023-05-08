-- -----------------------------------------------------------------------------
--       TABLE : APP_TypeRdv
-- -----------------------------------------------------------------------------

CREATE TABLE APP_TypeRdv (
    APP_TypeRdv NUMERIC(4)
    CONSTRAINT PK_TypeRdv PRIMARY KEY,
    TypeRdvNom VARCHAR(30)
    CONSTRAINT NN_TypeRdvNom NOT NULL
    CONSTRAINT UQ_TypeRdvNom UNIQUE
);