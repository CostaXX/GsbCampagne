--Procédure Ajout Campagne--
Create Procedure sp_campagne_add(@Intitule varchar(150) , @Objectif varchar(150) , @dateDebut date , @dateFin date , @IdSalarie int, @IdTypePublic int , @IdAgenceCommunication int , @IdAgenceEvenementiel int )
As
Begin

Insert Into Campagne(Intitule , Objectif , dateDebut , dateFin , IdSalarie , IdTypePublic , IdAgenceCommunication , IdAgenceEvenementiel) Values (@Intitule , @Objectif , @dateDebut , @dateFin , @IdSalarie , @IdTypePublic , @IdAgenceCommunication , @IdAgenceEvenementiel);

End;

--Exe--
EXEC sp_campagne_add 'Intitule de la Campagne', 'Un objectif', '2024-01-12' , '2024-01-13' , 1 , 2 , 1 , 2;

--Affichage--
SELECT * FROM Campagne;

go;

--Procédure Modifie Campagne--
Create Procedure sp_campagne_edit(@Id int , @Intitule varchar(150) , @Objectif varchar(150) , @dateDebut date , @dateFin date , @IdSalarie int, @IdTypePublic int , @IdAgenceCommunication int , @IdAgenceEvenementiel int)
As
Begin

Update Campagne
Set Intitule = @Intitule , Objectif = @Objectif, dateDebut = @dateDebut , dateFin = @dateFin , IdSalarie = @IdSalarie , IdTypePublic = @IdTypePublic , IdAgenceCommunication = @IdAgenceCommunication , IdAgenceEvenementiel = @IdAgenceEvenementiel
where Id = @Id;

End;

--Exe--
EXEC sp_campagne_update 1 , 'Intitule de la Campagne', 'Un objectif modifier', '2024-01-12' , '2024-01-13' , 2 , 2 , 2 , 1;

--Affichage--
SELECT * FROM Campagne;

go;

--Procédure Supprimer Campagne--
Create Procedure sp_campagne_delete(@Id int)
As
Begin

Delete From Campagne
Where Id = @Id;

End;

--Exe--
EXEC sp_campagne_delete 2;

--Affichage--
SELECT * FROM Campagne;

Create Procedure sp_categorieVIP_add(@Libelle varchar(150))
As
Begin

Insert Into CategorieVIP(Libelle) Values (@Libelle);

End;

exec sp_categorieVIP_add 'testProcedure'
go

Create Procedure sp_categorieVIP_edit(@Id int , @Libelle varchar(150))
As
Begin

Update CategorieVIP
Set Libelle = @Libelle
where Id = @Id;

End;

exec sp_categorieVIP_edit 6,  'NONONON'

go

Create Procedure sp_categorieVIP_delete(@Id int)
As
Begin

Delete From CategorieVIP
Where Id = @Id;

End;

exec sp_categorieVIP_delete 6

select * from CategorieVIP
