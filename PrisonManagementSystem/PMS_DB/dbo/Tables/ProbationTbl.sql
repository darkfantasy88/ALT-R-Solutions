CREATE TABLE [dbo].[ProbationTbl]
(
	[ProbationID] INT NOT NULL PRIMARY KEY,
	[FirstName] varchar(150) not null,
	[LastName] varchar(150) not null,
	[DOB] datetime2 not null,
	[StaffID] varchar(12) NOT NULL foreign key references StaffTbl,
	[ProbationStartDate] datetime2 not null,
	[ProbationEndDate] datetime2 not null,
	[Suspended] bit null default 0,
	[SupensionDate] datetime2 null,
	[Revoked] bit null default 0,
	[RevokedDate] datetime2 null,
	[Violation] bit not null default 0,
	[ViolationDetails] varchar(max) null,
	[Notes] varchar(max) null

)
