USE [master]
GO
/****** Object:  Database [SHT.New]    Script Date: 1/15/2025 20:05:29 ******/
CREATE DATABASE [SHT.New]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SHT.New', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\SHT.New.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SHT.New_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\SHT.New_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SHT.New] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SHT.New].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SHT.New] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SHT.New] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SHT.New] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SHT.New] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SHT.New] SET ARITHABORT OFF 
GO
ALTER DATABASE [SHT.New] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SHT.New] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SHT.New] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SHT.New] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SHT.New] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SHT.New] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SHT.New] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SHT.New] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SHT.New] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SHT.New] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SHT.New] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SHT.New] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SHT.New] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SHT.New] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SHT.New] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SHT.New] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SHT.New] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SHT.New] SET RECOVERY FULL 
GO
ALTER DATABASE [SHT.New] SET  MULTI_USER 
GO
ALTER DATABASE [SHT.New] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SHT.New] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SHT.New] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SHT.New] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SHT.New] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SHT.New] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SHT.New', N'ON'
GO
ALTER DATABASE [SHT.New] SET QUERY_STORE = ON
GO
ALTER DATABASE [SHT.New] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SHT.New]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 1/15/2025 20:05:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ManageSalon]    Script Date: 1/15/2025 20:05:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ManageSalon](
	[ManageSalonID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[SalonTimeID] [int] NOT NULL,
 CONSTRAINT [PK_ManageSalon] PRIMARY KEY CLUSTERED 
(
	[ManageSalonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MemberSalon]    Script Date: 1/15/2025 20:05:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MemberSalon](
	[MemberID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[ManageSalonID] [int] NOT NULL,
 CONSTRAINT [PK_MemberSalon] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Request]    Script Date: 1/15/2025 20:05:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Request](
	[RequestID] [int] IDENTITY(1,1) NOT NULL,
	[RequestText] [nvarchar](500) NOT NULL,
	[UserID] [int] NOT NULL,
	[ManageSalonID] [int] NOT NULL,
 CONSTRAINT [PK_Request] PRIMARY KEY CLUSTERED 
(
	[RequestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salon]    Script Date: 1/15/2025 20:05:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salon](
	[SalonID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Password] [nchar](10) NOT NULL,
	[Address] [nvarchar](200) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[Location] [binary](50) NULL,
	[SportField] [char](4) NOT NULL,
	[Price] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Salon] PRIMARY KEY CLUSTERED 
(
	[SalonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalonTime]    Script Date: 1/15/2025 20:05:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalonTime](
	[SalonTimeID] [int] IDENTITY(1,1) NOT NULL,
	[SalonTime] [char](12) NOT NULL,
	[salonID] [int] NOT NULL,
	[FreeTime] [char](1) NOT NULL,
	[ManageSalonID] [int] NULL,
 CONSTRAINT [PK_SalonTime] PRIMARY KEY CLUSTERED 
(
	[SalonTimeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 1/15/2025 20:05:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](80) NOT NULL,
	[LastName] [nvarchar](80) NOT NULL,
	[Phone] [nvarchar](11) NOT NULL,
	[Age] [nvarchar](10) NOT NULL,
	[SportField] [nvarchar](4) NOT NULL,
	[UserName] [nvarchar](80) NOT NULL,
	[Password] [nvarchar](10) NOT NULL,
	[Deleted] [nvarchar](1) NULL,
 CONSTRAINT [PK_dbo.Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'202501131543038_InitialCreate', N'SHT.SHTDATA.TestShtDataContext', 0x1F8B0800000000000400CD58DB72DB36107DEF4CFF81C36747B0EC3CA41E2A1945B25A4F2DDB132A7987C895842908B000E84ADFD6877E527FA10BDE4552B4E44BD2F1D8632E76CF5E00EC1EF2DFBFFFF13E6D23EE3C82D24C8A913B1C9CBB0E8840864CAC476E6256EF3EB89F3EFEFC93771D465BE75BA17769F5D052E891BB3126BE2244071B88A81E442C5052CB95190432223494E4E2FCFC17321C12400817B11CC7FB9208C322481FF071224500B149289FCB10B8CEE5B8E2A7A8CE1D8D40C7348091EBFFB618E0EF74BC18BBCE98338A21F8C057AE438590861A0CF0EAAB06DF2829D67E8C02CA17BB18506F45B9863CF0AB4AFDD81CCE2F6C0EA4322CA082441B199D0838BCCC8B429AE6CF2AAD5B160DCB768DE5353B9B755ABA918B0551AED3747435E1CA2AED55756075CF1C7C3A2B371CCF85FD397326093789829180C428CACF9C8764C959F03BEC16F20F102391705E8F0463C1B53D018A1E948C4199DD1758E5F1DD84AE43F6ED48D3B034ABD964D1DF087379E13A77E89C2E39941B5DCBD43752C1AF20405103E103350694B0189096AAE5BDE1CBFE2DBCE1C9C2DBE13A73BABD05B1369B91FB01AFC38C6D212C0479005F05C3BB84364625D01160BFD35BAACD0F71FCB091A2CFEB70F8165EC7EB5E9F6F92A91F4B65660C78D8E3FAFD5B78B6B7ECC76C2ED5FA2FA9FA127E9B5A4F8103DEBD3EBF47B9AD7BF148D5EADA0D10E78AA10CEF7C1EC102B4F137664A0DB54BB0351D3D1137266F8B3AF7B89F5506ED83A98166EDB50A251B49834CDC156F195935EA4836EB8A99480E0C456F4EE3180B571B92B9C4F1B3093979E79F3E41A20C8304BA639094D1969EB09BD2353456D135463A634AA7255E52BB7993306AA975ECC3811A170E1BA56E0E94AAF28581FD3FBFE28DD1D634AE0A38C39C229C07697A50C6904FCF96594A4F28A7AA632E4D244F227168B6F559673DA16E9F498E47A8C6461DA5921E8F94CF813A4C2E3A1E23EDEA75845470BC7DBD43D761EAF2E3D1AAAE5BC7AAA427D4A66CA37BE529A5C723957DB10E540ADB381E699CD7E66D20ADEBD06056CDEBD5D7A09A2AA5F7B251351A92973787A7A97CAB5B642AAE83057A64A1ED14FE4E1B88065661E0FFC9279C61BE95C29C0AB6C2A690914F1749F545E3A5E0FF43D089D6213F82A57F77F6CC6C459FE4C7270EFB3AB5118F54051BAA5AE4E6857CF8B570F7E86E27A825BCCF67B3DD90A7C7D926AB9DC8EF5FCC455FADB00DAAF95A856830C96ED83AEA4B89639BD7F473C25E3E9875B9911B2E256690056857F4B3A962BBE37AA4FE89C59B8266EB0AC27E701110D8565681163A3762258B7A6346F5880A95C676CCC1D0100B335686AD6860703900AD5376FF8DF20455AEA3258437E23E317162C65A43B4E47B2FDD1EE9F79FF2E1FD98BDFBD83EE9D74801C3649802DC8BCF09B3F72B8F7BD63E8E8720EC19C91B2846856F3708B7DE9548772DDE7408282FDF146210B6FD2E208A3982E97BE1D347784E6C78BC6E614D835D31380F833CBD11FB65F7A68CAE158D748E51D9DBCF86C47E37FCF81F1E23462B69140000, N'6.5.1')
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Name], [LastName], [Phone], [Age], [SportField], [UserName], [Password], [Deleted]) VALUES (1, N'مهدی', N'امانتی', N'09133635267', N'2008-09-14', N'1000', N'مهدی', N'امانتی 123', N'0')
INSERT [dbo].[Users] ([Id], [Name], [LastName], [Phone], [Age], [SportField], [UserName], [Password], [Deleted]) VALUES (2, N'mahdi', N'amanati', N'09133635267', N'2001-10-01', N'1000', N'mahdi', N'asd', N'0')
INSERT [dbo].[Users] ([Id], [Name], [LastName], [Phone], [Age], [SportField], [UserName], [Password], [Deleted]) VALUES (3, N'reza', N'amaanati', N'09133635268', N'2011-11-10', N'0100', N'amanati', N'123', N'0')
INSERT [dbo].[Users] ([Id], [Name], [LastName], [Phone], [Age], [SportField], [UserName], [Password], [Deleted]) VALUES (1002, N'7', N'7', N'09121111111', N'2001-05-12', N'1111', N'7', N'q', N'0')
INSERT [dbo].[Users] ([Id], [Name], [LastName], [Phone], [Age], [SportField], [UserName], [Password], [Deleted]) VALUES (1003, N'q', N'q', N'09213698521', N'2000-02-04', N'0001', N'q', N'q', N'1')
INSERT [dbo].[Users] ([Id], [Name], [LastName], [Phone], [Age], [SportField], [UserName], [Password], [Deleted]) VALUES (1004, N'a', N'a', N'09133635267', N'2001-12-10', N'0010', N'a', N'a', N'0')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Salon] ADD  CONSTRAINT [DF_Salon_SportField]  DEFAULT ('0000') FOR [SportField]
GO
ALTER TABLE [dbo].[SalonTime] ADD  CONSTRAINT [DF_SalonTime_FreeTime]  DEFAULT ('0') FOR [FreeTime]
GO
USE [master]
GO
ALTER DATABASE [SHT.New] SET  READ_WRITE 
GO
