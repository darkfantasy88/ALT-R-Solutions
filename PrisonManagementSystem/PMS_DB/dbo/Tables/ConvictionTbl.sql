CREATE TABLE [dbo].[ConvictionTbl]
(
	[ConvictionID] INT identity(1,1) NOT NULL PRIMARY KEY,
	[ConvictionType] varchar(12) not null,
	[ConvictionProbationPeriod] int not null,
	[ConvictionName] varchar(max) not null,
	[ConvictionPeriod] int not null
)
