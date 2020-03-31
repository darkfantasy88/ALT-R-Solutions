CREATE TABLE [dbo].[PrisonerTbl]
(
	[PrisonerID] INT NOT NULL PRIMARY KEY,
	[FirstName] varchar(150) not null,
	[LastName] varchar(150) not null,
	[Gender] varchar(150) not null check(Gender='Male' or Gender='Female'),
	[DOB] datetime2 not null,
	[PrisonID] varchar(10) not null,
	[FingerPrint] varbinary(max) not null,
	[DateOfConviction] datetime2 not null,
	[ConvictionID] int not null,
	[TimeServed] float not null,
	[Photo] varbinary(max) not null,
	[PrisonerType] varchar(max) not null,
	[RehabPrograms] varchar(max) null

)
