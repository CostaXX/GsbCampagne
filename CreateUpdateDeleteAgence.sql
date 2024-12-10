CREATE PROCEDURE sp_agence_add 
@Libelle Varchar(150),
@Adresse varchar(150),
@Telephone int,
@Email varchar(150),
@SiteWeb varchar(150),
@idVille int
AS
BEGIN
	
	INSERT INTO Agence(Libelle,Adresse,Telephone,Email,SiteWeb,idVille) VALUES (@Libelle,@Adresse,@Telephone,@Email,@SiteWeb,@idVille)

END;

go;

CREATE PROCEDURE sp_agence_update
@Id INT,
@Libelle varchar(150),
@Adresse varchar(150),
@Telephone INT,
@Email varchar(150),
@SiteWeb varchar(150),
@IdVille INT
AS
BEGIN
	
	UPDATE Agence SET 
	Libelle = @Libelle,
	Adresse = @Adresse,
	Telephone = @Telephone,
	Email = @Email,
	SiteWeb = @SiteWeb,
	IdVille = @IdVille
	WHERE Id = @Id

END;

go;

CREATE PROCEDURE sp_agence_delete
@id int
AS
BEGIN
	DELETE FROM Agence WHERE id = @id
END;

EXEC sp_agence_delete 1;

go;

CREATE PROCEDURE sp_agence_getAll
AS
BEGIN
	SELECT * FROM Agence
END;

SELECT * FROM AgenceCommunication

SELECT * FROM AgenceEvenementiel