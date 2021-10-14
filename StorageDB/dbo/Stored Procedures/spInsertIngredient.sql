CREATE PROCEDURE [dbo].[spInsertIngredient]
	@IngredientName nvarchar(50),
	@IngredientURL nvarchar(50)
AS
begin
	insert into IngredientsTable (IngredientName, IngredientURL)
	values (@IngredientName, @IngredientURL)
end