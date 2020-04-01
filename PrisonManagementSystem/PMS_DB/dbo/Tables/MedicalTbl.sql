CREATE TABLE [dbo].[MedicalTbl]
(
	[MedicalID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	[PrisonerID] int Not null foreign key references PrisonerTbl, 
	[StaffID] varchar(12) not null foreign key references StaffTbl, 
	[PhysicalDefect] nvarchar(max) not null, 
	[MentalHealthStatus] nvarchar(max) not null, 
	[MentalHealthDetails] nvarchar(max) not null, 
	[Height] float not null, 
	[Weight] float not null, 
	[DrugTestStatus]nvarchar(max) not null, 
	[DrugTestDetails] nvarchar(max) not null,
	[BloodTest]nvarchar(max)  null, 
	[BloodResults]nvarchar(max) null, 
	[Allergies] nvarchar(max)  null, 
	[LastCheckup] datetime2 not null,
	[DoctorNotes]nvarchar(max)  null, 
	[PurposeofVisit]nvarchar(max) not null, 
	[MedicationRequired] nvarchar(max) not null, 
    [Deleted] BIT NULL DEFAULT 0
	
)
