
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/16/2024 16:25:42
-- Generated from EDMX file: C:\Users\dulca\Desktop\GsbCampagne\GsbCampagneDAL\CampagnesModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [GsbCampagnes];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__Agence__IdVille__0A688BB1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Agence] DROP CONSTRAINT [FK__Agence__IdVille__0A688BB1];
GO
IF OBJECT_ID(N'[dbo].[FK__Artiste__IdCoura__693CA210]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Artiste] DROP CONSTRAINT [FK__Artiste__IdCoura__693CA210];
GO
IF OBJECT_ID(N'[dbo].[FK__Campagne__IdAgen__1209AD79]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Campagne] DROP CONSTRAINT [FK__Campagne__IdAgen__1209AD79];
GO
IF OBJECT_ID(N'[dbo].[FK__Campagne__IdAgen__12FDD1B2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Campagne] DROP CONSTRAINT [FK__Campagne__IdAgen__12FDD1B2];
GO
IF OBJECT_ID(N'[dbo].[FK__Campagne__IdSala__14E61A24]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Campagne] DROP CONSTRAINT [FK__Campagne__IdSala__14E61A24];
GO
IF OBJECT_ID(N'[dbo].[FK__Campagne__IdType__13F1F5EB]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Campagne] DROP CONSTRAINT [FK__Campagne__IdType__13F1F5EB];
GO
IF OBJECT_ID(N'[dbo].[FK__Evenement__IdArt__1C873BEC]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Evenement] DROP CONSTRAINT [FK__Evenement__IdArt__1C873BEC];
GO
IF OBJECT_ID(N'[dbo].[FK__Evenement__IdCam__1F63A897]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Evenement] DROP CONSTRAINT [FK__Evenement__IdCam__1F63A897];
GO
IF OBJECT_ID(N'[dbo].[FK__Evenement__IdCat__1E6F845E]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Evenement] DROP CONSTRAINT [FK__Evenement__IdCat__1E6F845E];
GO
IF OBJECT_ID(N'[dbo].[FK__Evenement__IdThe__1B9317B3]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Evenement] DROP CONSTRAINT [FK__Evenement__IdThe__1B9317B3];
GO
IF OBJECT_ID(N'[dbo].[FK__Evenement__IdVil__1D7B6025]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Evenement] DROP CONSTRAINT [FK__Evenement__IdVil__1D7B6025];
GO
IF OBJECT_ID(N'[dbo].[FK__JournalIn__IdSal__2739D489]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[JournalIntervention] DROP CONSTRAINT [FK__JournalIn__IdSal__2739D489];
GO
IF OBJECT_ID(N'[dbo].[FK__Salarie__IdRole__1EA48E88]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Salarie] DROP CONSTRAINT [FK__Salarie__IdRole__1EA48E88];
GO
IF OBJECT_ID(N'[dbo].[FK__VIP__IdCategorie__3A4CA8FD]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VIP] DROP CONSTRAINT [FK__VIP__IdCategorie__3A4CA8FD];
GO
IF OBJECT_ID(N'[dbo].[FK__VIP__IdVille__3B40CD36]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VIP] DROP CONSTRAINT [FK__VIP__IdVille__3B40CD36];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Agence]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Agence];
GO
IF OBJECT_ID(N'[dbo].[Artiste]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Artiste];
GO
IF OBJECT_ID(N'[dbo].[Campagne]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Campagne];
GO
IF OBJECT_ID(N'[dbo].[CategorieVIP]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CategorieVIP];
GO
IF OBJECT_ID(N'[dbo].[CourantArtistique]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CourantArtistique];
GO
IF OBJECT_ID(N'[dbo].[Evenement]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Evenement];
GO
IF OBJECT_ID(N'[dbo].[JournalIntervention]', 'U') IS NOT NULL
    DROP TABLE [dbo].[JournalIntervention];
GO
IF OBJECT_ID(N'[dbo].[Role]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Role];
GO
IF OBJECT_ID(N'[dbo].[Salarie]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Salarie];
GO
IF OBJECT_ID(N'[dbo].[Theme]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Theme];
GO
IF OBJECT_ID(N'[dbo].[TypePublic]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TypePublic];
GO
IF OBJECT_ID(N'[dbo].[Ville]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ville];
GO
IF OBJECT_ID(N'[dbo].[VIP]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VIP];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Agences'
CREATE TABLE [dbo].[Agences] (
    [Id] int  NOT NULL,
    [Libelle] varchar(150)  NULL,
    [Adresse] varchar(150)  NULL,
    [Telephone] int  NULL,
    [Email] varchar(150)  NULL,
    [SiteWeb] varchar(150)  NULL,
    [IdVille] int  NULL,
    [TypeCommunication] varchar(150)  NULL,
    [TypeEvenementiel] varchar(150)  NULL
);
GO

-- Creating table 'AgenceCommunications'
CREATE TABLE [dbo].[AgenceCommunications] (
    [Id] int  NOT NULL,
    [IdAgence] int  NULL
);
GO

-- Creating table 'AgenceEvenementiels'
CREATE TABLE [dbo].[AgenceEvenementiels] (
    [Id] int  NOT NULL,
    [IdAgence] int  NULL
);
GO

-- Creating table 'Artistes'
CREATE TABLE [dbo].[Artistes] (
    [Id] int  NOT NULL,
    [Nom] varchar(150)  NULL,
    [SiteWeb] varchar(150)  NULL,
    [IdCourantArtistique] int  NULL
);
GO

-- Creating table 'Campagnes'
CREATE TABLE [dbo].[Campagnes] (
    [Id] int  NOT NULL,
    [Intitule] varchar(150)  NULL,
    [Objectif] varchar(150)  NULL,
    [DateDebut] datetime  NULL,
    [DateFin] datetime  NULL,
    [IdTypePublic] int  NULL,
    [IdAgenceCommunication] int  NULL,
    [IdAgenceEvenementiel] int  NULL,
    [IdSalarie] int  NULL
);
GO

-- Creating table 'CategorieVIPs'
CREATE TABLE [dbo].[CategorieVIPs] (
    [Id] int  NOT NULL,
    [Libelle] varchar(150)  NULL
);
GO

-- Creating table 'CourantArtistiques'
CREATE TABLE [dbo].[CourantArtistiques] (
    [Id] int  NOT NULL,
    [Libelle] varchar(150)  NULL
);
GO

-- Creating table 'Roles'
CREATE TABLE [dbo].[Roles] (
    [Id] int  NOT NULL,
    [Libelle] varchar(150)  NULL
);
GO

-- Creating table 'Salaries'
CREATE TABLE [dbo].[Salaries] (
    [Id] int  NOT NULL,
    [Nom] varchar(150)  NULL,
    [Prenom] varchar(150)  NULL,
    [Mdp] varchar(150)  NULL,
    [IdRole] int  NULL,
    [Login] varchar(150)  NULL
);
GO

-- Creating table 'Themes'
CREATE TABLE [dbo].[Themes] (
    [Id] int  NOT NULL,
    [Libelle] varchar(150)  NULL
);
GO

-- Creating table 'TypePublics'
CREATE TABLE [dbo].[TypePublics] (
    [Id] int  NOT NULL,
    [Libelle] varchar(150)  NULL
);
GO

-- Creating table 'Villes'
CREATE TABLE [dbo].[Villes] (
    [CodeInsee] int  NOT NULL,
    [Nom] varchar(150)  NULL,
    [Arrondissement] int  NULL,
    [CodePostal] varchar(150)  NULL
);
GO

-- Creating table 'VIPs'
CREATE TABLE [dbo].[VIPs] (
    [Id] int  NOT NULL,
    [Nom] varchar(150)  NULL,
    [AdressePostal] varchar(150)  NULL,
    [Email] varchar(150)  NULL,
    [IdCategorieVIP] int  NULL,
    [IdVille] int  NULL
);
GO

-- Creating table 'JournalInterventions'
CREATE TABLE [dbo].[JournalInterventions] (
    [Id] int  NOT NULL,
    [NomTable] varchar(150)  NULL,
    [OperationEffetctue] varchar(150)  NULL,
    [DateHeure] datetime  NULL,
    [ReferenceEnregistrement] varchar(150)  NULL,
    [IdSalarie] int  NULL
);
GO

-- Creating table 'Conviers'
CREATE TABLE [dbo].[Conviers] (
    [IdEvenement] int  NOT NULL,
    [IdCategorie] int  NULL,
    [Message] varchar(150)  NULL
);
GO

-- Creating table 'Participers'
CREATE TABLE [dbo].[Participers] (
    [IdEvenement] int  NOT NULL,
    [IdArtiste] int  NULL,
    [Cachet] varchar(150)  NULL
);
GO

-- Creating table 'Evenements'
CREATE TABLE [dbo].[Evenements] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DateDebut] datetime  NULL,
    [DateFin] datetime  NULL,
    [Intitule] varchar(150)  NULL,
    [IdTheme] int  NULL,
    [IdArtiste] int  NULL,
    [IdVille] int  NULL,
    [IdCategorieVIP] int  NULL,
    [IdCampagne] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Agences'
ALTER TABLE [dbo].[Agences]
ADD CONSTRAINT [PK_Agences]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AgenceCommunications'
ALTER TABLE [dbo].[AgenceCommunications]
ADD CONSTRAINT [PK_AgenceCommunications]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AgenceEvenementiels'
ALTER TABLE [dbo].[AgenceEvenementiels]
ADD CONSTRAINT [PK_AgenceEvenementiels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Artistes'
ALTER TABLE [dbo].[Artistes]
ADD CONSTRAINT [PK_Artistes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Campagnes'
ALTER TABLE [dbo].[Campagnes]
ADD CONSTRAINT [PK_Campagnes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CategorieVIPs'
ALTER TABLE [dbo].[CategorieVIPs]
ADD CONSTRAINT [PK_CategorieVIPs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CourantArtistiques'
ALTER TABLE [dbo].[CourantArtistiques]
ADD CONSTRAINT [PK_CourantArtistiques]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [PK_Roles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Salaries'
ALTER TABLE [dbo].[Salaries]
ADD CONSTRAINT [PK_Salaries]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Themes'
ALTER TABLE [dbo].[Themes]
ADD CONSTRAINT [PK_Themes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TypePublics'
ALTER TABLE [dbo].[TypePublics]
ADD CONSTRAINT [PK_TypePublics]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [CodeInsee] in table 'Villes'
ALTER TABLE [dbo].[Villes]
ADD CONSTRAINT [PK_Villes]
    PRIMARY KEY CLUSTERED ([CodeInsee] ASC);
GO

-- Creating primary key on [Id] in table 'VIPs'
ALTER TABLE [dbo].[VIPs]
ADD CONSTRAINT [PK_VIPs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'JournalInterventions'
ALTER TABLE [dbo].[JournalInterventions]
ADD CONSTRAINT [PK_JournalInterventions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [IdEvenement] in table 'Conviers'
ALTER TABLE [dbo].[Conviers]
ADD CONSTRAINT [PK_Conviers]
    PRIMARY KEY CLUSTERED ([IdEvenement] ASC);
GO

-- Creating primary key on [IdEvenement] in table 'Participers'
ALTER TABLE [dbo].[Participers]
ADD CONSTRAINT [PK_Participers]
    PRIMARY KEY CLUSTERED ([IdEvenement] ASC);
GO

-- Creating primary key on [Id] in table 'Evenements'
ALTER TABLE [dbo].[Evenements]
ADD CONSTRAINT [PK_Evenements]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdVille] in table 'Agences'
ALTER TABLE [dbo].[Agences]
ADD CONSTRAINT [FK__Agence__IdVille__5812160E]
    FOREIGN KEY ([IdVille])
    REFERENCES [dbo].[Villes]
        ([CodeInsee])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Agence__IdVille__5812160E'
CREATE INDEX [IX_FK__Agence__IdVille__5812160E]
ON [dbo].[Agences]
    ([IdVille]);
GO

-- Creating foreign key on [IdAgence] in table 'AgenceCommunications'
ALTER TABLE [dbo].[AgenceCommunications]
ADD CONSTRAINT [FK__AgenceCom__IdAge__5DCAEF64]
    FOREIGN KEY ([IdAgence])
    REFERENCES [dbo].[Agences]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__AgenceCom__IdAge__5DCAEF64'
CREATE INDEX [IX_FK__AgenceCom__IdAge__5DCAEF64]
ON [dbo].[AgenceCommunications]
    ([IdAgence]);
GO

-- Creating foreign key on [IdAgence] in table 'AgenceEvenementiels'
ALTER TABLE [dbo].[AgenceEvenementiels]
ADD CONSTRAINT [FK__AgenceEve__IdAge__5AEE82B9]
    FOREIGN KEY ([IdAgence])
    REFERENCES [dbo].[Agences]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__AgenceEve__IdAge__5AEE82B9'
CREATE INDEX [IX_FK__AgenceEve__IdAge__5AEE82B9]
ON [dbo].[AgenceEvenementiels]
    ([IdAgence]);
GO

-- Creating foreign key on [IdAgenceCommunication] in table 'Campagnes'
ALTER TABLE [dbo].[Campagnes]
ADD CONSTRAINT [FK__Campagne__IdAgen__17036CC0]
    FOREIGN KEY ([IdAgenceCommunication])
    REFERENCES [dbo].[AgenceCommunications]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Campagne__IdAgen__17036CC0'
CREATE INDEX [IX_FK__Campagne__IdAgen__17036CC0]
ON [dbo].[Campagnes]
    ([IdAgenceCommunication]);
GO

-- Creating foreign key on [IdAgenceEvenementiel] in table 'Campagnes'
ALTER TABLE [dbo].[Campagnes]
ADD CONSTRAINT [FK__Campagne__IdAgen__160F4887]
    FOREIGN KEY ([IdAgenceEvenementiel])
    REFERENCES [dbo].[AgenceEvenementiels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Campagne__IdAgen__160F4887'
CREATE INDEX [IX_FK__Campagne__IdAgen__160F4887]
ON [dbo].[Campagnes]
    ([IdAgenceEvenementiel]);
GO

-- Creating foreign key on [IdCourantArtistique] in table 'Artistes'
ALTER TABLE [dbo].[Artistes]
ADD CONSTRAINT [FK__Artiste__IdCoura__693CA210]
    FOREIGN KEY ([IdCourantArtistique])
    REFERENCES [dbo].[CourantArtistiques]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Artiste__IdCoura__693CA210'
CREATE INDEX [IX_FK__Artiste__IdCoura__693CA210]
ON [dbo].[Artistes]
    ([IdCourantArtistique]);
GO

-- Creating foreign key on [IdSalarie] in table 'Campagnes'
ALTER TABLE [dbo].[Campagnes]
ADD CONSTRAINT [FK__Campagne__IdSala__18EBB532]
    FOREIGN KEY ([IdSalarie])
    REFERENCES [dbo].[Salaries]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Campagne__IdSala__18EBB532'
CREATE INDEX [IX_FK__Campagne__IdSala__18EBB532]
ON [dbo].[Campagnes]
    ([IdSalarie]);
GO

-- Creating foreign key on [IdTypePublic] in table 'Campagnes'
ALTER TABLE [dbo].[Campagnes]
ADD CONSTRAINT [FK__Campagne__IdType__17F790F9]
    FOREIGN KEY ([IdTypePublic])
    REFERENCES [dbo].[TypePublics]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Campagne__IdType__17F790F9'
CREATE INDEX [IX_FK__Campagne__IdType__17F790F9]
ON [dbo].[Campagnes]
    ([IdTypePublic]);
GO

-- Creating foreign key on [IdCategorieVIP] in table 'VIPs'
ALTER TABLE [dbo].[VIPs]
ADD CONSTRAINT [FK__VIP__IdCategorie__72C60C4A]
    FOREIGN KEY ([IdCategorieVIP])
    REFERENCES [dbo].[CategorieVIPs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__VIP__IdCategorie__72C60C4A'
CREATE INDEX [IX_FK__VIP__IdCategorie__72C60C4A]
ON [dbo].[VIPs]
    ([IdCategorieVIP]);
GO

-- Creating foreign key on [IdRole] in table 'Salaries'
ALTER TABLE [dbo].[Salaries]
ADD CONSTRAINT [FK__Salarie__IdRole__0E6E26BF]
    FOREIGN KEY ([IdRole])
    REFERENCES [dbo].[Roles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Salarie__IdRole__0E6E26BF'
CREATE INDEX [IX_FK__Salarie__IdRole__0E6E26BF]
ON [dbo].[Salaries]
    ([IdRole]);
GO

-- Creating foreign key on [IdVille] in table 'VIPs'
ALTER TABLE [dbo].[VIPs]
ADD CONSTRAINT [FK__VIP__IdVille__71D1E811]
    FOREIGN KEY ([IdVille])
    REFERENCES [dbo].[Villes]
        ([CodeInsee])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__VIP__IdVille__71D1E811'
CREATE INDEX [IX_FK__VIP__IdVille__71D1E811]
ON [dbo].[VIPs]
    ([IdVille]);
GO

-- Creating foreign key on [IdSalarie] in table 'JournalInterventions'
ALTER TABLE [dbo].[JournalInterventions]
ADD CONSTRAINT [FK__JournalIn__IdSal__2739D489]
    FOREIGN KEY ([IdSalarie])
    REFERENCES [dbo].[Salaries]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__JournalIn__IdSal__2739D489'
CREATE INDEX [IX_FK__JournalIn__IdSal__2739D489]
ON [dbo].[JournalInterventions]
    ([IdSalarie]);
GO

-- Creating foreign key on [IdArtiste] in table 'Participers'
ALTER TABLE [dbo].[Participers]
ADD CONSTRAINT [FK__Participe__IdArt__7A3223E8]
    FOREIGN KEY ([IdArtiste])
    REFERENCES [dbo].[Artistes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Participe__IdArt__7A3223E8'
CREATE INDEX [IX_FK__Participe__IdArt__7A3223E8]
ON [dbo].[Participers]
    ([IdArtiste]);
GO

-- Creating foreign key on [IdCategorie] in table 'Conviers'
ALTER TABLE [dbo].[Conviers]
ADD CONSTRAINT [FK__Convier__IdCateg__76619304]
    FOREIGN KEY ([IdCategorie])
    REFERENCES [dbo].[CategorieVIPs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Convier__IdCateg__76619304'
CREATE INDEX [IX_FK__Convier__IdCateg__76619304]
ON [dbo].[Conviers]
    ([IdCategorie]);
GO

-- Creating foreign key on [IdArtiste] in table 'Evenements'
ALTER TABLE [dbo].[Evenements]
ADD CONSTRAINT [FK__Evenement__IdArt__3F115E1A]
    FOREIGN KEY ([IdArtiste])
    REFERENCES [dbo].[Artistes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Evenement__IdArt__3F115E1A'
CREATE INDEX [IX_FK__Evenement__IdArt__3F115E1A]
ON [dbo].[Evenements]
    ([IdArtiste]);
GO

-- Creating foreign key on [IdCategorieVIP] in table 'Evenements'
ALTER TABLE [dbo].[Evenements]
ADD CONSTRAINT [FK__Evenement__IdCat__40F9A68C]
    FOREIGN KEY ([IdCategorieVIP])
    REFERENCES [dbo].[CategorieVIPs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Evenement__IdCat__40F9A68C'
CREATE INDEX [IX_FK__Evenement__IdCat__40F9A68C]
ON [dbo].[Evenements]
    ([IdCategorieVIP]);
GO

-- Creating foreign key on [IdEvenement] in table 'Conviers'
ALTER TABLE [dbo].[Conviers]
ADD CONSTRAINT [FK__Convier__IdEvene__756D6ECB]
    FOREIGN KEY ([IdEvenement])
    REFERENCES [dbo].[Evenements]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdTheme] in table 'Evenements'
ALTER TABLE [dbo].[Evenements]
ADD CONSTRAINT [FK__Evenement__IdThe__3E1D39E1]
    FOREIGN KEY ([IdTheme])
    REFERENCES [dbo].[Themes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Evenement__IdThe__3E1D39E1'
CREATE INDEX [IX_FK__Evenement__IdThe__3E1D39E1]
ON [dbo].[Evenements]
    ([IdTheme]);
GO

-- Creating foreign key on [IdVille] in table 'Evenements'
ALTER TABLE [dbo].[Evenements]
ADD CONSTRAINT [FK__Evenement__IdVil__40058253]
    FOREIGN KEY ([IdVille])
    REFERENCES [dbo].[Villes]
        ([CodeInsee])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Evenement__IdVil__40058253'
CREATE INDEX [IX_FK__Evenement__IdVil__40058253]
ON [dbo].[Evenements]
    ([IdVille]);
GO

-- Creating foreign key on [IdEvenement] in table 'Participers'
ALTER TABLE [dbo].[Participers]
ADD CONSTRAINT [FK__Participe__IdEve__793DFFAF]
    FOREIGN KEY ([IdEvenement])
    REFERENCES [dbo].[Evenements]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdAgenceCommunication] in table 'Campagnes'
ALTER TABLE [dbo].[Campagnes]
ADD CONSTRAINT [FK__Campagne__IdAgen__1209AD79]
    FOREIGN KEY ([IdAgenceCommunication])
    REFERENCES [dbo].[Agences]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Campagne__IdAgen__1209AD79'
CREATE INDEX [IX_FK__Campagne__IdAgen__1209AD79]
ON [dbo].[Campagnes]
    ([IdAgenceCommunication]);
GO

-- Creating foreign key on [IdAgenceEvenementiel] in table 'Campagnes'
ALTER TABLE [dbo].[Campagnes]
ADD CONSTRAINT [FK__Campagne__IdAgen__12FDD1B2]
    FOREIGN KEY ([IdAgenceEvenementiel])
    REFERENCES [dbo].[Agences]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Campagne__IdAgen__12FDD1B2'
CREATE INDEX [IX_FK__Campagne__IdAgen__12FDD1B2]
ON [dbo].[Campagnes]
    ([IdAgenceEvenementiel]);
GO

-- Creating foreign key on [IdCampagne] in table 'Evenements'
ALTER TABLE [dbo].[Evenements]
ADD CONSTRAINT [FK__Evenement__IdCam__1F63A897]
    FOREIGN KEY ([IdCampagne])
    REFERENCES [dbo].[Campagnes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Evenement__IdCam__1F63A897'
CREATE INDEX [IX_FK__Evenement__IdCam__1F63A897]
ON [dbo].[Evenements]
    ([IdCampagne]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------