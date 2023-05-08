-- -----------------------------------------------------------------------------
--       TABLE : APP_Message
-- -----------------------------------------------------------------------------

CREATE TABLE APP_Message (
    MessageID NUMERIC(4)
    CONSTRAINT PK_Message PRIMARY KEY,
    TicketID NUMERIC(4),
    UtilisateurID NUMERIC(4),
    MessageContenu VARCHAR(300)
    CONSTRAINT NN_MessageContenu NOT NULL,
    CONSTRAINT FK_Message_Ticket FOREIGN KEY (TicketID) REFERENCES APP_Ticket (TicketID),
    CONSTRAINT FK_Message_Utilisateur FOREIGN KEY (UtilisateurID) REFERENCES APP_Utilisateur (UtilisateurID)
);