CREATE TABLE [dbo].[StaffTbl]
(
	[StaffID] varchar(10) NOT NULL PRIMARY KEY,
	[FirstName] varchar(150) not null,
	[LastName] varchar(150) not null,
	[MiddleInitial] varchar(1) null,
	[DOB] datetime2 not null,
	[StaffType] varchar(15) not null,
	[StaffRole] varchar(50) not null,
	[ProbationOfficeID] int null,
	[PrisonID] varchar(10)null,
	[HeadOffice] bit null default 1,
	[Active] bit null default 0
)
