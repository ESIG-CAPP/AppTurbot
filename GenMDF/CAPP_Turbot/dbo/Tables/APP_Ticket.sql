-- -----------------------------------------------------------------------------
--       TABLE : APP_Ticket
-- -----------------------------------------------------------------------------

CREATE TABLE APP_Ticket (
    TicketID NUMERIC(4)
    CONSTRAINT PK_Ticket PRIMARY KEY,
    TicketUtilisateurID NUMERIC(4),
    TicketDateCreation DATE
    CONSTRAINT NN_TicketDateCreation NOT NULL,
    TicketDateFinition DATE NULL,
    TicketStatut VARCHAR(20)
    CONSTRAINT NN_TicketStatut NOT NULL
    CONSTRAINT CK_TicketStatut CHECK (TicketStatut IN ('Ouvert', 'Fermé', 'En attente', 'Annulé')),
    CONSTRAINT CK_TicketDate CHECK (TicketDateCreation <= TicketDateFinition OR TicketDateFinition IS NULL),
    CONSTRAINT FK_Ticket_UtilisateurClient FOREIGN KEY (TicketUtilisateurID) REFERENCES APP_UtilisateurClient (UtilisateurID)
);