CREATE PROCEDURE [dbo].[spInsertCrafting]
	@ResultName nvarchar(50),
	@ResultURL nvarchar(50),
	@ListOfIngredientName nvarchar(500),
	@CraftingName nvarchar(50),
	@CraftingURL nvarchar(50)
AS
begin
	insert into CraftingTable (ResultName, ResultURL, ListOfIngredientName, CraftingName, CraftingURL)
	values (@ResultName, @ResultURL, @ListOfIngredientName, @CraftingName, @CraftingURL)
end
