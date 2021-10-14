CREATE PROCEDURE [dbo].[spInsertProjectFormat]
	@Complete bit,
	@ResultName nvarchar(50), 
	@Trivia nvarchar(MAX),
	@Log nvarchar(MAX),
	@NextToDo nvarchar(MAX),
	@ListOfProblemName nvarchar(500)
AS
begin
	insert into ProjectFormatTable (Complete, ResultName, Trivia, [Log], NextToDo, ListOfProblemName)
	values (@Complete, @ResultName, @Trivia, @Log, @NextToDo, @ListOfProblemName)
end
