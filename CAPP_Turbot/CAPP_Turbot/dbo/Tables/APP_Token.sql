-- -----------------------------------------------------------------------------
--       TABLE : APP_Token
-- -----------------------------------------------------------------------------

CREATE TABLE APP_Token (
    TokenID CHAR(4)
    CONSTRAINT PK_Token PRIMARY KEY,
    TokenUtilisateurID NUMERIC(4),
    TokenDateExpiration DATE
    CONSTRAINT NN_TokenDateExpiration NOT NULL
    CONSTRAINT UQ_TokenDateExpiration UNIQUE,
    TokenCode VARCHAR(255)
    CONSTRAINT NN_TokenCode NOT NULL
    CONSTRAINT UQ_TokenCode UNIQUE,
    CONSTRAINT FK_Token_Utilisateur FOREIGN KEY (TokenUtilisateurID) REFERENCES APP_Utilisateur (UtilisateurID)
);