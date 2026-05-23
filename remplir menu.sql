USE Restaurant_IHEC;
GO

INSERT INTO Menus (date_menu, nom_choix, plat_principal, entree, dessert, prix, quantite_dispo)
VALUES 
-- SEMAINE DU 04 MAI AU 10 MAI --
('2026-05-04', 'Menu 1', 'Couscous Agneau', 'Salade Verte', 'Fruit', 4.500, 150),
('2026-05-04', 'Menu 2', 'Lablabi', 'Salade Verte', 'Fruit', 3.000, 200),
('2026-05-05', 'Menu 1', 'Mosli Poulet', 'Salade Tunisienne', 'Dattes', 4.000, 140),
('2026-05-05', 'Menu 2', 'Riz Djerbien', 'Salade Mechwia', 'Fruit', 3.800, 130),
('2026-05-06', 'Menu 1', 'Kamounia', 'Salade de Poulpe', 'Baklawa', 4.500, 100), -- Date d'aujourd'hui
('2026-05-06', 'Menu 2', 'Mloukhia', 'Salade Verte', 'Fruit', 4.000, 150),
('2026-05-07', 'Menu 1', 'Escalope Grillée', 'Frites', 'Jus', 4.200, 160),
('2026-05-07', 'Menu 2', 'Lasagne', 'Salade Cesar', 'Creme', 4.500, 110),
('2026-05-08', 'Menu 1', 'Poisson au four', 'Tastira', 'Fruit', 5.000, 90),
('2026-05-08', 'Menu 2', 'Spaghetti Fruits de mer', 'Soupe', 'Yaourt', 4.800, 100),
('2026-05-09', 'Menu 1', 'Ojja Merguez', 'Salade Verte', 'Fruit', 3.500, 180),
('2026-05-09', 'Menu 2', 'Chakhchoukha', 'Salade Tunisienne', 'Thé', 3.800, 140),


-- SEMAINE DU 11 MAI AU 17 MAI --
('2026-05-11', 'Menu 1', 'Makrouna Tunisienne', 'Salade Verte', 'Yaourt', 3.500, 150),
('2026-05-11', 'Menu 2', 'Dwida Mfawra', 'Salade Tunisienne', 'Fruit', 3.500, 140),
('2026-05-12', 'Menu 1', 'Riz Djerbien', 'Salade Mechwia', 'Dattes', 4.500, 200),
('2026-05-12', 'Menu 2', 'Koucha Viande', 'Salade Verte', 'Fruit', 5.000, 100),
('2026-05-13', 'Menu 1', 'Nwasser Poulet', 'Salade Tunisienne', 'Fruit', 4.000, 130),
('2026-05-13', 'Menu 2', 'Pizza Royale', 'Frites', 'Boisson', 3.500, 180),
('2026-05-14', 'Menu 1', 'Ojja Merguez', 'Salade Verte', 'Yaourt', 3.200, 150),
('2026-05-14', 'Menu 2', 'Riz','Brochettes Poulet', 'Fruit', 4.200, 140),
('2026-05-15', 'Menu 1', 'Couscous Poisson', 'Tastira', 'Fruit', 5.500, 80),
('2026-05-15', 'Menu 2', 'Cannelloni', 'Salade Cesar', 'Glace', 4.500, 100),
('2026-05-16', 'Menu 1', 'Kaftaji', 'Frites', 'Fruit', 3.500, 170),
('2026-05-16', 'Menu 2', 'Spaghetti Bolognaise', 'Salade Verte', 'Jus', 3.800, 150);
GO