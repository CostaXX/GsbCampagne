CREATE PROCEDURE sp_vip_add 
@Nom varchar(150),
@AdressePostal varchar(150),
@Email varchar(150),
@idCategorieVIP INT,
@idVille INT
AS
BEGIN 

	INSERT INTO VIP(Nom,AdressePostal,Email,IdCategorieVIP,IdVille)
	VALUES (@Nom, @AdressePostal, @Email, @idCategorieVIP, @idVille);

END;
go
CREATE PROCEDURE sp_vip_update
@Id INT,
@Nom varchar(150),
@AdressePostal varchar(150),
@Email varchar(150),
@idCategorieVIP INT,
@idVille INT
AS
BEGIN

	Update  VIP	
	SET
		Nom = @Nom,
		AdressePostal = @AdressePostal,
		Email = @Email,
		idCategorieVIP = @idCategorieVIP,
		idVille = @idVille
	WHERE Id = @Id; 
END
go
CREATE PROCEDURE sp_vip_delete
     @Id INT
AS 
BEGIN
            DELETE FROM VIP
               WHERE Id = @Id;
END;

EXEC sp_vip_add 'latifa','9 alle bize','qdd@f.fr',1,9225;

EXEC sp_vip_update 3,'lagziri','9 allee de gaules','lagziri@gmail.com',1,1033;

EXEC sp_vip_delete 3
