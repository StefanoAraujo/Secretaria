USE [master]
GO
/****** Object:  Database [secretaria]    Script Date: 01/17/2016 13:14:41 ******/
CREATE DATABASE [secretaria] ON  PRIMARY 
( NAME = N'secretaria', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.CRONOS\MSSQL\DATA\secretaria.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'secretaria_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.CRONOS\MSSQL\DATA\secretaria_log.LDF' , SIZE = 576KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [secretaria] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [secretaria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [secretaria] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [secretaria] SET ANSI_NULLS OFF
GO
ALTER DATABASE [secretaria] SET ANSI_PADDING OFF
GO
ALTER DATABASE [secretaria] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [secretaria] SET ARITHABORT OFF
GO
ALTER DATABASE [secretaria] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [secretaria] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [secretaria] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [secretaria] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [secretaria] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [secretaria] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [secretaria] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [secretaria] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [secretaria] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [secretaria] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [secretaria] SET  ENABLE_BROKER
GO
ALTER DATABASE [secretaria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [secretaria] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [secretaria] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [secretaria] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [secretaria] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [secretaria] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [secretaria] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [secretaria] SET  READ_WRITE
GO
ALTER DATABASE [secretaria] SET RECOVERY FULL
GO
ALTER DATABASE [secretaria] SET  MULTI_USER
GO
ALTER DATABASE [secretaria] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [secretaria] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'secretaria', N'ON'
GO
USE [secretaria]
GO
/****** Object:  Table [dbo].[usuarios_comun]    Script Date: 01/17/2016 13:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios_comun](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](40) NOT NULL,
	[funcionario_ID] [int] NOT NULL,
 CONSTRAINT [PK_usuarios_comun_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[funcionario_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [usuarios_comun$ID_UNIQUE] UNIQUE NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [fk_usuarios_comun_funcionário1_idx] ON [dbo].[usuarios_comun] 
(
	[funcionario_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'secretaria.usuarios_comun' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'usuarios_comun'
GO
/****** Object:  Table [dbo].[turma]    Script Date: 01/17/2016 13:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[turma](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Curso] [varchar](20) NOT NULL,
	[Qut_Max] [int] NOT NULL,
	[Qut_Min] [int] NOT NULL,
	[Criador_ID] [int] NOT NULL,
	[professor_ID] [int] NOT NULL,
 CONSTRAINT [PK_turma_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [fk_turma_login_senha1_idx] ON [dbo].[turma] 
(
	[Criador_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [fk_turma_professor1_idx] ON [dbo].[turma] 
(
	[professor_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'secretaria.turma' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'turma'
GO
/****** Object:  Table [dbo].[professor]    Script Date: 01/17/2016 13:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[professor](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](40) NOT NULL,
	[Qualificação] [varchar](60) NOT NULL,
	[funcionario_ID] [int] NOT NULL,
 CONSTRAINT [PK_professor_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [professor$ID_UNIQUE] UNIQUE NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [fk_professor_funcionário1_idx] ON [dbo].[professor] 
(
	[funcionario_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'secretaria.professor' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'professor'
GO
/****** Object:  Table [dbo].[matricula]    Script Date: 01/17/2016 13:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[matricula](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[materias_modulos_ID] [int] NOT NULL,
	[Criador_ID] [int] NOT NULL,
 CONSTRAINT [PK_matricula_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [fk_matricula_login_senha1_idx] ON [dbo].[matricula] 
(
	[Criador_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [fk_matricula_matérias_modulos1_idx] ON [dbo].[matricula] 
(
	[materias_modulos_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'secretaria.matricula' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'matricula'
GO
/****** Object:  Table [dbo].[materias_modulos]    Script Date: 01/17/2016 13:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[materias_modulos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](40) NOT NULL,
	[Carga_Horaria] [int] NOT NULL,
	[Descricao] [varchar](60) NOT NULL,
 CONSTRAINT [PK_materias_modulos_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'secretaria.materias_modulos' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'materias_modulos'
GO
/****** Object:  Table [dbo].[login_senha]    Script Date: 01/17/2016 13:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login_senha](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](40) NOT NULL,
	[Senha] [varchar](45) NOT NULL,
	[funcionario_ID] [int] NOT NULL,
 CONSTRAINT [PK_login_senha_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [login_senha$funcionario_ID_UNIQUE] UNIQUE NONCLUSTERED 
(
	[funcionario_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [login_senha$Usuario_UNIQUE] UNIQUE NONCLUSTERED 
(
	[Usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [fk_login_senha_funcionário1_idx] ON [dbo].[login_senha] 
(
	[funcionario_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'secretaria.login_senha' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'login_senha'
GO
/****** Object:  Table [dbo].[funcionario]    Script Date: 01/17/2016 13:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[funcionario](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](40) NOT NULL,
	[Departamento] [varchar](20) NOT NULL,
	[DataNascimento] [date] NOT NULL,
	[CPF] [varchar](14) NOT NULL,
	[RG] [varchar](12) NOT NULL,
	[Telefone] [varchar](14) NOT NULL,
	[Celular] [varchar](15) NOT NULL,
	[Endereco] [varchar](40) NOT NULL,
	[Bairro] [varchar](20) NOT NULL,
	[Cidade] [varchar](20) NOT NULL,
	[Numero_Imovel] [int] NOT NULL,
 CONSTRAINT [PK_funcionario_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [funcionario$CPF_UNIQUE] UNIQUE NONCLUSTERED 
(
	[CPF] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [funcionario$RG_UNIQUE] UNIQUE NONCLUSTERED 
(
	[RG] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'secretaria.funcionario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'funcionario'
GO
/****** Object:  Table [dbo].[aluno]    Script Date: 01/17/2016 13:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[aluno](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](40) NOT NULL,
	[DataNascimento] [date] NOT NULL,
	[Cidade] [varchar](30) NOT NULL,
	[Bairro] [varchar](30) NOT NULL,
	[Endereco] [varchar](40) NOT NULL,
	[Numero_Imovel] [int] NOT NULL,
	[RG] [varchar](12) NOT NULL,
	[CPF] [varchar](14) NOT NULL,
	[Telefone] [varchar](14) NOT NULL,
	[Celular] [varchar](15) NOT NULL,
	[Email] [varchar](30) NOT NULL,
	[matricula_ID] [int] NOT NULL,
	[turma_ID] [int] NOT NULL,
 CONSTRAINT [PK_aluno_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[matricula_ID] ASC,
	[turma_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [aluno$CPF_UNIQUE] UNIQUE NONCLUSTERED 
(
	[CPF] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [aluno$RG_UNIQUE] UNIQUE NONCLUSTERED 
(
	[RG] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [fk_aluno_turma1_idx] ON [dbo].[aluno] 
(
	[turma_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'secretaria.aluno' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'aluno'
GO
/****** Object:  Table [dbo].[administrador]    Script Date: 01/17/2016 13:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[administrador](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](40) NOT NULL,
	[funcionario_ID] [int] NOT NULL,
 CONSTRAINT [PK_administrador_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[funcionario_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [administrador$ID_UNIQUE] UNIQUE NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [administrador$Nome_UNIQUE] UNIQUE NONCLUSTERED 
(
	[Nome] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [fk_administrador_funcionário_idx] ON [dbo].[administrador] 
(
	[funcionario_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'secretaria.administrador' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'administrador'
GO
