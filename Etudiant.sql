
USE Restaurant_IHEC;
GO

IF OBJECT_ID('dbo.Etudiant', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Etudiant (
        cin_etudiant CHAR(8) PRIMARY KEY,
        nom NVARCHAR(50),
        prenom NVARCHAR(50),
        date_naissance DATE,
        filiere NVARCHAR(50),
        telephone CHAR(8),
        mail NVARCHAR(100),
        date_inscription DATE,
        mot_de_passe NVARCHAR(MAX)
    );
END
GO

INSERT INTO Etudiant (cin_etudiant, nom, prenom, date_naissance, filiere, telephone, mail, date_inscription, mot_de_passe) VALUES


('01250001','Ali','Trabelsi','2006-01-05','1BI','20123456','ali.trabelsi.2025@ihec.ucar.tn','2025-09-15','T9mV4pK8'),
('01250002','Sara','Ben Ali','2006-02-10','1LSG','20223457','sara.benali.2025@ihec.ucar.tn','2025-09-15','F6hJ3rN1'),
('01250003','Youssef','Jaziri','2006-03-12','1BI','20323458','youssef.jaziri.2025@ihec.ucar.tn','2025-09-15','V2dK9wQ5'),
('01250004','Mariem','Kefi','2006-04-05','1LSG','20423459','mariem.kefi.2025@ihec.ucar.tn','2025-09-15','P8gT7zL3'),
('01250005','Omar','Sassi','2006-05-20','1BI','20523450','omar.sassi.2025@ihec.ucar.tn','2025-09-15','N5bW3cR6'),
('01250006','Nour','Ben Salah','2006-06-11','1LSG','20623451','nour.bensalah.2025@ihec.ucar.tn','2025-09-15','H4kM9vJ2'),
('01250007','Ahmed','Chaabane','2006-07-30','1BI','20723452','ahmed.chaabane.2025@ihec.ucar.tn','2025-09-15','Z7rL5pX1'),
('01250008','Rania','Gharbi','2006-08-14','1LSG','20823453','rania.gharbi.2025@ihec.ucar.tn','2025-09-15','C3tV8jR4'),
('01250009','Karim','Hamdi','2006-09-25','1BI','20923454','karim.hamdi.2025@ihec.ucar.tn','2025-09-15','Q9wP2sF6'),
('01250010','Salma','Mekki','2006-10-12','1LSG','21023455','salma.mekki.2025@ihec.ucar.tn','2025-09-15','J2hK6vL8'),
('01250011','Nora','Hammami','2006-06-12','1BI','62123456','nora.hammami.2025@ihec.ucar.tn','2025-09-15','P3rT9xL7'),
('01250012','Nada','Tlili','2006-09-14','1LSG','62623451','nada.tlili.2025@ihec.ucar.tn','2025-09-15','R5pK7tM4'),


('01240011','Walid','Tounsi','2005-01-05','2BI','31123456','walid.tounsi.2024@ihec.ucar.tn','2024-09-15','X5qR8dM3'),
('01240012','Lina','Zoghlami','2005-02-15','2LSG','31223457','lina.zoghlami.2024@ihec.ucar.tn','2024-09-15','K1pG4vN7'),
('01240013','Fares','Ayari','2005-03-20','2Comptabilité','31323458','fares.ayari.2024@ihec.ucar.tn','2024-09-15','D8hT2qL5'),
('01240014','Ines','Brahmi','2005-04-11','2Management','31423459','ines.brahmi.2024@ihec.ucar.tn','2024-09-15','S7mW3rF9'),
('01240015','Mehdi','Khlifi','2005-05-23','2Finance','31523450','mehdi.khlifi.2024@ihec.ucar.tn','2024-09-15','L2kJ8vN6'),
('01240016','Aya','Tlili','2005-06-18','2Marketing','31623451','aya.tlili.2024@ihec.ucar.tn','2024-09-15','B9tR3hX2'),
('01240017','Houssem','Dridi','2005-07-22','2BI','31723452','houssem.dridi.2024@ihec.ucar.tn','2024-09-15','F6gK2vL9'),
('01240018','Amira','Saidi','2005-08-16','2LSG','31823453','amira.saidi.2024@ihec.ucar.tn','2024-09-15','Q4hM7tP1'),
('01240019','Zied','Ghedira','2005-09-30','2Finance','31923454','zied.ghedira.2024@ihec.ucar.tn','2024-09-15','R5kJ8vN3'),
('01240020','Sonia','Mansouri','2005-10-14','2Marketing','32023455','sonia.mansouri.2024@ihec.ucar.tn','2024-09-15','P7hT2qL5'),
('01240021','Rami','Ben Ali','2005-11-21','2Comptabilité','62723452','rami.benali.2024@ihec.ucar.tn','2024-09-15','V8hT2qN5'),
('01240022','Malek','Saidi','2005-03-09','2LSG','62223457','malek.saidi.2024@ihec.ucar.tn','2024-09-15','D5kJ1vM8'),


('01230021','Nader','Haddad','2004-01-08','3BI','41123456','nader.haddad.2023@ihec.ucar.tn','2023-09-15','G7kD2vP9'),
('01230022','Dorra','Rekik','2004-02-12','3LSG','41223457','dorra.rekik.2023@ihec.ucar.tn','2023-09-15','M4pR8xJ2'),
('01230023','Tarek','Ben Romdhane','2004-03-20','3Comptabilité','41323458','tarek.benromdhane.2023@ihec.ucar.tn','2023-09-15','B9vK3tL7'),
('01230024','Mouna','Gdoura','2004-04-11','3Management','41423459','mouna.gdoura.2023@ihec.ucar.tn','2023-09-15','R2hM6wP5'),
('01230025','Lotfi','Baccar','2004-05-23','3Finance','41523450','lotfi.baccar.2023@ihec.ucar.tn','2023-09-15','T8kV1zJ3'),
('01230026','Rim','Feki','2004-06-30','3Marketing','41623451','rim.feki.2023@ihec.ucar.tn','2023-09-15','Q5hW9rL2'),
('01230027','Hatem','Sellami','2004-07-08','3BI','41723452','hatem.sellami.2023@ihec.ucar.tn','2023-09-15','N7pK4vF8'),
('01230028','Wiem','Gharsalli','2004-09-27','3LSG','41823453','wiem.gharsalli.2023@ihec.ucar.tn','2023-09-15','L3rD5xM9'),
('01230029','Adel','Ben Youssef','2004-11-05','3Finance','41923454','adel.benyoussef.2023@ihec.ucar.tn','2023-09-15','C6tG2kP7'),
('01230030','Nesrine','Karray','2004-02-26','3Management','42023455','nesrine.karray.2023@ihec.ucar.tn','2023-09-15','V4hJ8mR1'),
('01230031','Safa','Ben Salah','2004-12-01','3BI','62323458','safa.bensalah.2023@ihec.ucar.tn','2023-09-15','F6hK2pR3'),
('01230032','Meriem','Ayari','2004-01-16','3Management','62823453','meriem.ayari.2023@ihec.ucar.tn','2023-09-15','J7kR3pL6'),


('01220031','Skander','Hamza','2003-03-18','M1 BigData','51123456','skander.hamza.2022@ihec.ucar.tn','2022-09-15','F9pL2vX6'),
('01220032','Olfa','Mrad','2003-05-07','M1 Finance','51223457','olfa.mrad.2022@ihec.ucar.tn','2022-09-15','K5hR7tQ3'),
('01220033','Anis','Chakroun','2003-07-14','M1 Management','51323458','anis.chakroun.2022@ihec.ucar.tn','2022-09-15','D8kM1pJ4'),
('01220034','Syrine','Boussetta','2003-10-22','M1 Marketing','51423459','syrine.boussetta.2022@ihec.ucar.tn','2022-09-15','R6vT3xH9'),
('01220035','Imed','Bouaziz','2003-12-31','M1 Finance','51523450','imed.bouaziz.2022@ihec.ucar.tn','2022-09-15','P2hK8mV7'),
('01220036','Asma','Cherif','2003-01-11','M1 Marketing','51623451','asma.cherif.2022@ihec.ucar.tn','2022-09-15','J7rT1xN5'),
('01220037','Fathi','Moussa','2003-09-09','M1 BigData','51723452','fathi.moussa.2022@ihec.ucar.tn','2022-09-15','L3pK6vQ8'),
('01220038','Hela','Abid','2003-03-04','M1 Finance','51823453','hela.abid.2022@ihec.ucar.tn','2022-09-15','M5hR2tF9'),
('01220039','Ridha','Dhouib','2003-06-25','M1 Management','51923454','ridha.dhouib.2022@ihec.ucar.tn','2022-09-15','B8vK3pX6'),
('01220040','Yosra','Ben Salem','2003-08-02','M1 Marketing','52023455','yosra.bensalem.2022@ihec.ucar.tn','2022-09-15','T4hM9rJ2'),
('01220041','Youssef','Gharbi','2003-08-17','M1 Finance','62423459','youssef.gharbi.2022@ihec.ucar.tn','2022-09-15','K9rT4vP1'),
('01220042','Hedi','Khlifi','2003-04-08','M1 BigData','62923454','hedi.khlifi.2022@ihec.ucar.tn','2022-09-15','N5pT2xR9'),


('01210041','Khalil','Mejri','2002-04-17','M2 BigData','61123456','khalil.mejri.2021@ihec.ucar.tn','2021-09-15','Q7pL5xR3'),
('01210042','Aicha','Touati','2002-07-29','M2 Finance','61223457','aicha.touati.2021@ihec.ucar.tn','2021-09-15','N3hT8vF6'),
('01210043','Hamza','Ghariani','2002-02-13','M2 Management','61323458','hamza.ghariani.2021@ihec.ucar.tn','2021-09-15','K5rD2mX9'),
('01210044','Nada','Jemai','2002-11-19','M2 Finance','61423459','nada.jemai.2021@ihec.ucar.tn','2021-09-15','C8vH1pJ4'),
('01210045','Sami','Khalfaoui','2002-05-21','M2 Marketing','61523450','sami.khalfaoui.2021@ihec.ucar.tn','2021-09-15','R2tM6xP7'),
('01210046','Racha','Bahloul','2002-09-06','M2 BigData','61623451','racha.bahloul.2021@ihec.ucar.tn','2021-09-15','F9hK3vL2'),
('01210047','Moez','Ben Amor','2002-01-30','M2 Finance','61723452','moez.benamor.2021@ihec.ucar.tn','2021-09-15','P5rT8xH6'),
('01210048','Imen','Saada','2002-04-24','M2 Marketing','61823453','imen.saada.2021@ihec.ucar.tn','2021-09-15','L2vM9pJ3'),
('01210049','Hichem','Kooli','2002-10-10','M2 Finance','61923454','hichem.kooli.2021@ihec.ucar.tn','2021-09-15','T7hR1xF8'),
('01210050','Ons','Bouzid','2002-12-15','M2 Marketing','62023455','ons.bouzid.2021@ihec.ucar.tn','2021-09-15','M4pK6vN9'),
('01210051','Selim','Ben Youssef','2002-05-12','M2 Marketing','62523450','selim.benyoussef.2021@ihec.ucar.tn','2021-09-15','H4vG3xN2'),
('01210052','Samar','Brahmi','2002-09-27','M2 Finance','63023455','samar.brahmi.2021@ihec.ucar.tn','2021-09-15','L3rK7vQ2');
