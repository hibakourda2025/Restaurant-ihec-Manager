USE Restaurant_IHEC;
GO

IF OBJECT_ID('dbo.Personnel', 'U') IS NULL
BEGIN
    CREATE TABLE Personnel (
        cin CHAR(8) PRIMARY KEY,       
        nom NVARCHAR(50) NOT NULL,
        prenom NVARCHAR(50) NOT NULL,
        poste NVARCHAR(50) NOT NULL,
        contact CHAR(8) NOT NULL,
        mot_de_passe NCHAR(6) NOT NULL
    );
END
GO
INSERT INTO Personnel(cin, nom, prenom, poste, contact, mot_de_passe) VALUES
-- Chefs
('01234567','Ben Ali','Karim','Chef','22123456','100100'),
('02345678','Mekki','Salma','Chef','22345678','136978'),
('19192828','Saada','Imen','Chef','23456789','753951'),

-- Sous-chefs
('05554433','Trabelsi','Ali','Sous-Chef','22234567','789456'),
('07891234','Khlifi','Mehdi','Sous-Chef','22678901','100236'),
('14500670','Dridi','Houssem','Sous-Chef','23234567','456987'),
('09988776','Ben Youssef','Adel','Sous-Chef','22345678','100478'),
('15678901','Gharsalli','Wiem','Sous-Chef','23345678','741852'),


-- Admin
('11223344', 'Ben Ali', 'Sami', 'Directeur', '20111111', '123456'),
('12341234', 'Trabelsi', 'Nour', 'Directeur General', '20222222', '234567'),
('18901234', 'Kefi', 'Amira', 'Secretaire', '20333333', '345678'),
('04567890', 'Chaari', 'Salma', 'Chef de Service', '20777777', '789012');