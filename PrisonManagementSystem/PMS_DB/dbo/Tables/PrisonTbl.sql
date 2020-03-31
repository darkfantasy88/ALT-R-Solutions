CREATE TABLE [dbo].[PrisonTbl]
(
	[PrisonID] varchar(10) NOT NULL PRIMARY KEY,
	[Name] varchar(max) not null,
	[Location] varchar(max) not null,
	[History] varchar(max) not null,
	[Image] varbinary(max) null,
	[MaxCapacity] int not null,
	[CurrentCapacity] int not null,
	[PrisonType] varchar(100) not null
)
