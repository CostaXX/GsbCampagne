CREATE PROCEDURE sp_CourantArtistique_add 
@Libelle varchar(150)

AS
BEGIN 

	INSERT INTO CourantArtistique(Libelle)
	VALUES (@Libelle);

END;
GO
CREATE PROCEDURE sp_CourantArtistique_delete
     @Id INT
AS 
BEGIN
            DELETE FROM CourantArtistique
               WHERE Id = @Id;
END;
GO
EXEC sp_CourantArtistique_add 'Manga';

EXEC sp_CourantArtistique_delete 1
