CREATE TABLE Salarie (
	
	Id int IDENTITY(1,1) PRIMARY KEY,
	Nom varchar(150),
	Prenom varchar(150),
	Login varchar(150),
	Mdp varchar(150),
	IdRole int,
	FOREIGN KEY (IdRole) REFERENCES Role(Id),

)

Create Table Ville (

	CodeInsee char(5) PRIMARY KEY NOT NULL,
	Nom varchar(150) NOT NULL,
	Arrondissement int NOT NULL,
	CodePostal varchar(150) NOT NULL,

)

CREATE TABLE Campagne (
	
	Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Intitule varchar(150) NOT NULL,
	Objectif varchar(150) NOT NULL,
	DateDebut date NOT NULL,
	DateFin date NOT NULL,
	IdTypePublic int NOT NULL,
	IdSalarie int NOT NULL,
	IdAgenceCommunication int,
	IdAgenceEvenementiel int,
	FOREIGN KEY (IdTypePublic) REFERENCES TypePublic(Id),
	FOREIGN KEY (IdAgenceCommunication) REFERENCES Agence(Id),
	FOREIGN KEY (IdAgenceEvenementiel) REFERENCES Agence(Id),
	FOREIGN KEY (IdSalarie) REFERENCES Salarie(Id),

)

Create Table JournalIntervention (
	
	Id int PRIMARY KEY NOT NULL,
	NomTable varchar(150) NOT NULL,
	OperationEffetctue varchar(150) NOT NULL,
	DateHeure datetime NOT NULL,
	ReferenceEnregistrement varchar(150) NOT NULL,
	IdSalarie int NOT NULL,
	FOREIGN KEY (IdSalarie) REFERENCES Salarie(Id),


)

Create Table VIP (
	
	Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Nom varchar(150) NOT NULL,
	AdressePostal varchar(150) NOT NULL,
	Email varchar(150) NOT NULL,
	IdCategorieVIP int NOT NULL,
	CodeInseeVille char(5) NOT NULL,
	FOREIGN KEY (IdCategorieVIP) REFERENCES CategorieVIP(Id),
	FOREIGN KEY (CodeInseeVille) REFERENCES Ville(CodeInsee),

)

Create Table CategorieVIP (

	Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Libelle varchar(150) NOT NULL,
	   	 
)


Create Table CourantArtistique (

	Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Libelle varchar(150) NOT NULL,
	   	 
)

Create Table Evenement (
	
	Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	DateDebut date NOT NULL,
	DateFin date NOT NULL,
	Intitule varchar(150) NOT NULL,
	IdTheme int NOT NULL,
	CodeInseeVille char(5) NOT NULL,
	IdCategorieVIP int NOT NULL,
	IdCampagne int NOT NULL,
	FOREIGN KEY (IdTheme) REFERENCES Theme(Id),
	FOREIGN KEY (CodeInseeVille) REFERENCES Ville(CodeInsee),
	FOREIGN KEY (IdCategorieVIP) REFERENCES CategorieVIP(Id),
	FOREIGN KEY (IdCampagne) REFERENCES Campagne(Id),

)


Create Table Convier (
	
	IdEvenement int NOT NULL,
	IdCategorieVIP int NOT NULL,
	PRIMARY KEY (IdEvenement, IdCategorieVIP),
	Message varchar(150) NOT NULL,
	FOREIGN KEY (IdEvenement) REFERENCES Evenement(Id),
	FOREIGN KEY (IdCategorieVIP) REFERENCES CategorieVIP(Id),
)


Create Table Participer (
	
	IdEvenement int NOT NULL,
	IdArtiste int NOT NULL,
	PRIMARY KEY (IdEvenement, IdArtiste),
	Cachet decimal(10,2) NOT NULL,
	FOREIGN KEY (IdEvenement) REFERENCES Evenement(Id),
	FOREIGN KEY (IdArtiste) REFERENCES Artiste(Id),
)

CREATE TABLE Agence (
	
	Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Libelle varchar(150) NOT NULL,
	Adresse varchar(150) NOT NULL,
	Telephone varchar(20) NOT NULL,
	Email varchar(150) NOT NULL,
	SiteWeb varchar(150) NOT NULL,
	CodeInseeVille char(5) NOT NULL,
	TypeAgence char(1),
	FOREIGN KEY (CodeInseeVille) REFERENCES Ville(CodeInsee)

)

CREATE TABLE Artiste (

	Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Nom varchar(150) NOT NULL,
	SiteWeb varchar(150) NOT NULL,
	IdCourantArtistique int NOT NULL,
	FOREIGN KEY (IdCourantArtistique) REFERENCES CourantArtistique(Id),

)

create table Role (

	Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Libelle varchar(150) NOT NULL,

)
create table Theme (

	Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Libelle varchar(150) NOT NULL,

)
create table TypePublic (

	Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Libelle varchar(150) NOT NULL,

)
