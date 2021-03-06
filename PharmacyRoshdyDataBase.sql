USE [master]
GO
/****** Object:  Database [Pharmacy]    Script Date: 5/5/2018 10:02:28 PM ******/
CREATE DATABASE [Pharmacy]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Pharmacy', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\Pharmacy.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Pharmacy_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\Pharmacy_log.ldf' , SIZE = 4096KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Pharmacy] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Pharmacy].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Pharmacy] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Pharmacy] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Pharmacy] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Pharmacy] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Pharmacy] SET ARITHABORT OFF 
GO
ALTER DATABASE [Pharmacy] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Pharmacy] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Pharmacy] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Pharmacy] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Pharmacy] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Pharmacy] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Pharmacy] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Pharmacy] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Pharmacy] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Pharmacy] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Pharmacy] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Pharmacy] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Pharmacy] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Pharmacy] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Pharmacy] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Pharmacy] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Pharmacy] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Pharmacy] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Pharmacy] SET  MULTI_USER 
GO
ALTER DATABASE [Pharmacy] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Pharmacy] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Pharmacy] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Pharmacy] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Pharmacy] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Pharmacy] SET QUERY_STORE = OFF
GO
USE [Pharmacy]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Pharmacy]
GO
/****** Object:  Table [dbo].[purchases]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[purchases](
	[transaction_number] [int] IDENTITY(1,1) NOT NULL,
	[pdate] [date] NOT NULL,
 CONSTRAINT [pk_purchases] PRIMARY KEY CLUSTERED 
(
	[transaction_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[purchases_contents]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[purchases_contents](
	[trans_no] [int] NOT NULL,
	[pr_code] [int] NOT NULL,
	[quantity] [int] NOT NULL,
 CONSTRAINT [idx_purchases_contents] PRIMARY KEY CLUSTERED 
(
	[pr_code] ASC,
	[trans_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[Med_tot_purch]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE function [dbo].[Med_tot_purch]()
returns table
return
select pr_code,sum(quantity) as pquantity from purchases,purchases_contents where trans_no=transaction_number Group by pr_code






GO
/****** Object:  Table [dbo].[order_contents]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order_contents](
	[trans_no] [int] NOT NULL,
	[p_code] [int] NOT NULL,
	[quantity] [int] NOT NULL,
 CONSTRAINT [idx_orders] PRIMARY KEY CLUSTERED 
(
	[trans_no] ASC,
	[p_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[transaction_no] [int] IDENTITY(1,1) NOT NULL,
	[odate] [datetime] NOT NULL,
 CONSTRAINT [pk_orders] PRIMARY KEY CLUSTERED 
(
	[transaction_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[Med_tot_sales]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE function [dbo].[Med_tot_sales]()
returns table
return
select p_code , sum(quantity) as squantity from orders,order_contents where trans_no=transaction_no Group by p_code






GO
/****** Object:  UserDefinedFunction [dbo].[All_Stocks]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[All_Stocks]()
returns table
return
select pr_code as Pcode,(pquantity-IsNULL(squantity,0)) as Stock from Med_tot_purch() left outer join Med_tot_sales() on pr_code=p_code

GO
/****** Object:  Table [dbo].[Medicine]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicine](
	[Code] [int] NOT NULL,
	[Active_ing] [varchar](50) NOT NULL,
	[Concentration] [varchar](50) NOT NULL,
	[Tradename] [varchar](250) NULL,
	[Category] [varchar](50) NULL,
	[Price] [float] NOT NULL,
 CONSTRAINT [PK_Medicine] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[All_Stockinfo]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[All_Stock]    Script Date: 4/18/2016 2:39:29 PM ******/


CREATE function [dbo].[All_Stockinfo]()
returns table
return
select Stock,Code,Tradename,Active_ing,Concentration,Category,Price from All_stocks(),Medicine where Code=Pcode 





