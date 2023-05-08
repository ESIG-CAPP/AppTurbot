-- -----------------------------------------------------------------------------
--       TABLE : APP_Produit
-- -----------------------------------------------------------------------------

CREATE TABLE APP_Produit (
    ProduitID NUMERIC(4)
    CONSTRAINT PK_Produit PRIMARY KEY,
    ProduitID_REMPLACE NUMERIC(4)  NULL,
    CategorieProduitID NUMERIC(4),
    ProduitNom VARCHAR(60)
    CONSTRAINT NN_ProduitNom NOT NULL
    CONSTRAINT UQ_ProduitNom UNIQUE,
    ProduitDescription VARCHAR(200)
    CONSTRAINT NN_ProduitDescription NOT NULL,
    ProduitPrix NUMERIC(6,2)
    CONSTRAINT NN_ProduitPrix NOT NULL
    CONSTRAINT CK_ProduitPrix CHECK (ProduitPrix > 0),
    ProduitStock NUMERIC(4)  NULL
    CONSTRAINT CK_ProduitStock CHECK (ProduitStock >= 0),
    ProduitImage VARCHAR(255)  NULL,
    CONSTRAINT FK_Produit_Produit FOREIGN KEY (ProduitID_REMPLACE) REFERENCES APP_Produit (ProduitID),
    CONSTRAINT FK_Produit_CategorieProduit FOREIGN KEY (CategorieProduitID) REFERENCES APP_CategorieProduit (CategorieProduitID)
);