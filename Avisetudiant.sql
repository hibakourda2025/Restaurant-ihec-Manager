USE Restaurant_IHEC;
GO
BEGIN
CREATE TABLE AvisEtudiants (
    -- Identifiant unique pour chaque avis
    id_avis NVARCHAR(20) PRIMARY KEY ,
    
    -- Clé étrangère (Le CIN en Tunisie est toujours de 8 chiffres fixes)
    cin_etudiant CHAR(8), 
    
    -- Détails de la visite
    date_avis DATE DEFAULT GETDATE(), -- Date de saisie de l'avis
    date_consommation DATE,           -- Date du repas (DateTimePicker dans votre interface)
    type_menu NVARCHAR(100),          -- Le menu choisi
    
    -- Évaluation par critères (NumericUpDown dans votre interface)
    qualite_plats INT CHECK (qualite_plats BETWEEN 0 AND 5),
    quantite_portions INT CHECK (quantite_portions BETWEEN 0 AND 5),
    temps_attente INT CHECK (temps_attente BETWEEN 0 AND 5),
    proprete_lieu INT CHECK (proprete_lieu BETWEEN 0 AND 5),
    accueil_personnel INT CHECK (accueil_personnel BETWEEN 0 AND 5),
    rapport_qualite_prix INT CHECK (rapport_qualite_prix BETWEEN 0 AND 5),
    
    -- Conclusion
    note_globale NVARCHAR(20),
    commentaire_libre NVARCHAR(MAX),

    -- Définition de la clé étrangère
    CONSTRAINT FK_Avis_Etudiant FOREIGN KEY (cin_etudiant) REFERENCES Etudiant(cin_etudiant)
);
END