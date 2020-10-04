USE [master]
GO
drop DATABASE [Webmypham ]
CREATE DATABASE [Webmypham ]
begin
EXEC [Webmypham ].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Webmypham ] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Webmypham ] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Webmypham ] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Webmypham ] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Webmypham ] SET ARITHABORT OFF 
GO
ALTER DATABASE [Webmypham ] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Webmypham ] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Webmypham ] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Webmypham ] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Webmypham ] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Webmypham ] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Webmypham ] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Webmypham ] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Webmypham ] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Webmypham ] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Webmypham ] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Webmypham ] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Webmypham ] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Webmypham ] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Webmypham ] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Webmypham ] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Webmypham ] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Webmypham ] SET RECOVERY FULL 
GO
ALTER DATABASE [Webmypham ] SET  MULTI_USER 
GO
ALTER DATABASE [Webmypham ] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Webmypham ] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Webmypham ] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Webmypham ] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Webmypham ] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Webmypham ', N'ON'
GO
ALTER DATABASE [Webmypham ] SET QUERY_STORE = OFF
GO
USE [Webmypham ]
GO
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

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[CustomerName] [nvarchar](max) NULL,
	[CustomerPhoneNumber] [nvarchar](max) NULL,
	[AppointmentDate] [datetime2] NULL,
	[CustomerEmail] [nvarchar](max) NULL,
	[TotalPrice] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manufacturer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Manufacturer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


  
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
	[Price] [int] NOT NULL,
	[Quantity] [int] NULL,
	[Manufacturer] [nvarchar](max) NULL,
	[CategoryId] [int] NOT NULL,
	[SpecialTagId] [int] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Status][int] NOT NULL
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductSelectForOrder](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Status][int]NOT NULL
 CONSTRAINT [PK_ProductSelectForOrder] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SpecialTag](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_SpecialTag] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[DateOfBith] [datetime2](7) NOT NULL,
	[Gender] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

--tạo nhân viên
CREATE TABLE [dbo].[Employee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[DateOfBith] [datetime2](7) NOT NULL,
	[Gender] [int] NOT NULL,
	[Type] [int] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191108234230_addCategory', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191108234554_addSpecialTag', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191108235036_addProducts', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191112033905_addUsers', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191112043502_addAppointmentsAndProductSelectedForAppointment', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191112075216_addBillAndBillDetails', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191112080352_addDatabase', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191113132915_DatabaseNew', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191115123850_addDatabaseNew', N'2.2.6-servicing-10079')
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [Address], [CustomerName], [CustomerPhoneNumber], [AppointmentDate], [CustomerEmail], [TotalPrice]) VALUES (1, N'HaNoi', N'Son IT', N'0968806360',CAST(N'1998-11-11T00:00:00.0000000' AS DateTime2), N'admin', 25780000)
INSERT [dbo].[Orders] ([Id], [Address], [CustomerName], [CustomerPhoneNumber], [AppointmentDate], [CustomerEmail], [TotalPrice]) VALUES (2, N'HaNoi', NULL, NULL, NULL, NULL, 26060000)
INSERT [dbo].[Orders] ([Id], [Address], [CustomerName], [CustomerPhoneNumber], [AppointmentDate], [CustomerEmail], [TotalPrice]) VALUES (3, N'HaNoi', NULL, NULL, NULL, NULL, 25780000)
INSERT [dbo].[Orders] ([Id], [Address], [CustomerName], [CustomerPhoneNumber], [AppointmentDate], [CustomerEmail], [TotalPrice]) VALUES (4, N'HaNoi', NULL, NULL, NULL, NULL, 42770000)
INSERT [dbo].[Orders] ([Id], [Address], [CustomerName], [CustomerPhoneNumber], [AppointmentDate], [CustomerEmail], [TotalPrice]) VALUES (5,N'HaNoi', NULL, NULL, NULL, NULL, 17580000)
INSERT [dbo].[Orders] ([Id], [Address], [CustomerName], [CustomerPhoneNumber], [AppointmentDate], [CustomerEmail], [TotalPrice]) VALUES (6, N'HaNoi', N'Son', N'01283381683', CAST(N'1998-11-11T00:00:00.0000000' AS DateTime2), N'admin@gmail.com', 9010000)
INSERT [dbo].[Orders] ([Id], [Address], [CustomerName], [CustomerPhoneNumber], [AppointmentDate], [CustomerEmail], [TotalPrice]) VALUES (7, N'HaNoi', N'Phan Phú Huy', N'01283381683', CAST(N'1998-11-11T00:00:00.0000000' AS DateTime2), N'phanphuhuy111@gmail.com', 19280000)
INSERT [dbo].[Orders] ([Id], [Address], [CustomerName], [CustomerPhoneNumber], [AppointmentDate], [CustomerEmail], [TotalPrice]) VALUES (8, N'HaNoi', N'Phan Phú Huy', N'01283381683', CAST(N'1998-11-11T00:00:00.0000000' AS DateTime2), N'phanphuhuy111@gmail.com', 430000)
INSERT [dbo].[Orders] ([Id], [Address], [CustomerName], [CustomerPhoneNumber], [AppointmentDate], [CustomerEmail], [TotalPrice]) VALUES (9, N'HaNoi', N'Duy', N'334343424434', CAST(N'1998-11-11T00:00:00.0000000' AS DateTime2), N'admin@gmail.com', 10490000)
INSERT [dbo].[Orders] ([Id], [Address], [CustomerName], [CustomerPhoneNumber], [AppointmentDate], [CustomerEmail], [TotalPrice]) VALUES (9, N'HaNoi', N'Diem', N'334343424432', CAST(N'1999-08-06T00:00:00.0000000' AS DateTime2), N'diemvo0806@gmail.com', 10290000)

