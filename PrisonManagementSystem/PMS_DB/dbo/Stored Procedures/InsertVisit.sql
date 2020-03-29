CREATE PROCEDURE [dbo].[InsertVisit]
	@trn int,
	@institution varchar(max),
	@coordinator varchar(max),
	@coordinatornum int,
	@mobile varchar(10),
	@work varchar(10),
	@firstname varchar(150),
	@lastname varchar(150),
	@gender varchar(7),
	@dob datetime2,
	@occupation varchar(max),
	@residential varchar(max),
	@postal varchar(max),
	@email varchar(250),
	@prisonname varchar(max),
	@purpose varchar(max),
	@image varbinary(max),
	@prisonerid int,
	@relationship varchar(max)
AS
begin try
	insert into VisitorTbl (TRN,InstitutionName,CoordinatorName,CoordinatorNumber
							,MobileNumber,WorkNumber,FirstName,LastName,Gender,
							DOB,Occupation,ResidentialAddress,PostalAddress,
							EmailAddress,PrisonName,PurposeOfVisit,VisitorImage,
							PrisonerID,Relationship)
				values (@trn,@institution,@coordinator,@coordinatornum,
						@mobile,@work,@firstname,@lastname,@gender,@dob,
						@occupation,@residential,@postal,@email,@prisonname,
						@purpose,@image,@prisonerid,@relationship)

end try
begin catch
 throw;
end catch

