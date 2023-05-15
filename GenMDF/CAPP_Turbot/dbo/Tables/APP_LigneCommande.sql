-- -----------------------------------------------------------------------------
--       TABLE : APP_LigneCommande
-- -----------------------------------------------------------------------------

CREATE TABLE APP_LigneCommande (
    CommandeID NUMERIC(4),
    ProduitID NUMERIC(4),
    LigneCommandeQuantite NUMERIC(2)
    CONSTRAINT NN_LigneCommandeQuantite NOT NULL,   
    CONSTRAINT PK_LigneCommande PRIMARY KEY (CommandeID, ProduitID),
    CONSTRAINT FK_LigneCommande_Commande FOREIGN KEY (CommandeID) REFERENCES APP_Commande (CommandeID),
    CONSTRAINT FK_LigneCommande_Produit FOREIGN KEY (ProduitID) REFERENCES APP_Produit (ProduitID)
);