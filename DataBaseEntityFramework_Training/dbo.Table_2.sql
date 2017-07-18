CREATE TABLE [dbo].[Person]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] NCHAR(50) NOT NULL, 
    [LastName] NCHAR(50) NOT NULL, 
    [Address] NCHAR(50) NULL, 
    [BirthDate] NCHAR(50) NOT NULL, 
    [Email] NCHAR(50) NULL
)
