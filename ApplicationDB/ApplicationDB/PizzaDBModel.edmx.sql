
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/08/2016 23:42:43
-- Generated from EDMX file: C:\Users\User\Documents\Visual Studio 2015\Projects\ApplicationDB\ApplicationDB\PizzaDBModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PizzaDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Orders_ToDeliverys]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_Orders_ToDeliverys];
GO
IF OBJECT_ID(N'[dbo].[FK_Orders_ToOrdersStatus]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_Orders_ToOrdersStatus];
GO
IF OBJECT_ID(N'[dbo].[FK_Orders_ToPizzas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_Orders_ToPizzas];
GO
IF OBJECT_ID(N'[dbo].[FK_Orders_ToUsers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_Orders_ToUsers];
GO
IF OBJECT_ID(N'[dbo].[FK_Pizzas_ToSize]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pizzas] DROP CONSTRAINT [FK_Pizzas_ToSize];
GO
IF OBJECT_ID(N'[dbo].[FK_Users_ToRoles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_Users_ToRoles];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Deliverys]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Deliverys];
GO
IF OBJECT_ID(N'[dbo].[Orders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Orders];
GO
IF OBJECT_ID(N'[dbo].[OrdersStatus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrdersStatus];
GO
IF OBJECT_ID(N'[dbo].[Pizzas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pizzas];
GO
IF OBJECT_ID(N'[dbo].[Roles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Roles];
GO
IF OBJECT_ID(N'[dbo].[Sizes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sizes];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Deliverys'
CREATE TABLE [dbo].[Deliverys] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Orders'
CREATE TABLE [dbo].[Orders] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] nvarchar(50)  NOT NULL,
    [User] int  NOT NULL,
    [State] int  NOT NULL,
    [Address] nvarchar(50)  NOT NULL,
    [Pizza] int  NOT NULL,
    [Cost] decimal(19,4)  NOT NULL,
    [TypeDelivery] int  NOT NULL
);
GO

-- Creating table 'OrdersStatus'
CREATE TABLE [dbo].[OrdersStatus] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Pizzas'
CREATE TABLE [dbo].[Pizzas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Size] int  NOT NULL,
    [Count] int  NOT NULL,
    [Price] decimal(19,4)  NOT NULL,
    [Describe] nvarchar(max)  NULL
);
GO

-- Creating table 'Roles'
CREATE TABLE [dbo].[Roles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(25)  NOT NULL
);
GO

-- Creating table 'Sizes'
CREATE TABLE [dbo].[Sizes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Diameter] int  NOT NULL,
    [Coefficient] float  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Login] nvarchar(20)  NOT NULL,
    [Password] nvarchar(20)  NOT NULL,
    [Name] nvarchar(20)  NOT NULL,
    [Surname] nvarchar(15)  NOT NULL,
    [Number] nvarchar(15)  NOT NULL,
    [Email] nvarchar(50)  NOT NULL,
    [Address] nvarchar(50)  NOT NULL,
    [Role] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Deliverys'
ALTER TABLE [dbo].[Deliverys]
ADD CONSTRAINT [PK_Deliverys]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [PK_Orders]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OrdersStatus'
ALTER TABLE [dbo].[OrdersStatus]
ADD CONSTRAINT [PK_OrdersStatus]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pizzas'
ALTER TABLE [dbo].[Pizzas]
ADD CONSTRAINT [PK_Pizzas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [PK_Roles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sizes'
ALTER TABLE [dbo].[Sizes]
ADD CONSTRAINT [PK_Sizes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TypeDelivery] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_Orders_ToDeliverys]
    FOREIGN KEY ([TypeDelivery])
    REFERENCES [dbo].[Deliverys]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Orders_ToDeliverys'
CREATE INDEX [IX_FK_Orders_ToDeliverys]
ON [dbo].[Orders]
    ([TypeDelivery]);
GO

-- Creating foreign key on [State] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_Orders_ToOrdersStatus]
    FOREIGN KEY ([State])
    REFERENCES [dbo].[OrdersStatus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Orders_ToOrdersStatus'
CREATE INDEX [IX_FK_Orders_ToOrdersStatus]
ON [dbo].[Orders]
    ([State]);
GO

-- Creating foreign key on [Pizza] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_Orders_ToPizzas]
    FOREIGN KEY ([Pizza])
    REFERENCES [dbo].[Pizzas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Orders_ToPizzas'
CREATE INDEX [IX_FK_Orders_ToPizzas]
ON [dbo].[Orders]
    ([Pizza]);
GO

-- Creating foreign key on [User] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_Orders_ToUsers]
    FOREIGN KEY ([User])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Orders_ToUsers'
CREATE INDEX [IX_FK_Orders_ToUsers]
ON [dbo].[Orders]
    ([User]);
GO

-- Creating foreign key on [Size] in table 'Pizzas'
ALTER TABLE [dbo].[Pizzas]
ADD CONSTRAINT [FK_Pizzas_ToSize]
    FOREIGN KEY ([Size])
    REFERENCES [dbo].[Sizes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Pizzas_ToSize'
CREATE INDEX [IX_FK_Pizzas_ToSize]
ON [dbo].[Pizzas]
    ([Size]);
GO

-- Creating foreign key on [Role] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_Users_ToRoles]
    FOREIGN KEY ([Role])
    REFERENCES [dbo].[Roles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Users_ToRoles'
CREATE INDEX [IX_FK_Users_ToRoles]
ON [dbo].[Users]
    ([Role]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------