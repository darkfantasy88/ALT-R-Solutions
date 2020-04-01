CREATE TABLE [dbo].[StaffTbl]
(
	[StaffID] varchar(12) NOT NULL PRIMARY KEY,
	[FirstName] varchar(150) not null,
	[LastName] varchar(150) not null,
	[MiddleInitial] varchar(1) null,
	[Gender] varchar(7) not null,
	[DOB] datetime2 not null,
	[StaffType] varchar(15) not null,
	[StaffRole] varchar(50) not null,
	[ProbationOfficeID] int null foreign key references ProbationOfficeTbl,
	[PrisonID] varchar(10)null foreign key references PrisonTbl,
	[HeadOffice] bit null default 1,
	[Active] bit null default 0,
	[Deleted] bit null default 0
)
