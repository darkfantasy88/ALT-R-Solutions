﻿CREATE TABLE [dbo].[MedicalTbl]
(
	[MedicalID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Deleted] BIT NULL DEFAULT 0
)
