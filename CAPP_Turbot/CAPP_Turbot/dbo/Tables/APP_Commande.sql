-- -----------------------------------------------------------------------------
--       TABLE : APP_Commande
-- -----------------------------------------------------------------------------

CREATE TABLE APP_Commande (
    CommandeID NUMERIC(4)  
    CONSTRAINT PK_Commande PRIMARY KEY,
    CommandeDate DATE
    CONSTRAINT NN_CommandeDate NOT NULL,
    CommandeEtat VARCHAR(30)
    CONSTRAINT NN_CommandeEtat NOT NULL
    CONSTRAINT CK_CommandeEtat CHECK (CommandeEtat IN ('en attente', 'en cours de traitement', 'terminée')),
    CommandeMethodePaiement VARCHAR(30)
    CONSTRAINT NN_CommandeMethodePaiement NOT NULL,
    CommandeDateLimitePaiement DATE
    CONSTRAINT NN_CommandeDateLimitePaiement NOT NULL
);