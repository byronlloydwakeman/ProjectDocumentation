CREATE TABLE [dbo].[ElectronicComponents]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    [Location] NVARCHAR(50) NOT NULL, 
    [Quantity] INT NOT NULL, 
    [Specification] NVARCHAR(100) NOT NULL, 
    [Name] NVARCHAR(50) NOT NULL
)
