
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/14/2020 20:27:14
-- Generated from EDMX file: C:\Users\bianc\OneDrive\Desktop\TSP.Net\P1\MyPhotos\MyPhotos\ModelBD.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyPhotos];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Photos'
CREATE TABLE [dbo].[Photos] (
    [PhotoId] int IDENTITY(1,1) NOT NULL,
    [Path] nvarchar(max)  NOT NULL,
    [Data_creare] datetime  NOT NULL,
    [Descriere] nvarchar(max)  NOT NULL,
    [Deleted] bit  NOT NULL
);
GO

-- Creating table 'Proprietati'
CREATE TABLE [dbo].[Proprietati] (
    [ProprietateId] int IDENTITY(1,1) NOT NULL,
    [NumeProprietate] nvarchar(max)  NOT NULL,
    [ValoareProprietate] nvarchar(max)  NOT NULL,
    [PhotoPhotoId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [PhotoId] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [PK_Photos]
    PRIMARY KEY CLUSTERED ([PhotoId] ASC);
GO

-- Creating primary key on [ProprietateId] in table 'Proprietati'
ALTER TABLE [dbo].[Proprietati]
ADD CONSTRAINT [PK_Proprietati]
    PRIMARY KEY CLUSTERED ([ProprietateId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PhotoPhotoId] in table 'Proprietati'
ALTER TABLE [dbo].[Proprietati]
ADD CONSTRAINT [FK_PhotoProprietate]
    FOREIGN KEY ([PhotoPhotoId])
    REFERENCES [dbo].[Photos]
        ([PhotoId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotoProprietate'
CREATE INDEX [IX_FK_PhotoProprietate]
ON [dbo].[Proprietati]
    ([PhotoPhotoId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------