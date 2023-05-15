-- -----------------------------------------------------------------------------
--      Projet : AppTurbot
--      Auteur : Andrea, Loic
--      Date de dernière modification : 31/03/2023
-- -----------------------------------------------------------------------------

-- -----------------------------------------------------------------------------
--       TABLE : APP_Adresse
-- -----------------------------------------------------------------------------

CREATE TABLE APP_Adresse (
    AdresseID NUMERIC(4) 
    CONSTRAINT PK_Adresse PRIMARY KEY,
    AdresseRue VARCHAR(50) 
    CONSTRAINT NN_AdresseRue NOT NULL,
    AdresseCP NUMERIC(6) 
    CONSTRAINT NN_AdresseCP NOT NULL
    CONSTRAINT CK_AdresseCP CHECK (LEN(AdresseCP) BETWEEN 4 AND 5), -- #1
    AdresseVille VARCHAR(30) 
    CONSTRAINT NN_AdresseVille NOT NULL,
    AdressePays VARCHAR(20) 
    CONSTRAINT NN_AdressePays NOT NULL
);