-- -----------------------------------------------------------------------------
--       TABLE : APP_CategorieProduit
-- -----------------------------------------------------------------------------

CREATE TABLE APP_CategorieProduit (
    CategorieProduitID NUMERIC(4)
    CONSTRAINT PK_CategorieProduit PRIMARY KEY,
    CategorieProduitNom VARCHAR(30)
    CONSTRAINT NN_CategorieProduitNom NOT NULL
    CONSTRAINT UQ_CategorieProduitNom UNIQUE,
    CategorieProduitDescription VARCHAR(128)
    CONSTRAINT NN_CategorieProduitDescription NOT NULL
    CONSTRAINT CK_CategorieProduitDescription CHECK (LEN(CategorieProduitDescription) <= 128),
    CategorieProduitImage VARCHAR(255) NULL
);