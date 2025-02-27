USE [GsbCampagnes]
GO
/****** Object:  Table [dbo].[Agence]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agence](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Libelle] [varchar](150) NOT NULL,
	[Adresse] [varchar](150) NOT NULL,
	[Email] [varchar](150) NOT NULL,
	[SiteWeb] [varchar](150) NOT NULL,
	[CodeInseeVille] [char](5) NOT NULL,
	[TypeAgence] [varchar](150) NULL,
	[Telephone] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Artiste]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Artiste](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](150) NOT NULL,
	[SiteWeb] [varchar](150) NOT NULL,
	[IdCourantArtistique] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Campagne]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Campagne](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Intitule] [varchar](150) NOT NULL,
	[Objectif] [varchar](150) NOT NULL,
	[DateDebut] [date] NOT NULL,
	[DateFin] [date] NOT NULL,
	[IdTypePublic] [int] NOT NULL,
	[IdSalarie] [int] NOT NULL,
	[IdAgenceCommunication] [int] NULL,
	[IdAgenceEvenementiel] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategorieVIP]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategorieVIP](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Libelle] [varchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Convier]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Convier](
	[IdEvenement] [int] NOT NULL,
	[IdCategorieVIP] [int] NOT NULL,
	[Message] [varchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEvenement] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CourantArtistique]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourantArtistique](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Libelle] [varchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Evenement]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evenement](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DateDebut] [date] NOT NULL,
	[DateFin] [date] NOT NULL,
	[Intitule] [varchar](150) NOT NULL,
	[IdTheme] [int] NOT NULL,
	[CodeInseeVille] [char](5) NOT NULL,
	[IdCategorieVIP] [int] NOT NULL,
	[IdCampagne] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JournalIntervention]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JournalIntervention](
	[Id] [int] NOT NULL,
	[NomTable] [varchar](150) NOT NULL,
	[OperationEffetctue] [varchar](150) NOT NULL,
	[DateHeure] [datetime] NOT NULL,
	[ReferenceEnregistrement] [varchar](150) NOT NULL,
	[IdSalarie] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Participer]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Participer](
	[IdEvenement] [int] NOT NULL,
	[IdArtiste] [int] NOT NULL,
	[Cachet] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEvenement] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Libelle] [varchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salarie]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salarie](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](150) NULL,
	[Prenom] [varchar](150) NULL,
	[Login] [varchar](150) NULL,
	[Mdp] [varchar](150) NULL,
	[IdRole] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Theme]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Theme](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Libelle] [varchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypePublic]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypePublic](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Libelle] [varchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ville]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ville](
	[CodeInsee] [char](5) NOT NULL,
	[Nom] [varchar](150) NOT NULL,
	[Arrondissement] [int] NOT NULL,
	[CodePostal] [varchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CodeInsee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VIP]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VIP](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](150) NOT NULL,
	[AdressePostal] [varchar](150) NOT NULL,
	[Email] [varchar](150) NOT NULL,
	[IdCategorieVIP] [int] NOT NULL,
	[CodeInseeVille] [char](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Agence] ON 
GO
INSERT [dbo].[Agence] ([Id], [Libelle], [Adresse], [Email], [SiteWeb], [CodeInseeVille], [TypeAgence], [Telephone]) VALUES (1, N'Riofluo Activité', N'7 rue jules Ferry', N'sophie.henry@riofluo.com', N'http:// www.riofluo.com', N'9225 ', N'C', N'0951028276')
GO
INSERT [dbo].[Agence] ([Id], [Libelle], [Adresse], [Email], [SiteWeb], [CodeInseeVille], [TypeAgence], [Telephone]) VALUES (2, N'Novell’art', N'6, rue Déodat de Severac', N'stephanie.novello@novellart.com', N'http:// www.novellart.com', N'7010 ', N'E', N'0686214715')
GO
INSERT [dbo].[Agence] ([Id], [Libelle], [Adresse], [Email], [SiteWeb], [CodeInseeVille], [TypeAgence], [Telephone]) VALUES (3, N'LJ communication', N'16 rue de l''arcade', N'paul.pierrat@ljcom.net', N'http:// www.ljcom.net', N'5023 ', N'C', N'0145038989')
GO
INSERT [dbo].[Agence] ([Id], [Libelle], [Adresse], [Email], [SiteWeb], [CodeInseeVille], [TypeAgence], [Telephone]) VALUES (4, N'Image & stratégie', N'30 rue Fortuny', N'bruno.fuchs@image-strategie.com', N'http:// www.image-strategie.com', N'3321 ', N'E', N'0000000000')
GO
INSERT [dbo].[Agence] ([Id], [Libelle], [Adresse], [Email], [SiteWeb], [CodeInseeVille], [TypeAgence], [Telephone]) VALUES (8, N'dulca', N'aaaaaaa', N'vdvfvfdfdvf', N'dsdgfdgddxds', N'10387', N'E', N'0214527549')
GO
INSERT [dbo].[Agence] ([Id], [Libelle], [Adresse], [Email], [SiteWeb], [CodeInseeVille], [TypeAgence], [Telephone]) VALUES (9, N'test', N'test', N'test', N'tset', N'10333', N'C', N'0000000000')
GO
SET IDENTITY_INSERT [dbo].[Agence] OFF
GO
SET IDENTITY_INSERT [dbo].[Artiste] ON 
GO
INSERT [dbo].[Artiste] ([Id], [Nom], [SiteWeb], [IdCourantArtistique]) VALUES (1, N'Skull', N'www.skull.com', 1)
GO
INSERT [dbo].[Artiste] ([Id], [Nom], [SiteWeb], [IdCourantArtistique]) VALUES (2, N'Hopare', N'www.hopare.com', 1)
GO
INSERT [dbo].[Artiste] ([Id], [Nom], [SiteWeb], [IdCourantArtistique]) VALUES (3, N'Shaka', N'www.shaka1.fr', 1)
GO
INSERT [dbo].[Artiste] ([Id], [Nom], [SiteWeb], [IdCourantArtistique]) VALUES (4, N'Piccinini', N'www.piccinini.fr', 2)
GO
INSERT [dbo].[Artiste] ([Id], [Nom], [SiteWeb], [IdCourantArtistique]) VALUES (5, N'Orlan', N'http://www.orlan.eu', 2)
GO
INSERT [dbo].[Artiste] ([Id], [Nom], [SiteWeb], [IdCourantArtistique]) VALUES (6, N'Stelarc', N'http://www.stelarc.va.com.au', 2)
GO
INSERT [dbo].[Artiste] ([Id], [Nom], [SiteWeb], [IdCourantArtistique]) VALUES (7, N'Bruno Montpied', N'http://www.montpied.fr', 3)
GO
INSERT [dbo].[Artiste] ([Id], [Nom], [SiteWeb], [IdCourantArtistique]) VALUES (8, N'Agusil', N'https://www.facebook.com/marc.gonzalezlopez.9', 4)
GO
INSERT [dbo].[Artiste] ([Id], [Nom], [SiteWeb], [IdCourantArtistique]) VALUES (9, N'Bibi', N'http://www.bibi.fr/', 6)
GO
INSERT [dbo].[Artiste] ([Id], [Nom], [SiteWeb], [IdCourantArtistique]) VALUES (10, N'Pierrick Sorin', N'https://www.facebook.com/PierrickSorinOfficiel', 6)
GO
INSERT [dbo].[Artiste] ([Id], [Nom], [SiteWeb], [IdCourantArtistique]) VALUES (11, N'Cécile Plaisance', N'http://www.cecileplaisance.com', 6)
GO
SET IDENTITY_INSERT [dbo].[Artiste] OFF
GO
SET IDENTITY_INSERT [dbo].[Campagne] ON 
GO
INSERT [dbo].[Campagne] ([Id], [Intitule], [Objectif], [DateDebut], [DateFin], [IdTypePublic], [IdSalarie], [IdAgenceCommunication], [IdAgenceEvenementiel]) VALUES (1, N'Médicaments sans médecin : attention, danger !', N'Les dangers de l’achat de médicaments sur Internet', CAST(N'2023-01-01' AS Date), CAST(N'2023-03-31' AS Date), 3, 3, NULL, 8)
GO
INSERT [dbo].[Campagne] ([Id], [Intitule], [Objectif], [DateDebut], [DateFin], [IdTypePublic], [IdSalarie], [IdAgenceCommunication], [IdAgenceEvenementiel]) VALUES (2, N'Prendre ou reprendre le contrôle de son asthme', N'Apprendre les gestes simples pour maîtriser les symptômes et prévenir les crises', CAST(N'2023-01-31' AS Date), CAST(N'2023-04-15' AS Date), 1, 2, 1, NULL)
GO
SET IDENTITY_INSERT [dbo].[Campagne] OFF
GO
SET IDENTITY_INSERT [dbo].[CategorieVIP] ON 
GO
INSERT [dbo].[CategorieVIP] ([Id], [Libelle]) VALUES (1, N'Journaliste')
GO
INSERT [dbo].[CategorieVIP] ([Id], [Libelle]) VALUES (2, N'Médecin')
GO
INSERT [dbo].[CategorieVIP] ([Id], [Libelle]) VALUES (3, N'Pharmacien')
GO
INSERT [dbo].[CategorieVIP] ([Id], [Libelle]) VALUES (4, N'Ministre')
GO
INSERT [dbo].[CategorieVIP] ([Id], [Libelle]) VALUES (5, N'Député')
GO
SET IDENTITY_INSERT [dbo].[CategorieVIP] OFF
GO
SET IDENTITY_INSERT [dbo].[CourantArtistique] ON 
GO
INSERT [dbo].[CourantArtistique] ([Id], [Libelle]) VALUES (1, N'Street art')
GO
INSERT [dbo].[CourantArtistique] ([Id], [Libelle]) VALUES (2, N'Bio art')
GO
INSERT [dbo].[CourantArtistique] ([Id], [Libelle]) VALUES (3, N'Art Brut')
GO
INSERT [dbo].[CourantArtistique] ([Id], [Libelle]) VALUES (4, N'Action painting')
GO
INSERT [dbo].[CourantArtistique] ([Id], [Libelle]) VALUES (5, N'Optical art')
GO
INSERT [dbo].[CourantArtistique] ([Id], [Libelle]) VALUES (6, N'Installation')
GO
SET IDENTITY_INSERT [dbo].[CourantArtistique] OFF
GO
SET IDENTITY_INSERT [dbo].[Evenement] ON 
GO
INSERT [dbo].[Evenement] ([Id], [DateDebut], [DateFin], [Intitule], [IdTheme], [CodeInseeVille], [IdCategorieVIP], [IdCampagne]) VALUES (20, CAST(N'2027-02-27' AS Date), CAST(N'2028-02-27' AS Date), N'bbbbb', 3, N'1004 ', 5, 1)
GO
SET IDENTITY_INSERT [dbo].[Evenement] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 
GO
INSERT [dbo].[Role] ([Id], [Libelle]) VALUES (1, N'Directeur financier')
GO
INSERT [dbo].[Role] ([Id], [Libelle]) VALUES (2, N'Directeur service communication')
GO
INSERT [dbo].[Role] ([Id], [Libelle]) VALUES (3, N'Employé service de communication')
GO
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[Salarie] ON 
GO
INSERT [dbo].[Salarie] ([Id], [Nom], [Prenom], [Login], [Mdp], [IdRole]) VALUES (1, N'BONDY', N'Frédéric', N'fbondy', N'$2a$12$q4lg9678.KkRctYI570GcuCu8lEfJxNzf68Ek.HBdmW.b1uBHDrFa', 3)
GO
INSERT [dbo].[Salarie] ([Id], [Nom], [Prenom], [Login], [Mdp], [IdRole]) VALUES (2, N'COLLET', N'Alizée', N'acollet', N'$2a$12$q4lg9678.KkRctYI570GcuCu8lEfJxNzf68Ek.HBdmW.b1uBHDrFa', 3)
GO
INSERT [dbo].[Salarie] ([Id], [Nom], [Prenom], [Login], [Mdp], [IdRole]) VALUES (3, N'THARAUD', N'Pascale', N'ptharaud', N'$2a$12$q4lg9678.KkRctYI570GcuCu8lEfJxNzf68Ek.HBdmW.b1uBHDrFa', 3)
GO
INSERT [dbo].[Salarie] ([Id], [Nom], [Prenom], [Login], [Mdp], [IdRole]) VALUES (4, N'GRUNY', N'Paul', N'pgruny', N'$2a$12$q4lg9678.KkRctYI570GcuCu8lEfJxNzf68Ek.HBdmW.b1uBHDrFa', 3)
GO
INSERT [dbo].[Salarie] ([Id], [Nom], [Prenom], [Login], [Mdp], [IdRole]) VALUES (5, N'NORMAN', N'Vincent', N'vnorman,', N'$2a$12$q4lg9678.KkRctYI570GcuCu8lEfJxNzf68Ek.HBdmW.b1uBHDrFa', 3)
GO
SET IDENTITY_INSERT [dbo].[Salarie] OFF
GO
SET IDENTITY_INSERT [dbo].[Theme] ON 
GO
INSERT [dbo].[Theme] ([Id], [Libelle]) VALUES (1, N'Réalisation oeuvre sur le sol')
GO
INSERT [dbo].[Theme] ([Id], [Libelle]) VALUES (2, N'Emballage de monument')
GO
INSERT [dbo].[Theme] ([Id], [Libelle]) VALUES (3, N'Réalisation de toile géante par plusieurs artistes')
GO
SET IDENTITY_INSERT [dbo].[Theme] OFF
GO
SET IDENTITY_INSERT [dbo].[TypePublic] ON 
GO
INSERT [dbo].[TypePublic] ([Id], [Libelle]) VALUES (1, N'Tout public')
GO
INSERT [dbo].[TypePublic] ([Id], [Libelle]) VALUES (2, N'Enfants')
GO
INSERT [dbo].[TypePublic] ([Id], [Libelle]) VALUES (3, N'Adolescents')
GO
INSERT [dbo].[TypePublic] ([Id], [Libelle]) VALUES (4, N'Jeunes adultes')
GO
INSERT [dbo].[TypePublic] ([Id], [Libelle]) VALUES (5, N'Adultes')
GO
INSERT [dbo].[TypePublic] ([Id], [Libelle]) VALUES (6, N'Séniors')
GO
INSERT [dbo].[TypePublic] ([Id], [Libelle]) VALUES (7, N'Femmes')
GO
INSERT [dbo].[TypePublic] ([Id], [Libelle]) VALUES (8, N'Hommes')
GO
SET IDENTITY_INSERT [dbo].[TypePublic] OFF
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'1004 ', N'Ambérieu-en-Bugey', 0, N'01500')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'10081', N'La Chapelle-Saint-Luc', 0, N'10600')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'10323', N'Romilly-sur-Seine', 0, N'10100')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'1033 ', N'Bellegarde-sur-Valserine', 0, N'01200')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'10333', N'Saint-André-les-Vergers', 0, N'10120')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'10387', N'Troyes', 0, N'10000')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'1053 ', N'Bourg-en-Bresse', 0, N'01000')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'11069', N'Carcassonne', 0, N'11000')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'11076', N'Castelnaudary', 0, N'11400')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'11262', N'Narbonne', 0, N'11100')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'12145', N'Millau', 0, N'12100')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'12202', N'Rodez', 0, N'12000')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'12300', N'Villefranche-de-Rouergue', 0, N'12200')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'1283 ', N'Oyonnax', 0, N'01100')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'13001', N'Aix-en-Provence', 0, N'13100')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'13002', N'Allauch', 0, N'13190')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'13004', N'Arles', 0, N'13104')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'13005', N'Aubagne', 0, N'13400')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'13007', N'Auriol', 0, N'13390')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'13014', N'Berre-l''Étang', 0, N'13130')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'13015', N'Bouc-Bel-Air', 0, N'13320')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'13026', N'Châteauneuf-les-Martigues', 0, N'13220')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'13027', N'Châteaurenard', 0, N'13160')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'13028', N'La Ciotat', 0, N'13600')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'13039', N'Fos-sur-Mer', 0, N'13270')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'13041', N'Gardanne', 0, N'13120')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'13047', N'Istres', 0, N'13800')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'13054', N'Marignane', 0, N'13700')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'13056', N'Martigues', 0, N'13500')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'13063', N'Miramas', 0, N'13140')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'13071', N'Pennes-Mirabeau', 0, N'13170')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'13075', N'Plan-de-Cuques', 0, N'13380')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'13077', N'Port-de-Bouc', 0, N'13110')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'13081', N'Rognac', 0, N'13340')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'13097', N'Saint-Martin-de-Crau', 0, N'13310')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'13103', N'Salon-de-Provence', 0, N'13300')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'13108', N'Tarascon', 0, N'13150')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'13117', N'Vitrolles', 0, N'13127')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'2168 ', N'Château-Thierry', 0, N'02400')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'2173 ', N'Chauny', 0, N'02300')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'2408 ', N'Laon', 0, N'02000')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'2691 ', N'Saint-Quentin', 0, N'02100')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'2722 ', N'Soissons', 0, N'02200')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'2738 ', N'Tergnier', 0, N'02700')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'3095 ', N'Cusset', 0, N'03300')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'3185 ', N'Montluçon', 0, N'03100')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'3190 ', N'Moulins', 0, N'03000')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'3310 ', N'Vichy', 0, N'03200')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'3321 ', N'Yzeure', 0, N'03400')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'4070 ', N'Digne-les-Bains', 0, N'04000')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'4112 ', N'Manosque', 0, N'04100')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'5023 ', N'Briançon', 0, N'05100')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'5061 ', N'Gap', 0, N'05000')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'6004 ', N'Antibes', 0, N'06600')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'6012 ', N'Beausoleil', 0, N'06240')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'6027 ', N'Cagnes-sur-Mer', 0, N'06800')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'6029 ', N'Cannes', 0, N'06400')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'6030 ', N'Le Cannet', 0, N'06110')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'6033 ', N'Carros', 0, N'06510')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'6069 ', N'Grasse', 0, N'06130')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'6079 ', N'Mandelieu-la-Napoule', 0, N'06210')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'6083 ', N'Menton', 0, N'06500')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'6085 ', N'Mougins', 0, N'06250')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'6088 ', N'Nice', 0, N'06000')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'6104 ', N'Roquebrune-Cap-Martin', 0, N'06190')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'6123 ', N'Saint-Laurent-du-Var', 0, N'06700')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'6152 ', N'Valbonne', 0, N'06560')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'6155 ', N'Vallauris', 0, N'06220')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'6157 ', N'Vence', 0, N'06140')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'6161 ', N'Villeneuve-Loubet', 0, N'06270')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'7010 ', N'Annonay', 0, N'07100')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'7019 ', N'Aubenas', 0, N'07200')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'8105 ', N'Charleville-Mézières', 0, N'08090')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'8409 ', N'Sedan', 0, N'08200')
GO
INSERT [dbo].[Ville] ([CodeInsee], [Nom], [Arrondissement], [CodePostal]) VALUES (N'9225 ', N'Pamiers', 0, N'09100')
GO
SET IDENTITY_INSERT [dbo].[VIP] ON 
GO
INSERT [dbo].[VIP] ([Id], [Nom], [AdressePostal], [Email], [IdCategorieVIP], [CodeInseeVille]) VALUES (1, N'jean', N'10 rue des nouilles', N'jeanlanouille@gmail.com', 5, N'9225 ')
GO
INSERT [dbo].[VIP] ([Id], [Nom], [AdressePostal], [Email], [IdCategorieVIP], [CodeInseeVille]) VALUES (2, N'Marc', N'10 rue des chèvres', N'marclachevre@gmail.com', 2, N'9225 ')
GO
INSERT [dbo].[VIP] ([Id], [Nom], [AdressePostal], [Email], [IdCategorieVIP], [CodeInseeVille]) VALUES (3, N'ALEXI', N'SANCHEZ', N'SANCHEZ.cclcl@outlook.fr', 2, N'2408 ')
GO
SET IDENTITY_INSERT [dbo].[VIP] OFF
GO
ALTER TABLE [dbo].[Agence]  WITH CHECK ADD FOREIGN KEY([CodeInseeVille])
REFERENCES [dbo].[Ville] ([CodeInsee])
GO
ALTER TABLE [dbo].[Artiste]  WITH CHECK ADD FOREIGN KEY([IdCourantArtistique])
REFERENCES [dbo].[CourantArtistique] ([Id])
GO
ALTER TABLE [dbo].[Campagne]  WITH CHECK ADD FOREIGN KEY([IdSalarie])
REFERENCES [dbo].[Salarie] ([Id])
GO
ALTER TABLE [dbo].[Campagne]  WITH CHECK ADD FOREIGN KEY([IdTypePublic])
REFERENCES [dbo].[TypePublic] ([Id])
GO
ALTER TABLE [dbo].[Campagne]  WITH CHECK ADD FOREIGN KEY([IdAgenceCommunication])
REFERENCES [dbo].[Agence] ([Id])
GO
ALTER TABLE [dbo].[Campagne]  WITH CHECK ADD FOREIGN KEY([IdAgenceEvenementiel])
REFERENCES [dbo].[Agence] ([Id])
GO
ALTER TABLE [dbo].[Convier]  WITH CHECK ADD FOREIGN KEY([IdCategorieVIP])
REFERENCES [dbo].[CategorieVIP] ([Id])
GO
ALTER TABLE [dbo].[Convier]  WITH CHECK ADD FOREIGN KEY([IdEvenement])
REFERENCES [dbo].[Evenement] ([Id])
GO
ALTER TABLE [dbo].[Evenement]  WITH CHECK ADD  CONSTRAINT [FK__Evenement__CodeI__5832119F] FOREIGN KEY([CodeInseeVille])
REFERENCES [dbo].[Ville] ([CodeInsee])
GO
ALTER TABLE [dbo].[Evenement] CHECK CONSTRAINT [FK__Evenement__CodeI__5832119F]
GO
ALTER TABLE [dbo].[Evenement]  WITH CHECK ADD FOREIGN KEY([IdCampagne])
REFERENCES [dbo].[Campagne] ([Id])
GO
ALTER TABLE [dbo].[Evenement]  WITH CHECK ADD FOREIGN KEY([IdCategorieVIP])
REFERENCES [dbo].[CategorieVIP] ([Id])
GO
ALTER TABLE [dbo].[Evenement]  WITH CHECK ADD FOREIGN KEY([IdTheme])
REFERENCES [dbo].[Theme] ([Id])
GO
ALTER TABLE [dbo].[JournalIntervention]  WITH CHECK ADD FOREIGN KEY([IdSalarie])
REFERENCES [dbo].[Salarie] ([Id])
GO
ALTER TABLE [dbo].[Participer]  WITH CHECK ADD FOREIGN KEY([IdArtiste])
REFERENCES [dbo].[Artiste] ([Id])
GO
ALTER TABLE [dbo].[Participer]  WITH CHECK ADD FOREIGN KEY([IdEvenement])
REFERENCES [dbo].[Evenement] ([Id])
GO
ALTER TABLE [dbo].[Salarie]  WITH CHECK ADD FOREIGN KEY([IdRole])
REFERENCES [dbo].[Role] ([Id])
GO
ALTER TABLE [dbo].[VIP]  WITH CHECK ADD FOREIGN KEY([IdCategorieVIP])
REFERENCES [dbo].[CategorieVIP] ([Id])
GO
ALTER TABLE [dbo].[VIP]  WITH CHECK ADD FOREIGN KEY([CodeInseeVille])
REFERENCES [dbo].[Ville] ([CodeInsee])
GO
/****** Object:  StoredProcedure [dbo].[sp_agence_add]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_agence_add] 
@Libelle Varchar(150),
@Adresse varchar(150),
@Telephone VARCHAR(20),
@Email varchar(150),
@SiteWeb varchar(150),
@TypeAgence char(1),
@CodeInseeVille char(5)
AS
BEGIN
	
	INSERT INTO Agence(Libelle,Adresse,Telephone,Email,SiteWeb,TypeAgence,CodeInseeVille) VALUES (@Libelle,@Adresse,@Telephone,@Email,@SiteWeb, @TypeAgence ,@CodeInseeVille)

END;
GO
/****** Object:  StoredProcedure [dbo].[sp_agence_delete]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_agence_delete]
@id int
AS
BEGIN
	DELETE FROM Agence WHERE id = @id
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_agence_update]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_agence_update]
@Id INT,
@Libelle varchar(150),
@Adresse varchar(150),
@Telephone VARCHAR(20),
@Email varchar(150),
@SiteWeb varchar(150),
@TypeAgence char(1),
@CodeInseeVille CHAR(5)
AS
BEGIN
	
	UPDATE Agence SET 
	Libelle = @Libelle,
	Adresse = @Adresse,
	Telephone = @Telephone,
	Email = @Email,
	SiteWeb = @SiteWeb,
	TypeAgence = @TypeAgence,
	CodeInseeVille = @CodeInseeVille
	WHERE Id = @Id

END;
GO
/****** Object:  StoredProcedure [dbo].[sp_artiste_add]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_artiste_add] 
@Nom varchar(150),
@SiteWeb varchar(150),
@idCourantArtistique INT
AS
BEGIN 

	INSERT INTO Artiste(Nom,SiteWeb,idCourantArtistique)
	VALUES (@Nom,@SiteWeb,@idCourantArtistique);

END;
GO
/****** Object:  StoredProcedure [dbo].[sp_artiste_delete]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_artiste_delete]
     @Id INT
AS 
BEGIN
            DELETE FROM Artiste
               WHERE Id = @Id;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_artiste_update]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_artiste_update]
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
GO
/****** Object:  StoredProcedure [dbo].[sp_campagne_add]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[sp_campagne_add](@Intitule varchar(150) , @Objectif varchar(150) , @dateDebut date , @dateFin date , @IdSalarie int, @IdTypePublic int , @IdAgenceCommunication int , @IdAgenceEvenementiel int )
As
Begin

Insert Into Campagne(Intitule , Objectif , dateDebut , dateFin , IdSalarie , IdTypePublic , IdAgenceCommunication , IdAgenceEvenementiel) Values (@Intitule , @Objectif , @dateDebut , @dateFin , @IdSalarie , @IdTypePublic , @IdAgenceCommunication , @IdAgenceEvenementiel);

End;
GO
/****** Object:  StoredProcedure [dbo].[sp_campagne_delete]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[sp_campagne_delete](@Id int)
As
Begin

Delete From Campagne
Where Id = @Id;

End;
GO
/****** Object:  StoredProcedure [dbo].[sp_campagne_update]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[sp_campagne_update](@Id int , @Intitule varchar(150) , @Objectif varchar(150) , @dateDebut date , @dateFin date , @IdSalarie int, @IdTypePublic int , @IdAgenceCommunication int , @IdAgenceEvenementiel int)
As
Begin

Update Campagne
Set Intitule = @Intitule , Objectif = @Objectif, dateDebut = @dateDebut , dateFin = @dateFin , IdSalarie = @IdSalarie , IdTypePublic = @IdTypePublic , IdAgenceCommunication = @IdAgenceCommunication , IdAgenceEvenementiel = @IdAgenceEvenementiel
where Id = @Id;

End;
GO
/****** Object:  StoredProcedure [dbo].[sp_categorieVIP_add]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[sp_categorieVIP_add](@Libelle varchar(150))
As
Begin

Insert Into CategorieVIP(Libelle) Values (@Libelle);

End;

GO
/****** Object:  StoredProcedure [dbo].[sp_categorieVIP_delete]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[sp_categorieVIP_delete](@Id int)
As
Begin

Delete From CategorieVIP
Where Id = @Id;

End;
GO
/****** Object:  StoredProcedure [dbo].[sp_categorieVIP_edit]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[sp_categorieVIP_edit](@Id int , @Libelle varchar(150))
As
Begin

Update CategorieVIP
Set Libelle = @Libelle
where Id = @Id;

End;

GO
/****** Object:  StoredProcedure [dbo].[sp_CourantArtistique_add]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CourantArtistique_add] 
@Libelle varchar(150)

AS
BEGIN 

	INSERT INTO CourantArtistique(Libelle)
	VALUES (@Libelle);

END;
GO
/****** Object:  StoredProcedure [dbo].[sp_CourantArtistique_delete]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CourantArtistique_delete]
     @Id INT
AS 
BEGIN
            DELETE FROM CourantArtistique
               WHERE Id = @Id;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_evenement_add]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[sp_evenement_add] (@DateDebut date, @DateFin date, @intitule varchar(150), @IdTheme int, @CodeInseeVille char(5), @IdCategorieVIP int, @IdCampagne int) 
AS 
BEGIN
	INSERT INTO Evenement(DateDebut, DateFin, intitule, IdTheme, CodeInseeVille, IdCategorieVIP, IdCampagne) 
	VALUES (@DateDebut, @DateFin, @intitule, @IdTheme, @CodeInseeVille, @IdCategorieVIP, @IdCampagne)
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_evenement_delete]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[sp_evenement_delete](@Id int)
AS 
BEGIN 
	DELETE FROM Evenement
	WHERE Id=@Id 
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_evenement_update]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_evenement_update](@Id int, @DateDebut date, @DateFin date, @intitule varchar(150), @IdTheme int, @CodeInseeVille char(5), @IdCategorieVIP int, @IdCampagne int)
AS
BEGIN
	UPDATE Evenement SET DateDebut=@DateDebut, DateFin=@DateFin, intitule=@intitule, IdTheme=@IdTheme, CodeInseeVille=@CodeInseeVille, IdCategorieVIP=@IdCategorieVIP, IdCampagne=@IdCampagne
	WHERE Id=@Id
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_vip_add]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_vip_add] 
@Nom varchar(150),
@AdressePostal varchar(150),
@Email varchar(150),
@idCategorieVIP INT,
@CodeInseeVille char(5)
AS
BEGIN 

	INSERT INTO VIP(Nom,AdressePostal,Email,IdCategorieVIP,CodeInseeVille)
	VALUES (@Nom, @AdressePostal, @Email, @idCategorieVIP, @CodeInseeVille);

END;
GO
/****** Object:  StoredProcedure [dbo].[sp_vip_delete]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_vip_delete]
     @Id INT
AS 
BEGIN
            DELETE FROM VIP
               WHERE Id = @Id;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_vip_update]    Script Date: 27/02/2025 11:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_vip_update]
@Id INT,
@Nom varchar(150),
@AdressePostal varchar(150),
@Email varchar(150),
@idCategorieVIP INT,
@CodeInseeVille char(5)
AS
BEGIN

	Update  VIP	
	SET
		Nom = @Nom,
		AdressePostal = @AdressePostal,
		Email = @Email,
		idCategorieVIP = @idCategorieVIP,
		CodeInseeVille = @CodeInseeVille
	WHERE Id = @Id; 
END
GO
