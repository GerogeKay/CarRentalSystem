USE [master]
GO
/****** Object:  Database [CarRentalSystem]    Script Date: 2020/6/6 18:43:06 ******/
CREATE DATABASE [CarRentalSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CarRentalSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CarRentalSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CarRentalSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CarRentalSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CarRentalSystem] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CarRentalSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CarRentalSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CarRentalSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CarRentalSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CarRentalSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CarRentalSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [CarRentalSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CarRentalSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CarRentalSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CarRentalSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CarRentalSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CarRentalSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CarRentalSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CarRentalSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CarRentalSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CarRentalSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CarRentalSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CarRentalSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CarRentalSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CarRentalSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CarRentalSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CarRentalSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CarRentalSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CarRentalSystem] SET RECOVERY FULL 
GO
ALTER DATABASE [CarRentalSystem] SET  MULTI_USER 
GO
ALTER DATABASE [CarRentalSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CarRentalSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CarRentalSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CarRentalSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CarRentalSystem] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CarRentalSystem', N'ON'
GO
ALTER DATABASE [CarRentalSystem] SET QUERY_STORE = OFF
GO
USE [CarRentalSystem]
GO
/****** Object:  Table [dbo].[ADMIN_INFO]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ADMIN_INFO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NAME] [varchar](50) NOT NULL,
	[PWD] [varchar](50) NOT NULL,
	[CONTROLPWD] [varchar](50) NULL,
	[REALNAME] [varchar](50) NULL,
	[PHONE] [varchar](50) NULL,
	[ADDRESS] [varchar](200) NULL,
	[IDENTITY] [varchar](50) NULL,
	[GENDER] [tinyint] NULL,
	[PHOTO] [image] NULL,
	[ISDELETE] [bit] NULL,
 CONSTRAINT [PK_ADMIN_INFO] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [CHECK_ADMIN_NAME] UNIQUE NONCLUSTERED 
(
	[NAME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AUDIT_LIST]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AUDIT_LIST](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[AUDIT_TYPE] [varchar](20) NULL,
	[CONTENT] [nvarchar](4000) NULL,
	[AUDITOR_ID] [int] NULL,
	[IS_PASS] [bit] NULL,
	[CHECKED] [bit] NULL,
 CONSTRAINT [PK__AUDIT_LI__3214EC27232FB4D5] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CAR_INFO]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAR_INFO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PLATENUMBER] [varchar](20) NULL,
	[TYPE] [varchar](50) NULL,
	[COLOR] [varchar](20) NULL,
	[STORE_ID] [int] NULL,
	[USER_ID] [int] NULL,
	[STATUS] [int] NULL,
	[ISDELETE] [bit] NULL,
 CONSTRAINT [PK_CAR_INFO] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COST_RULE]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COST_RULE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[USER_LEVEL] [int] NOT NULL,
	[HOUR_COST] [decimal](18, 2) NULL,
	[DAY_COST] [decimal](18, 2) NULL,
	[WEEK_COST] [decimal](18, 2) NULL,
	[MONTH_COST] [decimal](18, 2) NULL,
	[SEASON_COST] [decimal](18, 2) NULL,
	[YEAR_COST] [decimal](18, 2) NULL,
	[ISDELETE] [bit] NULL,
 CONSTRAINT [PK_COST_RULE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [ONE_LEVEL_ONE_RULE] UNIQUE NONCLUSTERED 
(
	[USER_LEVEL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DEVICE_INFO]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DEVICE_INFO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MAC] [varchar](50) NULL,
	[STORE_ID] [int] NULL,
	[IS_DELETE] [bit] NULL,
 CONSTRAINT [PK_DEVICE_INFO] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOG_INFO]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOG_INFO](
	[LOGID] [int] IDENTITY(1,1) NOT NULL,
	[USERID] [int] NULL,
	[ADMINID] [int] NULL,
	[CONTENT] [varchar](50) NULL,
	[LOGTIME] [datetime] NULL,
	[ISDELETE] [bit] NULL,
 CONSTRAINT [PK_LOG_INFO] PRIMARY KEY CLUSTERED 
(
	[LOGID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RENTAL_ORDERS]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RENTAL_ORDERS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[USER_ID] [int] NULL,
	[CAR_ID] [int] NULL,
	[STORE_ID] [int] NULL,
	[USER_LEVEL] [int] NULL,
	[ORDER_TYPE] [int] NULL,
	[START_TIME] [datetime] NULL,
	[END_TIME] [datetime] NULL,
	[ACTUAL_TIME] [int] NULL,
	[ORDER_COST] [decimal](18, 2) NULL,
	[ORDER_STATUS] [int] NULL,
 CONSTRAINT [PK_RENTAL_ORDERS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STORE_INFO]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STORE_INFO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NAME] [varchar](50) NULL,
	[ADDRESS] [varchar](200) NULL,
	[IS_DELETE] [bit] NULL,
 CONSTRAINT [PK_STORE_INFO] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [CHECK_STORE_NAME] UNIQUE NONCLUSTERED 
(
	[NAME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USER_INFO]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USER_INFO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NAME] [varchar](50) NULL,
	[PWD] [varchar](50) NULL,
	[PAYPWD] [varchar](50) NULL,
	[REALNAME] [varchar](50) NULL,
	[PHONE] [varchar](50) NULL,
	[ADDRESS] [varchar](200) NULL,
	[IDENTITY] [varchar](50) NULL,
	[GENDER] [tinyint] NULL,
	[PHOTO] [image] NULL,
	[REMAINMONEY] [decimal](18, 2) NULL,
	[DRILICENSE] [varchar](50) NULL,
	[USERLEVEL] [int] NOT NULL,
	[ISDELETE] [bit] NULL,
 CONSTRAINT [PK_USER_INFO] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [check_name] UNIQUE NONCLUSTERED 
(
	[NAME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[CAR_INFO] ADD  CONSTRAINT [DF_CAR_INFO_ISDELETE]  DEFAULT ((0)) FOR [ISDELETE]
GO
ALTER TABLE [dbo].[DEVICE_INFO] ADD  CONSTRAINT [DF_DEVICE_INFO_IS_DELETE]  DEFAULT ((0)) FOR [IS_DELETE]
GO
ALTER TABLE [dbo].[USER_INFO] ADD  CONSTRAINT [DF_USER_INFO_REMAINMONEY]  DEFAULT ((0)) FOR [REMAINMONEY]
GO
ALTER TABLE [dbo].[USER_INFO] ADD  CONSTRAINT [DF_USER_INFO_USERLEVEL]  DEFAULT ((0)) FOR [USERLEVEL]
GO
ALTER TABLE [dbo].[USER_INFO] ADD  CONSTRAINT [DF_USER_INFO_ISDELETE]  DEFAULT ((0)) FOR [ISDELETE]
GO
ALTER TABLE [dbo].[COST_RULE]  WITH CHECK ADD  CONSTRAINT [FK_COST_RULE_COST_RULE] FOREIGN KEY([ID])
REFERENCES [dbo].[COST_RULE] ([ID])
GO
ALTER TABLE [dbo].[COST_RULE] CHECK CONSTRAINT [FK_COST_RULE_COST_RULE]
GO
ALTER TABLE [dbo].[COST_RULE]  WITH CHECK ADD  CONSTRAINT [FK_COST_RULE_COST_RULE1] FOREIGN KEY([ID])
REFERENCES [dbo].[COST_RULE] ([ID])
GO
ALTER TABLE [dbo].[COST_RULE] CHECK CONSTRAINT [FK_COST_RULE_COST_RULE1]
GO
ALTER TABLE [dbo].[AUDIT_LIST]  WITH CHECK ADD  CONSTRAINT [CONTENT should be JSON] CHECK  ((isjson([CONTENT])=(1)))
GO
ALTER TABLE [dbo].[AUDIT_LIST] CHECK CONSTRAINT [CONTENT should be JSON]
GO
/****** Object:  StoredProcedure [dbo].[ADD_COST_RULE]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.05
-- Description:	添加收费规则
-- =============================================
CREATE PROCEDURE [dbo].[ADD_COST_RULE]
	@USER_LEVEL  INT,
	@HOUR_COST   DECIMAL,
	@DAY_COST    DECIMAL,
	@WEEK_COST   DECIMAL,
	@MONTH_COST  DECIMAL,
	@SEASON_COST DECIMAL,
	@YEAR_COST   DECIMAL
AS
BEGIN
	INSERT INTO COST_RULE(USER_LEVEL,HOUR_COST,DAY_COST,WEEK_COST,MONTH_COST,SEASON_COST,YEAR_COST,ISDELETE) 
	VALUES(@USER_LEVEL,@HOUR_COST,@DAY_COST,@WEEK_COST,@MONTH_COST,@SEASON_COST,@YEAR_COST,0)
END
GO
/****** Object:  StoredProcedure [dbo].[ADMIN_ADD]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.05.30
-- Description:	录入一个管理员
-- =============================================
CREATE PROCEDURE [dbo].[ADMIN_ADD]
	-- Add the parameters for the stored procedure here
	@NAME VARCHAR(50),
	@PWD VARCHAR(50),
	@CONTROLPWD VARCHAR(50),
	@REALNAME VARCHAR(50),
	@PHONE VARCHAR(50),
	@ADDRESS VARCHAR(200),
	@IDENTITY VARCHAR(50),
	@GENDER TINYINT
AS
    -- Insert statements for procedure here
	INSERT INTO ADMIN_INFO([NAME],[PWD],CONTROLPWD,REALNAME,PHONE,[ADDRESS],[IDENTITY],GENDER,ISDELETE) VALUES(@NAME,@PWD,@CONTROLPWD,@REALNAME,@PHONE,@ADDRESS,@IDENTITY,@GENDER,0)
GO
/****** Object:  StoredProcedure [dbo].[ADMIN_SELECT_BY_NAME]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.05.30
-- Description:	根据用户名取出管理员信息
-- =============================================
CREATE PROCEDURE [dbo].[ADMIN_SELECT_BY_NAME]
	-- Add the parameters for the stored procedure here
	@NAME VARCHAR(50)
AS
BEGIN
    -- Insert statements for procedure here
	SELECT * FROM ADMIN_INFO WHERE NAME=@NAME AND ISDELETE=0
END
GO
/****** Object:  StoredProcedure [dbo].[ADMIN_SELECT_BY_NAME_AND_PWD]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.03
-- Description:	管理员登录
-- =============================================
CREATE PROCEDURE [dbo].[ADMIN_SELECT_BY_NAME_AND_PWD]
	@NAME VARCHAR(50),
	@PWD VARCHAR(50)
AS
BEGIN
	SELECT ID,[NAME],PWD,CONTROLPWD,REALNAME,PHONE,[ADDRESS],[IDENTITY],GENDER,PHOTO,ISDELETE
	FROM ADMIN_INFO
	WHERE ISDELETE!=1 AND [NAME]=@NAME AND PWD=@PWD
END
GO
/****** Object:  StoredProcedure [dbo].[ADMIN_UPDATE]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.05.30
-- Description:	修改一个管理员的信息
-- =============================================
CREATE PROCEDURE [dbo].[ADMIN_UPDATE]
	-- Add the parameters for the stored procedure here
	@ID INT,
	@NAME VARCHAR(50),
	@PWD VARCHAR(50),
	@CONTROLPWD VARCHAR(50),
	@REALNAME VARCHAR(50),
	@PHONE VARCHAR(50),
	@ADDRESS VARCHAR(200),
	@IDENTITY VARCHAR(50),
	@GENDER TINYINT,
	@PHOTO IMAGE
AS
    -- Insert statements for procedure here
	UPDATE ADMIN_INFO SET 
	[NAME]=@NAME,
	[PWD]=@PWD,
	[CONTROLPWD]=@CONTROLPWD,
	REALNAME=@REALNAME,
	PHONE=@PHONE,
	[ADDRESS]=@ADDRESS,
	[IDENTITY]=@IDENTITY,
	GENDER=@GENDER,
	PHOTO=@PHOTO
	WHERE ID=@ID
GO
/****** Object:  StoredProcedure [dbo].[AUDIT_CHECK]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.04
-- Description:	审核处理
-- =============================================
CREATE PROCEDURE [dbo].[AUDIT_CHECK]
	@ID INT,
	@AUDITOR_ID INT,
	@IS_PASS BIT
AS
BEGIN
	UPDATE AUDIT_LIST SET
	AUDITOR_ID = @AUDITOR_ID,
	IS_PASS = @IS_PASS,
	CHECKED = 1
	WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[AUDIT_COMMIT]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.03
-- Description:	提交审核信息
-- =============================================
CREATE PROCEDURE [dbo].[AUDIT_COMMIT]
	-- Add the parameters for the stored procedure here
	@AUDIT_TYPE VARCHAR(20), 
	@CONTENT NVARCHAR(4000),
	@AUDITOR_ID INT,
	@IS_PASS BIT,
	@CHECKED BIT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	INSERT INTO AUDIT_LIST(AUDIT_TYPE,CONTENT,AUDITOR_ID,IS_PASS,CHECKED) VALUES(@AUDIT_TYPE,@CONTENT,@AUDITOR_ID,@IS_PASS,@CHECKED)
END
GO
/****** Object:  StoredProcedure [dbo].[CAR_ADD]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.04
-- Description:	添加一辆车的信息
-- =============================================
CREATE PROCEDURE [dbo].[CAR_ADD]
	@PLATENUMBER VARCHAR(20),
	@TYPE VARCHAR(50),
	@COLOR VARCHAR(20),
	@STORE_ID INT,
	@USER_ID INT,
	@STATUS INT
AS
BEGIN
	INSERT INTO CAR_INFO(PLATENUMBER,[TYPE],COLOR,STORE_ID,[USER_ID],[STATUS],ISDELETE) 
	VALUES(@PLATENUMBER,@TYPE,@COLOR,@STORE_ID,@USER_ID,@STATUS,0)
END
GO
/****** Object:  StoredProcedure [dbo].[CAR_UPDATE]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.04
-- Description:	更新一辆车的信息
-- =============================================
CREATE PROCEDURE [dbo].[CAR_UPDATE]
	@ID INT,
	@PLATENUMBER VARCHAR(20),
	@TYPE VARCHAR(20),
	@COLOR VARCHAR(20),
	@STORE_ID INT,
	@USER_ID INT,
	@STATUS INT
AS
BEGIN
	UPDATE CAR_INFO SET
	PLATENUMBER=@PLATENUMBER,[TYPE]=@TYPE,COLOR=@COLOR,STORE_ID=@STORE_ID,[USER_ID]=@USER_ID,[STATUS]=@STATUS
	WHERE ID=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[DEVICE_ADD]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.03
-- Description:	添加一个设备
-- =============================================
CREATE PROCEDURE [dbo].[DEVICE_ADD]
	@MAC VARCHAR(50),
	@STORE_ID INT
AS
BEGIN
	INSERT INTO DEVICE_INFO(MAC, STORE_ID) VALUES(@MAC,@STORE_ID)
END
GO
/****** Object:  StoredProcedure [dbo].[DEVICE_SELECT_BY_ID]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.03
-- Description:	根据设备id获取设备信息
-- =============================================
CREATE PROCEDURE [dbo].[DEVICE_SELECT_BY_ID]
	-- Add the parameters for the stored procedure here
	@ID INT
AS
BEGIN
    -- Insert statements for procedure here
	SELECT * FROM DEVICE_INFO WHERE ID=@ID AND IS_DELETE=0
END
GO
/****** Object:  StoredProcedure [dbo].[DEVICE_SELECT_BY_MAC]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.03
-- Description:	根据mac地址获取设备信息
-- =============================================
CREATE PROCEDURE [dbo].[DEVICE_SELECT_BY_MAC]
	-- Add the parameters for the stored procedure here
	@MAC VARCHAR(50) = '00-00-00-00-00-00'
AS
BEGIN
    -- Insert statements for procedure here
	SELECT * FROM DEVICE_INFO WHERE MAC=@MAC
END
GO
/****** Object:  StoredProcedure [dbo].[DEVICE_UPDATE]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.03
-- Description:	更新设备信息
-- =============================================
CREATE PROCEDURE [dbo].[DEVICE_UPDATE]
	@ID INT,
	@STORE_ID INT
AS
BEGIN
	UPDATE DEVICE_INFO SET STORE_ID=@STORE_ID WHERE ID=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[GET_COST_RULE]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.05
-- Description:	获取所有收费规则
-- =============================================
CREATE PROCEDURE [dbo].[GET_COST_RULE]
AS
BEGIN
	SELECT * FROM COST_RULE WHERE ISDELETE=0
END
GO
/****** Object:  StoredProcedure [dbo].[GET_ORDERS]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.05
-- Description:	查询所有订单
-- =============================================
CREATE PROCEDURE [dbo].[GET_ORDERS]
	--@ID INT,
	--@USER_ID INT, 
	--@CAR_ID INT,
	--@STORE_ID INT,
	--@USER_LEVEL INT,
	--@ORDER_TYPE INT,
	--@START_TIME DATETIME,
	--@END_TIME DATETIME,
	--@ACTUAL_TIME DATETIME,
	--@ORDER_COST DECIMAL,
	--@ORDER_STATUS INT
AS
BEGIN
	SELECT * FROM RENTAL_ORDERS
END
GO
/****** Object:  StoredProcedure [dbo].[GET_ORDERS_BY_CAR_ID]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.05
-- Description:	根据车辆id查询订单
-- =============================================
CREATE PROCEDURE [dbo].[GET_ORDERS_BY_CAR_ID]
	--@ID INT,
	--@USER_ID INT, 
	@CAR_ID INT--,
	--@STORE_ID INT,
	--@USER_LEVEL INT,
	--@ORDER_TYPE INT,
	--@START_TIME DATETIME,
	--@END_TIME DATETIME,
	--@ACTUAL_TIME INT,
	--@ORDER_COST DECIMAL,
	--@ORDER_STATUS INT
AS
BEGIN
	SELECT * FROM RENTAL_ORDERS WHERE CAR_ID=@CAR_ID
END
GO
/****** Object:  StoredProcedure [dbo].[GET_ORDERS_BY_CAR_ID_AND_STATUS]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.06
-- Description:	根据订单状态获取订单信息
-- =============================================
CREATE PROCEDURE [dbo].[GET_ORDERS_BY_CAR_ID_AND_STATUS]
	@STATUS INT,
	@CAR_ID INT
AS
BEGIN
	SELECT * FROM RENTAL_ORDERS WHERE ORDER_STATUS=@STATUS AND CAR_ID=@CAR_ID
END
GO
/****** Object:  StoredProcedure [dbo].[GET_ORDERS_BY_ID]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.05
-- Description:	根据订单id查询订单
-- =============================================
CREATE PROCEDURE [dbo].[GET_ORDERS_BY_ID] 
	@ID INT
	--,
	--@USER_ID INT, 
	--@CAR_ID INT,
	--@STORE_ID INT,
	--@USER_LEVEL INT,
	--@ORDER_TYPE INT,
	--@START_TIME DATETIME,
	--@END_TIME DATETIME,
	--@ACTUAL_TIME INT,
	--@ORDER_COST DECIMAL,
	--@ORDER_STATUS INT
AS
BEGIN
	SELECT * FROM RENTAL_ORDERS WHERE ID=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[GET_ORDERS_BY_STATUS]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.06
-- Description:	根据订单状态获取订单信息
-- =============================================
CREATE PROCEDURE [dbo].[GET_ORDERS_BY_STATUS]
	@STATUS INT
AS
BEGIN
	SELECT * FROM RENTAL_ORDERS WHERE ORDER_STATUS=@STATUS
END
GO
/****** Object:  StoredProcedure [dbo].[GET_ORDERS_BY_STORE_ID]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.05
-- Description:	根据店铺id查询订单
-- =============================================
CREATE PROCEDURE [dbo].[GET_ORDERS_BY_STORE_ID]
	--@ID INT,
	--@USER_ID INT, 
	--@CAR_ID INT,
	@STORE_ID INT--,
	--@USER_LEVEL INT,
	--@ORDER_TYPE INT,
	--@START_TIME DATETIME,
	--@END_TIME DATETIME,
	--@ACTUAL_TIME INT,
	--@ORDER_COST DECIMAL,
	--@ORDER_STATUS INT
AS
BEGIN
	SELECT * FROM RENTAL_ORDERS WHERE STORE_ID=@STORE_ID
END
GO
/****** Object:  StoredProcedure [dbo].[GET_ORDERS_BY_USER_ID]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.05
-- Description:	根据用户id查询订单
-- =============================================
CREATE PROCEDURE [dbo].[GET_ORDERS_BY_USER_ID] 
	--@ID INT,
	@USER_ID INT--, 
	--@CAR_ID INT,
	--@STORE_ID INT,
	--@USER_LEVEL INT,
	--@ORDER_TYPE INT,
	--@START_TIME DATETIME,
	--@END_TIME DATETIME,
	--@ACTUAL_TIME INT,
	--@ORDER_COST DECIMAL,
	--@ORDER_STATUS INT
AS
BEGIN
	SELECT * FROM RENTAL_ORDERS WHERE [USER_ID]=@USER_ID
END
GO
/****** Object:  StoredProcedure [dbo].[LOG_INSERT]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.03
-- Description:	插入日志信息
-- =============================================
CREATE PROCEDURE [dbo].[LOG_INSERT]
	-- Add the parameters for the stored procedure here
	@ADMINID INT, 
	@USERID INT, 
	@CONTENT VARCHAR(50),
	@LOGTIME DATETIME
	
AS
BEGIN
	INSERT INTO LOG_INFO(ADMINID,USERID,CONTENT,LOGTIME,ISDELETE) VALUES(@ADMINID,@USERID,@CONTENT,@LOGTIME,0)
END
GO
/****** Object:  StoredProcedure [dbo].[MAKE_ORDER]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.05
-- Description:	创建订单
-- =============================================
CREATE PROCEDURE [dbo].[MAKE_ORDER] 
	@USER_ID INT, 
	@CAR_ID INT,
	@STORE_ID INT,
	@USER_LEVEL INT,
	@ORDER_TYPE INT,
	@START_TIME DATETIME,
	@END_TIME DATETIME,
	@ACTUAL_TIME INT,
	@ORDER_COST DECIMAL,
	@ORDER_STATUS INT
AS
BEGIN
	INSERT INTO 
	RENTAL_ORDERS([USER_ID], CAR_ID, STORE_ID, USER_LEVEL, ORDER_TYPE, START_TIME, END_TIME, ACTUAL_TIME, ORDER_COST, ORDER_STATUS)
	        VALUES(@USER_ID,@CAR_ID,@STORE_ID,@USER_LEVEL,@ORDER_TYPE,@START_TIME,@END_TIME,@ACTUAL_TIME,@ORDER_COST,@ORDER_STATUS)
END
GO
/****** Object:  StoredProcedure [dbo].[SELECT_AUDIT_BY_ID]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.04
-- Description:	根据ID获取审核信息
-- =============================================
CREATE PROCEDURE [dbo].[SELECT_AUDIT_BY_ID]
	@ID INT
AS
BEGIN
	SELECT * FROM AUDIT_LIST WHERE ID=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[SELECT_AUDIT_BY_TYPE]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.03
-- Description:	根据审核类型选择待审核信息
-- =============================================
CREATE PROCEDURE [dbo].[SELECT_AUDIT_BY_TYPE]
	@AUDIT_TYPE VARCHAR(20)
AS
BEGIN
	SELECT * FROM AUDIT_LIST WHERE CHECKED=0 AND AUDIT_TYPE=@AUDIT_TYPE
END
GO
/****** Object:  StoredProcedure [dbo].[SELECT_CAR_BY_ID]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.04
-- Description:	获取一辆车的信息
-- =============================================
CREATE PROCEDURE [dbo].[SELECT_CAR_BY_ID]
	@ID INT
AS
BEGIN
	SELECT * FROM CAR_INFO WHERE ID=@ID AND ISDELETE=0
END
GO
/****** Object:  StoredProcedure [dbo].[SELECT_CAR_BY_STORE_ID]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.04
-- Description:	根据店铺id获取车辆信息
-- =============================================
CREATE PROCEDURE [dbo].[SELECT_CAR_BY_STORE_ID]
	@STORE_ID INT
AS
BEGIN
	SELECT * FROM CAR_INFO WHERE STORE_ID=@STORE_ID AND ISDELETE=0
END
GO
/****** Object:  StoredProcedure [dbo].[SELECT_CAR_BY_USER_ID]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.04
-- Description:	根据用户id获取车辆信息
-- =============================================
CREATE PROCEDURE [dbo].[SELECT_CAR_BY_USER_ID]
	@USER_ID INT
AS
BEGIN
	SELECT * FROM CAR_INFO WHERE [USER_ID]=@USER_ID AND ISDELETE=0
END
GO
/****** Object:  StoredProcedure [dbo].[SELECT_CAR_ENABLE]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.05
-- Description:	查询当前可用车辆
-- =============================================
CREATE PROCEDURE [dbo].[SELECT_CAR_ENABLE] 
	@STORE_ID int
AS
BEGIN
	SELECT * FROM CAR_INFO WHERE ISDELETE=0 AND [STATUS]=0 AND STORE_ID=@STORE_ID
END
GO
/****** Object:  StoredProcedure [dbo].[SELECT_COST_RULE_BY_USER_LEVEL]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.05
-- Description:	根据用户等级返回收费规则
-- =============================================
CREATE PROCEDURE [dbo].[SELECT_COST_RULE_BY_USER_LEVEL]
	-- Add the parameters for the stored procedure here
	@USER_LEVEL int = 1
AS
BEGIN
	SELECT * FROM COST_RULE WHERE USER_LEVEL=@USER_LEVEL
END
GO
/****** Object:  StoredProcedure [dbo].[STORE_ADD]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.03
-- Description:	添加商店信息
-- =============================================
CREATE PROCEDURE [dbo].[STORE_ADD]
	@NAME VARCHAR(50),
	@ADDRESS VARCHAR(50)
AS
BEGIN
	INSERT INTO STORE_INFO([NAME],[ADDRESS],IS_DELETE) VALUES(@NAME,@ADDRESS,0)
END
GO
/****** Object:  StoredProcedure [dbo].[STORE_SELECT_BY_ID]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.03
-- Description:	获取店铺信息
-- =============================================
CREATE PROCEDURE [dbo].[STORE_SELECT_BY_ID]
	-- Add the parameters for the stored procedure here
	@ID INT
AS
BEGIN
    -- Insert statements for procedure here
	SELECT * FROM STORE_INFO WHERE ID=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[STORE_UPDATE]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.03
-- Description:	更新商店信息
-- =============================================
CREATE PROCEDURE [dbo].[STORE_UPDATE]
	@ID INT,
	@NAME VARCHAR(50),
	@ADDRESS VARCHAR(200)
AS
BEGIN
	UPDATE STORE_INFO SET [NAME]=@NAME, [ADDRESS]=@ADDRESS WHERE ID=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[UPDATE_COST_RULE]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.05
-- Description:	更新收费规则
-- =============================================
CREATE PROCEDURE [dbo].[UPDATE_COST_RULE]
	@ID INT,
	@USER_LEVEL  INT,
	@HOUR_COST   DECIMAL,
	@DAY_COST    DECIMAL,
	@WEEK_COST   DECIMAL,
	@MONTH_COST  DECIMAL,
	@SEASON_COST DECIMAL,
	@YEAR_COST   DECIMAL
AS
BEGIN
	UPDATE COST_RULE SET
	USER_LEVEL=@USER_LEVEL,
	HOUR_COST=@HOUR_COST,
	DAY_COST=@DAY_COST,
	WEEK_COST=@WEEK_COST,
	MONTH_COST=@MONTH_COST,
	SEASON_COST=@SEASON_COST,
	YEAR_COST=@YEAR_COST 
	WHERE ID=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[UPDATE_ORDER]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.05
-- Description:	修改订单
-- =============================================
CREATE PROCEDURE [dbo].[UPDATE_ORDER] 
	@ID INT,
	@USER_ID INT, 
	@CAR_ID INT,
	@STORE_ID INT,
	@USER_LEVEL INT,
	@ORDER_TYPE INT,
	@START_TIME DATETIME,
	@END_TIME DATETIME,
	@ACTUAL_TIME INT,
	@ORDER_COST DECIMAL,
	@ORDER_STATUS INT
AS
BEGIN
	UPDATE RENTAL_ORDERS SET
	[USER_ID]=@USER_ID, 
	CAR_ID=@CAR_ID, 
	STORE_ID=@STORE_ID, 
	USER_LEVEL=@USER_LEVEL, 
	ORDER_TYPE=@ORDER_TYPE, 
	START_TIME=@START_TIME, 
	END_TIME=@END_TIME, 
	ACTUAL_TIME=@ACTUAL_TIME, 
	ORDER_COST=@ORDER_COST, 
	ORDER_STATUS=@ORDER_STATUS
	WHERE ID=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[USER_ADD]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.05.30
-- Description:	录入一个用户
-- =============================================
CREATE PROCEDURE [dbo].[USER_ADD]
	-- Add the parameters for the stored procedure here
	@NAME VARCHAR(50),
	@PWD VARCHAR(50),
	@PAYPWD VARCHAR(50),
	@REALNAME VARCHAR(50),
	@PHONE VARCHAR(50),
	@ADDRESS VARCHAR(200),
	@IDENTITY VARCHAR(50),
	@DRILICENSE VARCHAR(50),
	@GENDER TINYINT
AS
    -- Insert statements for procedure here
	INSERT INTO USER_INFO([NAME],[PWD],PAYPWD,REALNAME,PHONE,[ADDRESS],[IDENTITY],DRILICENSE,GENDER,REMAINMONEY,USERLEVEL,ISDELETE) VALUES(@NAME,@PWD,@PAYPWD,@REALNAME,@PHONE,@ADDRESS,@IDENTITY,@DRILICENSE,@GENDER,0,1,0)
GO
/****** Object:  StoredProcedure [dbo].[USER_SELECT_BY_ID]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.06
-- Description:	根据用户ID返回用户信息
-- =============================================
CREATE PROCEDURE [dbo].[USER_SELECT_BY_ID]
	@ID INT
AS
BEGIN
	SELECT * FROM USER_INFO WHERE ISDELETE=0 AND ID=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[USER_SELECT_BY_NAME]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.05.30
-- Description:	根据用户名取出用户信息
-- =============================================
CREATE PROCEDURE [dbo].[USER_SELECT_BY_NAME]
	-- Add the parameters for the stored procedure here
	@NAME VARCHAR(50)
AS
BEGIN
    -- Insert statements for procedure here
	SELECT * FROM USER_INFO WHERE [NAME] =@NAME
END
GO
/****** Object:  StoredProcedure [dbo].[USER_SELECT_BY_NAME_AND_PWD]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.06.04
-- Description:	根据用户名和密码获取用户信息
-- =============================================
CREATE PROCEDURE [dbo].[USER_SELECT_BY_NAME_AND_PWD]
	-- Add the parameters for the stored procedure here
	@NAME VARCHAR(50), 
	@PWD VARCHAR(50)
AS
BEGIN
	SELECT * FROM USER_INFO WHERE ISDELETE=0 AND [NAME]=@NAME AND PWD=@PWD
END
GO
/****** Object:  StoredProcedure [dbo].[USER_UPDATE]    Script Date: 2020/6/6 18:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		高凯楠
-- Create date: 2020.05.30
-- Description:	修改一个用户的信息
-- =============================================
CREATE PROCEDURE [dbo].[USER_UPDATE]
	-- Add the parameters for the stored procedure here
	@ID INT,
	@NAME VARCHAR(50),
	@PWD VARCHAR(50),
	@PAYPWD VARCHAR(50),
	@REALNAME VARCHAR(50),
	@PHONE VARCHAR(50),
	@ADDRESS VARCHAR(200),
	@IDENTITY VARCHAR(50),
	@DRILICENSE VARCHAR(50),
	@GENDER TINYINT,
	@REMAINMONEY DECIMAL(18,2),
	@USERLEVEL INT,
	@PHOTO IMAGE
	
AS
    -- Insert statements for procedure here
	UPDATE USER_INFO SET 
	[NAME]=@NAME,
	[PWD]=@PWD,
	PAYPWD=@PAYPWD,
	REALNAME=@REALNAME,
	PHONE=@PHONE,
	[ADDRESS]=@ADDRESS,
	[IDENTITY]=@IDENTITY,
	DRILICENSE=@DRILICENSE,
	GENDER=@GENDER,
	REMAINMONEY=@REMAINMONEY,
	USERLEVEL=@USERLEVEL,
	PHOTO=@PHOTO
	WHERE ID=@ID
GO
USE [master]
GO
ALTER DATABASE [CarRentalSystem] SET  READ_WRITE 
GO
