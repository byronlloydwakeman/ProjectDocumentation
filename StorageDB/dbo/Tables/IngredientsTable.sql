CREATE TABLE [dbo].[IngredientsTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [IngredientName] NVARCHAR(50) NOT NULL, 
    [IngredientURL] NVARCHAR(50) NULL
)
