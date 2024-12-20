CREATE PROCEDURE sp_agence_add 
@Libelle Varchar(150),
@Adresse varchar(150),
@Telephone int,
@Email varchar(150),
@SiteWeb varchar(150),
@TypeCommunication varchar(150),
@TypeEvenementiel varchar(150),
@idVille int
AS
BEGIN
	
	INSERT INTO Agence(Libelle,Adresse,Telephone,Email,SiteWeb,TypeCommunication,TypeEvenementiel,idVille) VALUES (@Libelle,@Adresse,@Telephone,@Email,@SiteWeb, @TypeCommunication, @TypeEvenementiel,@idVille)

END;