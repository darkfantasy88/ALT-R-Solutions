CREATE TABLE [dbo].[ProbationTbl]
(
	[ProbationID] INT NOT NULL PRIMARY KEY,
	[FirstName] varchar(150) not null,
	[LastName] varchar(150) not null,
	[DOB] datetime2 not null,
	[StaffID] varchar(10) NOT NULL,
	[ProbationStartDate] datetime2 not null,
	[ProbationEndDate] datetime2 not null,
	[Violation] bit not null default 0,
	[Notes] varchar(max) not null

)
