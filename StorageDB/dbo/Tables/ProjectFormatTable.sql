CREATE TABLE [dbo].[ProjectFormatTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [Complete] BIT NULL, 
    [ResultName] INT NULL, 
    [Trivia] NVARCHAR(MAX) NULL, 
    [Log] NVARCHAR(MAX) NULL, 
    [NextToDo] NVARCHAR(MAX) NULL, 
    [ListOfProblemName] NVARCHAR(500) NULL
)