SET IDENTITY_INSERT [dbo].[Orders] OFF
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name]) VALUES (1, N'Trang điểm')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (2, N'Quy trình làm sạch da')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (3, N'Quy trình chăm sóc da')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (4, N'Chăm sóc cơ thể')
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Name], [Image], [Price], [Quantity], [Manufacturer], [CategoryId], [SpecialTagId], [Description], [Status]) VALUES (1, N'Son Kem Lì Merzy', N'\images\ProductImage\1.jpg',110000, 10, N'Merzy', 1, 1, N'Son kem lì Merzy nằm trong phiên bản thứ 3',1)	 
SET IDENTITY_INSERT [dbo].[Products] OFF
SET IDENTITY_INSERT [dbo].[ProductSelectForOrder] ON 

INSERT [dbo].[ProductSelectForOrder] ([Id], [OrderID], [ProductId],[Status]) VALUES (1, 1, 2,0)
INSERT [dbo].[ProductSelectForOrder] ([Id], [OrderID], [ProductId],[Status]) VALUES (2, 1, 1,0)
INSERT [dbo].[ProductSelectForOrder] ([Id], [OrderID], [ProductId],[Status]) VALUES (3, 2, 2,0)
INSERT [dbo].[ProductSelectForOrder] ([Id], [OrderID], [ProductId],[Status]) VALUES (4, 2, 1,0)
INSERT [dbo].[ProductSelectForOrder] ([Id], [OrderID], [ProductId],[Status]) VALUES (5, 2, 9,0)
INSERT [dbo].[ProductSelectForOrder] ([Id], [OrderID], [ProductId],[Status]) VALUES (6, 3, 2,0)
INSERT [dbo].[ProductSelectForOrder] ([Id], [OrderID], [ProductId],[Status]) VALUES (7, 3, 1,1)
INSERT [dbo].[ProductSelectForOrder] ([Id], [OrderID], [ProductId],[Status]) VALUES (8, 4, 2,0)
INSERT [dbo].[ProductSelectForOrder] ([Id], [OrderID], [ProductId],[Status]) VALUES (9, 4, 1,0)
INSERT [dbo].[ProductSelectForOrder] ([Id], [OrderID], [ProductId],[Status]) VALUES (10, 4, 1,1)
INSERT [dbo].[ProductSelectForOrder] ([Id], [OrderID], [ProductId],[Status]) VALUES (11, 5, 2,0)
INSERT [dbo].[ProductSelectForOrder] ([Id], [OrderID], [ProductId],[Status]) VALUES (12, 5, 2,1)
INSERT [dbo].[ProductSelectForOrder] ([Id], [OrderID], [ProductId],[Status]) VALUES (13, 6, 2,0)
INSERT [dbo].[ProductSelectForOrder] ([Id], [OrderID], [ProductId],[Status]) VALUES (14, 6, 12,0)
INSERT [dbo].[ProductSelectForOrder] ([Id], [OrderID], [ProductId],[Status]) VALUES (15, 7, 2,0)
INSERT [dbo].[ProductSelectForOrder] ([Id], [OrderID], [ProductId],[Status]) VALUES (16, 7, 3,0)
INSERT [dbo].[ProductSelectForOrder] ([Id], [OrderID], [ProductId],[Status]) VALUES (17, 8, 10,0)
INSERT [dbo].[ProductSelectForOrder] ([Id], [OrderID], [ProductId],[Status]) VALUES (18, 8, 9,0)
INSERT [dbo].[ProductSelectForOrder] ([Id], [OrderID], [ProductId],[Status]) VALUES (19, 9, 3,0)
SET IDENTITY_INSERT [dbo].[ProductSelectForOrder] OFF
SET IDENTITY_INSERT [dbo].[SpecialTag] ON 

