CREATE TABLE [dbo].[ProbationOfficeTbl]
(
	[ProbationOfficeID] int not null PRIMARY KEY,
	[Location] varchar(max) not null,
	[Region] varchar(10) not null,
	[Name] varchar(max) not null,
	[PhoneNumber] int not null
)
