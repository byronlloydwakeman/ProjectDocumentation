CREATE TABLE [dbo].[ProblemAndSolutionTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [Problem] NVARCHAR(50) NOT NULL, 
    [PotentialSolution] NVARCHAR(50) NOT NULL, 
    [PlanForSolution] NVARCHAR(50) NOT NULL, 
    [Conclusion] NVARCHAR(50) NOT NULL, 
    [UltimateSolution] NVARCHAR(50) NOT NULL
)
