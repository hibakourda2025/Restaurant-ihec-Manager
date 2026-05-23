USE Restaurant_IHEC;
GO
CREATE TABLE Reservations (
    id_reservation NVARCHAR(20) PRIMARY KEY,
    cin_etudiant char(8) NOT NULL, 
    id_menu INT NOT NULL,
    date_reservation DATE DEFAULT CAST(GETDATE() AS DATE),
    statut VARCHAR(20) DEFAULT 'en cours',
    FOREIGN KEY (id_menu) REFERENCES Menus(id_menu)
);