CREATE PROCEDURE [dbo].[spGetComponentWithName]
	@name nvarchar(50)
AS
begin
	select *
	from ElectronicComponents
	where [Name] = @name
end

