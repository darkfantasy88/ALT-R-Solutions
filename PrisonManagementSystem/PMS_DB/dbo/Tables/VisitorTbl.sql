﻿CREATE TABLE [dbo].[VisitorTbl]
(
	[VisitID] INT IDENTITY(1,2) NOT NULL CONSTRAINT PK_VISITORTBL PRIMARY KEY,
	[TRN] int null,
	[InstitutionName] varchar(max) null,
	[CoordinatorName] varchar(max),
	[CoordinatorNumber] INT,
	[MobileNumber] varchar(10) null,
	[WorkNumber] varchar(10) null,
	[FirstName] varchar(150) null,
	[LastName] varchar(150) null,
	[Gender] varchar(7) null,
	[DOB] datetime2 null,
	[Occupation] varchar(Max),
	[ResidentialAddress] varchar(max) null,
	[PostalAddress] varchar(max) null,
	[EmailAddress] varchar(250) null check(EmailAddress like '%_@__%.__%'),
	[PrisonName] varchar(250) not null,
	[PurposeOfVisit] varchar(max) not null,
	[VisitorImage] varbinary(max) null,
	[ValidIDType] varchar(100) null,
	[ValidIDDateOfExpiry] datetime2 null,
	[ValidIDNumber] varchar(20) null,
	[PrisonerID] int null,
	[Relationship] varchar(max) null,
	[VisitStatus] varchar(max) NOT null check(VisitStatus='Approved' or VisitStatus='Declined' or VisitStatus='Deferred' or VisitStatus='Pending') DEFAULT 'Pending',
	[ApprovedDateOfVisit] datetime2 null,
	[Deleted] bit not null default 0
)