INSERT [dbo].[SpecialTag] ([Id], [Name]) VALUES (1, N'Mới ra')
INSERT [dbo].[SpecialTag] ([Id], [Name]) VALUES (2, N'Bán chạy')
INSERT [dbo].[SpecialTag] ([Id], [Name]) VALUES (3, N'Đặc biệt')
INSERT [dbo].[SpecialTag] ([Id], [Name]) VALUES (4, N'Phổ biến')
INSERT [dbo].[SpecialTag] ([Id], [Name]) VALUES (1003, N'None')
SET IDENTITY_INSERT [dbo].[SpecialTag] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [UserName], [Password], [Name], [Email], [Phone], [DateOfBith], [Gender]) VALUES (2, N'phanphuhuy116', N'123456', N'Phan Phú Huy', N'phanphuhuy111@gmail.com', N'01283381683', CAST(N'1998-11-11T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Users] ([Id], [UserName], [Password], [Name], [Email], [Phone], [DateOfBith], [Gender]) VALUES (3, N'admin', N'admin1', N'admin1', N'admin@gmail.com', N'0968806360', CAST(N'1999-11-06T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Users] ([Id], [UserName], [Password], [Name], [Email], [Phone], [DateOfBith], [Gender]) VALUES (8, N'phandinhsonlp116', N'0123456789', N'Son IT', N'phanphuhuy@gmail.com          ', N'0968806360', CAST(N'1999-11-11T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Users] ([Id], [UserName], [Password], [Name], [Email], [Phone], [DateOfBith], [Gender]) VALUES (9, N'thu12345', N'123456', N'Minh Thu', N'ngominhthu@gmail.com          ', N'0968806360', CAST(N'1999-11-11T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Users] ([Id], [UserName], [Password], [Name], [Email], [Phone], [DateOfBith], [Gender]) VALUES (10, N'lethai', N'123456', N'Lê Hồng Thái', N'hongthai@gmail.com', N'12345632322', CAST(N'1999-11-14T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Users] ([Id], [UserName], [Password], [Name], [Email], [Phone], [DateOfBith], [Gender]) VALUES (11, N'letienhoa1998', N'hoa12345', N'Lê Tiến Hòa', N'letienhoa1998@gmail.com       ', N'0123242322', CAST(N'1998-11-09T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Users] ([Id], [UserName], [Password], [Name], [Email], [Phone], [DateOfBith], [Gender]) VALUES (13, N'ngominhthu', N'123456', N'Thu IT', N'ngominhthu@gmail.com          ', N'0968806360', CAST(N'1999-11-11T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Users] ([Id], [UserName], [Password], [Name], [Email], [Phone], [DateOfBith], [Gender]) VALUES (14, N'phandinhson', N'1234567', N'Son IT', N'ngominhthu@gmail.com          ', N'0968806360', CAST(N'1999-11-11T00:00:00.0000000' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 
--tạo giá trị cho nhân viên
INSERT [dbo].[Employee]  ([UserName], [Password], [Name], [Email], [Phone], [DateOfBith], [Gender],[Type]) VALUES ( N'DiemKiDi', N'123456', N'Diem Vo', N'diem1234@gmail.com', N'098767655', CAST(N'1998-11-11T00:00:00.0000000' AS DateTime2), 0,2)
INSERT [dbo].[Employee] ([UserName], [Password], [Name], [Email], [Phone], [DateOfBith], [Gender],[Type]) VALUES (N'Han', N'admin', N'Han', N'han12345@gmail.com', N'098878676', CAST(N'1999-11-06T00:00:00.0000000' AS DateTime2), 1,2)
INSERT [dbo].[Employee] ([UserName], [Password], [Name], [Email], [Phone], [DateOfBith], [Gender],[Type]) VALUES (N'admin', N'admin', N'Han', N'han12345@gmail.com', N'098878676', CAST(N'1999-11-06T00:00:00.0000000' AS DateTime2), 1,1)
SET IDENTITY_INSERT [dbo].[Employee] OFF

