CREATE PROCEDURE [dbo].[spGetIngredientIdByName]
	@IngredientName nvarchar(50)
AS
begin
	select *
	from IngredientsTable
	where IngredientName = @IngredientName
end
