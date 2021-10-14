CREATE PROCEDURE [dbo].[spGetCraftingIdByResultName]
	@ResultName nvarchar(50)
AS
begin
	select *
	from CraftingTable
	where ResultName = @ResultName
end
