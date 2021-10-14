CREATE PROCEDURE [dbo].[spInsertProblemAndSolution]
	@Problem nvarchar(50),
	@PotentialSolution nvarchar(50),
	@PlanForSolution nvarchar(500),
	@Conclusion nvarchar(500),
	@UltimateSolution nvarchar(500)
AS
begin
	insert into ProblemAndSolutionTable (Problem, PotentialSolution, PlanForSolution, Conclusion, UltimateSolution)
	values (@Problem, @PotentialSolution, @PlanForSolution, @Conclusion, @UltimateSolution)
end
