CREATE PROCEDURE [dbo].[AddStaff]
	@id varchar(10),
	@firstname varchar(150),
	@lastname varchar(150),
	@middle varchar(1),
	@gender varchar(7),
	@password varchar(max),
	@email varchar(max),
	@dob datetime2,
	@type varchar(15),
	@role varchar(50),
	@officeid int,
	@prisonid int,
	@hoffice bit,
	@active bit
as
begin
begin try 
	insert into StaffTbl(StaffID,FirstName,LastName,MiddleInitial
						,DOB,StaffType,StaffRole,ProbationOfficeID,
						PrisonID,HeadOffice,Active,Gender)
				values(@id,@firstname,@lastname,@middle,@dob,@type,
						@role,@officeid,@prisonid,@hoffice,@active,@gender);
	insert into AuthTbl(EmailAddress,[Password],StaffID)
				values(@email,CONVERT(varbinary(max),@password),@id);
end try
begin catch
throw;
end catch
end;