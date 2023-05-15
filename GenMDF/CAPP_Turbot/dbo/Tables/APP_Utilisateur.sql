-- -----------------------------------------------------------------------------
--       TABLE : APP_Utilisateur
-- -----------------------------------------------------------------------------

CREATE TABLE APP_Utilisateur (
    UtilisateurID NUMERIC(4) 
    CONSTRAINT PK_Utilisateur PRIMARY KEY,
    AdresseID NUMERIC(4) 
    CONSTRAINT FK_Utilisateur_Adresse REFERENCES APP_Adresse (AdresseID),
    UtilisateurNom VARCHAR(50) 
    CONSTRAINT CK_UtilisateurNom CHECK(UtilisateurNom = UPPER(UtilisateurNom)) -- #2
    CONSTRAINT NN_UtilisateurNom NOT NULL,
    UtilisateurPrenom VARCHAR(50) 
    CONSTRAINT NN_UtilisateurPrenom NOT NULL,
    UtilisateurEmail VARCHAR(130)
    CONSTRAINT CK_UtilisateurEmail CHECK(UtilisateurEmail LIKE ('%@%.%') AND UtilisateurEmail = LOWER(UtilisateurEmail)) -- #3
    CONSTRAINT NN_UtilisateurEmail NOT NULL
    CONSTRAINT UQ_UtilisateurEmail UNIQUE,
    UtilisateurSexe VARCHAR(30)
    CONSTRAINT CK_UtilisateurSexe CHECK (UtilisateurSexe LIKE 'Masculin' OR UtilisateurSexe LIKE 'Féminin' OR UtilisateurSexe LIKE 'Autre'), -- #4
    UtilisateurTel VARCHAR(17)
    CONSTRAINT CK_UtilisateurTel CHECK(UtilisateurTel LIKE('+41.__.___.__.__') OR UtilisateurTel LIKE ('+33._.__.__.__.__')), -- #5
    UtilisateurPassword VARCHAR(128) 
    CONSTRAINT NN_UtilisateurPassword NOT NULL,
    UtilisateurType VARCHAR(20) 
    CONSTRAINT NN_UtilisateurType NOT NULL
);