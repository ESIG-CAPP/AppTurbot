-- -----------------------------------------------------------------------------
--       TABLE : APP_SupportTicket
-- -----------------------------------------------------------------------------

CREATE TABLE APP_SupportTicket (
    UtilisateurID NUMERIC(4),
    TicketID NUMERIC(4),   
    CONSTRAINT PK_SupportTicket PRIMARY KEY (UtilisateurID, TicketID),
    CONSTRAINT FK_ST_UtilisateurSupport FOREIGN KEY (UtilisateurID) REFERENCES APP_UtilisateurSupport (UtilisateurID),
    CONSTRAINT FK_SupportTicket_Ticket FOREIGN KEY (TicketID) REFERENCES APP_Ticket (TicketID)
);