GO
/****** Object:  UserDefinedFunction [dbo].[orderreceipts]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create function [dbo].[orderreceipts]
(@orderno int)
RETURNS TABLE
AS
RETURN 
select p.Tradename,p.Price,oc.quantity
from orders o,order_contents oc,Medicine p
where o.transaction_no=oc.trans_no AND oc.p_code=p.Code AND oc.trans_no=@orderno





GO
/****** Object:  Table [dbo].[account]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[account](
	[username] [varchar](10) NOT NULL,
	[Password] [varchar](max) NOT NULL,
 CONSTRAINT [PK_UserIdentification] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[cust_code] [int] IDENTITY(1,1) NOT NULL,
	[cname] [varchar](100) NOT NULL,
	[caddress] [varchar](100) NOT NULL,
	[comments] [varchar](max) NULL,
	[telephone] [varchar](11) NOT NULL,
 CONSTRAINT [pk_customer] PRIMARY KEY CLUSTERED 
(
	[cust_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[account] ([username], [Password]) VALUES (N'admin', N'   ÛÂF-zÒÀ	#«Š¾Û×x1àõ6Þ''³š')
INSERT [dbo].[account] ([username], [Password]) VALUES (N'Ahmed', N'   ;õýþ3Í~K=8›[\·èÂUÛ0ºy ')
INSERT [dbo].[account] ([username], [Password]) VALUES (N'fail', N'   :ìÓCê±3§)boqÜBí¡sõ>œ')
INSERT [dbo].[account] ([username], [Password]) VALUES (N'success', N'   
Û“Å‘Ÿæ¾Y¾.É½¿à•›¤T')
SET IDENTITY_INSERT [dbo].[customer] ON 

INSERT [dbo].[customer] ([cust_code], [cname], [caddress], [comments], [telephone]) VALUES (1, N'ahmed', N'giza', N'always have headache', N'01000000001')
INSERT [dbo].[customer] ([cust_code], [cname], [caddress], [comments], [telephone]) VALUES (2, N'mohamed', N'october', N'', N'01000000002')
INSERT [dbo].[customer] ([cust_code], [cname], [caddress], [comments], [telephone]) VALUES (3, N'mahmod', N'mohndsen', N'', N'01000555123')
INSERT [dbo].[customer] ([cust_code], [cname], [caddress], [comments], [telephone]) VALUES (4, N'omar', N'agoza', N'', N'01222554469')
INSERT [dbo].[customer] ([cust_code], [cname], [caddress], [comments], [telephone]) VALUES (5, N'amr', N'ma3ady', N'', N'01111222225')
INSERT [dbo].[customer] ([cust_code], [cname], [caddress], [comments], [telephone]) VALUES (6, N'maha', N'nasr city', N'', N'01000069740')
INSERT [dbo].[customer] ([cust_code], [cname], [caddress], [comments], [telephone]) VALUES (8, N'manal', N'zamalek', N'', N'01005509887')
INSERT [dbo].[customer] ([cust_code], [cname], [caddress], [comments], [telephone]) VALUES (9, N'mo3taz', N'giza', N'', N'01015222544')
INSERT [dbo].[customer] ([cust_code], [cname], [caddress], [comments], [telephone]) VALUES (10, N'amani', N'5 zamalek', N'', N'01063771441')
INSERT [dbo].[customer] ([cust_code], [cname], [caddress], [comments], [telephone]) VALUES (11, N'yomna', N'october', N'', N'01112223334')
INSERT [dbo].[customer] ([cust_code], [cname], [caddress], [comments], [telephone]) VALUES (12, N'shahinaz', N'nasr city', N'', N'01000111222')
INSERT [dbo].[customer] ([cust_code], [cname], [caddress], [comments], [telephone]) VALUES (13, N'osama', N'sharm elsheikh', N'', N'01011133354')
INSERT [dbo].[customer] ([cust_code], [cname], [caddress], [comments], [telephone]) VALUES (14, N'mostafa', N'northcoast', N'', N'01222333665')
INSERT [dbo].[customer] ([cust_code], [cname], [caddress], [comments], [telephone]) VALUES (15, N'salma', N'tagamo3', N'', N'01000069840')
SET IDENTITY_INSERT [dbo].[customer] OFF
INSERT [dbo].[Medicine] ([Code], [Active_ing], [Concentration], [Tradename], [Category], [Price]) VALUES (111122220, N'busc', N'10 mg', N'buscopan 10', N'Digestion', 20)
INSERT [dbo].[Medicine] ([Code], [Active_ing], [Concentration], [Tradename], [Category], [Price]) VALUES (111122221, N'but', N'10 mg', N'butacid 10', N'Digestion', 25)
INSERT [dbo].[Medicine] ([Code], [Active_ing], [Concentration], [Tradename], [Category], [Price]) VALUES (111122222, N'spasm', N'10 mg', N'nu spasm 10', N'Digestion', 10)
INSERT [dbo].[Medicine] ([Code], [Active_ing], [Concentration], [Tradename], [Category], [Price]) VALUES (111122223, N'spasm', N'10 mg', N'spasmocin 10', N'Digestion', 12)
INSERT [dbo].[Medicine] ([Code], [Active_ing], [Concentration], [Tradename], [Category], [Price]) VALUES (111122224, N'spasm', N'10 mg', N'spasmorest 10', N'Flu', 20)
INSERT [dbo].[Medicine] ([Code], [Active_ing], [Concentration], [Tradename], [Category], [Price]) VALUES (111122225, N'spasm', N'20 mg', N'spasmorest 20', N'Flu', 22)
INSERT [dbo].[Medicine] ([Code], [Active_ing], [Concentration], [Tradename], [Category], [Price]) VALUES (111122226, N'relaxin', N'10 mg/10 ml', N'farcolrelaxin', N'Sedative', 30)
INSERT [dbo].[Medicine] ([Code], [Active_ing], [Concentration], [Tradename], [Category], [Price]) VALUES (111122227, N'spasm', N'10 mg/5 ml', N'spasmofree', N'Digestion', 15)
INSERT [dbo].[Medicine] ([Code], [Active_ing], [Concentration], [Tradename], [Category], [Price]) VALUES (111122228, N'timo', N'10 mg/10 ml', N'timogen', N'Cough Relieve', 8)
INSERT [dbo].[Medicine] ([Code], [Active_ing], [Concentration], [Tradename], [Category], [Price]) VALUES (111122229, N'visc', N'10 mg/10 ml', N'viscera', N'Alergie', 10)
INSERT [dbo].[Medicine] ([Code], [Active_ing], [Concentration], [Tradename], [Category], [Price]) VALUES (111122230, N'visc', N'10 mg/10 ml', N'visceralgine', N'Alergie', 20)
INSERT [dbo].[Medicine] ([Code], [Active_ing], [Concentration], [Tradename], [Category], [Price]) VALUES (111122231, N'bral', N'10 mg/10 ml', N'oxybral 10', N'Digestion', 16.5)
INSERT [dbo].[Medicine] ([Code], [Active_ing], [Concentration], [Tradename], [Category], [Price]) VALUES (111122232, N'sigma', N'20 mg', N'sigmastinal 20', N'Digestion', 20)
INSERT [dbo].[Medicine] ([Code], [Active_ing], [Concentration], [Tradename], [Category], [Price]) VALUES (111122233, N'spasm', N'20 mg', N'spasmo 20', N'Digestion', 11.25)
INSERT [dbo].[Medicine] ([Code], [Active_ing], [Concentration], [Tradename], [Category], [Price]) VALUES (111122234, N'spasm', N'20 mg', N'spasmocin 20', N'Digestion', 13)
SET IDENTITY_INSERT [dbo].[purchases] ON 

INSERT [dbo].[purchases] ([transaction_number], [pdate]) VALUES (1, CAST(N'2018-05-02' AS Date))
INSERT [dbo].[purchases] ([transaction_number], [pdate]) VALUES (2, CAST(N'2018-05-02' AS Date))
INSERT [dbo].[purchases] ([transaction_number], [pdate]) VALUES (3, CAST(N'2018-05-02' AS Date))
INSERT [dbo].[purchases] ([transaction_number], [pdate]) VALUES (4, CAST(N'2018-05-02' AS Date))
INSERT [dbo].[purchases] ([transaction_number], [pdate]) VALUES (5, CAST(N'2018-05-02' AS Date))
INSERT [dbo].[purchases] ([transaction_number], [pdate]) VALUES (6, CAST(N'2018-05-02' AS Date))
INSERT [dbo].[purchases] ([transaction_number], [pdate]) VALUES (7, CAST(N'2018-05-02' AS Date))
INSERT [dbo].[purchases] ([transaction_number], [pdate]) VALUES (8, CAST(N'2018-05-02' AS Date))
INSERT [dbo].[purchases] ([transaction_number], [pdate]) VALUES (9, CAST(N'2018-05-02' AS Date))
INSERT [dbo].[purchases] ([transaction_number], [pdate]) VALUES (10, CAST(N'2018-05-02' AS Date))
INSERT [dbo].[purchases] ([transaction_number], [pdate]) VALUES (11, CAST(N'2018-05-02' AS Date))
INSERT [dbo].[purchases] ([transaction_number], [pdate]) VALUES (12, CAST(N'2018-05-02' AS Date))
INSERT [dbo].[purchases] ([transaction_number], [pdate]) VALUES (13, CAST(N'2018-05-02' AS Date))
INSERT [dbo].[purchases] ([transaction_number], [pdate]) VALUES (14, CAST(N'2018-05-02' AS Date))
INSERT [dbo].[purchases] ([transaction_number], [pdate]) VALUES (15, CAST(N'2018-05-02' AS Date))
INSERT [dbo].[purchases] ([transaction_number], [pdate]) VALUES (16, CAST(N'2018-05-02' AS Date))
INSERT [dbo].[purchases] ([transaction_number], [pdate]) VALUES (17, CAST(N'2018-05-02' AS Date))
INSERT [dbo].[purchases] ([transaction_number], [pdate]) VALUES (18, CAST(N'2018-05-04' AS Date))
INSERT [dbo].[purchases] ([transaction_number], [pdate]) VALUES (19, CAST(N'2018-05-04' AS Date))
INSERT [dbo].[purchases] ([transaction_number], [pdate]) VALUES (20, CAST(N'2018-05-04' AS Date))
INSERT [dbo].[purchases] ([transaction_number], [pdate]) VALUES (21, CAST(N'2018-05-05' AS Date))
INSERT [dbo].[purchases] ([transaction_number], [pdate]) VALUES (22, CAST(N'2018-05-04' AS Date))
INSERT [dbo].[purchases] ([transaction_number], [pdate]) VALUES (23, CAST(N'2018-05-04' AS Date))
INSERT [dbo].[purchases] ([transaction_number], [pdate]) VALUES (24, CAST(N'2018-05-04' AS Date))
INSERT [dbo].[purchases] ([transaction_number], [pdate]) VALUES (25, CAST(N'2018-05-04' AS Date))
INSERT [dbo].[purchases] ([transaction_number], [pdate]) VALUES (26, CAST(N'2018-05-04' AS Date))
INSERT [dbo].[purchases] ([transaction_number], [pdate]) VALUES (27, CAST(N'2018-05-04' AS Date))
INSERT [dbo].[purchases] ([transaction_number], [pdate]) VALUES (28, CAST(N'2018-05-05' AS Date))
INSERT [dbo].[purchases] ([transaction_number], [pdate]) VALUES (29, CAST(N'2018-05-04' AS Date))
SET IDENTITY_INSERT [dbo].[purchases] OFF
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (1, 111122220, 280)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (2, 111122220, 280)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (17, 111122220, 49)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (22, 111122220, 1)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (24, 111122220, 1)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (27, 111122220, 1)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (1, 111122221, 150)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (2, 111122221, 150)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (21, 111122221, 1)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (1, 111122222, 350)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (2, 111122222, 350)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (1, 111122223, 160)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (2, 111122223, 160)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (1, 111122224, 160)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (2, 111122224, 160)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (1, 111122225, 160)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (2, 111122225, 160)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (1, 111122226, 160)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (2, 111122226, 160)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (1, 111122227, 160)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (2, 111122227, 160)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (1, 111122228, 160)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (1, 111122229, 160)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (2, 111122229, 160)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (1, 111122230, 160)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (2, 111122230, 60)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (29, 111122230, 20)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (1, 111122231, 160)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (2, 111122231, 60)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (1, 111122232, 160)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (2, 111122232, 60)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (1, 111122233, 160)
INSERT [dbo].[purchases_contents] ([trans_no], [pr_code], [quantity]) VALUES (1, 111122234, 160)
ALTER TABLE [dbo].[account] ADD  CONSTRAINT [DF_account_Password]  DEFAULT ((2478)) FOR [Password]
GO
ALTER TABLE [dbo].[orders] ADD  CONSTRAINT [DF_orders_odate]  DEFAULT (getdate()) FOR [odate]
GO
ALTER TABLE [dbo].[order_contents]  WITH CHECK ADD  CONSTRAINT [fk_order_contents] FOREIGN KEY([trans_no])
REFERENCES [dbo].[orders] ([transaction_no])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[order_contents] CHECK CONSTRAINT [fk_order_contents]
GO
ALTER TABLE [dbo].[order_contents]  WITH CHECK ADD  CONSTRAINT [FK_order_contents_Medicine] FOREIGN KEY([p_code])
REFERENCES [dbo].[Medicine] ([Code])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[order_contents] CHECK CONSTRAINT [FK_order_contents_Medicine]
GO
ALTER TABLE [dbo].[purchases_contents]  WITH CHECK ADD  CONSTRAINT [fk_purchases_contents] FOREIGN KEY([trans_no])
REFERENCES [dbo].[purchases] ([transaction_number])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[purchases_contents] CHECK CONSTRAINT [fk_purchases_contents]
GO
ALTER TABLE [dbo].[purchases_contents]  WITH CHECK ADD  CONSTRAINT [FK_purchases_contents_Medicine] FOREIGN KEY([pr_code])
REFERENCES [dbo].[Medicine] ([Code])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[purchases_contents] CHECK CONSTRAINT [FK_purchases_contents_Medicine]
GO
/****** Object:  StoredProcedure [dbo].[All_Stock]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[All_Stock]
as 
begin
select Stock,Code,Tradename,Active_ing,Concentration,Category,Price from All_stocks(),Medicine where Code=Pcode 
end




GO
/****** Object:  StoredProcedure [dbo].[ChangePassword]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[ChangePassword]
@username varchar(10),
@newpassword varchar(10)

as
begin
 
update account
set Password = ENCRYPTBYPASSPHRASE('ABC123',@newpassword)
Where username = @username



end




GO
/****** Object:  StoredProcedure [dbo].[CheckAccountPassword]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[CheckAccountPassword]
@username varchar(10),
@password varchar(10)


as
begin
select Count(*)
from account
where @password IN
(select CAST(DECRYPTBYPASSPHRASE('ABC123',[password]) AS VARCHAR(10))
from account WHERE username = @username) AND username = @username


end



GO
/****** Object:  StoredProcedure [dbo].[countproducts]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[countproducts]
as
begin
select count(*) from product

end




GO
/****** Object:  StoredProcedure [dbo].[Delete_customer]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Delete_customer]
@cust_code int
AS
BEGIN
delete from customer
where [cust_code]=@cust_code
END

GO
/****** Object:  StoredProcedure [dbo].[Delete_order]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[Delete_order]

@transaction_no int

as
begin

delete from orders
where [transaction_no]=@transaction_no

end




GO
/****** Object:  StoredProcedure [dbo].[getallmedicine]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getallmedicine]

AS
BEGIN

	SELECT * from Medicine
END

GO
/****** Object:  StoredProcedure [dbo].[getcustomers]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getcustomers]

AS
BEGIN
	select * from customer
END

GO
/****** Object:  StoredProcedure [dbo].[getCustomersByCustomerCode]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getCustomersByCustomerCode]  @cust_code  int

AS
BEGIN
	select * from customer where customer.cust_code=@cust_code
END
GO
/****** Object:  StoredProcedure [dbo].[getlasttransnoinorders]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[getlasttransnoinorders]

AS
BEGIN

select MAX(transaction_no) from orders
END



GO
/****** Object:  StoredProcedure [dbo].[getlasttransnoinpurchases]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[getlasttransnoinpurchases]

AS
BEGIN

select MAX(transaction_number) from purchases
END



GO
/****** Object:  StoredProcedure [dbo].[getMedicinePrice]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getMedicinePrice] 
	-- Add the parameters for the stored procedure here
	 @medicineBarCode int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	select Price From Medicine where Medicine.Code = @medicineBarCode
END
GO
/****** Object:  StoredProcedure [dbo].[getMedicinesBarCode]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getMedicinesBarCode]
AS
	SET NOCOUNT ON;
SELECT        Code
FROM            Medicine
GO
/****** Object:  StoredProcedure [dbo].[getMedicinesByCategory]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getMedicinesByCategory]
AS
	SET NOCOUNT ON;
SELECT DISTINCT Category
FROM            Medicine
GO
/****** Object:  StoredProcedure [dbo].[getorders]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[getorders]

AS
BEGIN
	select * from orders
END

GO
/****** Object:  StoredProcedure [dbo].[Insert_customer]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[Insert_customer]

@cname varchar(100),
@caddress varchar(100),
@comments varchar(MAX)=NULL,
@telephone varchar(11)

as
begin
insert into [dbo].[customer]([cname],[caddress],[comments],[telephone])
values (@cname,@caddress,@comments,@telephone)
end



GO
/****** Object:  StoredProcedure [dbo].[Insert_medicine]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[Insert_medicine]
@code int,
@Tradename varchar(250),
@Concentration varchar(50),
@Active_ing varchar(50),
@Category varchar(50),
@Price float
as
begin
insert into [dbo].[Medicine]([Code],[Tradename],[Active_ing],[Concentration],[Category],[Price])
values (@code,@Tradename,@Active_ing,@Concentration,@Category,@Price)
end



GO
/****** Object:  StoredProcedure [dbo].[Insert_order]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[Insert_order]
AS
BEGIN
insert into orders DEFAULT Values;
end



GO
/****** Object:  StoredProcedure [dbo].[Insert_ordercont]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[Insert_ordercont]
@pcode int,
@transno int,
@quan int
AS
BEGIN
insert into order_contents(p_code,quantity,trans_no)
values (@pcode, @quan, @transno);

END



GO
/****** Object:  StoredProcedure [dbo].[Insert_purch]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Insert_purch]
@date date


AS
BEGIN
INSERT INTO [dbo].[purchases]
           ([pdate])
           
     VALUES
           (@date)
END



GO
/****** Object:  StoredProcedure [dbo].[Insert_purch_cont]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Insert_purch_cont]
@transno int,
@prcode int,
@quan int

AS
BEGIN
INSERT INTO [dbo].[purchases_contents]
           ([trans_no]
           ,[pr_code]
           ,[quantity])
  
     VALUES
           (@transno,@prcode,@quan)
END




GO
/****** Object:  StoredProcedure [dbo].[NewDeleteCommand]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NewDeleteCommand]
(
	@Original_Code int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [Medicine] WHERE (([Code] = @Original_Code))
GO
/****** Object:  StoredProcedure [dbo].[NewUpdateCommand]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NewUpdateCommand]
(
	@Code int,
	@Original_Code int
)
AS
	SET NOCOUNT OFF;
UPDATE [Medicine] SET [Code] = @Code WHERE (([Code] = @Original_Code));
	
SELECT Code FROM Medicine WHERE (Code = @Code)
GO
/****** Object:  StoredProcedure [dbo].[OrderContentsInfoSelectedOr]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[OrderContentsInfoSelectedOr]
@Transno int
AS
BEGIN
SELECT O.transaction_no AS 'Trans No.', P.Tradename AS 'Product Name', OC.p_code AS 'Code', SUM(OC.quantity) AS 'Quantity'
FROM order_contents OC, Medicine P, orders O
WHERE OC.trans_no=O.transaction_no AND P.Code=OC.p_code AND O.transaction_no=@Transno
GROUP BY OC.p_code, P.Tradename, O.transaction_no

END






GO
/****** Object:  StoredProcedure [dbo].[orderreceipt]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[orderreceipt]
@orderno int

AS

select p.Tradename as Name,p.Price as Price,p.quantity as Quantity,
  Total = p.price*p.quantity

from orderreceipts(@orderno) p
where p.Price!=0 AND p.quantity !=0 
group by p.Tradename,p.Price,p.quantity

UNION 
select 'Total' as Name,'' as Price , '' as Quantity ,SUM(p.Price*p.quantity) over () 
from orderreceipts(@orderno) p
where p.Price!=0 AND p.quantity !=0 
group by p.Tradename,p.price,p.quantity

order by Total
GO
/****** Object:  StoredProcedure [dbo].[purchasesinperiod]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[purchasesinperiod]
	@date1 date,@date2 date
AS
BEGIN
	select o.transaction_number,p.Tradename,oc.quantity as Quantity,o.pdate as Purch_Date
	from purchases o , purchases_contents oc,Medicine p
	where o.transaction_number=oc.trans_no AND oc.pr_code=p.Code  AND o.pdate>=@date1 AND o.pdate<=@date2
	order by o.transaction_number
END
GO
/****** Object:  StoredProcedure [dbo].[salesinperiod]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[salesinperiod]
	@date1 date,@date2 date
AS
BEGIN
	select o.transaction_no,p.Tradename,oc.quantity as Quantity,o.odate as Purch_Date
	from orders o , order_contents oc,Medicine p
	where o.transaction_no=oc.trans_no AND oc.p_code=p.Code  AND o.odate>=@date1 AND o.odate<=@date2
	order by o.transaction_no
END
GO
/****** Object:  StoredProcedure [dbo].[Search_activeing]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Search_activeing]
@activeing varchar(50),
@cat varchar(50)
as
begin
select * from All_Stockinfo() where Active_ing LIKE '%'+@activeing+'%' and Category=@cat
end
GO
/****** Object:  StoredProcedure [dbo].[Search_tradename]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Search_tradename]
@tradename varchar(50),
@cat  varchar(50)
as
begin
select * from All_Stockinfo() where Tradename LIKE '%'+@tradename+'%'and Category=@cat
end
GO
/****** Object:  StoredProcedure [dbo].[searchcustomers]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[searchcustomers]
@tel varchar(11)
AS
BEGIN
	select * from customer where telephone LIKE '%'+@tel+'%'
END

GO
/****** Object:  StoredProcedure [dbo].[SelectNameAndBarcodeProducts]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[SelectNameAndBarcodeProducts]

--@barcode int,
--@name varchar(100)
as
begin

select [Tradename],[Code]
from Medicine
--where [name]=@name and [barcode]=@barcode

end



GO
/****** Object:  StoredProcedure [dbo].[selectpurchases]    Script Date: 5/5/2018 10:02:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[selectpurchases]
as
begin

select * from purchases
end








GO
/****** Object:  StoredProcedure [dbo].[Single_Stock_thresh]    Script Date: 5/5/2018 10:02:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[Single_Stock_thresh]
@tradename varchar(250)
as
begin
select * from All_Stockinfo() where Stock<=2
end



GO
/****** Object:  StoredProcedure [dbo].[stock]    Script Date: 5/5/2018 10:02:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[stock]
 AS BEGIN 
 select * from All_Stockinfo() order by stock desc
 END








GO
/****** Object:  StoredProcedure [dbo].[stockthreshold]    Script Date: 5/5/2018 10:02:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[stockthreshold] 
AS Begin
 select p.Code,p.Tradename,s.Stock
 from All_Stockinfo() s,Medicine p
 where s.Stock<2 and p.Code=s.Code
 end



GO
/****** Object:  StoredProcedure [dbo].[stockthresholdcount]    Script Date: 5/5/2018 10:02:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[stockthresholdcount] 
AS Begin
 select count(*)
 from All_Stockinfo()
 where Stock<2
 end



GO
/****** Object:  StoredProcedure [dbo].[Update_customer]    Script Date: 5/5/2018 10:02:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Update_customer]
@cust_code int,
@cname varchar(100),
@caddress varchar(100),
@comments varchar(MAX)=NULL,
@telephone varchar(11)
AS
BEGIN
update [customer] set caddress=@caddress, comments=@comments, telephone=@telephone
where cust_code=@cust_code
END

GO
/****** Object:  StoredProcedure [dbo].[Update_medicine]    Script Date: 5/5/2018 10:02:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[Update_medicine]
@code int,
@Tradename varchar(250),
@Active_ing varchar(50),
@Concentration varchar(50),
@Category varchar(50),
@Price float
as
begin
update [Medicine] set Active_ing=@Active_ing,Concentration=@Concentration,Tradename=@Tradename,Category=@Category,Price=@Price
where Code=@code
end




GO
USE [master]
GO
ALTER DATABASE [Pharmacy] SET  READ_WRITE 
GO
