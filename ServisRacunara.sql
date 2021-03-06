USE [Servis]
GO
/****** Object:  Table [dbo].[Dosije]    Script Date: 6/30/2016 7:40:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dosije](
	[ime] [nvarchar](20) NOT NULL,
	[prezime] [nvarchar](20) NOT NULL,
	[korisnickoIme] [nvarchar](20) NOT NULL,
	[sifra] [nvarchar](20) NOT NULL,
	[osoba] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Dosije_1] PRIMARY KEY CLUSTERED 
(
	[korisnickoIme] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RacunVlasnika]    Script Date: 6/30/2016 7:40:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RacunVlasnika](
	[sifraRacuna] [int] IDENTITY(1,1) NOT NULL,
	[sifraNaloga] [int] NOT NULL,
	[radnik] [nvarchar](20) NOT NULL,
	[vreme] [nvarchar](50) NOT NULL,
	[imePrezime] [nvarchar](50) NULL,
	[brLicne] [int] NULL,
	[mail] [nvarchar](50) NULL,
	[telefon] [nvarchar](50) NULL,
	[sifraRac] [nvarchar](4) NULL,
	[opisKva] [nvarchar](100) NULL,
	[spisPoslova] [nvarchar](100) NULL,
	[rezDel] [nvarchar](100) NULL,
	[cenaUsluga] [nvarchar](50) NULL,
	[cenaDelova] [nvarchar](50) NULL,
	[cenaUkupna] [nvarchar](50) NULL,
 CONSTRAINT [PK_RacunVlasnika] PRIMARY KEY CLUSTERED 
(
	[sifraRacuna] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RadNalog]    Script Date: 6/30/2016 7:40:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RadNalog](
	[sifraNaloga] [int] NOT NULL,
	[radnik] [nvarchar](20) NOT NULL,
	[vreme] [nvarchar](50) NOT NULL,
	[status] [nvarchar](50) NOT NULL,
	[imePrezime] [nvarchar](50) NOT NULL,
	[brLicne] [int] NOT NULL,
	[telefon] [nvarchar](50) NULL,
	[adresa] [nvarchar](50) NULL,
	[mail] [nvarchar](50) NULL,
	[sifraRac] [nvarchar](4) NULL,
	[opisPro] [nvarchar](100) NULL,
	[opisKva] [nvarchar](100) NULL,
	[spisPoslova] [nvarchar](100) NULL,
	[rezDel] [nvarchar](100) NULL,
 CONSTRAINT [PK_RadniNalog] PRIMARY KEY CLUSTERED 
(
	[sifraNaloga] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RezervniDeo]    Script Date: 6/30/2016 7:40:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RezervniDeo](
	[barkod] [int] NOT NULL,
	[marka] [nvarchar](20) NOT NULL,
	[vrsta] [nvarchar](20) NOT NULL,
	[model] [nvarchar](20) NULL,
	[kolicina] [int] NULL,
	[cena] [int] NULL,
 CONSTRAINT [PK_RezervniDeo] PRIMARY KEY CLUSTERED 
(
	[barkod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ZahtevServ]    Script Date: 6/30/2016 7:40:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ZahtevServ](
	[brZahteva] [int] IDENTITY(1,1) NOT NULL,
	[serviser] [nvarchar](20) NOT NULL,
	[datum] [nvarchar](20) NOT NULL,
	[tekst] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_ZahtevServ] PRIMARY KEY CLUSTERED 
(
	[brZahteva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Dosije] ([ime], [prezime], [korisnickoIme], [sifra], [osoba]) VALUES (N'Marko', N'Markovic', N'mare', N'123', N'serviser')
INSERT [dbo].[Dosije] ([ime], [prezime], [korisnickoIme], [sifra], [osoba]) VALUES (N'Milos', N'Milic', N'milos', N'111', N'serviser')
INSERT [dbo].[Dosije] ([ime], [prezime], [korisnickoIme], [sifra], [osoba]) VALUES (N'Nikola ', N'Nikola', N'nikola', N'111', N'radnik')
INSERT [dbo].[Dosije] ([ime], [prezime], [korisnickoIme], [sifra], [osoba]) VALUES (N'Petar', N'Petrovic', N'pera', N'123', N'radnik')
SET IDENTITY_INSERT [dbo].[RacunVlasnika] ON 

INSERT [dbo].[RacunVlasnika] ([sifraRacuna], [sifraNaloga], [radnik], [vreme], [imePrezime], [brLicne], [mail], [telefon], [sifraRac], [opisKva], [spisPoslova], [rezDel], [cenaUsluga], [cenaDelova], [cenaUkupna]) VALUES (9, 1, N'Nikola ', N'26/06/2016', N'Ana Markovic', 1942837, N'ana@mail.com', N'063/123-23-42', N's001', N'Sistem ja pao!

', N'Reinstalacija operativnog sistema

', N'nisu potrebni

', N'3000', N'0', N'3000')
INSERT [dbo].[RacunVlasnika] ([sifraRacuna], [sifraNaloga], [radnik], [vreme], [imePrezime], [brLicne], [mail], [telefon], [sifraRac], [opisKva], [spisPoslova], [rezDel], [cenaUsluga], [cenaDelova], [cenaUkupna]) VALUES (14, 10, N'pera', N'28/06/2016', N'sdf', 123, N'wer', N'123', N'wer', N'
', N'
', N'
', N'3000', N'0', N'3000')
INSERT [dbo].[RacunVlasnika] ([sifraRacuna], [sifraNaloga], [radnik], [vreme], [imePrezime], [brLicne], [mail], [telefon], [sifraRac], [opisKva], [spisPoslova], [rezDel], [cenaUsluga], [cenaDelova], [cenaUkupna]) VALUES (15, 1, N'Nikola ', N'26/06/2016', N'Ana Markovic', 1942837, N'ana@mail.com', N'063/123-23-42', N's001', N'Sistem ja pao!


', N'Reinstalacija operativnog sistema


', N'nisu potrebni


', N'1500', N'12000', N'13500')
SET IDENTITY_INSERT [dbo].[RacunVlasnika] OFF
INSERT [dbo].[RadNalog] ([sifraNaloga], [radnik], [vreme], [status], [imePrezime], [brLicne], [telefon], [adresa], [mail], [sifraRac], [opisPro], [opisKva], [spisPoslova], [rezDel]) VALUES (1, N'Nikola ', N'26/06/2016', N'na popravci', N'Ana Markovic', 1942837, N'063/123-23-42', N'Nade Dimic 3', N'ana@mail.com', N's001', N'Ne moze sistem da se podigne!
', N'Sistem ja pao!

', N'Reinstalacija operativnog sistema

', N'nisu potrebni

')
INSERT [dbo].[RadNalog] ([sifraNaloga], [radnik], [vreme], [status], [imePrezime], [brLicne], [telefon], [adresa], [mail], [sifraRac], [opisPro], [opisKva], [spisPoslova], [rezDel]) VALUES (2, N'Nikola ', N'26/06/2016', N'na popravci', N'Marko Petkovic', 88327461, N'011/444-555', N'Ustanicka 5', N'mare@mail.rs', N's002', N'Graficka kartica ne radi, hardisk zuji...
', N'Graficka i hard disk su pokvareni




', N'Zamene graficke kartice i hard diska




', N'Nova graficka i hard!!!




')
INSERT [dbo].[RadNalog] ([sifraNaloga], [radnik], [vreme], [status], [imePrezime], [brLicne], [telefon], [adresa], [mail], [sifraRac], [opisPro], [opisKva], [spisPoslova], [rezDel]) VALUES (3, N'Petar', N'28/06/2016', N'na popravci', N'ert', 234, N'234', N'wer', N'wer', N'wer', N'wer
', N'ewrewewrewwerwewerwrwer
', N'werwerwer
', N'dssfs
')
INSERT [dbo].[RadNalog] ([sifraNaloga], [radnik], [vreme], [status], [imePrezime], [brLicne], [telefon], [adresa], [mail], [sifraRac], [opisPro], [opisKva], [spisPoslova], [rezDel]) VALUES (6, N'pera', N'28/06/2016', N'na cekanju', N'sdf234', 232323, N'23', N'oipiup', N'opooipo', N'23', N'ijuoi
', NULL, NULL, NULL)
INSERT [dbo].[RadNalog] ([sifraNaloga], [radnik], [vreme], [status], [imePrezime], [brLicne], [telefon], [adresa], [mail], [sifraRac], [opisPro], [opisKva], [spisPoslova], [rezDel]) VALUES (10, N'pera', N'28/06/2016', N'zavrsen', N'sdf', 123, N'123', N'wer', N'wer', N'wer', N'wer
', NULL, NULL, NULL)
INSERT [dbo].[RadNalog] ([sifraNaloga], [radnik], [vreme], [status], [imePrezime], [brLicne], [telefon], [adresa], [mail], [sifraRac], [opisPro], [opisKva], [spisPoslova], [rezDel]) VALUES (12, N'pera', N'28/06/2016', N'na cekanju', N'sgdf', 432423, N'234', N'wer', N'werwe', N'wr', N'werwe
', NULL, NULL, NULL)
INSERT [dbo].[RezervniDeo] ([barkod], [marka], [vrsta], [model], [kolicina], [cena]) VALUES (23432, N'Msi', N'maticna', N'2434', 3, 1234)
INSERT [dbo].[RezervniDeo] ([barkod], [marka], [vrsta], [model], [kolicina], [cena]) VALUES (11111111, N'Amd', N'graficka', N'GTX 9600', 3, 45000)
INSERT [dbo].[RezervniDeo] ([barkod], [marka], [vrsta], [model], [kolicina], [cena]) VALUES (11223344, N'Asus', N'maticna', N'Speed 5x', 2, 14000)
INSERT [dbo].[RezervniDeo] ([barkod], [marka], [vrsta], [model], [kolicina], [cena]) VALUES (12341234, N'Intel', N'procesor', N'i7 3.9 GHz', 2, 55000)
INSERT [dbo].[RezervniDeo] ([barkod], [marka], [vrsta], [model], [kolicina], [cena]) VALUES (12345678, N'Intel', N'procesor', N'i5 3.9Ghz', 6, 15000)
INSERT [dbo].[RezervniDeo] ([barkod], [marka], [vrsta], [model], [kolicina], [cena]) VALUES (22222222, N'Amd', N'graficka', N'GT 3200', 10, 21000)
INSERT [dbo].[RezervniDeo] ([barkod], [marka], [vrsta], [model], [kolicina], [cena]) VALUES (1122334455, N'Asus', N'maticna', N'Super speed', 5, 23000)
SET IDENTITY_INSERT [dbo].[ZahtevServ] ON 

INSERT [dbo].[ZahtevServ] ([brZahteva], [serviser], [datum], [tekst]) VALUES (10, N'Marko', N'27/06/2016', N'Trema mi CPU
')
INSERT [dbo].[ZahtevServ] ([brZahteva], [serviser], [datum], [tekst]) VALUES (11, N'Marko', N'27/06/2016', N'GTX
')
INSERT [dbo].[ZahtevServ] ([brZahteva], [serviser], [datum], [tekst]) VALUES (13, N'mare', N'28/06/2016', N'Treba mi nova graficka
')
INSERT [dbo].[ZahtevServ] ([brZahteva], [serviser], [datum], [tekst]) VALUES (14, N'mare', N'28/06/2016', N'erterterter
')
SET IDENTITY_INSERT [dbo].[ZahtevServ] OFF
ALTER TABLE [dbo].[RacunVlasnika]  WITH CHECK ADD  CONSTRAINT [FK_RacunVlasnika_RadNalog] FOREIGN KEY([sifraNaloga])
REFERENCES [dbo].[RadNalog] ([sifraNaloga])
GO
ALTER TABLE [dbo].[RacunVlasnika] CHECK CONSTRAINT [FK_RacunVlasnika_RadNalog]
GO
