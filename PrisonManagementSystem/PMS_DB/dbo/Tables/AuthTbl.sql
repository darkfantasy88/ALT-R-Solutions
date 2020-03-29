CREATE TABLE [dbo].[AuthTbl]
(
	[AuthID] INT IDENTITY(1,2) NOT NULL CONSTRAINT PK_AUTHTBL PRIMARY KEY,
	[FirstName] varchar(150) not null,
	[LastName] varchar(150) not null,
	[Gender] varchar(7) not null constraint CHK_GENDER check(Gender='Male' or Gender='Female'),
	[Role] varchar(250) not null,
	[EmailAddress] varchar(200) not null constraint CHK_EMAIL check ([EmailAddress] like '%_@__%.__%'),
	[Password] varbinary(max) not null,
	[Deleted] bit not null default 0
);


