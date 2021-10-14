CREATE TABLE [dbo].[CraftingTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [ResultName] NVARCHAR(50) NOT NULL, 
    [ResultURL] NVARCHAR(50) NOT NULL, 
    [ListOfIngredientName] NVARCHAR(500) NOT NULL, 
    [CraftingName] NVARCHAR(50) NOT NULL, 
    [CraftingURL] NVARCHAR(50) NOT NULL
)
