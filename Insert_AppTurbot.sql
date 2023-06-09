insert into APP_TYPERDV (app_typerdv, typerdvnom)
values (1, 'Dépannage matériel');
insert into APP_TYPERDV (app_typerdv, typerdvnom)
values (2, 'Installation logiciel');
insert into APP_TYPERDV (app_typerdv, typerdvnom)
values (3, 'Maintenance préventive');
insert into APP_TYPERDV (app_typerdv, typerdvnom)
values (4, 'Assistance technique');
insert into APP_TYPERDV (app_typerdv, typerdvnom)
values (5, 'Formation utilisateur');
insert into APP_TYPERDV (app_typerdv, typerdvnom)
values (6, 'Migration système');
insert into APP_TYPERDV (app_typerdv, typerdvnom)
values (7, 'Développement application');
insert into APP_TYPERDV (app_typerdv, typerdvnom)
values (8, 'Sécurité informatique');
insert into APP_TYPERDV (app_typerdv, typerdvnom)
values (9, 'Analyse de données');
insert into APP_TYPERDV (app_typerdv, typerdvnom)
values (10, 'Virtualisation de serveurs');
GO
insert into APP_RDV (rdvid, rdv_typerdv, rdvdate, rdvheure)
values (1, 10, CONVERT(DATE,'23-03-2023', 104), CONVERT(DATETIME,'01-05-2023 14:30:00', 104));
insert into APP_RDV (rdvid, rdv_typerdv, rdvdate, rdvheure)
values (2, 9, CONVERT(DATE,'25-03-2023', 104), CONVERT(DATETIME,'01-05-2023 11:00:00', 104));
insert into APP_RDV (rdvid, rdv_typerdv, rdvdate, rdvheure)
values (3, 8, CONVERT(DATE,'02-04-2023', 104), CONVERT(DATETIME,'01-05-2023 16:15:00', 104));
insert into APP_RDV (rdvid, rdv_typerdv, rdvdate, rdvheure)
values (4, 7, CONVERT(DATE,'05-04-2023', 104), CONVERT(DATETIME,'01-05-2023 09:30:00', 104));
insert into APP_RDV (rdvid, rdv_typerdv, rdvdate, rdvheure)
values (5, 6, CONVERT(DATE,'08-04-2023', 104), CONVERT(DATETIME,'01-05-2023 14:00:00', 104));
insert into APP_RDV (rdvid, rdv_typerdv, rdvdate, rdvheure)
values (6, 5, CONVERT(DATE,'12-04-2023', 104), CONVERT(DATETIME,'01-05-2023 10:45:00', 104));
insert into APP_RDV (rdvid, rdv_typerdv, rdvdate, rdvheure)
values (7, 4, CONVERT(DATE,'20-04-2023', 104), CONVERT(DATETIME,'01-05-2023 15:30:00', 104));
insert into APP_RDV (rdvid, rdv_typerdv, rdvdate, rdvheure)
values (8, 3, CONVERT(DATE,'27-04-2023', 104), CONVERT(DATETIME,'01-05-2023 11:00:00', 104));
insert into APP_RDV (rdvid, rdv_typerdv, rdvdate, rdvheure)
values (9, 2, CONVERT(DATE,'05-05-2023', 104), CONVERT(DATETIME,'01-05-2023 14:45:00', 104));
insert into APP_RDV (rdvid, rdv_typerdv, rdvdate, rdvheure)
values (10, 1, CONVERT(DATE,'10-05-2023', 104), CONVERT(DATETIME,'01-05-2023 10:00:00', 104));
GO
insert into APP_ADRESSE (adresseid, adresserue, adressecp, adresseville, adressepays)
values (1, '14 Rue de la Fontaine', 59000, 'Lille', 'France');
insert into APP_ADRESSE (adresseid, adresserue, adressecp, adresseville, adressepays)
values (2, '8 Rue du Simplon', 1006, 'Lausanne', 'Suisse');
insert into APP_ADRESSE (adresseid, adresserue, adressecp, adresseville, adressepays)
values (3, '18 Rue de la Servette', 1201, 'Genève', 'Suisse');
insert into APP_ADRESSE (adresseid, adresserue, adressecp, adresseville, adressepays)
values (4, '7 Rue des Alpes', 1201, 'Genève', 'Suisse');
insert into APP_ADRESSE (adresseid, adresserue, adressecp, adresseville, adressepays)
values (5, '12 Avenue de la Gare', 1003, 'Lausanne', 'Suisse');
insert into APP_ADRESSE (adresseid, adresserue, adressecp, adresseville, adressepays)
values (6, '3 Rue du Valais', 1202, 'Genève', 'Suisse');
insert into APP_ADRESSE (adresseid, adresserue, adressecp, adresseville, adressepays)
values (7, '25 Rue de la Victoire', 75009, 'Paris', 'France');
insert into APP_ADRESSE (adresseid, adresserue, adressecp, adresseville, adressepays)
values (8, '17 Avenue des Gobelins', 75005, 'Paris', 'France');
insert into APP_ADRESSE (adresseid, adresserue, adressecp, adresseville, adressepays)
values (9, '10 Rue de la Poste', 6000, 'Nice', 'France');
insert into APP_ADRESSE (adresseid, adresserue, adressecp, adresseville, adressepays)
values (10, '2 Rue de la Bourse', 69002, 'Lyon', 'France');
insert into APP_ADRESSE (adresseid, adresserue, adressecp, adresseville, adressepays)
values (11, '5 Rue du Lac', 1207, 'Genève', 'Suisse');
insert into APP_ADRESSE (adresseid, adresserue, adressecp, adresseville, adressepays)
values (12, '10 Rue de la Paix', 75001, 'Paris', 'France');
insert into APP_ADRESSE (adresseid, adresserue, adressecp, adresseville, adressepays)
values (13, '7 Rue du Faubourg Saint-Honoré', 75008, 'Paris', 'France');
insert into APP_ADRESSE (adresseid, adresserue, adressecp, adresseville, adressepays)
values (14, '20 Avenue des Champs-élysées', 75008, 'Paris', 'France');
insert into APP_ADRESSE (adresseid, adresserue, adressecp, adresseville, adressepays)
values (15, '12 Rue des Lombards', 75004, 'Paris', 'France');
insert into APP_ADRESSE (adresseid, adresserue, adressecp, adresseville, adressepays)
values (16, '1 Rue de la République', 69001, 'Lyon', 'France');
insert into APP_ADRESSE (adresseid, adresserue, adressecp, adresseville, adressepays)
values (17, '25 Quai des Bergues', 1201, 'Genève', 'Suisse');
insert into APP_ADRESSE (adresseid, adresserue, adressecp, adresseville, adressepays)
values (18, '15 Rue de Lausanne', 1201, 'Genève', 'Suisse');
insert into APP_ADRESSE (adresseid, adresserue, adressecp, adresseville, adressepays)
values (19, '10 Rue du Mont-Blanc', 1201, 'Genève', 'Suisse');
insert into APP_ADRESSE (adresseid, adresserue, adressecp, adresseville, adressepays)
values (20, '5 Rue du Rhône', 1204, 'Genève', 'Suisse');
insert into APP_ADRESSE (adresseid, adresserue, adressecp, adresseville, adressepays)
values (21, '3 Rue du Marché', 1003, 'Lausanne', 'Suisse');
GO
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (1, 1, 'ROUSSEL', 'Romeo', 'romeo.roussel@gmail.com', 'Masculin', '+41.78.567.89.02', 'password123', 'admin');
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (2, 1, 'ROUSSEL', 'Léa', 'lea.roussel@gmail.com', 'Féminin', '+41.78.567.89.01', 'password123', 'admin');
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (3, 2, 'LEFEBVRE', 'Alexandre', 'alexandre.lefebvre@gmail.com', 'Masculin', '+41.78.678.90.12', 'password123', 'admin');
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (4, 3, 'CARPENTIER', 'Manon', 'manon.carpentier@gmail.com', 'Féminin', '+41.78.789.01.23', 'password123', 'admin');
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (5, 4, 'DUBOIS', 'Julien', 'julien.dubois@gmail.com', 'Masculin', '+41.78.901.23.45', 'password123', 'admin');
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (6, 5, 'MICHAUD', 'Léna', 'lena.michaud@gmail.com', 'Féminin', '+41.78.012.34.56', 'password123', 'admin');
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (7, 6, 'GAUTHIER', 'Théo', 'theo.gauthier@gmail.com', 'Masculin', '+41.78.123.45.67', 'password123', 'admin');
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (8, 7, 'MOREAU', 'Noémie', 'noemie.moreau@gmail.com', 'Féminin', '+41.78.234.56.78', 'password123', 'admin');
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (9, 8, 'DURAND', 'Julie', 'julie.durand@gmail.com', 'Féminin', '+41.78.901.23.45', 'password123', 'support');
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (10, 9, 'LEROY', 'Pierre', 'pierre.leroy@gmail.com', 'Masculin', '+41.78.012.34.56', 'password123', 'support');
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (11, 10, 'GIRARD', 'Thomas', 'thomas.girard@gmail.com', 'Masculin', '+41.78.123.45.67', 'password123', 'support');
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (12, 11, 'FOURNIER', 'Emilie', 'emilie.fournier@gmail.com', 'Féminin', '+41.78.234.56.78', 'password123', 'support');
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (13, 12, 'DUPONT', 'Jean', 'jean.dupont@gmail.com', 'Masculin', '+41.78.123.45.67', 'motdepasse123', 'admin');
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (14, 21, 'DOE', 'John', 'john.doe@gmail.com', 'Masculin', '+41.78.234.56.78', 'password123', 'client');
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (15, 21, 'DOE', 'Jasmine', 'jasmine.doe@gmail.com', 'Féminin', '+41.78.234.56.79', 'password123', 'client');
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (16, 20, 'SMITH', 'Emma', 'emma.smith@gmail.com', 'Féminin', '+41.78.345.67.89', 'securepassword', 'support');
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (17, 20, 'SMITH', 'Chopper', 'chopper.smith@gmail.com', 'Masculin', '+41.78.345.67.90', 'securepassword', 'support');
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (18, 15, 'MARTIN', 'Lucie', 'lucie.martin@gmail.com', 'Féminin', '+41.78.456.78.90', 'mdp1234', 'client');
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (19, 15, 'MARTIN', 'Lucas', 'lucas.martin@gmail.com', 'Masculin', '+41.78.456.78.91', 'mdp1234', 'client');
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (20, 17, 'GARCIA', 'Maria', 'maria.garcia@gmail.com', 'Féminin', '+41.78.567.89.01', 'motdepasse456', 'client');
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (21, 17, 'GARCIA', 'Pierrot', 'pierrot.garcia@gmail.com', 'Masculin', '+41.78.567.89.02', 'motdepasse456', 'client');
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (22, 16, 'LOPEZ', 'Juan', 'juan.lopez@gmail.com', 'Masculin', '+41.78.678.90.12', 'azerty123', 'admin');
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (23, 18, 'LEE', 'Hyejin', 'hyejin.lee@gmail.com', 'Féminin', '+41.78.789.01.23', 'password1234', 'support');
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (24, 18, 'LEE', 'Sanji', 'sanji.lee@gmail.com', 'Masculin', '+41.78.789.01.24', 'password1234', 'support');
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (25, 19, 'MÜLLER', 'Hans', 'hans.mueller@gmail.com', 'Masculin', '+41.78.890.12.34', 'motdepasse789', 'support');
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (26, 19, 'MÜLLER', 'Usop', 'usop.mueller@gmail.com', 'Masculin', '+41.78.890.12.35', 'motdepasse789', 'support');
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (27, 14, 'KIM', 'Minsoo', 'minsoo.kim@gmail.com', 'Masculin', '+41.78.901.23.45', 'securepassword123', 'client');
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (28, 14, 'KIM', 'Minsaa', 'minsaa.kim@gmail.com', 'Féminin', '+41.78.901.23.46', 'securepassword123', 'client');
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (29, 13, 'LUFFY', 'Zoro', 'zoro.luffy@gmail.com', 'Masculin', '+41.79.905.24.90', 'securemotdepasse', 'client');
insert into APP_UTILISATEUR (utilisateurid, adresseid, utilisateurnom, utilisateurprenom, utilisateuremail, utilisateursexe, utilisateurtel, utilisateurpassword, utilisateurtype)
values (30, 13, 'LUFFY', 'Nami', 'nami.luffy@gmail.com', 'Féminin', '+41.79.905.24.91', 'securemotdepasse', 'client');
GO
insert into APP_UTILISATEURADMIN (utilisateurid)
values (1);
insert into APP_UTILISATEURADMIN (utilisateurid)
values (2);
insert into APP_UTILISATEURADMIN (utilisateurid)
values (3);
insert into APP_UTILISATEURADMIN (utilisateurid)
values (4);
insert into APP_UTILISATEURADMIN (utilisateurid)
values (5);
insert into APP_UTILISATEURADMIN (utilisateurid)
values (6);
insert into APP_UTILISATEURADMIN (utilisateurid)
values (7);
insert into APP_UTILISATEURADMIN (utilisateurid)
values (8);
insert into APP_UTILISATEURADMIN (utilisateurid)
values (13);
insert into APP_UTILISATEURADMIN (utilisateurid)
values (22);
GO
insert into APP_ADMINRDV (utilisateurid, rdvid)
values (1, 1);
insert into APP_ADMINRDV (utilisateurid, rdvid)
values (2, 2);
insert into APP_ADMINRDV (utilisateurid, rdvid)
values (3, 3);
insert into APP_ADMINRDV (utilisateurid, rdvid)
values (4, 4);
insert into APP_ADMINRDV (utilisateurid, rdvid)
values (5, 5);
insert into APP_ADMINRDV (utilisateurid, rdvid)
values (6, 6);
insert into APP_ADMINRDV (utilisateurid, rdvid)
values (7, 7);
insert into APP_ADMINRDV (utilisateurid, rdvid)
values (8, 8);
insert into APP_ADMINRDV (utilisateurid, rdvid)
values (13, 9);
insert into APP_ADMINRDV (utilisateurid, rdvid)
values (22, 10);
GO
insert into APP_ADRESSERDV (adresseid, rdvid)
values (12, 1);
insert into APP_ADRESSERDV (adresseid, rdvid)
values (12, 2);
insert into APP_ADRESSERDV (adresseid, rdvid)
values (13, 9);
insert into APP_ADRESSERDV (adresseid, rdvid)
values (13, 10);
insert into APP_ADRESSERDV (adresseid, rdvid)
values (15, 3);
insert into APP_ADRESSERDV (adresseid, rdvid)
values (19, 4);
insert into APP_ADRESSERDV (adresseid, rdvid)
values (19, 5);
insert into APP_ADRESSERDV (adresseid, rdvid)
values (19, 6);
insert into APP_ADRESSERDV (adresseid, rdvid)
values (21, 7);
insert into APP_ADRESSERDV (adresseid, rdvid)
values (21, 8);
GO
insert into APP_CATEGORIEPRODUIT (categorieproduitid, categorieproduitnom, categorieproduitdescription, categorieproduitimage)
values (1, 'Ordinateurs portables', 'Catégorie pour les ordinateurs portables', null);
insert into APP_CATEGORIEPRODUIT (categorieproduitid, categorieproduitnom, categorieproduitdescription, categorieproduitimage)
values (2, 'PC de bureau', 'Catégorie pour les ordinateurs de bureau', null);
insert into APP_CATEGORIEPRODUIT (categorieproduitid, categorieproduitnom, categorieproduitdescription, categorieproduitimage)
values (3, 'Périphériques', 'Catégorie pour les périphériques informatiques', null);
insert into APP_CATEGORIEPRODUIT (categorieproduitid, categorieproduitnom, categorieproduitdescription, categorieproduitimage)
values (4, 'Composants', 'Catégorie pour les composants informatiques', null);
insert into APP_CATEGORIEPRODUIT (categorieproduitid, categorieproduitnom, categorieproduitdescription, categorieproduitimage)
values (5, 'Réseau', 'Catégorie pour les équipements de réseau', null);
insert into APP_CATEGORIEPRODUIT (categorieproduitid, categorieproduitnom, categorieproduitdescription, categorieproduitimage)
values (6, 'Logiciels', 'Catégorie pour les logiciels informatiques', null);
insert into APP_CATEGORIEPRODUIT (categorieproduitid, categorieproduitnom, categorieproduitdescription, categorieproduitimage)
values (7, 'Stockage', 'Catégorie pour les périphériques de stockage informatiques', null);
insert into APP_CATEGORIEPRODUIT (categorieproduitid, categorieproduitnom, categorieproduitdescription, categorieproduitimage)
values (8, 'Sécurité', 'Catégorie pour les logiciels et équipements de sécurité informatique', null);
insert into APP_CATEGORIEPRODUIT (categorieproduitid, categorieproduitnom, categorieproduitdescription, categorieproduitimage)
values (9, 'Impression', 'Catégorie pour les équipements impression informatique', null);
insert into APP_CATEGORIEPRODUIT (categorieproduitid, categorieproduitnom, categorieproduitdescription, categorieproduitimage)
values (10, 'Accessoires', 'Catégorie pour les accessoires informatiques tels que les câbles et les adaptateurs', null);
GO
insert into APP_UTILISATEURCLIENT (utilisateurid)
values (14);
insert into APP_UTILISATEURCLIENT (utilisateurid)
values (15);
insert into APP_UTILISATEURCLIENT (utilisateurid)
values (18);
insert into APP_UTILISATEURCLIENT (utilisateurid)
values (19);
insert into APP_UTILISATEURCLIENT (utilisateurid)
values (20);
insert into APP_UTILISATEURCLIENT (utilisateurid)
values (21);
insert into APP_UTILISATEURCLIENT (utilisateurid)
values (27);
insert into APP_UTILISATEURCLIENT (utilisateurid)
values (28);
insert into APP_UTILISATEURCLIENT (utilisateurid)
values (29);
insert into APP_UTILISATEURCLIENT (utilisateurid)
values (30);
GO
insert into APP_CLIENTRDV (utilisateurid, rdvid)
values (14, 1);
insert into APP_CLIENTRDV (utilisateurid, rdvid)
values (15, 2);
insert into APP_CLIENTRDV (utilisateurid, rdvid)
values (18, 3);
insert into APP_CLIENTRDV (utilisateurid, rdvid)
values (19, 4);
insert into APP_CLIENTRDV (utilisateurid, rdvid)
values (20, 5);
insert into APP_CLIENTRDV (utilisateurid, rdvid)
values (21, 6);
insert into APP_CLIENTRDV (utilisateurid, rdvid)
values (27, 7);
insert into APP_CLIENTRDV (utilisateurid, rdvid)
values (28, 8);
insert into APP_CLIENTRDV (utilisateurid, rdvid)
values (29, 9);
insert into APP_CLIENTRDV (utilisateurid, rdvid)
values (30, 10);
GO
insert into APP_COMMANDE (commandeid, commandedate, commandeetat, commandemethodepaiement, commandedatelimitepaiement)
values (1, CONVERT(DATE,'01-01-2022', 104), 'en attente', 'carte de crédit', CONVERT(DATE,'10-01-2022', 104));
insert into APP_COMMANDE (commandeid, commandedate, commandeetat, commandemethodepaiement, commandedatelimitepaiement)
values (2, CONVERT(DATE,'02-01-2022', 104), 'en cours de traitement', 'virement bancaire', CONVERT(DATE,'12-01-2022', 104));
insert into APP_COMMANDE (commandeid, commandedate, commandeetat, commandemethodepaiement, commandedatelimitepaiement)
values (3, CONVERT(DATE,'03-01-2022', 104), 'terminée', 'Paypal', CONVERT(DATE,'13-01-2022', 104));
insert into APP_COMMANDE (commandeid, commandedate, commandeetat, commandemethodepaiement, commandedatelimitepaiement)
values (4, CONVERT(DATE,'04-01-2022', 104), 'en attente', 'chèque', CONVERT(DATE,'14-01-2022', 104));
insert into APP_COMMANDE (commandeid, commandedate, commandeetat, commandemethodepaiement, commandedatelimitepaiement)
values (5, CONVERT(DATE,'22-03-2023', 104), 'en attente', 'carte de crédit', CONVERT(DATE,'29-03-2023', 104));
insert into APP_COMMANDE (commandeid, commandedate, commandeetat, commandemethodepaiement, commandedatelimitepaiement)
values (6, CONVERT(DATE,'21-03-2023', 104), 'en cours de traitement', 'virement bancaire', CONVERT(DATE,'27-03-2023', 104));
insert into APP_COMMANDE (commandeid, commandedate, commandeetat, commandemethodepaiement, commandedatelimitepaiement)
values (7, CONVERT(DATE,'20-03-2023', 104), 'terminée', 'Paypal', CONVERT(DATE,'26-03-2023', 104));
insert into APP_COMMANDE (commandeid, commandedate, commandeetat, commandemethodepaiement, commandedatelimitepaiement)
values (8, CONVERT(DATE,'19-03-2023', 104), 'en attente', 'chèque', CONVERT(DATE,'25-03-2023', 104));
insert into APP_COMMANDE (commandeid, commandedate, commandeetat, commandemethodepaiement, commandedatelimitepaiement)
values (9, CONVERT(DATE,'18-03-2023', 104), 'en attente', 'carte de crédit', CONVERT(DATE,'24-03-2023', 104));
insert into APP_COMMANDE (commandeid, commandedate, commandeetat, commandemethodepaiement, commandedatelimitepaiement)
values (10, CONVERT(DATE,'17-03-2023', 104), 'en cours de traitement', 'virement bancaire', CONVERT(DATE,'23-03-2023', 104));
GO
insert into APP_COMMANDEUTILISATEUR (utilisateurid, commandeid)
values (14, 1);
insert into APP_COMMANDEUTILISATEUR (utilisateurid, commandeid)
values (15, 2);
insert into APP_COMMANDEUTILISATEUR (utilisateurid, commandeid)
values (18, 3);
insert into APP_COMMANDEUTILISATEUR (utilisateurid, commandeid)
values (19, 4);
insert into APP_COMMANDEUTILISATEUR (utilisateurid, commandeid)
values (20, 5);
insert into APP_COMMANDEUTILISATEUR (utilisateurid, commandeid)
values (21, 6);
insert into APP_COMMANDEUTILISATEUR (utilisateurid, commandeid)
values (27, 7);
insert into APP_COMMANDEUTILISATEUR (utilisateurid, commandeid)
values (28, 8);
insert into APP_COMMANDEUTILISATEUR (utilisateurid, commandeid)
values (29, 9);
insert into APP_COMMANDEUTILISATEUR (utilisateurid, commandeid)
values (30, 10);
GO
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (60, null, 8, 'Détecteur de fumée intelligent', 'Détecteur de fumée intelligent pour une détection rapide et une alerte en cas d''incendie', 49.99, 20, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (61, null, 8, 'Alarme anti-intrusion', 'Alarme anti-intrusion pour une sécurité renforcée', 79.99, 15, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (62, null, 8, 'Cadenas intelligent', 'Cadenas intelligent pour un accès contrôlé à votre propriété', 39.99, 25, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (63, null, 8, 'Kit de surveillance sans fil', 'Kit de surveillance sans fil pour une surveillance facile de votre maison ou bureau', 249.99, 6, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (64, null, 8, 'Détecteur de mouvement', 'Détecteur de mouvement pour une détection rapide des mouvements non autorisés', 29.99, 30, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (65, null, 9, 'Imprimante Laser', 'Imprimante laser monochrome, rapide et efficace pour les documents de bureau', 249.99, 10, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (66, null, 9, 'Imprimante Jet d''Encre', 'Imprimante jet d''encre couleur, idéale pour les photos et les documents à faible volume', 89.99, 15, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (67, null, 9, 'Papier d''impression', 'Papier d''impression A4 de haute qualité pour des impressions nettes et précises', 14.99, 100, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (68, null, 9, 'Toner laser', 'Toner de rechange pour imprimante laser monochrome', 49.99, 25, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (69, null, 9, 'Cartouche d''encre', 'Cartouche d''encre de rechange pour imprimante jet d''encre couleur', 24.99, 20, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (70, null, 9, 'Scanner de bureau', 'Scanner de bureau compact et facile à utiliser pour numériser des documents', 129.99, 5, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (71, null, 9, 'Papier photo', 'Papier photo de haute qualité pour des impressions de photos éclatantes et durables', 19.99, 50, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (72, null, 9, 'Imprimante multifonction', 'Imprimante multifonction 3 en 1 pour imprimer, numériser et copier', 179.99, 8, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (73, null, 9, 'Tambour d''imprimante', 'Tambour de rechange pour imprimante laser monochrome', 79.99, 15, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (74, null, 10, 'Câble HDMI 1m', 'Câble HDMI haute vitesse compatible 4K pour connecter votre ordinateur à votre TV', 12.99, 50, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (75, null, 10, 'Adaptateur USB-C vers HDMI', 'Adaptateur pour connecter un ordinateur portable ou un téléphone avec un port USB-C à un écran avec un port HDMI', 19.99, 25, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (76, null, 10, 'Câble Ethernet Cat 6', 'Câble Ethernet de 3 mètres pour une connexion Internet rapide et fiable', 9.99, 100, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (77, null, 10, 'Adaptateur USB-C vers Ethernet', 'Adaptateur pour connecter un ordinateur portable ou un téléphone avec un port USB-C à un réseau Ethernet', 14.99, 50, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (78, null, 10, 'Câble USB 2.0 vers Micro-USB', 'Câble de 1 mètre pour charger et synchroniser des téléphones et des tablettes Android', 6.99, 75, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (79, null, 10, 'Câble USB 2.0 vers USB-C', 'Câble de 1 mètre pour charger et synchroniser des téléphones et des tablettes avec un port USB-C', 7.99, 50, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (80, null, 10, 'Adaptateur USB 3.0 vers USB-C', 'Adaptateur pour connecter des périphériques avec un port USB-C à un ordinateur avec un port USB 3.0', 9.99, 50, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (81, null, 10, 'Câble d''alimentation pour ordinateur portable', 'Câble de remplacement pour les adaptateurs d''alimentation des ordinateurs portables', 12.99, 50, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (1, null, 1, 'MacBook Pro', 'Ordinateur portable Apple haut de gamme', 2499, 25, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (2, null, 1, 'Dell XPS 13', 'Ordinateur portable Dell compact et performant', 1599, 50, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (3, null, 1, 'HP Spectre x360', 'Ordinateur portable HP convertible et élégant', 1699, 30, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (4, null, 1, 'ASUS ZenBook UX425', 'Ordinateur portable ASUS ultraléger et autonome', 1299, 40, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (5, null, 1, 'Lenovo ThinkPad X1 Carbon', 'Ordinateur portable Lenovo robuste et puissant', 1999, 20, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (6, null, 1, 'Acer Predator Helios 300', 'Ordinateur portable Acer gaming performant', 1799, 15, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (7, null, 1, 'Microsoft Surface Laptop 4', 'Ordinateur portable Microsoft élégant et polyvalent', 1499, 35, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (8, null, 1, 'Razer Blade 15', 'Ordinateur portable de gaming haut de gamme', 2399, 5, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (9, null, 1, 'LG Gram 17', 'Ordinateur portable ultraléger avec grand écran', 1899, 20, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (10, null, 1, 'MSI GS66 Stealth', 'Ordinateur portable haut de gamme pour les gamers', 2099, 10, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (11, null, 2, 'HP Pavilion 590-p0056nf', 'Un PC de bureau polyvalent avec processeur Intel Core i5, 8 Go de RAM et 1 To de stockage HDD.', 699.99, 10, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (12, null, 2, 'Dell Optiplex 3080', 'Un PC de bureau compact et performant avec processeur Intel Core i3, 4 Go de RAM et 128 Go de stockage SSD.', 499.99, 5, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (13, null, 2, 'Lenovo ThinkCentre M75q', 'Un mini PC de bureau avec processeur AMD Ryzen 5, 8 Go de RAM et 256 Go de stockage SSD.', 799.99, 8, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (14, null, 2, 'HP EliteDesk 800 G5', 'Un PC de bureau professionnel avec processeur Intel Core i7, 16 Go de RAM et 512 Go de stockage SSD.', 1299.99, 3, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (15, null, 2, 'Acer Aspire TC-390', 'Un PC de bureau familial avec processeur AMD Ryzen 3, 8 Go de RAM et 1 To de stockage HDD.', 599.99, 12, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (16, null, 2, 'Apple iMac 24 pouces', 'Un PC de bureau tout-en-un avec processeur M1, 8 Go de RAM et 256 Go de stockage SSD.', 1499.99, 6, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (17, null, 2, 'MSI Trident 3 10SI-014EU', 'Un mini PC de bureau gaming avec processeur Intel Core i5, 8 Go de RAM et 512 Go de stockage SSD.', 899.99, 4, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (18, null, 3, 'Souris sans fil Logitech MX Master 3', 'Une souris ergonomique et précise avec une connexion sans fil avancée.', 89.99, 50, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (19, null, 3, 'Clavier mécanique Corsair K95 RGB Platinum XT', 'Un clavier mécanique haut de gamme avec éclairage RGB personnalisable.', 199.99, 25, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (20, null, 3, 'Casque audio sans fil Bose QuietComfort 35 II', 'Un casque audio sans fil avec réduction de bruit active pour une expérience sonore immersive.', 349.99, 10, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (21, null, 3, 'Webcam Logitech C920s HD Pro', 'Une webcam HD avec autofocus et correction automatique de l''éclairage pour des appels vidéo clairs et nets.', 99.99, 20, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (22, null, 3, 'Enceinte Bluetooth JBL Flip 5', 'Une enceinte portable Bluetooth avec un son puissant et une autonomie de batterie de 12 heures.', 129.99, 30, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (23, null, 3, 'Disque dur externe WD Elements', 'Un disque dur externe avec une grande capacité de stockage et une connectivité USB 3.0 rapide.', 99.99, 15, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (24, null, 3, 'Imprimante HP Color LaserJet Pro MFP M477fdw', 'Une imprimante multifonction avec impression couleur, numérisation, copie et fax.', 499.99, 5, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (25, null, 3, 'Scanner de documents Epson WorkForce ES-500W', 'Un scanner de documents sans fil avec numérisation recto verso automatique.', 399.99, 8, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (26, null, 4, 'Carte mère MSI MPG B550 GAMING EDGE WIFI', 'Carte mère ATX pour processeurs AMD, supporte la DDR4, avec connexion Wi-Fi intégrée', 179.99, 10, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (27, null, 4, 'Processeur Intel Core i9-11900K', 'Processeur pour socket LGA1200, avec 8 cœurs et 16 threads, fréquence de base de 3.5 GHz et fréquence turbo de 5.3 GHz', 539.99, 5, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (28, null, 4, 'Carte graphique NVIDIA GeForce RTX 3080', 'Carte graphique avec 10 240 cœurs CUDA, 10 Go de mémoire GDDR6X, et des sorties HDMI 2.1 et DisplayPort 1.4a', 1199.99, 3, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (29, null, 4, 'Barrette de mémoire Corsair Vengeance RGB Pro 32 Go', 'Kit de deux barrettes de mémoire DDR4 de 16 Go chacune, avec une fréquence de 3200 MHz et un éclairage RGB personnalisable', 219.99, 8, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (30, null, 4, 'SSD Samsung 970 EVO Plus 1 To', 'Disque SSD NVMe avec une capacité de 1 To, des vitesses de lecture/écriture séquentielles de jusqu''à 3 500/3 300 Mo/s, et une endurance de 600 TBW', 199.99, 12, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (31, null, 4, 'Ventilateur CPU Noctua NH-D15 chromax.black', 'Ventilateur double-tour pour CPU avec six caloducs en cuivre, deux ventilateurs NF-A15 PWM, et une compatibilité avec les sockets Intel et AMD', 99.99, 6, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (32, null, 5, 'Routeur sans fil TP-Link Archer C4000', 'Routeur Wi-Fi tri-bande avec une vitesse combinée allant jusqu’à 4 Gbit/s', 179.99, 10, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (33, null, 5, 'Switch Gigabit Ethernet NETGEAR GS308', 'Switch Gigabit Ethernet 8 ports avec une capacité de commutation de 16 Gbit/s', 24.99, 20, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (34, null, 5, 'Point d’accès Wi-Fi Ubiquiti UniFi UAP-AC-PRO', 'Point d’accès Wi-Fi double bande avec une vitesse combinée de 1750 Mbit/s et une portée de 122 mètres', 149.99, 5, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (35, null, 5, 'Répéteur Wi-Fi TP-Link RE650', 'Répéteur Wi-Fi double bande avec une vitesse combinée de 2600 Mbit/s et une portée de 14 000 pieds carrés', 109.99, 15, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (36, null, 5, 'Adaptateur CPL Devolo Magic 2 LAN triple', 'Adaptateur CPL triple avec une vitesse de transmission allant jusqu’à 2400 Mbit/s et une prise de courant intégrée', 119.99, 8, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (37, null, 5, 'Carte réseau Ethernet Intel X550-T2', 'Carte réseau Ethernet 10 Gbit/s avec deux ports et prise en charge de la virtualisation réseau', 449.99, 3, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (38, null, 5, 'Modem câble DOCSIS 3.1 ARRIS SURFboard SB8200', 'Modem câble avec une vitesse de téléchargement allant jusqu’à 10 Gbit/s et une prise en charge de l''IPv6', 199.99, 12, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (39, null, 5, 'Antenne extérieure TP-Link CPE510', 'Antenne extérieure Wi-Fi 5 GHz avec une portée de 15 km et une vitesse de transmission allant jusqu''à 300 Mbit/s', 69.99, 6, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (40, null, 6, 'Microsoft Office', 'Suite bureautique professionnelle', 199.99, 50, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (41, null, 6, 'Adobe Creative Suite', 'Suite de création graphique professionnelle', 799.99, 20, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (42, null, 6, 'Autodesk AutoCAD', 'Logiciel de CAO 2D/3D', 1299.99, 10, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (43, null, 6, 'Adobe Acrobat Pro', 'Logiciel de création et de modification de PDF', 299.99, 30, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (44, null, 6, 'VMware Workstation Pro', 'Logiciel de virtualisation de postes de travail', 299.99, 15, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (45, null, 6, 'Microsoft Visual Studio', 'Environnement de développement intégré pour développeurs', 899.99, 10, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (46, null, 6, 'Oracle Database', 'Système de gestion de base de données relationnelles', 4999.99, 5, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (47, null, 6, 'Symantec Endpoint Protection', 'Solution de sécurité pour les entreprises', 149.99, 100, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (48, null, 6, 'CorelDRAW Graphics Suite', 'Logiciel de création graphique et de mise en page', 499.99, 25, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (49, null, 6, 'IBM SPSS Statistics', 'Logiciel d''analyse statistique et de data mining', 2499.99, 5, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (50, null, 7, 'Disque dur externe 1 To', 'Disque dur externe USB 3.0 1 To de capacité', 69.99, 50, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (51, null, 7, 'Disque dur externe 2 To', 'Disque dur externe USB 3.0 2 To de capacité', 99.99, 30, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (52, null, 7, 'Disque dur interne 500 Go', 'Disque dur interne SATA 500 Go de capacité', 49.99, 20, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (53, null, 7, 'Disque dur interne 1 To', 'Disque dur interne SATA 1 To de capacité', 79.99, 15, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (54, null, 7, 'Carte mémoire SD 32 Go', 'Carte mémoire SDXC 32 Go de capacité', 19.99, 100, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (55, null, 7, 'Carte mémoire SD 64 Go', 'Carte mémoire SDXC 64 Go de capacité', 29.99, 50, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (56, null, 8, 'Caméra de surveillance IP', 'Caméra de surveillance IP pour la surveillance à distance en temps réel', 129.99, 10, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (57, null, 8, 'Système de sécurité de maison', 'Système de sécurité de maison avec capteurs de mouvement et de porte/fenêtre', 299.99, 5, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (58, null, 8, 'Enregistreur vidéo de sécurité', 'Enregistreur vidéo de sécurité pour la surveillance en continu et la sauvegarde des images', 199.99, 8, null);
insert into APP_PRODUIT (produitid, produitid_remplace, categorieproduitid, produitnom, produitdescription, produitprix, produitstock, produitimage)
values (59, null, 8, 'Serrure connectée', 'Serrure connectée pour un accès facile et sécurisé à votre maison', 149.99, 12, null);
GO
insert into APP_LIGNECOMMANDE (commandeid, produitid, lignecommandequantite)
values (1, 78, 2);
insert into APP_LIGNECOMMANDE (commandeid, produitid, lignecommandequantite)
values (1, 79, 1);
insert into APP_LIGNECOMMANDE (commandeid, produitid, lignecommandequantite)
values (2, 80, 3);
insert into APP_LIGNECOMMANDE (commandeid, produitid, lignecommandequantite)
values (3, 76, 2);
insert into APP_LIGNECOMMANDE (commandeid, produitid, lignecommandequantite)
values (3, 77, 1);
insert into APP_LIGNECOMMANDE (commandeid, produitid, lignecommandequantite)
values (4, 78, 4);
insert into APP_LIGNECOMMANDE (commandeid, produitid, lignecommandequantite)
values (4, 79, 2);
insert into APP_LIGNECOMMANDE (commandeid, produitid, lignecommandequantite)
values (5, 80, 1);
insert into APP_LIGNECOMMANDE (commandeid, produitid, lignecommandequantite)
values (6, 76, 3);
insert into APP_LIGNECOMMANDE (commandeid, produitid, lignecommandequantite)
values (6, 77, 2);
insert into APP_LIGNECOMMANDE (commandeid, produitid, lignecommandequantite)
values (7, 78, 1);
insert into APP_LIGNECOMMANDE (commandeid, produitid, lignecommandequantite)
values (7, 79, 3);
insert into APP_LIGNECOMMANDE (commandeid, produitid, lignecommandequantite)
values (8, 80, 2);
insert into APP_LIGNECOMMANDE (commandeid, produitid, lignecommandequantite)
values (9, 76, 1);
insert into APP_LIGNECOMMANDE (commandeid, produitid, lignecommandequantite)
values (9, 77, 2);
GO
insert into APP_TICKET (ticketid, ticketutilisateurid, ticketdatecreation, ticketdatefinition, ticketstatut)
values (1, 30, CONVERT(DATE,'01-01-2022', 104), null, 'Ouvert');
insert into APP_TICKET (ticketid, ticketutilisateurid, ticketdatecreation, ticketdatefinition, ticketstatut)
values (2, 29, CONVERT(DATE,'02-01-2022', 104), CONVERT(DATE,'03-01-2022', 104), 'Fermé');
insert into APP_TICKET (ticketid, ticketutilisateurid, ticketdatecreation, ticketdatefinition, ticketstatut)
values (3, 28, CONVERT(DATE,'04-01-2022', 104), null, 'En attente');
insert into APP_TICKET (ticketid, ticketutilisateurid, ticketdatecreation, ticketdatefinition, ticketstatut)
values (4, 27, CONVERT(DATE,'05-01-2022', 104), null, 'Ouvert');
insert into APP_TICKET (ticketid, ticketutilisateurid, ticketdatecreation, ticketdatefinition, ticketstatut)
values (5, 21, CONVERT(DATE,'10-01-2022', 104), CONVERT(DATE,'12-01-2022', 104), 'Fermé');
insert into APP_TICKET (ticketid, ticketutilisateurid, ticketdatecreation, ticketdatefinition, ticketstatut)
values (6, 20, CONVERT(DATE,'15-01-2022', 104), null, 'En attente');
insert into APP_TICKET (ticketid, ticketutilisateurid, ticketdatecreation, ticketdatefinition, ticketstatut)
values (7, 19, CONVERT(DATE,'18-01-2022', 104), null, 'Ouvert');
insert into APP_TICKET (ticketid, ticketutilisateurid, ticketdatecreation, ticketdatefinition, ticketstatut)
values (8, 18, CONVERT(DATE,'20-01-2022', 104), CONVERT(DATE,'21-01-2022', 104), 'Fermé');
insert into APP_TICKET (ticketid, ticketutilisateurid, ticketdatecreation, ticketdatefinition, ticketstatut)
values (9, 15, CONVERT(DATE,'22-01-2022', 104), null, 'Ouvert');
insert into APP_TICKET (ticketid, ticketutilisateurid, ticketdatecreation, ticketdatefinition, ticketstatut)
values (10, 14, CONVERT(DATE,'25-01-2022', 104), CONVERT(DATE,'27-01-2022', 104), 'Fermé');
GO
insert into APP_MESSAGE (messageid, ticketid, utilisateurid, messagecontenu)
values (1, 1, 26, 'Bonjour, comment puis-je vous aider aujourd''hui ?');
insert into APP_MESSAGE (messageid, ticketid, utilisateurid, messagecontenu)
values (2, 2, 30, 'Je rencontre un problème avec mon compte utilisateur');
insert into APP_MESSAGE (messageid, ticketid, utilisateurid, messagecontenu)
values (3, 3, 29, 'Bonjour, je ne parviens pas à accéder à mon panier');
insert into APP_MESSAGE (messageid, ticketid, utilisateurid, messagecontenu)
values (4, 4, 25, 'Pouvez-vous me dire si vous avez essayé de vider votre cache et vos cookies ?');
insert into APP_MESSAGE (messageid, ticketid, utilisateurid, messagecontenu)
values (5, 5, 28, 'Bonjour, je n''ai pas reçu ma commande');
insert into APP_MESSAGE (messageid, ticketid, utilisateurid, messagecontenu)
values (6, 6, 24, 'Avez-vous vérifié votre boîte de réception et votre dossier spam ?');
insert into APP_MESSAGE (messageid, ticketid, utilisateurid, messagecontenu)
values (7, 7, 27, 'Bonjour, mon colis est arrivé endommagé');
insert into APP_MESSAGE (messageid, ticketid, utilisateurid, messagecontenu)
values (8, 8, 23, 'Nous sommes désolés pour cela. Pouvez-vous nous envoyer une photo du colis ?');
insert into APP_MESSAGE (messageid, ticketid, utilisateurid, messagecontenu)
values (9, 9, 21, 'Bonjour, je ne parviens pas à me connecter à mon compte utilisateur');
insert into APP_MESSAGE (messageid, ticketid, utilisateurid, messagecontenu)
values (10, 10, 17, 'Avez-vous essayé de réinitialiser votre mot de passe ?');
GO
insert into APP_UTILISATEURSUPPORT (utilisateurid, supportstatut, supportlangue, supportdatearrivee)
values (26, 'Actif', 'Français', CONVERT(DATE,'22-03-2022', 104));
insert into APP_UTILISATEURSUPPORT (utilisateurid, supportstatut, supportlangue, supportdatearrivee)
values (25, 'Inactif', 'Anglais', CONVERT(DATE,'15-01-2022', 104));
insert into APP_UTILISATEURSUPPORT (utilisateurid, supportstatut, supportlangue, supportdatearrivee)
values (24, 'Actif', 'Allemand', CONVERT(DATE,'01-04-2022', 104));
insert into APP_UTILISATEURSUPPORT (utilisateurid, supportstatut, supportlangue, supportdatearrivee)
values (23, 'Inactif', 'Espagnol', CONVERT(DATE,'01-02-2022', 104));
insert into APP_UTILISATEURSUPPORT (utilisateurid, supportstatut, supportlangue, supportdatearrivee)
values (17, 'Actif', 'Portugais', CONVERT(DATE,'10-05-2022', 104));
insert into APP_UTILISATEURSUPPORT (utilisateurid, supportstatut, supportlangue, supportdatearrivee)
values (16, 'Inactif', 'Italien', CONVERT(DATE,'20-06-2022', 104));
insert into APP_UTILISATEURSUPPORT (utilisateurid, supportstatut, supportlangue, supportdatearrivee)
values (12, 'Actif', 'Russe', CONVERT(DATE,'05-07-2022', 104));
insert into APP_UTILISATEURSUPPORT (utilisateurid, supportstatut, supportlangue, supportdatearrivee)
values (11, 'Actif', 'Espagnol', CONVERT(DATE,'01-03-2022', 104));
insert into APP_UTILISATEURSUPPORT (utilisateurid, supportstatut, supportlangue, supportdatearrivee)
values (10, 'Inactif', 'Allemand', CONVERT(DATE,'12-02-2022', 104));
insert into APP_UTILISATEURSUPPORT (utilisateurid, supportstatut, supportlangue, supportdatearrivee)
values (9, 'Actif', 'Anglais', CONVERT(DATE,'05-06-2022', 104));
GO
insert into APP_SUPPORTTICKET (utilisateurid, ticketid)
values (9, 10);
insert into APP_SUPPORTTICKET (utilisateurid, ticketid)
values (10, 9);
insert into APP_SUPPORTTICKET (utilisateurid, ticketid)
values (11, 8);
insert into APP_SUPPORTTICKET (utilisateurid, ticketid)
values (12, 7);
insert into APP_SUPPORTTICKET (utilisateurid, ticketid)
values (16, 6);
insert into APP_SUPPORTTICKET (utilisateurid, ticketid)
values (17, 5);
insert into APP_SUPPORTTICKET (utilisateurid, ticketid)
values (23, 4);
insert into APP_SUPPORTTICKET (utilisateurid, ticketid)
values (24, 3);
insert into APP_SUPPORTTICKET (utilisateurid, ticketid)
values (25, 2);
insert into APP_SUPPORTTICKET (utilisateurid, ticketid)
values (26, 1);
GO
insert into APP_TOKEN (tokenid, tokenutilisateurid, tokendateexpiration, tokencode)
values ('1   ', 30, CONVERT(DATE,'01-04-2023', 104), 'y4u4ia8b98zn9v77xykgsj6i4x8wmcwufprrx7crbz5g5hw5ez5njf9vhv5k5n5q3ktg8mpwmmn5v5q');
insert into APP_TOKEN (tokenid, tokenutilisateurid, tokendateexpiration, tokencode)
values ('2   ', 29, CONVERT(DATE,'02-04-2023', 104), 'g3q8etfj9nv9b46hnnwdztnctt8f8wzhsmtj7xyhmksxsfgghy8c8m9chh9m7s7r5rwt8mktwccr8r5r');
insert into APP_TOKEN (tokenid, tokenutilisateurid, tokendateexpiration, tokencode)
values ('3   ', 28, CONVERT(DATE,'03-04-2023', 104), 't9c8jb8p9kzr7z93gkk86rj8w2w2tcx3gmsn3yq3k8t8vx9ktv7njsysp6t6c6t8vtv5zgr7k6c6t8v');
insert into APP_TOKEN (tokenid, tokenutilisateurid, tokendateexpiration, tokencode)
values ('4   ', 27, CONVERT(DATE,'04-04-2023', 104), 'v5v5np5g5cf3q8etfj9nv9b46hnnwdztnctt8f8wzhsmtj7xyhmksxsfgghy8c8m9chh9m7s7r5rwt8m');
insert into APP_TOKEN (tokenid, tokenutilisateurid, tokendateexpiration, tokencode)
values ('5   ', 21, CONVERT(DATE,'05-04-2023', 104), '5v5q3ktg8mpwmmn5v5qz5njf9vhv5k5n5q3ktg8mpwmmn5v5qz5njf9vhv5k5n5q3ktg8mpwmmn5v5qz');
insert into APP_TOKEN (tokenid, tokenutilisateurid, tokendateexpiration, tokencode)
values ('6   ', 20, CONVERT(DATE,'06-04-2023', 104), 'r7k6c6t8vzr7z93gkk86rj8w2w2tcx3gmsn3yq3k8t8vx9ktv7njsysp6t6c6t8vtv5zgr7k6c6t8vt');
insert into APP_TOKEN (tokenid, tokenutilisateurid, tokendateexpiration, tokencode)
values ('7   ', 19, CONVERT(DATE,'07-04-2023', 104), 'h9m7s7r5rwt8mktwccr8r5rwt8mktwccr8rwt8mktwccr8r5rwt8mktwccr8rwt8mktwccr8r5rwt8mkt');
insert into APP_TOKEN (tokenid, tokenutilisateurid, tokendateexpiration, tokencode)
values ('8   ', 18, CONVERT(DATE,'08-04-2023', 104), 'v7njsysp6t6c6t8vtv5zgr7k6c6t8vzr7z93gkk86rj8w2w2tcx3gmsn3yq3k8t8vx9ktv7njsysp6t6');
insert into APP_TOKEN (tokenid, tokenutilisateurid, tokendateexpiration, tokencode)
values ('9   ', 15, CONVERT(DATE,'09-04-2023', 104), 'n5v5qz5njf9vhv5k5n5q3ktg8mpwmmn5v5qz5njf9vhv5k5n5q3ktg8mpwmmn5v5qz5njf9vhv5k5n5');
insert into APP_TOKEN (tokenid, tokenutilisateurid, tokendateexpiration, tokencode)
values ('10  ', 14, CONVERT(DATE,'10-04-2023', 104), 'm7s7r5rwt8mktwccr8rwt8mktwccr8r5rwt8mktwccr8rwt8mktwccr8r5rwt8mktwccr8rwt8mktwccr');
GO

