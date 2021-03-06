USE [LocaisReciclagemDatabase]
GO
/****** Object:  User [loc]    Script Date: 21/09/2021 10:53:45 ******/
CREATE USER [loc] FOR LOGIN [loc] WITH DEFAULT_SCHEMA=[loc]
GO
/****** Object:  Schema [loc]    Script Date: 21/09/2021 10:53:45 ******/
CREATE SCHEMA [loc]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 21/09/2021 10:53:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LocaisReciclagem]    Script Date: 21/09/2021 10:53:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LocaisReciclagem](
	[LocalReciclagem_Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Identificacao] [varchar](100) NULL,
	[CEP] [varchar](10) NULL,
	[Logradouro] [varchar](100) NULL,
	[NumeroEndereco] [varchar](10) NULL,
	[Complemento] [varchar](30) NULL,
	[Bairro] [varchar](50) NULL,
	[Cidade] [varchar](50) NULL,
	[Capacidade] [float] NOT NULL,
	[Latitude] [varchar](100) NULL,
	[Longitude] [varchar](100) NULL,
 CONSTRAINT [PK_LocaisReciclagem] PRIMARY KEY CLUSTERED 
(
	[LocalReciclagem_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210917201301_migration01', N'3.1.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210919140256_migration_02', N'3.1.0')
SET IDENTITY_INSERT [dbo].[LocaisReciclagem] ON 

INSERT [dbo].[LocaisReciclagem] ([LocalReciclagem_Id], [Identificacao], [CEP], [Logradouro], [NumeroEndereco], [Complemento], [Bairro], [Cidade], [Capacidade], [Latitude], [Longitude]) VALUES (2, N'LR-Jardim Satélite', N'12230-480', N'R. Estrela Dalva, 135', N'135', N'nenhum', N'Bosque dos Eucaliptos', N'São José dos Campos', 5005, N'-23.235374136291547', N'-45.892523860676754')
INSERT [dbo].[LocaisReciclagem] ([LocalReciclagem_Id], [Identificacao], [CEP], [Logradouro], [NumeroEndereco], [Complemento], [Bairro], [Cidade], [Capacidade], [Latitude], [Longitude]) VALUES (3, N'LR-Altos de Santana', N'12214-010', N'Av. Alto do Rio Doce', N'1075', N'nenhum', N'Jardim Altos de Santana', N'São José dos Campos', 300, N'-23.16918559700298', N'-45.91281670115432')
INSERT [dbo].[LocaisReciclagem] ([LocalReciclagem_Id], [Identificacao], [CEP], [Logradouro], [NumeroEndereco], [Complemento], [Bairro], [Cidade], [Capacidade], [Latitude], [Longitude]) VALUES (11, N'LR-Novo Horizonte', N'12225-751', N'Av. Pres. Tancredo Neves - Parque Novo Horizonte', N'0', N'nenhum', N'Parque Novo Horizonte', N'São José dos Campos', 600.89, N'-23.198443919016206', N'-45.7811527011535')
INSERT [dbo].[LocaisReciclagem] ([LocalReciclagem_Id], [Identificacao], [CEP], [Logradouro], [NumeroEndereco], [Complemento], [Bairro], [Cidade], [Capacidade], [Latitude], [Longitude]) VALUES (12, N'LR-Campo dos Alemães', N'12225-751', N'Av. Pres. Tancredo Neves', N'601', N'nenhum', N'Campo dos Alemães', N'São José dos Campos', 500, N'-23.26723979045332', N'-45.889812945331805')
INSERT [dbo].[LocaisReciclagem] ([LocalReciclagem_Id], [Identificacao], [CEP], [Logradouro], [NumeroEndereco], [Complemento], [Bairro], [Cidade], [Capacidade], [Latitude], [Longitude]) VALUES (13, N'LR-Urbanova', N'00000-000', N'Condomínio Chácara dos Eucaliptos', N'0', N'nenhum', N'Bosque dos Eucaliptos', N'São José dos Campos', 300.4, N'-23.18428920766154', N'-45.923256858925605')
INSERT [dbo].[LocaisReciclagem] ([LocalReciclagem_Id], [Identificacao], [CEP], [Logradouro], [NumeroEndereco], [Complemento], [Bairro], [Cidade], [Capacidade], [Latitude], [Longitude]) VALUES (14, N'LR -  Putim', N' 12228-000', N'R. Nossa Sra. Do Loretto', N' 2 ', NULL, N' Putim', N' São José dos Campos ', 0, N'-23.250430202003162', N'-45.85016502458353')
INSERT [dbo].[LocaisReciclagem] ([LocalReciclagem_Id], [Identificacao], [CEP], [Logradouro], [NumeroEndereco], [Complemento], [Bairro], [Cidade], [Capacidade], [Latitude], [Longitude]) VALUES (15, N'LR-Galo Branco', N'12247-580', N'Av. Benedito Luiz de Medeiros', N'811', N'nenhum', N'Conj. Res. Galo Branco', N'São José dos Campos', 400.35, N'-23.141774284466536', N'-45.77485691649914')
INSERT [dbo].[LocaisReciclagem] ([LocalReciclagem_Id], [Identificacao], [CEP], [Logradouro], [NumeroEndereco], [Complemento], [Bairro], [Cidade], [Capacidade], [Latitude], [Longitude]) VALUES (16, N'LR-Interlagos', N'12229-816', N'R. Ubirajara Raimundo de Souza', N'21', N'nenhum', N'Parque Interlagos', N'São José dos Campos', 450, N'-23.27237997864715', N'-45.86286254533171')
INSERT [dbo].[LocaisReciclagem] ([LocalReciclagem_Id], [Identificacao], [CEP], [Logradouro], [NumeroEndereco], [Complemento], [Bairro], [Cidade], [Capacidade], [Latitude], [Longitude]) VALUES (17, N'LR-Jardim Paulista', N'12215-390', N'R. Ana Gonçalves da Cunha', N'0', N'nenhum', N'Monte Castelo', N'São José dos Campos', 500.1, N'-23.187460882037854', N'-45.87103195697383')
SET IDENTITY_INSERT [dbo].[LocaisReciclagem] OFF
