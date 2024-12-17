CREATE PROCEDURE sp_artiste_add 
@Nom varchar(150),
@SiteWeb varchar(150),
@idCourantArtistique INT
AS
BEGIN 

	INSERT INTO Artiste(Nom,SiteWeb,idCourantArtistique)
	VALUES (@Nom,@SiteWeb,@idCourantArtistique);

END;
go
CREATE PROCEDURE sp_artiste_update
@Id INT,
@Nom varchar(150),
@SiteWeb varchar(150),
@idCourantArtistique INT
AS
BEGIN

	Update  Artiste	
	SET
		Nom = @Nom,
		SiteWeb = @SiteWeb,
		idCourantArtistique = @idCourantArtistique
		
	WHERE Id = @Id; 
END
go
CREATE PROCEDURE sp_artiste_delete
     @Id INT
AS 
BEGIN
            DELETE FROM Artiste
               WHERE Id = @Id;
END;

EXEC sp_artiste_add 'lafzf','lafz.fr',2;

EXEC sp_artiste_update 12,'lagziri','lafz.fr',2;

EXEC sp_artiste_delete 12