CREATE TABLE Menus (
    id_menu INT PRIMARY KEY IDENTITY(1,1),
    date_menu DATE NOT NULL,
    nom_choix VARCHAR(20) NOT NULL, -- 'Menu 1' ou 'Menu 2'
    plat_principal VARCHAR(100),
    entree VARCHAR(100),
    dessert VARCHAR(100),
    prix DECIMAL(10, 3) NOT NULL, -- La nouvelle colonne Prix (ex: 5.500)
    quantite_dispo INT
);