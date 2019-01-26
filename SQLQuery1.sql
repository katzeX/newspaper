use Abonamente
	go

	/*select Ziare.DenZiar from ((Abonatii inner join Realizari on Abonatii.idAbonat = Realizari.idAbonat and Abonatii.idAbonat = 'A123456') inner join Ziare on Realizari.idZiar = Ziare.idZiar )*/


	/*select Abonatii.Nume, Abonatii.Prenume, Abonatii.Adresa from ((Realizari inner join Ziare on Realizari.idZiar = Ziare.idZiar and Realizari.idZiar = 'PM223050') inner join Abonatii on Realizari.idAbonat = Abonatii.idAbonat)*/

	/*select count( Ziare.idZiar) from Ziare where Ziare.idRed = 'I1501'
	select ROUND( SUM(Ziare.pret),2) from Ziare where Ziare.idRed='I1501'

	
	select Redactii.DenRedactie from Redactii where Redactii.idRed in (select idRed from Ziare)

	select * from Ziare where Ziare.lg = 'MD'

	select * from Abonatii inner join Realizari on Abonatii.idAbonat = Realizari.idAbonat where '??.01.2018' in 
	declare @find date = '01.01.2018'
	select Abonatii.idAbonat, Abonatii.Nume, Abonatii.Prenume,Ziare.DenZiar, Realizari.initial , Realizari.finis ,Realizari.pret_final
		 from Abonatii inner join Realizari on( Abonatii.idAbonat = Realizari.idAbonat) and  month(@find) between MONTH(initial ) and MONTH(finis) 
		 
		 inner join Ziare on Realizari.idZiar = Ziare.idZiar*/

		 select * from realizari


	
	 
