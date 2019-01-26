set dateformat dmy
	use master
		GO
		if exists (select 'true' from sys.databases where name='Abonamente')
			begin
				alter database Abonamente set single_user with rollback immediate
					drop database Abonamente
						end
		GO
					CREATE database Abonamente
		GO
					alter authorization on database::Abonamente to sa
					use Abonamente
		GO
					CREATE TABLE Domenii
					(idDomeniu char(2) PRIMARY KEY,
					 DenDomeniu char(50))
					 
					CREATE TABLE Redactii
					(idRed char(5) PRIMARY KEY,
					 DenRedactie char(50),
					 Sediul char(50))
					 
					 CREATE TABLE Ziare
					 (idZiar char(8) PRIMARY KEY,
					  idRed char(5),
					  DenZiar char(50),
					  idDomeniu char(2),
					  lg char(2),
					  periodicitate int,
					  pret int
					 )
					  
					  CREATE TABLE Abonatii
					  (idAbonat char(7) PRIMARY KEY,
					   Nume char(50),
					   Prenume char(50),
					   idRaion int,
					   Adresa char(50))
					   
					   CREATE TABLE Realizari
					   (idReal char(6) PRIMARY KEY,
					    idAbonat char(7),
					    idZiar char(8),
					    initial date,
					    finis date,
					    pret_final float)
					    
					    CREATE TABLE Raion
					    (idRaion int PRIMARY KEY,
					     nmRaion char(50))
					
	GO
		ALTER TABLE Ziare
			ADD CONSTRAINT FK_Ziare_idRed
				FOREIGN KEY (idRed) REFERENCES Redactii(idRed)  
				
		ALTER TABLE Ziare
			ADD CONSTRAINT FK_Ziare_idDomeniu
				FOREIGN KEY (idDomeniu) REFERENCES Domenii(idDomeniu) 
				 
	
				
		ALTER TABLE Realizari
			ADD CONSTRAINT FK_Realizari_idAbonat
				FOREIGN KEY (idAbonat) REFERENCES Abonatii(idAbonat)
				
		ALTER TABLE Realizari
			ADD CONSTRAINT FK_Realizari_idZiar
				FOREIGN KEY (idZiar) REFERENCES Ziare(idZiar)
				
		ALTER TABLE Abonatii
			ADD CONSTRAINT FK_Abonatii_idRaion
				FOREIGN KEY (idRaion) REFERENCES Raion(idRaion)		
				
				
	GO
		insert into Domenii(idDomeniu, DenDomeniu) values
			('C1', 'Culinarie'),
			('C2', 'Cultura'),
			('E1', 'Educatie'),
			('S1', 'Social'),
			('S2', 'Sanatate'),
			('G1', 'General')

		insert into Redactii(idRed, DenRedactie, Sediul) values
			('I1401', 'Adevarul', 'Chisinau'),
			('I1402', 'Adverb', 'Cahul'),
			('I1403', 'Curier','Cimislia'),
			('I1404', 'Duminica', 'Falesti'),
			('I1405','Luceafarul', 'Hancesti'),
			('I1406', 'Timpul', 'Hancesti'),
			('I1407', 'Vatra', 'Cantemir'),
			('I1501', 'Вести', 'Balti'),
			('I1502', 'Свет', 'Chisinau'),
			('I1503', 'Маклер', 'Chisinau')

		insert into Raion(idRaion, nmRaion) values
			(1, 'Anenii-Noi'),
			(2, 'Basarabeasca'),
			(3, 'Briceni'),
			(4, 'Cahul'),
			(5, 'Cantemir'),
			(6, 'Calarasi'),
			(7, 'Causeni'),
			(8, 'Cimislia'),
			(9, 'Criuleni'),
			(10, 'Donduseni'),
			(11, 'Drochia'),
			(12, 'Dubasari'),
			(13, 'Edinet'),
			(14, 'Falesti'),
			(15, 'Floresti'),
			(16, 'Glodeni'),
			(17, 'Hincesti'),
			(18, 'Ialoveni'),
			(19, 'Leova'),
			(20, 'Nisporeni'),
			(21, 'Ocnita'),
			(22, 'Orhei'),
			(23, 'Rezina'),
			(24, 'Riscani'),
			(25, 'Singerei'),
			(26, 'Soroca'),
			(27, 'Straseni'),
			(28, 'Soldanesti'),
			(29, 'Stefan-Voda'),
			(30, 'Taraclia'),
			(31, 'Telenesti'),
			(32, 'Ungheni'),
			(33, 'Chisinau'),
			(34, 'Balti')

		insert into Ziare(idZiar, idRed, DenZiar, idDomeniu, lg, periodicitate, pret) values
			('PM223050', 'I1501', 'Литературная газета', 'C2', 'RU', 3, 50.4),
			('PM301255', 'I1501','Музыкальное обозрение', 'E1', 'RU', 1, 100),
			('PM201821', 'I1406', 'Faclia', 'E1','MD', 1, 45),
			('PM251020', 'I1503','Makler','G1', 'MD', 1, 15),
			('PM130450', 'I1407', 'Ziarul de garda', 'S1', 'MD', 3, 20),
			('PM219080', 'I1502', 'Vocea poporului', 'S1', 'MD', 1, 18),
			('PM305047', 'I1502', 'Universul Sanatatii', 'S2', 'MD', 3, 45)

		insert into Abonatii(idAbonat, Nume, Prenume, idRaion, Adresa) values
			('A123456', 'Petrescu', 'Ion',3, 'str. Alba-Iulia 18'),
			('B123456', 'Cartescu', 'Maria',8, 'str. Paris'),
			('C123456', 'Sima','Felix',33, 'str. Columna 10'),
			('D123456', 'Popescu', 'Gheorghe', 33, 'str. Florilor'),
			('E123456', 'Trisca', 'Valeria', 33, 'str. Cantemir 14'),
			('F123456', 'Tomulescu', 'Anatol', 25, 'str. Sangera'),
			('G123456', 'Zurga', 'Ana', 30, 'str. Frumoasa 18'),
			('H123456', 'Zvezdenko', 'Alexandru', 33, 'str. Toma Ciorba 10'),
			('I123456', 'Cusnir', 'Dumitru', 30, 'str. Haiducului'),
			('J123456', 'Enescu', 'Vitalina', 12, 'str. Armatei 2'),
			('K123456', 'Dalcenco', 'Valeria', 14, 'str. Noul Neamt'),
			('L123456', 'Turta', 'Andrei', 10, 'str. Mihai Eminescu'),
			('M123456', 'Cristea', 'Cristina', 33, 'str. Veronica Micle'),
			('N123456', 'Cecan','Valeria', 32, 'str. Eugen Doga 12'),  
			('O123456', 'Rusu', 'Alexandru', 30, 'str. Vlaicu Parcalab 10'),
			('P123456', 'Lungu', 'Cristian', 31, 'str. Alecu Russo 5'),
			('Q123456', 'Ravcenco', 'Maxim', 28, 'str. Armatei 20')

								    
		insert into Realizari(idReal, idAbonat, idZiar, initial, finis, pret_final) values
			('ABC123', 'A123456', 'PM223050', '10.01.2018', '10.04.2018', 50.4),
			('DEF123', 'A123456', 'PM301255', '05.02.2018', '05.04.2018', 400),
			('ABC456', 'B123456', 'PM251020', '01.01.2018', '01.06.2018', 75), 
			('ABC987', 'N123456', 'PM305047', '02.02.2018', '02.05.2018', 45),
			('KLM123', 'D123456', 'PM201821', '01.01.2018', '01.08.2018', 315)

			insert into Ziare(idZiar, idRed, DenZiar, idDomeniu, lg, periodicitate, pret) values
			('PM240461', 'I1401', 'Adevarul', 'G1', 'MD', 1, 18),
			('PM205682', 'I1402', 'Кулинария', 'C1', 'RU', 1, 53),
			('PM213018', 'I1502','Рецепты', 'C1', 'RU', 3, 30),
			('PM182525', 'I1404', 'Literatura si Arta', 'C2', 'MD', 1, 15.30)