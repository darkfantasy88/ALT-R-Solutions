CREATE TABLE [dbo].[AuthTbl]
(
	[AuthID] INT IDENTITY(1,2) NOT NULL CONSTRAINT PK_AUTHTBL PRIMARY KEY,
	[EmailAddress] varchar(200) not null constraint CHK_EMAIL check ([EmailAddress] like '%_@__%.__%'),
	[Password] varbinary(max) not null,
    [StaffID] varchar(12) not null foreign key references StaffTbl([StaffID]),
	[Deleted] bit null default 0
);


