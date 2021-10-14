CREATE PROCEDURE [dbo].[spGetProblemAndSolutionIdByProblem]
	@Problem nvarchar(50)
AS
begin
	select *
	from ProblemAndSolutionTable
	where Problem = @Problem
end
